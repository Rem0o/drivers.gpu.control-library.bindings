
using CtlApiBindings;

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
        CtlApi.ctlFanSetFixedSpeedMode( fan, speed ).ThrowIfError( $"Set fixed fan speed to {speed.speed}" );
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
        CtlApi.ctlFanSetDefaultMode( fan ).ThrowIfError( "Set default fan speed" );
    }
}

// CLOSE
CtlApi.ctlClose( apiHandle ).ThrowIfError( "Close" );

static IEnumerable<SWIGTYPE_p__ctl_fan_handle_t> GetFanHandles( SWIGTYPE_p__ctl_device_adapter_handle_t[] devices, CompositeDisposable disposable )
{
    var uintPtr = CtlApi.new_unsigned_int_Ptr().DisposeWith( disposable, CtlApi.delete_unsigned_int_Ptr );
    foreach ( var handle in devices )
    {
        var arrayPtr = CtlApi.new_ctl_fan_handle_t_PtrPtr().DisposeWith( disposable, CtlApi.delete_ctl_fan_handle_t_PtrPtr );
        var fanHandles = CtlApi.ctlEnumFans( handle, uintPtr, arrayPtr );

        var fanArray = FanHandleArray.frompointer( arrayPtr );

        foreach ( var fan in Enumerable.Range( 0, Convert.ToInt32( CtlApi.unsigned_int_Ptr_value( uintPtr ) ) ).Select( fanArray.getitem ) )
        {
            yield return fan;
        }
    }
}

static SWIGTYPE_p__ctl_api_handle_t GetApiHandle( CompositeDisposable disposable )
{
    ctl_init_args_t initArgs = CtlApi.create_Init_Args().DisposeWith( disposable );
    var handlePtr = CtlApi.new_ctl_api_handle_t_PtrPtr().DisposeWith( disposable, CtlApi.delete_ctl_api_handle_t_PtrPtr );

    CtlApi.ctlInit( initArgs, handlePtr ).ThrowIfError( "Init" );
    var apiHandle = CtlApi.ctl_api_handle_t_PtrPtr_value( handlePtr );
    return apiHandle;
}

static SWIGTYPE_p__ctl_device_adapter_handle_t[] GetDeviceHandles( CompositeDisposable disposable, SWIGTYPE_p__ctl_api_handle_t apiHandle )
{
    var uintPtr = CtlApi.new_unsigned_int_Ptr().DisposeWith( disposable, CtlApi.delete_unsigned_int_Ptr );
    var deviceArrayPtr = CtlApi.new_ctl_device_adapter_handle_t_PtrPtr().DisposeWith( disposable, CtlApi.delete_ctl_device_adapter_handle_t_PtrPtr );
    CtlApi.ctlEnumerateDevices( apiHandle, uintPtr, deviceArrayPtr ).ThrowIfError( "Enumerate" );

    var array = DeviceAdapterHandleArray.frompointer( deviceArrayPtr );
    var n = CtlApi.unsigned_int_Ptr_value( uintPtr );
    var devices = Enumerable.Range( 0, Convert.ToInt32( n ) ).Select( array.getitem ).ToArray();
    return devices;
}


static void GetSpeed( CompositeDisposable disposable, SWIGTYPE_p__ctl_fan_handle_t? fan )
{
    var speedRequestPtr = CtlApi.new_int_Ptr().DisposeWith( disposable, CtlApi.delete_int_Ptr );
    CtlApi.ctlFanGetState( fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT, speedRequestPtr ).ThrowIfError( "Get fan % speed" );
    var fanSpeed = CtlApi.int_Ptr_value( speedRequestPtr );
    Console.WriteLine( $"Fan speed: {fanSpeed}" );
    // do the same for rpm

    CtlApi.ctlFanGetState( fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_RPM, speedRequestPtr ).ThrowIfError( "Get fan RPM speed" );
    var fanRpm = CtlApi.int_Ptr_value( speedRequestPtr );
    Console.WriteLine( $"Fan RPM: {fanRpm}" );
}

static void GetTemperatures( CompositeDisposable disposable, SWIGTYPE_p__ctl_device_adapter_handle_t device )
{
    var uintPtr = CtlApi.new_unsigned_int_Ptr().DisposeWith( disposable, CtlApi.delete_unsigned_int_Ptr );
    var tempArrayPtr = CtlApi.new_ctl_temp_handle_t_PtrPtr().DisposeWith( disposable, CtlApi.delete_ctl_temp_handle_t_PtrPtr );
    CtlApi.ctlEnumTemperatureSensors( device, uintPtr, tempArrayPtr ).ThrowIfError( "Enumerate temperature sensors" );

    var tempArray = TempHandleArray.frompointer( tempArrayPtr );
    var tempHandles = Enumerable.Range( 0, Convert.ToInt32( CtlApi.unsigned_int_Ptr_value( uintPtr ) ) ).Select( tempArray.getitem ).ToArray();

    foreach ( var temp in tempHandles )
    {
        var properties = new ctl_temp_properties_t().DisposeWith( disposable );
        CtlApi.ctlTemperatureGetProperties( temp, properties ).ThrowIfError( "Get temperature" );

        Console.WriteLine( $"Temperature sensor: type {properties.type}" );

        var doublePtr = CtlApi.new_double_Ptr().DisposeWith( disposable, CtlApi.delete_double_Ptr );
        CtlApi.ctlTemperatureGetState( temp, doublePtr ).ThrowIfError( "Get temperature" );
        var temperature = CtlApi.double_Ptr_value( doublePtr );

        Console.WriteLine( $"Temperature: {temperature}" );
    }
}

public static class Extensions
{
    public static void ThrowIfError( this ctl_result_t result, string context = "" )
    {
        if ( result != ctl_result_t.CTL_RESULT_SUCCESS )
        {
            throw new Exception( $"{context} Error: {result}" );
        }
    }

    public static T DisposeWith<T>( this T disposable, CompositeDisposable compositeDisposable )
        where T : IDisposable
    {
        compositeDisposable.Add( disposable );
        return disposable;
    }

    public static T DisposeWith<T>( this T disposable, CompositeDisposable compositeDisposable, Action<T> disposeMethod )
    {
        compositeDisposable.Add( new DisposeAction( () => disposeMethod( disposable ) ) );
        return disposable;
    }
}

public class DisposeAction : IDisposable
{
    private Action _disposeAction;

    public DisposeAction( Action disposeAction )
    {
        _disposeAction = disposeAction;
    }

    public void Dispose()
    {
        _disposeAction.Invoke();
    }
}

public class CompositeDisposable : IDisposable
{
    private List<IDisposable> _disposables = new List<IDisposable>();

    public void Add( IDisposable disposable )
    {
        _disposables.Add( disposable );
    }

    public void Dispose()
    {
        foreach ( var disposable in _disposables )
        {
            disposable.Dispose();
        }

        _disposables.Clear();
    }
}