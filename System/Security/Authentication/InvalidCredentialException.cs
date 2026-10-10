using System;
using System.Runtime.Serialization;

namespace System.Security.Authentication
{
	/// <summary>Исключение, возникающее при сбое и невозможности повторить проверку подлинности для потока проверки подлинности.</summary>
	// Token: 0x0200029F RID: 671
	[Serializable]
	public class InvalidCredentialException : AuthenticationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.InvalidCredentialException" /> без сообщения.</summary>
		// Token: 0x0600151C RID: 5404 RVA: 0x00055749 File Offset: 0x00053949
		public InvalidCredentialException() : base(Locale.GetText("Invalid credentials exception."))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.InvalidCredentialException" /> указанным сообщением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, представляющее описание сбоя проверки подлинности.</param>
		// Token: 0x0600151D RID: 5405 RVA: 0x0005575B File Offset: 0x0005395B
		public InvalidCredentialException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.InvalidCredentialException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, представляющее описание сбоя проверки подлинности.</param>
		/// <param name="innerException">Исключение <see cref="T:System.Exception" />, являющееся причиной текущего исключения.</param>
		// Token: 0x0600151E RID: 5406 RVA: 0x00055764 File Offset: 0x00053964
		public InvalidCredentialException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.InvalidCredentialException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит информацию, необходимую для десериализации нового экземпляра класса <see cref="T:System.Security.Authentication.InvalidCredentialException" />.</param>
		/// <param name="streamingContext">Экземпляр <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x0600151F RID: 5407 RVA: 0x0005576E File Offset: 0x0005396E
		protected InvalidCredentialException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}
	}
}
