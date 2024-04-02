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

public class ctl_adaptivesync_caps_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_adaptivesync_caps_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_adaptivesync_caps_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_adaptivesync_caps_t obj) {
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

  ~ctl_adaptivesync_caps_t() {
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
          CtlApiPINVOKE.delete_ctl_adaptivesync_caps_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool AdaptiveBalanceSupported {
    set {
      CtlApiPINVOKE.ctl_adaptivesync_caps_t_AdaptiveBalanceSupported_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlApiPINVOKE.ctl_adaptivesync_caps_t_AdaptiveBalanceSupported_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_property_info_float_t AdaptiveBalanceStrengthCaps {
    set {
      CtlApiPINVOKE.ctl_adaptivesync_caps_t_AdaptiveBalanceStrengthCaps_set(swigCPtr, ctl_property_info_float_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_adaptivesync_caps_t_AdaptiveBalanceStrengthCaps_get(swigCPtr);
      ctl_property_info_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_property_info_float_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_adaptivesync_caps_t() : this(CtlApiPINVOKE.new_ctl_adaptivesync_caps_t(), true) {
  }

}

}
