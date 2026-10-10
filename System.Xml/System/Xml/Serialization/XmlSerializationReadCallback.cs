using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Делегат, используемый <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса для десериализации типов с кодировкой SOAP, отличного от корневого XML-данных.
	///       </summary>
	/// <returns>
	///         Объект, возвращенный обратным вызовом.
	///       </returns>
	// Token: 0x020002F1 RID: 753
	// (Invoke) Token: 0x06001E00 RID: 7680
	public delegate object XmlSerializationReadCallback();
}
