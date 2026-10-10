using System;

namespace System.Xml.XPath
{
	/// <summary>
	///         Указывает порядок сортировки для прописные и строчные буквы.
	///       </summary>
	// Token: 0x02000253 RID: 595
	public enum XmlCaseOrder
	{
		/// <summary>
		///         Регистр не учитывается.
		///       </summary>
		// Token: 0x040017EF RID: 6127
		None,
		/// <summary>
		///         Прописные буквы сортируются перед строчными буквами.
		///       </summary>
		// Token: 0x040017F0 RID: 6128
		UpperFirst,
		/// <summary>
		///         Строчные буквы сортируются перед прописными буквами.
		///       </summary>
		// Token: 0x040017F1 RID: 6129
		LowerFirst
	}
}
