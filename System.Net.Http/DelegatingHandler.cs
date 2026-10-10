using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Тип для обработчиков HTTP-данных, которые делегируют обработку ответных сообщений HTTP другому обработчику, который называется внутренним обработчиком.</summary>
	// Token: 0x02000014 RID: 20
	public abstract class DelegatingHandler : HttpMessageHandler
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.DelegatingHandler" />.</summary>
		// Token: 0x060000C6 RID: 198 RVA: 0x00003BC4 File Offset: 0x00001DC4
		protected DelegatingHandler()
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.DelegatingHandler" /> с указанным внутренним обработчиком.</summary>
		/// <param name="innerHandler">Внутренний обработчик, который отвечает за обработку сообщений ответов HTTP.</param>
		// Token: 0x060000C7 RID: 199 RVA: 0x00003BCC File Offset: 0x00001DCC
		protected DelegatingHandler(HttpMessageHandler innerHandler)
		{
			if (innerHandler == null)
			{
				throw new ArgumentNullException("innerHandler");
			}
			this.InnerHandler = innerHandler;
		}

		/// <summary>Возвращает или задает внутренний обработчик, который обрабатывает сообщения HTTP-ответа.</summary>
		/// <returns>Внутренний обработчик сообщений HTTP-ответа.</returns>
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00003BE9 File Offset: 0x00001DE9
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x00003BF1 File Offset: 0x00001DF1
		public HttpMessageHandler InnerHandler
		{
			get
			{
				return this.handler;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("InnerHandler");
				}
				this.handler = value;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.DelegatingHandler" />, и при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x060000CA RID: 202 RVA: 0x00003C08 File Offset: 0x00001E08
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.InnerHandler != null)
				{
					this.InnerHandler.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		/// <summary>Отправляет HTTP-запрос внутреннему обработчику для отправки на сервер в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки на сервер.</param>
		/// <param name="cancellationToken">Токен отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Запрос <paramref name="request" /> имел значение <see langword="null" />.</exception>
		// Token: 0x060000CB RID: 203 RVA: 0x00003C36 File Offset: 0x00001E36
		protected internal override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			if (this.InnerHandler == null)
			{
				throw new InvalidOperationException("The inner handler has not been assigned.");
			}
			return this.InnerHandler.SendAsync(request, cancellationToken);
		}

		// Token: 0x04000051 RID: 81
		private bool disposed;

		// Token: 0x04000052 RID: 82
		private HttpMessageHandler handler;
	}
}
