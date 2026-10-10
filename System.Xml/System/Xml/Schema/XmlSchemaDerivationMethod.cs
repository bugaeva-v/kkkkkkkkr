using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Предоставляет различные методы для предотвращения создания производных типов.
	///       </summary>
	// Token: 0x020005A9 RID: 1449
	[Flags]
	public enum XmlSchemaDerivationMethod
	{
		/// <summary>
		///         Переопределите метод создания производных по умолчанию для разрешения любого вывода.
		///       </summary>
		// Token: 0x04002B1F RID: 11039
		[XmlEnum("")]
		Empty = 0,
		/// <summary>
		///         Ссылается на выводы посредством <see langword="Substitution" />.
		///       </summary>
		// Token: 0x04002B20 RID: 11040
		[XmlEnum("substitution")]
		Substitution = 1,
		/// <summary>
		///         Ссылается на выводы посредством <see langword="Extension" />.
		///       </summary>
		// Token: 0x04002B21 RID: 11041
		[XmlEnum("extension")]
		Extension = 2,
		/// <summary>
		///         Ссылается на выводы посредством <see langword="Restriction" />.
		///       </summary>
		// Token: 0x04002B22 RID: 11042
		[XmlEnum("restriction")]
		Restriction = 4,
		/// <summary>
		///         Ссылается на выводы посредством <see langword="List" />.
		///       </summary>
		// Token: 0x04002B23 RID: 11043
		[XmlEnum("list")]
		List = 8,
		/// <summary>
		///         Ссылается на выводы посредством <see langword="Union" />.
		///       </summary>
		// Token: 0x04002B24 RID: 11044
		[XmlEnum("union")]
		Union = 16,
		/// <summary>
		///         <see langword="#all" />.
		///          Ссылается на все методы вывода.
		///       </summary>
		// Token: 0x04002B25 RID: 11045
		[XmlEnum("#all")]
		All = 255,
		/// <summary>
		///         Принимает метод создания производных по умолчанию.
		///       </summary>
		// Token: 0x04002B26 RID: 11046
		[XmlIgnore]
		None = 256
	}
}
