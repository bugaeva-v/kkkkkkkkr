using System;
using System.ComponentModel;
using System.Reflection;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Представляет коллекцию объектов атрибутов, которые управляют как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует и десериализует объект.
	///       </summary>
	// Token: 0x020002CC RID: 716
	public class XmlAttributes
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Serialization.XmlAttributes" />.
		///       </summary>
		// Token: 0x06001B2D RID: 6957 RVA: 0x0009B87F File Offset: 0x00099A7F
		public XmlAttributes()
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x0009B8A8 File Offset: 0x00099AA8
		internal XmlAttributeFlags XmlFlags
		{
			get
			{
				XmlAttributeFlags xmlAttributeFlags = (XmlAttributeFlags)0;
				if (this.xmlElements.Count > 0)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Elements;
				}
				if (this.xmlArrayItems.Count > 0)
				{
					xmlAttributeFlags |= XmlAttributeFlags.ArrayItems;
				}
				if (this.xmlAnyElements.Count > 0)
				{
					xmlAttributeFlags |= XmlAttributeFlags.AnyElements;
				}
				if (this.xmlArray != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Array;
				}
				if (this.xmlAttribute != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Attribute;
				}
				if (this.xmlText != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Text;
				}
				if (this.xmlEnum != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Enum;
				}
				if (this.xmlRoot != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Root;
				}
				if (this.xmlType != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.Type;
				}
				if (this.xmlAnyAttribute != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.AnyAttribute;
				}
				if (this.xmlChoiceIdentifier != null)
				{
					xmlAttributeFlags |= XmlAttributeFlags.ChoiceIdentifier;
				}
				if (this.xmlns)
				{
					xmlAttributeFlags |= XmlAttributeFlags.XmlnsDeclarations;
				}
				return xmlAttributeFlags;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001B2F RID: 6959 RVA: 0x0009B974 File Offset: 0x00099B74
		private static Type IgnoreAttribute
		{
			get
			{
				if (XmlAttributes.ignoreAttributeType == null)
				{
					XmlAttributes.ignoreAttributeType = typeof(object).Assembly.GetType("System.XmlIgnoreMemberAttribute");
					if (XmlAttributes.ignoreAttributeType == null)
					{
						XmlAttributes.ignoreAttributeType = typeof(XmlIgnoreAttribute);
					}
				}
				return XmlAttributes.ignoreAttributeType;
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр <see cref="T:System.Xml.Serialization.XmlAttributes" /> класса и настраивает как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует и десериализует объект.
		///       </summary>
		/// <param name="provider">
		///           Класс, который может предоставить альтернативные реализации атрибутов, управляющих сериализацией XML.
		///         </param>
		// Token: 0x06001B30 RID: 6960 RVA: 0x0009B9D8 File Offset: 0x00099BD8
		public XmlAttributes(ICustomAttributeProvider provider)
		{
			object[] customAttributes = provider.GetCustomAttributes(false);
			XmlAnyElementAttribute xmlAnyElementAttribute = null;
			for (int i = 0; i < customAttributes.Length; i++)
			{
				if (customAttributes[i] is XmlIgnoreAttribute || customAttributes[i] is ObsoleteAttribute || customAttributes[i].GetType() == XmlAttributes.IgnoreAttribute)
				{
					this.xmlIgnore = true;
					break;
				}
				if (customAttributes[i] is XmlElementAttribute)
				{
					this.xmlElements.Add((XmlElementAttribute)customAttributes[i]);
				}
				else if (customAttributes[i] is XmlArrayItemAttribute)
				{
					this.xmlArrayItems.Add((XmlArrayItemAttribute)customAttributes[i]);
				}
				else if (customAttributes[i] is XmlAnyElementAttribute)
				{
					XmlAnyElementAttribute xmlAnyElementAttribute2 = (XmlAnyElementAttribute)customAttributes[i];
					if ((xmlAnyElementAttribute2.Name == null || xmlAnyElementAttribute2.Name.Length == 0) && xmlAnyElementAttribute2.NamespaceSpecified && xmlAnyElementAttribute2.Namespace == null)
					{
						xmlAnyElementAttribute = xmlAnyElementAttribute2;
					}
					else
					{
						this.xmlAnyElements.Add((XmlAnyElementAttribute)customAttributes[i]);
					}
				}
				else if (customAttributes[i] is DefaultValueAttribute)
				{
					this.xmlDefaultValue = ((DefaultValueAttribute)customAttributes[i]).Value;
				}
				else if (customAttributes[i] is XmlAttributeAttribute)
				{
					this.xmlAttribute = (XmlAttributeAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlArrayAttribute)
				{
					this.xmlArray = (XmlArrayAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlTextAttribute)
				{
					this.xmlText = (XmlTextAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlEnumAttribute)
				{
					this.xmlEnum = (XmlEnumAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlRootAttribute)
				{
					this.xmlRoot = (XmlRootAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlTypeAttribute)
				{
					this.xmlType = (XmlTypeAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlAnyAttributeAttribute)
				{
					this.xmlAnyAttribute = (XmlAnyAttributeAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlChoiceIdentifierAttribute)
				{
					this.xmlChoiceIdentifier = (XmlChoiceIdentifierAttribute)customAttributes[i];
				}
				else if (customAttributes[i] is XmlNamespaceDeclarationsAttribute)
				{
					this.xmlns = true;
				}
			}
			if (this.xmlIgnore)
			{
				this.xmlElements.Clear();
				this.xmlArrayItems.Clear();
				this.xmlAnyElements.Clear();
				this.xmlDefaultValue = null;
				this.xmlAttribute = null;
				this.xmlArray = null;
				this.xmlText = null;
				this.xmlEnum = null;
				this.xmlType = null;
				this.xmlAnyAttribute = null;
				this.xmlChoiceIdentifier = null;
				this.xmlns = false;
				return;
			}
			if (xmlAnyElementAttribute != null)
			{
				this.xmlAnyElements.Add(xmlAnyElementAttribute);
			}
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0009BC84 File Offset: 0x00099E84
		internal static object GetAttr(ICustomAttributeProvider provider, Type attrType)
		{
			object[] customAttributes = provider.GetCustomAttributes(attrType, false);
			if (customAttributes.Length == 0)
			{
				return null;
			}
			return customAttributes[0];
		}

		/// <summary>
		///         Возвращает коллекцию объектов, определяющих способ <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или чтения и записи свойство как элемент XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlElementAttributes" /> Содержащий коллекцию <see cref="T:System.Xml.Serialization.XmlElementAttribute" /> объектов.
		///       </returns>
		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001B32 RID: 6962 RVA: 0x0009BCA3 File Offset: 0x00099EA3
		public XmlElementAttributes XmlElements
		{
			get
			{
				return this.xmlElements;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или свойство чтения/записи как атрибут XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAttributeAttribute" /> Который управляет сериализацией открытого поля или чтение и запись свойства как атрибут XML.
		///       </returns>
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x0009BCAB File Offset: 0x00099EAB
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0009BCB3 File Offset: 0x00099EB3
		public XmlAttributeAttribute XmlAttribute
		{
			get
			{
				return this.xmlAttribute;
			}
			set
			{
				this.xmlAttribute = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует член перечисления.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlEnumAttribute" /> Указывает, как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует член перечисления.
		///       </returns>
		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x0009BCBC File Offset: 0x00099EBC
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x0009BCC4 File Offset: 0x00099EC4
		public XmlEnumAttribute XmlEnum
		{
			get
			{
				return this.xmlEnum;
			}
			set
			{
				this.xmlEnum = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, который указывает, что <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализовать открытое поле или свойство чтения/записи как текст XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlTextAttribute" /> Переопределяющий стандартную сериализацию открытого свойства или поля.
		///       </returns>
		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x0009BCCD File Offset: 0x00099ECD
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x0009BCD5 File Offset: 0x00099ED5
		public XmlTextAttribute XmlText
		{
			get
			{
				return this.xmlText;
			}
			set
			{
				this.xmlText = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или чтение и запись свойство, возвращающее массив.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlArrayAttribute" /> Указывает, как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или чтение и запись свойство, возвращающее массив.
		///       </returns>
		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x0009BCDE File Offset: 0x00099EDE
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x0009BCE6 File Offset: 0x00099EE6
		public XmlArrayAttribute XmlArray
		{
			get
			{
				return this.xmlArray;
			}
			set
			{
				this.xmlArray = value;
			}
		}

		/// <summary>
		///         Возвращает или задает коллекцию объектов, указанных как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует элементы, вставленные в массив, возвращенный свойством открытые поля или чтение и запись.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlArrayItemAttributes" /> Объект, содержащий коллекцию <see cref="T:System.Xml.Serialization.XmlArrayItemAttribute" /> объектов.
		///       </returns>
		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x0009BCEF File Offset: 0x00099EEF
		public XmlArrayItemAttributes XmlArrayItems
		{
			get
			{
				return this.xmlArrayItems;
			}
		}

		/// <summary>
		///         Возвращает или задает значение по умолчанию XML-элемента или атрибута.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Object" /> Представляющий значение по умолчанию XML-элемента или атрибута.
		///       </returns>
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06001B3C RID: 6972 RVA: 0x0009BCF7 File Offset: 0x00099EF7
		// (set) Token: 0x06001B3D RID: 6973 RVA: 0x0009BCFF File Offset: 0x00099EFF
		public object XmlDefaultValue
		{
			get
			{
				return this.xmlDefaultValue;
			}
			set
			{
				this.xmlDefaultValue = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее ли <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует открытое поле или свойство чтения/записи.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="T:System.Xml.Serialization.XmlSerializer" /> не должен сериализовать поле или свойство; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0009BD08 File Offset: 0x00099F08
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x0009BD10 File Offset: 0x00099F10
		public bool XmlIgnore
		{
			get
			{
				return this.xmlIgnore;
			}
			set
			{
				this.xmlIgnore = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> выполняется сериализация класса, к которому <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> был применен.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> Переопределяющий <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> применяется к объявлению класса.
		///       </returns>
		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x0009BD19 File Offset: 0x00099F19
		// (set) Token: 0x06001B41 RID: 6977 RVA: 0x0009BD21 File Offset: 0x00099F21
		public XmlTypeAttribute XmlType
		{
			get
			{
				return this.xmlType;
			}
			set
			{
				this.xmlType = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, указывающий как <see cref="T:System.Xml.Serialization.XmlSerializer" /> сериализует класса в качестве корневого элемента XML.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlRootAttribute" /> Переопределяющий класс атрибута как корневого элемента XML.
		///       </returns>
		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x0009BD2A File Offset: 0x00099F2A
		// (set) Token: 0x06001B43 RID: 6979 RVA: 0x0009BD32 File Offset: 0x00099F32
		public XmlRootAttribute XmlRoot
		{
			get
			{
				return this.xmlRoot;
			}
			set
			{
				this.xmlRoot = value;
			}
		}

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> объектов для переопределения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAnyElementAttributes" /> Объект, представляющий коллекцию <see cref="T:System.Xml.Serialization.XmlAnyElementAttribute" /> объектов.
		///       </returns>
		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0009BD3B File Offset: 0x00099F3B
		public XmlAnyElementAttributes XmlAnyElements
		{
			get
			{
				return this.xmlAnyElements;
			}
		}

		/// <summary>
		///         Возвращает или задает <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> для переопределения.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlAnyAttributeAttribute" /> Для переопределения.
		///       </returns>
		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001B45 RID: 6981 RVA: 0x0009BD43 File Offset: 0x00099F43
		// (set) Token: 0x06001B46 RID: 6982 RVA: 0x0009BD4B File Offset: 0x00099F4B
		public XmlAnyAttributeAttribute XmlAnyAttribute
		{
			get
			{
				return this.xmlAnyAttribute;
			}
			set
			{
				this.xmlAnyAttribute = value;
			}
		}

		/// <summary>
		///         Возвращает или задает объект, который позволяет различать набор вариантов.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Serialization.XmlChoiceIdentifierAttribute" /> Может применяться к члену класса, который сериализуется как <see langword="xsi:choice" /> элемента.
		///       </returns>
		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001B47 RID: 6983 RVA: 0x0009BD54 File Offset: 0x00099F54
		public XmlChoiceIdentifierAttribute XmlChoiceIdentifier
		{
			get
			{
				return this.xmlChoiceIdentifier;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, следует ли сохранять все объявления пространства имен, когда объект, содержащий член, который возвращает <see cref="T:System.Xml.Serialization.XmlSerializerNamespaces" /> переопределен.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если объявления пространств имен следует сохранить; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0009BD5C File Offset: 0x00099F5C
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x0009BD64 File Offset: 0x00099F64
		public bool Xmlns
		{
			get
			{
				return this.xmlns;
			}
			set
			{
				this.xmlns = value;
			}
		}

		// Token: 0x040019D8 RID: 6616
		private XmlElementAttributes xmlElements = new XmlElementAttributes();

		// Token: 0x040019D9 RID: 6617
		private XmlArrayItemAttributes xmlArrayItems = new XmlArrayItemAttributes();

		// Token: 0x040019DA RID: 6618
		private XmlAnyElementAttributes xmlAnyElements = new XmlAnyElementAttributes();

		// Token: 0x040019DB RID: 6619
		private XmlArrayAttribute xmlArray;

		// Token: 0x040019DC RID: 6620
		private XmlAttributeAttribute xmlAttribute;

		// Token: 0x040019DD RID: 6621
		private XmlTextAttribute xmlText;

		// Token: 0x040019DE RID: 6622
		private XmlEnumAttribute xmlEnum;

		// Token: 0x040019DF RID: 6623
		private bool xmlIgnore;

		// Token: 0x040019E0 RID: 6624
		private bool xmlns;

		// Token: 0x040019E1 RID: 6625
		private object xmlDefaultValue;

		// Token: 0x040019E2 RID: 6626
		private XmlRootAttribute xmlRoot;

		// Token: 0x040019E3 RID: 6627
		private XmlTypeAttribute xmlType;

		// Token: 0x040019E4 RID: 6628
		private XmlAnyAttributeAttribute xmlAnyAttribute;

		// Token: 0x040019E5 RID: 6629
		private XmlChoiceIdentifierAttribute xmlChoiceIdentifier;

		// Token: 0x040019E6 RID: 6630
		private static volatile Type ignoreAttributeType;
	}
}
