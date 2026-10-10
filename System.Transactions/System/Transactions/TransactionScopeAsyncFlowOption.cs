using System;

namespace System.Transactions
{
	/// <summary>Указывает, включен ли для <see cref="T:System.Transactions.TransactionScope" /> поток транзакций через продолжения потоков.</summary>
	// Token: 0x0200002A RID: 42
	public enum TransactionScopeAsyncFlowOption
	{
		/// <summary>Задает, что поток транзакций через продолжения потоков отключен.</summary>
		// Token: 0x04000074 RID: 116
		Suppress,
		/// <summary>Задает, что поток транзакций через продолжения потоков включен.</summary>
		// Token: 0x04000075 RID: 117
		Enabled
	}
}
