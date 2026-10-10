using System;

namespace System.EnterpriseServices.CompensatingResourceManager
{
	/// <summary>Задает состояние текущей транзакции CRM.</summary>
	// Token: 0x02000078 RID: 120
	[Serializable]
	public enum TransactionState
	{
		/// <summary>Транзакция выполняется.</summary>
		// Token: 0x040000CD RID: 205
		Active,
		/// <summary>Транзакция фиксируется.</summary>
		// Token: 0x040000CE RID: 206
		Committed,
		/// <summary>Транзакция отменяется.</summary>
		// Token: 0x040000CF RID: 207
		Aborted,
		/// <summary>Транзакция сомнительна.</summary>
		// Token: 0x040000D0 RID: 208
		Indoubt
	}
}
