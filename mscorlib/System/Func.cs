using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который не имеет параметров и возвращает значение типа, указанного в параметре <typeparamref name="TResult" />.</summary>
	/// <typeparam name="TResult">Тип возвращаемого значения метода, инкапсулируемого данным делегатом.</typeparam>
	/// <returns>Возвращаемое значение метода, инкапсулируемого данным делегатом.</returns>
	// Token: 0x020000E5 RID: 229
	// (Invoke) Token: 0x060006B7 RID: 1719
	public delegate TResult Func<out TResult>();
}
