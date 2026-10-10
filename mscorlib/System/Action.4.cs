using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который имеет три параметра и не возвращает значений.</summary>
	/// <param name="arg1">Первый параметр метода, инкапсулируемого данным делегатом.</param>
	/// <param name="arg2">Второй параметр метода, инкапсулируемого этим делегатом.</param>
	/// <param name="arg3">Третий параметр метода, инкапсулируемого этим делегатом.</param>
	/// <typeparam name="T1">Тип первого параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T2">Тип второго параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T3">Тип третьего параметра метода, инкапсулируемого данным делегатом.</typeparam>
	// Token: 0x020000DF RID: 223
	// (Invoke) Token: 0x0600069F RID: 1695
	public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
}
