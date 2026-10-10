using System;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000328 RID: 808
	internal class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo>
	{
		// Token: 0x06001A5F RID: 6751 RVA: 0x00072744 File Offset: 0x00070944
		public VectorImageRenderInfoPool() : base(() => new VectorImageRenderInfo(), delegate(VectorImageRenderInfo vectorImageInfo)
		{
			vectorImageInfo.Reset();
		}, 10000)
		{
		}
	}
}
