using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	/// <summary>Исключение, вызываемое при использовании недопустимых аргументов, являющихся перечислителями.</summary>
	// Token: 0x02000374 RID: 884
	[Serializable]
	public class InvalidEnumArgumentException : ArgumentException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> без сообщения.</summary>
		// Token: 0x06001D28 RID: 7464 RVA: 0x00068556 File Offset: 0x00066756
		public InvalidEnumArgumentException() : this(null)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> указанным сообщением.</summary>
		/// <param name="message">Сообщение, отображаемое для этого исключения.</param>
		// Token: 0x06001D29 RID: 7465 RVA: 0x0006855F File Offset: 0x0006675F
		public InvalidEnumArgumentException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidEnumArgumentException" /> с указанным подробным описанием и указанным исключением.</summary>
		/// <param name="message">Подробное описание ошибки.</param>
		/// <param name="innerException">Ссылка на внутреннее исключение, которое является причиной этого исключения.</param>
		// Token: 0x06001D2A RID: 7466 RVA: 0x00068568 File Offset: 0x00066768
		public InvalidEnumArgumentException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidEnumArgumentException" />, используя сообщение, созданное с использованием аргумента, недопустимого значения и класса перечисления.</summary>
		/// <param name="argumentName">Имя аргумента, вызвавшего исключение.</param>
		/// <param name="invalidValue">Значение аргумента, вызвавшего сбой.</param>
		/// <param name="enumClass">Объект <see cref="T:System.Type" />, представляющий класс перечисления с допустимыми значениями.</param>
		// Token: 0x06001D2B RID: 7467 RVA: 0x00068572 File Offset: 0x00066772
		public InvalidEnumArgumentException(string argumentName, int invalidValue, Type enumClass) : base(SR.Format("The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.", argumentName, invalidValue.ToString(CultureInfo.CurrentCulture), enumClass.Name), argumentName)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.InvalidEnumArgumentException" />, используя указанные данные сериализации и контекст.</summary>
		/// <param name="info">Метод <see cref="T:System.Runtime.Serialization.SerializationInfo" />, используемый для десериализации.</param>
		/// <param name="context">Объект назначения, используемый для десериализации.</param>
		// Token: 0x06001D2C RID: 7468 RVA: 0x00068598 File Offset: 0x00066798
		protected InvalidEnumArgumentException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
