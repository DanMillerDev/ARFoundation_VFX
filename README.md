# ARFoundation_VFX
AR Foundation setup for URP and VFX graph

![gif](AR_VFX.gif)
-------------------
**Current Unity version: 2019.4.15**

The main scene is ARVFX Scene

This project is currently **ONLY** supported on ARKit because the VFX graph currently only works with Metal and Vulkan rendering. ARCore does not currently support Vulkan. Because of this I have added a small script ```VFXCompatibilityCheck.cs``` which checks the current ```SystemInfo.graphicsDeviceType``` and enables a small UI when not supported on a device or platform.

Built using preview packages for ARFoundation and ARKit **package versions: 4.1.0 -preview.5**

Universal Render Pipeline **package version 7.3.1**  
Visual Effect Graph **package version 7.3.1**

-------------------

This project shows how Universal render pipeline can be configured with AR Foundation. In order to add URP or LWRP to your AR Foundation follow the steps from the documentation [here](https://docs.unity3d.com/Packages/com.unity.xr.arfoundation@3.0/manual/ar-camera-background-with-scriptable-render-pipeline.html?q=urp)

The sample VFX graph included in the project is from [Unity's VFX Samples](https://github.com/Unity-Technologies/VisualEffectGraph-Samples) called Unity Logo, I have modified it slightly to have less particles.


-------------------






The core of this project is built from AR Foundation demos https://github.com/Unity-Technologies/arfoundation-demos which is copyright © 2019 Unity Technologies ApS
