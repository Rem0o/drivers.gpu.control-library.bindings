using CtlLibraryBindings;
using CtlLibraryCSharpWrapper;
using System;
using System.Linq;
using System.Threading.Tasks;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var disposable = new CompositeDisposable();
        var apiHandle = GetApiHandle(disposable);

        using (disposable)
        {
            var devices = CtlLibraryHelpers.GetDevices(apiHandle)
                .DisposeWith(disposable)
                .GetItems((a, i) => a.getitem(i));

            Console.WriteLine($"Found {devices.Length} cards");

            // SET SPEED

            var speed = new ctl_fan_speed_t()
            {
                units = ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT,
            }.DisposeWith(disposable);

            var fanHandles = devices.SelectMany(d => CtlLibraryHelpers.GetFanHandles(d).DisposeWith(disposable).GetItems((a, i) => a.getitem(i))).ToArray();
            Console.WriteLine($"Found {fanHandles.Length} fans");

            if (fanHandles.Length > 0)
            {
                const int N = 10;
                foreach (var percent in Enumerable.Range(0, N + 1).Select(x => x * 10).Reverse())
                {
                    speed.speed = percent;
                    foreach (var fan in fanHandles)
                    {
                        CtlLibrary.ctlFanSetFixedSpeedMode(fan, speed).ThrowIfError($"Set fixed fan speed to {speed.speed}");
                    }

                    await Task.Delay(TimeSpan.FromSeconds(5));

                    // GET SPEED
                    foreach (var fan in fanHandles)
                    {
                        GetSpeed(fan);
                    }
                }
            }

            // GET TEMPERATURE
            foreach (var device in devices)
            {
                GetTemperatures(disposable, device);
            }

            // RESET TO DEFAULT
            if (fanHandles.Length > 0)
            {
                Console.WriteLine("RESETTING TO DEFAULT");
            }

            foreach (var fan in fanHandles)
            {
                CtlLibrary.ctlFanSetDefaultMode(fan).ThrowIfError("Set default fan speed");
            }

            // CLOSE
            CtlLibrary.ctlClose(apiHandle).ThrowIfError("Close");
        }
    }

    private static SWIGTYPE_p__ctl_api_handle_t GetApiHandle(CompositeDisposable disposable)
    {
        var initArgs = CtlLibrary.create_Init_Args().DisposeWith(disposable);
        var handlePtr = CtlLibrary.new_ctl_api_handle_t_Ptr();
        CtlLibrary.ctlInit(initArgs, handlePtr).ThrowIfError("Init");
        var apiHandle = CtlLibrary.ctl_api_handle_t_Ptr_value(handlePtr);

        return apiHandle;
    }

    private static void GetSpeed(SWIGTYPE_p__ctl_fan_handle_t fan)
    {
        var speedRequestPtr = CtlLibrary.new_int_Ptr();
        CtlLibrary.ctlFanGetState(fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT, speedRequestPtr).ThrowIfError("Get fan % speed");
        var fanSpeed = CtlLibrary.int_Ptr_value(speedRequestPtr);

        CtlLibrary.ctlFanGetState(fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_RPM, speedRequestPtr).ThrowIfError("Get fan RPM speed");
        var fanRpm = CtlLibrary.int_Ptr_value(speedRequestPtr);
        Console.WriteLine($"Reading Fan: {fanRpm} RPM --- {fanSpeed} %");
    }

    private static void GetTemperatures(CompositeDisposable disposable, SWIGTYPE_p__ctl_device_adapter_handle_t device)
    {
        foreach (var temp in CtlLibraryHelpers.GetTempHandles(device).DisposeWith(disposable).GetItems((a, i) => a.getitem(i)))
        {
            var properties = new ctl_temp_properties_t().DisposeWith(disposable);
            CtlLibrary.ctlTemperatureGetProperties(temp, properties).ThrowIfError("Get temperature");

            var doublePtr = CtlLibrary.new_double_Ptr().DisposeWith(disposable, CtlLibrary.delete_double_Ptr);
            CtlLibrary.ctlTemperatureGetState(temp, doublePtr).ThrowIfError("Get temperature");
            var temperature = CtlLibrary.double_Ptr_value(doublePtr);

            Console.WriteLine($"Temperature sensor: type {properties.type} temp {temperature} degree C");
        }
    }
}