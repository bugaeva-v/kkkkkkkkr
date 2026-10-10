using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при вызове метода, недопустимого для текущего состояния объекта.</summary>
	// Token: 0x0200014C RID: 332
	[Serializable]
	public class InvalidOperationException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidOperationException" />.</summary>
		// Token: 0x06000C8E RID: 3214 RVA: 0x00032820 File Offset: 0x00030A20
		public InvalidOperationException() : base("Operation is not valid due to the current state of the object.")
		{
			base.HResult = -2146233079;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidOperationException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000C8F RID: 3215 RVA: 0x00032838 File Offset: 0x00030A38
		public InvalidOperationException(string message) : base(message)
		{
			base.HResult = -2146233079;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidOperationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000C90 RID: 3216 RVA: 0x0003284C File Offset: 0x00030A4C
		public InvalidOperationException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233079;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidOperationException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект, содержащий сериализованные данные объекта.</param>
		/// <param name="context">Контекстные сведения об источнике или назначении.</param>
		// Token: 0x06000C91 RID: 3217 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected InvalidOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
