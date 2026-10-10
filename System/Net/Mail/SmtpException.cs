using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Представляет исключение, возникающее, когда объекту <see cref="T:System.Net.Mail.SmtpClient" /> не удается выполнить операцию <see cref="Overload:System.Net.Mail.SmtpClient.Send" /> или <see cref="Overload:System.Net.Mail.SmtpClient.SendAsync" />.</summary>
	// Token: 0x02000839 RID: 2105
	[Serializable]
	public class SmtpException : Exception, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" />.</summary>
		// Token: 0x0600430B RID: 17163 RVA: 0x000E9DE6 File Offset: 0x000E7FE6
		public SmtpException() : this(SmtpStatusCode.GeneralFailure)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" /> с заданным кодом состояния.</summary>
		/// <param name="statusCode">Значение <see cref="T:System.Net.Mail.SmtpStatusCode" />.</param>
		// Token: 0x0600430C RID: 17164 RVA: 0x000E9DEF File Offset: 0x000E7FEF
		public SmtpException(SmtpStatusCode statusCode) : this(statusCode, "Syntax error, command unrecognized.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		// Token: 0x0600430D RID: 17165 RVA: 0x000E9DFD File Offset: 0x000E7FFD
		public SmtpException(string message) : this(SmtpStatusCode.GeneralFailure, message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" /> на основе указанных экземпляров классов <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Net.Mail.SmtpException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий исходный объект и объект назначения для сериализованного потока, связанного с новым экземпляром.</param>
		// Token: 0x0600430E RID: 17166 RVA: 0x000E9E08 File Offset: 0x000E8008
		protected SmtpException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
			try
			{
				this.statusCode = (SmtpStatusCode)serializationInfo.GetValue("Status", typeof(int));
			}
			catch (SerializationException)
			{
				this.statusCode = (SmtpStatusCode)serializationInfo.GetValue("statusCode", typeof(SmtpStatusCode));
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpException" /> с указанными кодом состояния и сообщением об ошибке.</summary>
		/// <param name="statusCode">Значение <see cref="T:System.Net.Mail.SmtpStatusCode" />.</param>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		// Token: 0x0600430F RID: 17167 RVA: 0x000E9E74 File Offset: 0x000E8074
		public SmtpException(SmtpStatusCode statusCode, string message) : base(message)
		{
			this.statusCode = statusCode;
		}

		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Net.Mail.SmtpException" /> с указанным сообщением об ошибке и внутренним исключением.</summary>
		/// <param name="message">Значение типа <see cref="T:System.String" />, описывающее возникшую ошибку.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06004310 RID: 17168 RVA: 0x000E9E84 File Offset: 0x000E8084
		public SmtpException(string message, Exception innerException) : base(message, innerException)
		{
			this.statusCode = SmtpStatusCode.GeneralFailure;
		}

		/// <summary>Возвращает код состояния, возвращаемый сервером SMTP при передаче сообщения электронной почты.</summary>
		/// <returns>Значение <see cref="T:System.Net.Mail.SmtpStatusCode" />, идентифицирующее произошедшую ошибку.</returns>
		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06004311 RID: 17169 RVA: 0x000E9E95 File Offset: 0x000E8095
		// (set) Token: 0x06004312 RID: 17170 RVA: 0x000E9E9D File Offset: 0x000E809D
		public SmtpStatusCode StatusCode
		{
			get
			{
				return this.statusCode;
			}
			set
			{
				this.statusCode = value;
			}
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.Mail.SmtpException" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
		/// <param name="streamingContext">Контекст <see cref="T:System.Runtime.Serialization.StreamingContext" />, определяющий целевой объект сериализации.</param>
		// Token: 0x06004313 RID: 17171 RVA: 0x000E9EA6 File Offset: 0x000E80A6
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			if (serializationInfo == null)
			{
				throw new ArgumentNullException("serializationInfo");
			}
			base.GetObjectData(serializationInfo, streamingContext);
			serializationInfo.AddValue("Status", this.statusCode, typeof(int));
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.Mail.SmtpException" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные для исключения <see cref="T:System.Net.Mail.SmtpException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий назначение сериализованного потока, связанного с новым запросом <see cref="T:System.Net.Mail.SmtpException" />.</param>
		// Token: 0x06004314 RID: 17172 RVA: 0x000A7812 File Offset: 0x000A5A12
		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.GetObjectData(info, context);
		}

		// Token: 0x040028A4 RID: 10404
		private SmtpStatusCode statusCode;
	}
}
