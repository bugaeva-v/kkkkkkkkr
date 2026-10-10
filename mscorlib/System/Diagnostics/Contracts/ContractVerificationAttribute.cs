using System;

namespace System.Diagnostics.Contracts
{
	/// <summary>Указывает, что средствам анализа следует принимать правильность сборки, типа или члена без выполнения статической проверки.</summary>
	// Token: 0x020009CA RID: 2506
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	[Conditional("CONTRACTS_FULL")]
	public sealed class ContractVerificationAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.Contracts.ContractVerificationAttribute" />.</summary>
		/// <param name="value">Значение <see langword="true" /> для запроса проверки; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x06005A03 RID: 23043 RVA: 0x00133D4D File Offset: 0x00131F4D
		public ContractVerificationAttribute(bool value)
		{
			this._value = value;
		}

		/// <summary>Получает значение, определяющее, следует ли проверять контракт целевого объекта.</summary>
		/// <returns>Значение <see langword="true" />, если проверка необходима; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06005A04 RID: 23044 RVA: 0x00133D5C File Offset: 0x00131F5C
		public bool Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x040037A5 RID: 14245
		private bool _value;
	}
}
