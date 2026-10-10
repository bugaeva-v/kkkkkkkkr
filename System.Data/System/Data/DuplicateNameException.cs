using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается, если при добавлении строк в объект, относящийся к <see cref="T:System.Data.DataSet" />, нарушается уникальность имен объектов базы данных.</summary>
	// Token: 0x0200008B RID: 139
	[Serializable]
	public class DuplicateNameException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DuplicateNameException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006E0 RID: 1760 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected DuplicateNameException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DuplicateNameException" />.</summary>
		// Token: 0x060006E1 RID: 1761 RVA: 0x0001A64B File Offset: 0x0001884B
		public DuplicateNameException() : base("Duplicate name not allowed.")
		{
			base.HResult = -2146232030;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DuplicateNameException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006E2 RID: 1762 RVA: 0x0001A663 File Offset: 0x00018863
		public DuplicateNameException(string s) : base(s)
		{
			base.HResult = -2146232030;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DuplicateNameException" /> с заданной строкой и внутренним исключением.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006E3 RID: 1763 RVA: 0x0001A677 File Offset: 0x00018877
		public DuplicateNameException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232030;
		}
	}
}
