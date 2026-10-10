using System;
using System.Collections.Generic;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>
	///         Представляет средство чтения, обеспечивающее быстрый некэшированный прямой доступ к XML-данным в <see cref="T:System.Xml.XmlNode" />.
	///       </summary>
	// Token: 0x020001D7 RID: 471
	public class XmlNodeReader : XmlReader, IXmlNamespaceResolver
	{
		/// <summary>
		///         Создает экземпляр <see langword="XmlNodeReader" /> класса с помощью указанного <see cref="T:System.Xml.XmlNode" />.
		///       </summary>
		/// <param name="node">
		///           <see langword="XmlNode" /> Требуется прочитать.
		///         </param>
		// Token: 0x06001282 RID: 4738 RVA: 0x0006FAD8 File Offset: 0x0006DCD8
		public XmlNodeReader(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			this.readerNav = new XmlNodeReaderNavigator(node);
			this.curDepth = 0;
			this.readState = ReadState.Initial;
			this.fEOF = false;
			this.nodeType = XmlNodeType.None;
			this.bResolveEntity = false;
			this.bStartFromDocument = false;
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0006FB2F File Offset: 0x0006DD2F
		internal bool IsInReadingStates()
		{
			return this.readState == ReadState.Interactive;
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlNodeType" />, предоставляющее тип текущего узла.
		///       </returns>
		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x0006FB3A File Offset: 0x0006DD3A
		public override XmlNodeType NodeType
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return XmlNodeType.None;
				}
				return this.nodeType;
			}
		}

		/// <summary>
		///         Возвращает полное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Полное имя текущего узла.
		///          Например, <see langword="Name" /> имеет значение <see langword="bk:book" /> для элемента &lt;bk:book&gt;.
		///
		///         Возвращаемое имя зависит от значения свойства <see cref="P:System.Xml.XmlNodeReader.NodeType" /> узла.
		///          Значения возвращаются для представленных ниже типов узлов.
		///          Для других типов узлов возвращается пустая строка.
		///
		///                 Тип узла 
		///
		///                 Имя 
		///
		///                 <see langword="Attribute" />
		///
		///                 Имя атрибута.
		///
		///                 <see langword="DocumentType" />
		///
		///                 Имя типа документа.
		///
		///                 <see langword="Element" />
		///
		///                 Имя тега.
		///
		///                 <see langword="EntityReference" />
		///
		///                 Имя сущности, на которую существует ссылка.
		///
		///                 <see langword="ProcessingInstruction" />
		///
		///                 Цель инструкции по обработке.
		///
		///                 <see langword="XmlDeclaration" />
		///
		///                 Символьная строка <see langword="xml" />.
		///               </returns>
		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0006FB4C File Offset: 0x0006DD4C
		public override string Name
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Имя текущего узла с удаленным префиксом.
		///          Например, <see langword="LocalName" /> имеет значение <see langword="book" /> для элемента &lt;bk:book&gt;.
		///
		///         Для безымянных типов узлов (например, <see langword="Text" />, <see langword="Comment" /> и т. д.) данное свойство возвращает String.Empty.
		///       </returns>
		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x0006FB67 File Offset: 0x0006DD67
		public override string LocalName
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.LocalName;
			}
		}

		/// <summary>
		///         Возвращает URI пространства имен (определенное в спецификации W3C Namespace) узла, на который позиционировано средство чтения.
		///       </summary>
		/// <returns>
		///         URI пространства имен текущего узла; в противном случае — пустая строка.
		///       </returns>
		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001287 RID: 4743 RVA: 0x0006FB82 File Offset: 0x0006DD82
		public override string NamespaceURI
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.NamespaceURI;
			}
		}

		/// <summary>
		///         Возвращает префикс пространства имен, связанный с текущим узлом.
		///       </summary>
		/// <returns>
		///         Префикс пространства имен, связанный с текущим узлом.
		///       </returns>
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x0006FB9D File Offset: 0x0006DD9D
		public override string Prefix
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Prefix;
			}
		}

		/// <summary>
		///         Возвращает значение, указывающее, является ли текущий узел может иметь <see cref="P:System.Xml.XmlNodeReader.Value" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если узел, на котором расположено средство чтения, может иметь значение <see langword="Value" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001289 RID: 4745 RVA: 0x0006FBB8 File Offset: 0x0006DDB8
		public override bool HasValue
		{
			get
			{
				return this.IsInReadingStates() && this.readerNav.HasValue;
			}
		}

		/// <summary>
		///         Возвращает текстовое значение текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращаемое значение зависит от значения свойства <see cref="P:System.Xml.XmlNodeReader.NodeType" /> узла.
		///          В следующей таблице представлен список возвращаемых типов узлов со значениями.
		///          Другие типы узлов возвращают String.Empty.
		///
		///                 Тип узла 
		///
		///                 Значение 
		///
		///                 <see langword="Attribute" />
		///
		///                 Значение атрибута.
		///
		///                 <see langword="CDATA" />
		///
		///                 Содержимое раздела CDATA.
		///
		///                 <see langword="Comment" />
		///
		///                 Содержимое комментария.
		///
		///                 <see langword="DocumentType" />
		///
		///                 Внутреннее подмножество.
		///
		///                 <see langword="ProcessingInstruction" />
		///
		///                 Все содержимое, за исключением цели.
		///
		///                 <see langword="SignificantWhitespace" />
		///
		///                 Пробелы между разметкой в модели смешанного содержимого.
		///
		///                 <see langword="Text" />
		///
		///                 Содержимое текстового узла.
		///
		///                 <see langword="Whitespace" />
		///
		///                 Пробелы между разметкой.
		///
		///                 <see langword="XmlDeclaration" />
		///
		///                 Содержимое декларации.
		///               </returns>
		// Token: 0x1700036B RID: 875
		// (get) Token: 0x0600128A RID: 4746 RVA: 0x0006FBCF File Offset: 0x0006DDCF
		public override string Value
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.Value;
			}
		}

		/// <summary>
		///         Возвращает глубину текущего узла в XML-документе.
		///       </summary>
		/// <returns>
		///         Глубина текущего узла в XML-документе.
		///       </returns>
		// Token: 0x1700036C RID: 876
		// (get) Token: 0x0600128B RID: 4747 RVA: 0x0006FBEA File Offset: 0x0006DDEA
		public override int Depth
		{
			get
			{
				return this.curDepth;
			}
		}

		/// <summary>
		///         Возвращает базовый URI текущего узла.
		///       </summary>
		/// <returns>
		///         Базовый URI текущего узла.
		///       </returns>
		// Token: 0x1700036D RID: 877
		// (get) Token: 0x0600128C RID: 4748 RVA: 0x0006FBF2 File Offset: 0x0006DDF2
		public override string BaseURI
		{
			get
			{
				return this.readerNav.BaseURI;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, способно ли данное средство чтения выполнять синтаксический анализ и разрешение сущностей.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения позволяет анализировать и разрешать сущности; в противном случае — <see langword="false" />.
		///          Параметр <see langword="XmlNodeReader" /> всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x1700036E RID: 878
		// (get) Token: 0x0600128D RID: 4749 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли текущий узел пустым элементом (например, &lt;MyElement/&gt;).
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если текущий узел является элементом (<see cref="P:System.Xml.XmlNodeReader.NodeType" /> равняется <see langword="XmlNodeType.Element" />) и заканчивается /&gt;; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x0600128E RID: 4750 RVA: 0x0006FBFF File Offset: 0x0006DDFF
		public override bool IsEmptyElement
		{
			get
			{
				return this.IsInReadingStates() && this.readerNav.IsEmptyElement;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли текущий узел атрибутом, созданным из значения по умолчанию, определенного в DTD или схеме.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел является атрибутом, значение которого было создано из значения по умолчанию, определенного в DTD или схеме; значение <see langword="false" />, если значение атрибута было задано явно.
		///       </returns>
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600128F RID: 4751 RVA: 0x0006FC16 File Offset: 0x0006DE16
		public override bool IsDefault
		{
			get
			{
				return this.IsInReadingStates() && this.readerNav.IsDefault;
			}
		}

		/// <summary>
		///         Возвращает текущую область действия <see langword="xml:space" />.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlSpace" />.
		///          Если область действия <see langword="xml:space" /> отсутствует, данное свойство принимает значение <see langword="XmlSpace.None" />.
		///       </returns>
		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001290 RID: 4752 RVA: 0x0006FC2D File Offset: 0x0006DE2D
		public override XmlSpace XmlSpace
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return XmlSpace.None;
				}
				return this.readerNav.XmlSpace;
			}
		}

		/// <summary>
		///         Возвращает текущую область действия <see langword="xml:lang" />.
		///       </summary>
		/// <returns>
		///         Текущая область действия <see langword="xml:lang" />.
		///       </returns>
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001291 RID: 4753 RVA: 0x0006FC44 File Offset: 0x0006DE44
		public override string XmlLang
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return string.Empty;
				}
				return this.readerNav.XmlLang;
			}
		}

		/// <summary>
		///         Возвращает сведения схемы, которые были назначены текущему узлу.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> Объект, содержащий сведения о схеме для текущего узла.
		///       </returns>
		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x0006FC5F File Offset: 0x0006DE5F
		public override IXmlSchemaInfo SchemaInfo
		{
			get
			{
				if (!this.IsInReadingStates())
				{
					return null;
				}
				return this.readerNav.SchemaInfo;
			}
		}

		/// <summary>
		///         Возвращает количество атрибутов текущего узла.
		///       </summary>
		/// <returns>
		///         Количество атрибутов текущего узла.
		///          в том числе атрибутов, используемых по умолчанию.
		///       </returns>
		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x0006FC76 File Offset: 0x0006DE76
		public override int AttributeCount
		{
			get
			{
				if (!this.IsInReadingStates() || this.nodeType == XmlNodeType.EndElement)
				{
					return 0;
				}
				return this.readerNav.AttributeCount;
			}
		}

		/// <summary>
		///         Возвращает значение атрибута с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден, возвращается значение <see langword="null" />.
		///       </returns>
		// Token: 0x06001294 RID: 4756 RVA: 0x0006FC97 File Offset: 0x0006DE97
		public override string GetAttribute(string name)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			return this.readerNav.GetAttribute(name);
		}

		/// <summary>
		///         Возвращает значение атрибута с указанным локальным именем и универсальным кодом ресурса (URI) пространства имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден, возвращается значение <see langword="null" />.
		///       </returns>
		// Token: 0x06001295 RID: 4757 RVA: 0x0006FCB0 File Offset: 0x0006DEB0
		public override string GetAttribute(string name, string namespaceURI)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			string ns = (namespaceURI == null) ? string.Empty : namespaceURI;
			return this.readerNav.GetAttribute(name, ns);
		}

		/// <summary>
		///         Возвращает значение атрибута по заданному индексу.
		///       </summary>
		/// <param name="attributeIndex">
		///           Индекс атрибута.
		///            Индексация начинается с нуля.
		///            (Индекс первого атрибута равен нулю.)
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="i" /> Параметр меньше 0 или больше или равно <see cref="P:System.Xml.XmlNodeReader.AttributeCount" />.
		///           </exception>
		// Token: 0x06001296 RID: 4758 RVA: 0x0006FCE0 File Offset: 0x0006DEE0
		public override string GetAttribute(int attributeIndex)
		{
			if (!this.IsInReadingStates())
			{
				throw new ArgumentOutOfRangeException("attributeIndex");
			}
			return this.readerNav.GetAttribute(attributeIndex);
		}

		/// <summary>
		///         Переходит к атрибуту с указанным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут найден; в противном случае — <see langword="false" />.
		///          Если значение <see langword="false" />, позиция средства чтения не изменяется.
		///       </returns>
		// Token: 0x06001297 RID: 4759 RVA: 0x0006FD04 File Offset: 0x0006DF04
		public override bool MoveToAttribute(string name)
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			if (this.readerNav.MoveToAttribute(name))
			{
				this.curDepth++;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>
		///         Переходит к атрибуту с указанным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="name">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут найден; в противном случае — <see langword="false" />.
		///          Если значение <see langword="false" />, позиция средства чтения не изменяется.
		///       </returns>
		// Token: 0x06001298 RID: 4760 RVA: 0x0006FD84 File Offset: 0x0006DF84
		public override bool MoveToAttribute(string name, string namespaceURI)
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			string namespaceURI2 = (namespaceURI == null) ? string.Empty : namespaceURI;
			if (this.readerNav.MoveToAttribute(name, namespaceURI2))
			{
				this.curDepth++;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>
		///         Переходит к атрибуту с указанным индексом.
		///       </summary>
		/// <param name="attributeIndex">
		///           Индекс атрибута.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="i" /> Параметр меньше 0 или больше или равно <see cref="P:System.Xml.XmlReader.AttributeCount" />.
		///           </exception>
		// Token: 0x06001299 RID: 4761 RVA: 0x0006FE10 File Offset: 0x0006E010
		public override void MoveToAttribute(int attributeIndex)
		{
			if (!this.IsInReadingStates())
			{
				throw new ArgumentOutOfRangeException("attributeIndex");
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			try
			{
				if (this.AttributeCount <= 0)
				{
					throw new ArgumentOutOfRangeException("attributeIndex");
				}
				this.readerNav.MoveToAttribute(attributeIndex);
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
			}
			catch
			{
				this.readerNav.RollBackMove(ref this.curDepth);
				throw;
			}
			this.curDepth++;
			this.nodeType = this.readerNav.NodeType;
		}

		/// <summary>
		///         Переходит к первому атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут существует (средство чтения перемещается к первому атрибуту); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		// Token: 0x0600129A RID: 4762 RVA: 0x0006FEBC File Offset: 0x0006E0BC
		public override bool MoveToFirstAttribute()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
			if (this.AttributeCount > 0)
			{
				this.readerNav.MoveToAttribute(0);
				this.curDepth++;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>
		///         Переходит к следующему атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствует следующий атрибут; значение <see langword="false" />, если другие атрибуты отсутствуют.
		///       </returns>
		// Token: 0x0600129B RID: 4763 RVA: 0x0006FF40 File Offset: 0x0006E140
		public override bool MoveToNextAttribute()
		{
			if (!this.IsInReadingStates() || this.nodeType == XmlNodeType.EndElement)
			{
				return false;
			}
			this.readerNav.LogMove(this.curDepth);
			this.readerNav.ResetToAttribute(ref this.curDepth);
			if (this.readerNav.MoveToNextAttribute(ref this.curDepth))
			{
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>
		///         Переходит к элементу, содержащему текущий узел атрибута.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения находится на атрибуте (средство чтения перемещается к элементу с этим атрибутом); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		// Token: 0x0600129C RID: 4764 RVA: 0x0006FFCC File Offset: 0x0006E1CC
		public override bool MoveToElement()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			this.readerNav.LogMove(this.curDepth);
			this.readerNav.ResetToAttribute(ref this.curDepth);
			if (this.readerNav.MoveToElement())
			{
				this.curDepth--;
				this.nodeType = this.readerNav.NodeType;
				if (this.bInReadBinary)
				{
					this.FinishReadBinary();
				}
				return true;
			}
			this.readerNav.RollBackMove(ref this.curDepth);
			return false;
		}

		/// <summary>
		///         Считывает следующий узел из потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если чтение прошло успешно; значение <see langword="false" />, если отсутствуют узлы для чтения.
		///       </returns>
		// Token: 0x0600129D RID: 4765 RVA: 0x00070053 File Offset: 0x0006E253
		public override bool Read()
		{
			return this.Read(false);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0007005C File Offset: 0x0006E25C
		private bool Read(bool fSkipChildren)
		{
			if (this.fEOF)
			{
				return false;
			}
			if (this.readState == ReadState.Initial)
			{
				if (this.readerNav.NodeType == XmlNodeType.Document || this.readerNav.NodeType == XmlNodeType.DocumentFragment)
				{
					this.bStartFromDocument = true;
					if (!this.ReadNextNode(fSkipChildren))
					{
						this.readState = ReadState.Error;
						return false;
					}
				}
				this.ReSetReadingMarks();
				this.readState = ReadState.Interactive;
				this.nodeType = this.readerNav.NodeType;
				this.curDepth = 0;
				return true;
			}
			if (this.bInReadBinary)
			{
				this.FinishReadBinary();
			}
			if (this.readerNav.CreatedOnAttribute)
			{
				return false;
			}
			this.ReSetReadingMarks();
			if (this.ReadNextNode(fSkipChildren))
			{
				return true;
			}
			if (this.readState == ReadState.Initial || this.readState == ReadState.Interactive)
			{
				this.readState = ReadState.Error;
			}
			if (this.readState == ReadState.EndOfFile)
			{
				this.nodeType = XmlNodeType.None;
			}
			return false;
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00070130 File Offset: 0x0006E330
		private bool ReadNextNode(bool fSkipChildren)
		{
			if (this.readState != ReadState.Interactive && this.readState != ReadState.Initial)
			{
				this.nodeType = XmlNodeType.None;
				return false;
			}
			bool flag = !fSkipChildren;
			XmlNodeType xmlNodeType = this.readerNav.NodeType;
			if (flag && this.nodeType != XmlNodeType.EndElement && this.nodeType != XmlNodeType.EndEntity && (xmlNodeType == XmlNodeType.Element || (xmlNodeType == XmlNodeType.EntityReference && this.bResolveEntity) || ((this.readerNav.NodeType == XmlNodeType.Document || this.readerNav.NodeType == XmlNodeType.DocumentFragment) && this.readState == ReadState.Initial)))
			{
				if (this.readerNav.MoveToFirstChild())
				{
					this.nodeType = this.readerNav.NodeType;
					this.curDepth++;
					if (this.bResolveEntity)
					{
						this.bResolveEntity = false;
					}
					return true;
				}
				if (this.readerNav.NodeType == XmlNodeType.Element && !this.readerNav.IsEmptyElement)
				{
					this.nodeType = XmlNodeType.EndElement;
					return true;
				}
				if (this.readerNav.NodeType == XmlNodeType.EntityReference && this.bResolveEntity)
				{
					this.bResolveEntity = false;
					this.nodeType = XmlNodeType.EndEntity;
					return true;
				}
				return this.ReadForward(fSkipChildren);
			}
			else
			{
				if (this.readerNav.NodeType == XmlNodeType.EntityReference && this.bResolveEntity)
				{
					if (this.readerNav.MoveToFirstChild())
					{
						this.nodeType = this.readerNav.NodeType;
						this.curDepth++;
					}
					else
					{
						this.nodeType = XmlNodeType.EndEntity;
					}
					this.bResolveEntity = false;
					return true;
				}
				return this.ReadForward(fSkipChildren);
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000702AF File Offset: 0x0006E4AF
		private void SetEndOfFile()
		{
			this.fEOF = true;
			this.readState = ReadState.EndOfFile;
			this.nodeType = XmlNodeType.None;
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000702C6 File Offset: 0x0006E4C6
		private bool ReadAtZeroLevel(bool fSkipChildren)
		{
			if (!fSkipChildren && this.nodeType != XmlNodeType.EndElement && this.readerNav.NodeType == XmlNodeType.Element && !this.readerNav.IsEmptyElement)
			{
				this.nodeType = XmlNodeType.EndElement;
				return true;
			}
			this.SetEndOfFile();
			return false;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00070304 File Offset: 0x0006E504
		private bool ReadForward(bool fSkipChildren)
		{
			if (this.readState == ReadState.Error)
			{
				return false;
			}
			if (!this.bStartFromDocument && this.curDepth == 0)
			{
				return this.ReadAtZeroLevel(fSkipChildren);
			}
			if (this.readerNav.MoveToNext())
			{
				this.nodeType = this.readerNav.NodeType;
				return true;
			}
			if (this.curDepth == 0)
			{
				return this.ReadAtZeroLevel(fSkipChildren);
			}
			if (!this.readerNav.MoveToParent())
			{
				return false;
			}
			if (this.readerNav.NodeType == XmlNodeType.Element)
			{
				this.curDepth--;
				this.nodeType = XmlNodeType.EndElement;
				return true;
			}
			if (this.readerNav.NodeType == XmlNodeType.EntityReference)
			{
				this.curDepth--;
				this.nodeType = XmlNodeType.EndEntity;
				return true;
			}
			return true;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x000703C0 File Offset: 0x0006E5C0
		private void ReSetReadingMarks()
		{
			this.readerNav.ResetMove(ref this.curDepth, ref this.nodeType);
		}

		/// <summary>
		///         Возвращает значение, определяющее, позиционировано ли средство чтения в конец потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения установлено в конец потока; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x000703D9 File Offset: 0x0006E5D9
		public override bool EOF
		{
			get
			{
				return this.readState != ReadState.Closed && this.fEOF;
			}
		}

		/// <summary>
		///         Изменяет значение свойства <see cref="P:System.Xml.XmlNodeReader.ReadState" /> на <see langword="Closed" />.
		///       </summary>
		// Token: 0x060012A5 RID: 4773 RVA: 0x000703EC File Offset: 0x0006E5EC
		public override void Close()
		{
			this.readState = ReadState.Closed;
		}

		/// <summary>
		///         Возвращает состояние средства чтения.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.ReadState" />.
		///       </returns>
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x000703F5 File Offset: 0x0006E5F5
		public override ReadState ReadState
		{
			get
			{
				return this.readState;
			}
		}

		/// <summary>
		///         Пропускает дочерний узел текущего узла.
		///       </summary>
		// Token: 0x060012A7 RID: 4775 RVA: 0x000703FD File Offset: 0x0006E5FD
		public override void Skip()
		{
			this.Read(true);
		}

		/// <summary>
		///         Считывает содержимое элемента или текстового узла в виде строки.
		///       </summary>
		/// <returns>
		///         Содержимое элемента или текстового узла, который может быть узлом CDATA, Text и т. д.
		///          Если средство чтения позиционировано не на элемент или текстовый узел, а также если отсутствует возвращаемый текст, это может быть пустая строка.
		///
		///         <see langword="Note:" /> Текстовым узлом может быть элемент или текстовой узел атрибута.
		///       </returns>
		// Token: 0x060012A8 RID: 4776 RVA: 0x00070407 File Offset: 0x0006E607
		public override string ReadString()
		{
			if (this.NodeType == XmlNodeType.EntityReference && this.bResolveEntity && !this.Read())
			{
				throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
			}
			return base.ReadString();
		}

		/// <summary>
		///         Возвращает значение, показывающее, имеются ли атрибуты у текущего узла.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел содержит атрибуты; в противном случае — значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060012A9 RID: 4777 RVA: 0x0001F7BF File Offset: 0x0001D9BF
		public override bool HasAttributes
		{
			get
			{
				return this.AttributeCount > 0;
			}
		}

		/// <summary>
		///         Возвращает класс <see cref="T:System.Xml.XmlNameTable" />, связанный с данной реализацией.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNameTable" />, позволяющий получать в узле разделенную версию строки.
		///       </returns>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x060012AA RID: 4778 RVA: 0x00070438 File Offset: 0x0006E638
		public override XmlNameTable NameTable
		{
			get
			{
				return this.readerNav.NameTable;
			}
		}

		/// <summary>
		///         Разрешает префикс пространства имен в области видимости текущего элемента.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, для которого требуется разрешить URI пространства имен.
		///            Чтобы сопоставить пространство имен по умолчанию, необходимо передать пустую строку.
		///            Эту строку не следует атомизировать.
		///         </param>
		/// <returns>
		///         URI пространства имен, которое отображает префикс, или значение <see langword="null" />, если соответствующий префикс не найден.
		///       </returns>
		// Token: 0x060012AB RID: 4779 RVA: 0x00070448 File Offset: 0x0006E648
		public override string LookupNamespace(string prefix)
		{
			if (!this.IsInReadingStates())
			{
				return null;
			}
			string text = this.readerNav.LookupNamespace(prefix);
			if (text != null && text.Length == 0)
			{
				return null;
			}
			return text;
		}

		/// <summary>
		///         Разрешает ссылки на сущности для узлов <see langword="EntityReference" />.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Средство чтения не позиционировано на <see langword="EntityReference" /> узел.
		///           </exception>
		// Token: 0x060012AC RID: 4780 RVA: 0x0007047A File Offset: 0x0006E67A
		public override void ResolveEntity()
		{
			if (!this.IsInReadingStates() || this.nodeType != XmlNodeType.EntityReference)
			{
				throw new InvalidOperationException(Res.GetString("The node is not an expandable 'EntityReference' node."));
			}
			this.bResolveEntity = true;
		}

		/// <summary>
		///         Разбирает значение атрибута в один или несколько узлов <see langword="Text" />, <see langword="EntityReference" /> или <see langword="EndEntity" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствуют возвращаемые узлы.
		///
		///         Значение <see langword="false" />, если средство чтения не расположено на узле атрибута при первом вызове или все значения атрибута считаны.
		///
		///         Пустой атрибут (например, misc="") возвращает значение <see langword="true" /> с отдельным узлом, имеющим значение String.Empty.
		///       </returns>
		// Token: 0x060012AD RID: 4781 RVA: 0x000704A4 File Offset: 0x0006E6A4
		public override bool ReadAttributeValue()
		{
			if (!this.IsInReadingStates())
			{
				return false;
			}
			if (this.readerNav.ReadAttributeValue(ref this.curDepth, ref this.bResolveEntity, ref this.nodeType))
			{
				this.bInReadBinary = false;
				return true;
			}
			return false;
		}

		/// <summary>
		///         Получает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlNodeReader" /> методы чтения двоичного содержимого.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если реализуются методы чтения двоичного содержимого; в противном случае — <see langword="false" />.
		///          Класс <see cref="T:System.Xml.XmlNodeReader" /> всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool CanReadBinaryContent
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Считывает содержимое и возвращает раскодированные двоичные байты Base64.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, в который копируется полученный текст.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, с которого следует начать копировать результат.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер байтов.
		///            Этот метод возвращает фактическое количество скопированных байтов.
		///         </param>
		/// <returns>
		///         Количество байтов, записанных в буфер.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="M:System.Xml.XmlNodeReader.ReadContentAsBase64(System.Byte[],System.Int32,System.Int32)" /> не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		// Token: 0x060012AF RID: 4783 RVA: 0x000704DC File Offset: 0x0006E6DC
		public override int ReadContentAsBase64(byte[] buffer, int index, int count)
		{
			if (this.readState != ReadState.Interactive)
			{
				return 0;
			}
			if (!this.bInReadBinary)
			{
				this.readBinaryHelper = ReadContentAsBinaryHelper.CreateOrReset(this.readBinaryHelper, this);
			}
			this.bInReadBinary = false;
			int result = this.readBinaryHelper.ReadContentAsBase64(buffer, index, count);
			this.bInReadBinary = true;
			return result;
		}

		/// <summary>
		///         Считывает данные и возвращает двоичные байты, декодированные из кодировки BinHex.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, в который копируется полученный текст.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, с которого следует начать копировать результат.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер байтов.
		///            Этот метод возвращает фактическое количество скопированных байтов.
		///         </param>
		/// <returns>
		///         Количество байтов, записанных в буфер.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="M:System.Xml.XmlNodeReader.ReadContentAsBinHex(System.Byte[],System.Int32,System.Int32)" />  не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		// Token: 0x060012B0 RID: 4784 RVA: 0x0007052C File Offset: 0x0006E72C
		public override int ReadContentAsBinHex(byte[] buffer, int index, int count)
		{
			if (this.readState != ReadState.Interactive)
			{
				return 0;
			}
			if (!this.bInReadBinary)
			{
				this.readBinaryHelper = ReadContentAsBinaryHelper.CreateOrReset(this.readBinaryHelper, this);
			}
			this.bInReadBinary = false;
			int result = this.readBinaryHelper.ReadContentAsBinHex(buffer, index, count);
			this.bInReadBinary = true;
			return result;
		}

		/// <summary>
		///         Считывает элемент и декодирует его из кодировки Base64.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, в который копируется полученный текст.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, с которого следует начать копировать результат.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер байтов.
		///            Этот метод возвращает фактическое количество скопированных байтов.
		///         </param>
		/// <returns>
		///         Количество байтов, записанных в буфер.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел не является узлом элемента.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		// Token: 0x060012B1 RID: 4785 RVA: 0x0007057C File Offset: 0x0006E77C
		public override int ReadElementContentAsBase64(byte[] buffer, int index, int count)
		{
			if (this.readState != ReadState.Interactive)
			{
				return 0;
			}
			if (!this.bInReadBinary)
			{
				this.readBinaryHelper = ReadContentAsBinaryHelper.CreateOrReset(this.readBinaryHelper, this);
			}
			this.bInReadBinary = false;
			int result = this.readBinaryHelper.ReadElementContentAsBase64(buffer, index, count);
			this.bInReadBinary = true;
			return result;
		}

		/// <summary>
		///         Считывает элемент и декодирует его из кодировки BinHex.
		///       </summary>
		/// <param name="buffer">
		///           Буфер, в который копируется полученный текст.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, с которого следует начать копировать результат.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер байтов.
		///            Этот метод возвращает фактическое количество скопированных байтов.
		///         </param>
		/// <returns>
		///         Количество байтов, записанных в буфер.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел не является узлом элемента.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		// Token: 0x060012B2 RID: 4786 RVA: 0x000705CC File Offset: 0x0006E7CC
		public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count)
		{
			if (this.readState != ReadState.Interactive)
			{
				return 0;
			}
			if (!this.bInReadBinary)
			{
				this.readBinaryHelper = ReadContentAsBinaryHelper.CreateOrReset(this.readBinaryHelper, this);
			}
			this.bInReadBinary = false;
			int result = this.readBinaryHelper.ReadElementContentAsBinHex(buffer, index, count);
			this.bInReadBinary = true;
			return result;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0007061A File Offset: 0x0006E81A
		private void FinishReadBinary()
		{
			this.bInReadBinary = false;
			this.readBinaryHelper.Finish();
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.
		///       </summary>
		/// <param name="scope">
		///           Объект <see cref="T:System.Xml.XmlNamespaceScope" />.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Collections.IDictionary" /> Объект, который содержит пространства имен, которые находятся в области действия.
		///       </returns>
		// Token: 0x060012B4 RID: 4788 RVA: 0x0007062E File Offset: 0x0006E82E
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.readerNav.GetNamespacesInScope(scope);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.
		///       </summary>
		/// <param name="namespaceName">
		///           <see cref="T:System.String" /> Объект, определяющий пространство имен.
		///         </param>
		/// <returns>
		///         <see cref="T:System.String" /> Объект, содержащий префикс пространства имен.
		///       </returns>
		// Token: 0x060012B5 RID: 4789 RVA: 0x0007063C File Offset: 0x0006E83C
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.readerNav.LookupPrefix(namespaceName);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.
		///       </summary>
		/// <param name="prefix">
		///           <see cref="T:System.String" /> содержащая префикс пространства имен.
		///         </param>
		/// <returns>
		///         <see cref="T:System.String" /> содержащая имя пространства имен.
		///       </returns>
		// Token: 0x060012B6 RID: 4790 RVA: 0x0007064C File Offset: 0x0006E84C
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			if (!this.IsInReadingStates())
			{
				return this.readerNav.DefaultLookupNamespace(prefix);
			}
			string text = this.readerNav.LookupNamespace(prefix);
			if (text != null)
			{
				text = this.readerNav.NameTable.Add(text);
			}
			return text;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00070691 File Offset: 0x0006E891
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.readerNav.Document.DtdSchemaInfo;
			}
		}

		// Token: 0x040010D7 RID: 4311
		private XmlNodeReaderNavigator readerNav;

		// Token: 0x040010D8 RID: 4312
		private XmlNodeType nodeType;

		// Token: 0x040010D9 RID: 4313
		private int curDepth;

		// Token: 0x040010DA RID: 4314
		private ReadState readState;

		// Token: 0x040010DB RID: 4315
		private bool fEOF;

		// Token: 0x040010DC RID: 4316
		private bool bResolveEntity;

		// Token: 0x040010DD RID: 4317
		private bool bStartFromDocument;

		// Token: 0x040010DE RID: 4318
		private bool bInReadBinary;

		// Token: 0x040010DF RID: 4319
		private ReadContentAsBinaryHelper readBinaryHelper;
	}
}
