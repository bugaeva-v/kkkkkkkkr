using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается при попытке изменить значение столбца, доступное только для чтения.</summary>
	// Token: 0x02000090 RID: 144
	[Serializable]
	public class ReadOnlyException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ReadOnlyException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006F4 RID: 1780 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected ReadOnlyException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ReadOnlyException" />.</summary>
		// Token: 0x060006F5 RID: 1781 RVA: 0x0001A790 File Offset: 0x00018990
		public ReadOnlyException() : base("Column is marked read only.")
		{
			base.HResult = -2146232025;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ReadOnlyException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006F6 RID: 1782 RVA: 0x0001A7A8 File Offset: 0x000189A8
		public ReadOnlyException(string s) : base(s)
		{
			base.HResult = -2146232025;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.ReadOnlyException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006F7 RID: 1783 RVA: 0x0001A7BC File Offset: 0x000189BC
		public ReadOnlyException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232025;
		}
	}
}
