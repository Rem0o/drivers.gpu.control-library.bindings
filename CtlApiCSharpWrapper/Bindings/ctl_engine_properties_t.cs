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

public class ctl_engine_properties_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_engine_properties_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_engine_properties_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_engine_properties_t obj) {
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

  ~ctl_engine_properties_t() {
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
          CtlApiPINVOKE.delete_ctl_engine_properties_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlApiPINVOKE.ctl_engine_properties_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_engine_properties_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlApiPINVOKE.ctl_engine_properties_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlApiPINVOKE.ctl_engine_properties_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_engine_group_t type {
    set {
      CtlApiPINVOKE.ctl_engine_properties_t_type_set(swigCPtr, (int)value);
    } 
    get {
      ctl_engine_group_t ret = (ctl_engine_group_t)CtlApiPINVOKE.ctl_engine_properties_t_type_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_engine_properties_t() : this(CtlApiPINVOKE.new_ctl_engine_properties_t(), true) {
  }

}

}
