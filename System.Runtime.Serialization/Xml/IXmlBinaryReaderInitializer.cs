using System;
using System.IO;

namespace System.Xml
{
	/// <summary>Предоставляет методы для повторной инициализации средства чтения двоичных данных для считывания нового документа.</summary>
	// Token: 0x02000049 RID: 73
	public interface IXmlBinaryReaderInitializer
	{
		/// <summary>Повторно инициализирует модуль чтения двоичных данных, используя предоставленный входной буфер.</summary>
		/// <param name="buffer">Буфер, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="dictionary">Объект <see cref="T:System.Xml.XmlDictionary" />, который следует использовать.</param>
		/// <param name="quotas">Применяемый объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="session">Объект <see cref="T:System.Xml.XmlBinaryReaderSession" />, который следует использовать.</param>
		/// <param name="onClose">Делегат, вызываемый при закрытии модуля чтения.</param>
		// Token: 0x060002C0 RID: 704
		void SetInput(byte[] buffer, int offset, int count, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose);

		/// <summary>Повторно инициализирует средство чтения двоичных данных, используя предоставленный входной поток.</summary>
		/// <param name="stream">Поток, из которого требуется выполнить чтение.</param>
		/// <param name="dictionary">Объект <see cref="T:System.Xml.XmlDictionary" />, который следует использовать.</param>
		/// <param name="quotas">Применяемый объект <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="session">Объект <see cref="T:System.Xml.XmlBinaryReaderSession" />, который следует использовать.</param>
		/// <param name="onClose">Делегат, вызываемый при закрытии модуля чтения.</param>
		// Token: 0x060002C1 RID: 705
		void SetInput(Stream stream, IXmlDictionary dictionary, XmlDictionaryReaderQuotas quotas, XmlBinaryReaderSession session, OnXmlDictionaryReaderClose onClose);
	}
}
