using System;

namespace System.Runtime.CompilerServices
{
	/// <summary>Указывает, помечен ли метод модификатором Async или async.</summary>
	// Token: 0x020007DC RID: 2012
	[AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
	[Serializable]
	public sealed class AsyncStateMachineAttribute : StateMachineAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Runtime.CompilerServices.AsyncStateMachineAttribute" />.</summary>
		/// <param name="stateMachineType">Объект типа для типа базового конечного автомата, который используется для реализации метода конечного автомата.</param>
		// Token: 0x060045C3 RID: 17859 RVA: 0x000E51CE File Offset: 0x000E33CE
		public AsyncStateMachineAttribute(Type stateMachineType) : base(stateMachineType)
		{
		}
	}
}
