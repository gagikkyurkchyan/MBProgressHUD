using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkWith ("libMBProgressHUD.a", LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, SmartLink = true, Frameworks = "CoreGraphics UIKit Foundation")]
[assembly: LinkerSafe]
