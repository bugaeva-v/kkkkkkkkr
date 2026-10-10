using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000F1 RID: 241
	public static class GetAppleProductMetadataExtension
	{
		// Token: 0x06000487 RID: 1159 RVA: 0x0000A366 File Offset: 0x00008566
		public static AppleProductMetadata GetAppleProductMetadata(this ProductMetadata productMetadata)
		{
			return productMetadata as AppleProductMetadata;
		}
	}
}
