using System;
using System.IO;
using System.Text;

namespace System.Xml
{
	/// <summary>Указывает требования реализации для модулей записи текста XML, полученных из этого интерфейса.</summary>
	// Token: 0x0200009C RID: 156
	public interface IXmlTextWriterInitializer
	{
		/// <summary>Указывает требования инициализации для модулей записи текста XML, реализующих этот метод.</summary>
		/// <param name="stream">Поток, в который требуется выполнить запись.</param>
		/// <param name="encoding">Кодировка в потоке.</param>
		/// <param name="ownsStream">Значение <see langword="true" /> для указания того, что поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x0600084C RID: 2124
		void SetOutput(Stream stream, Encoding encoding, bool ownsStream);
	}
}
