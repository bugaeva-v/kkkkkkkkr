using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, которое выдается при недостаточности стека выполнения для выполнения большинства методов.</summary>
	// Token: 0x02000147 RID: 327
	[Serializable]
	public sealed class InsufficientExecutionStackException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientExecutionStackException" />.</summary>
		// Token: 0x06000C1A RID: 3098 RVA: 0x00031F4E File Offset: 0x0003014E
		public InsufficientExecutionStackException() : base("Insufficient stack to continue executing the program safely. This can happen from having too many functions on the call stack or function on the stack using too much stack space.")
		{
			base.HResult = -2146232968;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientExecutionStackException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		// Token: 0x06000C1B RID: 3099 RVA: 0x00031F66 File Offset: 0x00030166
		public InsufficientExecutionStackException(string message) : base(message)
		{
			base.HResult = -2146232968;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.InsufficientExecutionStackException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если значение параметра inner не равно <see langword="null" />, текущее исключение возникает в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000C1C RID: 3100 RVA: 0x00031F7A File Offset: 0x0003017A
		public InsufficientExecutionStackException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146232968;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal InsufficientExecutionStackException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
