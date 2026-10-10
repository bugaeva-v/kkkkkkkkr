using System;

namespace System.Xml
{
	/// <summary>
	///         Определяет способ обработки пробелов.
	///       </summary>
	// Token: 0x02000060 RID: 96
	public enum WhitespaceHandling
	{
		/// <summary>
		///         Вернуть <see langword="Whitespace" /> и <see langword="SignificantWhitespace" /> узлов.
		///          Это значение по умолчанию.
		///       </summary>
		// Token: 0x040006AA RID: 1706
		All,
		/// <summary>
		///         Возвращает <see langword="SignificantWhitespace" /> только узлы.
		///       </summary>
		// Token: 0x040006AB RID: 1707
		Significant,
		/// <summary>
		///         Не возвращает <see langword="Whitespace" /> и не <see langword="SignificantWhitespace" /> узлов.
		///       </summary>
		// Token: 0x040006AC RID: 1708
		None
	}
}
