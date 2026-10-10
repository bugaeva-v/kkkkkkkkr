using System;

namespace System.Drawing
{
	/// <summary>Перечисление <see cref="T:System.Drawing.StringDigitSubstitute" /> указывает, как заменять знаки в строке в соответствии с местом проживания или языком пользователя.</summary>
	// Token: 0x0200003C RID: 60
	public enum StringDigitSubstitute
	{
		/// <summary>Задает определяемую пользователем схему замены.</summary>
		// Token: 0x0400035C RID: 860
		User,
		/// <summary>Задает отключение замены.</summary>
		// Token: 0x0400035D RID: 861
		None,
		/// <summary>Указывает знаки замены, соответствующие соответствующие официальному государственному языку страны, где проживает пользователь.</summary>
		// Token: 0x0400035E RID: 862
		National,
		/// <summary>Определяет символы для замены, соответствующие родному языку пользователя, который может отличаться от официального языка его страны.</summary>
		// Token: 0x0400035F RID: 863
		Traditional
	}
}
