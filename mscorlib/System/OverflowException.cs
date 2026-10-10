using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается, если выполнение арифметической операции, операции приведения к типу или преобразования в проверяемом контексте приводит к переполнению.</summary>
	// Token: 0x0200016B RID: 363
	[Serializable]
	public class OverflowException : ArithmeticException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OverflowException" />.</summary>
		// Token: 0x06000E6E RID: 3694 RVA: 0x0003AE0D File Offset: 0x0003900D
		public OverflowException() : base("Arithmetic operation resulted in an overflow.")
		{
			base.HResult = -2146233066;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OverflowException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000E6F RID: 3695 RVA: 0x0003AE25 File Offset: 0x00039025
		public OverflowException(string message) : base(message)
		{
			base.HResult = -2146233066;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OverflowException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000E70 RID: 3696 RVA: 0x0003AE39 File Offset: 0x00039039
		public OverflowException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233066;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.OverflowException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000E71 RID: 3697 RVA: 0x00028203 File Offset: 0x00026403
		protected OverflowException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
