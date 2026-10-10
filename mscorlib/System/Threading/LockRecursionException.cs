using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение, которое создается, когда рекурсивная запись блокировки не совместима с рекурсивной политикой блокировки.</summary>
	// Token: 0x02000290 RID: 656
	[Serializable]
	public class LockRecursionException : Exception
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.LockRecursionException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x06001D86 RID: 7558 RVA: 0x00004B05 File Offset: 0x00002D05
		public LockRecursionException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.LockRecursionException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Вызывающий объект этого конструктора должен убедиться, что эта строка локализована для текущего языка и региональных параметров системы.</param>
		// Token: 0x06001D87 RID: 7559 RVA: 0x000328A2 File Offset: 0x00030AA2
		public LockRecursionException(string message) : base(message)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.LockRecursionException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Вызывающий объект этого конструктора должен убедиться, что эта строка локализована для текущего языка и региональных параметров системы.</param>
		/// <param name="innerException">Исключение, которое вызвало текущее исключение. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001D88 RID: 7560 RVA: 0x000328AB File Offset: 0x00030AAB
		public LockRecursionException(string message, Exception innerException) : base(message, innerException)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.LockRecursionException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001D89 RID: 7561 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		protected LockRecursionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
