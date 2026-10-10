using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x020002B3 RID: 691
	[StaticAccessor("WebCam::GetInstance()", StaticAccessorType.Dot)]
	[NativeHeader("PlatformDependent/Win/Webcam/WebCam.h")]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	public class WebCam
	{
		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001D0F RID: 7439
		public static extern WebCamMode Mode { [NativeConditional("(PLATFORM_WIN || PLATFORM_WINRT) && !PLATFORM_XBOXONE")] [NativeName("GetWebCamMode")] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
