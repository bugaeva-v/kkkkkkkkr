using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Xml.Schema;

namespace System.Xml
{
	/// <summary>
	///         Представляет средство чтения, обеспечивающее проверку определения DTD, схемы XDR и языка определения схемы XML.
	///
	///         Этот класс устарел.
	///          Начиная с .NET Framework версии 2.0, рекомендуется использовать класс <see cref="T:System.Xml.XmlReaderSettings" /> и метод <see cref="Overload:System.Xml.XmlReader.Create" /> для создания проверяющего средства чтения XML.
	///       </summary>
	// Token: 0x0200013F RID: 319
	[Obsolete("Use XmlReader created by XmlReader.Create() method using appropriate XmlReaderSettings instead. https://go.microsoft.com/fwlink/?linkid=14202")]
	[PermissionSet(SecurityAction.InheritanceDemand, Name = "FullTrust")]
	public class XmlValidatingReader : XmlReader, IXmlLineInfo, IXmlNamespaceResolver
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlValidatingReader" />, который служит для проверки содержимого, возвращаемого заданным <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		/// <param name="reader">
		///           <see langword="XmlReader" />, из которого при проверке данных выполняется чтение.
		///            Текущая реализация поддерживает только <see cref="T:System.Xml.XmlTextReader" />.
		///         </param>
		/// <exception cref="T:System.ArgumentException">
		///             Средство чтения указано не <see langword="XmlTextReader" />.
		///           </exception>
		// Token: 0x06000B4F RID: 2895 RVA: 0x0004CDA6 File Offset: 0x0004AFA6
		public XmlValidatingReader(XmlReader reader)
		{
			this.impl = new XmlValidatingReaderImpl(reader);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlValidatingReader" /> с использованием указанных значений.
		///       </summary>
		/// <param name="xmlFragment">
		///           Строка, содержащая анализируемый фрагмент XML.
		///         </param>
		/// <param name="fragType">
		///           Тип <see cref="T:System.Xml.XmlNodeType" /> фрагмента XML.
		///            Также определяет содержимое строки фрагмента (см. таблицу ниже).
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.XmlParserContext" />, в котором анализируется фрагмент XML.
		///            Это включает в себя используемый класс <see cref="T:System.Xml.NameTable" />, кодировку, область пространства имен, текущий xml:lang и область xml:space.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="fragType" /> не является одним из типов узлов, перечисленных в следующей таблице.
		///           </exception>
		// Token: 0x06000B50 RID: 2896 RVA: 0x0004CDC6 File Offset: 0x0004AFC6
		public XmlValidatingReader(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			if (xmlFragment == null)
			{
				throw new ArgumentNullException("xmlFragment");
			}
			this.impl = new XmlValidatingReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see langword="XmlValidatingReader" /> с использованием указанных значений.
		///       </summary>
		/// <param name="xmlFragment">
		///           Поток, содержащий анализируемый фрагмент XML.
		///         </param>
		/// <param name="fragType">
		///           Тип <see cref="T:System.Xml.XmlNodeType" /> фрагмента XML.
		///            Определяет содержимое фрагмента (см. таблицу ниже).
		///         </param>
		/// <param name="context">
		///           <see cref="T:System.Xml.XmlParserContext" />, в котором анализируется фрагмент XML.
		///            Это включает в себя используемый класс <see cref="T:System.Xml.XmlNameTable" />, кодировку, область пространства имен, текущий <see langword="xml:lang" /> и область <see langword="xml:space" />.
		///         </param>
		/// <exception cref="T:System.Xml.XmlException">
		///             <paramref name="fragType" /> не является одним из типов узлов, перечисленных в следующей таблице.
		///           </exception>
		// Token: 0x06000B51 RID: 2897 RVA: 0x0004CDF6 File Offset: 0x0004AFF6
		public XmlValidatingReader(Stream xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			if (xmlFragment == null)
			{
				throw new ArgumentNullException("xmlFragment");
			}
			this.impl = new XmlValidatingReaderImpl(xmlFragment, fragType, context);
			this.impl.OuterReader = this;
		}

		/// <summary>
		///         Возвращает тип текущего узла.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.XmlNodeType" />, предоставляющее тип текущего узла.
		///       </returns>
		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x0004CE26 File Offset: 0x0004B026
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
		///         Возвращаемое имя зависит от значения свойства <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> узла.
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
		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000B53 RID: 2899 RVA: 0x0004CE33 File Offset: 0x0004B033
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
		///         Для безымянных типов узлов (например, <see langword="Text" />, <see langword="Comment" /> и т. д.) данное свойство возвращает String.Empty.
		///       </returns>
		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x0004CE40 File Offset: 0x0004B040
		public override string LocalName
		{
			get
			{
				return this.impl.LocalName;
			}
		}

		/// <summary>
		///         Возвращает URI пространства имен (определенное в спецификации W3C, посвященной пространствам имен) узла, на который позиционировано средство чтения.
		///       </summary>
		/// <returns>
		///         URI пространства имен текущего узла; в противном случае — пустая строка.
		///       </returns>
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0004CE4D File Offset: 0x0004B04D
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
		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x0004CE5A File Offset: 0x0004B05A
		public override string Prefix
		{
			get
			{
				return this.impl.Prefix;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющие наличие у текущего узла свойства <see cref="P:System.Xml.XmlValidatingReader.Value" />, значение которого отличается от String.Empty.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если узел, на котором расположено средство чтения, может иметь значение <see langword="Value" />; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0004CE67 File Offset: 0x0004B067
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
		///         Возвращаемое значение зависит от значения свойства <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> узла.
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
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x0004CE74 File Offset: 0x0004B074
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
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0004CE81 File Offset: 0x0004B081
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
		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x0004CE8E File Offset: 0x0004B08E
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
		///         Значение <see langword="true" />, если текущий узел является элементом (свойство <see cref="P:System.Xml.XmlValidatingReader.NodeType" /> имеет значение <see langword="XmlNodeType.Element" />), который заканчивается на /&gt;; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0004CE9B File Offset: 0x0004B09B
		public override bool IsEmptyElement
		{
			get
			{
				return this.impl.IsEmptyElement;
			}
		}

		/// <summary>
		///         Возвращает значение, определяющее, является ли текущий узел атрибутом, созданным из значения по умолчанию, определенного в DTD или схеме.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если текущий узел является атрибутом, значение которого было создано из значения по умолчанию, определенного в DTD или схеме; значение <see langword="false" />, если значение атрибута было задано явно.
		///       </returns>
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0004CEA8 File Offset: 0x0004B0A8
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
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0004CEB5 File Offset: 0x0004B0B5
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
		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0004CEC2 File Offset: 0x0004B0C2
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
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x0004CECF File Offset: 0x0004B0CF
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
		///          в том числе атрибутов, используемых по умолчанию.
		///       </returns>
		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0004CEDC File Offset: 0x0004B0DC
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
		// Token: 0x06000B61 RID: 2913 RVA: 0x0004CEE9 File Offset: 0x0004B0E9
		public override string GetAttribute(string name)
		{
			return this.impl.GetAttribute(name);
		}

		/// <summary>
		///         Возвращает значение атрибута с заданным локальным именем и URI пространства имен.
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
		// Token: 0x06000B62 RID: 2914 RVA: 0x0004CEF7 File Offset: 0x0004B0F7
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
		///             <paramref name="i" /> Параметр меньше 0 или больше или равно <see cref="P:System.Xml.XmlValidatingReader.AttributeCount" />.
		///           </exception>
		// Token: 0x06000B63 RID: 2915 RVA: 0x0004CF06 File Offset: 0x0004B106
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
		// Token: 0x06000B64 RID: 2916 RVA: 0x0004CF14 File Offset: 0x0004B114
		public override bool MoveToAttribute(string name)
		{
			return this.impl.MoveToAttribute(name);
		}

		/// <summary>
		///         Переходит к атрибуту с заданным локальным именем и URI пространства имен.
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
		// Token: 0x06000B65 RID: 2917 RVA: 0x0004CF22 File Offset: 0x0004B122
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
		// Token: 0x06000B66 RID: 2918 RVA: 0x0004CF31 File Offset: 0x0004B131
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
		// Token: 0x06000B67 RID: 2919 RVA: 0x0004CF3F File Offset: 0x0004B13F
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
		// Token: 0x06000B68 RID: 2920 RVA: 0x0004CF4C File Offset: 0x0004B14C
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
		// Token: 0x06000B69 RID: 2921 RVA: 0x0004CF59 File Offset: 0x0004B159
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
		///         Пустой атрибут (например, misc="") возвращает значение <see langword="true" /> с отдельным узлом, имеющим значение String.Empty.
		///       </returns>
		// Token: 0x06000B6A RID: 2922 RVA: 0x0004CF66 File Offset: 0x0004B166
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
		// Token: 0x06000B6B RID: 2923 RVA: 0x0004CF73 File Offset: 0x0004B173
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
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x0004CF80 File Offset: 0x0004B180
		public override bool EOF
		{
			get
			{
				return this.impl.EOF;
			}
		}

		/// <summary>
		///         Изменяет значение <see cref="P:System.Xml.XmlReader.ReadState" /> на Closed.
		///       </summary>
		// Token: 0x06000B6D RID: 2925 RVA: 0x0004CF8D File Offset: 0x0004B18D
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
		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x0004CF9A File Offset: 0x0004B19A
		public override ReadState ReadState
		{
			get
			{
				return this.impl.ReadState;
			}
		}

		/// <summary>
		///         Возвращает класс <see cref="T:System.Xml.XmlNameTable" />, связанный с данной реализацией.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNameTable" />, позволяющий получать в узле разделенную версию строки.
		///       </returns>
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000B6F RID: 2927 RVA: 0x0004CFA7 File Offset: 0x0004B1A7
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
		///           Префикс, URI пространства имен которого вы хотите разрешить.
		///            Чтобы сопоставить пространство имен по умолчанию, необходимо передать пустую строку.
		///         </param>
		/// <returns>
		///         URI пространства имен, которое отображает префикс, или значение <see langword="null" />, если соответствующий префикс не найден.
		///       </returns>
		// Token: 0x06000B70 RID: 2928 RVA: 0x0004CFB4 File Offset: 0x0004B1B4
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
		///          Параметр <see langword="XmlValidatingReader" /> всегда возвращает значение <see langword="true" />.
		///       </returns>
		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000B71 RID: 2929 RVA: 0x0001222F File Offset: 0x0001042F
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
		/// <exception cref="T:System.InvalidOperationException">
		///             Средство чтения не позиционировано на <see langword="EntityReference" /> узел.
		///           </exception>
		// Token: 0x06000B72 RID: 2930 RVA: 0x0004CFDC File Offset: 0x0004B1DC
		public override void ResolveEntity()
		{
			this.impl.ResolveEntity();
		}

		/// <summary>
		///         Получает значение, указывающее, реализует ли объект <see cref="T:System.Xml.XmlValidatingReader" /> методы чтения двоичного содержимого.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" />, если реализуются методы чтения двоичного содержимого; в противном случае — <see langword="false" />.
		///          Класс <see cref="T:System.Xml.XmlValidatingReader" /> возвращает <see langword="true" />.
		///       </returns>
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0001222F File Offset: 0x0001042F
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
		///             <see cref="M:System.Xml.XmlValidatingReader.ReadContentAsBase64(System.Byte[],System.Int32,System.Int32)" />  не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		// Token: 0x06000B74 RID: 2932 RVA: 0x0004CFE9 File Offset: 0x0004B1E9
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
		///             <see cref="T:System.Xml.XmlValidatingReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		// Token: 0x06000B75 RID: 2933 RVA: 0x0004CFF9 File Offset: 0x0004B1F9
		public override int ReadElementContentAsBase64(byte[] buffer, int index, int count)
		{
			return this.impl.ReadElementContentAsBase64(buffer, index, count);
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
		///             <see cref="M:System.Xml.XmlValidatingReader.ReadContentAsBinHex(System.Byte[],System.Int32,System.Int32)" />  не поддерживается в текущем узле.
		///           </exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Индекс в буфере или индекса + число больше, чем выделенный размер буфера.
		///           </exception>
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlValidatingReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		// Token: 0x06000B76 RID: 2934 RVA: 0x0004D009 File Offset: 0x0004B209
		public override int ReadContentAsBinHex(byte[] buffer, int index, int count)
		{
			return this.impl.ReadContentAsBinHex(buffer, index, count);
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
		/// <exception cref="T:System.NotSupportedException">
		///             <see cref="T:System.Xml.XmlValidatingReader" /> Реализация не поддерживает этот метод.
		///           </exception>
		/// <exception cref="T:System.Xml.XmlException">
		///             Элемент содержит смешанное содержимое.
		///           </exception>
		/// <exception cref="T:System.FormatException">
		///             Не удается преобразовать содержимое в требуемый тип.
		///           </exception>
		// Token: 0x06000B77 RID: 2935 RVA: 0x0004D019 File Offset: 0x0004B219
		public override int ReadElementContentAsBinHex(byte[] buffer, int index, int count)
		{
			return this.impl.ReadElementContentAsBinHex(buffer, index, count);
		}

		/// <summary>
		///         Считывает содержимое элемента или текстового узла в виде строки.
		///       </summary>
		/// <returns>
		///         Содержимое элемента или текстового узла.
		///          Если средство чтения позиционировано не на элемент или текстовый узел, а также если отсутствует возвращаемый текст, это может быть пустая строка.
		///
		///           Текстовым узлом может быть элемент или текстовой узел атрибута.
		///         </returns>
		// Token: 0x06000B78 RID: 2936 RVA: 0x0004D029 File Offset: 0x0004B229
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
		// Token: 0x06000B79 RID: 2937 RVA: 0x0001222F File Offset: 0x0001042F
		public bool HasLineInfo()
		{
			return true;
		}

		/// <summary>
		///         Возвращает номер текущей строки.
		///       </summary>
		/// <returns>
		///         Текущий номер строки.
		///          Начальным значением свойства является 1.
		///       </returns>
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0004D03C File Offset: 0x0004B23C
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
		///          Начальным значением свойства является 1.
		///       </returns>
		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000B7B RID: 2939 RVA: 0x0004D049 File Offset: 0x0004B249
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
		///           Объект <see cref="T:System.Xml.XmlNamespaceScope" />, определяющий область действия средства чтения.
		///         </param>
		/// <returns>
		///         Объект T:System.Collections.IDictionary, определяющий пространства имен в области видимости.
		///       </returns>
		// Token: 0x06000B7C RID: 2940 RVA: 0x0004D056 File Offset: 0x0004B256
		IDictionary<string, string> IXmlNamespaceResolver.GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return this.impl.GetNamespacesInScope(scope);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupNamespace(System.String)" />.
		///       </summary>
		/// <param name="prefix">
		///           Префикс пространства имен.
		///         </param>
		/// <returns>
		///         Строковое значение, содержащее универсальный код ресурса (URI) пространства имен, связанный с данным префиксом.
		///       </returns>
		// Token: 0x06000B7D RID: 2941 RVA: 0x0004D064 File Offset: 0x0004B264
		string IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			return this.impl.LookupNamespace(prefix);
		}

		/// <summary>
		///         Описание этого члена см. в разделе <see cref="M:System.Xml.IXmlNamespaceResolver.LookupPrefix(System.String)" />.
		///       </summary>
		/// <param name="namespaceName">
		///           Пространство имен, связанное с префиксом.
		///         </param>
		/// <returns>
		///         Строковое значение, содержащее префикс пространства имен, связанный со значением <paramref name="namespaceName" />.
		///       </returns>
		// Token: 0x06000B7E RID: 2942 RVA: 0x0004D072 File Offset: 0x0004B272
		string IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			return this.impl.LookupPrefix(namespaceName);
		}

		/// <summary>
		///         Задает обработчик событий для получения сведений об ошибках проверки DTD, XDR- и XSD-схем.
		///       </summary>
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000B7F RID: 2943 RVA: 0x0004D080 File Offset: 0x0004B280
		// (remove) Token: 0x06000B80 RID: 2944 RVA: 0x0004D08E File Offset: 0x0004B28E
		public event ValidationEventHandler ValidationEventHandler
		{
			add
			{
				this.impl.ValidationEventHandler += value;
			}
			remove
			{
				this.impl.ValidationEventHandler -= value;
			}
		}

		/// <summary>
		///         Возвращает объект с типом схемы.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.Schema.XmlSchemaDatatype" />, <see cref="T:System.Xml.Schema.XmlSchemaSimpleType" />, или <see cref="T:System.Xml.Schema.XmlSchemaComplexType" /> в зависимости от того, является ли значение узла встроенным в язык определения схемы XML типом или определяемым пользователем типом simpleType или complexType; <see langword="null" />, если текущий узел не имеет типа схемы.
		///       </returns>
		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000B81 RID: 2945 RVA: 0x0004D09C File Offset: 0x0004B29C
		public object SchemaType
		{
			get
			{
				return this.impl.SchemaType;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlReader" />, используемый для создания <see langword="XmlValidatingReader" />.
		///       </summary>
		/// <returns>
		///         <see langword="XmlReader" />, заданный в конструкторе.
		///       </returns>
		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0004D0A9 File Offset: 0x0004B2A9
		public XmlReader Reader
		{
			get
			{
				return this.impl.Reader;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее тип выполняемой проверки.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.ValidationType" />.
		///          Если это свойство не задано, то по умолчанию используется тип ValidationType.Auto.
		///       </returns>
		/// <exception cref="T:System.InvalidOperationException">
		///             Задание свойства после вызова Read.
		///           </exception>
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000B83 RID: 2947 RVA: 0x0004D0B6 File Offset: 0x0004B2B6
		// (set) Token: 0x06000B84 RID: 2948 RVA: 0x0004D0C3 File Offset: 0x0004B2C3
		public ValidationType ValidationType
		{
			get
			{
				return this.impl.ValidationType;
			}
			set
			{
				this.impl.ValidationType = value;
			}
		}

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.Schema.XmlSchemaCollection" />, который будет использоваться при проверке данных.
		///       </summary>
		/// <returns>
		///         <see langword="XmlSchemaCollection" />, используемый при проверке данных.
		///       </returns>
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0004D0D1 File Offset: 0x0004B2D1
		public XmlSchemaCollection Schemas
		{
			get
			{
				return this.impl.Schemas;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, определяющее способ обработки сущностей средством чтения.
		///       </summary>
		/// <returns>
		///         Одно из значений <see cref="T:System.Xml.EntityHandling" />.
		///          Если <see langword="EntityHandling" /> не задан, по умолчанию для него используется значение EntityHandling.ExpandEntities.
		///       </returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">
		///             Указано недопустимое значение.
		///           </exception>
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0004D0DE File Offset: 0x0004B2DE
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0004D0EB File Offset: 0x0004B2EB
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
		///         Задает <see cref="T:System.Xml.XmlResolver" /> для разрешения внешних DTD и ссылок на расположение схем.
		///          Кроме того, <see langword="XmlResolver" /> используется для обработки любых импортированных или добавленных элементов, найденных в XSD-схемах.
		///       </summary>
		/// <returns>
		///         Используемый <see langword="XmlResolver" />.
		///          Если он имеет значение <see langword="null" />, внешние ресурсы не разрешаются.
		///
		///         В .NET Framework версии 1.1 вызывающий объект должен иметь полное доверие, чтобы иметь возможность указывать <see langword="XmlResolver" />.
		///       </returns>
		// Token: 0x170001A1 RID: 417
		// (set) Token: 0x06000B88 RID: 2952 RVA: 0x0004D0F9 File Offset: 0x0004B2F9
		public XmlResolver XmlResolver
		{
			set
			{
				this.impl.XmlResolver = value;
			}
		}

		/// <summary>
		///         Возвращает или задает значение, указывающее, поддерживаются ли пространства имен.
		///       </summary>
		/// <returns>
		///         Значение <see langword="true" /> — поддержка осуществляется; в противном случае — <see langword="false" />.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x0004D107 File Offset: 0x0004B307
		// (set) Token: 0x06000B8A RID: 2954 RVA: 0x0004D114 File Offset: 0x0004B314
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
		///         Возвращает тип CLR для указанного типа языка определения схем XML (XSD).
		///       </summary>
		/// <returns>
		///         Тип CLR для указанного типа XSD.
		///       </returns>
		// Token: 0x06000B8B RID: 2955 RVA: 0x0004D122 File Offset: 0x0004B322
		public object ReadTypedValue()
		{
			return this.impl.ReadTypedValue();
		}

		/// <summary>
		///         Возвращает атрибут кодировки для документа.
		///       </summary>
		/// <returns>
		///         Значение кодировки.
		///          Если атрибут кодировки и метка порядка байтов отсутствуют, по умолчанию используется кодировка UTF-8.
		///       </returns>
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0004D12F File Offset: 0x0004B32F
		public Encoding Encoding
		{
			get
			{
				return this.impl.Encoding;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x0004D13C File Offset: 0x0004B33C
		internal XmlValidatingReaderImpl Impl
		{
			get
			{
				return this.impl;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0004D144 File Offset: 0x0004B344
		internal override IDtdInfo DtdInfo
		{
			get
			{
				return this.impl.DtdInfo;
			}
		}

		// Token: 0x04000D23 RID: 3363
		private XmlValidatingReaderImpl impl;
	}
}
