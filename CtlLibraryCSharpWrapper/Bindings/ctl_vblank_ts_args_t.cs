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

public class ctl_vblank_ts_args_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_vblank_ts_args_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_vblank_ts_args_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_vblank_ts_args_t obj) {
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

  ~ctl_vblank_ts_args_t() {
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
          CtlLibraryPINVOKE.delete_ctl_vblank_ts_args_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlLibraryPINVOKE.ctl_vblank_ts_args_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_vblank_ts_args_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlLibraryPINVOKE.ctl_vblank_ts_args_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_vblank_ts_args_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public byte NumOfTargets {
    set {
      CtlLibraryPINVOKE.ctl_vblank_ts_args_t_NumOfTargets_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_vblank_ts_args_t_NumOfTargets_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_long_long VblankTS {
    set {
      CtlLibraryPINVOKE.ctl_vblank_ts_args_t_VblankTS_set(swigCPtr, SWIGTYPE_p_unsigned_long_long.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_vblank_ts_args_t_VblankTS_get(swigCPtr);
      SWIGTYPE_p_unsigned_long_long ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_long_long(cPtr, false);
      return ret;
    } 
  }

  public ctl_vblank_ts_args_t() : this(CtlLibraryPINVOKE.new_ctl_vblank_ts_args_t(), true) {
  }

}

}