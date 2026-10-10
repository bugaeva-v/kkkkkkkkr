using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Исключение, возникающее, когда электронная почта, отправленная с помощью <see cref="T:System.Net.Mail.SmtpClient" />, не может быть доставлена всем адресатам.</summary>
	// Token: 0x0200083B RID: 2107
	[Serializable]
	public class SmtpFailedRecipientsException : SmtpFailedRecipientException, ISerializable
	{
		/// <summary>Инициализирует пустой экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</summary>
		// Token: 0x0600431F RID: 17183 RVA: 0x000E9F85 File Offset: 0x000E8185
		public SmtpFailedRecipientsException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" /> указанным значением <see cref="T:System.String" />.</summary>
		/// <param name="message">Сообщение об исключении.</param>
		// Token: 0x06004320 RID: 17184 RVA: 0x000E9F8D File Offset: 0x000E818D
		public SmtpFailedRecipientsException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" /> с указанным значением <see cref="T:System.String" /> и внутренним <see cref="T:System.Exception" />.</summary>
		/// <param name="message">Сообщение об исключении.</param>
		/// <param name="innerException">Внутреннее исключение.</param>
		// Token: 0x06004321 RID: 17185 RVA: 0x000E9F96 File Offset: 0x000E8196
		public SmtpFailedRecipientsException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" /> с указанным значением <see cref="T:System.String" /> и массивом типа <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />.</summary>
		/// <param name="message">Сообщение об исключении.</param>
		/// <param name="innerExceptions">Массив получателей с ошибками доставки.</param>
		// Token: 0x06004322 RID: 17186 RVA: 0x000E9FA0 File Offset: 0x000E81A0
		public SmtpFailedRecipientsException(string message, SmtpFailedRecipientException[] innerExceptions) : base(message)
		{
			this.innerExceptions = innerExceptions;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Экземпляр класса <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, требуемые для сериализации нового экземпляра класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</param>
		/// <param name="context">Экземпляр класса <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий источник сериализованного потока, связанного с новым экземпляром класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</param>
		// Token: 0x06004323 RID: 17187 RVA: 0x000E9FB0 File Offset: 0x000E81B0
		protected SmtpFailedRecipientsException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new ArgumentNullException("info");
			}
			this.innerExceptions = (SmtpFailedRecipientException[])info.GetValue("innerExceptions", typeof(SmtpFailedRecipientException[]));
		}

		/// <summary>Возвращает один или несколько объектов <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />, указывающих получателей электронной почты с ошибками доставки SMTP.</summary>
		/// <returns>Массив типа <see cref="T:System.Net.Mail.SmtpFailedRecipientException" />, содержащий список получателей с ошибками доставки.</returns>
		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06004324 RID: 17188 RVA: 0x000E9FE8 File Offset: 0x000E81E8
		public SmtpFailedRecipientException[] InnerExceptions
		{
			get
			{
				return this.innerExceptions;
			}
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации объекта <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</summary>
		/// <param name="serializationInfo">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="streamingContext">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x06004325 RID: 17189 RVA: 0x000E9FF0 File Offset: 0x000E81F0
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (serializationInfo == null)
			{
				throw new ArgumentNullException("serializationInfo");
			}
			base.GetObjectData(serializationInfo, streamingContext);
			serializationInfo.AddValue("innerExceptions", this.innerExceptions);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" /> из указанных экземпляров <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, который содержит источник сериализованного потока, связанного с новым объектом <see cref="T:System.Net.Mail.SmtpFailedRecipientsException" />.</param>
		// Token: 0x06004326 RID: 17190 RVA: 0x000A7812 File Offset: 0x000A5A12
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.GetObjectData(info, context);
		}

		// Token: 0x040028A6 RID: 10406
		private SmtpFailedRecipientException[] innerExceptions;
	}
}
