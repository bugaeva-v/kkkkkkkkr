using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Определяет аббревиатуры, которые можно использовать вместо полного синтаксиса контракта.</summary>
	// Token: 0x020009CD RID: 2509
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	public sealed class ContractAbbreviatorAttribute : Attribute
	{
	}
}
