using System;

namespace System.Runtime.InteropServices
{
	/// <summary>Взамен рекомендуется использовать <see cref="T:System.Runtime.InteropServices.ComTypes.SYSKIND" />.</summary>
	// Token: 0x02000750 RID: 1872
	[Obsolete]
	[Serializable]
	public enum SYSKIND
	{
		/// <summary>Целевая операционная система для библиотеки типов — 16-разрядные системы Windows. Поля данных по умолчанию упакованы.</summary>
		// Token: 0x04002BFE RID: 11262
		SYS_WIN16,
		/// <summary>Целевая операционная система для библиотеки типов — 32-разрядные системы Windows. Поля данных по умолчанию выровнены естественным образом (например, 2-байтовые целые числа выровнены по границам четных байтов, 4-байтовые целые числа — по границам четырехбайтовых слов и т. д.).</summary>
		// Token: 0x04002BFF RID: 11263
		SYS_WIN32,
		/// <summary>Целевая операционная система для библиотеки типов — Apple Macintosh. По умолчанию все поля данных выравниваются по границам четных байтов.</summary>
		// Token: 0x04002C00 RID: 11264
		SYS_MAC
	}
}
