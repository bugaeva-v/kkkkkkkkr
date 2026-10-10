using System;
using System.Xml.Schema;

namespace System.Xml.Serialization
{
	/// <summary>
	///         Предоставляет пользовательский формат для сериализации и десериализации XML.
	///       </summary>
	// Token: 0x0200027B RID: 635
	public interface IXmlSerializable
	{
		/// <summary>
		///         Данный метод зарезервирован и не используется.
		///          При реализации интерфейса <see langword="IXmlSerializable" /> вы должны возвращать <see langword="null" /> (<see langword="Nothing" /> в Visual Basic) из этого метода, и если требуется указание пользовательской схемы, применить к классу <see cref="T:System.Xml.Serialization.XmlSchemaProviderAttribute" />.
		///       </summary>
		/// <returns>
		///         Схема <see cref="T:System.Xml.Schema.XmlSchema" />, описывающая представление XML объекта, полученного методом <see cref="M:System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter)" /> и используемого методом <see cref="M:System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader)" />.
		///       </returns>
		// Token: 0x0600180D RID: 6157
		XmlSchema GetSchema();

		/// <summary>
		///         Создает объект из представления XML.
		///       </summary>
		/// <param name="reader">
		///           Поток <see cref="T:System.Xml.XmlReader" />, из которого выполняется десериализация объекта.
		///         </param>
		// Token: 0x0600180E RID: 6158
		void ReadXml(XmlReader reader);

		/// <summary>
		///         Преобразует объект в представление XML.
		///       </summary>
		/// <param name="writer">
		///           Поток <see cref="T:System.Xml.XmlWriter" />, в который выполняется сериализация объекта.
		///         </param>
		// Token: 0x0600180F RID: 6159
		void WriteXml(XmlWriter writer);
	}
}
