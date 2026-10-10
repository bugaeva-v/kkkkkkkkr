using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает тип контракта, завершившегося ошибкой.</summary>
	// Token: 0x020009D0 RID: 2512
	public enum ContractFailureKind
	{
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.Requires" /> вызвал сбой.</summary>
		// Token: 0x040037AD RID: 14253
		Precondition,
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.Ensures" /> вызвал сбой.</summary>
		// Token: 0x040037AE RID: 14254
		Postcondition,
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.EnsuresOnThrow" /> вызвал сбой.</summary>
		// Token: 0x040037AF RID: 14255
		PostconditionOnException,
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.Invariant" /> вызвал сбой.</summary>
		// Token: 0x040037B0 RID: 14256
		Invariant,
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.Assert" /> вызвал сбой.</summary>
		// Token: 0x040037B1 RID: 14257
		Assert,
		/// <summary>Контракт <see cref="Overload:System.Diagnostics.Contracts.Contract.Assume" /> вызвал сбой.</summary>
		// Token: 0x040037B2 RID: 14258
		Assume
	}
}
