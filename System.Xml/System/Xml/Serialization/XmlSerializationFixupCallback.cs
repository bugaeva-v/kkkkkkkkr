using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Делегат, используемый <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса для десериализации данных XML с кодировкой SOAP.
	///       </summary>
	/// <param name="fixup">
	///           Экземпляр <see cref="T:System.Xml.Serialization.XmlSerializationReader.Fixup" /> класса, содержащего объект должен быть фиксированным и массив строковых идентификаторов элементов для заполнения.
	///         </param>
	// Token: 0x020002EF RID: 751
	// (Invoke) Token: 0x06001DF8 RID: 7672
	public delegate void XmlSerializationFixupCallback(object fixup);
}
