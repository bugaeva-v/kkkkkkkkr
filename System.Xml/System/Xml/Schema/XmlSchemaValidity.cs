using System;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет действия элемента XML проверяется <see cref="T:System.Xml.Schema.XmlSchemaValidator" /> класса.
	///       </summary>
	// Token: 0x020005EC RID: 1516
	public enum XmlSchemaValidity
	{
		/// <summary>
		///         Допустимость XML-элемента неизвестен.
		///       </summary>
		// Token: 0x04002C2F RID: 11311
		NotKnown,
		/// <summary>
		///         Элемент XML является допустимым.
		///       </summary>
		// Token: 0x04002C30 RID: 11312
		Valid,
		/// <summary>
		///         Недопустимый элемент XML.
		///       </summary>
		// Token: 0x04002C31 RID: 11313
		Invalid
	}
}
