using System;
using System.Xml.Schema;
using System.Xml.XPath;

namespace System.Xml
{
	/// <summary>
	///         Представляет атрибут.
	///          Допустимые значения и значения по умолчанию для атрибута определены в определении типа документа (DTD) или схеме.
	///       </summary>
	// Token: 0x020001B4 RID: 436
	public class XmlAttribute : XmlNode
	{
		// Token: 0x06000FD3 RID: 4051 RVA: 0x00066624 File Offset: 0x00064824
		internal XmlAttribute(XmlName name, XmlDocument doc) : base(doc)
		{
			this.parentNode = null;
			if (!doc.IsLoading)
			{
				XmlDocument.CheckName(name.Prefix);
				XmlDocument.CheckName(name.LocalName);
			}
			if (name.LocalName.Length == 0)
			{
				throw new ArgumentException(Res.GetString("The attribute local name cannot be empty."));
			}
			this.name = name;
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000FD4 RID: 4052 RVA: 0x00066681 File Offset: 0x00064881
		internal int LocalNameHash
		{
			get
			{
				return this.name.HashCode;
			}
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlAttribute" />.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен.
		///         </param>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI пространства имен).
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x06000FD5 RID: 4053 RVA: 0x0006668E File Offset: 0x0006488E
		protected internal XmlAttribute(string prefix, string localName, string namespaceURI, XmlDocument doc) : this(doc.AddAttrXmlName(prefix, localName, namespaceURI, null), doc)
		{
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000666A3 File Offset: 0x000648A3
		// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x000666AB File Offset: 0x000648AB
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
		///           <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; <see langword="false" /> для клонирования только самого узла 
		///         </param>
		/// <returns>
		///         Узел-дубликат.
		///       </returns>
		// Token: 0x06000FD8 RID: 4056 RVA: 0x000666B4 File Offset: 0x000648B4
		public override XmlNode CloneNode(bool deep)
		{
			XmlDocument ownerDocument = this.OwnerDocument;
			XmlAttribute xmlAttribute = ownerDocument.CreateAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
			xmlAttribute.CopyChildren(ownerDocument, this, true);
			return xmlAttribute;
		}

		/// <summary>
		///         Возвращает родительский узел данного узла.
		///          Для <see langword="XmlAttribute" /> узлов, это свойство всегда возвращает <see langword="null" />.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlAttribute" /> узлов, это свойство всегда возвращает <see langword="null" />.
		///       </returns>
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000FD9 RID: 4057 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public override XmlNode ParentNode
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Полное имя узла атрибута.
		///       </returns>
		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000FDA RID: 4058 RVA: 0x000666E9 File Offset: 0x000648E9
		public override string Name
		{
			get
			{
				return this.name.Name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Имя узла атрибута с удаленным префиксом.
		///          В следующем примере &lt; книги bk:genre = «novel» &gt;, <see langword="LocalName" /> атрибута является <see langword="genre" />.
		///       </returns>
		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000FDB RID: 4059 RVA: 0x000666F6 File Offset: 0x000648F6
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
		///          Если атрибут не предоставлено пространство имен явно, это свойство возвращает String.Empty.
		///       </returns>
		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x00066703 File Offset: 0x00064903
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
		///             Этот узел доступен только для чтения.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Указанный префикс содержит недопустимый символ.
		///
		///             Указанный префикс имеет неправильный формат.
		///
		///             URI пространства имен этого узла — <see langword="null" />.
		///
		///             «Xml» используется указанный префикс и URI пространства имен данного узла отличается от «http://www.w3.org/XML/1998/namespace».
		///
		///             Этот узел является атрибутом, указанного префикса — «xmlns» и URI пространства имен данного узла отличается от «http://www.w3.org/2000/xmlns/».
		///
		///             Этот узел является атрибутом и полное имя данного узла — «xmlns» [пространства имен].
		///           </exception>
		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x00066710 File Offset: 0x00064910
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x0006671D File Offset: 0x0006491D
		public override string Prefix
		{
			get
			{
				return this.name.Prefix;
			}
			set
			{
				this.name = this.name.OwnerDocument.AddAttrXmlName(value, this.LocalName, this.NamespaceURI, this.SchemaInfo);
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Тип узла для <see langword="XmlAttribute" /> узлов — XmlNodeType.Attribute.
		///       </returns>
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x00066748 File Offset: 0x00064948
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Attribute;
			}
		}

		/// <summary>
		///         Возвращает документ <see cref="T:System.Xml.XmlDocument" />, к которому относится данный узел.
		///       </summary>
		/// <returns>
		///         XML-документ, к которому принадлежит данный узел.
		///       </returns>
		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000FE0 RID: 4064 RVA: 0x0006674B File Offset: 0x0006494B
		public override XmlDocument OwnerDocument
		{
			get
			{
				return this.name.OwnerDocument;
			}
		}

		/// <summary>
		///         Возвращает или задает значение узла.
		///       </summary>
		/// <returns>
		///         Возвращаемое значение зависит от значения свойства <see cref="P:System.Xml.XmlNode.NodeType" /> узла.
		///          Для <see langword="XmlAttribute" /> узлов, это свойство имеет значение атрибута.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Узел доступен только для чтения и вызвана операция set.
		///           </exception>
		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x00066758 File Offset: 0x00064958
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00066760 File Offset: 0x00064960
		public override string Value
		{
			get
			{
				return this.InnerText;
			}
			set
			{
				this.InnerText = value;
			}
		}

		/// <summary>
		///         Возвращает после проверки схемы, который был назначен этому узлу в результате проверки схемы.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> Содержащий после-проверки схемы этого узла.
		///       </returns>
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000666A3 File Offset: 0x000648A3
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Задает сцепленные значения узла и всех его дочерних узлов.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения узла и его дочерних узлов.
		///          Для узлов атрибутов это свойство имеет ту же функциональность, что <see cref="P:System.Xml.XmlAttribute.Value" /> свойство.
		///       </returns>
		// Token: 0x1700027F RID: 639
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0006676C File Offset: 0x0006496C
		public override string InnerText
		{
			set
			{
				if (this.PrepareOwnerElementInElementIdAttrMap())
				{
					string innerText = base.InnerText;
					base.InnerText = value;
					this.ResetOwnerElementInElementIdAttrMap(innerText);
					return;
				}
				base.InnerText = value;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000667A0 File Offset: 0x000649A0
		internal bool PrepareOwnerElementInElementIdAttrMap()
		{
			if (this.OwnerDocument.DtdSchemaInfo != null)
			{
				XmlElement ownerElement = this.OwnerElement;
				if (ownerElement != null)
				{
					return ownerElement.Attributes.PrepareParentInElementIdAttrMap(this.Prefix, this.LocalName);
				}
			}
			return false;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x000667E0 File Offset: 0x000649E0
		internal void ResetOwnerElementInElementIdAttrMap(string oldInnerText)
		{
			XmlElement ownerElement = this.OwnerElement;
			if (ownerElement != null)
			{
				ownerElement.Attributes.ResetParentInElementIdAttrMap(oldInnerText, this.InnerText);
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x0001222F File Offset: 0x0001042F
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x0006680C File Offset: 0x00064A0C
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			XmlNodeChangedEventArgs insertEventArgsForLoad = doc.GetInsertEventArgsForLoad(newChild, this);
			if (insertEventArgsForLoad != null)
			{
				doc.BeforeEvent(insertEventArgsForLoad);
			}
			XmlLinkedNode xmlLinkedNode = (XmlLinkedNode)newChild;
			if (this.lastChild == null)
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

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x0006689E File Offset: 0x00064A9E
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x000668A6 File Offset: 0x00064AA6
		internal override XmlLinkedNode LastNode
		{
			get
			{
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x000668AF File Offset: 0x00064AAF
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return type == XmlNodeType.Text || type == XmlNodeType.EntityReference;
		}

		/// <summary>
		///         Возвращает значение, указывающее, было ли явно задано значение атрибута.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если значение этого атрибута задано явным образом в исходном документе экземпляра; в противном случае — <see langword="false" />.
		///          Значение <see langword="false" /> показывает, что значение атрибута получено из DTD.
		///       </returns>
		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x0001222F File Offset: 0x0001042F
		public virtual bool Specified
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Вставляет заданный узел сразу перед указанным узлом ссылки.
		///       </summary>
		/// <param name="newChild">
		///           Вставляемый объект <see cref="T:System.Xml.XmlNode" />.
		///         </param>
		/// <param name="refChild">
		///           <see cref="T:System.Xml.XmlNode" /> Являющийся узлом ссылки.
		///           <paramref name="newChild" /> Помещается перед данным узлом.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Вставки.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел имеет тип, который не допускает дочерних узлов типа <paramref name="newChild" /> узла.
		///
		///             <paramref name="newChild" /> Является предком данного узла.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newChild" /> Был создан из документа, отличного от того, который создан данный узел.
		///
		///             <paramref name="refChild" /> Не является потомком этого узла.
		///
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06000FED RID: 4077 RVA: 0x000668BC File Offset: 0x00064ABC
		public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.InsertBefore(newChild, refChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.InsertBefore(newChild, refChild);
			}
			return result;
		}

		/// <summary>
		///         Вставляет заданный узел сразу после указанного узла ссылки.
		///       </summary>
		/// <param name="newChild">
		///           Вставляемый объект <see cref="T:System.Xml.XmlNode" />.
		///         </param>
		/// <param name="refChild">
		///           <see cref="T:System.Xml.XmlNode" /> Являющийся узлом ссылки.
		///           <paramref name="newChild" /> Размещается после <paramref name="refChild" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Вставки.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот узел имеет тип, который не допускает дочерних узлов типа <paramref name="newChild" /> узла.
		///
		///             <paramref name="newChild" /> Является предком данного узла.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newChild" /> Был создан из документа, отличного от того, который создан данный узел.
		///
		///             <paramref name="refChild" /> Не является потомком этого узла.
		///
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06000FEE RID: 4078 RVA: 0x000668F4 File Offset: 0x00064AF4
		public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.InsertAfter(newChild, refChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.InsertAfter(newChild, refChild);
			}
			return result;
		}

		/// <summary>
		///         Заменяет указанный дочерний узел с новым дочерним узлом.
		///       </summary>
		/// <param name="newChild">
		///           Новый дочерний <see cref="T:System.Xml.XmlNode" />.
		///         </param>
		/// <param name="oldChild">
		///           <see cref="T:System.Xml.XmlNode" /> Для замены.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Замены.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот узел имеет тип, который не допускает дочерних узлов типа <paramref name="newChild" /> узла.
		///
		///             <paramref name="newChild" /> Является предком данного узла.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newChild" /> Был создан из документа, отличного от того, который создан данный узел.
		///
		///             Этот узел доступен только для чтения.
		///
		///             <paramref name="oldChild" /> Не является потомком этого узла.
		///           </exception>
		// Token: 0x06000FEF RID: 4079 RVA: 0x0006692C File Offset: 0x00064B2C
		public override XmlNode ReplaceChild(XmlNode newChild, XmlNode oldChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.ReplaceChild(newChild, oldChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.ReplaceChild(newChild, oldChild);
			}
			return result;
		}

		/// <summary>
		///         Удаляет указанный дочерний узел.
		///       </summary>
		/// <param name="oldChild">
		///           Объект <see cref="T:System.Xml.XmlNode" /> для удаления.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Удалены.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="oldChild" /> Не является потомком этого узла.
		///              Или этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06000FF0 RID: 4080 RVA: 0x00066964 File Offset: 0x00064B64
		public override XmlNode RemoveChild(XmlNode oldChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.RemoveChild(oldChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.RemoveChild(oldChild);
			}
			return result;
		}

		/// <summary>
		///         Добавляет указанный узел в начало списка дочерних узлов данного узла.
		///       </summary>
		/// <param name="newChild">
		///           Добавляемый объект <see cref="T:System.Xml.XmlNode" />.
		///            Если это <see cref="T:System.Xml.XmlDocumentFragment" />, все содержимое фрагмента документа перемещается в список дочерних узлов данного узла.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Добавлена.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот узел имеет тип, который не допускает дочерних узлов типа <paramref name="newChild" /> узла.
		///
		///             <paramref name="newChild" /> Является предком данного узла.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newChild" /> Был создан из документа, отличного от того, который создан данный узел.
		///
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06000FF1 RID: 4081 RVA: 0x0006699C File Offset: 0x00064B9C
		public override XmlNode PrependChild(XmlNode newChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.PrependChild(newChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.PrependChild(newChild);
			}
			return result;
		}

		/// <summary>
		///         Добавляет указанный узел в конец списка дочерних узлов данного узла.
		///       </summary>
		/// <param name="newChild">
		///           Добавляемый объект <see cref="T:System.Xml.XmlNode" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNode" /> Добавлена.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Этот узел имеет тип, который не допускает дочерних узлов типа <paramref name="newChild" /> узла.
		///
		///             <paramref name="newChild" /> Является предком данного узла.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="newChild" /> Был создан из документа, отличного от того, который создан данный узел.
		///
		///             Этот узел доступен только для чтения.
		///           </exception>
		// Token: 0x06000FF2 RID: 4082 RVA: 0x000669D4 File Offset: 0x00064BD4
		public override XmlNode AppendChild(XmlNode newChild)
		{
			XmlNode result;
			if (this.PrepareOwnerElementInElementIdAttrMap())
			{
				string innerText = this.InnerText;
				result = base.AppendChild(newChild);
				this.ResetOwnerElementInElementIdAttrMap(innerText);
			}
			else
			{
				result = base.AppendChild(newChild);
			}
			return result;
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlElement" /> которому принадлежит атрибут.
		///       </summary>
		/// <returns>
		///         <see langword="XmlElement" /> К которому принадлежит атрибут или <see langword="null" /> Если этот атрибут не является частью <see langword="XmlElement" />.
		///       </returns>
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000FF3 RID: 4083 RVA: 0x00066A0A File Offset: 0x00064C0A
		public virtual XmlElement OwnerElement
		{
			get
			{
				return this.parentNode as XmlElement;
			}
		}

		/// <summary>
		///         Задает значение атрибута.
		///       </summary>
		/// <returns>
		///         Значение атрибута.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Формат XML, указанный при задании этого свойства, является неправильным.
		///           </exception>
		// Token: 0x17000284 RID: 644
		// (set) Token: 0x06000FF4 RID: 4084 RVA: 0x00066A17 File Offset: 0x00064C17
		public override string InnerXml
		{
			set
			{
				this.RemoveAll();
				new XmlLoader().LoadInnerXmlAttribute(this, value);
			}
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06000FF5 RID: 4085 RVA: 0x00066A2B File Offset: 0x00064C2B
		public override void WriteTo(XmlWriter w)
		{
			w.WriteStartAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
			this.WriteContentTo(w);
			w.WriteEndAttribute();
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06000FF6 RID: 4086 RVA: 0x00066A54 File Offset: 0x00064C54
		public override void WriteContentTo(XmlWriter w)
		{
			for (XmlNode xmlNode = this.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				xmlNode.WriteTo(w);
			}
		}

		/// <summary>
		///         Получает базовый универсальный ресурса (URI) узла.
		///       </summary>
		/// <returns>
		///         Место, из которого был загружен узел, или String.Empty, если базовый URI узла отсутствует.
		///          Узлам атрибутов присвоен базовый URI владеющего ими элемента.
		///          Если узел атрибута не имеет элемента-владельца, <see langword="BaseURI" /> возвращает String.Empty.
		///       </returns>
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00066A7B File Offset: 0x00064C7B
		public override string BaseURI
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.BaseURI;
				}
				return string.Empty;
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00066A96 File Offset: 0x00064C96
		internal override void SetParent(XmlNode node)
		{
			this.parentNode = node;
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00066A9F File Offset: 0x00064C9F
		internal override XmlSpace XmlSpace
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.XmlSpace;
				}
				return XmlSpace.None;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000FFA RID: 4090 RVA: 0x00066AB6 File Offset: 0x00064CB6
		internal override string XmlLang
		{
			get
			{
				if (this.OwnerElement != null)
				{
					return this.OwnerElement.XmlLang;
				}
				return string.Empty;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000FFB RID: 4091 RVA: 0x00066AD1 File Offset: 0x00064CD1
		internal override XPathNodeType XPNodeType
		{
			get
			{
				if (this.IsNamespace)
				{
					return XPathNodeType.Namespace;
				}
				return XPathNodeType.Attribute;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000FFC RID: 4092 RVA: 0x00066ADE File Offset: 0x00064CDE
		internal override string XPLocalName
		{
			get
			{
				if (this.name.Prefix.Length == 0 && this.name.LocalName == "xmlns")
				{
					return string.Empty;
				}
				return this.name.LocalName;
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00066B1A File Offset: 0x00064D1A
		internal bool IsNamespace
		{
			get
			{
				return Ref.Equal(this.name.NamespaceURI, this.name.OwnerDocument.strReservedXmlns);
			}
		}

		// Token: 0x0400103A RID: 4154
		private XmlName name;

		// Token: 0x0400103B RID: 4155
		private XmlLinkedNode lastChild;
	}
}
