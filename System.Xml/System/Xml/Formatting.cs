using System;

namespace System.Xml
{
	/// <summary>
	///         Определяет параметры форматирования для <see cref="T:System.Xml.XmlTextWriter" />.
	///       </summary>
	// Token: 0x02000116 RID: 278
	public enum Formatting
	{
		/// <summary>
		///         Специальное форматирование не применяется.
		///          Это значение по умолчанию.
		///       </summary>
		// Token: 0x04000BDB RID: 3035
		None,
		/// <summary>
		///         Вызывает дочерние элементы, чтобы иметь отступ в соответствии с <see cref="P:System.Xml.XmlTextWriter.Indentation" /> и <see cref="P:System.Xml.XmlTextWriter.IndentChar" /> Параметры.
		///       </summary>
		// Token: 0x04000BDC RID: 3036
		Indented
	}
}
