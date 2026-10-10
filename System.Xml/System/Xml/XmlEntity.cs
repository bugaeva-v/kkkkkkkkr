using System;
using Unity;

namespace System.Xml
{
	/// <summary>
	///         Представляет объявление сущности, такие как &lt;! СУЩНОСТИ... &gt;.
	///       </summary>
	// Token: 0x020001C5 RID: 453
	public class XmlEntity : XmlNode
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x0006A9F4 File Offset: 0x00068BF4
		internal XmlEntity(string name, string strdata, string publicId, string systemId, string notationName, XmlDocument doc) : base(doc)
		{
			this.name = doc.NameTable.Add(name);
			this.publicId = publicId;
			this.systemId = systemId;
			this.notationName = notationName;
			this.unparsedReplacementStr = strdata;
			this.childrenFoliating = false;
		}

		/// <summary>
		///         Создает дубликат этого узла.
		///          Невозможно создать точную копию узлов сущностей.
		///          Вызов этого метода для <see cref="T:System.Xml.XmlEntity" /> создается исключение.
		///       </summary>
		/// <param name="deep">
		///           Значение <see langword="true" /> для рекурсивного клонирования поддерева указанного узла; значение <see langword="false" /> для клонирования только самого узла.
		///         </param>
		/// <returns>
		///         Возвращает копию <see cref="T:System.Xml.XmlNode" /> из которого был вызван метод.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Невозможно создать точную копию узлов сущностей.
		///              Вызов этого метода для <see cref="T:System.Xml.XmlEntity" /> создается исключение.
		///           </exception>
		// Token: 0x0600115C RID: 4444 RVA: 0x0006AA41 File Offset: 0x00068C41
		public override XmlNode CloneNode(bool deep)
		{
			throw new InvalidOperationException(Res.GetString("'Entity' and 'Notation' nodes cannot be cloned."));
		}

		/// <summary>
		///         Возвращает значение, определяющее, доступен ли узел только для чтения.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если узел доступен только для чтения; в противном случае <see langword="false" />.
		///
		///         Поскольку <see langword="XmlEntity" /> узлы доступны только для чтения, это свойство всегда возвращает <see langword="true" />.
		///       </returns>
		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x0600115D RID: 4445 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает имя узла.
		///       </summary>
		/// <returns>
		///         Имя сущности.
		///       </returns>
		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600115E RID: 4446 RVA: 0x0006AA52 File Offset: 0x00068C52
		public override string Name
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает имя узла без префикса пространства имен.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlEntity" /> узлов, это свойство возвращает имя сущности.
		///       </returns>
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0006AA52 File Offset: 0x00068C52
		public override string LocalName
		{
			get
			{
				return this.name;
			}
		}

		/// <summary>
		///         Возвращает последовательно соединенные значения узла и всех его дочерних узлов.
		///       </summary>
		/// <returns>
		///         Последовательно соединенные значения узла и его дочерних узлов.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Попытка задать свойство.
		///           </exception>
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001160 RID: 4448 RVA: 0x0006A286 File Offset: 0x00068486
		// (set) Token: 0x06001161 RID: 4449 RVA: 0x0006AA5A File Offset: 0x00068C5A
		public override string InnerText
		{
			get
			{
				return base.InnerText;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("The 'InnerText' of an 'Entity' node is read-only and cannot be set."));
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001162 RID: 4450 RVA: 0x0001222F File Offset: 0x0001042F
		internal override bool IsContainer
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0006AA6B File Offset: 0x00068C6B
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0006AA95 File Offset: 0x00068C95
		internal override XmlLinkedNode LastNode
		{
			get
			{
				if (this.lastChild == null && !this.childrenFoliating)
				{
					this.childrenFoliating = true;
					new XmlLoader().ExpandEntity(this);
				}
				return this.lastChild;
			}
			set
			{
				this.lastChild = value;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0006AA9E File Offset: 0x00068C9E
		internal override bool IsValidChildType(XmlNodeType type)
		{
			return type == XmlNodeType.Text || type == XmlNodeType.Element || type == XmlNodeType.ProcessingInstruction || type == XmlNodeType.Comment || type == XmlNodeType.CDATA || type == XmlNodeType.Whitespace || type == XmlNodeType.SignificantWhitespace || type == XmlNodeType.EntityReference;
		}

		/// <summary>
		///         Возвращает тип узла.
		///       </summary>
		/// <returns>
		///         Тип узла.
		///          Для <see langword="XmlEntity" /> узлов, значение — XmlNodeType.Entity.
		///       </returns>
		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06001166 RID: 4454 RVA: 0x0006AAC4 File Offset: 0x00068CC4
		public override XmlNodeType NodeType
		{
			get
			{
				return XmlNodeType.Entity;
			}
		}

		/// <summary>
		///         Возвращает значение открытого идентификатора для объявления сущности.
		///       </summary>
		/// <returns>
		///         Общий идентификатор для сущности.
		///          Если общий идентификатор отсутствует <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06001167 RID: 4455 RVA: 0x0006AAC7 File Offset: 0x00068CC7
		public string PublicId
		{
			get
			{
				return this.publicId;
			}
		}

		/// <summary>
		///         Возвращает значение идентификатора системы для объявления сущности.
		///       </summary>
		/// <returns>
		///         Идентификатор системы для сущности.
		///          Если идентификатор системы отсутствует <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06001168 RID: 4456 RVA: 0x0006AACF File Offset: 0x00068CCF
		public string SystemId
		{
			get
			{
				return this.systemId;
			}
		}

		/// <summary>
		///         Возвращает имя дополнительного атрибута NDATA для объявления сущности.
		///       </summary>
		/// <returns>
		///         Имя атрибута NDATA.
		///          Если атрибут NDATA отсутствует <see langword="null" /> возвращается.
		///       </returns>
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0006AAD7 File Offset: 0x00068CD7
		public string NotationName
		{
			get
			{
				return this.notationName;
			}
		}

		/// <summary>
		///         Получает разметку, представляющую данный узел и все его дочерние узлы.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlEntity" /> узлов, возвращается String.Empty.
		///       </returns>
		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x0001E51E File Offset: 0x0001C71E
		public override string OuterXml
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		///         Получает разметку, отражающую дочерние узлы данного узла.
		///       </summary>
		/// <returns>
		///         Для <see langword="XmlEntity" /> узлов, возвращается String.Empty.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Попытка задать свойство.
		///           </exception>
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0001E51E File Offset: 0x0001C71E
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0006AADF File Offset: 0x00068CDF
		public override string InnerXml
		{
			get
			{
				return string.Empty;
			}
			set
			{
				throw new InvalidOperationException(Res.GetString("Cannot set the 'InnerXml' for the current node because it is either read-only or cannot have children."));
			}
		}

		/// <summary>
		///         Сохраняет узел в указанном <see cref="T:System.Xml.XmlWriter" />.
		///          Для <see langword="XmlEntity" /> узлов, этот метод не оказывает влияния.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x0600116D RID: 4461 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteTo(XmlWriter w)
		{
		}

		/// <summary>
		///         Сохраняет все дочерние узлы узла в заданном <see cref="T:System.Xml.XmlWriter" />.
		///          Для <see langword="XmlEntity" /> узлов, этот метод не оказывает влияния.
		///       </summary>
		/// <param name="w">
		///           Объект <see langword="XmlWriter" />, в котором необходимо выполнить сохранение.
		///         </param>
		// Token: 0x0600116E RID: 4462 RVA: 0x0000B528 File Offset: 0x00009728
		public override void WriteContentTo(XmlWriter w)
		{
		}

		/// <summary>
		///         Получает базовый универсальный код ресурса (URI) текущего узла.
		///       </summary>
		/// <returns>
		///         Расположение, из которого загружен узел.
		///       </returns>
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0006AAF0 File Offset: 0x00068CF0
		public override string BaseURI
		{
			get
			{
				return this.baseURI;
			}
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0006AAF8 File Offset: 0x00068CF8
		internal void SetBaseURI(string inBaseURI)
		{
			this.baseURI = inBaseURI;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00067344 File Offset: 0x00065544
		internal XmlEntity()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x04001091 RID: 4241
		private string publicId;

		// Token: 0x04001092 RID: 4242
		private string systemId;

		// Token: 0x04001093 RID: 4243
		private string notationName;

		// Token: 0x04001094 RID: 4244
		private string name;

		// Token: 0x04001095 RID: 4245
		private string unparsedReplacementStr;

		// Token: 0x04001096 RID: 4246
		private string baseURI;

		// Token: 0x04001097 RID: 4247
		private XmlLinkedNode lastChild;

		// Token: 0x04001098 RID: 4248
		private bool childrenFoliating;
	}
}
