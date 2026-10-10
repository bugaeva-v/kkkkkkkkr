using System;
using System.IO;

namespace System.Xml
{
	/// <summary>Представляет интерфейс, который может реализовываться классами, предоставляющими потоки.</summary>
	// Token: 0x0200001D RID: 29
	public interface IStreamProvider
	{
		/// <summary>Возвращает поток.</summary>
		/// <returns>Объект <see cref="T:System.IO.Stream" />.</returns>
		// Token: 0x0600008F RID: 143
		Stream GetStream();

		/// <summary>Освобождает поток для вывода.</summary>
		/// <param name="stream">Поток освобожден.</param>
		// Token: 0x06000090 RID: 144
		void ReleaseStream(Stream stream);
	}
}
