using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Задает исключение, которое будет обрабатываться как предупреждение, а не как ошибка.</summary>
	// Token: 0x020003FA RID: 1018
	[Serializable]
	public class WarningException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" />.</summary>
		// Token: 0x0600212C RID: 8492 RVA: 0x00072085 File Offset: 0x00070285
		public WarningException() : this(null, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" />, используя указанное сообщение, но без файла справки.</summary>
		/// <param name="message">Сообщение, которое будет отображаться для конечного пользователя.</param>
		// Token: 0x0600212D RID: 8493 RVA: 0x00072090 File Offset: 0x00070290
		public WarningException(string message) : this(message, null, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" />, используя заданное сообщение и доступ к указанному файлу справки.</summary>
		/// <param name="message">Сообщение, которое будет отображаться для конечного пользователя.</param>
		/// <param name="helpUrl">Файл справки, отображаемый, если пользователь запросит справку.</param>
		// Token: 0x0600212E RID: 8494 RVA: 0x0007209B File Offset: 0x0007029B
		public WarningException(string message, string helpUrl) : this(message, helpUrl, null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" /> с указанным подробным описанием и указанным исключением.</summary>
		/// <param name="message">Подробное описание ошибки.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение, которое является причиной этого исключения.</param>
		// Token: 0x0600212F RID: 8495 RVA: 0x0002F191 File Offset: 0x0002D391
		public WarningException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" />, используя заданное сообщение и доступ к указанным файлу и разделу справки.</summary>
		/// <param name="message">Сообщение, которое будет отображаться для конечного пользователя.</param>
		/// <param name="helpUrl">Файл справки, отображаемый, если пользователь запросит справку.</param>
		/// <param name="helpTopic">Раздел справки, отображаемый, если пользователь запросит справку.</param>
		// Token: 0x06002130 RID: 8496 RVA: 0x000720A6 File Offset: 0x000702A6
		public WarningException(string message, string helpUrl, string helpTopic) : base(message)
		{
			this.HelpUrl = helpUrl;
			this.HelpTopic = helpTopic;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.WarningException" />, используя указанные данные сериализации и контекст.</summary>
		/// <param name="info">Метод <see cref="T:System.Runtime.Serialization.SerializationInfo" />, используемый для десериализации.</param>
		/// <param name="context">Объект назначения, используемый для десериализации.</param>
		// Token: 0x06002131 RID: 8497 RVA: 0x000720C0 File Offset: 0x000702C0
		protected WarningException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			this.HelpUrl = (string)info.GetValue("helpUrl", typeof(string));
			this.HelpTopic = (string)info.GetValue("helpTopic", typeof(string));
		}

		/// <summary>Возвращает файл справки, связанный с данным предупреждением.</summary>
		/// <returns>Файл справки, связанный с данным предупреждением.</returns>
		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06002132 RID: 8498 RVA: 0x00072115 File Offset: 0x00070315
		public string HelpUrl { get; }

		/// <summary>Возвращает раздел справки, связанный с данным предупреждением.</summary>
		/// <returns>Раздел справки, связанный с данным предупреждением.</returns>
		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06002133 RID: 8499 RVA: 0x0007211D File Offset: 0x0007031D
		public string HelpTopic { get; }

		/// <summary>Устанавливает для объекта <see cref="T:System.Runtime.Serialization.SerializationInfo" /> имя параметра и дополнительные сведения об исключении.</summary>
		/// <param name="info">Хранит данные, использовавшиеся при сериализации (десериализации) объекта с помощью класса <see cref="T:System.ComponentModel.Design.Serialization.CodeDomSerializer" />.</param>
		/// <param name="context">Описывает источник и место назначения потока, создающего исключение, а также служит для сохранения этого контекста и дополнительного контекста, определяемого вызывающим в процессе сериализации.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002134 RID: 8500 RVA: 0x00072125 File Offset: 0x00070325
		[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("helpUrl", this.HelpUrl);
			info.AddValue("helpTopic", this.HelpTopic);
		}
	}
}
