using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, возникающее при сбое проверки наличия необходимого объема памяти. Этот класс не наследуется.</summary>
	// Token: 0x020001CD RID: 461
	[Serializable]
	public sealed class InsufficientMemoryException : OutOfMemoryException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientMemoryException" /> с системным сообщением, содержащим описание ошибки.</summary>
		// Token: 0x060013C5 RID: 5061 RVA: 0x0004E9E3 File Offset: 0x0004CBE3
		public InsufficientMemoryException() : base("Insufficient memory to continue the execution of the program.")
		{
			base.HResult = -2146233027;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientMemoryException" /> с использованием заданного сообщения, содержащего описание ошибки.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		// Token: 0x060013C6 RID: 5062 RVA: 0x0004E9FB File Offset: 0x0004CBFB
		public InsufficientMemoryException(string message) : base(message)
		{
			base.HResult = -2146233027;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientMemoryException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение с описанием исключения. Код, вызывающий этот конструктор, должен обеспечить локализацию данной строки в соответствии с текущим языком и региональными параметрами системы.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="innerException" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x060013C7 RID: 5063 RVA: 0x0004EA0F File Offset: 0x0004CC0F
		public InsufficientMemoryException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233027;
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0004EA24 File Offset: 0x0004CC24
		private InsufficientMemoryException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
