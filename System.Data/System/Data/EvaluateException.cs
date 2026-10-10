using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Представляет исключение, которое выдается, когда невозможно найти значение свойства <see cref="P:System.Data.DataColumn.Expression" /> класса <see cref="T:System.Data.DataColumn" />.</summary>
	// Token: 0x020000F2 RID: 242
	[Serializable]
	public class EvaluateException : InvalidExpressionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.EvaluateException" /> со свойствами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Источника и назначение конкретного сериализованного потока.</param>
		// Token: 0x06000E5E RID: 3678 RVA: 0x0003CC16 File Offset: 0x0003AE16
		protected EvaluateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.EvaluateException" />.</summary>
		// Token: 0x06000E5F RID: 3679 RVA: 0x0003CC20 File Offset: 0x0003AE20
		public EvaluateException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.EvaluateException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x06000E60 RID: 3680 RVA: 0x0003CC28 File Offset: 0x0003AE28
		public EvaluateException(string s) : base(s)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.EvaluateException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x06000E61 RID: 3681 RVA: 0x0003CC31 File Offset: 0x0003AE31
		public EvaluateException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
