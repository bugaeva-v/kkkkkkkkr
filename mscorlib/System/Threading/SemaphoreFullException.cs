using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Это исключение создается при вызове метода <see cref="Overload:System.Threading.Semaphore.Release" /> семафора, счетчик которого уже имеет максимальное значение.</summary>
	// Token: 0x02000293 RID: 659
	[TypeForwardedFrom("System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
	[Serializable]
	public class SemaphoreFullException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreFullException" /> со значениями по умолчанию.</summary>
		// Token: 0x06001D8F RID: 7567 RVA: 0x0006E698 File Offset: 0x0006C898
		public SemaphoreFullException() : base("Adding the specified count to the semaphore would cause it to exceed its maximum count.")
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreFullException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06001D90 RID: 7568 RVA: 0x0006E6A5 File Offset: 0x0006C8A5
		public SemaphoreFullException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreFullException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001D91 RID: 7569 RVA: 0x0006E6AE File Offset: 0x0006C8AE
		public SemaphoreFullException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SemaphoreFullException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта по возникающему исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001D92 RID: 7570 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected SemaphoreFullException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
