using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Представляет исключение, возникающее, когда объекту <see cref="T:System.Net.Mail.SmtpClient" /> не удается завершить операцию <see cref="Overload:System.Net.Mail.SmtpClient.Send" /> или <see cref="Overload:System.Net.Mail.SmtpClient.SendAsync" /> для определенного получателя.</summary>
	// Token: 0x0200083A RID: 2106
	[Serializable]
	public class SmtpFailedRecipientException : SmtpException, ISerializable
	{
		/// <summary>Инициализирует пустой экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</summary>
		// Token: 0x06004315 RID: 17173 RVA: 0x000E9EDE File Offset: 0x000E80DE
		public SmtpFailedRecipientException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, содержащее сообщение об ошибке.</param>
		// Token: 0x06004316 RID: 17174 RVA: 0x000E9EE6 File Offset: 0x000E80E6
		public SmtpFailedRecipientException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с новым экземпляром.</param>
		// Token: 0x06004317 RID: 17175 RVA: 0x000E9EEF File Offset: 0x000E80EF
		protected SmtpFailedRecipientException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.failedRecipient = info.GetString("failedRecipient");
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" /> с указанным кодом статуса и адресом электронной почты.</summary>
		/// <param name="statusCode">Значение <see cref="T:System.Net.Mail.SmtpStatusCode" />.</param>
		/// <param name="failedRecipient">Значение <see cref="T:System.String" />, содержащее адрес электронной почты.</param>
		// Token: 0x06004318 RID: 17176 RVA: 0x000E9F18 File Offset: 0x000E8118
		public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient) : base(statusCode)
		{
			this.failedRecipient = failedRecipient;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Net.Mail.SmtpException" /> с указанным сообщением об ошибке и внутренним исключением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06004319 RID: 17177 RVA: 0x000E9F28 File Offset: 0x000E8128
		public SmtpFailedRecipientException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" /> с указанным сообщением об ошибке, адресом электронной почты и внутренним исключением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		/// <param name="failedRecipient">Значение <see cref="T:System.String" />, содержащее адрес электронной почты.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x0600431A RID: 17178 RVA: 0x000E9F32 File Offset: 0x000E8132
		public SmtpFailedRecipientException(string message, string failedRecipient, Exception innerException) : base(message, innerException)
		{
			this.failedRecipient = failedRecipient;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientException" /> с указанным кодом статуса, адресом электронной почты и ответом сервера.</summary>
		/// <param name="statusCode">Значение <see cref="T:System.Net.Mail.SmtpStatusCode" />.</param>
		/// <param name="failedRecipient">Значение <see cref="T:System.String" />, содержащее адрес электронной почты.</param>
		/// <param name="serverResponse">Значение <see cref="T:System.String" />, содержащее ответ сервера.</param>
		// Token: 0x0600431B RID: 17179 RVA: 0x000E9F43 File Offset: 0x000E8143
		public SmtpFailedRecipientException(SmtpStatusCode statusCode, string failedRecipient, string serverResponse) : base(statusCode, serverResponse)
		{
			this.failedRecipient = failedRecipient;
		}

		/// <summary>Указывает адрес электронной почты с проблемами доставки.</summary>
		/// <returns>Значение <see cref="T:System.String" />, содержащее адрес электронной почты.</returns>
		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x0600431C RID: 17180 RVA: 0x000E9F54 File Offset: 0x000E8154
		public string FailedRecipient
		{
			get
			{
				return this.failedRecipient;
			}
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x0600431D RID: 17181 RVA: 0x000E9F5C File Offset: 0x000E815C
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (serializationInfo == null)
			{
				throw new ArgumentNullException("serializationInfo");
			}
			base.GetObjectData(serializationInfo, streamingContext);
			serializationInfo.AddValue("failedRecipient", this.failedRecipient);
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</summary>
		/// <param name="serializationInfo">Экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные для <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</param>
		/// <param name="streamingContext">Экземпляр <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с новым <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</param>
		// Token: 0x0600431E RID: 17182 RVA: 0x000A7812 File Offset: 0x000A5A12
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		// Token: 0x040028A5 RID: 10405
		private string failedRecipient;
	}
}
