using System;
using System.IO;

namespace System.Xml
{
	/// <summary>Указывает требования реализации для модулей записи двоичных данных XML, полученных из этого интерфейса.</summary>
	// Token: 0x0200004D RID: 77
	public interface IXmlBinaryWriterInitializer
	{
		/// <summary>Указывает требования инициализации для модулей записи двоичных данных XML, реализующих этот метод.</summary>
		/// <param name="stream">Поток, в который требуется выполнить запись.</param>
		/// <param name="dictionary">Используемый <see cref="T:System.Xml.XmlDictionary" />.</param>
		/// <param name="session">Используемый <see cref="T:System.Xml.XmlBinaryWriterSession" />.</param>
		/// <param name="ownsStream">Значение <see langword="true" /> для указания того, что поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600031B RID: 795
		void SetOutput(Stream stream, IXmlDictionary dictionary, XmlBinaryWriterSession session, bool ownsStream);
	}
}
