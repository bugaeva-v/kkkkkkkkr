using System;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200019A RID: 410
	[UsedByNativeCode]
	public struct LOD
	{
		// Token: 0x06000EFC RID: 3836 RVA: 0x00012EFD File Offset: 0x000110FD
		public LOD(float screenRelativeTransitionHeight, Renderer[] renderers)
		{
			this.screenRelativeTransitionHeight = screenRelativeTransitionHeight;
			this.fadeTransitionWidth = 0f;
			this.renderers = renderers;
		}

		// Token: 0x040005A9 RID: 1449
		public float screenRelativeTransitionHeight;

		// Token: 0x040005AA RID: 1450
		public float fadeTransitionWidth;

		// Token: 0x040005AB RID: 1451
		public Renderer[] renderers;
	}
}
