using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Security.Permissions;
using System.Text;

namespace System.Xml
{
	/// <summary>
	///         Предоставляет средство чтения, обеспечивающее быстрый прямой доступ (без кэширования) к данным XML.
	///
	///         Начиная с .NET Framework версии 2.0 рекомендуется использовать класс <see cref="T:System.Xml.XmlReader" />.
	///       </summary>
	// Token: 0x020000BB RID: 187
	[EditorBrowsable(EditorBrowsableState.Never)]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	public class XmlTextReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlTextReader" />.
		///       </summary>
		// Token: 0x06000744 RID: 1860 RVA: 0x000268C5 File Offset: 0x00024AC5
		protected XmlTextReader()
		{
			this.impl = new XmlTextReaderImpl();
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> указанным значением <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		// Token: 0x06000745 RID: 1861 RVA: 0x000268E4 File Offset: 0x00024AE4
		protected XmlTextReader(XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным потоком.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий считываемые XML-данные.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="input" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000746 RID: 1862 RVA: 0x00026904 File Offset: 0x00024B04
		public XmlTextReader(Stream input)
		{
			this.impl = new XmlTextReaderImpl(input);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным URL-адресом и потоком.
		///       </summary>
		/// <param name="url">
		///           URL-адрес, используемый для разрешения внешних ресурсов.
		///            Для свойства <see cref="P:System.Xml.XmlTextReader.BaseURI" /> задано это значение.
		///         </param>
		/// <param name="input">
		///           Поток, содержащий считываемые XML-данные.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="input" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000747 RID: 1863 RVA: 0x00026924 File Offset: 0x00024B24
		public XmlTextReader(string url, Stream input)
		{
			this.impl = new XmlTextReaderImpl(url, input);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанными потоком и <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="input">
		///           Поток, содержащий считываемые XML-данные.
		///         </param>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.NullReferenceException">
		///             <paramref name="input" /> Или <paramref name="nt" /> значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000748 RID: 1864 RVA: 0x00026945 File Offset: 0x00024B45
		public XmlTextReader(Stream input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанными URL-адресом, потоком и <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="url">
		///           URL-адрес, используемый для разрешения внешних ресурсов.
		///            Для свойства <see cref="P:System.Xml.XmlTextReader.BaseURI" /> задано это значение.
		///            Если значение <paramref name="url" /> равно <see langword="null" />, то <see langword="BaseURI" /> присваивается значение <see langword="String.Empty" />.
		///         </param>
		/// <param name="input">
		///           Поток, содержащий считываемые XML-данные.
		///         </param>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.NullReferenceException">
		///             <paramref name="input" /> Или <paramref name="nt" /> значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000749 RID: 1865 RVA: 0x00026966 File Offset: 0x00024B66
		public XmlTextReader(string url, Stream input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(url, input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> указанным значением <see cref="T:System.IO.TextReader" />.
		///       </summary>
		/// <param name="input">
		///           <see langword="TextReader" />, содержащий считываемые XML-данные.
		///         </param>
		// Token: 0x0600074A RID: 1866 RVA: 0x00026988 File Offset: 0x00024B88
		public XmlTextReader(TextReader input)
		{
			this.impl = new XmlTextReaderImpl(input);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным URL-адресом и <see cref="T:System.IO.TextReader" />.
		///       </summary>
		/// <param name="url">
		///           URL-адрес, используемый для разрешения внешних ресурсов.
		///            Для свойства <see cref="P:System.Xml.XmlTextReader.BaseURI" /> задано это значение.
		///         </param>
		/// <param name="input">
		///           <see langword="TextReader" />, содержащий считываемые XML-данные.
		///         </param>
		// Token: 0x0600074B RID: 1867 RVA: 0x000269A8 File Offset: 0x00024BA8
		public XmlTextReader(string url, TextReader input)
		{
			this.impl = new XmlTextReaderImpl(url, input);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с заданными свойствами <see cref="T:System.IO.TextReader" /> и <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="input">
		///           <see langword="TextReader" />, содержащий считываемые XML-данные.
		///         </param>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.NullReferenceException">
		///             <paramref name="nt" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x0600074C RID: 1868 RVA: 0x000269C9 File Offset: 0x00024BC9
		public XmlTextReader(TextReader input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным URL-адресом, <see cref="T:System.IO.TextReader" /> и <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="url">
		///           URL-адрес, используемый для разрешения внешних ресурсов.
		///            Для свойства <see cref="P:System.Xml.XmlTextReader.BaseURI" /> задано это значение.
		///            Если значение <paramref name="url" /> равно <see langword="null" />, то <see langword="BaseURI" /> присваивается значение <see langword="String.Empty" />.
		///         </param>
		/// <param name="input">
		///           <see langword="TextReader" />, содержащий считываемые XML-данные.
		///         </param>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.ArgumentNullException">
		///             <paramref name="nt" /> Значение — <see langword="null" />.
		///           </exception>
		// Token: 0x0600074D RID: 1869 RVA: 0x000269EA File Offset: 0x00024BEA
		public XmlTextReader(string url, TextReader input, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(url, input, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанными потоком, <see cref="T:System.Xml.XmlNodeType" /> и <see cref="T:System.Xml.XmlParserContext" />.
		///       </summary>
		/// <param name="xmlFragment">
		///           Поток, содержащий анализируемый фрагмент XML.
		///         </param>
		/// <param name="fragType">
		///           Тип <see cref="T:System.Xml.XmlNodeType" /> фрагмента XML.
		///            Также определяет содержимое фрагмента.
		///            (См. таблицу, приведенную ниже.)
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.XmlParserContext" />, в котором анализируется <paramref name="xmlFragment" />.
		///            Это включает в себя используемый <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий xml:lang и область xml:space.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="fragType" /> не является элемент, атрибут или документа <see langword="XmlNodeType" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="xmlFragment" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600074E RID: 1870 RVA: 0x00026A0C File Offset: 0x00024C0C
		public XmlTextReader(Stream xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			this.impl = new XmlTextReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанной строкой, <see cref="T:System.Xml.XmlNodeType" /> и <see cref="T:System.Xml.XmlParserContext" />.
		///       </summary>
		/// <param name="xmlFragment">
		///           Строка, содержащая анализируемый фрагмент XML.
		///         </param>
		/// <param name="fragType">
		///           Тип <see cref="T:System.Xml.XmlNodeType" /> фрагмента XML.
		///            Также определяет содержимое строки фрагмента.
		///            (См. таблицу, приведенную ниже.)
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.XmlParserContext" />, в котором анализируется <paramref name="xmlFragment" />.
		///            Это включает в себя используемый <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий xml:lang и область xml:space.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="fragType" /> не <see langword="Element" />, <see langword="Attribute" />, или <see langword="Document" /><see langword="XmlNodeType" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Свойство <paramref name="xmlFragment" /> имеет значение <see langword="null" />.
		///           </exception>
		// Token: 0x0600074F RID: 1871 RVA: 0x00026A2E File Offset: 0x00024C2E
		public XmlTextReader(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			this.impl = new XmlTextReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным файлом.
		///       </summary>
		/// <param name="url">
		///           URL-адрес файла с XML-данными.
		///            Для свойства <see cref="P:System.Xml.XmlTextReader.BaseURI" /> задано это значение.
		///         </param>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти указанный файл.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             Не удалось найти часть файла или каталога.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Параметр <paramref name="url" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             Удаленное имя файла не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="url" /> не является допустимым URI.
		///           </exception>
		// Token: 0x06000750 RID: 1872 RVA: 0x00026A50 File Offset: 0x00024C50
		public XmlTextReader(string url)
		{
			this.impl = new XmlTextReaderImpl(url, new NameTable());
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.XmlTextReader" /> с указанным файлом и <see cref="T:System.Xml.XmlNameTable" />.
		///       </summary>
		/// <param name="url">
		///           URL-адрес файла, содержащего считываемые данные XML.
		///         </param>
		/// <param name="nt">
		///           Используемый <see langword="XmlNameTable" />.
		///         </param>
		/// <exception cref="T:System.NullReferenceException">
		///             <paramref name="nt" /> Значение — <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.IO.FileNotFoundException">
		///             Не удается найти указанный файл.
		///           </exception>
		/// <exception cref="T:System.IO.DirectoryNotFoundException">
		///             Не удалось найти часть файла или каталога.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Параметр <paramref name="url" /> равен пустой строке.
		///           </exception>
		/// <exception cref="T:System.Net.WebException">
		///             Удаленное имя файла не может быть разрешена.
		///
		///             -или-
		///
		///             При обработке этого запроса возникла ошибка.
		///           </exception>
		/// <exception cref="T:System.UriFormatException">
		///             <paramref name="url" /> не является допустимым URI.
		///           </exception>
		// Token: 0x06000751 RID: 1873 RVA: 0x00026A75 File Offset: 0x00024C75
		public XmlTextReader(string url, XmlNameTable nt)
		{
			this.impl = new XmlTextReaderImpl(url, nt);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlNodeType" />, предоставляющее тип текущего узла.
		///       </returns>
		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000752 RID: 1874 RVA: 0x00026A96 File Offset: 0x00024C96
		public override XmlNodeType NodeType
		{
			get
			{
				return this.impl.NodeType;
			}
		}

		/// <summary>
		///         Возвращает полное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Полное имя текущего узла.
		///          Например, <see langword="Name" /> имеет значение <see langword="bk:book" /> для элемента &lt;bk:book&gt;.
		///
		///         Возвращаемое имя зависит от значения свойства <see cref="P:System.Xml.XmlTextReader.NodeType" /> узла.
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
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00026AA3 File Offset: 0x00024CA3
		public override string Name
		{
			get
			{
				return this.impl.Name;
			}
		}

		/// <summary>
		///         Возвращает локальное имя текущего узла.
		///       </summary>
		/// <returns>
		///         Имя текущего узла с удаленным префиксом.
		///          Например, <see langword="LocalName" /> имеет значение <see langword="book" /> для элемента &lt;bk:book&gt;.
		///
		///         Для безымянных типов узлов (например, <see langword="Text" />, <see langword="Comment" /> и т. д.) данное свойство возвращает <see langword="String.Empty" />.
		///       </returns>
		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00026AB0 File Offset: 0x00024CB0
		public override string LocalName
		{
			get
			{
				return this.impl.LocalName;
			}
		}

		/// <summary>
		///         Возвращает URI пространства имен (определенное в спецификации W3C Namespace) узла, на который позиционировано средство чтения.
		///       </summary>
		/// <returns>
		///         URI пространства имен текущего узла; в противном случае — пустая строка.
		///       </returns>
		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00026ABD File Offset: 0x00024CBD
		public override string NamespaceURI
		{
			get
			{
				return this.impl.NamespaceURI;
			}
		}

		/// <summary>
		///         Возвращает префикс пространства имен, связанный с текущим узлом.
		///       </summary>
		/// <returns>
		///         Префикс пространства имен, связанный с текущим узлом.
		///       </returns>
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00026ACA File Offset: 0x00024CCA
		public override string Prefix
		{
			get
			{
				return this.impl.Prefix;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющие наличие у текущего узла свойства <see cref="P:System.Xml.XmlTextReader.Value" />, значение которого отличается от <see langword="String.Empty" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если узел, на котором расположено средство чтения, может иметь значение <see langword="Value" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00026AD7 File Offset: 0x00024CD7
		public override bool HasValue
		{
			get
			{
				return this.impl.HasValue;
			}
		}

		/// <summary>
		///         Возвращает текстовое значение текущего узла.
		///       </summary>
		/// <returns>
		///         Возвращаемое значение зависит от значения свойства <see cref="P:System.Xml.XmlTextReader.NodeType" /> узла.
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
		///                 Пробел в <see langword="xml:space" />= 'preserve' области.
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
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x00026AE4 File Offset: 0x00024CE4
		public override string Value
		{
			get
			{
				return this.impl.Value;
			}
		}

		/// <summary>
		///         Возвращает глубину текущего узла в XML-документе.
		///       </summary>
		/// <returns>
		///         Глубина текущего узла в XML-документе.
		///       </returns>
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x00026AF1 File Offset: 0x00024CF1
		public override int Depth
		{
			get
			{
				return this.impl.Depth;
			}
		}

		/// <summary>
		///         Возвращает базовый URI текущего узла.
		///       </summary>
		/// <returns>
		///         Базовый URI текущего узла.
		///       </returns>
		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x00026AFE File Offset: 0x00024CFE
		public override string BaseURI
		{
			get
			{
				return this.impl.BaseURI;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли текущий узел пустым элементом (например, &lt;MyElement/&gt;).
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел является элементом (свойство <see cref="P:System.Xml.XmlTextReader.NodeType" /> имеет значение <see langword="XmlNodeType.Element" />), который заканчивается на /&gt;; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x00026B0B File Offset: 0x00024D0B
		public override bool IsEmptyElement
		{
			get
			{
				return this.impl.IsEmptyElement;
			}
		}

		/// <summary>
		///         Возвращает значение, показывающее, является ли текущий узел атрибутом, который был создан из значения по умолчанию, определенного в определении DTD или в схеме.
		///       </summary>
		/// <returns>
		///         Данное свойство всегда возвращает значение <see langword="false" />.
		///          (<see cref="T:System.Xml.XmlTextReader" /> не расширяет атрибуты по умолчанию).
		///       </returns>
		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00026B18 File Offset: 0x00024D18
		public override bool IsDefault
		{
			get
			{
				return this.impl.IsDefault;
			}
		}

		/// <summary>
		///         Возвращает знак кавычек, используемый для выделения значения узла атрибута.
		///       </summary>
		/// <returns>
		///         Знак кавычек (" или ') для выделения значения узла атрибута.
		///       </returns>
		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00026B25 File Offset: 0x00024D25
		public override char QuoteChar
		{
			get
			{
				return this.impl.QuoteChar;
			}
		}

		/// <summary>
		///         Возвращает текущую область действия <see langword="xml:space" />.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlSpace" />.
		///          Если область действия <see langword="xml:space" /> отсутствует, данное свойство принимает значение <see langword="XmlSpace.None" />.
		///       </returns>
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00026B32 File Offset: 0x00024D32
		public override XmlSpace XmlSpace
		{
			get
			{
				return this.impl.XmlSpace;
			}
		}

		/// <summary>
		///         Возвращает текущую область действия <see langword="xml:lang" />.
		///       </summary>
		/// <returns>
		///         Текущая область действия <see langword="xml:lang" />.
		///       </returns>
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00026B3F File Offset: 0x00024D3F
		public override string XmlLang
		{
			get
			{
				return this.impl.XmlLang;
			}
		}

		/// <summary>
		///         Возвращает количество атрибутов текущего узла.
		///       </summary>
		/// <returns>
		///         Количество атрибутов текущего узла.
		///       </returns>
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00026B4C File Offset: 0x00024D4C
		public override int AttributeCount
		{
			get
			{
				return this.impl.AttributeCount;
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
		// Token: 0x06000761 RID: 1889 RVA: 0x00026B59 File Offset: 0x00024D59
		public override string GetAttribute(string name)
		{
			return this.impl.GetAttribute(name);
		}

		/// <summary>
		///         Возвращает значение атрибута с указанным локальным именем и универсальным кодом ресурса (URI) пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///          Если атрибут не найден, возвращается значение <see langword="null" />.
		///          Этот метод не изменяет позицию средства чтения.
		///       </returns>
		// Token: 0x06000762 RID: 1890 RVA: 0x00026B67 File Offset: 0x00024D67
		public override string GetAttribute(string localName, string namespaceURI)
		{
			return this.impl.GetAttribute(localName, namespaceURI);
		}

		/// <summary>
		///         Возвращает значение атрибута по заданному индексу.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///            Индексация начинается с нуля.
		///            (Индекс первого атрибута равен нулю.)
		///         </param>
		/// <returns>
		///         Значение указанного атрибута.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="i" /> Параметр меньше 0 или больше или равно <see cref="P:System.Xml.XmlTextReader.AttributeCount" />.
		///           </exception>
		// Token: 0x06000763 RID: 1891 RVA: 0x00026B76 File Offset: 0x00024D76
		public override string GetAttribute(int i)
		{
			return this.impl.GetAttribute(i);
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
		// Token: 0x06000764 RID: 1892 RVA: 0x00026B84 File Offset: 0x00024D84
		public override bool MoveToAttribute(string name)
		{
			return this.impl.MoveToAttribute(name);
		}

		/// <summary>
		///         Переходит к атрибуту с указанным локальным именем и URI пространства имен.
		///       </summary>
		/// <param name="localName">
		///           Локальное имя атрибута.
		///         </param>
		/// <param name="namespaceURI">
		///           Универсальный код ресурса (URI) пространства имен атрибута.
		///         </param>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут найден; в противном случае — <see langword="false" />.
		///          Если значение <see langword="false" />, позиция средства чтения не изменяется.
		///       </returns>
		// Token: 0x06000765 RID: 1893 RVA: 0x00026B92 File Offset: 0x00024D92
		public override bool MoveToAttribute(string localName, string namespaceURI)
		{
			return this.impl.MoveToAttribute(localName, namespaceURI);
		}

		/// <summary>
		///         Переходит к атрибуту с указанным индексом.
		///       </summary>
		/// <param name="i">
		///           Индекс атрибута.
		///         </param>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="i" /> Параметр меньше 0 или больше или равно <see cref="P:System.Xml.XmlReader.AttributeCount" />.
		///           </exception>
		// Token: 0x06000766 RID: 1894 RVA: 0x00026BA1 File Offset: 0x00024DA1
		public override void MoveToAttribute(int i)
		{
			this.impl.MoveToAttribute(i);
		}

		/// <summary>
		///         Переходит к первому атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если атрибут существует (средство чтения перемещается к первому атрибуту); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		// Token: 0x06000767 RID: 1895 RVA: 0x00026BAF File Offset: 0x00024DAF
		public override bool MoveToFirstAttribute()
		{
			return this.impl.MoveToFirstAttribute();
		}

		/// <summary>
		///         Переходит к следующему атрибуту.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствует следующий атрибут; значение <see langword="false" />, если другие атрибуты отсутствуют.
		///       </returns>
		// Token: 0x06000768 RID: 1896 RVA: 0x00026BBC File Offset: 0x00024DBC
		public override bool MoveToNextAttribute()
		{
			return this.impl.MoveToNextAttribute();
		}

		/// <summary>
		///         Переходит к элементу, содержащему текущий узел атрибута.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения находится на атрибуте (средство чтения перемещается к элементу с этим атрибутом); в противном случае — <see langword="false" /> (позиция средства чтения не изменяется).
		///       </returns>
		// Token: 0x06000769 RID: 1897 RVA: 0x00026BC9 File Offset: 0x00024DC9
		public override bool MoveToElement()
		{
			return this.impl.MoveToElement();
		}

		/// <summary>
		///         Разбирает значение атрибута в один или несколько узлов <see langword="Text" />, <see langword="EntityReference" /> или <see langword="EndEntity" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если присутствуют возвращаемые узлы.
		///
		///         Значение <see langword="false" />, если средство чтения не расположено на узле атрибута при первом вызове или все значения атрибута считаны.
		///
		///         Пустой атрибут (например, misc="") возвращает значение <see langword="true" /> с отдельным узлом, имеющим значение <see langword="String.Empty" />.
		///       </returns>
		// Token: 0x0600076A RID: 1898 RVA: 0x00026BD6 File Offset: 0x00024DD6
		public override bool ReadAttributeValue()
		{
			return this.impl.ReadAttributeValue();
		}

		/// <summary>
		///         Считывает следующий узел из потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если чтение прошло успешно; значение <see langword="false" />, если отсутствуют узлы для чтения.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка при разборе XML.
		///           </exception>
		// Token: 0x0600076B RID: 1899 RVA: 0x00026BE3 File Offset: 0x00024DE3
		public override bool Read()
		{
			return this.impl.Read();
		}

		/// <summary>
		///         Возвращает значение, определяющее, позиционировано ли средство чтения в конец потока.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения установлено в конец потока; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x00026BF0 File Offset: 0x00024DF0
		public override bool EOF
		{
			get
			{
				return this.impl.EOF;
			}
		}

		/// <summary>
		///         Изменяет значение свойства <see cref="P:System.Xml.XmlReader.ReadState" /> на <see langword="Closed" />.
		///       </summary>
		// Token: 0x0600076D RID: 1901 RVA: 0x00026BFD File Offset: 0x00024DFD
		public override void Close()
		{
			this.impl.Close();
		}

		/// <summary>
		///         Возвращает состояние средства чтения.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.ReadState" />.
		///       </returns>
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600076E RID: 1902 RVA: 0x00026C0A File Offset: 0x00024E0A
		public override ReadState ReadState
		{
			get
			{
				return this.impl.ReadState;
			}
		}

		/// <summary>
		///         Пропускает дочерний узел текущего узла.
		///       </summary>
		// Token: 0x0600076F RID: 1903 RVA: 0x00026C17 File Offset: 0x00024E17
		public override void Skip()
		{
			this.impl.Skip();
		}

		/// <summary>
		///         Возвращает класс <see cref="T:System.Xml.XmlNameTable" />, связанный с данной реализацией.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNameTable" />, позволяющий получать в узле разделенную версию строки.
		///       </returns>
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00026C24 File Offset: 0x00024E24
		public override XmlNameTable NameTable
		{
			get
			{
				return this.impl.NameTable;
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
		/// <exception cref="T:System.ArgumentNullException">
		///             <see cref="P:System.Xml.XmlTextReader.Namespaces" /> Свойству <see langword="true" /> и <paramref name="prefix" /> значение <see langword="null" />.
		///           </exception>
		// Token: 0x06000771 RID: 1905 RVA: 0x00026C34 File Offset: 0x00024E34
		public override string LookupNamespace(string prefix)
		{
			string text = this.impl.LookupNamespace(prefix);
			if (text != null && text.Length == 0)
			{
				text = null;
			}
			return text;
		}

		/// <summary>
		///         Возвращает значение, определяющее, способно ли данное средство чтения выполнять синтаксический анализ и разрешение сущностей.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если средство чтения позволяет анализировать и разрешать сущности; в противном случае — <see langword="false" />.
		///          Класс <see langword="XmlTextReader" /> всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000772 RID: 1906 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool CanResolveEntity
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Разрешает ссылки на сущности для узлов <see langword="EntityReference" />.
		///       </summary>
		// Token: 0x06000773 RID: 1907 RVA: 0x00026C5C File Offset: 0x00024E5C
		public override void ResolveEntity()
		{
			this.impl.ResolveEntity();
		}

		/// <summary>
		///         Получает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlTextReader" /> методы чтения двоичного содержимого.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если реализуются методы чтения двоичного содержимого; в противном случае — <see langword="false" />.
		///          Класс <see cref="T:System.Xml.XmlTextReader" /> всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001222F File Offset: 0x0001042F
		public override bool CanReadBinaryContent
		{
			get
			{
				return true;
			}
		}

		/// <summary>
		///         Считывает содержимое и возвращает раскодированные двоичные байты <see langword="Base64" />.
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
		///             <see cref="M:System.Xml.XmlTextReader.ReadContentAsBase64(System.Byte[],System.Int32,System.Int32)" />  не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		// Token: 0x06000775 RID: 1909 RVA: 0x00026C69 File Offset: 0x00024E69
		public override int ReadContentAsBase64(byte[] buffer, int index, int count)
		{
			return this.impl.ReadContentAsBase64(buffer, index, count);
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
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlTextReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		// Token: 0x06000776 RID: 1910 RVA: 0x00026C79 File Offset: 0x00024E79
		public override int ReadElementContentAsBase64(byte[] buffer, int index, int count)
		{
			return this.impl.ReadElementContentAsBase64(buffer, index, count);
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
		///             <see cref="M:System.Xml.XmlTextReader.ReadContentAsBinHex(System.Byte[],System.Int32,System.Int32)" />  не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlTextReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		// Token: 0x06000777 RID: 1911 RVA: 0x00026C89 File Offset: 0x00024E89
		public override int ReadContentAsBinHex(byte[] buffer, int index, int count)
		{
			return this.impl.ReadContentAsBinHex(buffer, index, count);
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
		// Token: 0x06000778 RID: 1912 RVA: 0x00026C99 File Offset: 0x00024E99
		public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count)
		{
			return this.impl.ReadElementContentAsBinHex(buffer, index, count);
		}

		/// <summary>
		///         Возвращает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlTextReader" /> метод <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если объект <see cref="T:System.Xml.XmlTextReader" /> реализует метод <see cref="M:System.Xml.XmlReader.ReadValueChunk(System.Char[],System.Int32,System.Int32)" />; в противном случае — <see langword="false" />.
		///          Класс <see cref="T:System.Xml.XmlTextReader" /> всегда возвращает значение <see langword="false" />.
		///       </returns>
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000779 RID: 1913 RVA: 0x0000D1C5 File Offset: 0x0000B3C5
		public override bool CanReadValueChunk
		{
			get
			{
				return false;
			}
		}

		/// <summary>
		///         Считывает содержимое элемента или текстового узла в виде строки.
		///       </summary>
		/// <returns>
		///         Содержимое элемента или текстового узла.
		///          Если средство чтения позиционировано не на элемент или текстовый узел, а также если отсутствует возвращаемый текст, это может быть пустая строка.
		///
		///         <see langword="Note:" /> Текстовым узлом может быть элемент или текстовой узел атрибута.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Произошла ошибка при разборе XML.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Предпринята попытка выполнить недопустимую операцию.
		///           </exception>
		// Token: 0x0600077A RID: 1914 RVA: 0x00026CA9 File Offset: 0x00024EA9
		public override string ReadString()
		{
			this.impl.MoveOffEntityReference();
			return base.ReadString();
		}

		/// <summary>
		///         Возвращает значение, определяющее возможность возвращения классом сведений о строке.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если класс может возвратить сведения о строке, в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x0600077B RID: 1915 RVA: 0x0001222F File Offset: 0x0001042F
		public bool HasLineInfo()
		{
			return true;
		}

		/// <summary>
		///         Возвращает номер текущей строки.
		///       </summary>
		/// <returns>
		///         Текущий номер строки.
		///       </returns>
		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00026CBC File Offset: 0x00024EBC
		public int LineNumber
		{
			get
			{
				return this.impl.LineNumber;
			}
		}

		/// <summary>
		///         Возвращает позицию в текущей строке.
		///       </summary>
		/// <returns>
		///         Позиция в текущей строке.
		///       </returns>
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600077D RID: 1917 RVA: 0x00026CC9 File Offset: 0x00024EC9
		public int LinePosition
		{
			get
			{
				return this.impl.LinePosition;
			}
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.GetNamespacesInScope(System.Xml.XmlNamespaceScope)" />.
		///       </summary>
		/// <param name="scope">
		///           С помощью значения <see cref="T:System.Xml.XmlNamespaceScope" /> указывается тип узлов пространства имен, которые следует возвратить.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Collections.IDictionary" />, содержащий текущие пространства имен в области.
		///       </returns>
		// Token: 0x0600077E RID: 1918 RVA: 0x00026CD6 File Offset: 0x00024ED6
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.impl.GetNamespacesInScope(scope);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.
		///       </summary>
		/// <param name="prefix">
		///           Префикс, URI пространства имен которого нужно найти.
		///         </param>
		/// <returns>
		///         URI пространства имен, сопоставленное с префиксом; <see langword="null" />, если префикс не сопоставлен с URI пространства имен.
		///       </returns>
		// Token: 0x0600077F RID: 1919 RVA: 0x00026CE4 File Offset: 0x00024EE4
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.impl.LookupNamespace(prefix);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.
		///       </summary>
		/// <param name="namespaceName">
		///           URI пространства имен, префикс которого нужно найти.
		///         </param>
		/// <returns>
		///         Префикс, сопоставленный с URI пространства имен; <see langword="null" /> если URI пространства имен не сопоставлен с префиксом.
		///       </returns>
		// Token: 0x06000780 RID: 1920 RVA: 0x00026CF2 File Offset: 0x00024EF2
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.impl.LookupPrefix(namespaceName);
		}

		/// <summary>
		///         Возвращает коллекцию, содержащую все пространства имен, которые в настоящий момент находятся в области видимости.
		///       </summary>
		/// <param name="scope">
		///           С помощью значения <see cref="T:System.Xml.XmlNamespaceScope" /> указывается тип узлов пространства имен, которые следует возвратить.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Collections.IDictionary" />, содержащий все текущие пространства имен в области.
		///          Если средство чтения не позиционировано на какой-либо элемент, возвращается пустой словарь (без пространств имен).
		///       </returns>
		// Token: 0x06000781 RID: 1921 RVA: 0x00026CD6 File Offset: 0x00024ED6
		public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.impl.GetNamespacesInScope(scope);
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, поддерживаются ли пространства имен.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" /> — поддержка осуществляется; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Задание этого свойства после операции чтения (<see cref="P:System.Xml.XmlTextReader.ReadState" /> не <see langword="ReadState.Initial" />).
		///           </exception>
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x00026D00 File Offset: 0x00024F00
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x00026D0D File Offset: 0x00024F0D
		public bool Namespaces
		{
			get
			{
				return this.impl.Namespaces;
			}
			set
			{
				this.impl.Namespaces = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее необходимость нормализации символов-разделителей и значений атрибутов.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" /> для нормализации; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="false" />.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Задание этого свойства при закрытии средства чтения (<see cref="P:System.Xml.XmlTextReader.ReadState" /> — <see langword="ReadState.Closed" />).
		///           </exception>
		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x00026D1B File Offset: 0x00024F1B
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x00026D28 File Offset: 0x00024F28
		public bool Normalization
		{
			get
			{
				return this.impl.Normalization;
			}
			set
			{
				this.impl.Normalization = value;
			}
		}

		/// <summary>
		///         Возвращает кодировку документа.
		///       </summary>
		/// <returns>
		///         Значение кодировки.
		///          Если атрибут кодировки и метка порядка байтов отсутствуют, по умолчанию используется кодировка UTF-8.
		///       </returns>
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x00026D36 File Offset: 0x00024F36
		public Encoding Encoding
		{
			get
			{
				return this.impl.Encoding;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее способ обработки символов-разделителей.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.WhitespaceHandling" />.
		///          По умолчанию используется значение <see langword="WhitespaceHandling.All" /> (возвращает узлы <see langword="Whitespace" /> и <see langword="SignificantWhitespace" />).
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Указано недопустимое значение.
		///           </exception>
		/// <exception cref="T:System.InvalidOperationException">
		///             Задание этого свойства при закрытии средства чтения (<see cref="P:System.Xml.XmlTextReader.ReadState" /> — <see langword="ReadState.Closed" />).
		///           </exception>
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x00026D43 File Offset: 0x00024F43
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00026D50 File Offset: 0x00024F50
		public WhitespaceHandling WhitespaceHandling
		{
			get
			{
				return this.impl.WhitespaceHandling;
			}
			set
			{
				this.impl.WhitespaceHandling = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее, следует ли разрешить обработку DTD.
		///          Это свойство устарело.
		///          Взамен рекомендуется использовать <see cref="P:System.Xml.XmlTextReader.DtdProcessing" />.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" /> для отключения обработки DTD; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="false" />.
		///       </returns>
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x00026D5E File Offset: 0x00024F5E
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x00026D6E File Offset: 0x00024F6E
		[Obsolete("Use DtdProcessing property instead.")]
		public bool ProhibitDtd
		{
			get
			{
				return this.impl.DtdProcessing == DtdProcessing.Prohibit;
			}
			set
			{
				this.impl.DtdProcessing = (value ? DtdProcessing.Prohibit : DtdProcessing.Parse);
			}
		}

		/// <summary>
		///         Получает или задает перечисление <see cref="T:System.Xml.DtdProcessing" />.
		///       </summary>
		/// <returns>
		///         Перечисление <see cref="T:System.Xml.DtdProcessing" />.
		///       </returns>
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00026D82 File Offset: 0x00024F82
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00026D8F File Offset: 0x00024F8F
		public DtdProcessing DtdProcessing
		{
			get
			{
				return this.impl.DtdProcessing;
			}
			set
			{
				this.impl.DtdProcessing = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее способ обработки сущностей средством чтения.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.EntityHandling" />.
		///          Если <see langword="EntityHandling" /> не задан, по умолчанию для него используется значение <see langword="EntityHandling.ExpandCharEntities" />.
		///       </returns>
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00026D9D File Offset: 0x00024F9D
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x00026DAA File Offset: 0x00024FAA
		public EntityHandling EntityHandling
		{
			get
			{
				return this.impl.EntityHandling;
			}
			set
			{
				this.impl.EntityHandling = value;
			}
		}

		/// <summary>
		///         Задает <see cref="T:System.Xml.XmlResolver" /> для разрешения ссылок на DTD.
		///       </summary>
		/// <returns>
		///         Используемый <see langword="XmlResolver" />.
		///          Если он имеет значение <see langword="null" />, внешние ресурсы не разрешаются.
		///
		///         В .NET Framework версии 1.1 вызывающий объект должен иметь полное доверие, чтобы иметь возможность указывать <see langword="XmlResolver" />.
		///       </returns>
		// Token: 0x1700011A RID: 282
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x00026DB8 File Offset: 0x00024FB8
		public XmlResolver XmlResolver
		{
			set
			{
				this.impl.XmlResolver = value;
			}
		}

		/// <summary>
		///         Сбрасывает состояние средства чтения на ReadState.Initial.
		///       </summary>
		/// <exception cref="T:System.InvalidOperationException">
		///             Вызов <see langword="ResetState" /> Если средство чтения создано с помощью <see cref="T:System.Xml.XmlParserContext" />.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Документы в отдельном потоке не имеют одной кодировки.
		///           </exception>
		// Token: 0x06000790 RID: 1936 RVA: 0x00026DC6 File Offset: 0x00024FC6
		public void ResetState()
		{
			this.impl.ResetState();
		}

		/// <summary>
		///         Возвращает оставшуюся часть XML-кода, находящегося в буфере.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.IO.TextReader" />, содержащий оставшуюся часть XML-кода, находящегося в буфере.
		///       </returns>
		// Token: 0x06000791 RID: 1937 RVA: 0x00026DD3 File Offset: 0x00024FD3
		public TextReader GetRemainder()
		{
			return this.impl.GetRemainder();
		}

		/// <summary>
		///         Считывает текстовое содержимое элемента в буфер символов.
		///          Этот метод предназначен для чтения больших потоков внедренного текста путем его последовательного вызова.
		///       </summary>
		/// <param name="buffer">
		///           Массив символов, выполняющий функции буфера, в который записывается текстовое содержимое.
		///         </param>
		/// <param name="index">
		///           Положение в <paramref name="buffer" />, с которого метод начинает запись текстового содержимого.
		///         </param>
		/// <param name="count">
		///           Число символов, записываемых в <paramref name="buffer" />.
		///         </param>
		/// <returns>
		///         Число прочитанных знаков.
		///          Если средство чтения находится не на элементе или отсутствует возвращаемый текст, это значение может быть равно <see langword="0" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             <paramref name="count" /> больше, чем размер, указанный в <paramref name="buffer" /> (размер буфера — <paramref name="index" />).
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="buffer" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="index" /><see langword="&lt; 0" /> или <paramref name="count" /><see langword="&lt; 0" />.
		///           </exception>
		// Token: 0x06000792 RID: 1938 RVA: 0x00026DE0 File Offset: 0x00024FE0
		public int ReadChars(char[] buffer, int index, int count)
		{
			return this.impl.ReadChars(buffer, index, count);
		}

		/// <summary>
		///         Декодирует данные из кодировки Base64 и возвращает результат в виде декодированных двоичных байтов.
		///       </summary>
		/// <param name="array">
		///           Массив символов, выполняющий функции буфера, в который записывается текстовое содержимое.
		///         </param>
		/// <param name="offset">
		///           Начинающийся с нуля индекс в массиве, указывающий место, с которого метод начнет запись в буфер.
		///         </param>
		/// <param name="len">
		///           Число байтов для записи в буфер.
		///         </param>
		/// <returns>
		///         Количество байтов, записанных в буфер.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             Недопустимая последовательность Base64.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="array" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> &lt; 0, или <paramref name="len" /> &lt; 0, или <paramref name="len" /> &gt; <paramref name="array" />. Длина - <paramref name="offset" />.
		///           </exception>
		// Token: 0x06000793 RID: 1939 RVA: 0x00026DF0 File Offset: 0x00024FF0
		public int ReadBase64(byte[] array, int offset, int len)
		{
			return this.impl.ReadBase64(array, offset, len);
		}

		/// <summary>
		///         Декодирует <see langword="BinHex" /> и возвращает результат в виде декодированных двоичных байтов.
		///       </summary>
		/// <param name="array">
		///           Массив байтов, выполняющий функции буфера, в который записываются декодированные двоичные байты.
		///         </param>
		/// <param name="offset">
		///           Начинающийся с нуля индекс в массиве, указывающий место, с которого метод начнет запись в буфер.
		///         </param>
		/// <param name="len">
		///           Число байтов для записи в буфер.
		///         </param>
		/// <returns>
		///         Количество байтов, записываемых в буфер.
		///       </returns>
		/// <exception cref="T:System.Xml.XmlException">
		///             <see langword="BinHex" /> Последовательность не является допустимым.
		///           </exception>
		/// <exception cref="T:System.ArgumentNullException">
		///             Значение <paramref name="array" /> равно <see langword="null" />.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             <paramref name="offset" /> &lt; 0, или <paramref name="len" /> &lt; 0, или <paramref name="len" /> &gt; <paramref name="array" />. Длина - <paramref name="offset" />.
		///           </exception>
		// Token: 0x06000794 RID: 1940 RVA: 0x00026E00 File Offset: 0x00025000
		public int ReadBinHex(byte[] array, int offset, int len)
		{
			return this.impl.ReadBinHex(array, offset, len);
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00026E10 File Offset: 0x00025010
		internal XmlTextReaderImpl Impl
		{
			get
			{
				return this.impl;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x00026E18 File Offset: 0x00025018
		internal override XmlNamespaceManager NamespaceManager
		{
			get
			{
				return this.impl.NamespaceManager;
			}
		}

		// Token: 0x1700011D RID: 285
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x00026E25 File Offset: 0x00025025
		internal bool XmlValidatingReaderCompatibilityMode
		{
			set
			{
				this.impl.XmlValidatingReaderCompatibilityMode = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00026E33 File Offset: 0x00025033
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.impl.DtdInfo;
			}
		}

		// Token: 0x04000917 RID: 2327
		private XmlTextReaderImpl impl;
	}
}
