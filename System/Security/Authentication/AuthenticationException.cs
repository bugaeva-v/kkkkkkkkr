using System;
using System.Runtime.Serialization;

namespace System.Security.Authentication
{
	/// <summary>Исключение возникает при сбое проверки подлинности для потока проверки подлинности.</summary>
	// Token: 0x0200029B RID: 667
	[Serializable]
	public class AuthenticationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.AuthenticationException" /> без сообщения.</summary>
		// Token: 0x06001518 RID: 5400 RVA: 0x0005572D File Offset: 0x0005392D
		public AuthenticationException() : base(Locale.GetText("Authentication exception."))
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.AuthenticationException" /> указанным сообщением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, представляющее описание сбоя проверки подлинности.</param>
		// Token: 0x06001519 RID: 5401 RVA: 0x0002F15C File Offset: 0x0002D35C
		public AuthenticationException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.AuthenticationException" /> указанным сообщением и внутренним исключением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, представляющее описание сбоя проверки подлинности.</param>
		/// <param name="innerException">Исключение <see cref="T:System.Exception" />, являющееся причиной текущего исключения.</param>
		// Token: 0x0600151A RID: 5402 RVA: 0x0002F191 File Offset: 0x0002D391
		public AuthenticationException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Authentication.AuthenticationException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит информацию, необходимую для десериализации нового экземпляра класса <see cref="T:System.Security.Authentication.AuthenticationException" />.</param>
		/// <param name="streamingContext">Экземпляр <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x0600151B RID: 5403 RVA: 0x0005573F File Offset: 0x0005393F
		protected AuthenticationException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}
	}
}
