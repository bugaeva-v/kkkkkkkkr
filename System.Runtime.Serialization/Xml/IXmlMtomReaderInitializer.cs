using System;
using System.IO;
using System.Text;

namespace System.Xml
{
	/// <summary>Указывает требования реализации для MTOM-модулей чтения текста XML, полученных из этого интерфейса.</summary>
	// Token: 0x0200006D RID: 109
	public interface IXmlMtomReaderInitializer
	{
		/// <summary>Указывает требования инициализации для MTOM-модулей чтения текста XML, выполняющие считывание из буфера.</summary>
		/// <param name="buffer">Буфер, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="encodings">Возможные кодировки на входе.</param>
		/// <param name="contentType">Тип Content-Type сообщения. Может иметь значение <see langword="null" />, если тип MIME присутствует в документе, чтение которого выполняется.</param>
		/// <param name="quotas">Действие <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, к которому должно быть применено изменение.</param>
		/// <param name="maxBufferSize">Максимально допустимый размер буфера.</param>
		/// <param name="onClose">Делегат, используемый в случае возникновения события <see langword="onClose" />.</param>
		// Token: 0x060005DD RID: 1501
		void SetInput(byte[] buffer, int offset, int count, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose);

		/// <summary>Указывает требования инициализации для MTOM-модулей чтения текста XML, выполняющие считывание потока.</summary>
		/// <param name="stream">Поток, из которого требуется выполнить чтение.</param>
		/// <param name="encodings">Возможные кодировки в потоке.</param>
		/// <param name="contentType">Тип Content-Type сообщения. Может иметь значение <see langword="null" />, если тип MIME присутствует в документе, чтение которого выполняется.</param>
		/// <param name="quotas">Действие <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />, к которому должно быть применено изменение.</param>
		/// <param name="maxBufferSize">Максимально допустимый размер буфера.</param>
		/// <param name="onClose">Делегат, используемый в случае возникновения события <see langword="onClose" />.</param>
		// Token: 0x060005DE RID: 1502
		void SetInput(Stream stream, Encoding[] encodings, string contentType, XmlDictionaryReaderQuotas quotas, int maxBufferSize, OnXmlDictionaryReaderClose onClose);
	}
}
