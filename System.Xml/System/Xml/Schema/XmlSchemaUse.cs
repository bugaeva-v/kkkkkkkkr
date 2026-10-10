using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Указывает, как используется атрибут.
	///       </summary>
	// Token: 0x020005E5 RID: 1509
	public enum XmlSchemaUse
	{
		/// <summary>
		///         Использование атрибута не указано.
		///       </summary>
		// Token: 0x04002BDD RID: 11229
		[XmlIgnore]
		None,
		/// <summary>
		///         Атрибут является необязательным.
		///       </summary>
		// Token: 0x04002BDE RID: 11230
		[XmlEnum("optional")]
		Optional,
		/// <summary>
		///         Атрибут нельзя использовать.
		///       </summary>
		// Token: 0x04002BDF RID: 11231
		[XmlEnum("prohibited")]
		Prohibited,
		/// <summary>
		///         Атрибут должен отобразиться один раз.
		///       </summary>
		// Token: 0x04002BE0 RID: 11232
		[XmlEnum("required")]
		Required
	}
}
