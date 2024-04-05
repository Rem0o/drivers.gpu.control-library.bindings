
using CtlLibraryBindings;
using System;
using System.Collections.Generic;
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
            var devices = GetDeviceHandles(disposable, apiHandle);
            Console.WriteLine($"Found {devices.Length} cards");
            // SET SPEED

            var speed = new ctl_fan_speed_t
            {
                units = ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT,
                // version?
            }.DisposeWith(disposable);

            var fanHandles = GetFanHandles(devices, disposable).ToArray();
            Console.WriteLine($"Found {fanHandles.Length} fans");

            const int N = 10;
            if (fanHandles.Length > 0)
            {
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
                        GetSpeed(disposable, fan);
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


        static IEnumerable<SWIGTYPE_p__ctl_fan_handle_t> GetFanHandles(SWIGTYPE_p__ctl_device_adapter_handle_t[] devices, CompositeDisposable disposable)
        {
            var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
            foreach (var handle in devices)
            {
                var emptyArrayPtr = CtlLibrary.new_ctl_fan_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_fan_handle_t_PtrPtr);
                CtlLibrary.ctlEnumFans(handle, uintPtr, emptyArrayPtr).ThrowIfError("Fan handles");
                int n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

                var fanArray = new FanHandleArray(n).DisposeWith(disposable);
                CtlLibrary.ctlEnumFans(handle, uintPtr, fanArray.cast()).ThrowIfError("Fan handles");

                foreach (var fan in Enumerable.Range(0, n).Select<int, SWIGTYPE_p__ctl_fan_handle_t>(fanArray.getitem))
                {
                    yield return fan;
                }
            }
        }

        static SWIGTYPE_p__ctl_api_handle_t GetApiHandle(CompositeDisposable disposable)
        {
            ctl_init_args_t initArgs = CtlLibrary.create_Init_Args().DisposeWith(disposable);
            var handlePtr = CtlLibrary.new_ctl_api_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_api_handle_t_PtrPtr);

            CtlLibrary.ctlInit(initArgs, handlePtr).ThrowIfError("Init");
            var apiHandle = CtlLibrary.ctl_api_handle_t_PtrPtr_value(handlePtr);

            return apiHandle;
        }

        static SWIGTYPE_p__ctl_device_adapter_handle_t[] GetDeviceHandles(CompositeDisposable disposable, SWIGTYPE_p__ctl_api_handle_t apiHandle)
        {
            var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
            CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0);
            var emptyDeviceArrayPtr = CtlLibrary.new_ctl_device_adapter_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_device_adapter_handle_t_PtrPtr);

            CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, emptyDeviceArrayPtr).ThrowIfError("Enumerate devices (n)");
            var n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

            var array = new DeviceAdapterHandleArray(n).DisposeWith(disposable);
            CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, array.cast()).ThrowIfError($"Enumerate devices ({n})"); ;

            var devices = Enumerable.Range(0, n).Select(array.getitem).ToArray();
            return devices;
        }

        static void GetSpeed(CompositeDisposable disposable, SWIGTYPE_p__ctl_fan_handle_t fan)
        {
            var speedRequestPtr = CtlLibrary.new_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_int_Ptr);
            CtlLibrary.ctlFanGetState(fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_PERCENT, speedRequestPtr).ThrowIfError("Get fan % speed");
            var fanSpeed = CtlLibrary.int_Ptr_value(speedRequestPtr);

            CtlLibrary.ctlFanGetState(fan, ctl_fan_speed_units_t.CTL_FAN_SPEED_UNITS_RPM, speedRequestPtr).ThrowIfError("Get fan RPM speed");
            var fanRpm = CtlLibrary.int_Ptr_value(speedRequestPtr);
            Console.WriteLine($"Reading Fan: {fanRpm} RPM --- {fanSpeed} %");
        }

        static void GetTemperatures(CompositeDisposable disposable, SWIGTYPE_p__ctl_device_adapter_handle_t device)
        {
            var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
            CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0);

            var emptyTempArrayPtr = CtlLibrary.new_ctl_temp_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_temp_handle_t_PtrPtr);
            CtlLibrary.ctlEnumTemperatureSensors(device, uintPtr, emptyTempArrayPtr).ThrowIfError("Enumerate temperature sensors (n)");
            int n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

            var tempArray = new TempHandleArray(n).DisposeWith(disposable);
            CtlLibrary.ctlEnumTemperatureSensors(device, uintPtr, tempArray.cast()).ThrowIfError($"Enumerate temperature sensors ({n})");

            Console.WriteLine($"Found {n} temp sensors");

            var tempHandles = Enumerable.Range(0, n).Select(tempArray.getitem).ToArray();

            foreach (var temp in tempHandles)
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
}