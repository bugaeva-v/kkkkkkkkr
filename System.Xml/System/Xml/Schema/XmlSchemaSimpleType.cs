using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="simpleType" /> элемент для простого содержимого из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс определяет простой тип.
	///          Простые типы могут содержать сведения и ограничения для значений атрибутов или элементов, которые допускают только текстовое содержимое.
	///       </summary>
	// Token: 0x020005DD RID: 1501
	public class XmlSchemaSimpleType : XmlSchemaType
	{
		/// <summary>
		///         Возвращает или задает один из <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeUnion" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeList" />, или <see cref="T:System.Xml.Schema.XmlSchemaSimpleTypeRestriction" />.
		///       </summary>
		/// <returns>
		///         Один из <see langword="XmlSchemaSimpleTypeUnion" />, <see langword="XmlSchemaSimpleTypeList" />, или <see langword="XmlSchemaSimpleTypeRestriction" />.
		///       </returns>
		// Token: 0x17000BC2 RID: 3010
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x00150FDC File Offset: 0x0014F1DC
		// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00150FE4 File Offset: 0x0014F1E4
		[XmlElement("restriction", typeof(XmlSchemaSimpleTypeRestriction))]
		[XmlElement("list", typeof(XmlSchemaSimpleTypeList))]
		[XmlElement("union", typeof(XmlSchemaSimpleTypeUnion))]
		public XmlSchemaSimpleTypeContent Content
		{
			get
			{
				return this.content;
			}
			set
			{
				this.content = value;
			}
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x00150FED File Offset: 0x0014F1ED
		internal override XmlQualifiedName DerivedFrom
		{
			get
			{
				if (this.content == null)
				{
					return XmlQualifiedName.Empty;
				}
				if (this.content is XmlSchemaSimpleTypeRestriction)
				{
					return ((XmlSchemaSimpleTypeRestriction)this.content).BaseTypeName;
				}
				return XmlQualifiedName.Empty;
			}
		}

		// Token: 0x06003C36 RID: 15414 RVA: 0x00151020 File Offset: 0x0014F220
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaSimpleType xmlSchemaSimpleType = (XmlSchemaSimpleType)base.MemberwiseClone();
			if (this.content != null)
			{
				xmlSchemaSimpleType.Content = (XmlSchemaSimpleTypeContent)this.content.Clone();
			}
			return xmlSchemaSimpleType;
		}

		// Token: 0x04002BC5 RID: 11205
		private XmlSchemaSimpleTypeContent content;
	}
}
