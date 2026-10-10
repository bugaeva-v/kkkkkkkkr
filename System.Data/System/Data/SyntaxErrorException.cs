using System;
using System.Runtime.Serialization;

namespace System.Data
{
	/// <summary>Предоставляет исключение, возникающее, когда свойство <see cref="P:System.Data.DataColumn.Expression" /> объекта <see cref="T:System.Data.DataColumn" /> содержит синтаксическую ошибку.</summary>
	// Token: 0x020000F3 RID: 243
	[Serializable]
	public class SyntaxErrorException : InvalidExpressionException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SyntaxErrorException" /> со свойствами <see cref="T:System.Runtime.Serialization.SerializationInfo" /> и <see cref="T:System.Runtime.Serialization.StreamingContext" />.</summary>
		/// <param name="info">Данные, необходимые для сериализации или десериализации объекта.</param>
		/// <param name="context">Источник и назначение определенного сериализованного потока.</param>
		// Token: 0x06000E62 RID: 3682 RVA: 0x0003CC16 File Offset: 0x0003AE16
		protected SyntaxErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SyntaxErrorException" />.</summary>
		// Token: 0x06000E63 RID: 3683 RVA: 0x0003CC20 File Offset: 0x0003AE20
		public SyntaxErrorException()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SyntaxErrorException" /> с заданной строкой.</summary>
		/// <param name="s">Строка, отображаемая при возникновении исключения.</param>
		// Token: 0x06000E64 RID: 3684 RVA: 0x0003CC28 File Offset: 0x0003AE28
		public SyntaxErrorException(string s) : base(s)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SyntaxErrorException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка (<see langword="Nothing" /> в Visual Basic), если внутреннее исключение не задано.</param>
		// Token: 0x06000E65 RID: 3685 RVA: 0x0003CC31 File Offset: 0x0003AE31
		public SyntaxErrorException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}
}
