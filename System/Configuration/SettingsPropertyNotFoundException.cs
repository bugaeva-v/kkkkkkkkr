using System;
using System.Runtime.Serialization;

namespace System.Configuration
{
	/// <summary>Генерирует исключение для ненайденных объектов <see cref="T:System.Configuration.SettingsProperty" />.</summary>
	// Token: 0x020001CF RID: 463
	[Serializable]
	public class SettingsPropertyNotFoundException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyNotFoundException" />.</summary>
		// Token: 0x06000C23 RID: 3107 RVA: 0x0000DC12 File Offset: 0x0000BE12
		public SettingsPropertyNotFoundException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyNotFoundException" />, используя предоставленный параметр.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		// Token: 0x06000C24 RID: 3108 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		public SettingsPropertyNotFoundException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> на основе предоставленных параметров.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении сериализованного потока.</param>
		// Token: 0x06000C25 RID: 3109 RVA: 0x0002C42D File Offset: 0x0002A62D
		protected SettingsPropertyNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.SettingsPropertyNotFoundException" /> на основе предоставленных параметров.</summary>
		/// <param name="message">Строка, содержащая сообщение об исключении.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000C26 RID: 3110 RVA: 0x000320E8 File Offset: 0x000302E8
		public SettingsPropertyNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
