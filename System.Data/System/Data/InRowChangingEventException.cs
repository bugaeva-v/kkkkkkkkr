using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается при вызове метода <see cref="M:System.Data.DataRow.EndEdit" /> в событии <see cref="E:System.Data.DataTable.RowChanging" />.</summary>
	// Token: 0x0200008C RID: 140
	[Serializable]
	public class InRowChangingEventException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InRowChangingEventException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006E4 RID: 1764 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected InRowChangingEventException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InRowChangingEventException" />.</summary>
		// Token: 0x060006E5 RID: 1765 RVA: 0x0001A68C File Offset: 0x0001888C
		public InRowChangingEventException() : base("Operation not supported in the RowChanging event.")
		{
			base.HResult = -2146232029;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InRowChangingEventException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006E6 RID: 1766 RVA: 0x0001A6A4 File Offset: 0x000188A4
		public InRowChangingEventException(string s) : base(s)
		{
			base.HResult = -2146232029;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InRowChangingEventException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006E7 RID: 1767 RVA: 0x0001A6B8 File Offset: 0x000188B8
		public InRowChangingEventException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232029;
		}
	}
}
