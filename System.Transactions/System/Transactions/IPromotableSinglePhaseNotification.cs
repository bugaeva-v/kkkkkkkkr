using System;

namespace System.Transactions
{
	/// <summary>Описывает объект, действующий в качестве делегата фиксации для нераспределенной транзакции, которая является внутренней для диспетчера ресурсов.</summary>
	// Token: 0x02000015 RID: 21
	public interface IPromotableSinglePhaseNotification : ITransactionPromoter
	{
		/// <summary>Уведомляет участника транзакции об успешном выполнении зачисления.</summary>
		/// <exception cref="T:System.Transactions.TransactionException">Попытка включения в список или сериализации транзакции.</exception>
		// Token: 0x06000033 RID: 51
		void Initialize();

		/// <summary>Уведомляет включенный в список объект о выполняемом откате транзакции.</summary>
		/// <param name="singlePhaseEnlistment">Объект <see cref="T:System.Transactions.SinglePhaseEnlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x06000034 RID: 52
		void Rollback(SinglePhaseEnlistment singlePhaseEnlistment);

		/// <summary>Уведомляет включенный в список объект о выполняемой фиксации транзакции.</summary>
		/// <param name="singlePhaseEnlistment">Интерфейс <see cref="T:System.Transactions.SinglePhaseEnlistment" />, используемый для передачи ответа диспетчеру транзакций.</param>
		// Token: 0x06000035 RID: 53
		void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment);
	}
}
