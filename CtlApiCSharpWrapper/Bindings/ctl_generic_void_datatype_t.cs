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

public class ctl_generic_void_datatype_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_generic_void_datatype_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_generic_void_datatype_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_generic_void_datatype_t obj) {
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

  ~ctl_generic_void_datatype_t() {
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
          CtlApiPINVOKE.delete_ctl_generic_void_datatype_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public SWIGTYPE_p_void pData {
    set {
      CtlApiPINVOKE.ctl_generic_void_datatype_t_pData_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_generic_void_datatype_t_pData_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public uint size {
    set {
      CtlApiPINVOKE.ctl_generic_void_datatype_t_size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_generic_void_datatype_t_size_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_generic_void_datatype_t() : this(CtlApiPINVOKE.new_ctl_generic_void_datatype_t(), true) {
  }

}

}
