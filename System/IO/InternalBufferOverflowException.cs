using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое создается при переполнении внутреннего буфера.</summary>
	// Token: 0x02000518 RID: 1304
	[Serializable]
	public class InternalBufferOverflowException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр по умолчанию класса <see cref="T:System.IO.InternalBufferOverflowException" />.</summary>
		// Token: 0x06002A4C RID: 10828 RVA: 0x000918D5 File Offset: 0x0008FAD5
		public InternalBufferOverflowException() : base("Internal buffer overflow occurred.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.InternalBufferOverflowException" /> с заданным сообщением об ошибке для отображения.</summary>
		/// <param name="message">Сообщение для исключения.</param>
		// Token: 0x06002A4D RID: 10829 RVA: 0x0002F15C File Offset: 0x0002D35C
		public InternalBufferOverflowException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый пустой экземпляр класса <see cref="T:System.IO.InternalBufferOverflowException" />, который может быть сериализован с помощью объектов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Информация, необходимая для сериализации объекта T:System.IO.InternalBufferOverflowException.</param>
		/// <param name="context">Источник и объект назначения сериализованного объекта связаны с объектом T:System.IO.InternalBufferOverflowException.</param>
		// Token: 0x06002A4E RID: 10830 RVA: 0x0005573F File Offset: 0x0005393F
		protected InternalBufferOverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.InternalBufferOverflowException" /> с заданным сообщением для отображения и созданным внутренним исключением.</summary>
		/// <param name="message">Сообщение для исключения.</param>
		/// <param name="inner">Внутреннее исключение.</param>
		// Token: 0x06002A4F RID: 10831 RVA: 0x0002F191 File Offset: 0x0002D391
		public InternalBufferOverflowException(string message, Exception inner) : base(message, inner)
		{
		}
	}
}
