using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет собой исключение, выдаваемое при попытке доступа к строке таблицы, не имеющей первичного ключа.</summary>
	// Token: 0x0200008E RID: 142
	[Serializable]
	public class MissingPrimaryKeyException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.MissingPrimaryKeyException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006EC RID: 1772 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected MissingPrimaryKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.MissingPrimaryKeyException" />.</summary>
		// Token: 0x060006ED RID: 1773 RVA: 0x0001A70E File Offset: 0x0001890E
		public MissingPrimaryKeyException() : base("Missing primary key.")
		{
			base.HResult = -2146232027;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.MissingPrimaryKeyException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006EE RID: 1774 RVA: 0x0001A726 File Offset: 0x00018926
		public MissingPrimaryKeyException(string s) : base(s)
		{
			base.HResult = -2146232027;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.MissingPrimaryKeyException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006EF RID: 1775 RVA: 0x0001A73A File Offset: 0x0001893A
		public MissingPrimaryKeyException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232027;
		}
	}
}
