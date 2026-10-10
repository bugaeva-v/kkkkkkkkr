using System;

namespace Castle.Components.DictionaryAdapter.Xml
{
	// Token: 0x020001AF RID: 431
	internal static class StringExtensions
	{
		// Token: 0x06000D2C RID: 3372 RVA: 0x0001FD6C File Offset: 0x0001DF6C
		public static string NonEmpty(this string s)
		{
			if (!string.IsNullOrEmpty(s))
			{
				return s;
			}
			return null;
		}
	}
}
