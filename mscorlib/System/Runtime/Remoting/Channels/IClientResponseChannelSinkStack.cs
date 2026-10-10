using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает функциональность для стека приемников канала ответов клиента, который должен вызываться при декодировании асинхронного ответа.</summary>
	// Token: 0x020005BD RID: 1469
	[ComVisible(true)]
	public interface IClientResponseChannelSinkStack
	{
		/// <summary>Запрашивает асинхронную обработку вызова метода на приемники в текущем стеке приемников.</summary>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <param name="stream">Поток возвращается из транспортного приемника.</param>
		/// <exception cref="T:System.Runtime.Remoting.RemotingException">Текущий стек приемников пуст.</exception>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003889 RID: 14473
		void AsyncProcessResponse(ITransportHeaders headers, Stream stream);

		/// <summary>Отправляет указанное исключение в приемник ответов.</summary>
		/// <param name="e">Исключение, отправляемое на сервер.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600388A RID: 14474
		void DispatchException(Exception e);

		/// <summary>Отправляет указанный ответ в приемник ответов.</summary>
		/// <param name="msg">Отправляемое сообщение <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600388B RID: 14475
		void DispatchReplyMessage(IMessage msg);
	}
}
