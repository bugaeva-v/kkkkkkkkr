using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	/// <summary>Предоставляет исключение для <see cref="T:System.Configuration.SettingsProperty" /> объектов, доступных только для чтения.</summary>
	// Token: 0x020001CE RID: 462
	[Serializable]
	public class SettingsPropertyIsReadOnlyException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyIsReadOnlyException" />.</summary>
		// Token: 0x06000C1F RID: 3103 RVA: 0x0000DC12 File Offset: 0x0000BE12
		public SettingsPropertyIsReadOnlyException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyIsReadOnlyException" /> на основе предоставленного параметра.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		// Token: 0x06000C20 RID: 3104 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		public SettingsPropertyIsReadOnlyException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyIsReadOnlyException" /> на основе предоставленных параметров.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении сериализованного потока.</param>
		// Token: 0x06000C21 RID: 3105 RVA: 0x0002C42D File Offset: 0x0002A62D
		protected SettingsPropertyIsReadOnlyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyIsReadOnlyException" /> на основе предоставленных параметров.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000C22 RID: 3106 RVA: 0x000320E8 File Offset: 0x000302E8
		public SettingsPropertyIsReadOnlyException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
