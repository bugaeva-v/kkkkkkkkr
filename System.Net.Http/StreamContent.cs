using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Предоставляет содержимое HTTP на основе потока.</summary>
	// Token: 0x02000031 RID: 49
	public class StreamContent : HttpContent
	{
		/// <summary>Создание нового экземпляра класса <see cref="T:System.Net.Http.StreamContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.StreamContent" />.</param>
		// Token: 0x0600018C RID: 396 RVA: 0x00006912 File Offset: 0x00004B12
		public StreamContent(Stream content) : this(content, 16384)
		{
		}

		/// <summary>Создание нового экземпляра класса <see cref="T:System.Net.Http.StreamContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.StreamContent" />.</param>
		/// <param name="bufferSize">Размер (в байтах) буфера, доступного для <see cref="T:System.Net.Http.StreamContent" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="content" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="bufferSize" /> было меньше или равно нулю.</exception>
		// Token: 0x0600018D RID: 397 RVA: 0x00006920 File Offset: 0x00004B20
		public StreamContent(Stream content, int bufferSize)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			if (bufferSize <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferSize");
			}
			this.content = content;
			this.bufferSize = bufferSize;
			if (content.CanSeek)
			{
				this.startPosition = content.Position;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00006972 File Offset: 0x00004B72
		internal StreamContent(Stream content, CancellationToken cancellationToken) : this(content)
		{
			this.cancellationToken = cancellationToken;
		}

		/// <summary>Запись содержимого потока HTTP в поток в памяти в качестве асинхронной операции.</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x0600018F RID: 399 RVA: 0x00006982 File Offset: 0x00004B82
		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			return Task.FromResult<Stream>(this.content);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Net.Http.StreamContent" />, и при необходимости удаляет управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> для освобождения управляемых и неуправляемых ресурсов; значение <see langword="false" /> для освобождения только неуправляемых ресурсов.</param>
		// Token: 0x06000190 RID: 400 RVA: 0x0000698F File Offset: 0x00004B8F
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.content.Dispose();
			}
			base.Dispose(disposing);
		}

		/// <summary>Сериализация содержимого HTTP в поток в качестве асинхронной операции.</summary>
		/// <param name="stream">Целевой поток.</param>
		/// <param name="context">Сведения о транспорте (например, маркер привязки каналов). Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x06000191 RID: 401 RVA: 0x000069A8 File Offset: 0x00004BA8
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			if (this.contentCopied)
			{
				if (!this.content.CanSeek)
				{
					throw new InvalidOperationException("The stream was already consumed. It cannot be read again.");
				}
				this.content.Seek(this.startPosition, SeekOrigin.Begin);
			}
			else
			{
				this.contentCopied = true;
			}
			return this.content.CopyToAsync(stream, this.bufferSize, this.cancellationToken);
		}

		/// <summary>Определяет, имеет ли содержимое потока допустимую длину в байтах.</summary>
		/// <param name="length">Длина (в байтах) содержимого потока.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="length" /> является допустимой длиной; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000192 RID: 402 RVA: 0x00006A09 File Offset: 0x00004C09
		protected internal override bool TryComputeLength(out long length)
		{
			if (!this.content.CanSeek)
			{
				length = 0L;
				return false;
			}
			length = this.content.Length - this.startPosition;
			return true;
		}

		// Token: 0x040000D4 RID: 212
		private readonly Stream content;

		// Token: 0x040000D5 RID: 213
		private readonly int bufferSize;

		// Token: 0x040000D6 RID: 214
		private readonly CancellationToken cancellationToken;

		// Token: 0x040000D7 RID: 215
		private readonly long startPosition;

		// Token: 0x040000D8 RID: 216
		private bool contentCopied;
	}
}
