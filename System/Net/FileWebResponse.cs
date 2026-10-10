using System;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Предоставляет реализацию файловой системы класса <see cref="T:System.Net.WebResponse" />.</summary>
	// Token: 0x0200065A RID: 1626
	[Serializable]
	public class FileWebResponse : WebResponse, ISerializable, ICloseEx
	{
		// Token: 0x06003350 RID: 13136 RVA: 0x000B30AC File Offset: 0x000B12AC
		internal FileWebResponse(FileWebRequest request, Uri uri, FileAccess access, bool asyncHint)
		{
			try
			{
				this.m_fileAccess = access;
				if (access == FileAccess.Write)
				{
					this.m_stream = Stream.Null;
				}
				else
				{
					this.m_stream = new FileWebStream(request, uri.LocalPath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192, asyncHint);
					this.m_contentLength = this.m_stream.Length;
				}
				this.m_headers = new WebHeaderCollection(WebHeaderCollectionType.FileWebResponse);
				this.m_headers.AddInternal("Content-Length", this.m_contentLength.ToString(NumberFormatInfo.InvariantInfo));
				this.m_headers.AddInternal("Content-Type", "application/octet-stream");
				this.m_uri = uri;
			}
			catch (Exception ex)
			{
				throw new WebException(ex.Message, ex, WebExceptionStatus.ConnectFailure, null);
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.FileWebResponse" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации нового экземпляра класса <see cref="T:System.Net.FileWebResponse" />.</param>
		/// <param name="streamingContext">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Net.FileWebResponse" />.</param>
		// Token: 0x06003351 RID: 13137 RVA: 0x000B3170 File Offset: 0x000B1370
		[Obsolete("Serialization is obsoleted for this type. http://go.microsoft.com/fwlink/?linkid=14202")]
		protected FileWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			this.m_headers = (WebHeaderCollection)serializationInfo.GetValue("headers", typeof(WebHeaderCollection));
			this.m_uri = (Uri)serializationInfo.GetValue("uri", typeof(Uri));
			this.m_contentLength = serializationInfo.GetInt64("contentLength");
			this.m_fileAccess = (FileAccess)serializationInfo.GetInt32("fileAccess");
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.FileWebResponse" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который будет содержать сериализованные данные для <see cref="T:System.Net.FileWebResponse" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий целевой объект для сериализованного потока, связанного с новым <see cref="T:System.Net.FileWebResponse" />.</param>
		// Token: 0x06003352 RID: 13138 RVA: 0x000ABB1C File Offset: 0x000A9D1C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации целевого объекта.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x06003353 RID: 13139 RVA: 0x000B31E8 File Offset: 0x000B13E8
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			serializationInfo.AddValue("headers", this.m_headers, typeof(WebHeaderCollection));
			serializationInfo.AddValue("uri", this.m_uri, typeof(Uri));
			serializationInfo.AddValue("contentLength", this.m_contentLength);
			serializationInfo.AddValue("fileAccess", this.m_fileAccess);
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Возвращает длину содержимого ресурса файловой системы.</summary>
		/// <returns>Количество байтов, возвращаемых из ресурса файловой системы.</returns>
		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003354 RID: 13140 RVA: 0x000B325A File Offset: 0x000B145A
		public override long ContentLength
		{
			get
			{
				this.CheckDisposed();
				return this.m_contentLength;
			}
		}

		/// <summary>Возвращает тип содержимого ресурса файловой системы.</summary>
		/// <returns>Значение — "binary/octet-stream".</returns>
		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003355 RID: 13141 RVA: 0x000B3268 File Offset: 0x000B1468
		public override string ContentType
		{
			get
			{
				this.CheckDisposed();
				return "application/octet-stream";
			}
		}

		/// <summary>Возвращает коллекцию пар "имя-значение" заголовков, связанных с запросом.</summary>
		/// <returns>Класс <see cref="T:System.Net.WebHeaderCollection" />, содержащий пары "имя-значение" заголовка, связанные с данным запросом.</returns>
		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003356 RID: 13142 RVA: 0x000B3275 File Offset: 0x000B1475
		public override WebHeaderCollection Headers
		{
			get
			{
				this.CheckDisposed();
				return this.m_headers;
			}
		}

		/// <summary>Возвращает значение, указывающее, поддерживается ли свойство <see cref="P:System.Net.FileWebResponse.Headers" /> экземпляром <see cref="T:System.Net.FileWebResponse" />.</summary>
		/// <returns>Значение <see langword="true" />, если свойство <see cref="P:System.Net.FileWebResponse.Headers" /> поддерживается экземпляром <see cref="T:System.Net.FileWebResponse" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003357 RID: 13143 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool SupportsHeaders
		{
			get
			{
				return true;
			}
		}

		/// <summary>Возвращает URI ресурса файловой системы, предоставившего ответ.</summary>
		/// <returns>Экземпляр класса <see cref="T:System.Uri" />, содержащий URI ресурса файловой системы, предоставившего ответ.</returns>
		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003358 RID: 13144 RVA: 0x000B3283 File Offset: 0x000B1483
		public override Uri ResponseUri
		{
			get
			{
				this.CheckDisposed();
				return this.m_uri;
			}
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x000B3291 File Offset: 0x000B1491
		private void CheckDisposed()
		{
			if (this.m_closed)
			{
				throw new ObjectDisposedException(base.GetType().FullName);
			}
		}

		/// <summary>Закрывает поток ответа.</summary>
		// Token: 0x0600335A RID: 13146 RVA: 0x000B32AC File Offset: 0x000B14AC
		public override void Close()
		{
			((ICloseEx)this).CloseEx(CloseExState.Normal);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x000B32B8 File Offset: 0x000B14B8
		void ICloseEx.CloseEx(CloseExState closeState)
		{
			try
			{
				if (!this.m_closed)
				{
					this.m_closed = true;
					Stream stream = this.m_stream;
					if (stream != null)
					{
						if (stream is ICloseEx)
						{
							((ICloseEx)stream).CloseEx(closeState);
						}
						else
						{
							stream.Close();
						}
						this.m_stream = null;
					}
				}
			}
			finally
			{
			}
		}

		/// <summary>Возвращает поток данных из ресурса файловой системы.</summary>
		/// <returns>Объект <see cref="T:System.IO.Stream" /> для чтения данных из ресурса файловой системы.</returns>
		// Token: 0x0600335C RID: 13148 RVA: 0x000B3314 File Offset: 0x000B1514
		public override Stream GetResponseStream()
		{
			try
			{
				this.CheckDisposed();
			}
			finally
			{
			}
			return this.m_stream;
		}

		// Token: 0x04001E12 RID: 7698
		private const int DefaultFileStreamBufferSize = 8192;

		// Token: 0x04001E13 RID: 7699
		private const string DefaultFileContentType = "application/octet-stream";

		// Token: 0x04001E14 RID: 7700
		private bool m_closed;

		// Token: 0x04001E15 RID: 7701
		private long m_contentLength;

		// Token: 0x04001E16 RID: 7702
		private FileAccess m_fileAccess;

		// Token: 0x04001E17 RID: 7703
		private WebHeaderCollection m_headers;

		// Token: 0x04001E18 RID: 7704
		private Stream m_stream;

		// Token: 0x04001E19 RID: 7705
		private Uri m_uri;
	}
}
