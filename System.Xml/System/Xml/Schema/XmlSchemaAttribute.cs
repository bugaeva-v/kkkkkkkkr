using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Представляет <see langword="attribute" /> элемент из схемы XML, определенной консорциумом World Wide Web Consortium (W3C).
	///          Атрибуты предоставляют дополнительную информацию для прочих элементов документа.
	///          Тег атрибута вложен между тегами элемента документа для схемы.
	///          Документ XML отображает атрибуты как элементы с именем в открывающем теге элемента.
	///       </summary>
	// Token: 0x02000598 RID: 1432
	public class XmlSchemaAttribute : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает или задает значение по умолчанию для атрибута.
		///       </summary>
		/// <returns>
		///         Значение по умолчанию для этого атрибута.
		///          Значение по умолчанию: пустая ссылка.
		///
		///         Необязательный.
		///       </returns>
		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x060039D2 RID: 14802 RVA: 0x0014BEF7 File Offset: 0x0014A0F7
		// (set) Token: 0x060039D3 RID: 14803 RVA: 0x0014BEFF File Offset: 0x0014A0FF
		[DefaultValue(null)]
		[XmlAttribute("default")]
		public string DefaultValue
		{
			get
			{
				return this.defaultValue;
			}
			set
			{
				this.defaultValue = value;
			}
		}

		/// <summary>
		///         Возвращает или задает фиксированное значение атрибута.
		///       </summary>
		/// <returns>
		///         Фиксированное значение атрибута.
		///          Значение по умолчанию — null.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060039D4 RID: 14804 RVA: 0x0014BF08 File Offset: 0x0014A108
		// (set) Token: 0x060039D5 RID: 14805 RVA: 0x0014BF10 File Offset: 0x0014A110
		[DefaultValue(null)]
		[XmlAttribute("fixed")]
		public string FixedValue
		{
			get
			{
				return this.fixedValue;
			}
			set
			{
				this.fixedValue = value;
			}
		}

		/// <summary>
		///         Возвращает или задает форму для атрибута.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlSchemaForm" />.
		///          Значение по умолчанию является значение <see cref="P:System.Xml.Schema.XmlSchema.AttributeFormDefault" /> схемы элемента, содержащего атрибут.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x060039D6 RID: 14806 RVA: 0x0014BF19 File Offset: 0x0014A119
		// (set) Token: 0x060039D7 RID: 14807 RVA: 0x0014BF21 File Offset: 0x0014A121
		[DefaultValue(XmlSchemaForm.None)]
		[XmlAttribute("form")]
		public XmlSchemaForm Form
		{
			get
			{
				return this.form;
			}
			set
			{
				this.form = value;
			}
		}

		/// <summary>
		///         Возвращает или задает имя атрибута.
		///       </summary>
		/// <returns>
		///         Имя атрибута.
		///       </returns>
		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x060039D8 RID: 14808 RVA: 0x0014BF2A File Offset: 0x0014A12A
		// (set) Token: 0x060039D9 RID: 14809 RVA: 0x0014BF32 File Offset: 0x0014A132
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
		///         Возвращает или задает имя атрибута, объявленного в данной схеме (или иной схеме, указанной заданным пространством имен).
		///       </summary>
		/// <returns>
		///         Имя объявленного атрибута.
		///       </returns>
		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x060039DA RID: 14810 RVA: 0x0014BF3B File Offset: 0x0014A13B
		// (set) Token: 0x060039DB RID: 14811 RVA: 0x0014BF43 File Offset: 0x0014A143
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

		/// <summary>
		///         Возвращает или задает имя простого типа, определенного в данной схеме (или иной схеме, указанной заданным пространством имен).
		///       </summary>
		/// <returns>
		///         Имя простого типа.
		///       </returns>
		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x060039DC RID: 14812 RVA: 0x0014BF5C File Offset: 0x0014A15C
		// (set) Token: 0x060039DD RID: 14813 RVA: 0x0014BF64 File Offset: 0x0014A164
		[XmlAttribute("type")]
		public XmlQualifiedName SchemaTypeName
		{
			get
			{
				return this.typeName;
			}
			set
			{
				this.typeName = ((value == null) ? XmlQualifiedName.Empty : value);
			}
		}

		/// <summary>
		///         Возвращает тип атрибута или устанавливает его как простой тип.
		///       </summary>
		/// <returns>
		///         Простой тип, определенный в данной схеме.
		///       </returns>
		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x060039DE RID: 14814 RVA: 0x0014BF7D File Offset: 0x0014A17D
		// (set) Token: 0x060039DF RID: 14815 RVA: 0x0014BF85 File Offset: 0x0014A185
		[XmlElement("simpleType")]
		public XmlSchemaSimpleType SchemaType
		{
			get
			{
				return this.type;
			}
			set
			{
				this.type = value;
			}
		}

		/// <summary>
		///         Возвращает или задает информацию по использованию атрибута.
		///       </summary>
		/// <returns>
		///         Одно из следующих значений: None, Prohibited, Optional или Required.
		///          По умолчанию используется значение Optional.
		///
		///         Необязательно.
		///       </returns>
		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x0014BF8E File Offset: 0x0014A18E
		// (set) Token: 0x060039E1 RID: 14817 RVA: 0x0014BF96 File Offset: 0x0014A196
		[XmlAttribute("use")]
		[DefaultValue(XmlSchemaUse.None)]
		public XmlSchemaUse Use
		{
			get
			{
				return this.use;
			}
			set
			{
				this.use = value;
			}
		}

		/// <summary>
		///         Возвращает полное имя атрибута.
		///       </summary>
		/// <returns>
		///         Значение после компиляции <see langword="QualifiedName" /> свойство.
		///       </returns>
		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x0014BF9F File Offset: 0x0014A19F
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qualifiedName;
			}
		}

		/// <summary>
		///         Возвращает объект CLR (CLR) на основании <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaType" /> или <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaTypeName" /> атрибута, который содержит значение после компиляции <see langword="AttributeType" /> свойство.
		///       </summary>
		/// <returns>
		///         Общий объект библиотеки (CLR) среды выполнения, содержит значение после компиляции <see langword="AttributeType" /> свойство.
		///       </returns>
		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x0014BFA7 File Offset: 0x0014A1A7
		[XmlIgnore]
		[Obsolete("This property has been deprecated. Please use AttributeSchemaType property that returns a strongly typed attribute type. http://go.microsoft.com/fwlink/?linkid=14202")]
		public object AttributeType
		{
			get
			{
				if (this.attributeType == null)
				{
					return null;
				}
				if (this.attributeType.QualifiedName.Namespace == "http://www.w3.org/2001/XMLSchema")
				{
					return this.attributeType.Datatype;
				}
				return this.attributeType;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> объект, представляющий тип атрибута на основе <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaType" /> или <see cref="P:System.Xml.Schema.XmlSchemaAttribute.SchemaTypeName" /> атрибута.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" />.
		///       </returns>
		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060039E4 RID: 14820 RVA: 0x0014BFE1 File Offset: 0x0014A1E1
		[XmlIgnore]
		public XmlSchemaSimpleType AttributeSchemaType
		{
			get
			{
				return this.attributeType;
			}
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x0014BFEC File Offset: 0x0014A1EC
		internal XmlReader Validate(XmlReader reader, XmlResolver resolver, XmlSchemaSet schemaSet, ValidationEventHandler valEventHandler)
		{
			if (schemaSet != null)
			{
				XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
				xmlReaderSettings.ValidationType = ValidationType.Schema;
				xmlReaderSettings.Schemas = schemaSet;
				xmlReaderSettings.ValidationEventHandler += valEventHandler;
				return new XsdValidatingReader(reader, resolver, xmlReaderSettings, this);
			}
			return null;
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x0014C023 File Offset: 0x0014A223
		[XmlIgnore]
		internal XmlSchemaDatatype Datatype
		{
			get
			{
				if (this.attributeType != null)
				{
					return this.attributeType.Datatype;
				}
				return null;
			}
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x0014C03A File Offset: 0x0014A23A
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qualifiedName = value;
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x0014C043 File Offset: 0x0014A243
		internal void SetAttributeType(XmlSchemaSimpleType value)
		{
			this.attributeType = value;
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x0014C04C File Offset: 0x0014A24C
		// (set) Token: 0x060039EA RID: 14826 RVA: 0x0014C054 File Offset: 0x0014A254
		internal SchemaAttDef AttDef
		{
			get
			{
				return this.attDef;
			}
			set
			{
				this.attDef = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x0014C05D File Offset: 0x0014A25D
		internal bool HasDefault
		{
			get
			{
				return this.defaultValue != null;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x060039EC RID: 14828 RVA: 0x0014C068 File Offset: 0x0014A268
		// (set) Token: 0x060039ED RID: 14829 RVA: 0x0014C070 File Offset: 0x0014A270
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

		// Token: 0x060039EE RID: 14830 RVA: 0x0014C079 File Offset: 0x0014A279
		internal override XmlSchemaObject Clone()
		{
			XmlSchemaAttribute xmlSchemaAttribute = (XmlSchemaAttribute)base.MemberwiseClone();
			xmlSchemaAttribute.refName = this.refName.Clone();
			xmlSchemaAttribute.typeName = this.typeName.Clone();
			xmlSchemaAttribute.qualifiedName = this.qualifiedName.Clone();
			return xmlSchemaAttribute;
		}

		// Token: 0x04002AD6 RID: 10966
		private string defaultValue;

		// Token: 0x04002AD7 RID: 10967
		private string fixedValue;

		// Token: 0x04002AD8 RID: 10968
		private string name;

		// Token: 0x04002AD9 RID: 10969
		private XmlSchemaForm form;

		// Token: 0x04002ADA RID: 10970
		private XmlSchemaUse use;

		// Token: 0x04002ADB RID: 10971
		private XmlQualifiedName refName = XmlQualifiedName.Empty;

		// Token: 0x04002ADC RID: 10972
		private XmlQualifiedName typeName = XmlQualifiedName.Empty;

		// Token: 0x04002ADD RID: 10973
		private XmlQualifiedName qualifiedName = XmlQualifiedName.Empty;

		// Token: 0x04002ADE RID: 10974
		private XmlSchemaSimpleType type;

		// Token: 0x04002ADF RID: 10975
		private XmlSchemaSimpleType attributeType;

		// Token: 0x04002AE0 RID: 10976
		private SchemaAttDef attDef;
	}
}
