using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Исключение создается, если тип входящего <see langword="SAFEARRAY" /> не совпадает с типом, указанным в управляемой подписи.</summary>
	// Token: 0x020006DE RID: 1758
	[Serializable]
	public class SafeArrayTypeMismatchException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayTypeMismatchException" /> со значениями по умолчанию.</summary>
		// Token: 0x0600404A RID: 16458 RVA: 0x000E0DD7 File Offset: 0x000DEFD7
		public SafeArrayTypeMismatchException() : base("Specified array was not of the expected type.")
		{
			base.HResult = -2146233037;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayTypeMismatchException" /> указанным сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x0600404B RID: 16459 RVA: 0x000E0DEF File Offset: 0x000DEFEF
		public SafeArrayTypeMismatchException(string message) : base(message)
		{
			base.HResult = -2146233037;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SafeArrayTypeMismatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x0600404C RID: 16460 RVA: 0x000E0E03 File Offset: 0x000DF003
		public SafeArrayTypeMismatchException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233037;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayTypeMismatchException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600404D RID: 16461 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected SafeArrayTypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
