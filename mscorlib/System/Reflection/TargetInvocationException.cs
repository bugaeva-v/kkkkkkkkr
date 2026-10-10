using System;
using System.Runtime.Serialization;

namespace System.Reflection
{
	/// <summary>Исключение выдается методами, вызываемыми средствами отражения. Этот класс не наследуется.</summary>
	// Token: 0x020008CB RID: 2251
	[Serializable]
	public sealed class TargetInvocationException : ApplicationException
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetInvocationException" /> со ссылкой на внутреннее исключение, которое является причиной данного исключения.</summary>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004AE9 RID: 19177 RVA: 0x000EFDA0 File Offset: 0x000EDFA0
		public TargetInvocationException(Exception inner) : base("Exception has been thrown by the target of an invocation.", inner)
		{
			base.HResult = -2146232828;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Reflection.TargetInvocationException" /> указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.</summary>
		/// <param name="message">Сообщение об ошибке, указывающее причину создания исключения.</param>
		/// <param name="inner">Исключение, которое является причиной текущего исключения. Если значение параметра <paramref name="inner" /> не равно <see langword="null" />, текущее исключение сгенерировано в блоке <see langword="catch" />, обрабатывающем внутреннее исключение.</param>
		// Token: 0x06004AEA RID: 19178 RVA: 0x000EFDB9 File Offset: 0x000EDFB9
		public TargetInvocationException(string message, Exception inner) : base(message, inner)
		{
			base.HResult = -2146232828;
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x0006E7BD File Offset: 0x0006C9BD
		internal TargetInvocationException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
