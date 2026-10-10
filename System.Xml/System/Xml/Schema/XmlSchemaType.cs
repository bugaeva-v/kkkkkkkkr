using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	/// <summary>
	///         Базовый класс для всех простых и сложных типов.
	///       </summary>
	// Token: 0x020005E4 RID: 1508
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> представляющий встроенный тип простой простого типа, которое указано полное имя.
		///       </summary>
		/// <param name="qualifiedName">
		///           <see cref="T:System.Xml.XmlQualifiedName" /> Простого типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> Представляющий встроенный простой тип.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <see cref="T:System.Xml.XmlQualifiedName" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06003C54 RID: 15444 RVA: 0x00151236 File Offset: 0x0014F436
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName)
		{
			if (qualifiedName == null)
			{
				throw new ArgumentNullException("qualifiedName");
			}
			return DatatypeImplementation.GetSimpleTypeFromXsdType(qualifiedName);
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> представляющий встроенных простого типа, заданного простого типа.
		///       </summary>
		/// <param name="typeCode">
		///           Один из <see cref="T:System.Xml.Schema.XmlTypeCode" /> значения, представляющие простого типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" /> Представляющий встроенный простой тип.
		///       </returns>
		// Token: 0x06003C55 RID: 15445 RVA: 0x00151252 File Offset: 0x0014F452
		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			return DatatypeImplementation.GetSimpleTypeFromTypeCode(typeCode);
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> представляющий встроенных сложный тип сложного типа.
		///       </summary>
		/// <param name="typeCode">
		///           Один из <see cref="T:System.Xml.Schema.XmlTypeCode" /> значения, представляющего сложный тип.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> Представляющий встроенных сложного типа.
		///       </returns>
		// Token: 0x06003C56 RID: 15446 RVA: 0x0015125A File Offset: 0x0014F45A
		public static XmlSchemaComplexType GetBuiltInComplexType(XmlTypeCode typeCode)
		{
			if (typeCode == XmlTypeCode.Item)
			{
				return XmlSchemaComplexType.AnyType;
			}
			return null;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> представляющий встроенных сложный тип сложного типа, указанного по полному имени.
		///       </summary>
		/// <param name="qualifiedName">
		///           <see cref="T:System.Xml.XmlQualifiedName" /> Сложного типа.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> Представляющий встроенных сложного типа.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Параметр <see cref="T:System.Xml.XmlQualifiedName" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06003C57 RID: 15447 RVA: 0x00151268 File Offset: 0x0014F468
		public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName)
		{
			if (qualifiedName == null)
			{
				throw new ArgumentNullException("qualifiedName");
			}
			if (qualifiedName.Equals(XmlSchemaComplexType.AnyType.QualifiedName))
			{
				return XmlSchemaComplexType.AnyType;
			}
			if (qualifiedName.Equals(XmlSchemaComplexType.UntypedAnyType.QualifiedName))
			{
				return XmlSchemaComplexType.UntypedAnyType;
			}
			return null;
		}

		/// <summary>
		///         Возвращает или задает имя типа.
		///       </summary>
		/// <returns>
		///         Имя типа.
		///       </returns>
		// Token: 0x17000BD0 RID: 3024
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x001512BA File Offset: 0x0014F4BA
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x001512C2 File Offset: 0x0014F4C2
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
		///         Возвращает или задает финальный атрибут создания производной типа, указывающее, если дополнительные выводы разрешены.
		///       </summary>
		/// <returns>
		///         Одно из допустимых <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> значения.
		///          Значение по умолчанию — <see cref="F:System.Xml.Schema.XmlSchemaDerivationMethod.None" />.
		///       </returns>
		// Token: 0x17000BD1 RID: 3025
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x001512CB File Offset: 0x0014F4CB
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x001512D3 File Offset: 0x0014F4D3
		[XmlAttribute("final")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod Final
		{
			get
			{
				return this.final;
			}
			set
			{
				this.final = value;
			}
		}

		/// <summary>
		///         Возвращает полное имя типа, построенного из <see langword="Name" /> атрибутов этого типа.
		///          Это свойство после компиляции.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlQualifiedName" /> Для типа, построенного из <see langword="Name" /> атрибутов этого типа.
		///       </returns>
		// Token: 0x17000BD2 RID: 3026
		// (get) Token: 0x06003C5C RID: 15452 RVA: 0x001512DC File Offset: 0x0014F4DC
		[XmlIgnore]
		public XmlQualifiedName QualifiedName
		{
			get
			{
				return this.qname;
			}
		}

		/// <summary>
		///         Получает значение после компиляции <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> свойство.
		///       </summary>
		/// <returns>
		///         Значение после компиляции <see cref="P:System.Xml.Schema.XmlSchemaType.Final" /> свойство.
		///          Значение по умолчанию — <see langword="finalDefault" /> значения атрибута <see langword="schema" /> элемента.
		///       </returns>
		// Token: 0x17000BD3 RID: 3027
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x001512E6 File Offset: 0x0014F4E6
		[XmlIgnore]
		public XmlSchemaDerivationMethod FinalResolved
		{
			get
			{
				return this.finalResolved;
			}
		}

		/// <summary>
		///         Возвращает тип объекта после компиляции или встроенный тип данных языка определения схемы XML (XSD), элемента simpleType или complexType-элемент.
		///          Это свойство набора сведений после компиляции схемы.
		///       </summary>
		/// <returns>
		///         Встроенный тип данных XSD, элемента simpleType или complexType-элемент.
		///       </returns>
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x06003C5E RID: 15454 RVA: 0x001512EE File Offset: 0x0014F4EE
		[Obsolete("This property has been deprecated. Please use BaseXmlSchemaType property that returns a strongly typed base schema type. http://go.microsoft.com/fwlink/?linkid=14202")]
		[XmlIgnore]
		public object BaseSchemaType
		{
			get
			{
				if (this.baseSchemaType == null)
				{
					return null;
				}
				if (this.baseSchemaType.QualifiedName.Namespace == "http://www.w3.org/2001/XMLSchema")
				{
					return this.baseSchemaType.Datatype;
				}
				return this.baseSchemaType;
			}
		}

		/// <summary>
		///         Получает значение после компиляции для базового типа данного типа схемы.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaType" /> Объект, представляющий базовый тип данного типа схемы.
		///       </returns>
		// Token: 0x17000BD5 RID: 3029
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x00151328 File Offset: 0x0014F528
		[XmlIgnore]
		public XmlSchemaType BaseXmlSchemaType
		{
			get
			{
				return this.baseSchemaType;
			}
		}

		/// <summary>
		///         Получает сведения после компиляции о том, как этот элемент создан на основе его базового типа.
		///       </summary>
		/// <returns>
		///         Одно из допустимых <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> значения.
		///       </returns>
		// Token: 0x17000BD6 RID: 3030
		// (get) Token: 0x06003C60 RID: 15456 RVA: 0x00151330 File Offset: 0x0014F530
		[XmlIgnore]
		public XmlSchemaDerivationMethod DerivedBy
		{
			get
			{
				return this.derivedBy;
			}
		}

		/// <summary>
		///         Получает значение после компиляции для типа данных сложного типа.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaDatatype" /> Значение после компиляции.
		///       </returns>
		// Token: 0x17000BD7 RID: 3031
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x00151338 File Offset: 0x0014F538
		[XmlIgnore]
		public XmlSchemaDatatype Datatype
		{
			get
			{
				return this.datatype;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, имеет ли этот тип модель смешанного содержимого.
		///          Данное свойство допустимо только в сложных типах.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если тип имеет модель со смешанным содержимым; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="false" />.
		///       </returns>
		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06003C62 RID: 15458 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		// (set) Token: 0x06003C63 RID: 15459 RVA: 0x0000B528 File Offset: 0x00009728
		[XmlIgnore]
		public virtual bool IsMixed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlTypeCode" /> типа.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.Schema.XmlTypeCode" />.
		///       </returns>
		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06003C64 RID: 15460 RVA: 0x00151340 File Offset: 0x0014F540
		[XmlIgnore]
		public XmlTypeCode TypeCode
		{
			get
			{
				if (this == XmlSchemaComplexType.AnyType)
				{
					return XmlTypeCode.Item;
				}
				if (this.datatype == null)
				{
					return XmlTypeCode.None;
				}
				return this.datatype.TypeCode;
			}
		}

		// Token: 0x17000BDA RID: 3034
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x00151361 File Offset: 0x0014F561
		[XmlIgnore]
		internal XmlValueConverter ValueConverter
		{
			get
			{
				if (this.datatype == null)
				{
					return XmlUntypedConverter.Untyped;
				}
				return this.datatype.ValueConverter;
			}
		}

		// Token: 0x06003C66 RID: 15462 RVA: 0x0015137C File Offset: 0x0014F57C
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

		// Token: 0x17000BDB RID: 3035
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x001513B3 File Offset: 0x0014F5B3
		internal XmlSchemaContentType SchemaContentType
		{
			get
			{
				return this.contentType;
			}
		}

		// Token: 0x06003C68 RID: 15464 RVA: 0x001513BB File Offset: 0x0014F5BB
		internal void SetQualifiedName(XmlQualifiedName value)
		{
			this.qname = value;
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001513C6 File Offset: 0x0014F5C6
		internal void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			this.finalResolved = value;
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x001513CF File Offset: 0x0014F5CF
		internal void SetBaseSchemaType(XmlSchemaType value)
		{
			this.baseSchemaType = value;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x001513D8 File Offset: 0x0014F5D8
		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
			this.derivedBy = value;
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x001513E1 File Offset: 0x0014F5E1
		internal void SetDatatype(XmlSchemaDatatype value)
		{
			this.datatype = value;
		}

		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x001513EA File Offset: 0x0014F5EA
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x001513F4 File Offset: 0x0014F5F4
		internal SchemaElementDecl ElementDecl
		{
			get
			{
				return this.elementDecl;
			}
			set
			{
				this.elementDecl = value;
			}
		}

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x001513FF File Offset: 0x0014F5FF
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x00151407 File Offset: 0x0014F607
		[XmlIgnore]
		internal XmlSchemaType Redefined
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x00151410 File Offset: 0x0014F610
		internal virtual XmlQualifiedName DerivedFrom
		{
			get
			{
				return XmlQualifiedName.Empty;
			}
		}

		// Token: 0x06003C72 RID: 15474 RVA: 0x00151417 File Offset: 0x0014F617
		internal void SetContentType(XmlSchemaContentType value)
		{
			this.contentType = value;
		}

		/// <summary>
		///         Возвращает значение, указывающее, если указанный тип схемы является производным от указанного типа базовой схемы
		///       </summary>
		/// <param name="derivedType">
		///           Производный <see cref="T:System.Xml.Schema.XmlSchemaType" /> для тестирования.
		///         </param>
		/// <param name="baseType">
		///           Базовый <see cref="T:System.Xml.Schema.XmlSchemaType" /> для тестирования производный <see cref="T:System.Xml.Schema.XmlSchemaType" /> от.
		///         </param>
		/// <param name="except">
		///           Один из <see cref="T:System.Xml.Schema.XmlSchemaDerivationMethod" /> значения, представляющие метод производного типа, чтобы исключить из проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если производный тип является производным от базового типа; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x06003C73 RID: 15475 RVA: 0x00151420 File Offset: 0x0014F620
		public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except)
		{
			if (derivedType == null || baseType == null)
			{
				return false;
			}
			if (derivedType == baseType)
			{
				return true;
			}
			if (baseType == XmlSchemaComplexType.AnyType)
			{
				return true;
			}
			XmlSchemaSimpleType xmlSchemaSimpleType;
			XmlSchemaSimpleType xmlSchemaSimpleType2;
			for (;;)
			{
				xmlSchemaSimpleType = (derivedType as XmlSchemaSimpleType);
				xmlSchemaSimpleType2 = (baseType as XmlSchemaSimpleType);
				if (xmlSchemaSimpleType2 != null && xmlSchemaSimpleType != null)
				{
					break;
				}
				if ((except & derivedType.DerivedBy) != XmlSchemaDerivationMethod.Empty)
				{
					return false;
				}
				derivedType = derivedType.BaseXmlSchemaType;
				if (derivedType == baseType)
				{
					return true;
				}
				if (derivedType == null)
				{
					return false;
				}
			}
			return xmlSchemaSimpleType2 == DatatypeImplementation.AnySimpleType || ((except & derivedType.DerivedBy) == XmlSchemaDerivationMethod.Empty && xmlSchemaSimpleType.Datatype.IsDerivedFrom(xmlSchemaSimpleType2.Datatype));
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x001514A2 File Offset: 0x0014F6A2
		internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except)
		{
			return DatatypeImplementation.AnySimpleType.Datatype == baseDataType || derivedDataType.IsDerivedFrom(baseDataType);
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x001514BA File Offset: 0x0014F6BA
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x001514C2 File Offset: 0x0014F6C2
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

		// Token: 0x04002BD2 RID: 11218
		private string name;

		// Token: 0x04002BD3 RID: 11219
		private XmlSchemaDerivationMethod final = XmlSchemaDerivationMethod.None;

		// Token: 0x04002BD4 RID: 11220
		private XmlSchemaDerivationMethod derivedBy;

		// Token: 0x04002BD5 RID: 11221
		private XmlSchemaType baseSchemaType;

		// Token: 0x04002BD6 RID: 11222
		private XmlSchemaDatatype datatype;

		// Token: 0x04002BD7 RID: 11223
		private XmlSchemaDerivationMethod finalResolved;

		// Token: 0x04002BD8 RID: 11224
		private volatile SchemaElementDecl elementDecl;

		// Token: 0x04002BD9 RID: 11225
		private volatile XmlQualifiedName qname = XmlQualifiedName.Empty;

		// Token: 0x04002BDA RID: 11226
		private XmlSchemaType redefined;

		// Token: 0x04002BDB RID: 11227
		private XmlSchemaContentType contentType;
	}
}
