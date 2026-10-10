using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Указывает, должны ли атрибуты или элементы получать префикс пространства имен.
	///       </summary>
	// Token: 0x020005BD RID: 1469
	public enum XmlSchemaForm
	{
		/// <summary>
		///         Форма элемента и атрибута не указан в схеме.
		///       </summary>
		// Token: 0x04002B5F RID: 11103
		[XmlIgnore]
		None,
		/// <summary>
		///         Элементы и атрибуты должны быть дополнены префиксом пространства имен.
		///       </summary>
		// Token: 0x04002B60 RID: 11104
		[XmlEnum("qualified")]
		Qualified,
		/// <summary>
		///         Элементы и атрибуты не требуются в соответствии с префиксом пространства имен.
		///       </summary>
		// Token: 0x04002B61 RID: 11105
		[XmlEnum("unqualified")]
		Unqualified
	}
}
