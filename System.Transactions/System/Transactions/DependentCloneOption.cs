using System;

namespace System.Transactions
{
	/// <summary>Определяет тип зависимой транзакции, которую требуется создать.</summary>
	// Token: 0x0200000E RID: 14
	public enum DependentCloneOption
	{
		/// <summary>Зависимая транзакция блокирует процесс фиксации транзакции, пока не истечет тайм-аут родительской транзакции, или не будет вызван метод <see cref="M:System.Transactions.DependentTransaction.Complete" />. В этом случае могут быть выполнены дополнительные операции по транзакции и созданы новые зачисления.</summary>
		// Token: 0x04000030 RID: 48
		BlockCommitUntilComplete,
		/// <summary>Зависимая транзакция автоматически прерывает транзакцию, если для родительской транзакции до вызова метода <see cref="M:System.Transactions.DependentTransaction.Complete" /> вызывается метод Commit.</summary>
		// Token: 0x04000031 RID: 49
		RollbackIfNotComplete
	}
}
