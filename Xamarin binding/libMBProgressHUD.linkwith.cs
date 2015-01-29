using System;
using ObjCRuntime;

[assembly: LinkWith ("libMBProgressHUD.a", LinkTarget.ArmV7 | LinkTarget.Arm64, SmartLink = true, ForceLoad = true)]
