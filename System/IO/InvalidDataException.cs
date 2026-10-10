using System;
using System.Runtime.Serialization;

namespace System.IO
{
	/// <summary>Исключение, которое выдается, если поток данных имеет недопустимый формат.</summary>
	// Token: 0x02000519 RID: 1305
	[Serializable]
	public sealed class InvalidDataException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.InvalidDataException" />.</summary>
		// Token: 0x06002A50 RID: 10832 RVA: 0x000918E2 File Offset: 0x0008FAE2
		public InvalidDataException() : base(Locale.GetText("Invalid data format."))
		{
			base.HResult = -2146233085;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.InvalidDataException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06002A51 RID: 10833 RVA: 0x000918FF File Offset: 0x0008FAFF
		public InvalidDataException(string message) : base(message)
		{
			base.HResult = -2146233085;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.IO.InvalidDataException" /> со ссылкой на внутреннее исключение, которое является причиной данного исключения.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06002A52 RID: 10834 RVA: 0x00091913 File Offset: 0x0008FB13
		public InvalidDataException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233085;
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0005573F File Offset: 0x0005393F
		private InvalidDataException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0400167A RID: 5754
		private const int Result = -2146233085;
	}
}
