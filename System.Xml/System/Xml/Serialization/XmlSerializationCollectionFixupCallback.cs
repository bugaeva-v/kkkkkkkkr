using System;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Делегат, используемый <see cref="T:System.Xml.Serialization.XmlSerializer" /> класса для десериализации данных XML с кодировкой SOAP типы, которые соответствуют коллекциям или перечислениям.
	///       </summary>
	/// <param name="collection">
	///           Коллекция, в которую копируется массив элементов коллекции.
	///         </param>
	/// <param name="collectionItems">
	///           Массив элементов, которые будут скопированы в <paramref name="object collection" />.
	///         </param>
	// Token: 0x020002F0 RID: 752
	// (Invoke) Token: 0x06001DFC RID: 7676
	public delegate void XmlSerializationCollectionFixupCallback(object collection, object collectionItems);
}
