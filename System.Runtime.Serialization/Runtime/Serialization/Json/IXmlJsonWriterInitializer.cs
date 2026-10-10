using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Runtime.Serialization.Json
{
	/// <summary>Задает интерфейс для инициализации модуля записи нотации объектов JavaScript (JSON) при его повторном использовании для записи в конкретный выходной поток.</summary>
	// Token: 0x02000168 RID: 360
	[TypeForwardedFrom("System.ServiceModel.Web, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
	public interface IXmlJsonWriterInitializer
	{
		/// <summary>Инициализирует (или повторно инициализирует) модуль записи нотации объектов JavaScript (JSON) для заданного выходного потока с заданной кодировкой.</summary>
		/// <param name="stream">Выходной поток <see cref="T:System.IO.Stream" />, в который модуль записи осуществляет запись.</param>
		/// <param name="encoding">Параметр <see cref="T:System.Text.Encoding" />, указывающий кодировку выходного потока.</param>
		/// <param name="ownsStream">Значение <see langword="true" />, если выходной поток закрывается средством записи после завершения; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06001301 RID: 4865
		void SetOutput(Stream stream, Encoding encoding, bool ownsStream);
	}
}
