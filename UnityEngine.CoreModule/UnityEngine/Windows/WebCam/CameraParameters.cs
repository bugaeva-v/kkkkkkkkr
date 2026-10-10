using System;
using System.Linq;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Windows.WebCam
{
	// Token: 0x020002B4 RID: 692
	[UsedByNativeCode]
	[MovedFrom("UnityEngine.XR.WSA.WebCam")]
	[NativeHeader("PlatformDependent/Win/Webcam/CameraParameters.h")]
	public struct CameraParameters
	{
		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0002E81C File Offset: 0x0002CA1C
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0002E834 File Offset: 0x0002CA34
		public float hologramOpacity
		{
			get
			{
				return this.m_HologramOpacity;
			}
			set
			{
				this.m_HologramOpacity = value;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0002E840 File Offset: 0x0002CA40
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0002E858 File Offset: 0x0002CA58
		public float frameRate
		{
			get
			{
				return this.m_FrameRate;
			}
			set
			{
				this.m_FrameRate = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0002E864 File Offset: 0x0002CA64
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0002E87C File Offset: 0x0002CA7C
		public int cameraResolutionWidth
		{
			get
			{
				return this.m_CameraResolutionWidth;
			}
			set
			{
				this.m_CameraResolutionWidth = value;
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0002E888 File Offset: 0x0002CA88
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0002E8A0 File Offset: 0x0002CAA0
		public int cameraResolutionHeight
		{
			get
			{
				return this.m_CameraResolutionHeight;
			}
			set
			{
				this.m_CameraResolutionHeight = value;
			}
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0002E8AC File Offset: 0x0002CAAC
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0002E8C4 File Offset: 0x0002CAC4
		public CapturePixelFormat pixelFormat
		{
			get
			{
				return this.m_PixelFormat;
			}
			set
			{
				this.m_PixelFormat = value;
			}
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x0002E8D0 File Offset: 0x0002CAD0
		public CameraParameters(WebCamMode webCamMode)
		{
			this.m_HologramOpacity = 1f;
			this.m_PixelFormat = CapturePixelFormat.BGRA32;
			this.m_FrameRate = 0f;
			this.m_CameraResolutionWidth = 0;
			this.m_CameraResolutionHeight = 0;
			bool flag = webCamMode == WebCamMode.PhotoMode;
			if (flag)
			{
				Resolution resolution = (from res in PhotoCapture.SupportedResolutions
				orderby res.width * res.height descending
				select res).First<Resolution>();
				this.m_CameraResolutionWidth = resolution.width;
				this.m_CameraResolutionHeight = resolution.height;
			}
			else
			{
				bool flag2 = webCamMode == WebCamMode.VideoMode;
				if (flag2)
				{
					Resolution resolution2 = (from res in VideoCapture.SupportedResolutions
					orderby res.width * res.height descending
					select res).First<Resolution>();
					float frameRate = (from fps in VideoCapture.GetSupportedFrameRatesForResolution(resolution2)
					orderby fps descending
					select fps).First<float>();
					this.m_CameraResolutionWidth = resolution2.width;
					this.m_CameraResolutionHeight = resolution2.height;
					this.m_FrameRate = frameRate;
				}
			}
		}

		// Token: 0x04000982 RID: 2434
		private float m_HologramOpacity;

		// Token: 0x04000983 RID: 2435
		private float m_FrameRate;

		// Token: 0x04000984 RID: 2436
		private int m_CameraResolutionWidth;

		// Token: 0x04000985 RID: 2437
		private int m_CameraResolutionHeight;

		// Token: 0x04000986 RID: 2438
		private CapturePixelFormat m_PixelFormat;
	}
}
