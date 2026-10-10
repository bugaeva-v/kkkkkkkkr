using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020003E4 RID: 996
	[RequiredByNativeCode]
	public class OnDemandRendering
	{
		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x00033F94 File Offset: 0x00032194
		public static bool willCurrentFrameRender
		{
			get
			{
				return Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001FDC RID: 8156 RVA: 0x00033FB4 File Offset: 0x000321B4
		// (set) Token: 0x06001FDD RID: 8157 RVA: 0x00033FCB File Offset: 0x000321CB
		public static int renderFrameInterval
		{
			get
			{
				return OnDemandRendering.m_RenderFrameInterval;
			}
			set
			{
				OnDemandRendering.m_RenderFrameInterval = Math.Max(1, value);
			}
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00033FDA File Offset: 0x000321DA
		[RequiredByNativeCode]
		internal static void GetRenderFrameInterval(out int frameInterval)
		{
			frameInterval = OnDemandRendering.renderFrameInterval;
		}

		// Token: 0x06001FDF RID: 8159
		[FreeFunction]
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern float GetEffectiveRenderFrameRate();

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001FE0 RID: 8160 RVA: 0x00033FE4 File Offset: 0x000321E4
		public static int effectiveRenderFrameRate
		{
			get
			{
				float effectiveRenderFrameRate = OnDemandRendering.GetEffectiveRenderFrameRate();
				bool flag = (double)effectiveRenderFrameRate <= 0.0;
				int result;
				if (flag)
				{
					result = (int)effectiveRenderFrameRate;
				}
				else
				{
					result = (int)(effectiveRenderFrameRate + 0.5f);
				}
				return result;
			}
		}

		// Token: 0x04000C32 RID: 3122
		private static int m_RenderFrameInterval = 1;
	}
}
