using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Это исключение вызывается, когда не удается найти часовой пояс.</summary>
	// Token: 0x02000194 RID: 404
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class TimeZoneNotFoundException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeZoneNotFoundException" />, используя системное сообщение.</summary>
		// Token: 0x0600102B RID: 4139 RVA: 0x00004B05 File Offset: 0x00002D05
		public TimeZoneNotFoundException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeZoneNotFoundException" /> с указанной строкой сообщения.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		// Token: 0x0600102C RID: 4140 RVA: 0x000328A2 File Offset: 0x00030AA2
		public TimeZoneNotFoundException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeZoneNotFoundException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x0600102D RID: 4141 RVA: 0x000328AB File Offset: 0x00030AAB
		public TimeZoneNotFoundException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.TimeZoneNotFoundException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные.</param>
		/// <param name="context">Поток, содержащий сериализованные данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Параметр <paramref name="context" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600102E RID: 4142 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
