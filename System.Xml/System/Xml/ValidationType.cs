using System;

namespace System.Xml
{
	/// <summary>
	///         Указывает тип выполняемой проверки.
	///       </summary>
	// Token: 0x0200005F RID: 95
	public enum ValidationType
	{
		/// <summary>
		///         Проверка не производится.
		///          Если задан этот параметр, создается совместимое с XML 1.0 средство синтаксического анализа, не выполняющее проверки. .
		///       </summary>
		// Token: 0x040006A4 RID: 1700
		None,
		/// <summary>
		///         Проверка наличия сведений о DTD или схеме.
		///       </summary>
		// Token: 0x040006A5 RID: 1701
		[Obsolete("Validation type should be specified as DTD or Schema.")]
		Auto,
		/// <summary>
		///         Проверка в соответствии с DTD.
		///       </summary>
		// Token: 0x040006A6 RID: 1702
		DTD,
		/// <summary>
		///         Проверка в соответствии со схемами XDR, включая встроенные схемы XDR.
		///          Схемы XDR распознаются с помощью <see langword="x-schema" /> префикс пространства имен или <see cref="P:System.Xml.XmlValidatingReader.Schemas" /> свойства.
		///       </summary>
		// Token: 0x040006A7 RID: 1703
		[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
		XDR,
		/// <summary>
		///         Проверка в соответствии со схемами языка определения схем XML (XSD), включая встроенные схемы XML.
		///          Схемы XML связаны с URI пространства имен с помощью <see langword="schemaLocation" /> атрибута или указанного <see langword="Schemas" /> свойство.
		///       </summary>
		// Token: 0x040006A8 RID: 1704
		Schema
	}
}
