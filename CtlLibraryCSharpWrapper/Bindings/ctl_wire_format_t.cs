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

public class ctl_wire_format_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_wire_format_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_wire_format_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_wire_format_t obj) {
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

  ~ctl_wire_format_t() {
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
          CtlLibraryPINVOKE.delete_ctl_wire_format_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlLibraryPINVOKE.ctl_wire_format_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_wire_format_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlLibraryPINVOKE.ctl_wire_format_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_wire_format_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_wire_format_color_model_t ColorModel {
    set {
      CtlLibraryPINVOKE.ctl_wire_format_t_ColorModel_set(swigCPtr, (int)value);
    } 
    get {
      ctl_wire_format_color_model_t ret = (ctl_wire_format_color_model_t)CtlLibraryPINVOKE.ctl_wire_format_t_ColorModel_get(swigCPtr);
      return ret;
    } 
  }

  public uint ColorDepth {
    set {
      CtlLibraryPINVOKE.ctl_wire_format_t_ColorDepth_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_wire_format_t_ColorDepth_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_wire_format_t() : this(CtlLibraryPINVOKE.new_ctl_wire_format_t(), true) {
  }

}

}
