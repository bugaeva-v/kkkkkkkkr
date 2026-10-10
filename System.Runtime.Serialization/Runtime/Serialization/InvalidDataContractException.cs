using System;

namespace System.Runtime.Serialization
{
	/// <summary>Исключение, которое выдается, если <see cref="T:System.Runtime.Serialization.DataContractSerializer" /> или <see cref="T:System.Runtime.Serialization.NetDataContractSerializer" /> встречает недопустимый контракт данных во время сериализации или десериализации.</summary>
	// Token: 0x020000EA RID: 234
	[Serializable]
	public class InvalidDataContractException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.InvalidDataContractException" />.</summary>
		// Token: 0x06000D52 RID: 3410 RVA: 0x0003543B File Offset: 0x0003363B
		public InvalidDataContractException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.InvalidDataContractException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Описание ошибки.</param>
		// Token: 0x06000D53 RID: 3411 RVA: 0x00035443 File Offset: 0x00033643
		public InvalidDataContractException(string message) : base(message)
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Runtime.Serialization.InvalidDataContractException" /> с указанным сообщением об ошибке и внутренним исключением.</summary>
		/// <param name="message">Описание ошибки.</param>
		/// <param name="innerException">Исходный объект <see cref="T:System.Exception" />.</param>
		// Token: 0x06000D54 RID: 3412 RVA: 0x0003544C File Offset: 0x0003364C
		public InvalidDataContractException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.InvalidDataContractException" /> с заданными свойствами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий данные, необходимые для сериализации и десериализации объекта.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, задающий контекст пользователя во время сериализации и десериализации.</param>
		// Token: 0x06000D55 RID: 3413 RVA: 0x00035456 File Offset: 0x00033656
		protected InvalidDataContractException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
