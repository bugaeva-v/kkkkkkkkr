using System;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	/// <summary>Вызывается, когда поток, в котором должна выполняться операция, больше не существует или в нем отсутствует цикл обработки сообщений.</summary>
	// Token: 0x020003C3 RID: 963
	[Serializable]
	public class InvalidAsynchronousStateException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidAsynchronousStateException" />.</summary>
		// Token: 0x06001F3B RID: 7995 RVA: 0x0006CDF5 File Offset: 0x0006AFF5
		public InvalidAsynchronousStateException() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidAsynchronousStateException" />, используя заданное подробное описание.</summary>
		/// <param name="message">Подробное описание ошибки.</param>
		// Token: 0x06001F3C RID: 7996 RVA: 0x0006855F File Offset: 0x0006675F
		public InvalidAsynchronousStateException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidAsynchronousStateException" /> с указанным подробным описанием и указанным исключением.</summary>
		/// <param name="message">Подробное описание ошибки.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение, которое является причиной этого исключения.</param>
		// Token: 0x06001F3D RID: 7997 RVA: 0x00068568 File Offset: 0x00066768
		public InvalidAsynchronousStateException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidAsynchronousStateException" /> с заданными объектами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Метод <see cref="T:System.Runtime.Serialization.SerializationInfo" />, используемый для десериализации.</param>
		/// <param name="context">Объект назначения, используемый для десериализации.</param>
		// Token: 0x06001F3E RID: 7998 RVA: 0x00068598 File Offset: 0x00066798
		protected InvalidAsynchronousStateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
