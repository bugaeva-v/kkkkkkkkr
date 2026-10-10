using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при истечении времени, предоставленного процессу или операции.</summary>
	// Token: 0x02000195 RID: 405
	[Serializable]
	public class TimeoutException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeoutException" />.</summary>
		// Token: 0x0600102F RID: 4143 RVA: 0x000425C3 File Offset: 0x000407C3
		public TimeoutException() : base("The operation has timed out.")
		{
			base.HResult = -2146233083;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeoutException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06001030 RID: 4144 RVA: 0x000425DB File Offset: 0x000407DB
		public TimeoutException(string message) : base(message)
		{
			base.HResult = -2146233083;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.TimeoutException" /> с указанным сообщением об ошибке и внутренним исключением.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001031 RID: 4145 RVA: 0x000425EF File Offset: 0x000407EF
		public TimeoutException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233083;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeoutException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта о вызываемом исключении.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении. Параметр <paramref name="context" /> зарезервирован для будущего использования и может быть задан значением <see langword="null" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">Имя класса — <see langword="null" />, или <see cref="P:System.Exception.HResult" /> равно нулю (0).</exception>
		// Token: 0x06001032 RID: 4146 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected TimeoutException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
