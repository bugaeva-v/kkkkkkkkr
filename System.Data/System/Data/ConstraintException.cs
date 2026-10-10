using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, возникающее при попытке выполнения действия, нарушающего ограничение.</summary>
	// Token: 0x02000089 RID: 137
	[Serializable]
	public class ConstraintException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ConstraintException" /> с использованием указанного контекста потока и сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006D8 RID: 1752 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected ConstraintException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ConstraintException" />. Это конструктор по умолчанию.</summary>
		// Token: 0x060006D9 RID: 1753 RVA: 0x0001A5C9 File Offset: 0x000187C9
		public ConstraintException() : base("Constraint Exception.")
		{
			base.HResult = -2146232022;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ConstraintException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006DA RID: 1754 RVA: 0x0001A5E1 File Offset: 0x000187E1
		public ConstraintException(string s) : base(s)
		{
			base.HResult = -2146232022;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ConstraintException" /> с использованием заданной строки и внутреннего исключения.</summary>
		/// <param name="message">Строка, отображаемая при возникновении исключения.</param>
		/// <param name="innerException">Возвращает экземпляр класса <see langword="Exception" />, который вызвал текущее исключение.</param>
		// Token: 0x060006DB RID: 1755 RVA: 0x0001A5F5 File Offset: 0x000187F5
		public ConstraintException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232022;
		}
	}
}
