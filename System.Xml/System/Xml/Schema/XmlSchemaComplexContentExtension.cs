using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="extension" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс предназначен для сложных типов со сложной моделью содержимого, наследуемых через расширение.
	///          Он расширяет сложный тип, добавляя атрибуты и элементы.
	///       </summary>
	// Token: 0x020005A1 RID: 1441
	public class XmlSchemaComplexContentExtension : XmlSchemaContent
	{
		/// <summary>
		///         Возвращает или задает имя сложного типа, из которого этот тип создается путем расширения.
		///       </summary>
		/// <returns>
		///         Имя сложного типа, из которого этот тип создается путем расширения.
		///       </returns>
		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x0014C8C4 File Offset: 0x0014AAC4
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x0014C8CC File Offset: 0x0014AACC
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
		///         Возвращает или задает один из <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, или <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> классы.
		///       </summary>
		/// <returns>
		///         Один из <see cref="T:System.Xml.Schema.XmlSchemaGroupRef" />, <see cref="T:System.Xml.Schema.XmlSchemaChoice" />, <see cref="T:System.Xml.Schema.XmlSchemaAll" />, или <see cref="T:System.Xml.Schema.XmlSchemaSequence" /> классы.
		///       </returns>
		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x0014C8E5 File Offset: 0x0014AAE5
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x0014C8ED File Offset: 0x0014AAED
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		public XmlSchemaParticle Particle
		{
			get
			{
				return this.particle;
			}
			set
			{
				this.particle = value;
			}
		}

		/// <summary>
		///         Возвращает коллекцию атрибутов для сложного содержимого.
		///          Содержит <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> и <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> элементы.
		///       </summary>
		/// <returns>
		///         Коллекция атрибутов для сложного содержимого.
		///       </returns>
		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x0014C8F6 File Offset: 0x0014AAF6
		[XmlElement("attributeGroup", typeof(XmlSchemaAttributeGroupRef))]
		[XmlElement("attribute", typeof(XmlSchemaAttribute))]
		public XmlSchemaObjectCollection Attributes
		{
			get
			{
				return this.attributes;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> компонент сложные модели содержимого.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> Компонент сложные модели содержимого.
		///       </returns>
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003A46 RID: 14918 RVA: 0x0014C8FE File Offset: 0x0014AAFE
		// (set) Token: 0x06003A47 RID: 14919 RVA: 0x0014C906 File Offset: 0x0014AB06
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

		// Token: 0x06003A48 RID: 14920 RVA: 0x0014C90F File Offset: 0x0014AB0F
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04002AFB RID: 11003
		private XmlSchemaParticle particle;

		// Token: 0x04002AFC RID: 11004
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04002AFD RID: 11005
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04002AFE RID: 11006
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
