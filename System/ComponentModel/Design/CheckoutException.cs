using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel.Design
{
	/// <summary>Исключение, которое создается, если попытка попытка извлечь возвращенный в программу управления исходным кодом файл отменяется или вызывает ошибку.</summary>
	// Token: 0x0200043E RID: 1086
	[Serializable]
	public class CheckoutException : ExternalException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" /> со связанным сообщением или кодом ошибки.</summary>
		// Token: 0x06002381 RID: 9089 RVA: 0x00080FE3 File Offset: 0x0007F1E3
		public CheckoutException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" /> указанным сообщением.</summary>
		/// <param name="message">Сообщение, описывающее исключение.</param>
		// Token: 0x06002382 RID: 9090 RVA: 0x00080FEB File Offset: 0x0007F1EB
		public CheckoutException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" /> с указанным сообщением и кодом ошибки.</summary>
		/// <param name="message">Сообщение, описывающее исключение.</param>
		/// <param name="errorCode">Передаваемый код ошибки.</param>
		// Token: 0x06002383 RID: 9091 RVA: 0x00080FF4 File Offset: 0x0007F1F4
		public CheckoutException(string message, int errorCode) : base(message, errorCode)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" />, используя указанные данные сериализации и контекст.</summary>
		/// <param name="info">Метод <see cref="T:System.Runtime.Serialization.SerializationInfo" />, используемый для десериализации.</param>
		/// <param name="context">Объект назначения, используемый для десериализации.</param>
		// Token: 0x06002384 RID: 9092 RVA: 0x00080FFE File Offset: 0x0007F1FE
		protected CheckoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" /> с указанным подробным описанием и указанным исключением.</summary>
		/// <param name="message">Подробное описание ошибки.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение, которое является причиной этого исключения.</param>
		// Token: 0x06002385 RID: 9093 RVA: 0x00081008 File Offset: 0x0007F208
		public CheckoutException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x040010AC RID: 4268
		private const int E_ABORT = -2147467260;

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.CheckoutException" />, указывающий на отмену попытки извлечь файл. Это поле доступно только для чтения.</summary>
		// Token: 0x040010AD RID: 4269
		public static readonly CheckoutException Canceled = new CheckoutException("The checkout was canceled by the user.", -2147467260);
	}
}
