using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Указывает порядок и структуру дочерних элементов типа.
	///       </summary>
	// Token: 0x020005A5 RID: 1445
	public abstract class XmlSchemaContentModel : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает содержимое типа.
		///       </summary>
		/// <returns>
		///         Предоставляет содержимое типа.
		///       </returns>
		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06003A7F RID: 14975
		// (set) Token: 0x06003A80 RID: 14976
		[XmlIgnore]
		public abstract XmlSchemaContent Content { get; set; }
	}
}
