using System;

namespace System.Globalization
{
	/// <summary>Определяет типы списков языков и региональных параметров, которые можно получить с помощью метода <see cref="M:System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes)" />.</summary>
	// Token: 0x02000958 RID: 2392
	[Flags]
	public enum CultureTypes
	{
		/// <summary>Языки и региональные параметры, которые связаны с языком, но не являются специфичными для страны или региона.</summary>
		// Token: 0x040033D5 RID: 13269
		NeutralCultures = 1,
		/// <summary>Конкретные языки и региональные параметры, характерные для стран или регионов.</summary>
		// Token: 0x040033D6 RID: 13270
		SpecificCultures = 2,
		/// <summary>Этот элемент считается нерекомендуемым. Все языки и региональные параметры, установленные в операционной системе Windows.</summary>
		// Token: 0x040033D7 RID: 13271
		InstalledWin32Cultures = 4,
		/// <summary>Все языки и региональные параметры, распознаваемые .NET, включая нейтральные и определенные, а также созданные пользователем.
		/// В .NET Framework 4 и более поздних версиях и .NET Core под управлением Windows содержатся данные языка и региональных параметров, доступные в операционной системе Windows. В .NET Core под управлением Linux и macOS содержатся данные языка и региональных параметров, которые определены в библиотеках ICU.
		///  <see cref="F:System.Globalization.CultureTypes.AllCultures" /> представляет собой составное поле, содержащее значения <see cref="F:System.Globalization.CultureTypes.NeutralCultures" />, <see cref="F:System.Globalization.CultureTypes.SpecificCultures" /> и <see cref="F:System.Globalization.CultureTypes.InstalledWin32Cultures" />.</summary>
		// Token: 0x040033D8 RID: 13272
		AllCultures = 7,
		/// <summary>Этот элемент считается нерекомендуемым. Пользовательские языки и региональные параметры, созданные пользователем.</summary>
		// Token: 0x040033D9 RID: 13273
		UserCustomCulture = 8,
		/// <summary>Этот элемент считается нерекомендуемым. Пользовательские языки и региональные параметры, созданные пользователем, заменяющие языки и региональные параметры, поставляемые вместе с платформой .NET Framework.</summary>
		// Token: 0x040033DA RID: 13274
		ReplacementCultures = 16,
		/// <summary>Этот элемент считается нерекомендуемым и игнорируется.</summary>
		// Token: 0x040033DB RID: 13275
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		WindowsOnlyCultures = 32,
		/// <summary>Этот элемент считается нерекомендуемым. При использовании этого значения с <see cref="M:System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes)" /> будут возвращены нейтральные и конкретные языки и региональные параметры, поставляемые с платформой .NET Framework 2.0.</summary>
		// Token: 0x040033DC RID: 13276
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		FrameworkCultures = 64
	}
}
