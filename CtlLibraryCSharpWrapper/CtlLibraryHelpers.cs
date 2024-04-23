using CtlLibraryBindings;
using System;
using System.Linq;

namespace CtlLibraryCSharpWrapper
{
    public static class CtlLibraryHelpers
    {
        public static SWIGTYPE_p__ctl_device_adapter_handle_t[] GetDevices(SWIGTYPE_p__ctl_api_handle_t apiHandle)
        {
            using (var disposable = new CompositeDisposable())
            {
                var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
                CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0u);
                var emptyDeviceArray = new DeviceAdapterHandleArray(0).DisposeWith(disposable);

                CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, emptyDeviceArray.cast()).ThrowIfError("Enumerate devices (n)");
                var n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

                var array = new DeviceAdapterHandleArray(n).DisposeWith(disposable);
                CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, array.cast()).ThrowIfError($"Enumerate devices ({n})"); ;

                var devices = Enumerable.Range(0, n).Select(array.getitem).ToArray();
                return devices;
            }
        }
        public static SWIGTYPE_p__ctl_fan_handle_t[] GetFanHandles(SWIGTYPE_p__ctl_device_adapter_handle_t device)
        {
            using (var disposable = new CompositeDisposable())
            {
                var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
                CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0u);

                var emptyArray = new FanHandleArray(0).DisposeWith(disposable);
                CtlLibrary.ctlEnumFans(device, uintPtr, emptyArray.cast()).ThrowIfError("Fan handles (n)");
                int n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

                var fanArray = new FanHandleArray(n).DisposeWith(disposable);
                CtlLibrary.ctlEnumFans(device, uintPtr, fanArray.cast()).ThrowIfError($"Fan handles ({n})");

                return Enumerable.Range(0, n).Select(fanArray.getitem).ToArray();
            }
        }

        public static SWIGTYPE_p__ctl_temp_handle_t[] GetTempHandles(SWIGTYPE_p__ctl_device_adapter_handle_t handle)
        {
            using (var disposable = new CompositeDisposable())
            {
                var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
                var _ = new TempHandleArray(0).cast();
                CtlLibrary.ctlEnumTemperatureSensors(handle, uintPtr, _).ThrowIfError("Enumerate temperature sensors");
                int n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));
                var tempArray = new TempHandleArray(n);
                CtlLibrary.ctlEnumTemperatureSensors(handle, uintPtr, tempArray.cast()).ThrowIfError("Enumerate temperature sensors");

                return Enumerable.Range(0, n).Select(tempArray.getitem).ToArray();
            }
        }
    }
}
