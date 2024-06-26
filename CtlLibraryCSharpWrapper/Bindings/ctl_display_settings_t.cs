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

public class ctl_display_settings_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_display_settings_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_display_settings_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_display_settings_t obj) {
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

  ~ctl_display_settings_t() {
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
          CtlLibraryPINVOKE.delete_ctl_display_settings_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_display_settings_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_display_settings_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public bool Set {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_Set_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlLibraryPINVOKE.ctl_display_settings_t_Set_get(swigCPtr);
      return ret;
    } 
  }

  public uint SupportedFlags {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_SupportedFlags_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_display_settings_t_SupportedFlags_get(swigCPtr);
      return ret;
    } 
  }

  public uint ControllableFlags {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_ControllableFlags_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_display_settings_t_ControllableFlags_get(swigCPtr);
      return ret;
    } 
  }

  public uint ValidFlags {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_ValidFlags_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_display_settings_t_ValidFlags_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_low_latency_t LowLatency {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_LowLatency_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_low_latency_t ret = (ctl_display_setting_low_latency_t)CtlLibraryPINVOKE.ctl_display_settings_t_LowLatency_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_sourcetm_t SourceTM {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_SourceTM_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_sourcetm_t ret = (ctl_display_setting_sourcetm_t)CtlLibraryPINVOKE.ctl_display_settings_t_SourceTM_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_content_type_t ContentType {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_ContentType_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_content_type_t ret = (ctl_display_setting_content_type_t)CtlLibraryPINVOKE.ctl_display_settings_t_ContentType_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_quantization_range_t QuantizationRange {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_QuantizationRange_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_quantization_range_t ret = (ctl_display_setting_quantization_range_t)CtlLibraryPINVOKE.ctl_display_settings_t_QuantizationRange_get(swigCPtr);
      return ret;
    } 
  }

  public uint SupportedPictureAR {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_SupportedPictureAR_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_display_settings_t_SupportedPictureAR_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_picture_ar_flag_t PictureAR {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_PictureAR_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_picture_ar_flag_t ret = (ctl_display_setting_picture_ar_flag_t)CtlLibraryPINVOKE.ctl_display_settings_t_PictureAR_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_display_setting_audio_t AudioSettings {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_AudioSettings_set(swigCPtr, (int)value);
    } 
    get {
      ctl_display_setting_audio_t ret = (ctl_display_setting_audio_t)CtlLibraryPINVOKE.ctl_display_settings_t_AudioSettings_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_unsigned_int Reserved {
    set {
      CtlLibraryPINVOKE.ctl_display_settings_t_Reserved_set(swigCPtr, SWIGTYPE_p_unsigned_int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_display_settings_t_Reserved_get(swigCPtr);
      SWIGTYPE_p_unsigned_int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_unsigned_int(cPtr, false);
      return ret;
    } 
  }

  public ctl_display_settings_t() : this(CtlLibraryPINVOKE.new_ctl_display_settings_t(), true) {
  }

}

}
