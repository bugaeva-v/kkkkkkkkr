using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="attributeGroup" /> элемент с <see langword="ref" /> атрибутов из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          AttributesGroupRef ссылкой для группу атрибутов, имя свойства содержит выполняется ссылка на группы атрибутов.
	///       </summary>
	// Token: 0x0200059A RID: 1434
	public class XmlSchemaAttributeGroupRef : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает имя упоминаемого <see langword="attributeGroup" /> элемента.
		///       </summary>
		/// <returns>
		///         Имя группы атрибутов, на которую указывает ссылка.
		///          Значение должно быть QName.
		///       </returns>
		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x0014C1D9 File Offset: 0x0014A3D9
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x0014C1E1 File Offset: 0x0014A3E1
		[XmlAttribute("ref")]
		public XmlQualifiedName RefName
		{
			get
			{
				return this.refName;
			}
			set
			{
				this.refName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		// Token: 0x04002AE9 RID: 10985
		private XmlQualifiedName refName = XmlQualifiedName.Empty;
	}
}
