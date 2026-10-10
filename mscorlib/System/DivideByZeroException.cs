using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое возникает при попытке деления целого значения или значения <see cref="T:System.Decimal" /> на ноль.</summary>
	// Token: 0x02000110 RID: 272
	[Serializable]
	public class DivideByZeroException : ArithmeticException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DivideByZeroException" />.</summary>
		// Token: 0x06000A8B RID: 2699 RVA: 0x000281C2 File Offset: 0x000263C2
		public DivideByZeroException() : base("Attempted to divide by zero.")
		{
			base.HResult = -2147352558;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DivideByZeroException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Строка <see cref="T:System.String" />, описывающая ошибку.</param>
		// Token: 0x06000A8C RID: 2700 RVA: 0x000281DA File Offset: 0x000263DA
		public DivideByZeroException(string message) : base(message)
		{
			base.HResult = -2147352558;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DivideByZeroException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000A8D RID: 2701 RVA: 0x000281EE File Offset: 0x000263EE
		public DivideByZeroException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2147352558;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.DivideByZeroException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000A8E RID: 2702 RVA: 0x00028203 File Offset: 0x00026403
		protected DivideByZeroException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
