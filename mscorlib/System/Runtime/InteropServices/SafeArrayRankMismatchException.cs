using System;
using System.Runtime.Serialization;

namespace System.Runtime.InteropServices
{
	/// <summary>Это исключение возникает, если ранг входного массива <see langword="SAFEARRAY" /> не совпадает с рангом, указанным в управляемой подписи.</summary>
	// Token: 0x020006DD RID: 1757
	[Serializable]
	public class SafeArrayRankMismatchException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayTypeMismatchException" /> со значениями по умолчанию.</summary>
		// Token: 0x06004046 RID: 16454 RVA: 0x000E0D96 File Offset: 0x000DEF96
		public SafeArrayRankMismatchException() : base("Specified array was not of the expected rank.")
		{
			base.HResult = -2146233032;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayRankMismatchException" /> указанным сообщением.</summary>
		/// <param name="message">Сообщение, указывающее причину возникновения исключения.</param>
		// Token: 0x06004047 RID: 16455 RVA: 0x000E0DAE File Offset: 0x000DEFAE
		public SafeArrayRankMismatchException(string message) : base(message)
		{
			base.HResult = -2146233032;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.InteropServices.SafeArrayRankMismatchException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004048 RID: 16456 RVA: 0x000E0DC2 File Offset: 0x000DEFC2
		public SafeArrayRankMismatchException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233032;
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="SafeArrayTypeMismatchException" />, используя данные сериализации.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="info" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004049 RID: 16457 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected SafeArrayRankMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
