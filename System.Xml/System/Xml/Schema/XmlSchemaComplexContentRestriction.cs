using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="restriction" /> элемент из схемы XML в соответствии с World Wide Web Consortium (W3C).
	///          Этот класс предназначен для сложных типов с моделью сложного содержимого, определяемых путем ограничения.
	///          Он ограничивает содержимое сложного типа подмножеством унаследованного сложного типа.
	///       </summary>
	// Token: 0x020005A2 RID: 1442
	public class XmlSchemaComplexContentRestriction : XmlSchemaContent
	{
		/// <summary>
		///         Возвращает или задает имя сложного типа, из которого данный тип создается путем ограничения.
		///       </summary>
		/// <returns>
		///         Имя сложного типа, из которого данный тип создается путем ограничения.
		///       </returns>
		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003A4A RID: 14922 RVA: 0x0014C936 File Offset: 0x0014AB36
		// (set) Token: 0x06003A4B RID: 14923 RVA: 0x0014C93E File Offset: 0x0014AB3E
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
		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06003A4C RID: 14924 RVA: 0x0014C957 File Offset: 0x0014AB57
		// (set) Token: 0x06003A4D RID: 14925 RVA: 0x0014C95F File Offset: 0x0014AB5F
		[XmlElement("sequence", typeof(XmlSchemaSequence))]
		[XmlElement("all", typeof(XmlSchemaAll))]
		[XmlElement("choice", typeof(XmlSchemaChoice))]
		[XmlElement("group", typeof(XmlSchemaGroupRef))]
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
		///         Возвращает коллекцию атрибутов для сложного типа.
		///          Содержит <see cref="T:System.Xml.Schema.XmlSchemaAttribute" /> и <see cref="T:System.Xml.Schema.XmlSchemaAttributeGroupRef" /> элементы.
		///       </summary>
		/// <returns>
		///         Коллекция атрибутов для сложного типа.
		///       </returns>
		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06003A4E RID: 14926 RVA: 0x0014C968 File Offset: 0x0014AB68
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
		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x0014C970 File Offset: 0x0014AB70
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x0014C978 File Offset: 0x0014AB78
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

		// Token: 0x06003A51 RID: 14929 RVA: 0x0014C981 File Offset: 0x0014AB81
		internal void SetAttributes(XmlSchemaObjectCollection newAttributes)
		{
			this.attributes = newAttributes;
		}

		// Token: 0x04002AFF RID: 11007
		private XmlSchemaParticle particle;

		// Token: 0x04002B00 RID: 11008
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04002B01 RID: 11009
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04002B02 RID: 11010
		private XmlQualifiedName baseTypeName = XmlQualifiedName.Empty;
	}
}
