using System;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="attributeGroup" /> элемент из схемы XML, определенной консорциумом World Wide Web Consortium (W3C).
	///          AttributesGroups обеспечивает механизм группировки набора объявлений атрибутов, чтобы можно было их добавить как группу в определения сложных типов.
	///       </summary>
	// Token: 0x02000599 RID: 1433
	public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает имя группы атрибутов.
		///       </summary>
		/// <returns>
		///         Имя группы атрибутов.
		///       </returns>
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x060039F0 RID: 14832 RVA: 0x0014C0E2 File Offset: 0x0014A2E2
		// (set) Token: 0x060039F1 RID: 14833 RVA: 0x0014C0EA File Offset: 0x0014A2EA
		[XmlAttribute("name")]
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>
		///         Возвращает коллекцию атрибутов для группы атрибутов.
		///          Содержит <see langword="XmlSchemaAttribute" /> и <see langword="XmlSchemaAttributeGroupRef" /> элементы.
		///       </summary>
		/// <returns>
		///         Коллекция атрибутов для группы атрибутов.
		///       </returns>
		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x060039F2 RID: 14834 RVA: 0x0014C0F3 File Offset: 0x0014A2F3
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
		///         Возвращает или задает <see cref="T:System.Xml.Schema.XmlSchemaAnyAttribute" /> компонент группы атрибутов.
		///       </summary>
		/// <returns>
		///         World Wide Web Consortium (W3C) <see langword="anyAttribute" /> элемента.
		///       </returns>
		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x0014C0FB File Offset: 0x0014A2FB
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x0014C103 File Offset: 0x0014A303
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

		/// <summary>
		///         Возвращает полное имя группы атрибутов.
		///       </summary>
		/// <returns>
		///         Полное имя группы атрибутов.
		///       </returns>
		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x0014C10C File Offset: 0x0014A30C
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x060039F6 RID: 14838 RVA: 0x0014C114 File Offset: 0x0014A314
		[XmlIgnore]
		internal XmlSchemaObjectTable AttributeUses
		{
			get
			{
				if (this.attributeUses == null)
				{
					this.attributeUses = new XmlSchemaObjectTable();
				}
				return this.attributeUses;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x0014C12F File Offset: 0x0014A32F
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x0014C137 File Offset: 0x0014A337
		[XmlIgnore]
		internal XmlSchemaAnyAttribute AttributeWildcard
		{
			get
			{
				return this.attributeWildcard;
			}
			set
			{
				this.attributeWildcard = value;
			}
		}

		/// <summary>
		///         Возвращает переопределенное свойство группы атрибутов из схемы XML.
		///       </summary>
		/// <returns>
		///         Переопределенное свойство группы атрибутов.
		///       </returns>
		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x0014C140 File Offset: 0x0014A340
		[XmlIgnore]
		public XmlSchemaAttributeGroup RedefinedAttributeGroup
		{
			get
			{
				return this.redefined;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x060039FA RID: 14842 RVA: 0x0014C140 File Offset: 0x0014A340
		// (set) Token: 0x060039FB RID: 14843 RVA: 0x0014C148 File Offset: 0x0014A348
		[XmlIgnore]
		internal XmlSchemaAttributeGroup Redefined
		{
			get
			{
				return this.redefined;
			}
			set
			{
				this.redefined = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x060039FC RID: 14844 RVA: 0x0014C151 File Offset: 0x0014A351
		// (set) Token: 0x060039FD RID: 14845 RVA: 0x0014C159 File Offset: 0x0014A359
		[XmlIgnore]
		internal int SelfReferenceCount
		{
			get
			{
				return this.selfReferenceCount;
			}
			set
			{
				this.selfReferenceCount = value;
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x060039FE RID: 14846 RVA: 0x0014C162 File Offset: 0x0014A362
		// (set) Token: 0x060039FF RID: 14847 RVA: 0x0014C16A File Offset: 0x0014A36A
		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return this.Name;
			}
			set
			{
				this.Name = value;
			}
		}

		// Token: 0x06003A00 RID: 14848 RVA: 0x0014C173 File Offset: 0x0014A373
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06003A01 RID: 14849 RVA: 0x0014C17C File Offset: 0x0014A37C
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaAttributeGroup xmlSchemaAttributeGroup = (XmlSchemaAttributeGroup)base.MemberwiseClone();
			if (XmlSchemaComplexType.HasAttributeQNameRef(this.attributes))
			{
				xmlSchemaAttributeGroup.attributes = XmlSchemaComplexType.CloneAttributes(this.attributes);
				xmlSchemaAttributeGroup.attributeUses = null;
			}
			return xmlSchemaAttributeGroup;
		}

		// Token: 0x04002AE1 RID: 10977
		private string name;

		// Token: 0x04002AE2 RID: 10978
		private XmlSchemaObjectCollection attributes = new XmlSchemaObjectCollection();

		// Token: 0x04002AE3 RID: 10979
		private XmlSchemaAnyAttribute anyAttribute;

		// Token: 0x04002AE4 RID: 10980
		private XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x04002AE5 RID: 10981
		private XmlSchemaAttributeGroup redefined;

		// Token: 0x04002AE6 RID: 10982
		private XmlSchemaObjectTable attributeUses;

		// Token: 0x04002AE7 RID: 10983
		private XmlSchemaAnyAttribute attributeWildcard;

		// Token: 0x04002AE8 RID: 10984
		private int selfReferenceCount;
	}
}
