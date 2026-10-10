using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Предоставляет сведения о режиме проверки <see langword="any" /> и <see langword="anyAttribute" /> замены элемента.
	///       </summary>
	// Token: 0x020005A6 RID: 1446
	public enum XmlSchemaContentProcessing
	{
		/// <summary>
		///         Элементы документа не проверяются.
		///       </summary>
		// Token: 0x04002B15 RID: 11029
		[XmlIgnore]
		None,
		/// <summary>
		///         Элементы документа должны состоять из XML-документа правильного формата и не проверяется по схеме.
		///       </summary>
		// Token: 0x04002B16 RID: 11030
		[XmlEnum("skip")]
		Skip,
		/// <summary>
		///         При обнаружении связанной схеме будет проверяться элементов документа.
		///          В противном случае будет создано без ошибок.
		///       </summary>
		// Token: 0x04002B17 RID: 11031
		[XmlEnum("lax")]
		Lax,
		/// <summary>
		///         Процессор схемы должен найти схему, связанную с указанным пространством имен для проверки элементов документа.
		///       </summary>
		// Token: 0x04002B18 RID: 11032
		[XmlEnum("strict")]
		Strict
	}
}
