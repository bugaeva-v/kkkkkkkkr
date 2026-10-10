using System;

namespace System.Xml
{
	/// <summary>
	///         Задает тип узла.
	///       </summary>
	// Token: 0x02000241 RID: 577
	public enum XmlNodeType
	{
		/// <summary>
		///         Это значение возвращается с <see cref="T:System.Xml.XmlReader" /> Если <see langword="Read" /> не был вызван метод.
		///       </summary>
		// Token: 0x040012F3 RID: 4851
		None,
		/// <summary>
		///         Элемент (например, &lt;item&gt; ).
		///       </summary>
		// Token: 0x040012F4 RID: 4852
		Element,
		/// <summary>
		///         Атрибут (например, id='123' ).
		///       </summary>
		// Token: 0x040012F5 RID: 4853
		Attribute,
		/// <summary>
		///         Содержимое текстового узла.
		///       </summary>
		// Token: 0x040012F6 RID: 4854
		Text,
		/// <summary>
		///         Раздел CDATA (например, &lt;![CDATA[my escaped text]]&gt; ).
		///       </summary>
		// Token: 0x040012F7 RID: 4855
		CDATA,
		/// <summary>
		///         Ссылка на сущность (например, &amp;num; ).
		///       </summary>
		// Token: 0x040012F8 RID: 4856
		EntityReference,
		/// <summary>
		///         Объявление сущности (например, &lt;!ENTITY...&gt; ).
		///       </summary>
		// Token: 0x040012F9 RID: 4857
		Entity,
		/// <summary>
		///         Инструкции по обработке (например, &lt;?pi test?&gt; ).
		///       </summary>
		// Token: 0x040012FA RID: 4858
		ProcessingInstruction,
		/// <summary>
		///         Комментарий (например, &lt;!-- my comment --&gt; ).
		///       </summary>
		// Token: 0x040012FB RID: 4859
		Comment,
		/// <summary>
		///         Объект документа, как корень дерева документов, предоставляет доступ ко всему документу XML.
		///       </summary>
		// Token: 0x040012FC RID: 4860
		Document,
		/// <summary>
		///         Объявление типа документа, обозначается следующим тегом (например, &lt;!DOCTYPE...&gt; ).
		///       </summary>
		// Token: 0x040012FD RID: 4861
		DocumentType,
		/// <summary>
		///         Фрагмент документа.
		///       </summary>
		// Token: 0x040012FE RID: 4862
		DocumentFragment,
		/// <summary>
		///         Нотация в объявлении типа документа (например, &lt;!NOTATION...&gt; ).
		///       </summary>
		// Token: 0x040012FF RID: 4863
		Notation,
		/// <summary>
		///         Пробелы между разметкой.
		///       </summary>
		// Token: 0x04001300 RID: 4864
		Whitespace,
		/// <summary>
		///         Пробел между элементами разметки в смешанной модели содержимого или пробел в xml:space="preserve" области.
		///       </summary>
		// Token: 0x04001301 RID: 4865
		SignificantWhitespace,
		/// <summary>
		///         Закрывающий тег (например, &lt;/item&gt; ).
		///       </summary>
		// Token: 0x04001302 RID: 4866
		EndElement,
		/// <summary>
		///         Возвращается, когда <see langword="XmlReader" /> доходит до конца новой сущности в результате вызова <see cref="M:System.Xml.XmlReader.ResolveEntity" />.
		///       </summary>
		// Token: 0x04001303 RID: 4867
		EndEntity,
		/// <summary>
		///         XML-декларация (например, &lt;?xml version='1.0'?&gt; ).
		///       </summary>
		// Token: 0x04001304 RID: 4868
		XmlDeclaration
	}
}
