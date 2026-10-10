using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который имеет три параметра и возвращает значение типа, указанного параметром <typeparamref name="TResult" />.</summary>
	/// <param name="arg1">Первый параметр метода, инкапсулируемого этим делегатом.</param>
	/// <param name="arg2">Второй параметр метода, инкапсулируемого этим делегатом.</param>
	/// <param name="arg3">Третий параметр метода, инкапсулируемого этим делегатом.</param>
	/// <typeparam name="T1">Тип первого параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T2">Тип второго параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T3">Тип третьего параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="TResult">Тип возвращаемого значения метода, инкапсулируемого данным делегатом.</typeparam>
	/// <returns>Возвращаемое значение метода, инкапсулируемого данным делегатом.</returns>
	// Token: 0x020000E8 RID: 232
	// (Invoke) Token: 0x060006C3 RID: 1731
	public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);
}
