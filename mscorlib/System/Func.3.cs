using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который имеет два параметра и возвращает значение типа, указанного параметром <typeparamref name="TResult" />.</summary>
	/// <param name="arg1">Первый параметр метода, инкапсулируемого этим делегатом.</param>
	/// <param name="arg2">Второй параметр метода, инкапсулируемого этим делегатом.</param>
	/// <typeparam name="T1">Тип первого параметра метода, инкапсулируемого этим делегатом.</typeparam>
	/// <typeparam name="T2">Тип второго параметра метода, инкапсулируемого данным делегатом.</typeparam>
	/// <typeparam name="TResult">Тип возвращаемого значения метода, инкапсулируемого данным делегатом.</typeparam>
	/// <returns>Возвращаемое значение метода, инкапсулируемого данным делегатом.</returns>
	// Token: 0x020000E7 RID: 231
	// (Invoke) Token: 0x060006BF RID: 1727
	public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2);
}
