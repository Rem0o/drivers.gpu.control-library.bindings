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

public class ctl_device_adapter_properties_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_device_adapter_properties_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_device_adapter_properties_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_device_adapter_properties_t obj) {
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

  ~ctl_device_adapter_properties_t() {
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
          CtlApiPINVOKE.delete_ctl_device_adapter_properties_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void pDeviceID {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_pDeviceID_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_device_adapter_properties_t_pDeviceID_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public uint device_id_size {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_device_id_size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_device_id_size_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_device_type_t device_type {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_device_type_set(swigCPtr, (int)value);
    } 
    get {
      ctl_device_type_t ret = (ctl_device_type_t)CtlApiPINVOKE.ctl_device_adapter_properties_t_device_type_get(swigCPtr);
      return ret;
    } 
  }

  public uint supported_subfunction_flags {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_supported_subfunction_flags_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_supported_subfunction_flags_get(swigCPtr);
      return ret;
    } 
  }

  public ulong driver_version {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_driver_version_set(swigCPtr, value);
    } 
    get {
      ulong ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_driver_version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_firmware_version_t firmware_version {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_firmware_version_set(swigCPtr, ctl_firmware_version_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_device_adapter_properties_t_firmware_version_get(swigCPtr);
      ctl_firmware_version_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_firmware_version_t(cPtr, false);
      return ret;
    } 
  }

  public uint pci_vendor_id {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_vendor_id_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_vendor_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint pci_device_id {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_device_id_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_device_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint rev_id {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_rev_id_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_rev_id_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_eus_per_sub_slice {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_num_eus_per_sub_slice_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_num_eus_per_sub_slice_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_sub_slices_per_slice {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_num_sub_slices_per_slice_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_num_sub_slices_per_slice_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_slices {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_num_slices_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_num_slices_get(swigCPtr);
      return ret;
    } 
  }

  public string name {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_name_set(swigCPtr, value);
    } 
    get {
      string ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_name_get(swigCPtr);
      return ret;
    } 
  }

  public uint graphics_adapter_properties {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_graphics_adapter_properties_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_graphics_adapter_properties_get(swigCPtr);
      return ret;
    } 
  }

  public uint Frequency {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_Frequency_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_Frequency_get(swigCPtr);
      return ret;
    } 
  }

  public ushort pci_subsys_id {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_subsys_id_set(swigCPtr, value);
    } 
    get {
      ushort ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_subsys_id_get(swigCPtr);
      return ret;
    } 
  }

  public ushort pci_subsys_vendor_id {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_subsys_vendor_id_set(swigCPtr, value);
    } 
    get {
      ushort ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_pci_subsys_vendor_id_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_adapter_bdf_t adapter_bdf {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_adapter_bdf_set(swigCPtr, ctl_adapter_bdf_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlApiPINVOKE.ctl_device_adapter_properties_t_adapter_bdf_get(swigCPtr);
      ctl_adapter_bdf_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_adapter_bdf_t(cPtr, false);
      return ret;
    } 
  }

  public string reserved {
    set {
      CtlApiPINVOKE.ctl_device_adapter_properties_t_reserved_set(swigCPtr, value);
    } 
    get {
      string ret = CtlApiPINVOKE.ctl_device_adapter_properties_t_reserved_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_device_adapter_properties_t() : this(CtlApiPINVOKE.new_ctl_device_adapter_properties_t(), true) {
  }

}

}
