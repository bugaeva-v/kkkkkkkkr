using System;
using System.Runtime.Serialization;

namespace System.Net.NetworkInformation
{
	/// <summary>Исключение возникает, когда метод <see cref="Overload:System.Net.NetworkInformation.Ping.Send" /> или <see cref="Overload:System.Net.NetworkInformation.Ping.SendAsync" /> вызывают метод, приводящий к исключению.</summary>
	// Token: 0x0200070D RID: 1805
	[Serializable]
	public class PingException : InvalidOperationException
	{
		// Token: 0x060039C6 RID: 14790 RVA: 0x000A7186 File Offset: 0x000A5386
		internal PingException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PingException" /> с сериализованными данными.</summary>
		/// <param name="serializationInfo">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения о начальном или конечном объекте сериализации.</param>
		// Token: 0x060039C7 RID: 14791 RVA: 0x000A7197 File Offset: 0x000A5397
		protected PingException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PingException" />, используя указанное сообщение.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x060039C8 RID: 14792 RVA: 0x000A718E File Offset: 0x000A538E
		public PingException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.NetworkInformation.PingException" />, используя указанное сообщение и внутреннее исключение.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		/// <param name="innerException">Исключение, которое вызывает текущее исключение.</param>
		// Token: 0x060039C9 RID: 14793 RVA: 0x000C8EAF File Offset: 0x000C70AF
		public PingException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
