//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.1.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CtlApiBindings {

public class ctl_property_info_int_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_property_info_int_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_property_info_int_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_property_info_int_t obj) {
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

  ~ctl_property_info_int_t() {
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
          CtlApiPINVOKE.delete_ctl_property_info_int_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool DefaultEnable {
    set {
      CtlApiPINVOKE.ctl_property_info_int_t_DefaultEnable_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlApiPINVOKE.ctl_property_info_int_t_DefaultEnable_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_property_range_info_int_t RangeInfo {
    set {
      CtlApiPINVOKE.ctl_property_info_int_t_RangeInfo_set(swigCPtr, ctl_property_range_info_int_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_property_info_int_t_RangeInfo_get(swigCPtr);
      ctl_property_range_info_int_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_property_range_info_int_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_property_info_int_t() : this(CtlApiPINVOKE.new_ctl_property_info_int_t(), true) {
  }

}

}
