using System;

namespace System.Xml
{
	/// <summary>
	///         Позволяет классу возвращать <see cref="T:System.Xml.XmlNode" /> из текущего контекста или положения.
	///       </summary>
	// Token: 0x020001E1 RID: 481
	public interface IHasXmlNode
	{
		/// <summary>
		///         Возвращает <see cref="T:System.Xml.XmlNode" /> для текущего положения.
		///       </summary>
		/// <returns>
		///         <see langword="XmlNode" /> Для текущего положения.
		///       </returns>
		// Token: 0x0600131A RID: 4890
		XmlNode GetNode();
	}
}
