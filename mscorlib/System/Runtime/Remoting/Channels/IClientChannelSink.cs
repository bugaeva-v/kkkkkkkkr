using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Предоставляет требуемые функции и свойства для приемников каналов клиента.</summary>
	// Token: 0x020005B8 RID: 1464
	[ComVisible(true)]
	public interface IClientChannelSink : IChannelSinkBase
	{
		/// <summary>Возвращает следующий приемник канала клиента в цепи приемников клиентов.</summary>
		/// <returns>Следующий приемник канала клиента в цепи приемников клиентов.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x0600387F RID: 14463
		IClientChannelSink NextChannelSink { get; }

		/// <summary>Запрашивает асинхронную обработку вызова метода текущего приемника.</summary>
		/// <param name="sinkStack">Стек приемников канала, вызывающий этот приемник.</param>
		/// <param name="msg">Сообщение для обработки.</param>
		/// <param name="headers">Заголовки, добавляемые в исходящее сообщение, отправляемое на сервер.</param>
		/// <param name="stream">Поток направляется в транспортный приемник.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003880 RID: 14464
		void AsyncProcessRequest(IClientChannelSinkStack sinkStack, IMessage msg, ITransportHeaders headers, Stream stream);

		/// <summary>Запрашивает асинхронную обработку ответа на метод вызова на текущем приемнике.</summary>
		/// <param name="sinkStack">Стек приемников, вызывающий этот приемник.</param>
		/// <param name="state">Сведения, созданные на стороне запроса, который связан с этим приемником.</param>
		/// <param name="headers">Заголовки, извлекаемые из потока ответа сервера.</param>
		/// <param name="stream">Поток возвращается из транспортного приемника.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003881 RID: 14465
		void AsyncProcessResponse(IClientResponseChannelSinkStack sinkStack, object state, ITransportHeaders headers, Stream stream);

		/// <summary>Возвращает поток <see cref="T:System.IO.Stream" />, на котором упорядочивается обеспеченное сообщение.</summary>
		/// <param name="msg">Сообщение <see cref="T:System.Runtime.Remoting.Messaging.IMethodCallMessage" />, содержащее сведения о вызове метода.</param>
		/// <param name="headers">Заголовки, добавляемые в исходящее сообщение, отправляемое на сервер.</param>
		/// <returns>Поток <see cref="T:System.IO.Stream" />, на котором упорядочивается обеспеченное сообщение.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003882 RID: 14466
		Stream GetRequestStream(IMessage msg, ITransportHeaders headers);

		/// <summary>Запрашивает обработку сообщения из текущего приемника.</summary>
		/// <param name="msg">Сообщение для обработки.</param>
		/// <param name="requestHeaders">Заголовки, добавляемые в исходящее сообщение, отправляемое на сервер.</param>
		/// <param name="requestStream">Поток направляется в транспортный приемник.</param>
		/// <param name="responseHeaders">Когда возвращается этот метод, он содержит интерфейс <see cref="T:System.Runtime.Remoting.Channels.ITransportHeaders" />, содержащий заголовки, возвращаемые сервером. Этот параметр передается неинициализированным.</param>
		/// <param name="responseStream">Когда возвращается этот метод, он содержит поток <see cref="T:System.IO.Stream" />, возвращающийся из транспортного приемника. Этот параметр передается неинициализированным.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003883 RID: 14467
		void ProcessMessage(IMessage msg, ITransportHeaders requestHeaders, Stream requestStream, out ITransportHeaders responseHeaders, out Stream responseStream);
	}
}
