using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что сборка является ссылочной сборкой, которая содержит контракты.</summary>
	// Token: 0x020009C8 RID: 2504
	[AttributeUsage(AttributeTargets.Assembly)]
	public sealed class ContractReferenceAssemblyAttribute : Attribute
	{
	}
}
