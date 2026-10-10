using System;

namespace System.Xml.XPath
{
	/// <summary>
	///         Предоставляет метод доступа для <see cref="T:System.Xml.XPath.XPathNavigator" /> класса.
	///       </summary>
	// Token: 0x0200024E RID: 590
	public interface IXPathNavigable
	{
		/// <summary>
		///         Возвращает новый объект <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </summary>
		/// <returns>
		///         Объект <see cref="T:System.Xml.XPath.XPathNavigator" />.
		///       </returns>
		// Token: 0x060015C7 RID: 5575
		XPathNavigator CreateNavigator();
	}
}
