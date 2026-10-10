using System;

namespace System.Transactions
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Transactions.TransactionManager.DistributedTransactionStarted" /> класса <see cref="T:System.Transactions.TransactionManager" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">
	///   <see cref="T:System.Transactions.TransactionEventArgs" />, содержащий транзакцию, из которого могут быть извлечены сведения о транзакции.</param>
	// Token: 0x0200000D RID: 13
	// (Invoke) Token: 0x06000021 RID: 33
	public delegate void TransactionStartedEventHandler(object sender, TransactionEventArgs e);
}
