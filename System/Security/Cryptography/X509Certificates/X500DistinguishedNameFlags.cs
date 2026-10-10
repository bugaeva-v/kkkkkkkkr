using System;

namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Задает характеристики различающегося имени, соответствующего стандарту X.500.</summary>
	// Token: 0x020002C1 RID: 705
	[Flags]
	public enum X500DistinguishedNameFlags
	{
		/// <summary>В различающемся имени отсутствуют особые параметры.</summary>
		// Token: 0x04000C6D RID: 3181
		None = 0,
		/// <summary>Различающееся имя записывается в обратном порядке.</summary>
		// Token: 0x04000C6E RID: 3182
		Reversed = 1,
		/// <summary>В различающемся имени используются точки с запятой.</summary>
		// Token: 0x04000C6F RID: 3183
		UseSemicolons = 16,
		/// <summary>В различающемся имени не используется знак «плюс».</summary>
		// Token: 0x04000C70 RID: 3184
		DoNotUsePlusSign = 32,
		/// <summary>В различающемся имени не используются кавычки.</summary>
		// Token: 0x04000C71 RID: 3185
		DoNotUseQuotes = 64,
		/// <summary>В различающемся имени используются запятые.</summary>
		// Token: 0x04000C72 RID: 3186
		UseCommas = 128,
		/// <summary>В различающемся имени используется символ новой строки.</summary>
		// Token: 0x04000C73 RID: 3187
		UseNewLines = 256,
		/// <summary>В различающемся имени используется кодировка UTF8 вместо кодировки символов Юникода.</summary>
		// Token: 0x04000C74 RID: 3188
		UseUTF8Encoding = 4096,
		/// <summary>В различающемся имени используется кодировка T61.</summary>
		// Token: 0x04000C75 RID: 3189
		UseT61Encoding = 8192,
		/// <summary>Обеспечивает принудительную кодировку определенных ключей X.500 в различающемся имени как строк UTF-8, а не печатных строк Юникода. Дополнительную информацию и список затрагиваемых ключей X.500 см. в описании перечисления X500NameFlags.</summary>
		// Token: 0x04000C76 RID: 3190
		ForceUTF8Encoding = 16384
	}
}
