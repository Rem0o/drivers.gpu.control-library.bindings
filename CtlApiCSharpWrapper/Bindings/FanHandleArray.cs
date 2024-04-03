//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CtlApiBindings {

public class FanHandleArray : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FanHandleArray(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FanHandleArray obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(FanHandleArray obj) {
    if (obj != null) {
      if (!obj.swigCMemOwn)
        throw new global::System.ApplicationException("Cannot release ownership as memory is not owned");
      global::System.Runtime.InteropServices.HandleRef ptr = obj.swigCPtr;
      obj.swigCMemOwn = false;
      obj.Dispose();
      return ptr;
    } else {
      return new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
    }
  }

  ~FanHandleArray() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CtlApiPINVOKE.delete_FanHandleArray(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FanHandleArray(int nelements) : this(CtlApiPINVOKE.new_FanHandleArray(nelements), true) {
  }

  public SWIGTYPE_p__ctl_fan_handle_t getitem(int index) {
    global::System.IntPtr cPtr = CtlApiPINVOKE.FanHandleArray_getitem(swigCPtr, index);
    SWIGTYPE_p__ctl_fan_handle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p__ctl_fan_handle_t(cPtr, false);
    return ret;
  }

  public void setitem(int index, SWIGTYPE_p__ctl_fan_handle_t value) {
    CtlApiPINVOKE.FanHandleArray_setitem(swigCPtr, index, SWIGTYPE_p__ctl_fan_handle_t.getCPtr(value));
  }

  public SWIGTYPE_p_p__ctl_fan_handle_t cast() {
    global::System.IntPtr cPtr = CtlApiPINVOKE.FanHandleArray_cast(swigCPtr);
    SWIGTYPE_p_p__ctl_fan_handle_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p__ctl_fan_handle_t(cPtr, false);
    return ret;
  }

  public static FanHandleArray frompointer(SWIGTYPE_p_p__ctl_fan_handle_t t) {
    global::System.IntPtr cPtr = CtlApiPINVOKE.FanHandleArray_frompointer(SWIGTYPE_p_p__ctl_fan_handle_t.getCPtr(t));
    FanHandleArray ret = (cPtr == global::System.IntPtr.Zero) ? null : new FanHandleArray(cPtr, false);
    return ret;
  }

}

}
