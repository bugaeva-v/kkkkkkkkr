using System;
using System.Collections;
using MS.Internal.Xml.XPath;

namespace System.Xml.XPath
{
	/// <summary>
	///         Предоставляет типизированный класс, который представляет скомпилированное выражение XPath.
	///       </summary>
	// Token: 0x02000256 RID: 598
	public abstract class XPathExpression
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x0000216B File Offset: 0x0000036B
		internal XPathExpression()
		{
		}

		/// <summary>
		///         При переопределении в производном классе получает <see langword="string" /> представление <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </summary>
		/// <returns>
		///         Возвращает объект <see langword="string" />, который представляет объект <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </returns>
		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x060015EE RID: 5614
		public abstract string Expression { get; }

		/// <summary>
		///         При переопределении в производном классе Сортирует узлы, выбранные с помощью выражения XPath в соответствии с указанным <see cref="T:System.Collections.IComparer" /> объекта.
		///       </summary>
		/// <param name="expr">
		///           Объект, представляющий ключ сортировки.
		///            Это может быть значение <see langword="string" /> узла или объект <see cref="T:System.Xml.XPath.XPathExpression" /> со скомпилированным выражением XPath.
		///         </param>
		/// <param name="comparer">
		///           <see cref="T:System.Collections.IComparer" /> Объект, предоставляющий сравнения типов данных для сравнения на равенство двух объектов.
		///         </param>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             <see cref="T:System.Xml.XPath.XPathExpression" /> или ключ сортировки включает префикс и либо <see cref="T:System.Xml.XmlNamespaceManager" /> отсутствует, либо не удается найти этот префикс в предоставленном <see cref="T:System.Xml.XmlNamespaceManager" />.
		///           </exception>
		// Token: 0x060015EF RID: 5615
		public abstract void AddSort(object expr, IComparer comparer);

		/// <summary>
		///         При переопределении в производном классе выполняет сортировку узлов, выбранных выражением XPath, согласно указанным параметрам.
		///       </summary>
		/// <param name="expr">
		///           Объект, представляющий ключ сортировки.
		///            Это может быть значение <see langword="string" /> узла или объект <see cref="T:System.Xml.XPath.XPathExpression" /> со скомпилированным выражением XPath.
		///         </param>
		/// <param name="order">
		///           Значение <see cref="T:System.Xml.XPath.XmlSortOrder" />, указывающее порядок сортировки.
		///         </param>
		/// <param name="caseOrder">
		///           Значение <see cref="T:System.Xml.XPath.XmlCaseOrder" />, указывающее, как должны сортироваться прописные и строчные буквы.
		///         </param>
		/// <param name="lang">
		///           Язык, используемый для сравнения.
		///            Использует <see cref="T:System.Globalization.CultureInfo" /> класс, который может быть передан <see cref="Overload:System.String.Compare" /> типов метода для языка, например, «us-en» для штатов. английский.
		///            Если задана пустая строка, для определения <see cref="T:System.Globalization.CultureInfo" /> используется среда системы.
		///         </param>
		/// <param name="dataType">
		///           Значение <see cref="T:System.Xml.XPath.XmlDataType" />, указывающее порядок сортировки для типа данных.
		///         </param>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             <see cref="T:System.Xml.XPath.XPathExpression" /> или ключ сортировки включает префикс и либо <see cref="T:System.Xml.XmlNamespaceManager" /> отсутствует, либо не удается найти этот префикс в предоставленном <see cref="T:System.Xml.XmlNamespaceManager" />.
		///           </exception>
		// Token: 0x060015F0 RID: 5616
		public abstract void AddSort(object expr, XmlSortOrder order, XmlCaseOrder caseOrder, string lang, XmlDataType dataType);

		/// <summary>
		///         При переопределении в производном классе Возвращает клон данного <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </summary>
		/// <returns>
		///         Новый объект <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </returns>
		// Token: 0x060015F1 RID: 5617
		public abstract XPathExpression Clone();

		/// <summary>
		///         При переопределении в производном классе задает объект <see cref="T:System.Xml.XmlNamespaceManager" />, который должен использоваться для разрешения пространства имен.
		///       </summary>
		/// <param name="nsManager">
		///           Объект <see cref="T:System.Xml.XmlNamespaceManager" />, используемый для разрешения пространства имен.
		///         </param>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Параметр объекта <see cref="T:System.Xml.XmlNamespaceManager" /> не является производным от класса <see cref="T:System.Xml.XmlNamespaceManager" />.
		///           </exception>
		// Token: 0x060015F2 RID: 5618
		public abstract void SetContext(XmlNamespaceManager nsManager);

		/// <summary>
		///         При переопределении в производном классе задает объект <see cref="T:System.Xml.IXmlNamespaceResolver" />, который должен использоваться для разрешения пространства имен.
		///       </summary>
		/// <param name="nsResolver">
		///           Объект, реализующий интерфейс <see cref="T:System.Xml.IXmlNamespaceResolver" />, используемый для разрешения пространства имен.
		///         </param>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Параметр объекта <see cref="T:System.Xml.IXmlNamespaceResolver" /> не является производным от <see cref="T:System.Xml.IXmlNamespaceResolver" />.
		///           </exception>
		// Token: 0x060015F3 RID: 5619
		public abstract void SetContext(IXmlNamespaceResolver nsResolver);

		/// <summary>
		///         При переопределении в производном классе получает тип результата выражения XPath.
		///       </summary>
		/// <returns>
		///         Значение <see cref="T:System.Xml.XPath.XPathResultType" />, представляющее тип результата выражения XPath.
		///       </returns>
		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060015F4 RID: 5620
		public abstract XPathResultType ReturnType { get; }

		/// <summary>
		///         Компилирует указанное выражение XPath и возвращает объект <see cref="T:System.Xml.XPath.XPathExpression" />, представляющий выражение XPath.
		///       </summary>
		/// <param name="xpath">
		///           Выражение XPath.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр выражения XPath не является допустимым выражением XPath.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x060015F5 RID: 5621 RVA: 0x000855D3 File Offset: 0x000837D3
		public static XPathExpression Compile(string xpath)
		{
			return XPathExpression.Compile(xpath, null);
		}

		/// <summary>
		///         Компилирует заданного выражения XPath с <see cref="T:System.Xml.IXmlNamespaceResolver" /> объекта, указанного для разрешения пространства имен и возвращает <see cref="T:System.Xml.XPath.XPathExpression" /> представляющий выражение XPath.
		///       </summary>
		/// <param name="xpath">
		///           Выражение XPath.
		///         </param>
		/// <param name="nsResolver">
		///           Объект, реализующий интерфейс <see cref="T:System.Xml.IXmlNamespaceResolver" /> интерфейс для разрешения пространства имен.
		///         </param>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathExpression" />.
		///       </returns>
		/// <exception cref="T:System.ArgumentException">
		///             Параметр выражения XPath не является допустимым выражением XPath.
		///           </exception>
		/// <exception cref="T:System.Xml.XPath.XPathException">
		///             Недопустимое выражение XPath.
		///           </exception>
		// Token: 0x060015F6 RID: 5622 RVA: 0x000855DC File Offset: 0x000837DC
		public static XPathExpression Compile(string xpath, IXmlNamespaceResolver nsResolver)
		{
			bool needContext;
			CompiledXpathExpr compiledXpathExpr = new CompiledXpathExpr(new QueryBuilder().Build(xpath, out needContext), xpath, needContext);
			if (nsResolver != null)
			{
				compiledXpathExpr.SetContext(nsResolver);
			}
			return compiledXpathExpr;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00085609 File Offset: 0x00083809
		private void PrintQuery(XmlWriter w)
		{
			((CompiledXpathExpr)this).QueryTree.PrintQuery(w);
		}
	}
}
