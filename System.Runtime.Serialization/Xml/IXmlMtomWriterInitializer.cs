using System;
using System.IO;
using System.Text;

namespace System.Xml
{
	/// <summary>Будучи реализованным модулем записи MTOM, этот интерфейс обеспечивает инициализацию модуля записи MTOM.</summary>
	// Token: 0x02000082 RID: 130
	public interface IXmlMtomWriterInitializer
	{
		/// <summary>Будучи реализованным модулем записи MTOM, выполняет инициализацию модуля записи MTOM.</summary>
		/// <param name="stream">Поток, в который требуется выполнить запись.</param>
		/// <param name="encoding">Кодировка в потоке.</param>
		/// <param name="maxSizeInBytes">Максимальное число копируемых в буфер модуля записи байтов.</param>
		/// <param name="startInfo">Атрибут в заголовке SOAP ContentType, которому задано значение «Application/soap+xml».</param>
		/// <param name="boundary">Граничная строка MIME.</param>
		/// <param name="startUri">Универсальный код ресурса (URI) для раздела MIME.</param>
		/// <param name="writeMessageHeaders">Если значение <see langword="true" />, выполнятся запись заголовков сообщений.</param>
		/// <param name="ownsStream">Значение <see langword="true" /> для указания того, что поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060006E9 RID: 1769
		void SetOutput(Stream stream, Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream);
	}
}
