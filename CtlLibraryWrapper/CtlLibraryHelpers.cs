using CtlLibraryBindings;
using System;

namespace CtlLibraryWrapper
{
    public static class CtlLibraryHelpers
    {
        public static ArrayWrapper<DeviceAdapterHandleArray> GetDevices(SWIGTYPE_p__ctl_api_handle_t apiHandle)
        {
            using var disposable = new CompositeDisposable();

            var uintPtr = CtlLibrary.new_unsigned_int_Ptr();
            CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0u);
            var emptyDeviceArray = ArrayWrapper.Create(0, n => new DeviceAdapterHandleArray(n)).DisposeWith(disposable);

            CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, null).ThrowIfError("Enumerate devices (n)");
            var adapterCount = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

            var array = ArrayWrapper.Create(adapterCount, n => new DeviceAdapterHandleArray(n));
            CtlLibrary.ctlEnumerateDevices(apiHandle, uintPtr, array.Value.cast()).ThrowIfError($"Enumerate devices ({adapterCount})"); ;

            return array;
        }

        public static ArrayWrapper<FanHandleArray> GetFanHandles(SWIGTYPE_p__ctl_device_adapter_handle_t device)
        {
            using var disposable = new CompositeDisposable();

            var uintPtr = CtlLibrary.new_unsigned_int_Ptr();
            CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0u);

            CtlLibrary.ctlEnumFans(device, uintPtr, null).ThrowIfError("Fan handles (n)");
            int fanCount = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));

            var fanArray = ArrayWrapper.Create(fanCount, n => new FanHandleArray(n));
            CtlLibrary.ctlEnumFans(device, uintPtr, fanArray.Value.cast()).ThrowIfError($"Fan handles ({fanCount})");

            return fanArray;
        }

        public static ArrayWrapper<TempHandleArray> GetTempHandles(SWIGTYPE_p__ctl_device_adapter_handle_t handle)
        {
            using var disposable = new CompositeDisposable();

            var uintPtr = CtlLibrary.new_unsigned_int_Ptr().DisposeWith(disposable, CtlLibrary.delete_unsigned_int_Ptr);
            CtlLibrary.unsigned_int_Ptr_assign(uintPtr, 0u);

            CtlLibrary.ctlEnumTemperatureSensors(handle, uintPtr, null).ThrowIfError("Enumerate temperature sensors");
            int tempCount = Convert.ToInt32(CtlLibrary.unsigned_int_Ptr_value(uintPtr));
            var tempArray = ArrayWrapper.Create(tempCount, n => new TempHandleArray(n));
            CtlLibrary.ctlEnumTemperatureSensors(handle, uintPtr, tempArray.Value.cast()).ThrowIfError("Enumerate temperature sensors");

            return tempArray;
        }
    }
}
