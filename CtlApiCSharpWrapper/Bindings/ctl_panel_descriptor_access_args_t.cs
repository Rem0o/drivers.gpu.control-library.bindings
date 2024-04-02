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

public class ctl_panel_descriptor_access_args_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_panel_descriptor_access_args_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_panel_descriptor_access_args_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_panel_descriptor_access_args_t obj) {
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

  ~ctl_panel_descriptor_access_args_t() {
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
          CtlApiPINVOKE.delete_ctl_panel_descriptor_access_args_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_operation_type_t OpType {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_OpType_set(swigCPtr, (int)value);
    } 
    get {
      ctl_operation_type_t ret = (ctl_operation_type_t)CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_OpType_get(swigCPtr);
      return ret;
    } 
  }

  public uint BlockNumber {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_BlockNumber_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_BlockNumber_get(swigCPtr);
      return ret;
    } 
  }

  public uint DescriptorDataSize {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_DescriptorDataSize_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_DescriptorDataSize_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_char pDescriptorData {
    set {
      CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_pDescriptorData_set(swigCPtr, SWIGTYPE_p_unsigned_char.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_panel_descriptor_access_args_t_pDescriptorData_get(swigCPtr);
      SWIGTYPE_p_unsigned_char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_char(cPtr, false);
      return ret;
    } 
  }

  public ctl_panel_descriptor_access_args_t() : this(CtlApiPINVOKE.new_ctl_panel_descriptor_access_args_t(), true) {
  }

}

}
