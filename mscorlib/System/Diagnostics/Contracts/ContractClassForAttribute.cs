using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что класс является контрактом для типа.</summary>
	// Token: 0x020009C6 RID: 2502
	[Conditional("CONTRACTS_FULL")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
	public sealed class ContractClassForAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractClassForAttribute" /> с заданием типа, для которого текущий класс является контрактом.</summary>
		/// <param name="typeContractsAreFor">Тип, для которого текущий класс является контрактом.</param>
		// Token: 0x060059FE RID: 23038 RVA: 0x00133D36 File Offset: 0x00131F36
		public ContractClassForAttribute(Type typeContractsAreFor)
		{
			this._typeIAmAContractFor = typeContractsAreFor;
		}

		/// <summary>Получает тип, к которому применяется этот контракт кода.</summary>
		/// <returns>Тип, к которому применяется этот контракт.</returns>
		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x060059FF RID: 23039 RVA: 0x00133D45 File Offset: 0x00131F45
		public Type TypeContractsAreFor
		{
			get
			{
				return this._typeIAmAContractFor;
			}
		}

		// Token: 0x040037A4 RID: 14244
		private Type _typeIAmAContractFor;
	}
}
