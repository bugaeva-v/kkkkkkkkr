using System;

namespace com.shephertz.app42.paas.sdk.csharp.upload
{
	// Token: 0x020000C1 RID: 193
	public sealed class UploadFileType
	{
		// Token: 0x06000831 RID: 2097 RVA: 0x0002FFCC File Offset: 0x0002E1CC
		public static bool IsValidType(string type)
		{
			return UploadFileType.AUDIO.Equals(type) || UploadFileType.VIDEO.Equals(type) || UploadFileType.IMAGE.Equals(type) || UploadFileType.BINARY.Equals(type) || UploadFileType.TXT.Equals(type) || UploadFileType.XML.Equals(type) || UploadFileType.CSV.Equals(type) || UploadFileType.JSON.Equals(type) || UploadFileType.OTHER.Equals(type) || UploadFileType.HTML.Equals(type);
		}

		// Token: 0x040002F3 RID: 755
		public static readonly string AUDIO = "AUDIO";

		// Token: 0x040002F4 RID: 756
		public static readonly string VIDEO = "VIDEO";

		// Token: 0x040002F5 RID: 757
		public static readonly string IMAGE = "IMAGE";

		// Token: 0x040002F6 RID: 758
		public static readonly string BINARY = "BINARY";

		// Token: 0x040002F7 RID: 759
		public static readonly string TXT = "TXT";

		// Token: 0x040002F8 RID: 760
		public static readonly string XML = "XML";

		// Token: 0x040002F9 RID: 761
		public static readonly string CSV = "CSV";

		// Token: 0x040002FA RID: 762
		public static readonly string JSON = "JSON";

		// Token: 0x040002FB RID: 763
		public static readonly string OTHER = "OTHER";

		// Token: 0x040002FC RID: 764
		public static readonly string HTML = "text";
	}
}
