using System;

namespace System.Transactions
{
	/// <summary>Предоставляет данные для следующих событий, связанных с транзакцией: <see cref="E:System.Transactions.TransactionManager.DistributedTransactionStarted" />, <see cref="E:System.Transactions.Transaction.TransactionCompleted" />.</summary>
	// Token: 0x02000020 RID: 32
	public class TransactionEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.TransactionEventArgs" />.</summary>
		// Token: 0x0600008E RID: 142 RVA: 0x00002BAF File Offset: 0x00000DAF
		public TransactionEventArgs()
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002BB7 File Offset: 0x00000DB7
		internal TransactionEventArgs(Transaction transaction) : this()
		{
			this.transaction = transaction;
		}

		/// <summary>Получает транзакцию, для которой предоставляется состояние события.</summary>
		/// <returns>Объект <see cref="T:System.Transactions.Transaction" />, для которого предоставляется состояние события.</returns>
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002BC6 File Offset: 0x00000DC6
		public Transaction Transaction
		{
			get
			{
				return this.transaction;
			}
		}

		// Token: 0x0400005A RID: 90
		private Transaction transaction;
	}
}
