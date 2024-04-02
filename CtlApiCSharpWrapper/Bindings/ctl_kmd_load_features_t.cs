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

public class ctl_kmd_load_features_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_kmd_load_features_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_kmd_load_features_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_kmd_load_features_t obj) {
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

  ~ctl_kmd_load_features_t() {
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
          CtlApiPINVOKE.delete_ctl_kmd_load_features_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ctl_application_id_t ReservedFuncID {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_ReservedFuncID_set(swigCPtr, ctl_application_id_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_kmd_load_features_t_ReservedFuncID_get(swigCPtr);
      ctl_application_id_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_application_id_t(cPtr, false);
      return ret;
    } 
  }

  public bool bLoad {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_bLoad_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlApiPINVOKE.ctl_kmd_load_features_t_bLoad_get(swigCPtr);
      return ret;
    } 
  }

  public long SubsetFeatureMask {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_SubsetFeatureMask_set(swigCPtr, value);
    } 
    get {
      long ret = CtlApiPINVOKE.ctl_kmd_load_features_t_SubsetFeatureMask_get(swigCPtr);
      return ret;
    } 
  }

  public string ApplicationName {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_ApplicationName_set(swigCPtr, value);
    } 
    get {
      string ret = CtlApiPINVOKE.ctl_kmd_load_features_t_ApplicationName_get(swigCPtr);
      return ret;
    } 
  }

  public sbyte ApplicationNameLength {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_ApplicationNameLength_set(swigCPtr, value);
    } 
    get {
      sbyte ret = CtlApiPINVOKE.ctl_kmd_load_features_t_ApplicationNameLength_get(swigCPtr);
      return ret;
    } 
  }

  public sbyte CallerComponent {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_CallerComponent_set(swigCPtr, value);
    } 
    get {
      sbyte ret = CtlApiPINVOKE.ctl_kmd_load_features_t_CallerComponent_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_long_long Reserved {
    set {
      CtlApiPINVOKE.ctl_kmd_load_features_t_Reserved_set(swigCPtr, SWIGTYPE_p_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_kmd_load_features_t_Reserved_get(swigCPtr);
      SWIGTYPE_p_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_long_long(cPtr, false);
      return ret;
    } 
  }

  public ctl_kmd_load_features_t() : this(CtlApiPINVOKE.new_ctl_kmd_load_features_t(), true) {
  }

}

}
