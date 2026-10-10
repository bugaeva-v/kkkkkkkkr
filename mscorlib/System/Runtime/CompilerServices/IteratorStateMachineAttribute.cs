using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, помечен ли метод в Visual Basic модификатором <see langword="Iterator" />.</summary>
	// Token: 0x020007FF RID: 2047
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class IteratorStateMachineAttribute : StateMachineAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.IteratorStateMachineAttribute" />.</summary>
		/// <param name="stateMachineType">Объект типа для типа базового конечного автомата, который используется для реализации метода конечного автомата.</param>
		// Token: 0x06004610 RID: 17936 RVA: 0x000E51CE File Offset: 0x000E33CE
		public IteratorStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
