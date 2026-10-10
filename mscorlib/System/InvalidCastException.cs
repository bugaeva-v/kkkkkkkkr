using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается в случае недопустимого приведения или явного преобразования.</summary>
	// Token: 0x0200014B RID: 331
	[Serializable]
	public class InvalidCastException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidCastException" />.</summary>
		// Token: 0x06000C89 RID: 3209 RVA: 0x000327CF File Offset: 0x000309CF
		public InvalidCastException() : base("Specified cast is not valid.")
		{
			base.HResult = -2147467262;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidCastException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000C8A RID: 3210 RVA: 0x000327E7 File Offset: 0x000309E7
		public InvalidCastException(string message) : base(message)
		{
			base.HResult = -2147467262;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidCastException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000C8B RID: 3211 RVA: 0x000327FB File Offset: 0x000309FB
		public InvalidCastException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147467262;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidCastException" />, используя заданное сообщение и код ошибки.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		/// <param name="errorCode">Код ошибки (HRESULT) — это значение, связанное с исключением.</param>
		// Token: 0x06000C8C RID: 3212 RVA: 0x00032810 File Offset: 0x00030A10
		public InvalidCastException(string message, int errorCode) : base(message)
		{
			base.HResult = errorCode;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidCastException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000C8D RID: 3213 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected InvalidCastException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
