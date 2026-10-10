using System;
using System.IO;
using System.Text;

namespace System.Xml
{
	/// <summary>Указывает требования реализации для модулей чтения текста XML, полученных из этого интерфейса.</summary>
	// Token: 0x02000099 RID: 153
	public interface IXmlTextReaderInitializer
	{
		/// <summary>Указывает требования инициализации для модулей чтения текста XML, выполняющие считывание из буфера.</summary>
		/// <param name="buffer">Буфер, из которого выполняется чтение.</param>
		/// <param name="offset">Начальное положение для чтения из параметра <paramref name="buffer" />.</param>
		/// <param name="count">Количество байтов, которое может быть считано из параметра <paramref name="buffer" />.</param>
		/// <param name="encoding">Кодировка в потоке.</param>
		/// <param name="quotas">Применяемый режим <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="onClose">Делегат, вызываемый при закрытии модуля чтения.</param>
		// Token: 0x06000829 RID: 2089
		void SetInput(byte[] buffer, int offset, int count, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);

		/// <summary>Указывает требования инициализации для модулей чтения текста XML, выполняющие считывание потока.</summary>
		/// <param name="stream">Поток, из которого требуется выполнить чтение.</param>
		/// <param name="encoding">Кодировка в потоке.</param>
		/// <param name="quotas">Применяемый режим <see cref="T:System.Xml.XmlDictionaryReaderQuotas" />.</param>
		/// <param name="onClose">Делегат, вызываемый при закрытии модуля чтения.</param>
		// Token: 0x0600082A RID: 2090
		void SetInput(Stream stream, Encoding encoding, XmlDictionaryReaderQuotas quotas, OnXmlDictionaryReaderClose onClose);
	}
}
