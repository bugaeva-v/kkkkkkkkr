using System;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	/// <summary>Представляет ответное сообщение HTTP, включая код и данные о состоянии.</summary>
	// Token: 0x0200002B RID: 43
	public class HttpResponseMessage : IDisposable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpResponseMessage" />.</summary>
		// Token: 0x0600015F RID: 351 RVA: 0x00005C64 File Offset: 0x00003E64
		public HttpResponseMessage() : this(HttpStatusCode.OK)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpResponseMessage" /> с конкретным <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" />.</summary>
		/// <param name="statusCode">Код состояния HTTP-ответа.</param>
		// Token: 0x06000160 RID: 352 RVA: 0x00005C71 File Offset: 0x00003E71
		public HttpResponseMessage(HttpStatusCode statusCode)
		{
			this.StatusCode = statusCode;
		}

		/// <summary>Возвращает или задает содержимое ответного HTTP-сообщения.</summary>
		/// <returns>Содержимое ответного HTTP-сообщения.</returns>
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00005C80 File Offset: 0x00003E80
		// (set) Token: 0x06000162 RID: 354 RVA: 0x00005C88 File Offset: 0x00003E88
		public HttpContent Content { get; set; }

		/// <summary>Возвращает коллекцию заголовков HTTP-ответа.</summary>
		/// <returns>Коллекция заголовков HTTP-ответа.</returns>
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00005C94 File Offset: 0x00003E94
		public HttpResponseHeaders Headers
		{
			get
			{
				HttpResponseHeaders result;
				if ((result = this.headers) == null)
				{
					result = (this.headers = new HttpResponseHeaders());
				}
				return result;
			}
		}

		/// <summary>Возвращает значение, указывающее, завершился ли успешно HTTP-ответ.</summary>
		/// <returns>
		///   <see langword="true" /> Если <see cref="P:System.Net.Http.HttpResponseMessage.StatusCode" /> был в диапазоне от 200 до 299; в противном случае <see langword="false" />.</returns>
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005CB9 File Offset: 0x00003EB9
		public bool IsSuccessStatusCode
		{
			get
			{
				return this.statusCode >= HttpStatusCode.OK && this.statusCode < HttpStatusCode.MultipleChoices;
			}
		}

		/// <summary>Возвращает или задает фразу причины, которая обычно отправляется серверами вместе с кодом состояния.</summary>
		/// <returns>Фраза причины, отправленная сервером.</returns>
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005CD7 File Offset: 0x00003ED7
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00005CEE File Offset: 0x00003EEE
		public string ReasonPhrase
		{
			get
			{
				return this.reasonPhrase ?? HttpStatusDescription.Get(this.statusCode);
			}
			set
			{
				this.reasonPhrase = value;
			}
		}

		/// <summary>Возвращает или задает сообщение запроса, которое привело к получению этого ответного сообщения.</summary>
		/// <returns>Сообщение запроса, которое привело к получению этого ответного сообщения.</returns>
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00005CF7 File Offset: 0x00003EF7
		// (set) Token: 0x06000168 RID: 360 RVA: 0x00005CFF File Offset: 0x00003EFF
		public HttpRequestMessage RequestMessage { get; set; }

		/// <summary>Возвращает или задает код состояния HTTP-ответа.</summary>
		/// <returns>Код состояния HTTP-ответа.</returns>
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00005D08 File Offset: 0x00003F08
		// (set) Token: 0x0600016A RID: 362 RVA: 0x00005D10 File Offset: 0x00003F10
		public HttpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
			set
			{
				if (value < (HttpStatusCode)0)
				{
					throw new ArgumentOutOfRangeException();
				}
				this.statusCode = value;
			}
		}

		/// <summary>Возвращает или задает версию HTTP-сообщения.</summary>
		/// <returns>Версия HTTP-сообщения. Значение по умолчанию — 1.1.</returns>
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005D23 File Offset: 0x00003F23
		// (set) Token: 0x0600016C RID: 364 RVA: 0x00005D34 File Offset: 0x00003F34
		public Version Version
		{
			get
			{
				return this.version ?? HttpVersion.Version11;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("Version");
				}
				this.version = value;
			}
		}

		/// <summary>Освобождает неуправляемые ресурсы и удаляет неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpResponseMessage" />.</summary>
		// Token: 0x0600016D RID: 365 RVA: 0x00005D51 File Offset: 0x00003F51
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.HttpResponseMessage" />, и опционально удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x0600016E RID: 366 RVA: 0x00005D5A File Offset: 0x00003F5A
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && !this.disposed)
			{
				this.disposed = true;
				if (this.Content != null)
				{
					this.Content.Dispose();
				}
			}
		}

		/// <summary>Вызывает исключение, если свойство <see cref="P:System.Net.Http.HttpResponseMessage.IsSuccessStatusCode" /> для HTTP-ответа имеет значение <see langword="false" />.</summary>
		/// <returns>Сообщение HTTP-ответа, если вызов был успешным.</returns>
		/// <exception cref="T:System.Net.Http.HttpRequestException">HTTP-ответ завершился неудачей.</exception>
		// Token: 0x0600016F RID: 367 RVA: 0x00005D81 File Offset: 0x00003F81
		public HttpResponseMessage EnsureSuccessStatusCode()
		{
			if (this.IsSuccessStatusCode)
			{
				return this;
			}
			throw new HttpRequestException(string.Format("{0} ({1})", (int)this.statusCode, this.ReasonPhrase));
		}

		/// <summary>Возвращает строку, представляющую текущий объект.</summary>
		/// <returns>Строковое представление текущего объекта.</returns>
		// Token: 0x06000170 RID: 368 RVA: 0x00005DB0 File Offset: 0x00003FB0
		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StatusCode: ").Append((int)this.StatusCode);
			stringBuilder.Append(", ReasonPhrase: '").Append(this.ReasonPhrase ?? "<null>");
			stringBuilder.Append("', Version: ").Append(this.Version);
			stringBuilder.Append(", Content: ").Append((this.Content != null) ? this.Content.ToString() : "<null>");
			stringBuilder.Append(", Headers:\r\n{\r\n").Append(this.Headers);
			if (this.Content != null)
			{
				stringBuilder.Append(this.Content.Headers);
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00005E7F File Offset: 0x0000407F
		public HttpResponseHeaders TrailingHeaders
		{
			get
			{
				if (this.trailingHeaders == null)
				{
					this.trailingHeaders = new HttpResponseHeaders();
				}
				return this.trailingHeaders;
			}
		}

		// Token: 0x040000BB RID: 187
		private HttpResponseHeaders headers;

		// Token: 0x040000BC RID: 188
		private HttpResponseHeaders trailingHeaders;

		// Token: 0x040000BD RID: 189
		private string reasonPhrase;

		// Token: 0x040000BE RID: 190
		private HttpStatusCode statusCode;

		// Token: 0x040000BF RID: 191
		private Version version;

		// Token: 0x040000C0 RID: 192
		private bool disposed;
	}
}
