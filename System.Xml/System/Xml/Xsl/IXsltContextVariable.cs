using System;
using System.Xml.XPath;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Предоставляет интерфейс для данной переменной, которая определена в таблице стилей во время выполнения.
	///       </summary>
	// Token: 0x0200034A RID: 842
	public interface IXsltContextVariable
	{
		/// <summary>
		///         Возвращает значение, указывающее, является ли переменная локальной.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если переменная является локальной переменной в текущем контексте; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060022CE RID: 8910
		bool IsLocal { get; }

		/// <summary>
		///         Возвращает значение, указывающее, является ли переменная параметром таблицы стилей преобразования (XSLT).
		///          Это может быть параметр таблицы стилей или шаблона.
		///       </summary>
		/// <returns>
		///         <see langword="true" /> Если переменная является параметром XSLT; в противном случае — <see langword="false" />.
		///       </returns>
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060022CF RID: 8911
		bool IsParam { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XPath.XPathResultType" /> представляет язык XML Path (XPath) тип переменной.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XPath.XPathResultType" /> Представляет тип XPath переменной.
		///       </returns>
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060022D0 RID: 8912
		XPathResultType VariableType { get; }

		/// <summary>
		///         Вычисляет значение переменной во время выполнения и возвращает объект, представляющий значение переменной.
		///       </summary>
		/// <param name="xsltContext">
		///           <see cref="T:System.Xml.Xsl.XsltContext" /> Представляет контекст выполнения переменной.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Представляет значение переменной.
		///          Возможные типы возвращаемых значений включают число, строка, логическое значение, фрагмент документа или набор узлов.
		///       </returns>
		// Token: 0x060022D1 RID: 8913
		object Evaluate(XsltContext xsltContext);
	}
}
