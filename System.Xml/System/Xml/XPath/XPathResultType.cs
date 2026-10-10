using System;

namespace System.Xml.XPath
{
	/// <summary>
	///         Указывает тип, возвращаемый выражением XPath.
	///       </summary>
	// Token: 0x02000255 RID: 597
	public enum XPathResultType
	{
		/// <summary>
		///         Числовое значение.
		///       </summary>
		// Token: 0x040017F6 RID: 6134
		Number,
		/// <summary>
		///         Значение <see cref="T:System.String" />.
		///       </summary>
		// Token: 0x040017F7 RID: 6135
		String,
		/// <summary>
		///         Объект <see cref="T:System.Boolean" /><see langword="true" /> или <see langword="false" /> значение.
		///       </summary>
		// Token: 0x040017F8 RID: 6136
		Boolean,
		/// <summary>
		///         Коллекция узлов.
		///       </summary>
		// Token: 0x040017F9 RID: 6137
		NodeSet,
		/// <summary>
		///         Фрагмент дерева.
		///       </summary>
		// Token: 0x040017FA RID: 6138
		Navigator = 1,
		/// <summary>
		///         Любые типы узлов XPath.
		///       </summary>
		// Token: 0x040017FB RID: 6139
		Any = 5,
		/// <summary>
		///         Выражение не выполняет вычисления в правильный тип XPath.
		///       </summary>
		// Token: 0x040017FC RID: 6140
		Error
	}
}
