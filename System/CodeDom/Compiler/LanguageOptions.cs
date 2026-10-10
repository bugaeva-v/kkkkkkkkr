using System;

namespace System.CodeDom.Compiler
{
	/// <summary>Определяет идентификаторы, указывающие особенности языка.</summary>
	// Token: 0x02000354 RID: 852
	[Flags]
	public enum LanguageOptions
	{
		/// <summary>Язык имеет характеристики по умолчанию.</summary>
		// Token: 0x04000E6C RID: 3692
		None = 0,
		/// <summary>В языке регистр не учитывается.</summary>
		// Token: 0x04000E6D RID: 3693
		CaseInsensitive = 1
	}
}
