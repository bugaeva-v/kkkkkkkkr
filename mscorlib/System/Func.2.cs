using System;

namespace System
{
	/// <summary>Инкапсулирует метод с одним параметром, который возвращает значение типа, указанного в параметре <typeparamref name="TResult" />.</summary>
	/// <param name="arg">Параметр метода, инкапсулируемого данным делегатом.</param>
	/// <typeparam name="T">Тип параметра метода, инкапсулируемого данным делегатом.</typeparam>
	/// <typeparam name="TResult">Тип возвращаемого значения метода, инкапсулируемого данным делегатом.</typeparam>
	/// <returns>Возвращаемое значение метода, инкапсулируемого данным делегатом.</returns>
	// Token: 0x020000E6 RID: 230
	// (Invoke) Token: 0x060006BB RID: 1723
	public delegate TResult Func<in T, out TResult>(T arg);
}
