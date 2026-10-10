using System;
using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет элемент.
	///       </summary>
	// Token: 0x020001C0 RID: 448
	public class XmlElement : XmlLinkedNode
	{
		// Token: 0x06001107 RID: 4359 RVA: 0x00069B14 File Offset: 0x00067D14
		internal XmlElement(XmlName name, bool empty, XmlDocument doc) : base(doc)
		{
			this.parentNode = null;
			if (!doc.IsLoading)
			{
				XmlDocument.CheckName(name.Prefix);
				XmlDocument.CheckName(name.LocalName);
			}
			if (name.LocalName.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The local name for elements or attributes cannot be null or an empty string."));
			}
			this.name = name;
			if (empty)
			{
				this.lastChild = this;
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlElement" />.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен; в разделе <see cref="P:System.Xml.XmlElement.Prefix" /> свойство.
		///         </param>
		/// <param name="localName">
		///           Локальное имя; в разделе <see cref="P:System.Xml.XmlElement.LocalName" /> свойство.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен; в разделе <see cref="P:System.Xml.XmlElement.NamespaceURI" /> свойство.
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x06001108 RID: 4360 RVA: 0x00069B7B File Offset: 0x00067D7B
		protected internal XmlElement(string prefix, string localName, string namespaceURI, XmlDocument doc) : this(doc.AddXmlName(prefix, localName, namespaceURI, null), true, doc)
		{
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x00069B91 File Offset: 0x00067D91
		// (set) Token: 0x0600110A RID: 4362 RVA: 0x00069B99 File Offset: 0x00067D99
		internal XmlName XmlName
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
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла (и его атрибутов, если узел является <see langword="XmlElement" />).
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x0600110B RID: 4363 RVA: 0x00069BA4 File Offset: 0x00067DA4
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			bool isLoading = ownerDocument.IsLoading;
			ownerDocument.IsLoading = true;
			XmlElement xmlElement = ownerDocument.CreateElement(this.Prefix, this.LocalName, this.NamespaceURI);
			ownerDocument.IsLoading = isLoading;
			if (xmlElement.IsEmpty != this.IsEmpty)
			{
				xmlElement.IsEmpty = this.IsEmpty;
			}
			if (this.HasAttributes)
			{
				foreach (object obj in this.Attributes)
				{
					XmlAttribute xmlAttribute = (XmlAttribute)obj;
					XmlAttribute xmlAttribute2 = (XmlAttribute)xmlAttribute.CloneNode(true);
					if (xmlAttribute is XmlUnspecifiedAttribute && !xmlAttribute.Specified)
					{
						((XmlUnspecifiedAttribute)xmlAttribute2).SetSpecified(false);
					}
					xmlElement.Attributes.InternalAppendAttribute(xmlAttribute2);
				}
			}
			if (deep)
			{
				xmlElement.CopyChildren(ownerDocument, this, deep);
			}
			return xmlElement;
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Полное имя узла.
		///          Для узлов <see langword="XmlElement" /> это имя тега элемента.
		///       </returns>
		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x00069C9C File Offset: 0x00067E9C
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Имя текущего узла с удаленным префиксом.
		///          Например, <see langword="LocalName" /> — это книга для элемента &lt;bk:book&gt;.
		///       </returns>
		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x00069CA9 File Offset: 0x00067EA9
		public override string LocalName
		{
			get
			{
				return this.name.LocalName;
			}
		}

		/// <summary>
		///         Возвращает URI пространства имен данного узла.
		///       </summary>
		/// <returns>
		///         URI пространства имен данного узла.
		///          Если URI пространства имен отсутствует, возвращает String.Empty.
		///       </returns>
		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x0600110E RID: 4366 RVA: 0x00069CB6 File Offset: 0x00067EB6
		public override string NamespaceURI
		{
			get
			{
				return this.name.NamespaceURI;
			}
		}

		/// <summary>
		///         Возвращает или задает префикс пространства имен данного узла.
		///       </summary>
		/// <returns>
		///         Префикс пространства имен данного узла.
		///          Если префикс отсутствует, данное свойство возвращает String.Empty.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел только для чтения. 
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Указанный префикс содержит недопустимый символ.
		///
		///             Указанный префикс имеет неправильный формат.
		///
		///             URI пространства имен этого узла — <see langword="null" />.
		///
		///             Указанный префикс — "xml", а URI пространства имен данного узла отличается от http://www.w3.org/XML/1998/namespace.
		///           </exception>
		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x00069CC3 File Offset: 0x00067EC3
		// (set) Token: 0x06001110 RID: 4368 RVA: 0x00069CD0 File Offset: 0x00067ED0
		public override string Prefix
		{
			get
			{
				return this.name.Prefix;
			}
			set
			{
				this.name = this.name.OwnerDocument.AddXmlName(value, this.LocalName, this.NamespaceURI, this.SchemaInfo);
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Тип узла.
		///          Для <see langword="XmlElement" /> узлов, это значение является XmlNodeType.Element.
		///       </returns>
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06001111 RID: 4369 RVA: 0x0001222F File Offset: 0x0001042F
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Element;
			}
		}

		/// <summary>
		///         Возвращает родительский узел для данного узла (только для тех узлов, которые могут иметь родительские узлы).
		///       </summary>
		/// <returns>
		///         Объект <see langword="XmlNode" />, являющийся родительским по отношению к текущему узлу.
		///          Если узел уже создан, но еще не добавлен в дерево или если узел был из дерева удален, родительский узел равен <see langword="null" />.
		///          Для всех других узлов возвращаемое значение зависит от свойства <see cref="P:System.Xml.XmlNode.NodeType" /> узла.
		///          В следующей таблице описаны возможные возвращаемые значения для свойства <see langword="ParentNode" />.
		///       </returns>
		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06001112 RID: 4370 RVA: 0x00069CFB File Offset: 0x00067EFB
		public override XmlNode ParentNode
		{
			get
			{
				return this.parentNode;
			}
		}

		/// <summary>
		///         Возвращает документ <see cref="T:System.Xml.XmlDocument" />, к которому относится данный узел.
		///       </summary>
		/// <returns>
		///         Документ <see langword="XmlDocument" />, к которому относится данный элемент.
		///       </returns>
		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06001113 RID: 4371 RVA: 0x00069D03 File Offset: 0x00067F03
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.OwnerDocument;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001114 RID: 4372 RVA: 0x0001222F File Offset: 0x0001042F
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00069D10 File Offset: 0x00067F10
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (this.lastChild == null || this.lastChild == this)
			{
				xmlLinkedNode.next = xmlLinkedNode;
				this.lastChild = xmlLinkedNode;
				xmlLinkedNode.SetParentForLoad(this);
			}
			else
			{
				XmlLinkedNode xmlLinkedNode2 = this.lastChild;
				xmlLinkedNode.next = xmlLinkedNode2.next;
				xmlLinkedNode2.next = xmlLinkedNode;
				this.lastChild = xmlLinkedNode;
				if (xmlLinkedNode2.IsText && xmlLinkedNode.IsText)
				{
					XmlNode.NestTextNodes(xmlLinkedNode2, xmlLinkedNode);
				}
				else
				{
					xmlLinkedNode.SetParentForLoad(this);
				}
			}
			if (insertEventArgsForLoad != null)
			{
				doc.AfterEvent(insertEventArgsForLoad);
			}
			return xmlLinkedNode;
		}

		/// <summary>
		///         Получает или задает формат тега данного элемента.
		///       </summary>
		/// <returns>
		///         Возвращает значение <see langword="true" /> при сериализации в сокращенном формате тегов "&lt;item/&gt;"; значение <see langword="false" /> обозначает полный формат "&lt;item&gt;&lt;/item&gt;".
		///
		///         При определении этого свойства, если задано значение <see langword="true" />, дочерние элементы элемента удаляются и элемент сериализуется в сокращенном формате тегов.
		///          Если задано значение <see langword="false" />, значение свойства изменяется (независимо от того, имеет ли элемент содержимое); если элемент пуст, он сериализуется в полном формате.
		///
		///         Это свойство является расширением Microsoft для объектной модели документа (DOM).
		///       </returns>
		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001116 RID: 4374 RVA: 0x00069DAB File Offset: 0x00067FAB
		// (set) Token: 0x06001117 RID: 4375 RVA: 0x00069DB6 File Offset: 0x00067FB6
		public bool IsEmpty
		{
			get
			{
				return this.lastChild == this;
			}
			set
			{
				if (value)
				{
					if (this.lastChild != this)
					{
						this.RemoveAllChildren();
						this.lastChild = this;
						return;
					}
				}
				else if (this.lastChild == this)
				{
					this.lastChild = null;
				}
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001118 RID: 4376 RVA: 0x00069DE2 File Offset: 0x00067FE2
		// (set) Token: 0x06001119 RID: 4377 RVA: 0x00069DF5 File Offset: 0x00067FF5
		internal override XmlLinkedNode LastNode
		{
			get
			{
				if (this.lastChild != this)
				{
					return this.lastChild;
				}
				return null;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00069E00 File Offset: 0x00068000
		internal override bool IsValidChildType(XmlNodeType type)
		{
			switch (type)
			{
			case XmlNodeType.Element:
			case XmlNodeType.Text:
			case XmlNodeType.CDATA:
			case XmlNodeType.EntityReference:
			case XmlNodeType.ProcessingInstruction:
			case XmlNodeType.Comment:
			case XmlNodeType.Whitespace:
			case XmlNodeType.SignificantWhitespace:
				return true;
			}
			return false;
		}

		/// <summary>
		///         Получает коллекцию <see cref="T:System.Xml.XmlAttributeCollection" />, содержащую список атрибутов для этого узла.
		///       </summary>
		/// <returns>
		///         Коллекция <see cref="T:System.Xml.XmlAttributeCollection" />, содержащая список атрибутов для этого узла.
		///       </returns>
		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600111B RID: 4379 RVA: 0x00069E54 File Offset: 0x00068054
		public override XmlAttributeCollection Attributes
		{
			get
			{
				if (this.attributes == null)
				{
					object objLock = this.OwnerDocument.objLock;
					lock (objLock)
					{
						if (this.attributes == null)
						{
							this.attributes = new XmlAttributeCollection(this);
						}
					}
				}
				return this.attributes;
			}
		}

		/// <summary>
		///         Возвращает значение <see langword="boolean" />, показывающее, имеются ли атрибуты у текущего узла.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел содержит атрибуты; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x170002EC RID: 748
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00069EB8 File Offset: 0x000680B8
		public virtual bool HasAttributes
		{
			get
			{
				return this.attributes != null && this.attributes.Count > 0;
			}
		}

		/// <summary>
		///         Возвращает значение для атрибута с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Имя извлекаемого атрибута.
		///            Это полное имя.
		///            Оно противопоставляется свойству <see langword="Name" /> соответствующего узла.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если соответствующий атрибут не найден, или если атрибут не имеет заданного значения или значения по умолчанию, то возвращается пустая строка.
		///       </returns>
		// Token: 0x0600111D RID: 4381 RVA: 0x00069ED4 File Offset: 0x000680D4
		public virtual string GetAttribute(string name)
		{
			XmlAttribute attributeNode = this.GetAttributeNode(name);
			if (attributeNode != null)
			{
				return attributeNode.Value;
			}
			return string.Empty;
		}

		/// <summary>
		///         Задает значение атрибута с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Имя атрибута для создания или изменения.
		///            Это полное имя.
		///            Если имя содержит двоеточие, оно разбивается на префикс и локальное имя.
		///         </param>
		/// <param name="value">
		///           Значение для атрибута.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             Указанное имя содержит недопустимый символ.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x0600111E RID: 4382 RVA: 0x00069EF8 File Offset: 0x000680F8
		public virtual void SetAttribute(string name, string value)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(name);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(name);
				xmlAttribute.Value = value;
				this.Attributes.InternalAppendAttribute(xmlAttribute);
				return;
			}
			xmlAttribute.Value = value;
		}

		/// <summary>
		///         Удаляет атрибут по имени.
		///       </summary>
		/// <param name="name">
		///           Имя удаляемого атрибута. Это полное имя.
		///            Оно противопоставляется свойству <see langword="Name" /> соответствующего узла.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x0600111F RID: 4383 RVA: 0x00069F39 File Offset: 0x00068139
		public virtual void RemoveAttribute(string name)
		{
			if (this.HasAttributes)
			{
				this.Attributes.RemoveNamedItem(name);
			}
		}

		/// <summary>
		///         Возвращает <see langword="XmlAttribute" /> с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Имя извлекаемого атрибута.
		///            Это полное имя.
		///            Оно противопоставляется свойству <see langword="Name" /> соответствующего узла.
		///         </param>
		/// <returns>
		///         Указанный объект <see langword="XmlAttribute" /> или <see langword="null" />, если не удалось найти соответствующий атрибут.
		///       </returns>
		// Token: 0x06001120 RID: 4384 RVA: 0x00069F50 File Offset: 0x00068150
		public virtual XmlAttribute GetAttributeNode(string name)
		{
			if (this.HasAttributes)
			{
				return this.Attributes[name];
			}
			return null;
		}

		/// <summary>
		///         Добавляет указанный <see cref="T:System.Xml.XmlAttribute" />.
		///       </summary>
		/// <param name="newAttr">
		///           <see langword="XmlAttribute" /> Узел для добавления в коллекцию атрибутов этого элемента.
		///         </param>
		/// <returns>
		///         Если атрибут заменяет существующий атрибут с таким же именем, старый <see langword="XmlAttribute" /> возвращается; в противном случае — <see langword="null" /> возвращается.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newAttr" /> Был создан из документа, отличного от того, который создан данный узел.
		///              Или этот узел доступен только для чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <paramref name="newAttr" /> Уже является атрибутом другого <see langword="XmlElement" /> объекта.
		///              Необходимо явно клонировать <see langword="XmlAttribute" /> узлов для повторного использования их в других <see langword="XmlElement" /> объектов.
		///           </exception>
		// Token: 0x06001121 RID: 4385 RVA: 0x00069F68 File Offset: 0x00068168
		public virtual XmlAttribute SetAttributeNode(XmlAttribute newAttr)
		{
			if (newAttr.OwnerElement != null)
			{
				throw new InvalidOperationException(Res.GetString("The 'Attribute' node cannot be inserted because it is already an attribute of another element."));
			}
			return (XmlAttribute)this.Attributes.SetNamedItem(newAttr);
		}

		/// <summary>
		///         Удаляет указанный <see cref="T:System.Xml.XmlAttribute" />.
		///       </summary>
		/// <param name="oldAttr">
		///           <see langword="XmlAttribute" /> Узла для удаления.
		///            Если удаленный атрибут имеет значение по умолчанию, он немедленно заменяется.
		///         </param>
		/// <returns>
		///         Удален <see langword="XmlAttribute" /> или <see langword="null" /> Если <paramref name="oldAttr" /> не является узлом атрибута <see langword="XmlElement" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06001122 RID: 4386 RVA: 0x00069F93 File Offset: 0x00068193
		public virtual XmlAttribute RemoveAttributeNode(XmlAttribute oldAttr)
		{
			if (this.HasAttributes)
			{
				return this.Attributes.Remove(oldAttr);
			}
			return null;
		}

		/// <summary>
		///         Возвращает значение <see cref="T:System.Xml.XmlNodeList" />, содержащее список всех элементов-потомков, соответствующих указанному имени <see cref="P:System.Xml.XmlElement.Name" />.
		///       </summary>
		/// <param name="name">
		///           Сопоставляемый тег имени.
		///            Это полное имя.
		///            Оно противопоставляется свойству <see langword="Name" /> соответствующего узла.
		///            Звездочка (*) — это специальное значение, которое соответствует всем тегам.
		///         </param>
		/// <returns>
		///         Класс <see cref="T:System.Xml.XmlNodeList" />, содержащий список всех соответствующих узлов.
		///          Если соответствующие узлы отсутствуют, этот список пуст.
		///       </returns>
		// Token: 0x06001123 RID: 4387 RVA: 0x00068769 File Offset: 0x00066969
		public virtual XmlNodeList GetElementsByTagName(string name)
		{
			return new XmlElementList(this, name);
		}

		/// <summary>
		///         Возвращает значение атрибута с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен атрибута для извлечения.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если соответствующий атрибут не найден, или если атрибут не имеет заданного значения или значения по умолчанию, то возвращается пустая строка.
		///       </returns>
		// Token: 0x06001124 RID: 4388 RVA: 0x00069FAC File Offset: 0x000681AC
		public virtual string GetAttribute(string localName, string namespaceURI)
		{
			XmlAttribute attributeNode = this.GetAttributeNode(localName, namespaceURI);
			if (attributeNode != null)
			{
				return attributeNode.Value;
			}
			return string.Empty;
		}

		/// <summary>
		///         Задает значение атрибута с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <param name="value">
		///           Значение для атрибута.
		///         </param>
		/// <returns>
		///         Значение атрибута.
		///       </returns>
		// Token: 0x06001125 RID: 4389 RVA: 0x00069FD4 File Offset: 0x000681D4
		public virtual string SetAttribute(string localName, string namespaceURI, string value)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(localName, namespaceURI);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(string.Empty, localName, namespaceURI);
				xmlAttribute.Value = value;
				this.Attributes.InternalAppendAttribute(xmlAttribute);
			}
			else
			{
				xmlAttribute.Value = value;
			}
			return value;
		}

		/// <summary>
		///         Удаляет атрибут с заданным локальным именем и URI пространства имен.
		///          Если удаляемый атрибут имеет значение по умолчанию, он будет немедленно заменен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен атрибута для удаления.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06001126 RID: 4390 RVA: 0x0006A01E File Offset: 0x0006821E
		public virtual void RemoveAttribute(string localName, string namespaceURI)
		{
			this.RemoveAttributeNode(localName, namespaceURI);
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlAttribute" /> с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Указанный объект <see langword="XmlAttribute" /> или <see langword="null" />, если не удалось найти соответствующий атрибут.
		///       </returns>
		// Token: 0x06001127 RID: 4391 RVA: 0x0006A029 File Offset: 0x00068229
		public virtual XmlAttribute GetAttributeNode(string localName, string namespaceURI)
		{
			if (this.HasAttributes)
			{
				return this.Attributes[localName, namespaceURI];
			}
			return null;
		}

		/// <summary>
		///         Добавляет указанный <see cref="T:System.Xml.XmlAttribute" />.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Добавляемый объект <see langword="XmlAttribute" />.
		///       </returns>
		// Token: 0x06001128 RID: 4392 RVA: 0x0006A044 File Offset: 0x00068244
		public virtual XmlAttribute SetAttributeNode(string localName, string namespaceURI)
		{
			XmlAttribute xmlAttribute = this.GetAttributeNode(localName, namespaceURI);
			if (xmlAttribute == null)
			{
				xmlAttribute = this.OwnerDocument.CreateAttribute(string.Empty, localName, namespaceURI);
				this.Attributes.InternalAppendAttribute(xmlAttribute);
			}
			return xmlAttribute;
		}

		/// <summary>
		///         Удаляет <see cref="T:System.Xml.XmlAttribute" /> указанный по локальному имени и URI пространства имен.
		///          Если удаляемый атрибут имеет значение по умолчанию, он будет немедленно заменен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Удален <see langword="XmlAttribute" /> или <see langword="null" /> Если <see langword="XmlElement" /> не имеет соответствующего узла атрибута.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06001129 RID: 4393 RVA: 0x0006A080 File Offset: 0x00068280
		public virtual XmlAttribute RemoveAttributeNode(string localName, string namespaceURI)
		{
			if (this.HasAttributes)
			{
				XmlAttribute attributeNode = this.GetAttributeNode(localName, namespaceURI);
				this.Attributes.Remove(attributeNode);
				return attributeNode;
			}
			return null;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNodeList" />, содержащий список всех элементов-потомков, соответствующих указанным значениям <see cref="P:System.Xml.XmlElement.LocalName" /> и <see cref="P:System.Xml.XmlElement.NamespaceURI" />.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя для сопоставления.
		///            Звездочка (*) — это специальное значение, которое соответствует всем тегам.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен для сопоставления.
		///         </param>
		/// <returns>
		///         Класс <see cref="T:System.Xml.XmlNodeList" />, содержащий список всех соответствующих узлов.
		///          Если соответствующие узлы отсутствуют, этот список пуст.
		///       </returns>
		// Token: 0x0600112A RID: 4394 RVA: 0x000687CC File Offset: 0x000669CC
		public virtual XmlNodeList GetElementsByTagName(string localName, string namespaceURI)
		{
			return new XmlElementList(this, localName, namespaceURI);
		}

		/// <summary>
		///         Определяет, имеет ли текущий узел атрибут с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Имя атрибута, который требуется найти.
		///            Это полное имя.
		///            Оно противопоставляется свойству <see langword="Name" /> соответствующего узла.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел имеет указанный атрибут; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600112B RID: 4395 RVA: 0x0006A0AE File Offset: 0x000682AE
		public virtual bool HasAttribute(string name)
		{
			return this.GetAttributeNode(name) != null;
		}

		/// <summary>
		///         Определяет, имеет ли текущий узел атрибута с заданным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута для поиска.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен атрибута для поиска.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел имеет указанный атрибут; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x0600112C RID: 4396 RVA: 0x0006A0BA File Offset: 0x000682BA
		public virtual bool HasAttribute(string localName, string namespaceURI)
		{
			return this.GetAttributeNode(localName, namespaceURI) != null;
		}

		/// <summary>
		///         Сохраняет текущий узел в заданном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x0600112D RID: 4397 RVA: 0x0006A0C8 File Offset: 0x000682C8
		public override void WriteTo(XmlWriter w)
		{
			if (base.GetType() == typeof(XmlElement))
			{
				XmlElement.WriteElementTo(w, this);
				return;
			}
			this.WriteStartElement(w);
			if (this.IsEmpty)
			{
				w.WriteEndElement();
				return;
			}
			this.WriteContentTo(w);
			w.WriteFullEndElement();
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0006A118 File Offset: 0x00068318
		private static void WriteElementTo(XmlWriter writer, XmlElement e)
		{
			XmlNode xmlNode = e;
			XmlNode xmlNode2 = e;
			for (;;)
			{
				e = (xmlNode2 as XmlElement);
				if (e != null && e.GetType() == typeof(XmlElement))
				{
					e.WriteStartElement(writer);
					if (e.IsEmpty)
					{
						writer.WriteEndElement();
					}
					else
					{
						if (e.lastChild != null)
						{
							xmlNode2 = e.FirstChild;
							continue;
						}
						writer.WriteFullEndElement();
					}
				}
				else
				{
					xmlNode2.WriteTo(writer);
				}
				while (xmlNode2 != xmlNode && xmlNode2 == xmlNode2.ParentNode.LastChild)
				{
					xmlNode2 = xmlNode2.ParentNode;
					writer.WriteFullEndElement();
				}
				if (xmlNode2 == xmlNode)
				{
					break;
				}
				xmlNode2 = xmlNode2.NextSibling;
			}
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x0006A1B4 File Offset: 0x000683B4
		private void WriteStartElement(XmlWriter w)
		{
			w.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceURI);
			if (this.HasAttributes)
			{
				XmlAttributeCollection xmlAttributeCollection = this.Attributes;
				for (int i = 0; i < xmlAttributeCollection.Count; i++)
				{
					xmlAttributeCollection[i].WriteTo(w);
				}
			}
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001130 RID: 4400 RVA: 0x0006A208 File Offset: 0x00068408
		public override void WriteContentTo(XmlWriter w)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				xmlNode.WriteTo(w);
			}
		}

		/// <summary>
		///         Удаляет из элемента узел атрибута с указанным индексом.
		///          Если удаляемый атрибут имеет значение по умолчанию, он будет немедленно заменен.
		///       </summary>
		/// <param name="i">
		///           Индекс удаляемого узла.
		///            Первый узел имеет индекс 0.
		///         </param>
		/// <returns>
		///         Удаленный узел атрибута или значение <see langword="null" />, если узел с таким индексом отсутствует.
		///       </returns>
		// Token: 0x06001131 RID: 4401 RVA: 0x0006A22F File Offset: 0x0006842F
		public virtual XmlNode RemoveAttributeAt(int i)
		{
			if (this.HasAttributes)
			{
				return this.attributes.RemoveAt(i);
			}
			return null;
		}

		/// <summary>
		///         Удаляет все заданные атрибуты из элемента.
		///          Атрибуты по умолчанию не удаляются.
		///       </summary>
		// Token: 0x06001132 RID: 4402 RVA: 0x0006A247 File Offset: 0x00068447
		public virtual void RemoveAllAttributes()
		{
			if (this.HasAttributes)
			{
				this.attributes.RemoveAll();
			}
		}

		/// <summary>
		///         Удаляет все указанные атрибуты и дочерние узлы текущего узла.
		///          Атрибуты по умолчанию не удаляются.
		///       </summary>
		// Token: 0x06001133 RID: 4403 RVA: 0x0006A25C File Offset: 0x0006845C
		public override void RemoveAll()
		{
			base.RemoveAll();
			this.RemoveAllAttributes();
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0006A26A File Offset: 0x0006846A
		internal void RemoveAllChildren()
		{
			base.RemoveAll();
		}

		/// <summary>
		///         Возвращает информационный набор после проверки схемы (назначенный этому узлу в результате проверки схемы).
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> Объект, содержащий информационный проверки схемы этого узла.
		///       </returns>
		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001135 RID: 4405 RVA: 0x00069B91 File Offset: 0x00067D91
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Получает или задает разметку, представляющую только дочерние элементы этого узла.
		///       </summary>
		/// <returns>
		///         Разметка дочерних элементов данного узла.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Формат XML, указанный при задании этого свойства, является неправильным.
		///           </exception>
		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001136 RID: 4406 RVA: 0x0006900B File Offset: 0x0006720B
		// (set) Token: 0x06001137 RID: 4407 RVA: 0x0006A272 File Offset: 0x00068472
		public override string InnerXml
		{
			get
			{
				return base.InnerXml;
			}
			set
			{
				this.RemoveAllChildren();
				new XmlLoader().LoadInnerXmlElement(this, value);
			}
		}

		/// <summary>
		///         Возвращает или задает сцепленные значения узла и всех его дочерних узлов.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения узла и его дочерних узлов.
		///       </returns>
		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001138 RID: 4408 RVA: 0x0006A286 File Offset: 0x00068486
		// (set) Token: 0x06001139 RID: 4409 RVA: 0x0006A290 File Offset: 0x00068490
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				XmlLinkedNode lastNode = this.LastNode;
				if (lastNode != null && lastNode.NodeType == XmlNodeType.Text && lastNode.next == lastNode)
				{
					lastNode.Value = value;
					return;
				}
				this.RemoveAllChildren();
				this.AppendChild(this.OwnerDocument.CreateTextNode(value));
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNode" /> сразу после этого элемента.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNode" /> Сразу после этого элемента.
		///       </returns>
		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600113A RID: 4410 RVA: 0x0006A2DA File Offset: 0x000684DA
		public override XmlNode NextSibling
		{
			get
			{
				if (this.parentNode != null && this.parentNode.LastNode != this)
				{
					return this.next;
				}
				return null;
			}
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x00066A96 File Offset: 0x00064C96
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600113C RID: 4412 RVA: 0x0001222F File Offset: 0x0001042F
		internal override XPathNodeType XPNodeType
		{
			get
			{
				return XPathNodeType.Element;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600113D RID: 4413 RVA: 0x0006A2FA File Offset: 0x000684FA
		internal override string XPLocalName
		{
			get
			{
				return this.LocalName;
			}
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x0006A304 File Offset: 0x00068504
		internal override string GetXPAttribute(string localName, string ns)
		{
			if (ns == this.OwnerDocument.strReservedXmlns)
			{
				return null;
			}
			XmlAttribute attributeNode = this.GetAttributeNode(localName, ns);
			if (attributeNode != null)
			{
				return attributeNode.Value;
			}
			return string.Empty;
		}

		// Token: 0x0400107C RID: 4220
		private XmlName name;

		// Token: 0x0400107D RID: 4221
		private XmlAttributeCollection attributes;

		// Token: 0x0400107E RID: 4222
		private XmlLinkedNode lastChild;
	}
}
