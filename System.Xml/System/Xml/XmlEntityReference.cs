using System;

namespace System.Xml
{
	/// <summary>
	///         Представляет узел ссылки на сущность.
	///       </summary>
	// Token: 0x020001C6 RID: 454
	public class XmlEntityReference : XmlLinkedNode
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlEntityReference" />.
		///       </summary>
		/// <param name="name">
		///           Имя ссылки на сущность; в разделе <see cref="P:System.Xml.XmlEntityReference.Name" /> свойство.
		///         </param>
		/// <param name="doc">
		///           Родительский XML-документ.
		///         </param>
		// Token: 0x06001172 RID: 4466 RVA: 0x0006AB04 File Offset: 0x00068D04
		protected internal XmlEntityReference(string name, XmlDocument doc) : base(doc)
		{
			if (!doc.IsLoading && name.Length > 0 && name[0] == '#')
			{
				throw new ArgumentException(Res.GetString("Cannot create an 'EntityReference' node with a name starting with '#'."));
			}
			this.name = doc.NameTable.Add(name);
			doc.fEntRefNodesPresent = true;
		}

		/// <summary>
		///         Возвращает имя узла.
		///       </summary>
		/// <returns>
		///         Имя сущности, на которую существует ссылка.
		///       </returns>
		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0006AB5D File Offset: 0x00068D5D
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlEntityReference" /> узлов, это свойство возвращает имя ссылки на сущность.
		///       </returns>
		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0006AB5D File Offset: 0x00068D5D
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает или задает значение узла.
		///       </summary>
		/// <returns>
		///         Значение узла.
		///          Для <see langword="XmlEntityReference" /> узлов, это свойство возвращает <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Узел доступен только для чтения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Задание для свойства.
		///           </exception>
		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0001DA42 File Offset: 0x0001BC42
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0006AB65 File Offset: 0x00068D65
		public override string Value
		{
			get
			{
				return null;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("'EntityReference' nodes have no support for setting value."));
			}
		}

		/// <summary>
		///         Возвращает тип узла.
		///       </summary>
		/// <returns>
		///         Тип узла.
		///          Для <see langword="XmlEntityReference" /> узлов, значение равно XmlNodeType.EntityReference.
		///       </returns>
		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0006AB76 File Offset: 0x00068D76
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.EntityReference;
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Для <see langword="XmlEntityReference" /> узлов, этот метод всегда возвращает узел ссылки на сущность без дочерних узлов.
		///            Текст замены устанавливается при вставке узла в родительский узел.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x06001178 RID: 4472 RVA: 0x0006AB79 File Offset: 0x00068D79
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateEntityReference(this.name);
		}

		/// <summary>
		///         Возвращает значение, определяющее, доступен ли узел только для чтения.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если узел доступен только для чтения; в противном случае <see langword="false" />.
		///
		///         Поскольку <see langword="XmlEntityReference" /> узлы доступны только для чтения, это свойство всегда возвращает <see langword="true" />.
		///       </returns>
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0001222F File Offset: 0x0001042F
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x0006AB8C File Offset: 0x00068D8C
		internal override void SetParent(XmlNode node)
		{
			base.SetParent(node);
			if (this.LastNode == null && node != null && node != this.OwnerDocument)
			{
				new XmlLoader().ExpandEntityReference(this);
			}
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0006ABB4 File Offset: 0x00068DB4
		internal override void SetParentForLoad(XmlNode node)
		{
			this.SetParent(node);
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0006ABBD File Offset: 0x00068DBD
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0006ABC5 File Offset: 0x00068DC5
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

		// Token: 0x0600117F RID: 4479 RVA: 0x0006ABD0 File Offset: 0x00068DD0
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
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001180 RID: 4480 RVA: 0x0006AC22 File Offset: 0x00068E22
		public override void WriteTo(XmlWriter w)
		{
			w.WriteEntityRef(this.name);
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x06001181 RID: 4481 RVA: 0x0006AC30 File Offset: 0x00068E30
		public override void WriteContentTo(XmlWriter w)
		{
			foreach (object obj in this)
			{
				((XmlNode)obj).WriteTo(w);
			}
		}

		/// <summary>
		///         Получает базовый универсальный код ресурса (URI) текущего узла.
		///       </summary>
		/// <returns>
		///         Расположение, из которого загружен узел.
		///       </returns>
		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0006AC84 File Offset: 0x00068E84
		public override string BaseURI
		{
			get
			{
				return this.OwnerDocument.BaseURI;
			}
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x0006AC94 File Offset: 0x00068E94
		private string ConstructBaseURI(string baseURI, string systemId)
		{
			if (baseURI == null)
			{
				return systemId;
			}
			int num = baseURI.LastIndexOf('/') + 1;
			string str = baseURI;
			if (num > 0 && num < baseURI.Length)
			{
				str = baseURI.Substring(0, num);
			}
			else if (num == 0)
			{
				str += "\\";
			}
			return str + systemId.Replace('\\', '/');
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0006ACEC File Offset: 0x00068EEC
		internal string ChildBaseURI
		{
			get
			{
				XmlEntity entityNode = this.OwnerDocument.GetEntityNode(this.name);
				if (entityNode == null)
				{
					return string.Empty;
				}
				if (entityNode.SystemId != null && entityNode.SystemId.Length > 0)
				{
					return this.ConstructBaseURI(entityNode.BaseURI, entityNode.SystemId);
				}
				return entityNode.BaseURI;
			}
		}

		// Token: 0x04001099 RID: 4249
		private string name;

		// Token: 0x0400109A RID: 4250
		private XmlLinkedNode lastChild;
	}
}
