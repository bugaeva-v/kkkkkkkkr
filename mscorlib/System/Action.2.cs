using System;

namespace System
{
	/// <summary>Инкапсулирует метод, который принимает один параметр и не возвращает значения.</summary>
	/// <param name="obj">Параметр метода, инкапсулируемого данным делегатом.</param>
	/// <typeparam name="T">Тип параметра метода, инкапсулируемого данным делегатом.</typeparam>
	// Token: 0x020000DD RID: 221
	// (Invoke) Token: 0x06000697 RID: 1687
	public delegate void Action<in T>(T obj);
}
