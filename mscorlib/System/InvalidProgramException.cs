using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выбрасывается, если программа содержит недопустимые инструкции MSIL или метаданные. Это обычно указывает на ошибку в компиляторе, создавшем программу.</summary>
	// Token: 0x0200014D RID: 333
	[Serializable]
	public sealed class InvalidProgramException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidProgramException" /> стандартными свойствами.</summary>
		// Token: 0x06000C92 RID: 3218 RVA: 0x00032861 File Offset: 0x00030A61
		public InvalidProgramException() : base("Common Language Runtime detected an invalid program.")
		{
			base.HResult = -2146233030;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidProgramException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000C93 RID: 3219 RVA: 0x00032879 File Offset: 0x00030A79
		public InvalidProgramException(string message) : base(message)
		{
			base.HResult = -2146233030;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InvalidProgramException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="inner" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000C94 RID: 3220 RVA: 0x0003288D File Offset: 0x00030A8D
		public InvalidProgramException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146233030;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal InvalidProgramException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
