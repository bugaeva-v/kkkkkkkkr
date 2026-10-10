using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что тип или метод является чистым, то есть не вносит изменения в состояние видимости.</summary>
	// Token: 0x020009C4 RID: 2500
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.Delegate, AllowMultiple = false, Inherited = true)]
	public sealed class PureAttribute : Attribute
	{
	}
}
