using System;
using System.IO;
using System.Threading.Tasks;

namespace System.Net.Http
{
	/// <summary>Предоставляет содержимое HTTP на основе массива байтов.</summary>
	// Token: 0x02000012 RID: 18
	public class ByteArrayContent : HttpContent
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.ByteArrayContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="content" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060000C1 RID: 193 RVA: 0x00003B03 File Offset: 0x00001D03
		public ByteArrayContent(byte[] content)
		{
			if (content == null)
			{
				throw new ArgumentNullException("content");
			}
			this.content = content;
			this.count = content.Length;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.ByteArrayContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
		/// <param name="offset">Смещение в байтах в параметре <paramref name="content" />, используемом для инициализации объекта <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
		/// <param name="count">Число байтов в параметре <paramref name="content" />, начиная с параметра <paramref name="offset" />, используемых для инициализации объекта <see cref="T:System.Net.Http.ByteArrayContent" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="content" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">Значение параметра <paramref name="offset" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="offset" /> больше длины содержимого, указанного параметром <paramref name="content" />.  
		///
		/// или - 
		/// Значение параметра <paramref name="count" /> меньше нуля.  
		///
		/// или - 
		/// Значение параметра <paramref name="count" /> больше длины содержимого, указанного параметром <paramref name="content" /> без учета параметра <paramref name="offset" />.</exception>
		// Token: 0x060000C2 RID: 194 RVA: 0x00003B2C File Offset: 0x00001D2C
		public ByteArrayContent(byte[] content, int offset, int count) : this(content)
		{
			if (offset < 0 || offset > this.count)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || count > this.count - offset)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			this.offset = offset;
			this.count = count;
		}

		/// <summary>Создает поток HTTP-содержимого в качестве асинхронной операции для чтения (в качестве резервного хранилища используется память из <see cref="T:System.Net.Http.ByteArrayContent" />).</summary>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x060000C3 RID: 195 RVA: 0x00003B80 File Offset: 0x00001D80
		protected override Task<Stream> CreateContentReadStreamAsync()
		{
			return Task.FromResult<Stream>(new MemoryStream(this.content, this.offset, this.count));
		}

		/// <summary>Сериализует и записывает массив байтов из конструктора в поток содержимого HTTP в качестве асинхронной операции.</summary>
		/// <param name="stream">Целевой поток.</param>
		/// <param name="context">Сведения о транспорте (например, маркер привязки каналов). Этот параметр может иметь значение <see langword="null" />.</param>
		/// <returns>Объект задачи, представляющий асинхронную операцию.</returns>
		// Token: 0x060000C4 RID: 196 RVA: 0x00003B9E File Offset: 0x00001D9E
		protected override Task SerializeToStreamAsync(Stream stream, TransportContext context)
		{
			return stream.WriteAsync(this.content, this.offset, this.count);
		}

		/// <summary>Определяет, имеет ли массив байтов допустимую длину в байтах.</summary>
		/// <param name="length">Длина массива байтов в байтах.</param>
		/// <returns>Значение <see langword="true" />, если <paramref name="length" /> — допустимая длина. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000C5 RID: 197 RVA: 0x00003BB8 File Offset: 0x00001DB8
		protected internal override bool TryComputeLength(out long length)
		{
			length = (long)this.count;
			return true;
		}

		// Token: 0x0400004B RID: 75
		private readonly byte[] content;

		// Token: 0x0400004C RID: 76
		private readonly int offset;

		// Token: 0x0400004D RID: 77
		private readonly int count;
	}
}
