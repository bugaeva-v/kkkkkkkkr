using System;

namespace System.Transactions
{
	/// <summary>Описывает интерфейс, который должен реализовать диспетчер ресурсов, чтобы предоставить обратные вызовы уведомлений о двухфазной фиксации диспетчеру транзакций при внесении в список для участия.</summary>
	// Token: 0x02000014 RID: 20
	public interface IEnlistmentNotification
	{
		/// <summary>Уведомляет включенный в список объект о том, что транзакция фиксируется.</summary>
		/// <param name="enlistment">Объект <see cref="T:System.Transactions.Enlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x0600002F RID: 47
		void Commit(Enlistment enlistment);

		/// <summary>Уведомляет включенный в список объект о сомнительном состоянии транзакции.</summary>
		/// <param name="enlistment">Объект <see cref="T:System.Transactions.Enlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x06000030 RID: 48
		void InDoubt(Enlistment enlistment);

		/// <summary>Уведомляет включенный в список объект о том, что транзакция подготавливается для фиксации.</summary>
		/// <param name="preparingEnlistment">Объект <see cref="T:System.Transactions.PreparingEnlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x06000031 RID: 49
		void Prepare(PreparingEnlistment preparingEnlistment);

		/// <summary>Уведомляет включенный в список объект о том, что выполняется откат транзакции (ее прерывание).</summary>
		/// <param name="enlistment">Объект <see cref="T:System.Transactions.Enlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x06000032 RID: 50
		void Rollback(Enlistment enlistment);
	}
}
