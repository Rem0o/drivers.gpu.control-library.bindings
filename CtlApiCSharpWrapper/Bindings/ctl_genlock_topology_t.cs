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

public class ctl_genlock_topology_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_genlock_topology_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_genlock_topology_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_genlock_topology_t obj) {
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

  ~ctl_genlock_topology_t() {
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
          CtlApiPINVOKE.delete_ctl_genlock_topology_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public byte NumGenlockDisplays {
    set {
      CtlApiPINVOKE.ctl_genlock_topology_t_NumGenlockDisplays_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlApiPINVOKE.ctl_genlock_topology_t_NumGenlockDisplays_get(swigCPtr);
      return ret;
    } 
  }

  public bool IsPrimaryGenlockSystem {
    set {
      CtlApiPINVOKE.ctl_genlock_topology_t_IsPrimaryGenlockSystem_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlApiPINVOKE.ctl_genlock_topology_t_IsPrimaryGenlockSystem_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_timing_t CommonTargetMode {
    set {
      CtlApiPINVOKE.ctl_genlock_topology_t_CommonTargetMode_set(swigCPtr, ctl_display_timing_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_genlock_topology_t_CommonTargetMode_get(swigCPtr);
      ctl_display_timing_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_display_timing_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_genlock_display_info_t pGenlockDisplayInfo {
    set {
      CtlApiPINVOKE.ctl_genlock_topology_t_pGenlockDisplayInfo_set(swigCPtr, ctl_genlock_display_info_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_genlock_topology_t_pGenlockDisplayInfo_get(swigCPtr);
      ctl_genlock_display_info_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_genlock_display_info_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_genlock_target_mode_list_t pGenlockModeList {
    set {
      CtlApiPINVOKE.ctl_genlock_topology_t_pGenlockModeList_set(swigCPtr, ctl_genlock_target_mode_list_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_genlock_topology_t_pGenlockModeList_get(swigCPtr);
      ctl_genlock_target_mode_list_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_genlock_target_mode_list_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_genlock_topology_t() : this(CtlApiPINVOKE.new_ctl_genlock_topology_t(), true) {
  }

}

}
