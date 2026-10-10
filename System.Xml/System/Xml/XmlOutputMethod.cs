using System;

namespace System.Xml
{
	/// <summary>
	///         Определяет метод, используемый для сериализации <see cref="T:System.Xml.XmlWriter" /> Выходные данные.
	///       </summary>
	// Token: 0x02000182 RID: 386
	public enum XmlOutputMethod
	{
		/// <summary>
		///         Сериализация в соответствии с правилами XML 1.0.
		///       </summary>
		// Token: 0x04000EEB RID: 3819
		Xml,
		/// <summary>
		///         Сериализация в соответствии с правилами HTML, заданными XSLT.
		///       </summary>
		// Token: 0x04000EEC RID: 3820
		Html,
		/// <summary>
		///         Сериализует только текстовые блоки.
		///       </summary>
		// Token: 0x04000EED RID: 3821
		Text,
		/// <summary>
		///         Используйте правила XSLT для выбора между <see cref="F:System.Xml.XmlOutputMethod.Xml" /> и <see cref="F:System.Xml.XmlOutputMethod.Html" /> вывода методов во время выполнения.
		///       </summary>
		// Token: 0x04000EEE RID: 3822
		AutoDetect
	}
}
