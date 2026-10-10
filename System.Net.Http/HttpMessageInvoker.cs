using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Специальный класс, который позволяет приложениям вызывать метод <see cref="M:System.Net.Http.HttpMessageInvoker.SendAsync(System.Net.Http.HttpRequestMessage,System.Threading.CancellationToken)" /> в цепочке обработчика HTTP.</summary>
	// Token: 0x02000027 RID: 39
	public class HttpMessageInvoker : IDisposable
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Net.Http.HttpMessageInvoker" /> с конкретным <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">Компонент <see cref="T:System.Net.Http.HttpMessageHandler" />, отвечающий за обработку сообщений ответов HTTP.</param>
		// Token: 0x06000134 RID: 308 RVA: 0x000057F1 File Offset: 0x000039F1
		public HttpMessageInvoker(HttpMessageHandler handler) : this(handler, true)
		{
		}

		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Net.Http.HttpMessageInvoker" /> с конкретным <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		/// <param name="handler">Компонент <see cref="T:System.Net.Http.HttpMessageHandler" />, отвечающий за обработку сообщений ответов HTTP.</param>
		/// <param name="disposeHandler">Значение <see langword="true" />, если внутренний обработчик должен быть удален с помощью Dispose(). Значение <see langword="false" />, если планируется повторно использовать внутренний обработчик.</param>
		// Token: 0x06000135 RID: 309 RVA: 0x000057FB File Offset: 0x000039FB
		public HttpMessageInvoker(HttpMessageHandler handler, bool disposeHandler)
		{
			if (handler == null)
			{
				throw new ArgumentNullException("handler");
			}
			this.handler = handler;
			this.disposeHandler = disposeHandler;
		}

		/// <summary>Освобождает неуправляемые ресурсы и удаляет управляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpMessageInvoker" />.</summary>
		// Token: 0x06000136 RID: 310 RVA: 0x0000581F File Offset: 0x00003A1F
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpMessageInvoker" />, и опционально удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06000137 RID: 311 RVA: 0x00005828 File Offset: 0x00003A28
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this.disposeHandler && this.handler != null)
			{
				this.handler.Dispose();
				this.handler = null;
			}
		}

		/// <summary>Отправка HTTP-запроса в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <param name="cancellationToken">Токен отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="request" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06000138 RID: 312 RVA: 0x0000584F File Offset: 0x00003A4F
		public virtual Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return this.handler.SendAsync(request, cancellationToken);
		}

		// Token: 0x040000A9 RID: 169
		private protected HttpMessageHandler handler;

		// Token: 0x040000AA RID: 170
		private readonly bool disposeHandler;
	}
}
