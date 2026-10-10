using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Помечает метод как инвариантный метод для класса.</summary>
	// Token: 0x020009C7 RID: 2503
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
	public sealed class ContractInvariantMethodAttribute : Attribute
	{
	}
}
