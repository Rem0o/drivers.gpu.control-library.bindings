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

public class ctl_endurance_gaming_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_endurance_gaming_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_endurance_gaming_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_endurance_gaming_t obj) {
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

  ~ctl_endurance_gaming_t() {
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
          CtlLibraryPINVOKE.delete_ctl_endurance_gaming_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public ctl_3d_endurance_gaming_control_t EGControl {
    set {
      CtlLibraryPINVOKE.ctl_endurance_gaming_t_EGControl_set(swigCPtr, (int)value);
    } 
    get {
      ctl_3d_endurance_gaming_control_t ret = (ctl_3d_endurance_gaming_control_t)CtlLibraryPINVOKE.ctl_endurance_gaming_t_EGControl_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_3d_endurance_gaming_mode_t EGMode {
    set {
      CtlLibraryPINVOKE.ctl_endurance_gaming_t_EGMode_set(swigCPtr, (int)value);
    } 
    get {
      ctl_3d_endurance_gaming_mode_t ret = (ctl_3d_endurance_gaming_mode_t)CtlLibraryPINVOKE.ctl_endurance_gaming_t_EGMode_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_endurance_gaming_t() : this(CtlLibraryPINVOKE.new_ctl_endurance_gaming_t(), true) {
  }

}

}
