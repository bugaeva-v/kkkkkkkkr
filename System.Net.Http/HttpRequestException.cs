using System;

namespace System.Net.Http
{
	/// <summary>Базовый класс для исключений, вызванных классами <see cref="T:System.Net.Http.HttpClient" /> и <see cref="T:System.Net.Http.HttpMessageHandler" />.</summary>
	// Token: 0x02000029 RID: 41
	[Serializable]
	public class HttpRequestException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpRequestException" />.</summary>
		// Token: 0x0600014A RID: 330 RVA: 0x0000599A File Offset: 0x00003B9A
		public HttpRequestException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpRequestException" /> с указанным сообщением, описывающим текущее исключением.</summary>
		/// <param name="message">Сообщение, описывающее текущее исключение.</param>
		// Token: 0x0600014B RID: 331 RVA: 0x000059A2 File Offset: 0x00003BA2
		public HttpRequestException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Http.HttpRequestException" /> с указанным сообщением, описывающим текущее исключение и внутреннее исключение.</summary>
		/// <param name="message">Сообщение, описывающее текущее исключение.</param>
		/// <param name="inner">Внутреннее исключение.</param>
		// Token: 0x0600014C RID: 332 RVA: 0x000059AB File Offset: 0x00003BAB
		public HttpRequestException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
