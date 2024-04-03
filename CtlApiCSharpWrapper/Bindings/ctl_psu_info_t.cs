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

public class ctl_psu_info_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_psu_info_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_psu_info_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_psu_info_t obj) {
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

  ~ctl_psu_info_t() {
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
          CtlApiPINVOKE.delete_ctl_psu_info_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool bSupported {
    set {
      CtlApiPINVOKE.ctl_psu_info_t_bSupported_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlApiPINVOKE.ctl_psu_info_t_bSupported_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_psu_type_t psuType {
    set {
      CtlApiPINVOKE.ctl_psu_info_t_psuType_set(swigCPtr, (int)value);
    } 
    get {
      ctl_psu_type_t ret = (ctl_psu_type_t)CtlApiPINVOKE.ctl_psu_info_t_psuType_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_oc_telemetry_item_t energyCounter {
    set {
      CtlApiPINVOKE.ctl_psu_info_t_energyCounter_set(swigCPtr, ctl_oc_telemetry_item_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_psu_info_t_energyCounter_get(swigCPtr);
      ctl_oc_telemetry_item_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_oc_telemetry_item_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_oc_telemetry_item_t voltage {
    set {
      CtlApiPINVOKE.ctl_psu_info_t_voltage_set(swigCPtr, ctl_oc_telemetry_item_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_psu_info_t_voltage_get(swigCPtr);
      ctl_oc_telemetry_item_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_oc_telemetry_item_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_psu_info_t() : this(CtlApiPINVOKE.new_ctl_psu_info_t(), true) {
  }

}

}
