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

public class ctl_video_processing_noise_reduction_info_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_video_processing_noise_reduction_info_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_video_processing_noise_reduction_info_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_video_processing_noise_reduction_info_t obj) {
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

  ~ctl_video_processing_noise_reduction_info_t() {
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
          CtlLibraryPINVOKE.delete_ctl_video_processing_noise_reduction_info_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_property_info_uint_t noise_reduction {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_set(swigCPtr, ctl_property_info_uint_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_get(swigCPtr);
      ctl_property_info_uint_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_property_info_uint_t(cPtr, false);
      return ret;
    } 
  }

  public bool noise_reduction_auto_detect_supported {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_auto_detect_supported_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_auto_detect_supported_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_property_info_boolean_t noise_reduction_auto_detect {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_auto_detect_set(swigCPtr, ctl_property_info_boolean_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_noise_reduction_auto_detect_get(swigCPtr);
      ctl_property_info_boolean_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_property_info_boolean_t(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int ReservedFields {
    set {
      CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_ReservedFields_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_video_processing_noise_reduction_info_t_ReservedFields_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public ctl_video_processing_noise_reduction_info_t() : this(CtlLibraryPINVOKE.new_ctl_video_processing_noise_reduction_info_t(), true) {
  }

}

}
