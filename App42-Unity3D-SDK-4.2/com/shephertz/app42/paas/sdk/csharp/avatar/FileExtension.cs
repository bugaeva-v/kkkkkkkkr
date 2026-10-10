using System;

namespace com.shephertz.app42.paas.sdk.csharp.avatar
{
	// Token: 0x02000024 RID: 36
	public sealed class FileExtension
	{
		// Token: 0x06000157 RID: 343 RVA: 0x00006D97 File Offset: 0x00004F97
		public static bool IsValidType(string type)
		{
			return FileExtension.JPEG.Equals(type) || FileExtension.GIF.Equals(type) || FileExtension.JPG.Equals(type) || FileExtension.PNG.Equals(type);
		}

		// Token: 0x0400007F RID: 127
		public static readonly string PNG = "png";

		// Token: 0x04000080 RID: 128
		public static readonly string JPG = "jpg";

		// Token: 0x04000081 RID: 129
		public static readonly string GIF = "gif";

		// Token: 0x04000082 RID: 130
		public static readonly string JPEG = "jpeg";
	}
}
