using System;
using System.Runtime.Serialization;

namespace System.Threading
{
	/// <summary>Исключение, которое выдается, когда объект <see cref="T:System.Threading.Thread" /> является неправильным свойством <see cref="P:System.Threading.Thread.ThreadState" /> для вызова метода.</summary>
	// Token: 0x0200029A RID: 666
	[Serializable]
	public class ThreadStateException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadStateException" /> стандартными свойствами.</summary>
		// Token: 0x06001DA2 RID: 7586 RVA: 0x0006E72A File Offset: 0x0006C92A
		public ThreadStateException() : base("Thread was in an invalid state for the operation being executed.")
		{
			base.HResult = -2146233056;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadStateException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06001DA3 RID: 7587 RVA: 0x0006E742 File Offset: 0x0006C942
		public ThreadStateException(string message) : base(message)
		{
			base.HResult = -2146233056;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadStateException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06001DA4 RID: 7588 RVA: 0x0006E756 File Offset: 0x0006C956
		public ThreadStateException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233056;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Threading.ThreadStateException" /> с сериализованными данными.</summary>
		/// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
		/// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
		// Token: 0x06001DA5 RID: 7589 RVA: 0x00020A65 File Offset: 0x0001EC65
		protected ThreadStateException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
