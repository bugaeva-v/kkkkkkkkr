using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается, если возможность не работает на соответствующей платформе.</summary>
	// Token: 0x0200016F RID: 367
	[Serializable]
	public class PlatformNotSupportedException : NotSupportedException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.PlatformNotSupportedException" /> стандартными свойствами.</summary>
		// Token: 0x06000E89 RID: 3721 RVA: 0x0003B9D6 File Offset: 0x00039BD6
		public PlatformNotSupportedException() : base("Operation is not supported on this platform.")
		{
			base.HResult = -2146233031;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.PlatformNotSupportedException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке с объяснением причины исключения.</param>
		// Token: 0x06000E8A RID: 3722 RVA: 0x0003B9EE File Offset: 0x00039BEE
		public PlatformNotSupportedException(string message) : base(message)
		{
			base.HResult = -2146233031;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.PlatformNotSupportedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000E8B RID: 3723 RVA: 0x0003BA02 File Offset: 0x00039C02
		public PlatformNotSupportedException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233031;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.PlatformNotSupportedException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000E8C RID: 3724 RVA: 0x0003BA17 File Offset: 0x00039C17
		protected PlatformNotSupportedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
