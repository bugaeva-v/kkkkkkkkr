using System;

namespace System.Transactions
{
	/// <summary>Описывает текущее состояние распределенной транзакции.</summary>
	// Token: 0x0200002C RID: 44
	public enum TransactionStatus
	{
		/// <summary>Состояние транзакции неизвестно, поскольку еще должно быть опрошено несколько участников.</summary>
		// Token: 0x0400007B RID: 123
		Active,
		/// <summary>Транзакция зафиксирована.</summary>
		// Token: 0x0400007C RID: 124
		Committed,
		/// <summary>Выполнен откат транзакции.</summary>
		// Token: 0x0400007D RID: 125
		Aborted,
		/// <summary>Состояние транзакции неизвестно.</summary>
		// Token: 0x0400007E RID: 126
		InDoubt
	}
}
