
using CtlLibraryBindings;

var disposable = new CompositeDisposable();
var apiHandle = GetApiHandle( disposable );

using ( disposable )
{
    var devices = GetDeviceHandles( disposable, apiHandle );

    // SET SPEED

    var speed = new ctl_fan_speed_t
    {
        speed = 50,
        units = ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT,
        // version?
    }.DisposeWith( disposable );

    var fanHandles = GetFanHandles( devices, disposable ).ToArray();

    foreach ( var fan in fanHandles )
    {
        CtlLibrary.ctlFanSetFixedSpeedMode( fan, speed ).ThrowIfError( $"Set fixed fan speed to {speed.speed}" );
    }

    Console.WriteLine( "Waiting for 10 seconds for fan speed to increase" );
    await Task.Delay( TimeSpan.FromSeconds( 10 ) );

    // GET SPEED
    foreach ( var fan in fanHandles )
    {
        GetSpeed( disposable, fan );
    }

    // GET TEMPERATURE
    foreach ( var device in devices )
    {
        GetTemperatures( disposable, device );
    }

    // RESET TO DEFAULT
    foreach ( var fan in fanHandles )
    {
        CtlLibrary.ctlFanSetDefaultMode( fan ).ThrowIfError( "Set default fan speed" );
    }
}

// CLOSE
CtlLibrary.ctlClose( apiHandle ).ThrowIfError( "Close" );

static IEnumerable<SWIGTYPE_p__ctl_fan_handle_t> GetFanHandles( SWIGTYPE_p__ctl_device_adapter_handle_t[] devices, CompositeDisposable disposable )
{
    var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith( disposable, CtlLibrary.delete_unsigned_int_Ptr );
    foreach ( var handle in devices )
    {
        var arrayPtr = CtlLibrary.new_ctl_fan_handle_t_PtrPtr().DisposeWith( disposable, CtlLibrary.delete_ctl_fan_handle_t_PtrPtr );
        var fanHandles = CtlLibrary.ctlEnumFans( handle, uintPtr, arrayPtr );

        var fanArray = FanHandleArray.frompointer( arrayPtr );

        foreach ( var fan in Enumerable.Range( 0, Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value( uintPtr ) ) ).Select( fanArray.getitem ) )
        {
            yield return fan;
        }
    }
}

static SWIGTYPE_p__ctl_api_handle_t GetApiHandle( CompositeDisposable disposable )
{
    ctl_init_args_t initArgs = CtlLibrary.create_Init_Args().DisposeWith( disposable );
    var handlePtr = CtlLibrary.new_ctl_api_handle_t_PtrPtr().DisposeWith( disposable, CtlLibrary.delete_ctl_api_handle_t_PtrPtr );

    CtlLibrary.ctlInit( initArgs, handlePtr ).ThrowIfError( "Init" );
    var apiHandle = CtlLibrary.ctl_api_handle_t_PtrPtr_value( handlePtr );
    return apiHandle;
}

static SWIGTYPE_p__ctl_device_adapter_handle_t[] GetDeviceHandles( CompositeDisposable disposable, SWIGTYPE_p__ctl_api_handle_t apiHandle )
{
    var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith( disposable, CtlLibrary.delete_unsigned_int_Ptr );
    var deviceArrayPtr = CtlLibrary.new_ctl_device_adapter_handle_t_PtrPtr().DisposeWith( disposable, CtlLibrary.delete_ctl_device_adapter_handle_t_PtrPtr );
    CtlLibrary.ctlEnumerateDevices( apiHandle, uintPtr, deviceArrayPtr ).ThrowIfError( "Enumerate" );

    var array = DeviceAdapterHandleArray.frompointer( deviceArrayPtr );
    var n = CtlLibrary.unsigned_int_Ptr_value( uintPtr );
    var devices = Enumerable.Range( 0, Convert.ToInt32( n ) ).Select( array.getitem ).ToArray();
    return devices;
}


static void GetSpeed( CompositeDisposable disposable, SWIGTYPE_p__ctl_fan_handle_t? fan )
{
    var speedRequestPtr = CtlLibrary.new_int_Ptr().DisposeWith( disposable, CtlLibrary.delete_int_Ptr );
    CtlLibrary.ctlFanGetState( fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT, speedRequestPtr ).ThrowIfError( "Get fan % speed" );
    var fanSpeed = CtlLibrary.int_Ptr_value( speedRequestPtr );
    Console.WriteLine( $"Fan speed: {fanSpeed}" );
    // do the same for rpm

    CtlLibrary.ctlFanGetState( fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_RPM, speedRequestPtr ).ThrowIfError( "Get fan RPM speed" );
    var fanRpm = CtlLibrary.int_Ptr_value( speedRequestPtr );
    Console.WriteLine( $"Fan RPM: {fanRpm}" );
}

static void GetTemperatures( CompositeDisposable disposable, SWIGTYPE_p__ctl_device_adapter_handle_t device )
{
    var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith( disposable, CtlLibrary.delete_unsigned_int_Ptr );
    var tempArrayPtr = CtlLibrary.new_ctl_temp_handle_t_PtrPtr().DisposeWith( disposable, CtlLibrary.delete_ctl_temp_handle_t_PtrPtr );
    CtlLibrary.ctlEnumTemperatureSensors( device, uintPtr, tempArrayPtr ).ThrowIfError( "Enumerate temperature sensors" );

    var tempArray = TempHandleArray.frompointer( tempArrayPtr );
    var tempHandles = Enumerable.Range( 0, Convert.ToInt32( CtlLibrary.unsigned_int_Ptr_value( uintPtr ) ) ).Select( tempArray.getitem ).ToArray();

    foreach ( var temp in tempHandles )
    {
        var properties = new ctl_temp_properties_t().DisposeWith( disposable );
        CtlLibrary.ctlTemperatureGetProperties( temp, properties ).ThrowIfError( "Get temperature" );

        Console.WriteLine( $"Temperature sensor: type {properties.type}" );

        var doublePtr = CtlLibrary.new_double_Ptr().DisposeWith( disposable, CtlLibrary.delete_double_Ptr );
        CtlLibrary.ctlTemperatureGetState( temp, doublePtr ).ThrowIfError( "Get temperature" );
        var temperature = CtlLibrary.double_Ptr_value( doublePtr );

        Console.WriteLine( $"Temperature: {temperature}" );
    }
}