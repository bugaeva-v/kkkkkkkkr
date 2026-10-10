using System;

namespace System.Xml.Xsl
{
	/// <summary>
	///         Предоставляет данные для события <see cref="E:System.Xml.Xsl.XsltArgumentList.XsltMessageEncountered" />.
	///       </summary>
	// Token: 0x02000346 RID: 838
	public abstract class XsltMessageEncounteredEventArgs : EventArgs
	{
		/// <summary>
		///         Возвращает содержимое xsl:message элемента.
		///       </summary>
		/// <returns>
		///         Содержимое xsl:message элемента.
		///       </returns>
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060022B8 RID: 8888
		public abstract string Message { get; }
	}
}
