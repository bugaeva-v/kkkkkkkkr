using System;
using System.Text;

namespace com.shephertz.app42.paas.sdk.csharp.util
{
	// Token: 0x02000026 RID: 38
	internal class Base64
	{
		// Token: 0x06000166 RID: 358 RVA: 0x000079C4 File Offset: 0x00005BC4
		public static string EncodeTo64(string toEncode)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(toEncode);
			return Convert.ToBase64String(bytes);
		}
	}
}
