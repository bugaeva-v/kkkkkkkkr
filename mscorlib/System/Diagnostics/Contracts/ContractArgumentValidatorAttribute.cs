using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Включает факторизацию устаревшего кода <see langword="if-then-throw" /> в отдельные методы для многократного использования, и обеспечивает полный контроль над выброшенными исключениями и аргументами.</summary>
	// Token: 0x020009CC RID: 2508
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractArgumentValidatorAttribute : Attribute
	{
	}
}
