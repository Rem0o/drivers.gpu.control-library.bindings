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

public class ctl_power_optimization_settings_t : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ctl_power_optimization_settings_t(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ctl_power_optimization_settings_t obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  internal static global::System.Runtime.InteropServices.HandleRef swigRelease(ctl_power_optimization_settings_t obj) {
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

  ~ctl_power_optimization_settings_t() {
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
          CtlLibraryPINVOKE.delete_ctl_power_optimization_settings_t(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public uint Size {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Size_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Size_get(swigCPtr);
      return ret;
    } 
  }

  public byte Version {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Version_set(swigCPtr, value);
    } 
    get {
      byte ret = CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Version_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_power_optimization_plan_t PowerOptimizationPlan {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerOptimizationPlan_set(swigCPtr, (int)value);
    } 
    get {
      ctl_power_optimization_plan_t ret = (ctl_power_optimization_plan_t)CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerOptimizationPlan_get(swigCPtr);
      return ret;
    } 
  }

  public uint PowerOptimizationFeature {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerOptimizationFeature_set(swigCPtr, value);
    } 
    get {
      uint ret = CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerOptimizationFeature_get(swigCPtr);
      return ret;
    } 
  }

  public bool Enable {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Enable_set(swigCPtr, value);
    } 
    get {
      bool ret = CtlLibraryPINVOKE.ctl_power_optimization_settings_t_Enable_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_power_optimization_feature_specific_info_t FeatureSpecificData {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_FeatureSpecificData_set(swigCPtr, ctl_power_optimization_feature_specific_info_t.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = CtlLibraryPINVOKE.ctl_power_optimization_settings_t_FeatureSpecificData_get(swigCPtr);
      ctl_power_optimization_feature_specific_info_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new ctl_power_optimization_feature_specific_info_t(cPtr, false);
      return ret;
    } 
  }

  public ctl_power_source_t PowerSource {
    set {
      CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerSource_set(swigCPtr, (int)value);
    } 
    get {
      ctl_power_source_t ret = (ctl_power_source_t)CtlLibraryPINVOKE.ctl_power_optimization_settings_t_PowerSource_get(swigCPtr);
      return ret;
    } 
  }

  public ctl_power_optimization_settings_t() : this(CtlLibraryPINVOKE.new_ctl_power_optimization_settings_t(), true) {
  }

}

}
