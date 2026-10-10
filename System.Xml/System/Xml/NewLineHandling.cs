using System;

namespace System.Xml
{
	/// <summary>
	///         Задает порядок обработки разрывов строк.
	///       </summary>
	// Token: 0x02000046 RID: 70
	public enum NewLineHandling
	{
		/// <summary>
		///         Символы новой строки заменяются в соответствии с символа, указанного в <see cref="P:System.Xml.XmlWriterSettings.NewLineChars" />  свойство.
		///       </summary>
		// Token: 0x04000610 RID: 1552
		Replace,
		/// <summary>
		///         Символы новой строки преобразуются в сущности.
		///          Этот параметр сохраняет все знаки, если выходные данные считываются путем нормализации <see cref="T:System.Xml.XmlReader" />.
		///       </summary>
		// Token: 0x04000611 RID: 1553
		Entitize,
		/// <summary>
		///         Символы новой строки не изменяются.
		///          Выходные данные является таким же, как входные данные.
		///       </summary>
		// Token: 0x04000612 RID: 1554
		None
	}
}
