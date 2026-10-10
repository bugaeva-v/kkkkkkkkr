using System;

namespace System.Runtime.Serialization
{
	/// <summary>Исключение, которое выдается при возникновении ошибки во время сериализации или десериализации.</summary>
	// Token: 0x0200064B RID: 1611
	[Serializable]
	public class SerializationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationException" /> стандартными свойствами.</summary>
		// Token: 0x06003C4F RID: 15439 RVA: 0x000D147B File Offset: 0x000CF67B
		public SerializationException() : base(SerializationException.s_nullMessage)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationException" /> с заданным сообщением.</summary>
		/// <param name="message">Указывает причину возникновения исключения.</param>
		// Token: 0x06003C50 RID: 15440 RVA: 0x000D1493 File Offset: 0x000CF693
		public SerializationException(string message) : base(message)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06003C51 RID: 15441 RVA: 0x000D14A7 File Offset: 0x000CF6A7
		public SerializationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233076;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект сведений о сериализации, хранящий данные сериализованного объекта в форме имя-значение.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении исключения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003C52 RID: 15442 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected SerializationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x04002715 RID: 10005
		private static string s_nullMessage = "Serialization error.";
	}
}
