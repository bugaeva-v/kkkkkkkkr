using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет средство чтения, обеспечивающее быстрый прямой доступ (без кэширования) к данным XML.
	///
	///         Просмотреть исходный код .NET Framework для этого типа Reference Source.
	///       </summary>
	// Token: 0x0200009B RID: 155
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XmlReader : IDisposable
	{
		/// <summary>
		///         Получает объект <see cref="T:System.Xml.XmlReaderSettings" />, используемый для создания данного экземпляра <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XmlReaderSettings" /> Объект, используемый для создания этого экземпляра средства чтения.
		///          Если средство чтения не было создано с помощью <see cref="Overload:System.Xml.XmlReader.Create" /> метода, это свойство возвращает <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001DA42 File Offset: 0x0001BC42
		public virtual XmlReaderSettings Settings
		{
			get
			{
				return null;
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления, задающее тип текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060005CA RID: 1482
		public abstract XmlNodeType NodeType { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает полное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Полное имя текущего узла.
		///          Например, <see langword="Name" /> имеет значение <see langword="bk:book" /> для элемента &lt;bk:book&gt;.
		///
		///         Возвращаемое имя зависит от значения свойства <see cref="P:System.Xml.XmlReader.NodeType" /> узла.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001E4D6 File Offset: 0x0001C6D6
		public virtual string Name
		{
			get
			{
				if (this.Prefix.Length == 0)
				{
					return this.LocalName;
				}
				return this.NameTable.Add(this.Prefix + ":" + this.LocalName);
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает локальное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Имя текущего узла с удаленным префиксом.
		///          Например, <see langword="LocalName" /> имеет значение <see langword="book" /> для элемента &lt;bk:book&gt;.
		///
		///         Для безымянных типов узлов (например, <see langword="Text" />, <see langword="Comment" /> и т. д.) данное свойство возвращает <see langword="String.Empty" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060005CC RID: 1484
		public abstract string LocalName { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает URI пространства имен (определенное в спецификации W3C Namespace) узла, на котором расположено средство чтения.
		///       </summary>
		/// <returns>
		///         URI пространства имен текущего узла; в противном случае — пустая строка.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060005CD RID: 1485
		public abstract string NamespaceURI { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает префикс пространства имен, связанный с текущим узлом.
		///       </summary>
		/// <returns>
		///         Префикс пространства имен, связанный с текущим узлом.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060005CE RID: 1486
		public abstract string Prefix { get; }

		/// <summary>
		///         При переопределении в производном классе получает значение, указывающее, является ли текущий узел может иметь <see cref="P:System.Xml.XmlReader.Value" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если узел, на котором расположено средство чтения, может иметь значение <see langword="Value" />; в противном случае — <see langword="false" />.
		///          Если <see langword="false" />, узел имеет значение <see langword="String.Empty" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001E50D File Offset: 0x0001C70D
		public virtual bool HasValue
		{
			get
			{
				return XmlReader.HasValueInternal(this.NodeType);
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает текстовое значение текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращаемое значение зависит от значения свойства <see cref="P:System.Xml.XmlReader.NodeType" /> узла.
		///          В следующей таблице представлен список возвращаемых типов узлов со значениями.
		///          Все прочие типы узлов возвращают значение <see langword="String.Empty" />.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060005D0 RID: 1488
		public abstract string Value { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает глубину текущего узла в XML-документе.
		///       </summary>
		/// <returns>
		///         Глубина текущего узла в XML-документе.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060005D1 RID: 1489
		public abstract int Depth { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает базовый URI текущего узла.
		///       </summary>
		/// <returns>
		///         Базовый URI текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060005D2 RID: 1490
		public abstract string BaseURI { get; }

		/// <summary>
		///         При переопределении в производном классе получает значение, указывающее, является ли текущий узел пустым элементом (например, &lt;MyElement/&gt;).
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел является элементом (свойство <see cref="P:System.Xml.XmlReader.NodeType" /> имеет значение <see langword="XmlNodeType.Element" />), который заканчивается на /&gt;; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060005D3 RID: 1491
		public abstract bool IsEmptyElement { get; }

		/// <summary>
		///         Когда переопределено в производном классе, возвращает значение, определяющее, является ли текущий узел атрибутом, созданным из значения по умолчанию, определенного в DTD или схеме.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел является атрибутом, значение которого было создано из значения по умолчанию, определенного в DTD или схеме; значение <see langword="false" />, если значение атрибута было задано явно.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool IsDefault
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает знак кавычек для выделения значения узла атрибута.
		///       </summary>
		/// <returns>
		///         Знак кавычек (" или ') для выделения значения узла атрибута.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001E51A File Offset: 0x0001C71A
		public virtual char QuoteChar
		{
			get
			{
				return '"';
			}
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает текущую <see langword="xml:space" /> область.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlSpace" />.
		///          Если область действия <see langword="xml:space" /> отсутствует, данное свойство принимает значение <see langword="XmlSpace.None" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual XmlSpace XmlSpace
		{
			get
			{
				return XmlSpace.None;
			}
		}

		/// <summary>
		///         При переопределении в производном классе, возвращает текущую <see langword="xml:lang" /> область.
		///       </summary>
		/// <returns>
		///         Текущая область действия <see langword="xml:lang" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x0001E51E File Offset: 0x0001C71E
		public virtual string XmlLang
		{
			get
			{
				return string.Empty;
			}
		}

		/// <summary>
		///         Возвращает сведения схемы, которые были назначены текущему узлу в результате проверки схемы.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> Объект, содержащий сведения о схеме для текущего узла.
		///          Сведения о схеме можно задать на элементов, атрибутов или текстовых узлов с пустым <see cref="P:System.Xml.XmlReader.ValueType" /> (типизированные значения).
		///
		///         Если текущий узел не является одним из приведенных выше типов узлов или <see langword="XmlReader" /> экземпляра не сообщает сведения о схеме, это свойство возвращает <see langword="null" />.
		///
		///         Если это свойство вызывается из <see cref="T:System.Xml.XmlTextReader" /> или <see cref="T:System.Xml.XmlValidatingReader" /> объекта, это свойство всегда возвращает <see langword="null" />.
		///          Эти <see langword="XmlReader" /> реализации не раскрывают сведений схемы посредством <see langword="SchemaInfo" /> свойство.
		///
		///           Если требуется получить информационный набор после проверки схемы (PSVI — post-schema-validation information set) для элемента, выполните позиционирование объекта чтения на конечный тег элемента вместо начального.
		///            PSVI доступны <see langword="SchemaInfo" /> объекта чтения.
		///            Проверяющий модуль чтения, созданного при помощи <see cref="Overload:System.Xml.XmlReader.Create" /> с <see cref="P:System.Xml.XmlReaderSettings.ValidationType" /> свойству <see cref="F:System.Xml.ValidationType.Schema" /> имеет полные сведения PSVI для элемента только в том случае, если средство чтения расположено на конечный тег элемента.
		///         </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0001E525 File Offset: 0x0001C725
		public virtual IXmlSchemaInfo SchemaInfo
		{
			get
			{
				return this as IXmlSchemaInfo;
			}
		}

		/// <summary>
		///         Возвращает тип CLR текущего узла.
		///       </summary>
		/// <returns>
		///         Тип CLR, соответствующий типизированному значению узла.
		///          Значение по умолчанию — <see langword="System.String" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001E52D File Offset: 0x0001C72D
		public virtual Type ValueType
		{
			get
			{
				return typeof(string);
			}
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое как самый подходящий объект CLR.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DA RID: 1498 RVA: 0x0001E539 File Offset: 0x0001C739
		public virtual object ReadContentAsObject()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsObject");
			}
			return this.InternalReadContentAsString();
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see langword="Boolean" />.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде <see cref="T:System.Boolean" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DB RID: 1499 RVA: 0x0001E558 File Offset: 0x0001C758
		public virtual bool ReadContentAsBoolean()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsBoolean");
			}
			bool result;
			try
			{
				result = XmlConvert.ToBoolean(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Boolean", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see cref="T:System.DateTime" /> объект.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде <see cref="T:System.DateTime" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DC RID: 1500 RVA: 0x0001E5B4 File Offset: 0x0001C7B4
		public virtual DateTime ReadContentAsDateTime()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsDateTime");
			}
			DateTime result;
			try
			{
				result = XmlConvert.ToDateTime(this.InternalReadContentAsString(), XmlDateTimeSerializationMode.RoundtripKind);
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "DateTime", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see cref="T:System.DateTimeOffset" /> объект.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде <see cref="T:System.DateTimeOffset" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DD RID: 1501 RVA: 0x0001E610 File Offset: 0x0001C810
		public virtual DateTimeOffset ReadContentAsDateTimeOffset()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsDateTimeOffset");
			}
			DateTimeOffset result;
			try
			{
				result = XmlConvert.ToDateTimeOffset(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "DateTimeOffset", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает текстовое содержимое в текущей позиции как число с плавающей запятой двойной точности.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде числа с плавающей запятой двойной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DE RID: 1502 RVA: 0x0001E66C File Offset: 0x0001C86C
		public virtual double ReadContentAsDouble()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsDouble");
			}
			double result;
			try
			{
				result = XmlConvert.ToDouble(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Double", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как число с плавающей запятой одиночной точности.
		///       </summary>
		/// <returns>
		///         Содержимое текста в текущей позиции как число с плавающей запятой одиночной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005DF RID: 1503 RVA: 0x0001E6C8 File Offset: 0x0001C8C8
		public virtual float ReadContentAsFloat()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsFloat");
			}
			float result;
			try
			{
				result = XmlConvert.ToSingle(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Float", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see cref="T:System.Decimal" /> объект.
		///       </summary>
		/// <returns>
		///         Содержимое текста в текущей позиции как <see cref="T:System.Decimal" /> объект.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E0 RID: 1504 RVA: 0x0001E724 File Offset: 0x0001C924
		public virtual decimal ReadContentAsDecimal()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsDecimal");
			}
			decimal result;
			try
			{
				result = XmlConvert.ToDecimal(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Decimal", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает текстовое содержимое в текущей позиции как 32-разрядное целое число со знаком.
		///       </summary>
		/// <returns>
		///         Содержимое как 32-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E1 RID: 1505 RVA: 0x0001E780 File Offset: 0x0001C980
		public virtual int ReadContentAsInt()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsInt");
			}
			int result;
			try
			{
				result = XmlConvert.ToInt32(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Int", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает текстовое содержимое в текущей позиции как 64-разрядное целое число со знаком.
		///       </summary>
		/// <returns>
		///         Содержимое как 64-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E2 RID: 1506 RVA: 0x0001E7DC File Offset: 0x0001C9DC
		public virtual long ReadContentAsLong()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsLong");
			}
			long result;
			try
			{
				result = XmlConvert.ToInt64(this.InternalReadContentAsString());
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", "Long", innerException, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает содержимое текста в текущей позиции как <see cref="T:System.String" /> объект.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде <see cref="T:System.String" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Недопустимый формат строки.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E3 RID: 1507 RVA: 0x0001E838 File Offset: 0x0001CA38
		public virtual string ReadContentAsString()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsString");
			}
			return this.InternalReadContentAsString();
		}

		/// <summary>
		///         Считывает содержимое объекта указанного типа.
		///       </summary>
		/// <param name="returnType">
		///           Тип возвращаемого значения.
		///
		///           Примечание   с выпуском платформы .NET Framework 3.5 значение <paramref name="returnType" /> может иметь <see cref="T:System.DateTimeOffset" /> типа.
		///         </param>
		/// <param name="namespaceResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения любых префиксов пространств имен, имеющих отношение к преобразованию типов.
		///            Например, этот объект можно использовать при преобразовании объекта <see cref="T:System.Xml.XmlQualifiedName" /> в xs:string.
		///
		///           Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объединенное текстовое содержимое или значение атрибута, преобразованное в требуемый тип.
		///       </returns>
		/// <exception cref="T:System.FormatException">
		///             Содержимое не правильный формат для целевого типа.
		///           </exception>
		/// <exception cref="T:System.InvalidCastException">
		///             Попытка приведения типов не является допустимым.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="returnType" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел не является неподдерживаемым типом узла.
		///              Подробные сведения см.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Чтение <see langword="Decimal.MaxValue" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E4 RID: 1508 RVA: 0x0001E854 File Offset: 0x0001CA54
		public virtual object ReadContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver)
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAs");
			}
			string text = this.InternalReadContentAsString();
			if (returnType == typeof(string))
			{
				return text;
			}
			object result;
			try
			{
				result = XmlUntypedConverter.Untyped.ChangeType(text, returnType, (namespaceResolver == null) ? (this as IXmlNamespaceResolver) : namespaceResolver);
			}
			catch (FormatException innerException)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", returnType.ToString(), innerException, this as IXmlLineInfo);
			}
			catch (InvalidCastException innerException2)
			{
				throw new XmlException("Content cannot be converted to the type {0}.", returnType.ToString(), innerException2, this as IXmlLineInfo);
			}
			return result;
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Упакованный объект CLR наиболее подходящего типа.
		///         <see cref="P:System.Xml.XmlReader.ValueType" /> Свойство определяет соответствующий тип среды CLR.
		///          Если содержимое типизировано как тип списка, этот метод возвращает массив упакованных объектов соответствующего типа.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E5 RID: 1509 RVA: 0x0001E8FC File Offset: 0x0001CAFC
		public virtual object ReadElementContentAsObject()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsObject"))
			{
				object result = this.ReadContentAsObject();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return string.Empty;
		}

		/// <summary>
		///         Проверяет, что указанным локальным именем и URI пространства имен таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Object" />.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Упакованный объект CLR наиболее подходящего типа.
		///         <see cref="P:System.Xml.XmlReader.ValueType" /> Свойство определяет соответствующий тип среды CLR.
		///          Если содержимое типизировано как тип списка, этот метод возвращает массив упакованных объектов соответствующего типа.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E6 RID: 1510 RVA: 0x0001E91D File Offset: 0x0001CB1D
		public virtual object ReadElementContentAsObject(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsObject();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Boolean" /> объекта.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.Boolean" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.Boolean" /> объекта.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E7 RID: 1511 RVA: 0x0001E92D File Offset: 0x0001CB2D
		public virtual bool ReadElementContentAsBoolean()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsBoolean"))
			{
				bool result = this.ReadContentAsBoolean();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToBoolean(string.Empty);
		}

		/// <summary>
		///         Проверяет, что указанным локальным именем и URI пространства имен таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Boolean" /> объекта.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.Boolean" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E8 RID: 1512 RVA: 0x0001E953 File Offset: 0x0001CB53
		public virtual bool ReadElementContentAsBoolean(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsBoolean();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.DateTime" /> объекта.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.DateTime" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.DateTime" /> объекта.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005E9 RID: 1513 RVA: 0x0001E963 File Offset: 0x0001CB63
		public virtual DateTime ReadElementContentAsDateTime()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsDateTime"))
			{
				DateTime result = this.ReadContentAsDateTime();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToDateTime(string.Empty, XmlDateTimeSerializationMode.RoundtripKind);
		}

		/// <summary>
		///         Проверяет, что указанным локальным именем и URI пространства имен таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.DateTime" /> объекта.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.DateTime" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005EA RID: 1514 RVA: 0x0001E98A File Offset: 0x0001CB8A
		public virtual DateTime ReadElementContentAsDateTime(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsDateTime();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое как число с плавающей запятой двойной точности.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде числа с плавающей запятой двойной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может быть преобразовано двойной точности с плавающей запятой.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005EB RID: 1515 RVA: 0x0001E99A File Offset: 0x0001CB9A
		public virtual double ReadElementContentAsDouble()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsDouble"))
			{
				double result = this.ReadContentAsDouble();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToDouble(string.Empty);
		}

		/// <summary>
		///         Проверяет, совпадают ли указанные локальное имя и URI пространства имен с таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое как число с плавающей запятой двойной точности.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде числа с плавающей запятой двойной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005EC RID: 1516 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		public virtual double ReadElementContentAsDouble(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsDouble();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое как число с плавающей запятой одиночной точности.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде числа с плавающей запятой одиночной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может преобразовать число одинарной точности с плавающей запятой.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005ED RID: 1517 RVA: 0x0001E9D0 File Offset: 0x0001CBD0
		public virtual float ReadElementContentAsFloat()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsFloat"))
			{
				float result = this.ReadContentAsFloat();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToSingle(string.Empty);
		}

		/// <summary>
		///         Проверяет, совпадают ли указанные локальное имя и URI пространства имен с таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое как число с плавающей запятой одиночной точности.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде числа с плавающей запятой одиночной точности.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может преобразовать число одинарной точности с плавающей запятой.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005EE RID: 1518 RVA: 0x0001E9F6 File Offset: 0x0001CBF6
		public virtual float ReadElementContentAsFloat(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsFloat();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Decimal" /> объекта.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.Decimal" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.Decimal" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005EF RID: 1519 RVA: 0x0001EA06 File Offset: 0x0001CC06
		public virtual decimal ReadElementContentAsDecimal()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsDecimal"))
			{
				decimal result = this.ReadContentAsDecimal();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToDecimal(string.Empty);
		}

		/// <summary>
		///         Проверяет, что указанным локальным именем и URI пространства имен таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Decimal" /> объекта.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.Decimal" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.Decimal" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F0 RID: 1520 RVA: 0x0001EA2C File Offset: 0x0001CC2C
		public virtual decimal ReadElementContentAsDecimal(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsDecimal();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде 32-разрядного целого числа со знаком.
		///       </summary>
		/// <returns>
		///         Содержимое элемента как целое 32-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может быть преобразовано 32-разрядное целое число со знаком.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F1 RID: 1521 RVA: 0x0001EA3C File Offset: 0x0001CC3C
		public virtual int ReadElementContentAsInt()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsInt"))
			{
				int result = this.ReadContentAsInt();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToInt32(string.Empty);
		}

		/// <summary>
		///         Проверяет, совпадают ли указанные локальное имя и URI пространства имен с таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое как 32-разрядное целое число со знаком.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента как целое 32-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может быть преобразовано 32-разрядное целое число со знаком.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F2 RID: 1522 RVA: 0x0001EA62 File Offset: 0x0001CC62
		public virtual int ReadElementContentAsInt(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsInt();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде 64-разрядного целого числа со знаком.
		///       </summary>
		/// <returns>
		///         Содержимое элемента как целое 64-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может быть преобразовано 64-разрядное целое число со знаком.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F3 RID: 1523 RVA: 0x0001EA72 File Offset: 0x0001CC72
		public virtual long ReadElementContentAsLong()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsLong"))
			{
				long result = this.ReadContentAsLong();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return XmlConvert.ToInt64(string.Empty);
		}

		/// <summary>
		///         Проверяет, совпадают ли указанные локальное имя и URI пространства имен с таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое как 64-разрядное целое число со знаком.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента как целое 64-разрядное целое число со знаком.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента не может быть преобразовано 64-разрядное целое число со знаком.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F4 RID: 1524 RVA: 0x0001EA98 File Offset: 0x0001CC98
		public virtual long ReadElementContentAsLong(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsLong();
		}

		/// <summary>
		///         Считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.String" /> объекта.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.String" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.String" /> объекта.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F5 RID: 1525 RVA: 0x0001EAA8 File Offset: 0x0001CCA8
		public virtual string ReadElementContentAsString()
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAsString"))
			{
				string result = this.ReadContentAsString();
				this.FinishReadElementContentAsXxx();
				return result;
			}
			return string.Empty;
		}

		/// <summary>
		///         Проверяет, что указанным локальным именем и URI пространства имен таковыми для текущего элемента, затем считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.String" /> объекта.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.String" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Не удается преобразовать содержимое элемента <see cref="T:System.String" /> объекта.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F6 RID: 1526 RVA: 0x0001EAC9 File Offset: 0x0001CCC9
		public virtual string ReadElementContentAsString(string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAsString();
		}

		/// <summary>
		///         Считывает содержимое элемента в качестве требуемого типа.
		///       </summary>
		/// <param name="returnType">
		///           Тип возвращаемого значения.
		///
		///           Примечание   с выпуском платформы .NET Framework 3.5 значение <paramref name="returnType" /> может иметь <see cref="T:System.DateTimeOffset" /> типа.
		///         </param>
		/// <param name="namespaceResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения любых префиксов пространств имен, имеющих отношение к преобразованию типов.
		///         </param>
		/// <returns>
		///         Содержимое элемента, преобразованное в требуемый типизированный объект.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Чтение <see langword="Decimal.MaxValue" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F7 RID: 1527 RVA: 0x0001EADC File Offset: 0x0001CCDC
		public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver)
		{
			if (this.SetupReadElementContentAsXxx("ReadElementContentAs"))
			{
				object result = this.ReadContentAs(returnType, namespaceResolver);
				this.FinishReadElementContentAsXxx();
				return result;
			}
			if (!(returnType == typeof(string)))
			{
				return XmlUntypedConverter.Untyped.ChangeType(string.Empty, returnType, namespaceResolver);
			}
			return string.Empty;
		}

		/// <summary>
		///         Проверяет, совпадают ли указанные локальное имя и URI пространства имен с таковыми для текущего элемента, затем считывает содержимое элемента как требуемый тип.
		///       </summary>
		/// <param name="returnType">
		///           Тип возвращаемого значения.
		///
		///           Примечание   с выпуском платформы .NET Framework 3.5 значение <paramref name="returnType" /> может иметь <see cref="T:System.DateTimeOffset" /> типа.
		///         </param>
		/// <param name="namespaceResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения любых префиксов пространств имен, имеющих отношение к преобразованию типов.
		///         </param>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         Содержимое элемента, преобразованное в требуемый типизированный объект.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Не находится на элементе.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий элемент содержит дочерние элементы.
		///
		///             -или-
		///
		///             Содержимое элемента нельзя преобразовать в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Метод вызывается с <see langword="null" /> аргументы.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Заданным локальным именем и URI пространства имен не совпадают, считываемого текущего элемента.
		///           </exception>
		/// <exception cref="T:System.OverflowException">
		///             Чтение <see langword="Decimal.MaxValue" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005F8 RID: 1528 RVA: 0x0001EB2E File Offset: 0x0001CD2E
		public virtual object ReadElementContentAs(Type returnType, IXmlNamespaceResolver namespaceResolver, string localName, string namespaceURI)
		{
			this.CheckElement(localName, namespaceURI);
			return this.ReadElementContentAs(returnType, namespaceResolver);
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает количество атрибутов текущего узла.
		///       </summary>
		/// <returns>
		///         Количество атрибутов текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060005F9 RID: 1529
		public abstract int AttributeCount { get; }

		/// <summary>
		///         При переопределении в производном классе получает значение атрибута с указанным <see cref="P:System.Xml.XmlReader.Name" />.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден или значение равно <see langword="String.Empty" />, <see langword="null" /> возвращается.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="name" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005FA RID: 1530
		public abstract string GetAttribute(string name);

		/// <summary>
		///         При переопределении в производном классе получает значение атрибута с указанным <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" />.
		///       </summary>
		/// <param name="name">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден или значение равно <see langword="String.Empty" />, <see langword="null" /> возвращается.
		///          Этот метод не изменяет позицию средства чтения.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="name" /> имеет значение <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005FB RID: 1531
		public abstract string GetAttribute(string name, string namespaceURI);

		/// <summary>
		///         Когда переопределено в производном классе, возвращает значение атрибута по указанному индексу.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///            Индексация начинается с нуля.
		///            (Индекс первого атрибута равен нулю.)
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Этот метод не изменяет позицию средства чтения.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="i" /> выходит за пределы диапазона.
		///              Оно должно быть неотрицательным и меньшим, чем размер коллекции атрибутов.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x060005FC RID: 1532
		public abstract string GetAttribute(int i);

		/// <summary>
		///         Когда переопределено в производном классе, возвращает значение атрибута по указанному индексу.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C5 RID: 197
		public virtual string this[int i]
		{
			get
			{
				return this.GetAttribute(i);
			}
		}

		/// <summary>
		///         При переопределении в производном классе получает значение атрибута с указанным <see cref="P:System.Xml.XmlReader.Name" />.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден, возвращается значение <see langword="null" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C6 RID: 198
		public virtual string this[string name]
		{
			get
			{
				return this.GetAttribute(name);
			}
		}

		/// <summary>
		///         При переопределении в производном классе получает значение атрибута с указанным <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" />.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C7 RID: 199
		public virtual string this[string name, string namespaceURI]
		{
			get
			{
				return this.GetAttribute(name, namespaceURI);
			}
		}

		/// <summary>
		///         При переопределении в производном классе перемещает к атрибуту с указанным <see cref="P:System.Xml.XmlReader.Name" />.
		///       </summary>
		/// <param name="name">
		///           Полное имя атрибута.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут найден; в противном случае — <see langword="false" />.
		///          Если значение <see langword="false" />, позиция средства чтения не изменяется.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр является пустая строка.
		///           </exception>
		// Token: 0x06000600 RID: 1536
		public abstract bool MoveToAttribute(string name);

		/// <summary>
		///         При переопределении в производном классе перемещает к атрибуту с указанным <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" />.
		///       </summary>
		/// <param name="name">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут найден; в противном случае — <see langword="false" />.
		///          Если значение <see langword="false" />, позиция средства чтения не изменяется.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Оба значения параметра <see langword="null" />.
		///           </exception>
		// Token: 0x06000601 RID: 1537
		public abstract bool MoveToAttribute(string name, string ns);

		/// <summary>
		///         Когда переопределено в производном классе, переходит к атрибуту с указанным индексом.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Параметр имеет отрицательное значение.
		///           </exception>
		// Token: 0x06000602 RID: 1538 RVA: 0x0001EB60 File Offset: 0x0001CD60
		public virtual void MoveToAttribute(int i)
		{
			if (i < 0 || i >= this.AttributeCount)
			{
				throw new ArgumentOutOfRangeException("i");
			}
			this.MoveToElement();
			this.MoveToFirstAttribute();
			for (int j = 0; j < i; j++)
			{
				this.MoveToNextAttribute();
			}
		}

		/// <summary>
		///         Когда переопределено в производном классе, переходит к первому атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут существует (средство чтения перемещается к первому атрибуту); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000603 RID: 1539
		public abstract bool MoveToFirstAttribute();

		/// <summary>
		///         Когда переопределено в производном классе, переходит к следующему атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствует следующий атрибут; значение <see langword="false" />, если другие атрибуты отсутствуют.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000604 RID: 1540
		public abstract bool MoveToNextAttribute();

		/// <summary>
		///         Когда переопределено в производном классе, переходит к элементу, содержащему текущий узел атрибута.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения находится на атрибуте (средство чтения перемещается к элементу с этим атрибутом); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000605 RID: 1541
		public abstract bool MoveToElement();

		/// <summary>
		///         При переопределении в производном классе разбирает значение атрибута в один или несколько <see langword="Text" />, <see langword="EntityReference" />, или <see langword="EndEntity" /> узлов.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствуют возвращаемые узлы.
		///
		///         Значение <see langword="false" />, если средство чтения не расположено на узле атрибута при первом вызове или все значения атрибута считаны.
		///
		///         Пустой атрибут (например, misc="") возвращает значение <see langword="true" /> с отдельным узлом, имеющим значение <see langword="String.Empty" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000606 RID: 1542
		public abstract bool ReadAttributeValue();

		/// <summary>
		///         Когда переопределено в производном классе, считывает из потока следующий узел.
		///       </summary>
		/// <returns>
		///         <see langword="true" />, если считывание узла прошло успешно. В противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка при синтаксическом анализе XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод <see cref="T:System.Xml.XmlReader" /> вызван перед завершением предыдущей асинхронной операции.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Асинхронная операция уже выполняется".
		///           </exception>
		// Token: 0x06000607 RID: 1543
		public abstract bool Read();

		/// <summary>
		///         Когда переопределено в производном классе, возвращает значение, показывающее, позиционировано ли средство чтения в конец потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения установлено в конец потока; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000608 RID: 1544
		public abstract bool EOF { get; }

		/// <summary>
		///         При переопределении в производном классе изменяет <see cref="P:System.Xml.XmlReader.ReadState" /> для <see cref="F:System.Xml.ReadState.Closed" />.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000609 RID: 1545 RVA: 0x0000B528 File Offset: 0x00009728
		public virtual void Close()
		{
		}

		/// <summary>
		///         Когда переопределено в производном классе, возвращает состояние средства чтения.
		///       </summary>
		/// <returns>
		///         Одно из значений перечисления, определяющее состояние средства чтения.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x0600060A RID: 1546
		public abstract ReadState ReadState { get; }

		/// <summary>
		///         Пропускает дочерний узел текущего узла.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600060B RID: 1547 RVA: 0x0001EBA6 File Offset: 0x0001CDA6
		public virtual void Skip()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return;
			}
			this.SkipSubtree();
		}

		/// <summary>
		///         При переопределении в производном классе получает <see cref="T:System.Xml.XmlNameTable" /> связанный с данной реализацией.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNameTable" />, позволяющий получать в узле разделенную версию строки.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600060C RID: 1548
		public abstract XmlNameTable NameTable { get; }

		/// <summary>
		///         Когда переопределено в производном классе, разрешает префикс пространства имен в области видимости текущего элемента.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, для которого требуется разрешить URI пространства имен.
		///            Чтобы сопоставить пространство имен по умолчанию, необходимо передать пустую строку.
		///         </param>
		/// <returns>
		///         URI пространства имен, которое отображает префикс, или значение <see langword="null" />, если соответствующий префикс не найден.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600060D RID: 1549
		public abstract string LookupNamespace(string prefix);

		/// <summary>
		///         Возвращает значение, определяющее, способно ли данное средство чтения выполнять синтаксический анализ и разрешение сущностей.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения позволяет анализировать и разрешать сущности; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600060E RID: 1550 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool CanResolveEntity
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         При переопределении в производном классе разрешает ссылки на сущности для <see langword="EntityReference" /> узлов.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Средство чтения не позиционировано на <see langword="EntityReference" /> узел; это реализация модуля чтения не может разрешать сущности (<see cref="P:System.Xml.XmlReader.CanResolveEntity" /> возвращает <see langword="false" />).
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600060F RID: 1551
		public abstract void ResolveEntity();

		/// <summary>
		///         Получает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlReader" /> методы чтения двоичного содержимого.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если реализуются методы чтения двоичного содержимого; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000610 RID: 1552 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool CanReadBinaryContent
		{
			get
			{
				return false;
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
		///             <see cref="M:System.Xml.XmlReader.ReadContentAsBase64(System.Byte[],System.Int32,System.Int32)" /> не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000611 RID: 1553 RVA: 0x0001EBB9 File Offset: 0x0001CDB9
		public virtual int ReadContentAsBase64(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadContentAsBase64"
			}));
		}

		/// <summary>
		///         Считывает элемент и декодирует содержимое <see langword="Base64" />.
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
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000612 RID: 1554 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		public virtual int ReadElementContentAsBase64(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadElementContentAsBase64"
			}));
		}

		/// <summary>
		///         Считывает содержимое и возвращает раскодированные двоичные байты <see langword="BinHex" />.
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
		///             <see cref="M:System.Xml.XmlReader.ReadContentAsBinHex(System.Byte[],System.Int32,System.Int32)" /> не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000613 RID: 1555 RVA: 0x0001EBF7 File Offset: 0x0001CDF7
		public virtual int ReadContentAsBinHex(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadContentAsBinHex"
			}));
		}

		/// <summary>
		///         Считывает элемент и декодирует содержимое <see langword="BinHex" />.
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
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000614 RID: 1556 RVA: 0x0001EC16 File Offset: 0x0001CE16
		public virtual int ReadElementContentAsBinHex(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadElementContentAsBinHex"
			}));
		}

		/// <summary>
		///         Возвращает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlReader" /> метод <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XmlReader" /> реализует метод <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" />; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000615 RID: 1557 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public virtual bool CanReadValueChunk
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Считывает большие потоки текста, внедренного в XML-документ.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, выполняющий функции буфера, в который записывается текстовое содержимое.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, где <see cref="T:System.Xml.XmlReader" /> может начать копировать результаты.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер символов.
		///            Этот метод возвращает фактическое количество скопированных символов.
		///         </param>
		/// <returns>
		///         Количество символов, считанных в буфер.
		///          По окончании текстового содержимого возвращается нуль.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Текущий узел не имеет значения (<see cref="P:System.Xml.XmlReader.HasValue" /> — <see langword="false" />).
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере, или индекс + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Данные XML сформирован неправильно.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000616 RID: 1558 RVA: 0x0001EC35 File Offset: 0x0001CE35
		public virtual int ReadValueChunk(char[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("ReadValueChunk method is not supported on this XmlReader. Use CanReadValueChunk property to find out if an XmlReader implements it."));
		}

		/// <summary>
		///         Когда переопределено в производном классе, считывает содержимое узла элемента или текстового узла в виде строки.
		///          Тем не менее, мы рекомендуем использовать <see cref="Overload:System.Xml.XmlReader.ReadElementContentAsString" /> метода вместо этого, поскольку она предоставляет более простой способ обработки данной операции.
		///       </summary>
		/// <returns>
		///         Содержимое элемента или пустая строка.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка при разборе XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000617 RID: 1559 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadString()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return string.Empty;
			}
			this.MoveToElement();
			if (this.NodeType == XmlNodeType.Element)
			{
				if (this.IsEmptyElement)
				{
					return string.Empty;
				}
				if (!this.Read())
				{
					throw new InvalidOperationException(Res.GetString("Operation is not valid due to the current state of the object."));
				}
				if (this.NodeType == XmlNodeType.EndElement)
				{
					return string.Empty;
				}
			}
			string text = string.Empty;
			while (XmlReader.IsTextualNode(this.NodeType))
			{
				text += this.Value;
				if (!this.Read())
				{
					break;
				}
			}
			return text;
		}

		/// <summary>
		///         Проверяет, является ли текущий узел содержимого (текст пустое пространство, <see langword="CDATA" />, <see langword="Element" />, <see langword="EndElement" />, <see langword="EntityReference" />, или <see langword="EndEntity" />) узла.
		///          Если узел не является узлом содержимого, средство чтения пропускает этот узел и переходит к следующему узлу содержимого или в конец файла.
		///          Пропускаются узлы следующих типов: <see langword="ProcessingInstruction" />, <see langword="DocumentType" />, <see langword="Comment" />, <see langword="Whitespace" /> и <see langword="SignificantWhitespace" />.
		///       </summary>
		/// <returns>
		///         <see cref="P:System.Xml.XmlReader.NodeType" /> Текущего узла, найденного с помощью метода или <see langword="XmlNodeType.None" /> Если средство чтения достигло конца потока входных данных.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Во входном потоке обнаружен неверный XML-код.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000618 RID: 1560 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		public virtual XmlNodeType MoveToContent()
		{
			for (;;)
			{
				XmlNodeType nodeType = this.NodeType;
				switch (nodeType)
				{
				case XmlNodeType.Element:
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.EntityReference:
					goto IL_33;
				case XmlNodeType.Attribute:
					goto IL_2C;
				default:
					if (nodeType - XmlNodeType.EndElement <= 1)
					{
						goto IL_33;
					}
					if (!this.Read())
					{
						goto Block_2;
					}
					break;
				}
			}
			IL_2C:
			this.MoveToElement();
			IL_33:
			return this.NodeType;
			Block_2:
			return this.NodeType;
		}

		/// <summary>
		///         Проверяет, является ли текущий узел элементом и перемещает модуль чтения к следующему узлу.
		///       </summary>
		/// <exception cref="T:System.Xml.XmlException">
		///             Во входном потоке обнаружен неправильный XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000619 RID: 1561 RVA: 0x0001ED30 File Offset: 0x0001CF30
		public virtual void ReadStartElement()
		{
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			this.Read();
		}

		/// <summary>
		///         Проверяет, что текущий узел элементом с заданной <see cref="P:System.Xml.XmlReader.Name" /> и перемещает средство чтения на следующий узел.
		///       </summary>
		/// <param name="name">
		///           Полное имя элемента.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             Во входном потоке обнаружен неправильный XML.
		///
		///             -или- 
		///
		///             <see cref="P:System.Xml.XmlReader.Name" /> Элемента не соответствует заданной <paramref name="name" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061A RID: 1562 RVA: 0x0001ED74 File Offset: 0x0001CF74
		public virtual void ReadStartElement(string name)
		{
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (this.Name == name)
			{
				this.Read();
				return;
			}
			throw new XmlException("Element '{0}' was not found.", name, this as IXmlLineInfo);
		}

		/// <summary>
		///         Проверяет, что текущий узел элементом с заданной <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" /> и перемещает средство чтения на следующий узел.
		///       </summary>
		/// <param name="localname">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="ns">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             Во входном потоке обнаружен неправильный XML.
		///
		///             -или-
		///
		///             <see cref="P:System.Xml.XmlReader.LocalName" /> И <see cref="P:System.Xml.XmlReader.NamespaceURI" /> свойства найденного элемента не соответствуют заданным аргументам.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061B RID: 1563 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		public virtual void ReadStartElement(string localname, string ns)
		{
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (this.LocalName == localname && this.NamespaceURI == ns)
			{
				this.Read();
				return;
			}
			throw new XmlException("Element '{0}' with namespace name '{1}' was not found.", new string[]
			{
				localname,
				ns
			}, this as IXmlLineInfo);
		}

		/// <summary>
		///         Считывает элемент, предназначенный только для чтения.
		///          Тем не менее, мы рекомендуем использовать <see cref="M:System.Xml.XmlReader.ReadElementContentAsString" /> метода вместо этого, поскольку она предоставляет более простой способ обработки данной операции.
		///       </summary>
		/// <returns>
		///         Текст, содержащийся в считанном элементе.
		///          Пустая строка, если элемент является пустым.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Следующий узел содержимого не является открывающим тегом; или найти элемент не содержит простого текстового значения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061C RID: 1564 RVA: 0x0001EE58 File Offset: 0x0001D058
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadElementString()
		{
			string result = string.Empty;
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (!this.IsEmptyElement)
			{
				this.Read();
				result = this.ReadString();
				if (this.NodeType != XmlNodeType.EndElement)
				{
					throw new XmlException("Unexpected node type {0}. {1} method can only be called on elements with simple or empty content.", new string[]
					{
						this.NodeType.ToString(),
						"ReadElementString"
					}, this as IXmlLineInfo);
				}
				this.Read();
			}
			else
			{
				this.Read();
			}
			return result;
		}

		/// <summary>
		///         Проверяет, что <see cref="P:System.Xml.XmlReader.Name" /> свойства найденного элемента совпадает с указанной строкой перед чтением текстового элемента.
		///          Тем не менее, мы рекомендуем использовать <see cref="M:System.Xml.XmlReader.ReadElementContentAsString" /> метода вместо этого, поскольку она предоставляет более простой способ обработки данной операции.
		///       </summary>
		/// <param name="name">
		///           Имя для проверки.
		///         </param>
		/// <returns>
		///         Текст, содержащийся в считанном элементе.
		///          Пустая строка, если элемент является пустым.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Если следующий узел содержимого не является открывающим тегом; Если элемент <see langword="Name" /> не соответствует заданному аргументу, или найденный элемент не содержит простого текстового значения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061D RID: 1565 RVA: 0x0001EF00 File Offset: 0x0001D100
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadElementString(string name)
		{
			string result = string.Empty;
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (this.Name != name)
			{
				throw new XmlException("Element '{0}' was not found.", name, this as IXmlLineInfo);
			}
			if (!this.IsEmptyElement)
			{
				result = this.ReadString();
				if (this.NodeType != XmlNodeType.EndElement)
				{
					throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
				}
				this.Read();
			}
			else
			{
				this.Read();
			}
			return result;
		}

		/// <summary>
		///         Проверяет, что <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" /> Свойства элемента найденного заданных строк перед чтением текстового элемента.
		///          Тем не менее, мы рекомендуем использовать <see cref="M:System.Xml.XmlReader.ReadElementContentAsString(System.String,System.String)" /> метода вместо этого, поскольку она предоставляет более простой способ обработки данной операции.
		///       </summary>
		/// <param name="localname">
		///           Локальное имя для проверки.
		///         </param>
		/// <param name="ns">
		///           URI пространства имен для проверки.
		///         </param>
		/// <returns>
		///         Текст, содержащийся в считанном элементе.
		///          Пустая строка, если элемент является пустым.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Если следующий узел содержимого не является открывающим тегом; Если элемент <see langword="LocalName" /> или <see langword="NamespaceURI" /> не соответствует заданным аргументам, или найденный элемент не содержит простого текстового значения.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061E RID: 1566 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual string ReadElementString(string localname, string ns)
		{
			string result = string.Empty;
			if (this.MoveToContent() != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (this.LocalName != localname || this.NamespaceURI != ns)
			{
				throw new XmlException("Element '{0}' with namespace name '{1}' was not found.", new string[]
				{
					localname,
					ns
				}, this as IXmlLineInfo);
			}
			if (!this.IsEmptyElement)
			{
				result = this.ReadString();
				if (this.NodeType != XmlNodeType.EndElement)
				{
					throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
				}
				this.Read();
			}
			else
			{
				this.Read();
			}
			return result;
		}

		/// <summary>
		///         Проверяет, является ли текущий узел содержимого закрывающим тегом, и позиционирует средство чтения на следующий узел.
		///       </summary>
		/// <exception cref="T:System.Xml.XmlException">
		///             Текущий узел не является закрывающим тегом или если неверный XML встречается во входном потоке.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600061F RID: 1567 RVA: 0x0001F07C File Offset: 0x0001D27C
		public virtual void ReadEndElement()
		{
			if (this.MoveToContent() != XmlNodeType.EndElement)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			this.Read();
		}

		/// <summary>
		///         Вызовы <see cref="M:System.Xml.XmlReader.MoveToContent" /> и проверяет, является ли текущий узел содержимого открывающим тегом или пустым тегом элемента.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если <see cref="M:System.Xml.XmlReader.MoveToContent" /> находит открывающий тег или пустой тег элемента; <see langword="false" /> Если узел типом, отличным от <see langword="XmlNodeType.Element" /> найден.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неверный XML встречается во входном потоке.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000620 RID: 1568 RVA: 0x0001F0BF File Offset: 0x0001D2BF
		public virtual bool IsStartElement()
		{
			return this.MoveToContent() == XmlNodeType.Element;
		}

		/// <summary>
		///         Вызовы <see cref="M:System.Xml.XmlReader.MoveToContent" /> и проверяет, является ли текущий узел содержимого открывающим тегом или пустым тегом элемента, а если <see cref="P:System.Xml.XmlReader.Name" /> свойство элемента соответствует заданному аргументу.
		///       </summary>
		/// <param name="name">
		///           Строка противопоставляется <see langword="Name" /> свойства найденного элемента.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если полученный в результате узел является элементом и <see langword="Name" /> свойства совпадает с указанной строкой.
		///         <see langword="false" /> Если узел типом, отличным от <see langword="XmlNodeType.Element" /> был найден или если элемент <see langword="Name" /> свойства не совпадает с указанной строкой.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неверный XML встречается во входном потоке.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000621 RID: 1569 RVA: 0x0001F0CA File Offset: 0x0001D2CA
		public virtual bool IsStartElement(string name)
		{
			return this.MoveToContent() == XmlNodeType.Element && this.Name == name;
		}

		/// <summary>
		///         Вызовы <see cref="M:System.Xml.XmlReader.MoveToContent" /> и проверяет, является ли текущий узел содержимого открывающим тегом или пустым тегом элемента, а если <see cref="P:System.Xml.XmlReader.LocalName" /> и <see cref="P:System.Xml.XmlReader.NamespaceURI" /> свойства найденного элемента соответствует заданной строки.
		///       </summary>
		/// <param name="localname">
		///           Строка, сравниваемая с <see langword="LocalName" /> свойства найденного элемента.
		///         </param>
		/// <param name="ns">
		///           Строка, сравниваемая с <see langword="NamespaceURI" /> свойства найденного элемента.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если полученный в результате узел является элементом.
		///         <see langword="false" /> Если узел типом, отличным от <see langword="XmlNodeType.Element" /> был найден или если <see langword="LocalName" /> и <see langword="NamespaceURI" /> Свойства элемента не соответствуют указанной строки.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Неверный XML встречается во входном потоке.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000622 RID: 1570 RVA: 0x0001F0E3 File Offset: 0x0001D2E3
		public virtual bool IsStartElement(string localname, string ns)
		{
			return this.MoveToContent() == XmlNodeType.Element && this.LocalName == localname && this.NamespaceURI == ns;
		}

		/// <summary>
		///         Выполняет чтение до обнаружения элемента с указанным полным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя элемента.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если найден соответствующий элемент; в противном случае <see langword="false" /> и <see cref="T:System.Xml.XmlReader" /> находится в состоянии конец файла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр является пустая строка.
		///           </exception>
		// Token: 0x06000623 RID: 1571 RVA: 0x0001F10C File Offset: 0x0001D30C
		public virtual bool ReadToFollowing(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(name, "name");
			}
			name = this.NameTable.Add(name);
			while (this.Read())
			{
				if (this.NodeType == XmlNodeType.Element && Ref.Equal(name, this.Name))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///         Выполняет чтение до обнаружения указанных локального имени и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если найден соответствующий элемент; в противном случае <see langword="false" /> и <see cref="T:System.Xml.XmlReader" /> находится в состоянии конец файла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Оба значения параметра <see langword="null" />.
		///           </exception>
		// Token: 0x06000624 RID: 1572 RVA: 0x0001F164 File Offset: 0x0001D364
		public virtual bool ReadToFollowing(string localName, string namespaceURI)
		{
			if (localName == null || localName.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(localName, "localName");
			}
			if (namespaceURI == null)
			{
				throw new ArgumentNullException("namespaceURI");
			}
			localName = this.NameTable.Add(localName);
			namespaceURI = this.NameTable.Add(namespaceURI);
			while (this.Read())
			{
				if (this.NodeType == XmlNodeType.Element && Ref.Equal(localName, this.LocalName) && Ref.Equal(namespaceURI, this.NamespaceURI))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XmlReader" /> к следующему элементу-потомку с указанным проверенным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя элемента, на который следует переместиться.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если найден сопоставленный элемент-потомок; в противном случае <see langword="false" />.
		///          Если сопоставленный дочерний элемент не найден, <see cref="T:System.Xml.XmlReader" /> позиционируется на закрывающем теге (<see cref="P:System.Xml.XmlReader.NodeType" /> — <see langword="XmlNodeType.EndElement" />) элемента.
		///
		///         Если <see cref="T:System.Xml.XmlReader" /> не находится на элементе при <see cref="M:System.Xml.XmlReader.ReadToDescendant(System.String)" /> был вызван этот метод возвращает <see langword="false" /> и положение <see cref="T:System.Xml.XmlReader" /> не изменяется.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр является пустая строка.
		///           </exception>
		// Token: 0x06000625 RID: 1573 RVA: 0x0001F1E4 File Offset: 0x0001D3E4
		public virtual bool ReadToDescendant(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(name, "name");
			}
			int num = this.Depth;
			if (this.NodeType != XmlNodeType.Element)
			{
				if (this.ReadState != ReadState.Initial)
				{
					return false;
				}
				num--;
			}
			else if (this.IsEmptyElement)
			{
				return false;
			}
			name = this.NameTable.Add(name);
			while (this.Read() && this.Depth > num)
			{
				if (this.NodeType == XmlNodeType.Element && Ref.Equal(name, this.Name))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///         Перемещает <see cref="T:System.Xml.XmlReader" /> к следующему элементу-потомку с указанным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента, на который следует переместиться.
		///         </param>
		/// <param name="namespaceURI">
		///           URI пространства имен элемента, на который следует переместиться.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если найден сопоставленный элемент-потомок; в противном случае <see langword="false" />.
		///          Если сопоставленный дочерний элемент не найден, <see cref="T:System.Xml.XmlReader" /> позиционируется на закрывающем теге (<see cref="P:System.Xml.XmlReader.NodeType" /> — <see langword="XmlNodeType.EndElement" />) элемента.
		///
		///         Если <see cref="T:System.Xml.XmlReader" /> не находится на элементе при <see cref="M:System.Xml.XmlReader.ReadToDescendant(System.String,System.String)" /> был вызван этот метод возвращает <see langword="false" /> и положение <see cref="T:System.Xml.XmlReader" /> не изменяется.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Оба значения параметра <see langword="null" />.
		///           </exception>
		// Token: 0x06000626 RID: 1574 RVA: 0x0001F270 File Offset: 0x0001D470
		public virtual bool ReadToDescendant(string localName, string namespaceURI)
		{
			if (localName == null || localName.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(localName, "localName");
			}
			if (namespaceURI == null)
			{
				throw new ArgumentNullException("namespaceURI");
			}
			int num = this.Depth;
			if (this.NodeType != XmlNodeType.Element)
			{
				if (this.ReadState != ReadState.Initial)
				{
					return false;
				}
				num--;
			}
			else if (this.IsEmptyElement)
			{
				return false;
			}
			localName = this.NameTable.Add(localName);
			namespaceURI = this.NameTable.Add(namespaceURI);
			while (this.Read() && this.Depth > num)
			{
				if (this.NodeType == XmlNodeType.Element && Ref.Equal(localName, this.LocalName) && Ref.Equal(namespaceURI, this.NamespaceURI))
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>
		///         Перемещает <see langword="XmlReader" /> следующему родственному элементу с указанным проверенным именем.
		///       </summary>
		/// <param name="name">
		///           Полное имя элемента того же уровня, на который следует переместиться.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если найден сопоставленный родственный элемент; в противном случае <see langword="false" />.
		///          Если сопоставленный родственный элемент не найден, <see langword="XmlReader" /> позиционируется на закрывающем теге (<see cref="P:System.Xml.XmlReader.NodeType" /> — <see langword="XmlNodeType.EndElement" />) родительского элемента.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр является пустая строка.
		///           </exception>
		// Token: 0x06000627 RID: 1575 RVA: 0x0001F324 File Offset: 0x0001D524
		public virtual bool ReadToNextSibling(string name)
		{
			if (name == null || name.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(name, "name");
			}
			name = this.NameTable.Add(name);
			while (this.SkipSubtree())
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType == XmlNodeType.Element && Ref.Equal(name, this.Name))
				{
					return true;
				}
				if (nodeType == XmlNodeType.EndElement || this.EOF)
				{
					break;
				}
			}
			return false;
		}

		/// <summary>
		///         Переводит <see langword="XmlReader" /> к следующему элементу того же уровня с указанным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя элемента того же уровня, на который следует переместиться.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен элемента того же уровня, на который следует переместиться.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если найден сопоставленный элемент с тем же родительским элементом. В противном случае — значение <see langword="false" />.
		///          Если такой элемент не найден, средство чтения <see langword="XmlReader" /> позиционируется на закрывающем теге (<see cref="P:System.Xml.XmlReader.NodeType" /> является <see langword="XmlNodeType.EndElement" />) родительского элемента.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод <see cref="T:System.Xml.XmlReader" /> вызван перед завершением предыдущей асинхронной операции.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Асинхронная операция уже выполняется".
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Оба параметра имеют значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000628 RID: 1576 RVA: 0x0001F388 File Offset: 0x0001D588
		public virtual bool ReadToNextSibling(string localName, string namespaceURI)
		{
			if (localName == null || localName.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(localName, "localName");
			}
			if (namespaceURI == null)
			{
				throw new ArgumentNullException("namespaceURI");
			}
			localName = this.NameTable.Add(localName);
			namespaceURI = this.NameTable.Add(namespaceURI);
			while (this.SkipSubtree())
			{
				XmlNodeType nodeType = this.NodeType;
				if (nodeType == XmlNodeType.Element && Ref.Equal(localName, this.LocalName) && Ref.Equal(namespaceURI, this.NamespaceURI))
				{
					return true;
				}
				if (nodeType == XmlNodeType.EndElement || this.EOF)
				{
					break;
				}
			}
			return false;
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли строковый аргумент допустимым именем XML.
		///       </summary>
		/// <param name="str">
		///           Имя для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если имя является допустимым; в противном случае — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="str" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000629 RID: 1577 RVA: 0x0001F415 File Offset: 0x0001D615
		public static bool IsName(string str)
		{
			if (str == null)
			{
				throw new NullReferenceException();
			}
			return ValidateNames.IsNameNoNamespaces(str);
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли строковый аргумент допустимым токеном имени XML.
		///       </summary>
		/// <param name="str">
		///           Токен имени для проверки.
		///         </param>
		/// <returns>
		///         <see langword="true" /> Если это является допустимым токеном имени; в противном случае <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="str" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x0600062A RID: 1578 RVA: 0x0001F426 File Offset: 0x0001D626
		public static bool IsNameToken(string str)
		{
			if (str == null)
			{
				throw new NullReferenceException();
			}
			return ValidateNames.IsNmtokenNoNamespaces(str);
		}

		/// <summary>
		///         Когда переопределено в производном классе, считывает как строку все содержимое, включая разметку.
		///       </summary>
		/// <returns>
		///         Все содержимое XML-кода в текущем узле, включая разметку.
		///          Если текущий узел не имеет дочерних узлов, возвращается пустая строка.
		///
		///         Если текущий узел не является элементом или атрибутом, возвращается пустая строка.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-код неверен или произошла ошибка при разборе XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600062B RID: 1579 RVA: 0x0001F438 File Offset: 0x0001D638
		public virtual string ReadInnerXml()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return string.Empty;
			}
			if (this.NodeType != XmlNodeType.Attribute && this.NodeType != XmlNodeType.Element)
			{
				this.Read();
				return string.Empty;
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			XmlWriter xmlWriter = this.CreateWriterForInnerOuterXml(stringWriter);
			try
			{
				if (this.NodeType == XmlNodeType.Attribute)
				{
					((XmlTextWriter)xmlWriter).QuoteChar = this.QuoteChar;
					this.WriteAttributeValue(xmlWriter);
				}
				if (this.NodeType == XmlNodeType.Element)
				{
					this.WriteNode(xmlWriter, false);
				}
			}
			finally
			{
				xmlWriter.Close();
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0001F4D8 File Offset: 0x0001D6D8
		private void WriteNode(XmlWriter xtw, bool defattr)
		{
			int num = (this.NodeType == XmlNodeType.None) ? -1 : this.Depth;
			while (this.Read() && num < this.Depth)
			{
				switch (this.NodeType)
				{
				case XmlNodeType.Element:
					xtw.WriteStartElement(this.Prefix, this.LocalName, this.NamespaceURI);
					((XmlTextWriter)xtw).QuoteChar = this.QuoteChar;
					xtw.WriteAttributes(this, defattr);
					if (this.IsEmptyElement)
					{
						xtw.WriteEndElement();
					}
					break;
				case XmlNodeType.Text:
					xtw.WriteString(this.Value);
					break;
				case XmlNodeType.CDATA:
					xtw.WriteCData(this.Value);
					break;
				case XmlNodeType.EntityReference:
					xtw.WriteEntityRef(this.Name);
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.XmlDeclaration:
					xtw.WriteProcessingInstruction(this.Name, this.Value);
					break;
				case XmlNodeType.Comment:
					xtw.WriteComment(this.Value);
					break;
				case XmlNodeType.DocumentType:
					xtw.WriteDocType(this.Name, this.GetAttribute("PUBLIC"), this.GetAttribute("SYSTEM"), this.Value);
					break;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					xtw.WriteWhitespace(this.Value);
					break;
				case XmlNodeType.EndElement:
					xtw.WriteFullEndElement();
					break;
				}
			}
			if (num == this.Depth && this.NodeType == XmlNodeType.EndElement)
			{
				this.Read();
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0001F654 File Offset: 0x0001D854
		private void WriteAttributeValue(XmlWriter xtw)
		{
			string name = this.Name;
			while (this.ReadAttributeValue())
			{
				if (this.NodeType == XmlNodeType.EntityReference)
				{
					xtw.WriteEntityRef(this.Name);
				}
				else
				{
					xtw.WriteString(this.Value);
				}
			}
			this.MoveToAttribute(name);
		}

		/// <summary>
		///         Когда переопределено в производном классе, считывает содержимое, включая разметку, представляющую этот узел и все его дочерние узлы.
		///       </summary>
		/// <returns>
		///         Если средство чтения позиционировано на узел элемента или атрибута, данный метод возвращает все содержимое XML текущего узла и всех его дочерних узлов, включая разметку; в противном случае возвращается пустая строка.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             XML-код неверен или произошла ошибка при разборе XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x0600062E RID: 1582 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
		public virtual string ReadOuterXml()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return string.Empty;
			}
			if (this.NodeType != XmlNodeType.Attribute && this.NodeType != XmlNodeType.Element)
			{
				this.Read();
				return string.Empty;
			}
			StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture);
			XmlWriter xmlWriter = this.CreateWriterForInnerOuterXml(stringWriter);
			try
			{
				if (this.NodeType == XmlNodeType.Attribute)
				{
					xmlWriter.WriteStartAttribute(this.Prefix, this.LocalName, this.NamespaceURI);
					this.WriteAttributeValue(xmlWriter);
					xmlWriter.WriteEndAttribute();
				}
				else
				{
					xmlWriter.WriteNode(this, false);
				}
			}
			finally
			{
				xmlWriter.Close();
			}
			return stringWriter.ToString();
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0001F748 File Offset: 0x0001D948
		private XmlWriter CreateWriterForInnerOuterXml(StringWriter sw)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(sw);
			this.SetNamespacesFlag(xmlTextWriter);
			return xmlTextWriter;
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0001F764 File Offset: 0x0001D964
		private void SetNamespacesFlag(XmlTextWriter xtw)
		{
			XmlTextReader xmlTextReader = this as XmlTextReader;
			if (xmlTextReader != null)
			{
				xtw.Namespaces = xmlTextReader.Namespaces;
				return;
			}
			XmlValidatingReader xmlValidatingReader = this as XmlValidatingReader;
			if (xmlValidatingReader != null)
			{
				xtw.Namespaces = xmlValidatingReader.Namespaces;
			}
		}

		/// <summary>
		///         Возвращает новый <see langword="XmlReader" /> экземпляр, который может использоваться для считывания текущего узла и всех его потомков.
		///       </summary>
		/// <returns>
		///         Новый экземпляр средства чтения XML, равным <see cref="F:System.Xml.ReadState.Initial" />.
		///          Вызов <see cref="M:System.Xml.XmlReader.Read" /> метод помещает новый модуль чтения на узел, который был текущим перед вызовом <see cref="M:System.Xml.XmlReader.ReadSubtree" /> метод.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Средство чтения XML не находится на элементе при вызове этого метода.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000631 RID: 1585 RVA: 0x0001F79E File Offset: 0x0001D99E
		public virtual XmlReader ReadSubtree()
		{
			if (this.NodeType != XmlNodeType.Element)
			{
				throw new InvalidOperationException(Res.GetString("ReadSubtree() can be called only if the reader is on an element node."));
			}
			return new XmlSubtreeReader(this);
		}

		/// <summary>
		///         Возвращает значение, показывающее, имеются ли атрибуты у текущего узла.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел содержит атрибуты; в противном случае — значение <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001F7BF File Offset: 0x0001D9BF
		public virtual bool HasAttributes
		{
			get
			{
				return this.AttributeCount > 0;
			}
		}

		/// <summary>
		///         Освобождает все ресурсы, используемые текущим экземпляром класса <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000633 RID: 1587 RVA: 0x0001F7CA File Offset: 0x0001D9CA
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>
		///         Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Xml.XmlReader" />, а при необходимости освобождает также управляемые ресурсы.
		///       </summary>
		/// <param name="disposing">
		///           Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.
		///         </param>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		// Token: 0x06000634 RID: 1588 RVA: 0x0001F7D3 File Offset: 0x0001D9D3
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.ReadState != ReadState.Closed)
			{
				this.Close();
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x0001DA42 File Offset: 0x0001BC42
		internal virtual XmlNamespaceManager NamespaceManager
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0001F7E7 File Offset: 0x0001D9E7
		internal static bool IsTextualNode(XmlNodeType nodeType)
		{
			return ((ulong)XmlReader.IsTextualNodeBitmap & (ulong)(1L << (int)(nodeType & (XmlNodeType)31))) > 0UL;
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0001F7FB File Offset: 0x0001D9FB
		internal static bool CanReadContentAs(XmlNodeType nodeType)
		{
			return ((ulong)XmlReader.CanReadContentAsBitmap & (ulong)(1L << (int)(nodeType & (XmlNodeType)31))) > 0UL;
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0001F80F File Offset: 0x0001DA0F
		internal static bool HasValueInternal(XmlNodeType nodeType)
		{
			return ((ulong)XmlReader.HasValueBitmap & (ulong)(1L << (int)(nodeType & (XmlNodeType)31))) > 0UL;
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0001F824 File Offset: 0x0001DA24
		private bool SkipSubtree()
		{
			this.MoveToElement();
			if (this.NodeType == XmlNodeType.Element && !this.IsEmptyElement)
			{
				int depth = this.Depth;
				while (this.Read() && depth < this.Depth)
				{
				}
				return this.NodeType == XmlNodeType.EndElement && this.Read();
			}
			return this.Read();
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0001F87C File Offset: 0x0001DA7C
		internal void CheckElement(string localName, string namespaceURI)
		{
			if (localName == null || localName.Length == 0)
			{
				throw XmlConvert.CreateInvalidNameArgumentException(localName, "localName");
			}
			if (namespaceURI == null)
			{
				throw new ArgumentNullException("namespaceURI");
			}
			if (this.NodeType != XmlNodeType.Element)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString(), this as IXmlLineInfo);
			}
			if (this.LocalName != localName || this.NamespaceURI != namespaceURI)
			{
				throw new XmlException("Element '{0}' with namespace name '{1}' was not found.", new string[]
				{
					localName,
					namespaceURI
				}, this as IXmlLineInfo);
			}
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0001F917 File Offset: 0x0001DB17
		internal Exception CreateReadContentAsException(string methodName)
		{
			return XmlReader.CreateReadContentAsException(methodName, this.NodeType, this as IXmlLineInfo);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0001F92B File Offset: 0x0001DB2B
		internal Exception CreateReadElementContentAsException(string methodName)
		{
			return XmlReader.CreateReadElementContentAsException(methodName, this.NodeType, this as IXmlLineInfo);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0001F93F File Offset: 0x0001DB3F
		internal bool CanReadContentAs()
		{
			return XmlReader.CanReadContentAs(this.NodeType);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0001F94C File Offset: 0x0001DB4C
		internal static Exception CreateReadContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo)
		{
			string name = "The {0} method is not supported on node type {1}. If you want to read typed content of an element, use the ReadElementContentAs method.";
			object[] args = new string[]
			{
				methodName,
				nodeType.ToString()
			};
			return new InvalidOperationException(XmlReader.AddLineInfo(Res.GetString(name, args), lineInfo));
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0001F98C File Offset: 0x0001DB8C
		internal static Exception CreateReadElementContentAsException(string methodName, XmlNodeType nodeType, IXmlLineInfo lineInfo)
		{
			string name = "The {0} method is not supported on node type {1}.";
			object[] args = new string[]
			{
				methodName,
				nodeType.ToString()
			};
			return new InvalidOperationException(XmlReader.AddLineInfo(Res.GetString(name, args), lineInfo));
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001F9CC File Offset: 0x0001DBCC
		private static string AddLineInfo(string message, IXmlLineInfo lineInfo)
		{
			if (lineInfo != null)
			{
				string[] array = new string[]
				{
					lineInfo.LineNumber.ToString(CultureInfo.InvariantCulture),
					lineInfo.LinePosition.ToString(CultureInfo.InvariantCulture)
				};
				string str = message;
				string str2 = " ";
				string name = "Line {0}, position {1}.";
				object[] args = array;
				message = str + str2 + Res.GetString(name, args);
			}
			return message;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0001FA2C File Offset: 0x0001DC2C
		internal string InternalReadContentAsString()
		{
			string text = string.Empty;
			StringBuilder stringBuilder = null;
			do
			{
				switch (this.NodeType)
				{
				case XmlNodeType.Attribute:
					goto IL_55;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					if (text.Length == 0)
					{
						text = this.Value;
						goto IL_9B;
					}
					if (stringBuilder == null)
					{
						stringBuilder = new StringBuilder();
						stringBuilder.Append(text);
					}
					stringBuilder.Append(this.Value);
					goto IL_9B;
				case XmlNodeType.EntityReference:
					if (this.CanResolveEntity)
					{
						this.ResolveEntity();
						goto IL_9B;
					}
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.Comment:
				case XmlNodeType.EndEntity:
					goto IL_9B;
				}
				break;
				IL_9B:;
			}
			while ((this.AttributeCount != 0) ? this.ReadAttributeValue() : this.Read());
			goto IL_B6;
			IL_55:
			return this.Value;
			IL_B6:
			if (stringBuilder != null)
			{
				return stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0001FAFC File Offset: 0x0001DCFC
		private bool SetupReadElementContentAsXxx(string methodName)
		{
			if (this.NodeType != XmlNodeType.Element)
			{
				throw this.CreateReadElementContentAsException(methodName);
			}
			bool isEmptyElement = this.IsEmptyElement;
			this.Read();
			if (isEmptyElement)
			{
				return false;
			}
			XmlNodeType nodeType = this.NodeType;
			if (nodeType == XmlNodeType.EndElement)
			{
				this.Read();
				return false;
			}
			if (nodeType == XmlNodeType.Element)
			{
				throw new XmlException("ReadElementContentAs() methods cannot be called on an element that has child elements.", string.Empty, this as IXmlLineInfo);
			}
			return true;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001FB5C File Offset: 0x0001DD5C
		private void FinishReadElementContentAsXxx()
		{
			if (this.NodeType != XmlNodeType.EndElement)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString());
			}
			this.Read();
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		internal bool IsDefaultInternal
		{
			get
			{
				if (this.IsDefault)
				{
					return true;
				}
				IXmlSchemaInfo schemaInfo = this.SchemaInfo;
				return schemaInfo != null && schemaInfo.IsDefault;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000645 RID: 1605 RVA: 0x0001DA42 File Offset: 0x0001BC42
		internal virtual IDtdInfo DtdInfo
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0001FBC8 File Offset: 0x0001DDC8
		internal static Encoding GetEncoding(XmlReader reader)
		{
			XmlTextReaderImpl xmlTextReaderImpl = XmlReader.GetXmlTextReaderImpl(reader);
			if (xmlTextReaderImpl == null)
			{
				return null;
			}
			return xmlTextReaderImpl.Encoding;
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0001FBE8 File Offset: 0x0001DDE8
		internal static ConformanceLevel GetV1ConformanceLevel(XmlReader reader)
		{
			XmlTextReaderImpl xmlTextReaderImpl = XmlReader.GetXmlTextReaderImpl(reader);
			if (xmlTextReaderImpl == null)
			{
				return ConformanceLevel.Document;
			}
			return xmlTextReaderImpl.V1ComformanceLevel;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0001FC08 File Offset: 0x0001DE08
		private static XmlTextReaderImpl GetXmlTextReaderImpl(XmlReader reader)
		{
			XmlTextReaderImpl xmlTextReaderImpl = reader as XmlTextReaderImpl;
			if (xmlTextReaderImpl != null)
			{
				return xmlTextReaderImpl;
			}
			XmlTextReader xmlTextReader = reader as XmlTextReader;
			if (xmlTextReader != null)
			{
				return xmlTextReader.Impl;
			}
			XmlValidatingReaderImpl xmlValidatingReaderImpl = reader as XmlValidatingReaderImpl;
			if (xmlValidatingReaderImpl != null)
			{
				return xmlValidatingReaderImpl.ReaderImpl;
			}
			XmlValidatingReader xmlValidatingReader = reader as XmlValidatingReader;
			if (xmlValidatingReader != null)
			{
				return xmlValidatingReader.Impl.ReaderImpl;
			}
			return null;
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с указанным URI.
		///       </summary>
		/// <param name="inputUri">
		///           URI файла с XML-данными.
		///            Класс <see cref="T:System.Xml.XmlUrlResolver" /> используется для преобразования пути к классическому представлению данных.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="inputUri" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Тип <see cref="T:System.Xml.XmlReader" /> не имеет достаточных разрешений для доступа к расположению XML-данных.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Файл, указанный в URI, не существует.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///               Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.FormatException" />.
		///
		///             Неправильный формат URI.
		///           </exception>
		// Token: 0x06000649 RID: 1609 RVA: 0x0001FC5A File Offset: 0x0001DE5A
		public static XmlReader Create(string inputUri)
		{
			return XmlReader.Create(inputUri, null, null);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного URI и параметров.
		///       </summary>
		/// <param name="inputUri">
		///           URI файла с XML-данными.
		///            Объект <see cref="T:System.Xml.XmlResolver" /> в объекте <see cref="T:System.Xml.XmlReaderSettings" /> используется для преобразования пути в каноническое представление данных.
		///            Если <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> равно <see langword="null" />, используется новый объект <see cref="T:System.Xml.XmlUrlResolver" />.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="inputUri" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти файл, заданный с помощью URI.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///               Вместо этого в .NET для приложений Магазина Windows или в переносимой библиотеке классов перехватите исключение базового класса <see cref="T:System.FormatException" />.
		///
		///             Неправильный формат URI.
		///           </exception>
		// Token: 0x0600064A RID: 1610 RVA: 0x0001FC64 File Offset: 0x0001DE64
		public static XmlReader Create(string inputUri, XmlReaderSettings settings)
		{
			return XmlReader.Create(inputUri, settings, null);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с помощью указанного URI, параметров и сведений о контексте для анализа.
		///       </summary>
		/// <param name="inputUri">
		///           URI файла с XML-данными.
		///            Объект <see cref="T:System.Xml.XmlResolver" /> в объекте <see cref="T:System.Xml.XmlReaderSettings" /> используется для преобразования пути в каноническое представление данных.
		///            Если <see cref="P:System.Xml.XmlReaderSettings.XmlResolver" /> равно <see langword="null" />, используется новый объект <see cref="T:System.Xml.XmlUrlResolver" />.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="inputContext">
		///           Для синтаксического анализа фрагмента XML необходимы контекстные сведения.
		///            Контекстные сведения могут содержать используемый класс <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий xml:lang, область xml:space, базовый URI и описание типа документов.
		///
		///           Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <see langword="inputUri" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Тип <see cref="T:System.Xml.XmlReader" /> не имеет достаточных разрешений для доступа к расположению XML-данных.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Свойства <see cref="P:System.Xml.XmlReaderSettings.NameTable" /> и <see cref="P:System.Xml.XmlParserContext.NameTable" /> содержат значения.
		///              (Можно задать и использовать только для одного из этих свойств <see langword="NameTable" />).
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти файл, заданный с помощью URI.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             Неправильный формат URI.
		///           </exception>
		// Token: 0x0600064B RID: 1611 RVA: 0x0001FC6E File Offset: 0x0001DE6E
		public static XmlReader Create(string inputUri, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(inputUri, inputContext);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" />, используя заданный поток с параметрами по умолчанию.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий XML-данные.
		///
		///           <see cref="T:System.Xml.XmlReader" /> просматривает первые байты потока в поисках метки порядка следования байтов или другого признака кодировки.
		///            Эта кодировка после определения используется в последующем считывании потока, а процедура обработки продолжает анализировать входные данные как поток символов Юникода.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.Security.SecurityException">
		///             Тип <see cref="T:System.Xml.XmlReader" /> не имеет достаточных разрешений для доступа к расположению XML-данных.
		///           </exception>
		// Token: 0x0600064C RID: 1612 RVA: 0x0001FC82 File Offset: 0x0001DE82
		public static XmlReader Create(Stream input)
		{
			return XmlReader.Create(input, null, string.Empty);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с указанными потоком и параметрами.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий XML-данные.
		///
		///           <see cref="T:System.Xml.XmlReader" /> просматривает первые байты потока в поисках метки порядка следования байтов или другого признака кодировки.
		///            Эта кодировка после определения используется в последующем считывании потока, а процедура обработки продолжает анализировать входные данные как поток символов Юникода.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x0600064D RID: 1613 RVA: 0x0001FC90 File Offset: 0x0001DE90
		public static XmlReader Create(Stream input, XmlReaderSettings settings)
		{
			return XmlReader.Create(input, settings, string.Empty);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного потока, базового URI и параметров.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий XML-данные.
		///
		///           <see cref="T:System.Xml.XmlReader" /> просматривает первые байты потока в поисках метки порядка следования байтов или другого признака кодировки.
		///            Эта кодировка после определения используется в последующем считывании потока, а процедура обработки продолжает анализировать входные данные как поток символов Юникода.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="baseUri">
		///           Базовый URI считываемой сущности или документа.
		///            Это значение может быть равно <see langword="null" />.
		///
		///           Примечание по безопасности. Базовый универсальный код ресурса (URI) используется для разрешения относительного URI в XML-документе.
		///            Не используйте базовый URI из непроверенного источника.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x0600064E RID: 1614 RVA: 0x0001FC9E File Offset: 0x0001DE9E
		public static XmlReader Create(Stream input, XmlReaderSettings settings, string baseUri)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, null, baseUri, null);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" />, используя заданный поток, параметры и контекстную информацию для анализа.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий XML-данные.
		///
		///           <see cref="T:System.Xml.XmlReader" /> просматривает первые байты потока в поисках метки порядка следования байтов или другого признака кодировки.
		///            Эта кодировка после определения используется в последующем считывании потока, а процедура обработки продолжает анализировать входные данные как поток символов Юникода.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="inputContext">
		///           Для синтаксического анализа фрагмента XML необходимы контекстные сведения.
		///            Контекстные сведения могут содержать используемый класс <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий xml:lang, область xml:space, базовый URI и описание типа документов.
		///
		///           Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x0600064F RID: 1615 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		public static XmlReader Create(Stream input, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, null, string.Empty, inputContext);
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного средства чтения текста.
		///       </summary>
		/// <param name="input">
		///           Средство считывания текста, из которого следует считывать данные XML.
		///            Средство считывания текста возвращает поток символов Юникода, и указанная в объявлении XML кодировка не используется средством считывания XML для раскодирования потока данных.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000650 RID: 1616 RVA: 0x0001FCCE File Offset: 0x0001DECE
		public static XmlReader Create(TextReader input)
		{
			return XmlReader.Create(input, null, string.Empty);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного модуля чтения текста и параметров.
		///       </summary>
		/// <param name="input">
		///           Средство считывания текста, из которого следует считывать данные XML.
		///            Средство считывания текста возвращает поток символов Юникода, и указанная в объявлении XML кодировка не используется средством считывания XML для раскодирования потока данных.
		///         </param>
		/// <param name="settings">
		///           Параметры для нового <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000651 RID: 1617 RVA: 0x0001FCDC File Offset: 0x0001DEDC
		public static XmlReader Create(TextReader input, XmlReaderSettings settings)
		{
			return XmlReader.Create(input, settings, string.Empty);
		}

		/// <summary>
		///         Создает экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного средства чтения текста, параметров и базового кода URI.
		///       </summary>
		/// <param name="input">
		///           Средство считывания текста, из которого следует считывать данные XML.
		///            Средство считывания текста возвращает поток символов Юникода, и указанная в объявлении XML кодировка не используется <see cref="T:System.Xml.XmlReader" /> для декодирования потока данных.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="baseUri">
		///           Базовый URI считываемой сущности или документа.
		///            Это значение может быть равно <see langword="null" />.
		///
		///           Примечание по безопасности. Базовый универсальный код ресурса (URI) используется для разрешения относительного URI в XML-документе.
		///            Не используйте базовый URI из непроверенного источника.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		// Token: 0x06000652 RID: 1618 RVA: 0x0001FCEA File Offset: 0x0001DEEA
		public static XmlReader Create(TextReader input, XmlReaderSettings settings, string baseUri)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, baseUri, null);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" /> с использованием указанного средства чтения текста, параметров и сведений о контексте для анализа.
		///       </summary>
		/// <param name="input">
		///           Средство считывания текста, из которого следует считывать данные XML.
		///            Средство считывания текста возвращает поток символов Юникода, и указанная в объявлении XML кодировка не используется средством считывания XML для раскодирования потока данных.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///            Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <param name="inputContext">
		///           Для синтаксического анализа фрагмента XML необходимы контекстные сведения.
		///            Контекстные сведения могут содержать используемый класс <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий xml:lang, область xml:space, базовый URI и описание типа документов.
		///
		///           Это значение может быть равно <see langword="null" />.
		///         </param>
		/// <returns>
		///         Объект, используемый для чтения данных XML в потоке.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="input" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentException">
		///             Свойства <see cref="P:System.Xml.XmlReaderSettings.NameTable" /> и <see cref="P:System.Xml.XmlParserContext.NameTable" /> содержат значения.
		///              (Только для одного из этих свойств <see langword="NameTable" /> можно задать значение и использовать это свойство).
		///           </exception>
		// Token: 0x06000653 RID: 1619 RVA: 0x0001FCFF File Offset: 0x0001DEFF
		public static XmlReader Create(TextReader input, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(input, string.Empty, inputContext);
		}

		/// <summary>
		///         Создает новый экземпляр <see cref="T:System.Xml.XmlReader" />, используя заданное средство чтения XML и параметры.
		///       </summary>
		/// <param name="reader">
		///           Объект, который следует использовать в качестве базового средства чтения XML.
		///         </param>
		/// <param name="settings">
		///           Параметры нового экземпляра <see cref="T:System.Xml.XmlReader" />.
		///
		///           Уровень согласованности объекта <see cref="T:System.Xml.XmlReaderSettings" /> должен быть равным уровню согласованности базового средства чтения или иметь значение <see cref="F:System.Xml.ConformanceLevel.Auto" />.
		///         </param>
		/// <returns>
		///         Объект, являющийся оболочкой для объекта <see cref="T:System.Xml.XmlReader" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="reader" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Если объект <see cref="T:System.Xml.XmlReaderSettings" /> задает уровень согласованности, который не соответствует уровню согласованности базового средства чтения.
		///
		///             -или-
		///
		///             Базовый <see cref="T:System.Xml.XmlReader" /> находится в состоянии <see cref="F:System.Xml.ReadState.Error" /> или <see cref="F:System.Xml.ReadState.Closed" />.
		///           </exception>
		// Token: 0x06000654 RID: 1620 RVA: 0x0001FD18 File Offset: 0x0001DF18
		public static XmlReader Create(XmlReader reader, XmlReaderSettings settings)
		{
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			return settings.CreateReader(reader);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0001FD2C File Offset: 0x0001DF2C
		internal static XmlReader CreateSqlReader(Stream input, XmlReaderSettings settings, XmlParserContext inputContext)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			if (settings == null)
			{
				settings = new XmlReaderSettings();
			}
			byte[] array = new byte[XmlReader.CalcBufferSize(input)];
			int num = 0;
			int num2;
			do
			{
				num2 = input.Read(array, num, array.Length - num);
				num += num2;
			}
			while (num2 > 0 && num < 2);
			XmlReader xmlReader;
			if (num >= 2 && array[0] == 223 && array[1] == 255)
			{
				if (inputContext != null)
				{
					throw new ArgumentException(Res.GetString("BinaryXml Parser does not support initialization with XmlParserContext."), "inputContext");
				}
				xmlReader = new XmlSqlBinaryReader(input, array, num, string.Empty, settings.CloseInput, settings);
			}
			else
			{
				xmlReader = new XmlTextReaderImpl(input, array, num, settings, null, string.Empty, inputContext, settings.CloseInput);
			}
			if (settings.ValidationType != ValidationType.None)
			{
				xmlReader = settings.AddValidation(xmlReader);
			}
			if (settings.Async)
			{
				xmlReader = XmlAsyncCheckReader.CreateAsyncCheckWrapper(xmlReader);
			}
			return xmlReader;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0001FDF8 File Offset: 0x0001DFF8
		internal static int CalcBufferSize(Stream input)
		{
			int num = 4096;
			if (input.CanSeek)
			{
				long length = input.Length;
				if (length < (long)num)
				{
					num = checked((int)length);
				}
				else if (length > 65536L)
				{
					num = 8192;
				}
			}
			return num;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001FE34 File Offset: 0x0001E034
		private object debuggerDisplayProxy
		{
			get
			{
				return new XmlReader.XmlReaderDebuggerDisplayProxy(this);
			}
		}

		/// <summary>
		///         Асинхронно возвращает значение текущего узла.
		///       </summary>
		/// <returns>
		///         Значение текущего узла.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000658 RID: 1624 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task<string> GetValueAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно считывает содержимое текста в текущей позиции как <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое как самый подходящий объект CLR.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000659 RID: 1625 RVA: 0x0001FE44 File Offset: 0x0001E044
		public virtual Task<object> ReadContentAsObjectAsync()
		{
			XmlReader.<ReadContentAsObjectAsync>d__184 <ReadContentAsObjectAsync>d__;
			<ReadContentAsObjectAsync>d__.<>4__this = this;
			<ReadContentAsObjectAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<ReadContentAsObjectAsync>d__.<>1__state = -1;
			<ReadContentAsObjectAsync>d__.<>t__builder.Start<XmlReader.<ReadContentAsObjectAsync>d__184>(ref <ReadContentAsObjectAsync>d__);
			return <ReadContentAsObjectAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает содержимое текста в текущей позиции как <see cref="T:System.String" /> объект.
		///       </summary>
		/// <returns>
		///         Текстовое содержимое в виде <see cref="T:System.String" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065A RID: 1626 RVA: 0x0001FE87 File Offset: 0x0001E087
		public virtual Task<string> ReadContentAsStringAsync()
		{
			if (!this.CanReadContentAs())
			{
				throw this.CreateReadContentAsException("ReadContentAsString");
			}
			return this.InternalReadContentAsStringAsync();
		}

		/// <summary>
		///         Асинхронно считывает содержимое как объект указанного типа.
		///       </summary>
		/// <param name="returnType">
		///           Тип возвращаемого значения.
		///         </param>
		/// <param name="namespaceResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения любых префиксов пространств имен, имеющих отношение к преобразованию типов.
		///         </param>
		/// <returns>
		///         Объединенное текстовое содержимое или значение атрибута, преобразованное в требуемый тип.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065B RID: 1627 RVA: 0x0001FEA4 File Offset: 0x0001E0A4
		public virtual Task<object> ReadContentAsAsync(Type returnType, IXmlNamespaceResolver namespaceResolver)
		{
			XmlReader.<ReadContentAsAsync>d__186 <ReadContentAsAsync>d__;
			<ReadContentAsAsync>d__.<>4__this = this;
			<ReadContentAsAsync>d__.returnType = returnType;
			<ReadContentAsAsync>d__.namespaceResolver = namespaceResolver;
			<ReadContentAsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<ReadContentAsAsync>d__.<>1__state = -1;
			<ReadContentAsAsync>d__.<>t__builder.Start<XmlReader.<ReadContentAsAsync>d__186>(ref <ReadContentAsAsync>d__);
			return <ReadContentAsAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.Object" />.
		///       </summary>
		/// <returns>
		///         Упакованный объект CLR наиболее подходящего типа.
		///         <see cref="P:System.Xml.XmlReader.ValueType" /> Свойство определяет соответствующий тип среды CLR.
		///          Если содержимое типизировано как тип списка, этот метод возвращает массив упакованных объектов соответствующего типа.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065C RID: 1628 RVA: 0x0001FEF8 File Offset: 0x0001E0F8
		public virtual Task<object> ReadElementContentAsObjectAsync()
		{
			XmlReader.<ReadElementContentAsObjectAsync>d__187 <ReadElementContentAsObjectAsync>d__;
			<ReadElementContentAsObjectAsync>d__.<>4__this = this;
			<ReadElementContentAsObjectAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<ReadElementContentAsObjectAsync>d__.<>1__state = -1;
			<ReadElementContentAsObjectAsync>d__.<>t__builder.Start<XmlReader.<ReadElementContentAsObjectAsync>d__187>(ref <ReadElementContentAsObjectAsync>d__);
			return <ReadElementContentAsObjectAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает текущий элемент и возвращает содержимое в виде <see cref="T:System.String" /> объекта.
		///       </summary>
		/// <returns>
		///         Содержимое элемента в виде <see cref="T:System.String" /> объекта.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065D RID: 1629 RVA: 0x0001FF3C File Offset: 0x0001E13C
		public virtual Task<string> ReadElementContentAsStringAsync()
		{
			XmlReader.<ReadElementContentAsStringAsync>d__188 <ReadElementContentAsStringAsync>d__;
			<ReadElementContentAsStringAsync>d__.<>4__this = this;
			<ReadElementContentAsStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadElementContentAsStringAsync>d__.<>1__state = -1;
			<ReadElementContentAsStringAsync>d__.<>t__builder.Start<XmlReader.<ReadElementContentAsStringAsync>d__188>(ref <ReadElementContentAsStringAsync>d__);
			return <ReadElementContentAsStringAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает содержимое элемента как запрашиваемый тип.
		///       </summary>
		/// <param name="returnType">
		///           Тип возвращаемого значения.
		///         </param>
		/// <param name="namespaceResolver">
		///           Объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения любых префиксов пространств имен, имеющих отношение к преобразованию типов.
		///         </param>
		/// <returns>
		///         Содержимое элемента, преобразованное в требуемый типизированный объект.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065E RID: 1630 RVA: 0x0001FF80 File Offset: 0x0001E180
		public virtual Task<object> ReadElementContentAsAsync(Type returnType, IXmlNamespaceResolver namespaceResolver)
		{
			XmlReader.<ReadElementContentAsAsync>d__189 <ReadElementContentAsAsync>d__;
			<ReadElementContentAsAsync>d__.<>4__this = this;
			<ReadElementContentAsAsync>d__.returnType = returnType;
			<ReadElementContentAsAsync>d__.namespaceResolver = namespaceResolver;
			<ReadElementContentAsAsync>d__.<>t__builder = AsyncTaskMethodBuilder<object>.Create();
			<ReadElementContentAsAsync>d__.<>1__state = -1;
			<ReadElementContentAsAsync>d__.<>t__builder.Start<XmlReader.<ReadElementContentAsAsync>d__189>(ref <ReadElementContentAsAsync>d__);
			return <ReadElementContentAsAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает следующий узел из потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если чтение прошло успешно; значение <see langword="false" />, если отсутствуют узлы для чтения.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x0600065F RID: 1631 RVA: 0x0000349C File Offset: 0x0000169C
		public virtual Task<bool> ReadAsync()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		///         Асинхронно пропускает дочерние узлы текущего узла.
		///       </summary>
		/// <returns>
		///         Текущий узел.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000660 RID: 1632 RVA: 0x0001FFD3 File Offset: 0x0001E1D3
		public virtual Task SkipAsync()
		{
			if (this.ReadState != ReadState.Interactive)
			{
				return AsyncHelper.DoneTask;
			}
			return this.SkipSubtreeAsync();
		}

		/// <summary>
		///         Асинхронно считывает содержимое и возвращает декодированные из кодировки Base64 двоичные байты.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000661 RID: 1633 RVA: 0x0001EBB9 File Offset: 0x0001CDB9
		public virtual Task<int> ReadContentAsBase64Async(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadContentAsBase64"
			}));
		}

		/// <summary>
		///         Асинхронно считывает элемент и расшифровывает содержимое <see langword="Base64" />.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод <see cref="T:System.Xml.XmlReader" /> вызван перед завершением предыдущей асинхронной операции.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Асинхронная операция уже выполняется".
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Асинхронный метод <see cref="T:System.Xml.XmlReader" /> вызван без присваивания флагу <see cref="P:System.Xml.XmlReaderSettings.Async" /> значения <see langword="true" />.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Задайте параметру XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы Async Methods".
		///           </exception>
		// Token: 0x06000662 RID: 1634 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		public virtual Task<int> ReadElementContentAsBase64Async(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadElementContentAsBase64"
			}));
		}

		/// <summary>
		///         Асинхронно считывает содержимое и возвращает <see langword="BinHex" /> раскодированные двоичные байты.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000663 RID: 1635 RVA: 0x0001EBF7 File Offset: 0x0001CDF7
		public virtual Task<int> ReadContentAsBinHexAsync(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadContentAsBinHex"
			}));
		}

		/// <summary>
		///         Асинхронно считывает элемент и раскодирует <see langword="BinHex" /> содержимого.
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
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000664 RID: 1636 RVA: 0x0001EC16 File Offset: 0x0001CE16
		public virtual Task<int> ReadElementContentAsBinHexAsync(byte[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("{0} method is not supported on this XmlReader. Use CanReadBinaryContent property to find out if a reader implements it.", new object[]
			{
				"ReadElementContentAsBinHex"
			}));
		}

		/// <summary>
		///         Асинхронно считывает большие потоки текста, внедренного в XML-документ.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, выполняющий функции буфера, в который записывается текстовое содержимое.
		///            Это значение не может быть равно <see langword="null" />.
		///         </param>
		/// <param name="index">
		///           Смещение в буфере, где <see cref="T:System.Xml.XmlReader" /> может начать копировать результаты.
		///         </param>
		/// <param name="count">
		///           Максимальное количество копируемых в буфер символов.
		///            Этот метод возвращает фактическое количество скопированных символов.
		///         </param>
		/// <returns>
		///         Количество символов, считанных в буфер.
		///          По окончании текстового содержимого возвращается нуль.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000665 RID: 1637 RVA: 0x0001EC35 File Offset: 0x0001CE35
		public virtual Task<int> ReadValueChunkAsync(char[] buffer, int index, int count)
		{
			throw new NotSupportedException(Res.GetString("ReadValueChunk method is not supported on this XmlReader. Use CanReadValueChunk property to find out if an XmlReader implements it."));
		}

		/// <summary>
		///         В асинхронном режиме проверяет, является ли текущий узел узлом содержимого.
		///          Если узел не является узлом содержимого, средство чтения пропускает этот узел и переходит к следующему узлу содержимого или в конец файла.
		///       </summary>
		/// <returns>
		///         Значение <see cref="P:System.Xml.XmlReader.NodeType" /> для текущего узла, найденного с помощью метода, или значение <see langword="XmlNodeType.None" />, если средство чтения достигло конца потока входных данных.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Метод <see cref="T:System.Xml.XmlReader" /> вызван перед завершением предыдущей асинхронной операции.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Асинхронная операция уже выполняется".
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Асинхронный метод <see cref="T:System.Xml.XmlReader" /> вызван без присваивания флагу <see cref="P:System.Xml.XmlReaderSettings.Async" /> значения <see langword="true" />.
		///              В этом случае возникает исключение <see cref="T:System.InvalidOperationException" /> с сообщением "Задайте параметру XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы Async Methods".
		///           </exception>
		// Token: 0x06000666 RID: 1638 RVA: 0x0001FFEC File Offset: 0x0001E1EC
		public virtual Task<XmlNodeType> MoveToContentAsync()
		{
			XmlReader.<MoveToContentAsync>d__197 <MoveToContentAsync>d__;
			<MoveToContentAsync>d__.<>4__this = this;
			<MoveToContentAsync>d__.<>t__builder = AsyncTaskMethodBuilder<XmlNodeType>.Create();
			<MoveToContentAsync>d__.<>1__state = -1;
			<MoveToContentAsync>d__.<>t__builder.Start<XmlReader.<MoveToContentAsync>d__197>(ref <MoveToContentAsync>d__);
			return <MoveToContentAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает в виде строки все содержимое, включая разметку.
		///       </summary>
		/// <returns>
		///         Все содержимое XML-кода в текущем узле, включая разметку.
		///          Если текущий узел не имеет дочерних узлов, возвращается пустая строка.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000667 RID: 1639 RVA: 0x00020030 File Offset: 0x0001E230
		public virtual Task<string> ReadInnerXmlAsync()
		{
			XmlReader.<ReadInnerXmlAsync>d__198 <ReadInnerXmlAsync>d__;
			<ReadInnerXmlAsync>d__.<>4__this = this;
			<ReadInnerXmlAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadInnerXmlAsync>d__.<>1__state = -1;
			<ReadInnerXmlAsync>d__.<>t__builder.Start<XmlReader.<ReadInnerXmlAsync>d__198>(ref <ReadInnerXmlAsync>d__);
			return <ReadInnerXmlAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00020074 File Offset: 0x0001E274
		private Task WriteNodeAsync(XmlWriter xtw, bool defattr)
		{
			XmlReader.<WriteNodeAsync>d__199 <WriteNodeAsync>d__;
			<WriteNodeAsync>d__.<>4__this = this;
			<WriteNodeAsync>d__.xtw = xtw;
			<WriteNodeAsync>d__.defattr = defattr;
			<WriteNodeAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<WriteNodeAsync>d__.<>1__state = -1;
			<WriteNodeAsync>d__.<>t__builder.Start<XmlReader.<WriteNodeAsync>d__199>(ref <WriteNodeAsync>d__);
			return <WriteNodeAsync>d__.<>t__builder.Task;
		}

		/// <summary>
		///         Асинхронно считывает содержимое, включая разметку, представляющее этот узел и все его дочерние узлы.
		///       </summary>
		/// <returns>
		///         Если средство чтения позиционировано на узел элемента или атрибута, данный метод возвращает все содержимое XML текущего узла и всех его дочерних узлов, включая разметку; в противном случае возвращается пустая строка.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Метод был вызван до завершения предыдущей асинхронной операции.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «асинхронная операция уже выполняется.»
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             <see cref="T:System.Xml.XmlReader" /> Асинхронный метод был вызван без параметра <see cref="P:System.Xml.XmlReaderSettings.Async" /> флаг <see langword="true" />.
		///              В этом случае <see cref="T:System.InvalidOperationException" /> исключение с сообщением «Set XmlReaderSettings.Async значение true, если вы хотите использовать асинхронные методы».
		///           </exception>
		// Token: 0x06000669 RID: 1641 RVA: 0x000200C8 File Offset: 0x0001E2C8
		public virtual Task<string> ReadOuterXmlAsync()
		{
			XmlReader.<ReadOuterXmlAsync>d__200 <ReadOuterXmlAsync>d__;
			<ReadOuterXmlAsync>d__.<>4__this = this;
			<ReadOuterXmlAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<ReadOuterXmlAsync>d__.<>1__state = -1;
			<ReadOuterXmlAsync>d__.<>t__builder.Start<XmlReader.<ReadOuterXmlAsync>d__200>(ref <ReadOuterXmlAsync>d__);
			return <ReadOuterXmlAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0002010C File Offset: 0x0001E30C
		private Task<bool> SkipSubtreeAsync()
		{
			XmlReader.<SkipSubtreeAsync>d__201 <SkipSubtreeAsync>d__;
			<SkipSubtreeAsync>d__.<>4__this = this;
			<SkipSubtreeAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SkipSubtreeAsync>d__.<>1__state = -1;
			<SkipSubtreeAsync>d__.<>t__builder.Start<XmlReader.<SkipSubtreeAsync>d__201>(ref <SkipSubtreeAsync>d__);
			return <SkipSubtreeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00020150 File Offset: 0x0001E350
		internal Task<string> InternalReadContentAsStringAsync()
		{
			XmlReader.<InternalReadContentAsStringAsync>d__202 <InternalReadContentAsStringAsync>d__;
			<InternalReadContentAsStringAsync>d__.<>4__this = this;
			<InternalReadContentAsStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<InternalReadContentAsStringAsync>d__.<>1__state = -1;
			<InternalReadContentAsStringAsync>d__.<>t__builder.Start<XmlReader.<InternalReadContentAsStringAsync>d__202>(ref <InternalReadContentAsStringAsync>d__);
			return <InternalReadContentAsStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00020194 File Offset: 0x0001E394
		private Task<bool> SetupReadElementContentAsXxxAsync(string methodName)
		{
			XmlReader.<SetupReadElementContentAsXxxAsync>d__203 <SetupReadElementContentAsXxxAsync>d__;
			<SetupReadElementContentAsXxxAsync>d__.<>4__this = this;
			<SetupReadElementContentAsXxxAsync>d__.methodName = methodName;
			<SetupReadElementContentAsXxxAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SetupReadElementContentAsXxxAsync>d__.<>1__state = -1;
			<SetupReadElementContentAsXxxAsync>d__.<>t__builder.Start<XmlReader.<SetupReadElementContentAsXxxAsync>d__203>(ref <SetupReadElementContentAsXxxAsync>d__);
			return <SetupReadElementContentAsXxxAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x000201E0 File Offset: 0x0001E3E0
		private Task FinishReadElementContentAsXxxAsync()
		{
			if (this.NodeType != XmlNodeType.EndElement)
			{
				throw new XmlException("'{0}' is an invalid XmlNodeType.", this.NodeType.ToString());
			}
			return this.ReadAsync();
		}

		// Token: 0x0400083C RID: 2108
		private static uint IsTextualNodeBitmap = 24600U;

		// Token: 0x0400083D RID: 2109
		private static uint CanReadContentAsBitmap = 123324U;

		// Token: 0x0400083E RID: 2110
		private static uint HasValueBitmap = 157084U;

		// Token: 0x0400083F RID: 2111
		internal const int DefaultBufferSize = 4096;

		// Token: 0x04000840 RID: 2112
		internal const int BiggerBufferSize = 8192;

		// Token: 0x04000841 RID: 2113
		internal const int MaxStreamLengthForDefaultBufferSize = 65536;

		// Token: 0x04000842 RID: 2114
		internal const int AsyncBufferSize = 65536;

		// Token: 0x0200009C RID: 156
		[DebuggerDisplay("{ToString()}")]
		private struct XmlReaderDebuggerDisplayProxy
		{
			// Token: 0x06000670 RID: 1648 RVA: 0x0002023C File Offset: 0x0001E43C
			internal XmlReaderDebuggerDisplayProxy(XmlReader reader)
			{
				this.reader = reader;
			}

			// Token: 0x06000671 RID: 1649 RVA: 0x00020248 File Offset: 0x0001E448
			public override string ToString()
			{
				XmlNodeType nodeType = this.reader.NodeType;
				string text = nodeType.ToString();
				switch (nodeType)
				{
				case XmlNodeType.Element:
				case XmlNodeType.EntityReference:
				case XmlNodeType.EndElement:
				case XmlNodeType.EndEntity:
					text = text + ", Name=\"" + this.reader.Name + "\"";
					break;
				case XmlNodeType.Attribute:
				case XmlNodeType.ProcessingInstruction:
					text = string.Concat(new string[]
					{
						text,
						", Name=\"",
						this.reader.Name,
						"\", Value=\"",
						XmlConvert.EscapeValueForDebuggerDisplay(this.reader.Value),
						"\""
					});
					break;
				case XmlNodeType.Text:
				case XmlNodeType.CDATA:
				case XmlNodeType.Comment:
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
				case XmlNodeType.XmlDeclaration:
					text = text + ", Value=\"" + XmlConvert.EscapeValueForDebuggerDisplay(this.reader.Value) + "\"";
					break;
				case XmlNodeType.DocumentType:
					text = text + ", Name=\"" + this.reader.Name + "'";
					text = text + ", SYSTEM=\"" + this.reader.GetAttribute("SYSTEM") + "\"";
					text = text + ", PUBLIC=\"" + this.reader.GetAttribute("PUBLIC") + "\"";
					text = text + ", Value=\"" + XmlConvert.EscapeValueForDebuggerDisplay(this.reader.Value) + "\"";
					break;
				}
				return text;
			}

			// Token: 0x04000843 RID: 2115
			private XmlReader reader;
		}
	}
}
