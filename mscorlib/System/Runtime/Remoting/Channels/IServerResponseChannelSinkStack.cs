using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает функционирование стека для стека приемников каналов ответов сервера.</summary>
	// Token: 0x020005C3 RID: 1475
	[ComVisible(true)]
	public interface IServerResponseChannelSinkStack
	{
		/// <summary>Запрашивает асинхронную обработку вызова метода на приемники в текущем стеке приемников.</summary>
		/// <param name="msg">Ответное сообщение.</param>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <param name="stream">Поток возвращается из транспортного приемника.</param>
		// Token: 0x0600389B RID: 14491
		void AsyncProcessResponse(IMessage msg, ITransportHeaders headers, Stream stream);

		/// <summary>Возвращает поток <see cref="T:System.IO.Stream" />, на котором упорядочивается указанное сообщение.</summary>
		/// <param name="msg">Сообщение, упорядочиваемое на запрошенном потоке.</param>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <returns>Поток <see cref="T:System.IO.Stream" />, на котором упорядочивается указанное сообщение.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600389C RID: 14492
		Stream GetResponseStream(IMessage msg, ITransportHeaders headers);
	}
}
