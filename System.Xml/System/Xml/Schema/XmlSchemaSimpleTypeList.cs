using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="list" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс может использоваться для определения <see langword="simpleType" /> как список значений указанного типа данных.
	///       </summary>
	// Token: 0x020005DF RID: 1503
	public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent
	{
		/// <summary>
		///         Возвращает или задает имя встроенного типа данных или <see langword="simpleType" /> элемента, определенного в этой схеме (или другой схеме, задаваемой указанным пространством имен).
		///       </summary>
		/// <returns>
		///         Имя типа списка простых типов.
		///       </returns>
		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06003C38 RID: 15416 RVA: 0x00151058 File Offset: 0x0014F258
		// (set) Token: 0x06003C39 RID: 15417 RVA: 0x00151060 File Offset: 0x0014F260
		[XmlAttribute("itemType")]
		public XmlQualifiedName ItemTypeName
		{
			get
			{
				return this.itemTypeName;
			}
			set
			{
				this.itemTypeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает или задает <see langword="simpleType" /> элемент, который является производным от типа, заданного базовым значением.
		///       </summary>
		/// <returns>
		///         Тип элемента для элемента простого типа.
		///       </returns>
		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06003C3A RID: 15418 RVA: 0x00151079 File Offset: 0x0014F279
		// (set) Token: 0x06003C3B RID: 15419 RVA: 0x00151081 File Offset: 0x0014F281
		[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
		public XmlSchemaSimpleType ItemType
		{
			get
			{
				return this.itemType;
			}
			set
			{
				this.itemType = value;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> представляет тип <see langword="simpleType" /> на основе элемента <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeList.ItemType" /> и <see cref="P:System.Xml.Schema.XmlSchemaSimpleTypeList.ItemTypeName" /> значений простого типа.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> Представляет тип <see langword="simpleType" /> элемента.
		///       </returns>
		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06003C3C RID: 15420 RVA: 0x0015108A File Offset: 0x0014F28A
		// (set) Token: 0x06003C3D RID: 15421 RVA: 0x00151092 File Offset: 0x0014F292
		[XmlIgnore]
		public XmlSchemaSimpleType BaseItemType
		{
			get
			{
				return this.baseItemType;
			}
			set
			{
				this.baseItemType = value;
			}
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x0015109B File Offset: 0x0014F29B
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaSimpleTypeList xmlSchemaSimpleTypeList = (XmlSchemaSimpleTypeList)base.MemberwiseClone();
			xmlSchemaSimpleTypeList.ItemTypeName = this.itemTypeName.Clone();
			return xmlSchemaSimpleTypeList;
		}

		// Token: 0x04002BC6 RID: 11206
		private XmlQualifiedName itemTypeName = XmlQualifiedName.Empty;

		// Token: 0x04002BC7 RID: 11207
		private XmlSchemaSimpleType itemType;

		// Token: 0x04002BC8 RID: 11208
		private XmlSchemaSimpleType baseItemType;
	}
}
