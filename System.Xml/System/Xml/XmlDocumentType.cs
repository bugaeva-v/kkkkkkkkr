using System;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>
	///         Представляет объявление типа документа.
	///       </summary>
	// Token: 0x020001BE RID: 446
	public class XmlDocumentType : XmlLinkedNode
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlDocumentType" />.
		///       </summary>
		/// <param name="name">
		///           Полное имя; в разделе <see cref="P:System.Xml.XmlDocumentType.Name" /> свойство.
		///         </param>
		/// <param name="publicId">
		///           Открытый идентификатор; в разделе <see cref="P:System.Xml.XmlDocumentType.PublicId" /> свойство.
		///         </param>
		/// <param name="systemId">
		///           Идентификатор системы; в разделе <see cref="P:System.Xml.XmlDocumentType.SystemId" /> свойство.
		///         </param>
		/// <param name="internalSubset">
		///           Внутреннее подмножество DTD; в разделе <see cref="P:System.Xml.XmlDocumentType.InternalSubset" /> свойство.
		///         </param>
		/// <param name="doc">
		///           Родительский документ.
		///         </param>
		// Token: 0x060010F1 RID: 4337 RVA: 0x00069990 File Offset: 0x00067B90
		protected internal XmlDocumentType(string name, string publicId, string systemId, string internalSubset, XmlDocument doc) : base(doc)
		{
			this.name = name;
			this.publicId = publicId;
			this.systemId = systemId;
			this.namespaces = true;
			this.internalSubset = internalSubset;
			if (!doc.IsLoading)
			{
				doc.IsLoading = true;
				new XmlLoader().ParseDocumentType(this);
				doc.IsLoading = false;
			}
		}

		/// <summary>
		///         Возвращает полное имя узла.
		///       </summary>
		/// <returns>
		///         Для узлов DocumentType это свойство возвращает имя типа документа.
		///       </returns>
		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x060010F2 RID: 4338 RVA: 0x000699ED File Offset: 0x00067BED
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
		///         Для узлов DocumentType это свойство возвращает имя типа документа.
		///       </returns>
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x060010F3 RID: 4339 RVA: 0x000699ED File Offset: 0x00067BED
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Для узлов DocumentType это значение равно XmlNodeType.DocumentType.
		///       </returns>
		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x060010F4 RID: 4340 RVA: 0x000699F5 File Offset: 0x00067BF5
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.DocumentType;
			}
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///            Для узлов типа документа точная копия узла всегда включает поддерево независимо от значения параметра.
		///         </param>
		/// <returns>
		///         Точная копия узла.
		///       </returns>
		// Token: 0x060010F5 RID: 4341 RVA: 0x000699F9 File Offset: 0x00067BF9
		public override XmlNode CloneNode(bool deep)
		{
			return this.OwnerDocument.CreateDocumentType(this.name, this.publicId, this.systemId, this.internalSubset);
		}

		/// <summary>
		///         Возвращает значение, определяющее, доступен ли узел только для чтения.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если узел доступен только для чтения; в противном случае <see langword="false" />.
		///
		///         Поскольку узлы DocumentType доступны только для чтения, это свойство всегда возвращает <see langword="true" />.
		///       </returns>
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x060010F6 RID: 4342 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Xml.XmlEntity" /> узлов, объявленные в объявлении типа документа.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNamedNodeMap" /> Содержащий <see langword="XmlEntity" /> узлов.
		///          Возвращаемый поток <see langword="XmlNamedNodeMap" /> доступен только для чтения.
		///       </returns>
		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x00069A1E File Offset: 0x00067C1E
		public XmlNamedNodeMap Entities
		{
			get
			{
				if (this.entities == null)
				{
					this.entities = new XmlNamedNodeMap(this);
				}
				return this.entities;
			}
		}

		/// <summary>
		///         Возвращает коллекцию <see cref="T:System.Xml.XmlNotation" /> объявление типа узлов в документе.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlNamedNodeMap" /> Содержащий <see langword="XmlNotation" /> узлов.
		///          Возвращаемый поток <see langword="XmlNamedNodeMap" /> доступен только для чтения.
		///       </returns>
		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x00069A3A File Offset: 0x00067C3A
		public XmlNamedNodeMap Notations
		{
			get
			{
				if (this.notations == null)
				{
					this.notations = new XmlNamedNodeMap(this);
				}
				return this.notations;
			}
		}

		/// <summary>
		///         Возвращает значение открытого идентификатора для объявления DOCTYPE.
		///       </summary>
		/// <returns>
		///         Общий идентификатор для DOCTYPE.
		///          Если общий идентификатор отсутствует <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x00069A56 File Offset: 0x00067C56
		public string PublicId
		{
			get
			{
				return this.publicId;
			}
		}

		/// <summary>
		///         Возвращает значение идентификатора системы для объявления DOCTYPE.
		///       </summary>
		/// <returns>
		///         Идентификатор системы для DOCTYPE.
		///          Если идентификатор системы отсутствует <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x00069A5E File Offset: 0x00067C5E
		public string SystemId
		{
			get
			{
				return this.systemId;
			}
		}

		/// <summary>
		///         Возвращает значение внутреннего подмножества определения DTD типа документа для объявления DOCTYPE.
		///       </summary>
		/// <returns>
		///         Внутреннее подмножество DTD на DOCTYPE.
		///          Если нет встроенного DTD, возвращается String.Empty.
		///       </returns>
		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x00069A66 File Offset: 0x00067C66
		public string InternalSubset
		{
			get
			{
				return this.internalSubset;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060010FC RID: 4348 RVA: 0x00069A6E File Offset: 0x00067C6E
		// (set) Token: 0x060010FD RID: 4349 RVA: 0x00069A76 File Offset: 0x00067C76
		internal bool ParseWithNamespaces
		{
			get
			{
				return this.namespaces;
			}
			set
			{
				this.namespaces = value;
			}
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x060010FE RID: 4350 RVA: 0x00069A7F File Offset: 0x00067C7F
		public override void WriteTo(XmlWriter w)
		{
			w.WriteDocType(this.name, this.publicId, this.systemId, this.internalSubset);
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///          Для <see langword="XmlDocumentType" /> узлов, этот метод не оказывает влияния.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x060010FF RID: 4351 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x00069A9F File Offset: 0x00067C9F
		// (set) Token: 0x06001101 RID: 4353 RVA: 0x00069AA7 File Offset: 0x00067CA7
		internal SchemaInfo DtdSchemaInfo
		{
			get
			{
				return this.schemaInfo;
			}
			set
			{
				this.schemaInfo = value;
			}
		}

		// Token: 0x04001074 RID: 4212
		private string name;

		// Token: 0x04001075 RID: 4213
		private string publicId;

		// Token: 0x04001076 RID: 4214
		private string systemId;

		// Token: 0x04001077 RID: 4215
		private string internalSubset;

		// Token: 0x04001078 RID: 4216
		private bool namespaces;

		// Token: 0x04001079 RID: 4217
		private XmlNamedNodeMap entities;

		// Token: 0x0400107A RID: 4218
		private XmlNamedNodeMap notations;

		// Token: 0x0400107B RID: 4219
		private SchemaInfo schemaInfo;
	}
}
