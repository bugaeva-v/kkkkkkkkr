using System;
using System.IO;
using Unity;

namespace System.Net
{
	/// <summary>Инкапсулирует ответ FTP-сервера на запрос.</summary>
	// Token: 0x02000593 RID: 1427
	public class FtpWebResponse : WebResponse, IDisposable
	{
		// Token: 0x06002E5C RID: 11868 RVA: 0x000A0924 File Offset: 0x0009EB24
		internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, contentLength, statusLine);
			}
			this._responseStream = responseStream;
			if (responseStream == null && contentLength < 0L)
			{
				contentLength = 0L;
			}
			this._contentLength = contentLength;
			this._responseUri = responseUri;
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._lastModified = lastModified;
			this._bannerMessage = bannerMessage;
			this._welcomeMessage = welcomeMessage;
			this._exitMessage = exitMessage;
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x000A099D File Offset: 0x0009EB9D
		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
			this._statusCode = statusCode;
			this._statusLine = statusLine;
			this._exitMessage = exitMessage;
		}

		/// <summary>Получает поток, содержащий данные ответа, отправленного с FTP-сервера.</summary>
		/// <returns>Доступный для чтения экземпляр <see cref="T:System.IO.Stream" />, в котором содержатся данные, возвращенные с ответом; в противном случае — значение <see cref="F:System.IO.Stream.Null" />, если сервер не возвратил данные ответа.</returns>
		/// <exception cref="T:System.InvalidOperationException">В возвращенном ответе не содержался поток данных.</exception>
		// Token: 0x06002E5E RID: 11870 RVA: 0x000A09B4 File Offset: 0x0009EBB4
		public override Stream GetResponseStream()
		{
			Stream result;
			if (this._responseStream != null)
			{
				result = this._responseStream;
			}
			else
			{
				result = (this._responseStream = new FtpWebResponse.EmptyStream());
			}
			return result;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x000A09E4 File Offset: 0x0009EBE4
		internal void SetResponseStream(Stream stream)
		{
			if (stream == null || stream == Stream.Null || stream is FtpWebResponse.EmptyStream)
			{
				return;
			}
			this._responseStream = stream;
		}

		/// <summary>Освобождает ресурсы, удерживаемые этим ответом.</summary>
		// Token: 0x06002E60 RID: 11872 RVA: 0x000A0A01 File Offset: 0x0009EC01
		public override void Close()
		{
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Enter(this, null, "Close");
			}
			Stream responseStream = this._responseStream;
			if (responseStream != null)
			{
				responseStream.Close();
			}
			if (NetEventSource.IsEnabled)
			{
				NetEventSource.Exit(this, null, "Close");
			}
		}

		/// <summary>Возвращает длину данных, полученных с FTP-сервера.</summary>
		/// <returns>Значение <see cref="T:System.Int64" />, которое содержит количество байтов данных, полученных с FTP-сервера.</returns>
		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x000A0A3A File Offset: 0x0009EC3A
		public override long ContentLength
		{
			get
			{
				return this._contentLength;
			}
		}

		/// <summary>Возвращает пустой объект <see cref="T:System.Net.WebHeaderCollection" />.</summary>
		/// <returns>Пустой объект <see cref="T:System.Net.WebHeaderCollection" /></returns>
		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x000A0A44 File Offset: 0x0009EC44
		public override WebHeaderCollection Headers
		{
			get
			{
				if (this._ftpRequestHeaders == null)
				{
					lock (this)
					{
						if (this._ftpRequestHeaders == null)
						{
							this._ftpRequestHeaders = new WebHeaderCollection();
						}
					}
				}
				return this._ftpRequestHeaders;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживается ли свойство <see cref="P:System.Net.FtpWebResponse.Headers" /> экземпляром <see cref="T:System.Net.FtpWebResponse" />.</summary>
		/// <returns>Возвращает <see cref="T:System.Boolean" />.  
		///  Значение <see langword="true" />, если свойство <see cref="P:System.Net.FtpWebResponse.Headers" /> поддерживается экземпляром <see cref="T:System.Net.FtpWebResponse" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool SupportsHeaders
		{
			get
			{
				return true;
			}
		}

		/// <summary>Получает универсальный код ресурса (URI), с которого был отправлен ответ на запрос.</summary>
		/// <returns>Экземпляр <see cref="T:System.Uri" />, идентифицирующий ресурс, связанный с этим ответом.</returns>
		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x000A0A9C File Offset: 0x0009EC9C
		public override Uri ResponseUri
		{
			get
			{
				return this._responseUri;
			}
		}

		/// <summary>Получает самый последний код состояния, отправленный с FTP-сервера.</summary>
		/// <returns>Значение <see cref="T:System.Net.FtpStatusCode" />, указывающее самый последний код состояния, возвращенный этим запросом.</returns>
		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000A0AA4 File Offset: 0x0009ECA4
		public FtpStatusCode StatusCode
		{
			get
			{
				return this._statusCode;
			}
		}

		/// <summary>Получает текст, описывающий код состояния, отправленный с FTP-сервера.</summary>
		/// <returns>Экземпляр <see cref="T:System.String" />, содержащий код состояния и сообщение, возвращенное вместе с этим ответом.</returns>
		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x000A0AAC File Offset: 0x0009ECAC
		public string StatusDescription
		{
			get
			{
				return this._statusLine;
			}
		}

		/// <summary>Возвращает значения даты и времени последнего изменения файла на FTP-сервере.</summary>
		/// <returns>Объект <see cref="T:System.DateTime" />, который содержит дату и время последнего изменения файла.</returns>
		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000A0AB4 File Offset: 0x0009ECB4
		public DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
		}

		/// <summary>Получает сообщение, отправленное FTP-сервером при установке подключения до входа пользователя.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий текст заголовка, отправленного сервером; в противном случае — значение <see cref="F:System.String.Empty" />, если сообщение отправлено не было.</returns>
		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x06002E68 RID: 11880 RVA: 0x000A0ABC File Offset: 0x0009ECBC
		public string BannerMessage
		{
			get
			{
				return this._bannerMessage;
			}
		}

		/// <summary>Получает сообщение, отправленное FTP-сервером по завершении проверки подлинности.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий сообщение входа, отправленное сервером; в противном случае — значение <see cref="F:System.String.Empty" />, если сообщение отправлено не было.</returns>
		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000A0AC4 File Offset: 0x0009ECC4
		public string WelcomeMessage
		{
			get
			{
				return this._welcomeMessage;
			}
		}

		/// <summary>Получает сообщение, отправленное сервером при завершении FTP-сеанса.</summary>
		/// <returns>Объект <see cref="T:System.String" />, содержащий сообщение выхода, отправленное сервером; в противном случае — значение <see cref="F:System.String.Empty" />, если сообщение отправлено не было.</returns>
		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x06002E6A RID: 11882 RVA: 0x000A0ACC File Offset: 0x0009ECCC
		public string ExitMessage
		{
			get
			{
				return this._exitMessage;
			}
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00013BCA File Offset: 0x00011DCA
		internal FtpWebResponse()
		{
			ThrowStub.ThrowNotSupportedException();
		}

		// Token: 0x0400199A RID: 6554
		internal Stream _responseStream;

		// Token: 0x0400199B RID: 6555
		private long _contentLength;

		// Token: 0x0400199C RID: 6556
		private Uri _responseUri;

		// Token: 0x0400199D RID: 6557
		private FtpStatusCode _statusCode;

		// Token: 0x0400199E RID: 6558
		private string _statusLine;

		// Token: 0x0400199F RID: 6559
		private WebHeaderCollection _ftpRequestHeaders;

		// Token: 0x040019A0 RID: 6560
		private DateTime _lastModified;

		// Token: 0x040019A1 RID: 6561
		private string _bannerMessage;

		// Token: 0x040019A2 RID: 6562
		private string _welcomeMessage;

		// Token: 0x040019A3 RID: 6563
		private string _exitMessage;

		// Token: 0x02000594 RID: 1428
		internal sealed class EmptyStream : MemoryStream
		{
			// Token: 0x06002E6C RID: 11884 RVA: 0x000A0AD4 File Offset: 0x0009ECD4
			internal EmptyStream() : base(Array.Empty<byte>(), false)
			{
			}
		}
	}
}
