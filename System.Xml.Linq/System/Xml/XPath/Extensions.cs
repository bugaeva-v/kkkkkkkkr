using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace System.Xml.XPath
{
	/// <summary>Этот класс содержит методы расширения LINQ to XML, позволяющие вычислять выражения XPath.</summary>
	// Token: 0x02000008 RID: 8
	public static class Extensions
	{
		/// <summary>Создает <see cref="T:System.Xml.XPath.XPathNavigator" /> для <see cref="T:System.Xml.Linq.XNode" />.</summary>
		/// <param name="node">Объект <see cref="T:System.Xml.Linq.XNode" />, который может обрабатывать запросы XPath.</param>
		/// <returns>Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, который может обрабатывать запросы XPath.</returns>
		// Token: 0x0600004C RID: 76 RVA: 0x00003353 File Offset: 0x00001553
		public static XPathNavigator CreateNavigator(this XNode node)
		{
			return node.CreateNavigator(null);
		}

		/// <summary>Создает <see cref="T:System.Xml.XPath.XPathNavigator" /> для <see cref="T:System.Xml.Linq.XNode" />. <see cref="T:System.Xml.XmlNameTable" /> обеспечивает более эффективную обработку выражений XPath.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, который может обработать запрос XPath.</param>
		/// <param name="nameTable">
		///   <see cref="T:System.Xml.XmlNameTable" /> для использования <see cref="T:System.Xml.XPath.XPathNavigator" />.</param>
		/// <returns>Объект <see cref="T:System.Xml.XPath.XPathNavigator" />, который может обрабатывать запросы XPath.</returns>
		// Token: 0x0600004D RID: 77 RVA: 0x0000335C File Offset: 0x0000155C
		public static XPathNavigator CreateNavigator(this XNode node, XmlNameTable nameTable)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			if (node is XDocumentType)
			{
				throw new ArgumentException(SR.Format("This XPathNavigator cannot be created on a node of type {0}.", XmlNodeType.DocumentType));
			}
			XText xtext = node as XText;
			if (xtext != null)
			{
				if (xtext.GetParent() is XDocument)
				{
					throw new ArgumentException(SR.Format("This XPathNavigator cannot be created on a node of type {0}.", XmlNodeType.Whitespace));
				}
				node = Extensions.CalibrateText(xtext);
			}
			return new XNodeNavigator(node, nameTable);
		}

		/// <summary>Вычисляет выражение XPath.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <returns>Объект, который может содержать <see langword="bool" />, <see langword="double" />, <see langword="string" /> или <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		// Token: 0x0600004E RID: 78 RVA: 0x000033D3 File Offset: 0x000015D3
		public static object XPathEvaluate(this XNode node, string expression)
		{
			return node.XPathEvaluate(expression, null);
		}

		/// <summary>Вычисляет выражение XPath, разрешая префиксы пространств имен с помощью указанного <see cref="T:System.Xml.IXmlNamespaceResolver" />.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <param name="resolver">
		///   <see cref="T:System.Xml.IXmlNamespaceResolver" /> для префиксов пространств имен в выражении XPath.</param>
		/// <returns>Объект, содержащий результат вычисления выражения. Объект может иметь тип <see langword="bool" />, <see langword="double" />, <see langword="string" /> или <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
		// Token: 0x0600004F RID: 79 RVA: 0x000033E0 File Offset: 0x000015E0
		public static object XPathEvaluate(this XNode node, string expression, IXmlNamespaceResolver resolver)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			return default(XPathEvaluator).Evaluate<object>(node, expression, resolver);
		}

		/// <summary>Выбирает <see cref="T:System.Xml.Linq.XElement" /> с помощью выражения XPath.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XElement" /> или null.</returns>
		// Token: 0x06000050 RID: 80 RVA: 0x0000340C File Offset: 0x0000160C
		public static XElement XPathSelectElement(this XNode node, string expression)
		{
			return node.XPathSelectElement(expression, null);
		}

		/// <summary>Выбирает <see cref="T:System.Xml.Linq.XElement" /> с помощью выражения XPath, разрешая префиксы пространства имен с помощью указанного <see cref="T:System.Xml.IXmlNamespaceResolver" />.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <param name="resolver">
		///   <see cref="T:System.Xml.IXmlNamespaceResolver" /> для префиксов пространств имен в выражении XPath.</param>
		/// <returns>
		///   <see cref="T:System.Xml.Linq.XElement" /> или null.</returns>
		// Token: 0x06000051 RID: 81 RVA: 0x00003416 File Offset: 0x00001616
		public static XElement XPathSelectElement(this XNode node, string expression, IXmlNamespaceResolver resolver)
		{
			return node.XPathSelectElements(expression, resolver).FirstOrDefault<XElement>();
		}

		/// <summary>Выбирает коллекцию элементов с помощью выражения XPath.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащего выбранные элементы.</returns>
		// Token: 0x06000052 RID: 82 RVA: 0x00003425 File Offset: 0x00001625
		public static IEnumerable<XElement> XPathSelectElements(this XNode node, string expression)
		{
			return node.XPathSelectElements(expression, null);
		}

		/// <summary>Выбирает коллекцию элементов с помощью выражения XPath, разрешая префиксы пространства имен с помощью указанного <see cref="T:System.Xml.IXmlNamespaceResolver" />.</summary>
		/// <param name="node">
		///   <see cref="T:System.Xml.Linq.XNode" />, в котором вычисляется выражение XPath.</param>
		/// <param name="expression">
		///   <see cref="T:System.String" />, содержащая выражение XPath.</param>
		/// <param name="resolver">
		///   <see cref="T:System.Xml.IXmlNamespaceResolver" /> для префиксов пространств имен в выражении XPath.</param>
		/// <returns>
		///   <see cref="T:System.Collections.Generic.IEnumerable`1" /> для <see cref="T:System.Xml.Linq.XElement" />, содержащего выбранные элементы.</returns>
		// Token: 0x06000053 RID: 83 RVA: 0x00003430 File Offset: 0x00001630
		public static IEnumerable<XElement> XPathSelectElements(this XNode node, string expression, IXmlNamespaceResolver resolver)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			return (IEnumerable<XElement>)default(XPathEvaluator).Evaluate<XElement>(node, expression, resolver);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003464 File Offset: 0x00001664
		private static XText CalibrateText(XText n)
		{
			XContainer parent = n.GetParent();
			if (parent == null)
			{
				return n;
			}
			foreach (XNode xnode in parent.Nodes())
			{
				XText xtext = xnode as XText;
				if (xtext != null && xnode == n)
				{
					return xtext;
				}
			}
			return null;
		}
	}
}
