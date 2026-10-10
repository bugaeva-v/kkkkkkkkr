using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается при попытке выполнить действие с объектом <see cref="T:System.Data.DataRow" />, который не содержится в объекте <see cref="T:System.Data.DataTable" />.</summary>
	// Token: 0x02000091 RID: 145
	[Serializable]
	public class RowNotInTableException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.RowNotInTableException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006F8 RID: 1784 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected RowNotInTableException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.RowNotInTableException" />.</summary>
		// Token: 0x060006F9 RID: 1785 RVA: 0x0001A7D1 File Offset: 0x000189D1
		public RowNotInTableException() : base("Row not found in table.")
		{
			base.HResult = -2146232024;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.RowNotInTableException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006FA RID: 1786 RVA: 0x0001A7E9 File Offset: 0x000189E9
		public RowNotInTableException(string s) : base(s)
		{
			base.HResult = -2146232024;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.RowNotInTableException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006FB RID: 1787 RVA: 0x0001A7FD File Offset: 0x000189FD
		public RowNotInTableException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232024;
		}
	}
}
