//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (https://www.swig.org).
// Version 4.2.1
//
// Do not make changes to this file unless you know what you are doing - modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CtlLibraryBindings {

public class ctl_oc_telemetry_item_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_oc_telemetry_item_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_oc_telemetry_item_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_oc_telemetry_item_t obj) {
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

  ~ctl_oc_telemetry_item_t() {
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
          CtlLibraryPINVOKE.delete_ctl_oc_telemetry_item_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public bool bSupported {
    set {
      CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_bSupported_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_bSupported_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_units_t units {
    set {
      CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_units_set(swigCPtr, (int)value);
    } 
    get {
      ctl_units_t ret = (ctl_units_t)CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_units_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_data_type_t type {
    set {
      CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_type_set(swigCPtr, (int)value);
    } 
    get {
      ctl_data_type_t ret = (ctl_data_type_t)CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_type_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_data_value_t value {
    set {
      CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_value_set(swigCPtr, ctl_data_value_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_oc_telemetry_item_t_value_get(swigCPtr);
      ctl_data_value_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_data_value_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_oc_telemetry_item_t() : this(CtlLibraryPINVOKE.new_ctl_oc_telemetry_item_t(), true) {
  }

}

}