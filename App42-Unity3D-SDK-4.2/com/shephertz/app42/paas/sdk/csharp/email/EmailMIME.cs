using System;

namespace com.shephertz.app42.paas.sdk.csharp.email
{
	// Token: 0x0200003F RID: 63
	public sealed class EmailMIME
	{
		// Token: 0x0600026F RID: 623 RVA: 0x0000D64C File Offset: 0x0000B84C
		public static bool isValidType(string type)
		{
			return EmailMIME.PLAIN_TEXT_MIME_TYPE.Equals(type) || EmailMIME.HTML_TEXT_MIME_TYPE.Equals(type);
		}

		// Token: 0x040000D1 RID: 209
		public static readonly string PLAIN_TEXT_MIME_TYPE = "text/plain";

		// Token: 0x040000D2 RID: 210
		public static readonly string HTML_TEXT_MIME_TYPE = "text/html";
	}
}
