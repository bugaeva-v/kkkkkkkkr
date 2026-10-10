using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, возникающее при неправильной попытке создания отношения или доступа к нему.</summary>
	// Token: 0x0200008D RID: 141
	[Serializable]
	public class InvalidConstraintException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidConstraintException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006E8 RID: 1768 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected InvalidConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidConstraintException" />.</summary>
		// Token: 0x060006E9 RID: 1769 RVA: 0x0001A6CD File Offset: 0x000188CD
		public InvalidConstraintException() : base("Invalid constraint.")
		{
			base.HResult = -2146232028;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidConstraintException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006EA RID: 1770 RVA: 0x0001A6E5 File Offset: 0x000188E5
		public InvalidConstraintException(string s) : base(s)
		{
			base.HResult = -2146232028;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidConstraintException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006EB RID: 1771 RVA: 0x0001A6F9 File Offset: 0x000188F9
		public InvalidConstraintException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232028;
		}
	}
}
