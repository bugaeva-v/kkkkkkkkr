using System;

namespace JetBrains.Annotations
{
	// Token: 0x020000CF RID: 207
	[Flags]
	public enum CollectionAccessType
	{
		// Token: 0x04000262 RID: 610
		None = 0,
		// Token: 0x04000263 RID: 611
		Read = 1,
		// Token: 0x04000264 RID: 612
		ModifyExistingContent = 2,
		// Token: 0x04000265 RID: 613
		UpdatedContent = 6
	}
}
