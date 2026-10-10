using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Базовый тип для обработчиков, которые выполняют определенную небольшую часть обработки запросов и ответных сообщений.</summary>
	// Token: 0x0200002C RID: 44
	public abstract class MessageProcessingHandler : DelegatingHandler
	{
		/// <summary>Создает экземпляр класса <see cref="T:System.Net.Http.MessageProcessingHandler" />.</summary>
		// Token: 0x06000172 RID: 370 RVA: 0x00005E9A File Offset: 0x0000409A
		protected MessageProcessingHandler()
		{
		}

		/// <summary>Создает экземпляр класса <see cref="T:System.Net.Http.MessageProcessingHandler" /> с указанным внутренним обработчиком.</summary>
		/// <param name="innerHandler">Внутренний обработчик, отвечающий за обработку сообщений откликов HTTP.</param>
		// Token: 0x06000173 RID: 371 RVA: 0x00005EA2 File Offset: 0x000040A2
		protected MessageProcessingHandler(HttpMessageHandler innerHandler) : base(innerHandler)
		{
		}

		/// <summary>Выполняет обработку для каждого запроса, отправленного серверу.</summary>
		/// <param name="request">Сообщение HTTP-запроса для обработки.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Обработанное сообщение HTTP-запроса.</returns>
		// Token: 0x06000174 RID: 372
		protected abstract HttpRequestMessage ProcessRequest(HttpRequestMessage request, CancellationToken cancellationToken);

		/// <summary>Выполнить обработку на каждом ответе сервера.</summary>
		/// <param name="response">Сообщение HTTP-отклика для обработки.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Обработанное сообщение HTTP-отклика.</returns>
		// Token: 0x06000175 RID: 373
		protected abstract HttpResponseMessage ProcessResponse(HttpResponseMessage response, CancellationToken cancellationToken);

		/// <summary>Отправляет HTTP-запрос внутреннему обработчику, отправляемый серверу в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщения HTTP-запроса, которые необходимо отправить на сервер.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="request" /> — <see langword="null" />.</exception>
		// Token: 0x06000176 RID: 374 RVA: 0x00005EAC File Offset: 0x000040AC
		protected internal sealed override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			MessageProcessingHandler.<SendAsync>d__4 <SendAsync>d__;
			<SendAsync>d__.<>4__this = this;
			<SendAsync>d__.request = request;
			<SendAsync>d__.cancellationToken = cancellationToken;
			<SendAsync>d__.<>t__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
			<SendAsync>d__.<>1__state = -1;
			<SendAsync>d__.<>t__builder.Start<MessageProcessingHandler.<SendAsync>d__4>(ref <SendAsync>d__);
			return <SendAsync>d__.<>t__builder.Task;
		}
	}
}
