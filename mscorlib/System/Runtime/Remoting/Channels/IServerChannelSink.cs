using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace System.Runtime.Remoting.Channels
{
	/// <summary>Обеспечивает методы, используемые для обеспечения безопасности и приемников переноса.</summary>
	// Token: 0x020005BF RID: 1471
	[ComVisible(true)]
	public interface IServerChannelSink : IChannelSinkBase
	{
		/// <summary>Получает следующий приемник канала сервера в цепи приемников сервера.</summary>
		/// <returns>Следующий приемник канала сервера в цепи приемников сервера.</returns>
		/// <exception cref="T:System.Security.SecurityException">Непосредственный вызывающий не имеет требуемого разрешения <see cref="F:System.Security.Permissions.SecurityPermissionFlag.Infrastructure" />.</exception>
		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x0600388E RID: 14478
		IServerChannelSink NextChannelSink { get; }

		/// <summary>Запрашивает обработку из текущего приемника ответа от вызова метода, отправленного асинхронно.</summary>
		/// <param name="sinkStack">Стек приемников, ведущий назад в приемник серверной транспортировки.</param>
		/// <param name="state">Сведения, созданные на стороне запроса, который связан с этим приемником.</param>
		/// <param name="msg">Ответное сообщение.</param>
		/// <param name="headers">Заголовки, добавляемые в возвращенное сообщение, отправляемое клиенту.</param>
		/// <param name="stream">Поток, отправляемый обратно в приемник транспортировки.</param>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x0600388F RID: 14479
		void AsyncProcessResponse(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers, Stream stream);

		/// <summary>Возвращает <see cref="T:System.IO.Stream" />, в который необходимо сериализовать предоставленное ответное сообщение.</summary>
		/// <param name="sinkStack">Стек приемников, ведущий назад в приемник серверной транспортировки.</param>
		/// <param name="state">Состояние, переданное стеку данным приемником.</param>
		/// <param name="msg">Сериализуемое ответное сообщение.</param>
		/// <param name="headers">Заголовки, помещаемые в ответный поток для клиента.</param>
		/// <returns>
		///   <see cref="T:System.IO.Stream" />, в который необходимо сериализовать предоставленное ответное сообщение.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003890 RID: 14480
		Stream GetResponseStream(IServerResponseChannelSinkStack sinkStack, object state, IMessage msg, ITransportHeaders headers);

		/// <summary>Запрашивает обработку сообщения из текущего приемника.</summary>
		/// <param name="sinkStack">Стек приемников каналов, который вызывал текущий приемник.</param>
		/// <param name="requestMsg">Сообщение, которое содержит запрос.</param>
		/// <param name="requestHeaders">Заголовки, извлеченные из входящих сообщений от клиента.</param>
		/// <param name="requestStream">Поток, который необходимо обработать и передать приемнику десериализации.</param>
		/// <param name="responseMsg">При возвращении этого метода содержит <see cref="T:System.Runtime.Remoting.Messaging.IMessage" />, в котором содержится ответное сообщение. Этот параметр передается неинициализированным.</param>
		/// <param name="responseHeaders">Когда возвращается этот метод, он содержит <see cref="T:System.Runtime.Remoting.Channels.ITransportHeaders" />, который включает заголовки, добавляемые в возвращаемое сообщение, идущее к клиенту. Этот параметр передается неинициализированным.</param>
		/// <param name="responseStream">Когда возвращается этот метод, он содержит поток <see cref="T:System.IO.Stream" />, направляющийся обратно в транспортный приемник. Этот параметр передается неинициализированным.</param>
		/// <returns>Значение состояния <see cref="T:System.Runtime.Remoting.Channels.ServerProcessing" />, которое предоставляет сведения о том, как обрабатывалось сообщение.</returns>
		/// <exception cref="T:System.Security.SecurityException">У непосредственно вызывающего объекта отсутствует разрешение инфраструктуры.</exception>
		// Token: 0x06003891 RID: 14481
		ServerProcessing ProcessMessage(IServerChannelSinkStack sinkStack, IMessage requestMsg, ITransportHeaders requestHeaders, Stream requestStream, out IMessage responseMsg, out ITransportHeaders responseHeaders, out Stream responseStream);
	}
}
