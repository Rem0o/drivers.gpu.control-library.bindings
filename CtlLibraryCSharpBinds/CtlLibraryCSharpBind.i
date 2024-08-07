%module CtlLibrary
%{
#include <Windows.h>
#include "../../drivers.gpu.control-library/Include/igcl_api.h"
#include "../../drivers.gpu.control-library/Source/cApiWrapper.cpp"
#include "CtlLibraryHelper.h"
%}

%include stdint.i
%include windows.i
%include typemaps.i
%include carrays.i
%include cpointer.i

// use the following to have int indexes instead of uint (size_t)
%apply int { size_t nelements, size_t index }

%include "../../drivers.gpu.control-library/Include/igcl_api.h"
%include "../../drivers.gpu.control-library/Source/cApiWrapper.cpp"
%include "CtlLibraryHelper.h"

%inline %{
  ctl_init_args_t create_Init_Args() {
    ctl_init_args_t CtlInitArgs;
    CtlInitArgs.AppVersion = CTL_MAKE_VERSION(CTL_IMPL_MAJOR_VERSION, CTL_IMPL_MINOR_VERSION);
    CtlInitArgs.flags      = CTL_INIT_FLAG_USE_LEVEL_ZERO;
    CtlInitArgs.Size       = sizeof(CtlInitArgs);
    CtlInitArgs.Version    = 0;
    // Init App UID appropriately
    ZeroMemory(&CtlInitArgs.ApplicationUID, sizeof(ctl_application_id_t));
    return CtlInitArgs;
  }
%}

%define %setSizeInCtor(TYPE1)
%extend TYPE1 {
    TYPE1() {
        
        TYPE1* result = (TYPE1 *)new TYPE1();
        result->Size = sizeof(TYPE1);

        return result;
    }
}
%enddef

%setSizeInCtor(_ctl_fan_speed_t);
%setSizeInCtor(_ctl_temp_properties_t);
%setSizeInCtor(_ctl_device_adapter_properties_t);
%setSizeInCtor(_ctl_fan_speed_table_t);

%define %pointer_cast(TYPE1,TYPE2,NAME)
%inline %{
TYPE2 NAME(TYPE1 x) {
   return (TYPE2) x;
}
%}
%enddef

%pointer_functions(ctl_init_args_t, ctl_init_args_t_Ptr);
%pointer_functions(uint32_t, unsigned_int_Ptr);
%pointer_functions(int, int_Ptr);
%pointer_functions(double, double_Ptr);
%pointer_functions(ctl_api_handle_t, ctl_api_handle_t_Ptr);

%array_class(ctl_device_adapter_handle_t, DeviceAdapterHandleArray);
%array_class(ctl_temp_handle_t, TempHandleArray);
%array_class(ctl_fan_handle_t, FanHandleArray);