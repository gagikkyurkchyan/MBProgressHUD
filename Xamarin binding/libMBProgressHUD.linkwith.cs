using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libMBProgressHUD.a", LinkTarget.ArmV7 | LinkTarget.Simulator, SmartLink = true, ForceLoad = true)]
