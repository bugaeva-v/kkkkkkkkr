using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение, которое создается в то время, когда методу требуется вызвавший его объект для получения блокировки данного монитора, а метод вызван объектом, не являющимся владельцем блокировки.</summary>
	// Token: 0x02000295 RID: 661
	[Serializable]
	public class SynchronizationLockException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SynchronizationLockException" /> стандартными свойствами.</summary>
		// Token: 0x06001D97 RID: 7575 RVA: 0x0006E6B8 File Offset: 0x0006C8B8
		public SynchronizationLockException() : base("Object synchronization method was called from an unsynchronized block of code.")
		{
			base.HResult = -2146233064;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SynchronizationLockException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06001D98 RID: 7576 RVA: 0x0006E6D0 File Offset: 0x0006C8D0
		public SynchronizationLockException(string message) : base(message)
		{
			base.HResult = -2146233064;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SynchronizationLockException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001D99 RID: 7577 RVA: 0x0006E6E4 File Offset: 0x0006C8E4
		public SynchronizationLockException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233064;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.SynchronizationLockException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001D9A RID: 7578 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected SynchronizationLockException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
