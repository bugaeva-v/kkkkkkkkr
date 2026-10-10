using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200032B RID: 811
	internal class GradientRemapPool : LinkedPool<GradientRemap>
	{
		// Token: 0x06001A66 RID: 6758 RVA: 0x000727E0 File Offset: 0x000709E0
		public GradientRemapPool() : base(() => new GradientRemap(), delegate(GradientRemap gradientRemap)
		{
			gradientRemap.Reset();
		}, 10000)
		{
		}
	}
}
