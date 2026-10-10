using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что отдельный тип содержит контракты кода для этого типа.</summary>
	// Token: 0x020009C5 RID: 2501
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Conditional("DEBUG")]
	public sealed class ContractClassAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractClassAttribute" />.</summary>
		/// <param name="typeContainingContracts">Тип, содержащий контракты кода для этого типа.</param>
		// Token: 0x060059FC RID: 23036 RVA: 0x00133D1F File Offset: 0x00131F1F
		public ContractClassAttribute(Type typeContainingContracts)
		{
			this._typeWithContracts = typeContainingContracts;
		}

		/// <summary>Получает тип, содержащий контракты кода для этого типа.</summary>
		/// <returns>Тип, содержащий контракты кода для этого типа.</returns>
		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x060059FD RID: 23037 RVA: 0x00133D2E File Offset: 0x00131F2E
		public Type TypeContainingContracts
		{
			get
			{
				return this._typeWithContracts;
			}
		}

		// Token: 0x040037A3 RID: 14243
		private Type _typeWithContracts;
	}
}
