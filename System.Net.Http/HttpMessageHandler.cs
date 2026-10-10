using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Базовый тип для обработчиков сообщений HTTP.</summary>
	// Token: 0x02000026 RID: 38
	public abstract class HttpMessageHandler : IDisposable
	{
		/// <summary>Освобождает неуправляемые ресурсы и удаляет управляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
		// Token: 0x06000130 RID: 304 RVA: 0x000057E6 File Offset: 0x000039E6
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpMessageHandler" />, и опционально удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06000131 RID: 305 RVA: 0x000057EF File Offset: 0x000039EF
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Отправка HTTP-запроса в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <param name="cancellationToken">Токен отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="request" /> имел значение <see langword="null" />.</exception>
		// Token: 0x06000132 RID: 306
		protected internal abstract Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
	}
}
