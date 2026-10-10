using System;
using System.Xml.XPath;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Предоставляет интерфейс для заданной функции, определенной в таблице стилей для таблицы стилей преобразования (XSLT) во время выполнения.
	///       </summary>
	// Token: 0x02000349 RID: 841
	public interface IXsltContextFunction
	{
		/// <summary>
		///         Возвращает минимальное количество аргументов функции.
		///          Это позволяет пользователю различать перегруженные функции.
		///       </summary>
		/// <returns>
		///         Минимальное число аргументов для функции.
		///       </returns>
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060022C9 RID: 8905
		int Minargs { get; }

		/// <summary>
		///         Возвращает максимальное количество аргументов функции.
		///          Это позволяет пользователю различать перегруженные функции.
		///       </summary>
		/// <returns>
		///         Максимальное количество аргументов функции.
		///       </returns>
		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060022CA RID: 8906
		int Maxargs { get; }

		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XPath.XPathResultType" /> представляет тип XPath, возвращаемый функцией.
		///       </summary>
		/// <returns>
		///         <see cref="T:System.Xml.XPath.XPathResultType" /> Представляет тип XPath, возвращаемый функцией 
		///       </returns>
		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060022CB RID: 8907
		XPathResultType ReturnType { get; }

		/// <summary>
		///         Возвращает типы язык XML Path (XPath) для списка аргументов функции.
		///          Эта информация может использоваться для определения подписи функции, которая позволяет различать перегруженные функции.
		///       </summary>
		/// <returns>
		///         Массив <see cref="T:System.Xml.XPath.XPathResultType" /> представляют типы для списка аргументов функции.
		///       </returns>
		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060022CC RID: 8908
		XPathResultType[] ArgTypes { get; }

		/// <summary>
		///         Предоставляет метод для вызова функции с заданными аргументами в заданном контексте.
		///       </summary>
		/// <param name="xsltContext">
		///           Контекст XSLT для вызова функции.
		///         </param>
		/// <param name="args">
		///           Аргументы вызова функции.
		///            Каждый аргумент является элементом в массиве.
		///         </param>
		/// <param name="docContext">
		///           Узел контекста для вызова функции.
		///         </param>
		/// <returns>
		///         <see cref="T:System.Object" /> Представляет возвращаемое значение функции.
		///       </returns>
		// Token: 0x060022CD RID: 8909
		object Invoke(XsltContext xsltContext, object[] args, XPathNavigator docContext);
	}
}
