using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет собой исключение, возникающее при попытке добавления столбца <see cref="T:System.Data.DataColumn" />, содержащего недопустимое выражение <see cref="P:System.Data.DataColumn.Expression" />, к коллекции <see cref="T:System.Data.DataColumnCollection" />.</summary>
	// Token: 0x020000F1 RID: 241
	[Serializable]
	public class InvalidExpressionException : DataException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidExpressionException" /> со свойствами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Источник и назначение данного сериализованного потока.</param>
		// Token: 0x06000E5A RID: 3674 RVA: 0x0001A5BF File Offset: 0x000187BF
		protected InvalidExpressionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidExpressionException" />.</summary>
		// Token: 0x06000E5B RID: 3675 RVA: 0x0003CBFB File Offset: 0x0003ADFB
		public InvalidExpressionException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidExpressionException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x06000E5C RID: 3676 RVA: 0x0003CC03 File Offset: 0x0003AE03
		public InvalidExpressionException(string s) : base(s)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.InvalidExpressionException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x06000E5D RID: 3677 RVA: 0x0003CC0C File Offset: 0x0003AE0C
		public InvalidExpressionException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
