%module CtlApi
%{
#include <Windows.h>
#include "../../drivers.gpu.control-library/Include/igcl_api.h"
#include "../../drivers.gpu.control-library/Source/cApiWrapper.cpp"

typedef     uint32_t        ctlapi_uint32;
typedef     ctlapi_uint32   ctlapi_uint;

// Microsoft
#define CtlAPI_CORE_LINK          __declspec(dllexport)
#define CtlAPI_STD_CALL           __stdcall
#define CtlAPI_CDECL_CALL         __cdecl
#define CtlAPI_FAST_CALL          __fastcall
#define CtlAPI_INLINE              __inline
#define CtlAPI_FORCEINLINE         __forceinline
#define CtlAPI_NO_VTABLE          __declspec(novtable)

//IID's
#define CtlAPI_DECLARE_IID(X) static CtlAPI_INLINE const wchar_t* IID()  { return X; }
#define CtlAPI_IS_IID(X, Y) (!wcscmp (X, Y))
#define CtlAPI_DECLARE_ITEM_IID(X) static CtlAPI_INLINE const wchar_t* ITEM_IID()  { return X; }

%}

typedef     uint32_t        ctlapi_uint32;
typedef     ctlapi_uint32   ctlapi_uint;

%include stdint.i
%include carrays.i
%include windows.i
%include typemaps.i
%include cpointer.i

%include "../../drivers.gpu.control-library/Include/igcl_api.h"
%include "../../drivers.gpu.control-library/Source/cApiWrapper.cpp"

%inline %{
  size_t size_of_ctl_init_args_t() {
    return sizeof(ctl_init_args_t);
  }
%}

%inline %{
  void zero_memory_application_id(ctl_application_id_t* memory) {
    ZeroMemory(memory, sizeof(ctl_application_id_t));
  }
%}

%inline %{
  ctl_init_args_t create_Init_Args() {
    ctl_init_args_t CtlInitArgs;
    CtlInitArgs.AppVersion = CTL_MAKE_VERSION(CTL_IMPL_MAJOR_VERSION, CTL_IMPL_MINOR_VERSION);
    CtlInitArgs.flags      = 0; // CTL_INIT_FLAG_USE_LEVEL_ZERO;
    CtlInitArgs.Size       = sizeof(CtlInitArgs);
    CtlInitArgs.Version    = 0;
    // Init App UID appropriately
    ZeroMemory(&CtlInitArgs.ApplicationUID, sizeof(ctl_application_id_t));
    return CtlInitArgs;
  }
%}

// T** ppointer
%define %ppointer_functions(TYPE,NAME)
%{
static TYPE *new_##NAME() { %}
%{  return new TYPE(); %}
%{}

static TYPE *copy_##NAME(TYPE value) { %}
%{  return new TYPE(value); %}
%{}

static void delete_##NAME(TYPE *obj) { %}
%{  if (*obj) delete *obj; %}
%{}

static void NAME ##_assign(TYPE *obj, TYPE value) {
  *obj = value;
}

static TYPE NAME ##_value(TYPE *obj) {
  return *obj;
}
%}

TYPE *new_##NAME();
TYPE *copy_##NAME(TYPE value);
void  delete_##NAME(TYPE *obj);
void  NAME##_assign(TYPE *obj, TYPE value);
TYPE  NAME##_value(TYPE *obj);

%enddef

%define %pointer_cast(TYPE1,TYPE2,NAME)
%inline %{
TYPE2 NAME(TYPE1 x) {
   return (TYPE2) x;
}
%}
%enddef


%pointer_functions(ctl_init_args_t, ctl_init_args_t_Ptr);
%pointer_functions(ctlapi_uint, unsigned_int_Ptr);
%pointer_functions(int, int_Ptr);
%pointer_functions(double, double_Ptr);
%ppointer_functions(ctl_api_handle_t, ctl_api_handle_t_PtrPtr);

%ppointer_functions(ctl_device_adapter_handle_t, ctl_device_adapter_handle_t_PtrPtr);
%array_class(ctl_device_adapter_handle_t, DeviceAdapterHandleArray);

%ppointer_functions(ctl_temp_handle_t, ctl_temp_handle_t_PtrPtr);
%array_class(ctl_temp_handle_t, TempHandleArray);

%ppointer_functions(ctl_fan_handle_t, ctl_fan_handle_t_PtrPtr);
%array_class(ctl_fan_handle_t, FanHandleArray);