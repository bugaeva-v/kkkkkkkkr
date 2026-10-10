using System;

namespace System.Xml
{
	/// <summary>
	///         Задает параметры для обработки DTD.
	///         <see cref="T:System.Xml.DtdProcessing" /> Перечисление используется методом <see cref="T:System.Xml.XmlReaderSettings" /> класса.
	///       </summary>
	// Token: 0x0200002F RID: 47
	public enum DtdProcessing
	{
		/// <summary>
		///         Указывает, что при обнаружении DTD, <see cref="T:System.Xml.XmlException" /> исключение с сообщением о том, что запрещено DTD.
		///          Это поведение установлено по умолчанию.
		///       </summary>
		// Token: 0x040005E4 RID: 1508
		Prohibit,
		/// <summary>
		///         Заставляет элемент DOCTYPE игнорироваться.
		///          Обработка DTD не выполнялась.
		///       </summary>
		// Token: 0x040005E5 RID: 1509
		Ignore,
		/// <summary>
		///         Используется для анализа DTD.
		///       </summary>
		// Token: 0x040005E6 RID: 1510
		Parse
	}
}
