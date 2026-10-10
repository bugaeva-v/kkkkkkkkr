using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Делегат, используемый <see cref="T:System.Xml.Serialization.XmlSerializer" /> класс для сериализации типов с кодировкой SOAP, отличного от корневого XML-данных.
	///       </summary>
	/// <param name="o">
	///           Сериализуемый объект.
	///         </param>
	// Token: 0x020002FA RID: 762
	// (Invoke) Token: 0x06001F3B RID: 7995
	public delegate void XmlSerializationWriteCallback(object o);
}
