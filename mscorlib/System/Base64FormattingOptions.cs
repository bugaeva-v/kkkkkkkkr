using System;

namespace System
{
	/// <summary>Указывает, вставляют ли соответствующие методы <see cref="Overload:System.Convert.ToBase64CharArray" /> и <see cref="Overload:System.Convert.ToBase64String" /> разрыва строк в свои выходные данные.</summary>
	// Token: 0x02000108 RID: 264
	[Flags]
	public enum Base64FormattingOptions
	{
		/// <summary>Не вставляет разрывы строк после каждых 76 символов в строковом представлении.</summary>
		// Token: 0x0400108C RID: 4236
		None = 0,
		/// <summary>Вставляет разрывы строк после каждых 76 символов в строковом представлении.</summary>
		// Token: 0x0400108D RID: 4237
		InsertLineBreaks = 1
	}
}
