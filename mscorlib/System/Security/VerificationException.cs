using System;
using System.Runtime.Serialization;

namespace System.Security
{
	/// <summary>Исключение, которое создается, если в политику безопасности входит требование типобезопасности кода, а в ходе проверки невозможно определить, выполнено ли это требование в коде.</summary>
	// Token: 0x020003C4 RID: 964
	[Serializable]
	public class VerificationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.VerificationException" /> стандартными свойствами.</summary>
		// Token: 0x06002848 RID: 10312 RVA: 0x00092A08 File Offset: 0x00090C08
		public VerificationException() : base("Operation could destabilize the runtime.")
		{
			base.HResult = -2146233075;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.VerificationException" />, используя пояснительное сообщение.</summary>
		/// <param name="message">Сообщение, содержащее причину возникновения исключения.</param>
		// Token: 0x06002849 RID: 10313 RVA: 0x00092A20 File Offset: 0x00090C20
		public VerificationException(string message) : base(message)
		{
			base.HResult = -2146233075;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.VerificationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600284A RID: 10314 RVA: 0x00092A34 File Offset: 0x00090C34
		public VerificationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233075;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.VerificationException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x0600284B RID: 10315 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected VerificationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
