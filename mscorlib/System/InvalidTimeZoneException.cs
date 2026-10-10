using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается в случае недопустимых данных часового пояса.</summary>
	// Token: 0x0200014E RID: 334
	[TypeForwardedFrom("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class InvalidTimeZoneException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidTimeZoneException" />, используя системное сообщение.</summary>
		// Token: 0x06000C96 RID: 3222 RVA: 0x00004B05 File Offset: 0x00002D05
		public InvalidTimeZoneException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidTimeZoneException" /> с указанной строкой сообщения.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		// Token: 0x06000C97 RID: 3223 RVA: 0x000328A2 File Offset: 0x00030AA2
		public InvalidTimeZoneException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidTimeZoneException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Строка с описанием исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения.</param>
		// Token: 0x06000C98 RID: 3224 RVA: 0x000328AB File Offset: 0x00030AAB
		public InvalidTimeZoneException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidTimeZoneException" /> из сериализованных данных.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные.</param>
		/// <param name="context">Поток, содержащий сериализованные данные.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="info" /> имеет значение <see langword="null" />.  
		/// -или- 
		/// Параметр <paramref name="context" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000C99 RID: 3225 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected InvalidTimeZoneException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
