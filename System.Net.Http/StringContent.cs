using System;
using System.Net.Http.Headers;
using System.Text;

namespace System.Net.Http
{
	/// <summary>Предоставляет содержимое HTTP на основе строки.</summary>
	// Token: 0x02000032 RID: 50
	public class StringContent : ByteArrayContent
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.StringContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.StringContent" />.</param>
		// Token: 0x06000193 RID: 403 RVA: 0x00006A33 File Offset: 0x00004C33
		public StringContent(string content) : this(content, null, null)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.StringContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.StringContent" />.</param>
		/// <param name="encoding">Кодировка, используемая для содержимого.</param>
		// Token: 0x06000194 RID: 404 RVA: 0x00006A3E File Offset: 0x00004C3E
		public StringContent(string content, Encoding encoding) : this(content, encoding, null)
		{
		}

		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.Http.StringContent" />.</summary>
		/// <param name="content">Содержимое, используемое для инициализации <see cref="T:System.Net.Http.StringContent" />.</param>
		/// <param name="encoding">Кодировка, используемая для содержимого.</param>
		/// <param name="mediaType">Тип мультимедиа, используемый для содержимого.</param>
		// Token: 0x06000195 RID: 405 RVA: 0x00006A49 File Offset: 0x00004C49
		public StringContent(string content, Encoding encoding, string mediaType) : base(StringContent.GetByteArray(content, encoding))
		{
			base.Headers.ContentType = new MediaTypeHeaderValue(mediaType ?? "text/plain")
			{
				CharSet = (encoding ?? Encoding.UTF8).WebName
			};
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00006A87 File Offset: 0x00004C87
		private static byte[] GetByteArray(string content, Encoding encoding)
		{
			return (encoding ?? Encoding.UTF8).GetBytes(content);
		}
	}
}
