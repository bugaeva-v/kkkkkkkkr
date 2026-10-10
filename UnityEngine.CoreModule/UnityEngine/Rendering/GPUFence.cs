using System;

namespace UnityEngine.Rendering
{
	// Token: 0x020003A0 RID: 928
	[Obsolete("GPUFence has been deprecated. Use GraphicsFence instead (UnityUpgradable) -> GraphicsFence", false)]
	public struct GPUFence
	{
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x06001F57 RID: 8023 RVA: 0x00033244 File Offset: 0x00031444
		public bool passed
		{
			get
			{
				return true;
			}
		}
	}
}
