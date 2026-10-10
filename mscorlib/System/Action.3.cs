using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который имеет два параметра и не возвращает значения.</summary>
	/// <param name="arg1">Первый параметр метода, инкапсулируемого этим делегатом.</param>
	/// <param name="arg2">Второй параметр метода, инкапсулируемого этим делегатом.</param>
	/// <typeparam name="T1">Тип первого параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T2">Тип второго параметра метода, инкапсулируемого этим делегатом.</typeparam>
	// Token: 0x020000DE RID: 222
	// (Invoke) Token: 0x0600069B RID: 1691
	public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
}
