using System;
using System.Runtime.InteropServices;

namespace System.Globalization
{
	/// <summary>Определяет разные языковые версии григорианского календаря.</summary>
	// Token: 0x0200098B RID: 2443
	[ComVisible(true)]
	[Serializable]
	public enum GregorianCalendarTypes
	{
		/// <summary>Ссылается на локализованную версию григорианского календаря на основе языка <see cref="T:System.Globalization.CultureInfo" />, использующего <see cref="T:System.Globalization.DateTimeFormatInfo" />.</summary>
		// Token: 0x04003610 RID: 13840
		Localized = 1,
		/// <summary>Ссылается на англо- американскую версию григорианского календаря.</summary>
		// Token: 0x04003611 RID: 13841
		USEnglish,
		/// <summary>Ссылается на ближневосточную французскую версию григорианского календаря.</summary>
		// Token: 0x04003612 RID: 13842
		MiddleEastFrench = 9,
		/// <summary>Ссылается на арабскую версию григорианского календаря.</summary>
		// Token: 0x04003613 RID: 13843
		Arabic,
		/// <summary>Ссылается на транслитерированную английскую версию григорианского календаря.</summary>
		// Token: 0x04003614 RID: 13844
		TransliteratedEnglish,
		/// <summary>Ссылается на транслитерированную французскую версию григорианского календаря.</summary>
		// Token: 0x04003615 RID: 13845
		TransliteratedFrench
	}
}
