using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="extension" /> элемент для простого содержимого из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс используется для наследования простых типов через расширение.
	///          Такие наследования используются для расширения содержимого простого типа элемента посредством добавления атрибутов.
	///       </summary>
	// Token: 0x020005DB RID: 1499
	public class XmlSchemaSimpleContentExtension : XmlSchemaContent
	{
		/// <summary>
		///         Возвращает или задает имя встроенного или простого типа, из которого данный тип расширяется.
		///       </summary>
		/// <returns>
		///         Имя базового типа.
		///       </returns>
		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x00150EEE File Offset: 0x0014F0EE
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x00150EF6 File Offset: 0x0014F0F6
		[XmlAttribute("base")]
		public XmlQualifiedName BaseTypeName
		{
			get
			{
				return this.baseTypeName;
			}
			set
			{
				this.baseTypeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> и <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" />.
		///       </summary>
		/// <returns>
		///         Коллекция атрибутов для <see langword="simpleType" /> элемента.
		///       </returns>
		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x00150F0F File Offset: 0x0014F10F
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>
		///         Возвращает или задает <see langword="XmlSchemaAnyAttribute" /> для значения атрибута.
		///       </summary>
		/// <returns>
		///         <see langword="XmlSchemaAnyAttribute" />.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x06003C24 RID: 15396 RVA: 0x00150F17 File Offset: 0x0014F117
		// (set) Token: 0x06003C25 RID: 15397 RVA: 0x00150F1F File Offset: 0x0014F11F
		[XmlElement("anyAttribute")]
		public XmlSchemaAnyAttribute AnyAttribute
		{
			get
			{
				return this.anyAttribute;
			}
			set
			{
				this.anyAttribute = value;
			}
		}

		// Token: 0x06003C26 RID: 15398 RVA: 0x00150F28 File Offset: 0x0014F128
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04002BBD RID: 11197
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04002BBE RID: 11198
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04002BBF RID: 11199
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
