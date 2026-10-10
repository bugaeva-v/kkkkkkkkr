using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое создается при попытке вставить значение NULL в столбец, где <see cref="P:System.Data.DataColumn.AllowDBNull" /> имеет значение <see langword="false" />.</summary>
	// Token: 0x0200008F RID: 143
	[Serializable]
	public class NoNullAllowedException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.NoNullAllowedException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006F0 RID: 1776 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected NoNullAllowedException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.NoNullAllowedException" />.</summary>
		// Token: 0x060006F1 RID: 1777 RVA: 0x0001A74F File Offset: 0x0001894F
		public NoNullAllowedException() : base("Null not allowed.")
		{
			base.HResult = -2146232026;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.NoNullAllowedException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006F2 RID: 1778 RVA: 0x0001A767 File Offset: 0x00018967
		public NoNullAllowedException(string s) : base(s)
		{
			base.HResult = -2146232026;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.NoNullAllowedException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006F3 RID: 1779 RVA: 0x0001A77B File Offset: 0x0001897B
		public NoNullAllowedException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232026;
		}
	}
}
