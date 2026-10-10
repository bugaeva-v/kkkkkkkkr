using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается при попытке выполнить действие с удаленным объектом <see cref="T:System.Data.DataRow" />.</summary>
	// Token: 0x0200008A RID: 138
	[Serializable]
	public class DeletedRowInaccessibleException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DeletedRowInaccessibleException" /> со сведениями о сериализации.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Описание источника и назначения заданного сериализованного потока.</param>
		// Token: 0x060006DC RID: 1756 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected DeletedRowInaccessibleException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DeletedRowInaccessibleException" />.</summary>
		// Token: 0x060006DD RID: 1757 RVA: 0x0001A60A File Offset: 0x0001880A
		public DeletedRowInaccessibleException() : base("Deleted rows inaccessible.")
		{
			base.HResult = -2146232031;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DeletedRowInaccessibleException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x060006DE RID: 1758 RVA: 0x0001A622 File Offset: 0x00018822
		public DeletedRowInaccessibleException(string s) : base(s)
		{
			base.HResult = -2146232031;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DeletedRowInaccessibleException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x060006DF RID: 1759 RVA: 0x0001A636 File Offset: 0x00018836
		public DeletedRowInaccessibleException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232031;
		}
	}
}
