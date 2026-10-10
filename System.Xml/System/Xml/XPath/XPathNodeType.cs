using System;

namespace System.Xml.XPath
{
	/// <summary>
	///         Определяет типы узлов XPath, которые могут быть возвращены из <see cref="T:System.Xml.XPath.XPathNavigator" /> класса.
	///       </summary>
	// Token: 0x02000264 RID: 612
	public enum XPathNodeType
	{
		/// <summary>
		///         Корневой узел XML-документа или узлом дерева.
		///       </summary>
		// Token: 0x0400182A RID: 6186
		Root,
		/// <summary>
		///         Элемент, такой как &lt;element&gt;.
		///       </summary>
		// Token: 0x0400182B RID: 6187
		Element,
		/// <summary>
		///         Атрибут, такой как id='123'.
		///       </summary>
		// Token: 0x0400182C RID: 6188
		Attribute,
		/// <summary>
		///         В пространстве имен таких как xmlns="namespace".
		///       </summary>
		// Token: 0x0400182D RID: 6189
		Namespace,
		/// <summary>
		///         Содержимое текстового узла.
		///          Эквивалент текст объектной модели документов (DOM) и типам узлов CDATA.
		///          Содержит по крайней мере один символ.
		///       </summary>
		// Token: 0x0400182E RID: 6190
		Text,
		/// <summary>
		///         Узел с пробельные символы и xml:space значение preserve.
		///       </summary>
		// Token: 0x0400182F RID: 6191
		SignificantWhitespace,
		/// <summary>
		///         Узел только пробелы и без значащих пробелов.
		///          Пробельные символы, #x20, #x9, #xD, или #xA.
		///       </summary>
		// Token: 0x04001830 RID: 6192
		Whitespace,
		/// <summary>
		///         Объект обработки, такие как &lt;?pi test?&gt;.
		///          Это не относится к XML-декларации, которые не являются видимыми для <see cref="T:System.Xml.XPath.XPathNavigator" /> класса.
		///       </summary>
		// Token: 0x04001831 RID: 6193
		ProcessingInstruction,
		/// <summary>
		///         Значение комментария, такие как &lt;!-- my comment --&gt;
		///       </summary>
		// Token: 0x04001832 RID: 6194
		Comment,
		/// <summary>
		///         Любой из <see cref="T:System.Xml.XPath.XPathNodeType" /> типов узлов.
		///       </summary>
		// Token: 0x04001833 RID: 6195
		All
	}
}
