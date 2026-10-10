using System;
using System.IO;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Предоставляет базовый класс для отправки HTTP-запросов и получения HTTP-ответов от ресурса с заданным URI.</summary>
	// Token: 0x02000016 RID: 22
	public class HttpClient : HttpMessageInvoker
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpClient" />.</summary>
		// Token: 0x060000CF RID: 207 RVA: 0x00003D49 File Offset: 0x00001F49
		public HttpClient() : this(new HttpClientHandler(), true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpClient" /> с указанным обработчиком.</summary>
		/// <param name="handler">Стек обработчика HTTP-данных, используемый для отправки запросов.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000D0 RID: 208 RVA: 0x00003D57 File Offset: 0x00001F57
		public HttpClient(HttpMessageHandler handler) : this(handler, true)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpClient" /> с указанным обработчиком.</summary>
		/// <param name="handler">
		///   <see cref="T:System.Net.Http.HttpMessageHandler" />,  отвечающий за обработку сообщений откликов HTTP.</param>
		/// <param name="disposeHandler">Значение <see langword="true" />, если внутренний обработчик должен быть удален с помощью HttpClient.Dispose. Значение <see langword="false" />, если планируется повторно использовать внутренний обработчик.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="handler" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000D1 RID: 209 RVA: 0x00003D61 File Offset: 0x00001F61
		public HttpClient(HttpMessageHandler handler, bool disposeHandler) : base(handler, disposeHandler)
		{
			this.buffer_size = 2147483647L;
			this.timeout = HttpClient.TimeoutDefault;
			this.cts = new CancellationTokenSource();
		}

		/// <summary>Получает или задает базовый адрес универсального кода ресурса (URI) интернет-ресурса, используемого при отправке запросов.</summary>
		/// <returns>Базовый адрес универсального кода ресурса (URI) интернет-ресурса, используемого при отправке запросов.</returns>
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x00003D8D File Offset: 0x00001F8D
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x00003D95 File Offset: 0x00001F95
		public Uri BaseAddress
		{
			get
			{
				return this.base_address;
			}
			set
			{
				this.base_address = value;
			}
		}

		/// <summary>Получает заголовки, которые должны отправляться с каждым запросом.</summary>
		/// <returns>Заголовки, которые должны отправляться с каждым запросом.</returns>
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x00003DA0 File Offset: 0x00001FA0
		public HttpRequestHeaders DefaultRequestHeaders
		{
			get
			{
				HttpRequestHeaders result;
				if ((result = this.headers) == null)
				{
					result = (this.headers = new HttpRequestHeaders());
				}
				return result;
			}
		}

		/// <summary>Получает или задает максимальное число байтов в буфере при чтении содержимого отклика.</summary>
		/// <returns>Максимальное число байтов в буфере при чтении содержимого отклика. Значением по умолчанию для этого свойства является 2 гигабайта.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанный размер меньше или равен нулю.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция для текущего экземпляра уже запущена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр был удален.</exception>
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003DC5 File Offset: 0x00001FC5
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00003DCD File Offset: 0x00001FCD
		public long MaxResponseContentBufferSize
		{
			get
			{
				return this.buffer_size;
			}
			set
			{
				if (value <= 0L)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.buffer_size = value;
			}
		}

		/// <summary>Возвращает или задает время ожидания для выполнения запроса.</summary>
		/// <returns>Время ожидания для выполнения запроса.</returns>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Указанное время ожидания меньше или равно нулю и не является <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Операция для текущего экземпляра уже запущена.</exception>
		/// <exception cref="T:System.ObjectDisposedException">Текущий экземпляр удален.</exception>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00003DE1 File Offset: 0x00001FE1
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00003DE9 File Offset: 0x00001FE9
		public TimeSpan Timeout
		{
			get
			{
				return this.timeout;
			}
			set
			{
				if (value != System.Threading.Timeout.InfiniteTimeSpan && (value <= TimeSpan.Zero || value.TotalMilliseconds > 2147483647.0))
				{
					throw new ArgumentOutOfRangeException();
				}
				this.timeout = value;
			}
		}

		/// <summary>Отменить все ожидающие запросы на этом экземпляре.</summary>
		// Token: 0x060000D9 RID: 217 RVA: 0x00003E24 File Offset: 0x00002024
		public void CancelPendingRequests()
		{
			using (CancellationTokenSource cancellationTokenSource = Interlocked.Exchange<CancellationTokenSource>(ref this.cts, new CancellationTokenSource()))
			{
				cancellationTokenSource.Cancel();
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpClient" />, и при необходимости удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x060000DA RID: 218 RVA: 0x00003E64 File Offset: 0x00002064
		protected override void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				this.cts.Cancel();
				this.cts.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>Отправляет запрос DELETE согласно указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000DB RID: 219 RVA: 0x00003E95 File Offset: 0x00002095
		public Task<HttpResponseMessage> DeleteAsync(string requestUri)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri));
		}

		/// <summary>Отправить запрос DELETE к указанному URI с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000DC RID: 220 RVA: 0x00003EA8 File Offset: 0x000020A8
		public Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri), cancellationToken);
		}

		/// <summary>Отправляет запрос DELETE согласно указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000DD RID: 221 RVA: 0x00003EBC File Offset: 0x000020BC
		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri));
		}

		/// <summary>Отправить запрос DELETE к указанному URI с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000DE RID: 222 RVA: 0x00003ECF File Offset: 0x000020CF
		public Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Delete, requestUri), cancellationToken);
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000DF RID: 223 RVA: 0x00003EE3 File Offset: 0x000020E3
		public Task<HttpResponseMessage> GetAsync(string requestUri)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri));
		}

		/// <summary>Отправить запрос DELETE указанному универсальному коду ресурса (URI) с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E0 RID: 224 RVA: 0x00003EF6 File Offset: 0x000020F6
		public Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), cancellationToken);
		}

		/// <summary>Отправить запрос GET указанному универсальному коду ресурса (URI) с параметром "выполнение HTTP" в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="completionOption">Значение параметра завершения операции HTTP, указывающее, когда следует считать операцию завершенной.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E1 RID: 225 RVA: 0x00003F0A File Offset: 0x0000210A
		public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), completionOption);
		}

		/// <summary>Отправить запрос GET к указанному универсальному коду ресурса (URI) с параметром "выполнение HTTP" и токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="completionOption">Значение параметра завершения операции HTTP, указывающее, когда следует считать операцию завершенной.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E2 RID: 226 RVA: 0x00003F1E File Offset: 0x0000211E
		public Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), completionOption, cancellationToken);
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E3 RID: 227 RVA: 0x00003F33 File Offset: 0x00002133
		public Task<HttpResponseMessage> GetAsync(Uri requestUri)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri));
		}

		/// <summary>Отправить запрос DELETE указанному универсальному коду ресурса (URI) с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E4 RID: 228 RVA: 0x00003F46 File Offset: 0x00002146
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), cancellationToken);
		}

		/// <summary>Отправить запрос GET указанному универсальному коду ресурса (URI) с параметром "выполнение HTTP" в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="completionOption">Значение параметра завершения операции HTTP, указывающее, когда следует считать операцию завершенной.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E5 RID: 229 RVA: 0x00003F5A File Offset: 0x0000215A
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), completionOption);
		}

		/// <summary>Отправить запрос GET к указанному универсальному коду ресурса (URI) с параметром "выполнение HTTP" и токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="completionOption">Значение параметра завершения операции HTTP, указывающее, когда следует считать операцию завершенной.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E6 RID: 230 RVA: 0x00003F6E File Offset: 0x0000216E
		public Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Get, requestUri), completionOption, cancellationToken);
		}

		/// <summary>Отправка запроса POST по указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E7 RID: 231 RVA: 0x00003F83 File Offset: 0x00002183
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
			{
				Content = content
			});
		}

		/// <summary>Отправить запрос POST с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E8 RID: 232 RVA: 0x00003F9D File Offset: 0x0000219D
		public Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		/// <summary>Отправка запроса POST по указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000E9 RID: 233 RVA: 0x00003FB8 File Offset: 0x000021B8
		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
			{
				Content = content
			});
		}

		/// <summary>Отправить запрос POST с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000EA RID: 234 RVA: 0x00003FD2 File Offset: 0x000021D2
		public Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Post, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		/// <summary>Отправка запроса PUT по указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000EB RID: 235 RVA: 0x00003FED File Offset: 0x000021ED
		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Put, requestUri)
			{
				Content = content
			});
		}

		/// <summary>Отправить запрос PUT с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000EC RID: 236 RVA: 0x00004007 File Offset: 0x00002207
		public Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Put, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		/// <summary>Отправка запроса PUT по указанному универсальному коду ресурса (URI) в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000ED RID: 237 RVA: 0x00004022 File Offset: 0x00002222
		public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Put, requestUri)
			{
				Content = content
			});
		}

		/// <summary>Отправить запрос PUT с токеном отмены в качестве асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <param name="content">Содержимое HTTP-запроса, отправляемое на сервер.</param>
		/// <param name="cancellationToken">Токен отмены, который может использоваться другими объектами или потоками для получения уведомления об отмене.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000EE RID: 238 RVA: 0x0000403C File Offset: 0x0000223C
		public Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			return this.SendAsync(new HttpRequestMessage(HttpMethod.Put, requestUri)
			{
				Content = content
			}, cancellationToken);
		}

		/// <summary>Отправляет HTTP-запрос в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="request" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000EF RID: 239 RVA: 0x00004057 File Offset: 0x00002257
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
		{
			return this.SendAsync(request, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
		}

		/// <summary>Отправляет HTTP-запрос в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <param name="completionOption">Когда должна завершиться операция (как только будет доступен отклик или после считывания всего содержимого отклика).</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="request" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F0 RID: 240 RVA: 0x00004066 File Offset: 0x00002266
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
		{
			return this.SendAsync(request, completionOption, CancellationToken.None);
		}

		/// <summary>Отправляет HTTP-запрос в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <param name="cancellationToken">Токен отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="request" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F1 RID: 241 RVA: 0x00004075 File Offset: 0x00002275
		public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			return this.SendAsync(request, HttpCompletionOption.ResponseContentRead, cancellationToken);
		}

		/// <summary>Отправляет HTTP-запрос в качестве асинхронной операции.</summary>
		/// <param name="request">Сообщение HTTP-запроса для отправки.</param>
		/// <param name="completionOption">Когда должна завершиться операция (как только будет доступен отклик или после считывания всего содержимого отклика).</param>
		/// <param name="cancellationToken">Токен отмены для отмены операции.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="request" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">Сообщение запроса уже было отправлено экземпляром <see cref="T:System.Net.Http.HttpClient" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F2 RID: 242 RVA: 0x00004080 File Offset: 0x00002280
		public Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			if (request == null)
			{
				throw new ArgumentNullException("request");
			}
			if (request.SetIsUsed())
			{
				throw new InvalidOperationException("Cannot send the same request message multiple times");
			}
			Uri requestUri = request.RequestUri;
			if (requestUri == null)
			{
				if (this.base_address == null)
				{
					throw new InvalidOperationException("The request URI must either be an absolute URI or BaseAddress must be set");
				}
				request.RequestUri = this.base_address;
			}
			else if (!requestUri.IsAbsoluteUri || (requestUri.Scheme == Uri.UriSchemeFile && requestUri.OriginalString.StartsWith("/", StringComparison.Ordinal)))
			{
				if (this.base_address == null)
				{
					throw new InvalidOperationException("The request URI must either be an absolute URI or BaseAddress must be set");
				}
				request.RequestUri = new Uri(this.base_address, requestUri);
			}
			if (this.headers != null)
			{
				request.Headers.AddHeaders(this.headers);
			}
			return this.SendAsyncWorker(request, completionOption, cancellationToken);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00004160 File Offset: 0x00002360
		private Task<HttpResponseMessage> SendAsyncWorker(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
		{
			HttpClient.<SendAsyncWorker>d__47 <SendAsyncWorker>d__;
			<SendAsyncWorker>d__.<>4__this = this;
			<SendAsyncWorker>d__.request = request;
			<SendAsyncWorker>d__.completionOption = completionOption;
			<SendAsyncWorker>d__.cancellationToken = cancellationToken;
			<SendAsyncWorker>d__.<>t__builder = AsyncTaskMethodBuilder<HttpResponseMessage>.Create();
			<SendAsyncWorker>d__.<>1__state = -1;
			<SendAsyncWorker>d__.<>t__builder.Start<HttpClient.<SendAsyncWorker>d__47>(ref <SendAsyncWorker>d__);
			return <SendAsyncWorker>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает текст ответа в виде массива байтов в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F4 RID: 244 RVA: 0x000041BC File Offset: 0x000023BC
		public Task<byte[]> GetByteArrayAsync(string requestUri)
		{
			HttpClient.<GetByteArrayAsync>d__48 <GetByteArrayAsync>d__;
			<GetByteArrayAsync>d__.<>4__this = this;
			<GetByteArrayAsync>d__.requestUri = requestUri;
			<GetByteArrayAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetByteArrayAsync>d__.<>1__state = -1;
			<GetByteArrayAsync>d__.<>t__builder.Start<HttpClient.<GetByteArrayAsync>d__48>(ref <GetByteArrayAsync>d__);
			return <GetByteArrayAsync>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает тело отклика в виде массива байтов в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F5 RID: 245 RVA: 0x00004208 File Offset: 0x00002408
		public Task<byte[]> GetByteArrayAsync(Uri requestUri)
		{
			HttpClient.<GetByteArrayAsync>d__49 <GetByteArrayAsync>d__;
			<GetByteArrayAsync>d__.<>4__this = this;
			<GetByteArrayAsync>d__.requestUri = requestUri;
			<GetByteArrayAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
			<GetByteArrayAsync>d__.<>1__state = -1;
			<GetByteArrayAsync>d__.<>t__builder.Start<HttpClient.<GetByteArrayAsync>d__49>(ref <GetByteArrayAsync>d__);
			return <GetByteArrayAsync>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает тело отклика в виде потока в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F6 RID: 246 RVA: 0x00004254 File Offset: 0x00002454
		public Task<Stream> GetStreamAsync(string requestUri)
		{
			HttpClient.<GetStreamAsync>d__50 <GetStreamAsync>d__;
			<GetStreamAsync>d__.<>4__this = this;
			<GetStreamAsync>d__.requestUri = requestUri;
			<GetStreamAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Stream>.Create();
			<GetStreamAsync>d__.<>1__state = -1;
			<GetStreamAsync>d__.<>t__builder.Start<HttpClient.<GetStreamAsync>d__50>(ref <GetStreamAsync>d__);
			return <GetStreamAsync>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает тело отклика в виде потока в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F7 RID: 247 RVA: 0x000042A0 File Offset: 0x000024A0
		public Task<Stream> GetStreamAsync(Uri requestUri)
		{
			HttpClient.<GetStreamAsync>d__51 <GetStreamAsync>d__;
			<GetStreamAsync>d__.<>4__this = this;
			<GetStreamAsync>d__.requestUri = requestUri;
			<GetStreamAsync>d__.<>t__builder = AsyncTaskMethodBuilder<Stream>.Create();
			<GetStreamAsync>d__.<>1__state = -1;
			<GetStreamAsync>d__.<>t__builder.Start<HttpClient.<GetStreamAsync>d__51>(ref <GetStreamAsync>d__);
			return <GetStreamAsync>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает тело отклика в виде строки в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F8 RID: 248 RVA: 0x000042EC File Offset: 0x000024EC
		public Task<string> GetStringAsync(string requestUri)
		{
			HttpClient.<GetStringAsync>d__52 <GetStringAsync>d__;
			<GetStringAsync>d__.<>4__this = this;
			<GetStringAsync>d__.requestUri = requestUri;
			<GetStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetStringAsync>d__.<>1__state = -1;
			<GetStringAsync>d__.<>t__builder.Start<HttpClient.<GetStringAsync>d__52>(ref <GetStringAsync>d__);
			return <GetStringAsync>d__.<>t__builder.Task;
		}

		/// <summary>Отправляет запрос GET согласно указанному универсальному коду ресурса (URI) и возвращает тело отклика в виде строки в асинхронной операции.</summary>
		/// <param name="requestUri">Универсальный код ресурса (URI), по которому отправляется запрос.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="requestUri" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Net.Http.HttpRequestException">Не удалось выполнить запрос из-за ключевой проблемы, например подключения к сети, ошибки DNS, проверки сертификата сервера или времени ожидания.</exception>
		// Token: 0x060000F9 RID: 249 RVA: 0x00004338 File Offset: 0x00002538
		public Task<string> GetStringAsync(Uri requestUri)
		{
			HttpClient.<GetStringAsync>d__53 <GetStringAsync>d__;
			<GetStringAsync>d__.<>4__this = this;
			<GetStringAsync>d__.requestUri = requestUri;
			<GetStringAsync>d__.<>t__builder = AsyncTaskMethodBuilder<string>.Create();
			<GetStringAsync>d__.<>1__state = -1;
			<GetStringAsync>d__.<>t__builder.Start<HttpClient.<GetStringAsync>d__53>(ref <GetStringAsync>d__);
			return <GetStringAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002874 File Offset: 0x00000A74
		public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002874 File Offset: 0x00000A74
		public Task<HttpResponseMessage> PatchAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002874 File Offset: 0x00000A74
		public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002874 File Offset: 0x00000A74
		public Task<HttpResponseMessage> PatchAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
		{
			throw new PlatformNotSupportedException();
		}

		// Token: 0x04000053 RID: 83
		private static readonly TimeSpan TimeoutDefault = TimeSpan.FromSeconds(100.0);

		// Token: 0x04000054 RID: 84
		private Uri base_address;

		// Token: 0x04000055 RID: 85
		private CancellationTokenSource cts;

		// Token: 0x04000056 RID: 86
		private bool disposed;

		// Token: 0x04000057 RID: 87
		private HttpRequestHeaders headers;

		// Token: 0x04000058 RID: 88
		private long buffer_size;

		// Token: 0x04000059 RID: 89
		private TimeSpan timeout;
	}
}
