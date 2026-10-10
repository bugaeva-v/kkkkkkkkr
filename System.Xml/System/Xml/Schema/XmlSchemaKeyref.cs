using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Этот класс представляет <see langword="keyref" /> элемента из XML-схемы в соответствии с World Wide Web Consortium (W3C).
	///       </summary>
	// Token: 0x020005C5 RID: 1477
	public class XmlSchemaKeyref : XmlSchemaIdentityConstraint
	{
		/// <summary>
		///         Возвращает или задает имя ключа, на который ссылается данное ограничение в другом простом или сложном типе.
		///       </summary>
		/// <returns>
		///         QName ключа, на которое ссылается данное ограничение.
		///       </returns>
		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06003B48 RID: 15176 RVA: 0x0014E25B File Offset: 0x0014C45B
		// (set) Token: 0x06003B49 RID: 15177 RVA: 0x0014E263 File Offset: 0x0014C463
		[XmlAttribute("refer")]
		public XmlQualifiedName Refer
		{
			get
			{
				return this.refer;
			}
			set
			{
				this.refer = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		// Token: 0x04002B71 RID: 11121
		private XmlQualifiedName refer = XmlQualifiedName.Empty;
	}
}
