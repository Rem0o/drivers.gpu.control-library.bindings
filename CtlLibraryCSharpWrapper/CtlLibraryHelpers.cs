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
                var emptyDeviceArrayPtr = CtlLibrary.new_ctl_device_adapter_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_device_adapter_handle_t_PtrPtr);

                CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, emptyDeviceArrayPtr).ThrowIfError("Enumerate devices (n)");
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

                var emptyArrayPtr = CtlLibrary.new_ctl_fan_handle_t_PtrPtr().DisposeWith(disposable, CtlLibrary.delete_ctl_fan_handle_t_PtrPtr);
                CtlLibrary.ctlEnumFans(device, uintPtr, emptyArrayPtr).ThrowIfError("Fan handles (n)");
                int n = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

                var fanArray = new FanHandleArray(n).DisposeWith(disposable);
                CtlLibrary.ctlEnumFans(device, uintPtr, fanArray.cast()).ThrowIfError($"Fan handles ({n})");

                return Enumerable.Range(0, n).Select(fanArray.getitem).ToArray();
            }
        }
    }
}
