using System;
using System.Xml.XPath;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Инкапсулирует текущий контекст выполнения расширяемый язык стилей для процессора преобразования (XSLT), позволяя язык XML Path (XPath), для разрешения функции, параметры и пространства имен в выражениях XPath.
	///       </summary>
	// Token: 0x0200034B RID: 843
	public abstract class XsltContext : XmlNamespaceManager
	{
		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltContext" /> указанным значением <see cref="T:System.Xml.NameTable" />.
		///       </summary>
		/// <param name="table">
		///           Используемый <see cref="T:System.Xml.NameTable" />.
		///         </param>
		// Token: 0x060022D2 RID: 8914 RVA: 0x000DA738 File Offset: 0x000D8938
		protected XsltContext(NameTable table) : base(table)
		{
		}

		/// <summary>
		///         Инициализирует новый экземпляр класса <see cref="T:System.Xml.Xsl.XsltContext" />.
		///       </summary>
		// Token: 0x060022D3 RID: 8915 RVA: 0x000DA741 File Offset: 0x000D8941
		protected XsltContext() : base(new NameTable())
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00035911 File Offset: 0x00033B11
		internal XsltContext(bool dummy)
		{
		}

		/// <summary>
		///         При переопределении в производном классе разрешает ссылку на переменную и возвращает <see cref="T:System.Xml.Xsl.IXsltContextVariable" /> представляющий переменную.
		///       </summary>
		/// <param name="prefix">
		///           Префикс переменной для использования в выражениях XPath.
		///         </param>
		/// <param name="name">
		///           Имя переменной.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Xsl.IXsltContextVariable" /> Представляющий переменную во время выполнения.
		///       </returns>
		// Token: 0x060022D5 RID: 8917
		public abstract IXsltContextVariable ResolveVariable(string prefix, string name);

		/// <summary>
		///         При переопределении в производном классе разрешает ссылку на функцию и возвращает <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> представляющий функцию.
		///         <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> Используется во время выполнения для получения возвращаемого значения функции.
		///       </summary>
		/// <param name="prefix">
		///           Префикс функции для использования в выражениях XPath.
		///         </param>
		/// <param name="name">
		///           Имя функции.
		///         </param>
		/// <param name="ArgTypes">
		///           Массив типов аргументов разрешаемой функции.
		///            Это позволяет выбрать нужный метод из нескольких, имеющих одно и то же имя (например, перегруженных методов).
		///         </param>
		/// <returns>
		///         <see cref="T:System.Xml.Xsl.IXsltContextFunction" /> Представляет функцию.
		///       </returns>
		// Token: 0x060022D6 RID: 8918
		public abstract IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes);

		/// <summary>
		///         При переопределении в производном классе получает значение, указывающее, следует ли включать узлы пустых пространств в выходных данных.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Чтобы узлы пустых пространств в исходном документе для включения в выходных данных. <see langword="false" /> не вычисляется узлы пробелов.
		///          Значение по умолчанию — <see langword="true" />.
		///       </returns>
		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060022D7 RID: 8919
		public abstract bool Whitespace { get; }

		/// <summary>
		///         При переопределении в производном классе вычисляет, будут ли узлы пустых пространств сохранены или срезаны в данном контексте.
		///       </summary>
		/// <param name="node">
		///           Узел пустого пространства, который должен быть сохранен или отброшен в текущем контексте.
		///         </param>
		/// <returns>
		///         Возвращает <see langword="true" /> Если сохранить пробелы или <see langword="false" /> Если пустое пространство должно быть удалены.
		///       </returns>
		// Token: 0x060022D8 RID: 8920
		public abstract bool PreserveWhitespace(XPathNavigator node);

		/// <summary>
		///         При переопределении в производном классе сравнивает базовые универсальные коды ресурсов (URI) двух документов, основываясь на порядке загрузки документов процессором XSLT (то есть <see cref="T:System.Xml.Xsl.XslTransform" /> класса).
		///       </summary>
		/// <param name="baseUri">
		///           Базовый универсальный код ресурса (URI) первого документа.
		///         </param>
		/// <param name="nextbaseUri">
		///           Базовый URI второго документа.
		///         </param>
		/// <returns>
		///         Целочисленное значение, описывающее относительный порядок двух основных URI: <see langword="-" />1, если <paramref name="baseUri" /> предшествует <paramref name="nextbaseUri" />; Если два URI идентичны; 0 и 1, если <paramref name="baseUri" /> происходит после <paramref name="nextbaseUri" />.
		///       </returns>
		// Token: 0x060022D9 RID: 8921
		public abstract int CompareDocument(string baseUri, string nextbaseUri);
	}
}
