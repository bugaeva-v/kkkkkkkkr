using System;

namespace System.Transactions
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Transactions.Transaction.TransactionCompleted" /> класса <see cref="T:System.Transactions.Transaction" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Transactions.TransactionEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200000C RID: 12
	// (Invoke) Token: 0x0600001D RID: 29
	public delegate void TransactionCompletedEventHandler(object sender, TransactionEventArgs e);
}
