using System;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>Исключение, выбрасываемое при внутренней ошибке в ядре выполнения среды CLR. Этот класс не наследуется.</summary>
	// Token: 0x02000118 RID: 280
	[Obsolete("This type previously indicated an unspecified fatal error in the runtime. The runtime no longer raises this exception so this type is obsolete.")]
	[Serializable]
	public sealed class ExecutionEngineException : SystemException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ExecutionEngineException" />.</summary>
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00028819 File Offset: 0x00026A19
		public ExecutionEngineException() : base("Internal error in the runtime.")
		{
			base.HResult = -2146233082;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ExecutionEngineException" /> с указанным сообщением об ошибке.</summary>
		/// <param name="message">Сообщение, описывающее ошибку.</param>
		// Token: 0x06000ADA RID: 2778 RVA: 0x00028831 File Offset: 0x00026A31
		public ExecutionEngineException(string message) : base(message)
		{
			base.HResult = -2146233082;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ExecutionEngineException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="innerException">Исключение, которое является причиной текущего исключения. Если параметр <paramref name="innerException" /> не является указателем null (<see langword="Nothing" /> в Visual Basic), то текущее исключение создается в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06000ADB RID: 2779 RVA: 0x00028845 File Offset: 0x00026A45
		public ExecutionEngineException(string message, Exception innerException) : base(message, innerException)
		{
			base.HResult = -2146233082;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00020A65 File Offset: 0x0001EC65
		internal ExecutionEngineException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
