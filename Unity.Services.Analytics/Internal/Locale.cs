using System;
using System.Globalization;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000028 RID: 40
	internal static class Locale
	{
		// Token: 0x06000100 RID: 256 RVA: 0x000046C1 File Offset: 0x000028C1
		internal static string CurrentLanguageCode()
		{
			return CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000046CD File Offset: 0x000028CD
		internal static string AnalyticsRegionLanguageCode()
		{
			return Locale.CurrentLanguageCode() + "_ZZ";
		}
	}
}
