using System;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000E6 RID: 230
	public static class GetGoogleProductMetadataExtension
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x0000A2AA File Offset: 0x000084AA
		public static GoogleProductMetadata GetGoogleProductMetadata(this ProductMetadata productMetadata)
		{
			return productMetadata as GoogleProductMetadata;
		}
	}
}
