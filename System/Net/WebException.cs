using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Исключение, которое выдается, если при обращении к сети через подключаемый протокол возникает ошибка.</summary>
	// Token: 0x02000605 RID: 1541
	[Serializable]
	public class WebException : InvalidOperationException, ISerializable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" />.</summary>
		// Token: 0x060030AC RID: 12460 RVA: 0x000A76FB File Offset: 0x000A58FB
		public WebException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" /> указанным сообщением об ошибке.</summary>
		/// <param name="message">Текст сообщения об ошибке.</param>
		// Token: 0x060030AD RID: 12461 RVA: 0x000A770B File Offset: 0x000A590B
		public WebException(string message) : this(message, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" /> с указанным сообщением об ошибке и вложенным исключением.</summary>
		/// <param name="message">Текст сообщения об ошибке.</param>
		/// <param name="innerException">Вложенное исключение.</param>
		// Token: 0x060030AE RID: 12462 RVA: 0x000A7715 File Offset: 0x000A5915
		public WebException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" /> с указанным сообщением об ошибке и статусом.</summary>
		/// <param name="message">Текст сообщения об ошибке.</param>
		/// <param name="status">Одно из значений перечисления <see cref="T:System.Net.WebExceptionStatus" />.</param>
		// Token: 0x060030AF RID: 12463 RVA: 0x000A7727 File Offset: 0x000A5927
		public WebException(string message, WebExceptionStatus status) : this(message, null, status, null)
		{
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000A7733 File Offset: 0x000A5933
		internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException) : this(message, innerException, status, null, internalStatus)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" /> с указанным сообщением об ошибке, вложенным исключением, статусом и ответом.</summary>
		/// <param name="message">Текст сообщения об ошибке.</param>
		/// <param name="innerException">Вложенное исключение.</param>
		/// <param name="status">Одно из значений перечисления <see cref="T:System.Net.WebExceptionStatus" />.</param>
		/// <param name="response">Экземпляр <see cref="T:System.Net.WebResponse" />, содержащий ответ от удаленного узла в сети.</param>
		// Token: 0x060030B1 RID: 12465 RVA: 0x000A7741 File Offset: 0x000A5941
		public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response) : this(message, null, innerException, status, response)
		{
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000A7750 File Offset: 0x000A5950
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response) : base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
		{
			this.m_Status = status;
			this.m_Response = response;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000A779C File Offset: 0x000A599C
		internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) : this(message, null, innerException, status, response, internalStatus)
		{
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000A77AC File Offset: 0x000A59AC
		internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus) : base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
		{
			this.m_Status = status;
			this.m_Response = response;
			this.m_InternalStatus = internalStatus;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.WebException" /> из указанных экземпляров <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="serializationInfo">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, который содержит сведения, необходимые для сериализации нового экземпляра класса <see cref="T:System.Net.WebException" />.</param>
		/// <param name="streamingContext">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, который содержит источник сериализованного потока, связанного с новым объектом <see cref="T:System.Net.WebException" />.</param>
		// Token: 0x060030B5 RID: 12469 RVA: 0x000A7800 File Offset: 0x000A5A00
		protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
		{
		}

		/// <summary>Сериализует этот экземпляр в указанный объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</summary>
		/// <param name="serializationInfo">Объект, в который будет сериализован этот экземпляр <see cref="T:System.Net.WebException" />.</param>
		/// <param name="streamingContext">Назначение сериализации.</param>
		// Token: 0x060030B6 RID: 12470 RVA: 0x000A7812 File Offset: 0x000A5A12
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			this.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Заполняет экземпляр <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации экземпляра <see cref="T:System.Net.WebException" />.</summary>
		/// <param name="serializationInfo">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.SerializationInfo" />.</param>
		/// <param name="streamingContext">Используемые данные о сериализации <see cref="T:System.Runtime.Serialization.StreamingContext" />.</param>
		// Token: 0x060030B7 RID: 12471 RVA: 0x0002975A File Offset: 0x0002795A
		[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
		public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
			base.GetObjectData(serializationInfo, streamingContext);
		}

		/// <summary>Возвращает состояние ответа.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Net.WebExceptionStatus" />.</returns>
		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000A781C File Offset: 0x000A5A1C
		public WebExceptionStatus Status
		{
			get
			{
				return this.m_Status;
			}
		}

		/// <summary>Получает ответ, возвращенный удаленным узлом.</summary>
		/// <returns>Если ответ доступен из интернет-ресурсов, экземпляр <see cref="T:System.Net.WebResponse" />, содержащий отклик из интернет-ресурса, в противном случае — <see langword="null" />.</returns>
		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x060030B9 RID: 12473 RVA: 0x000A7824 File Offset: 0x000A5A24
		public WebResponse Response
		{
			get
			{
				return this.m_Response;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x060030BA RID: 12474 RVA: 0x000A782C File Offset: 0x000A5A2C
		internal WebExceptionInternalStatus InternalStatus
		{
			get
			{
				return this.m_InternalStatus;
			}
		}

		// Token: 0x04001C40 RID: 7232
		private WebExceptionStatus m_Status = WebExceptionStatus.UnknownError;

		// Token: 0x04001C41 RID: 7233
		private WebResponse m_Response;

		// Token: 0x04001C42 RID: 7234
		[NonSerialized]
		private WebExceptionInternalStatus m_InternalStatus;
	}
}
