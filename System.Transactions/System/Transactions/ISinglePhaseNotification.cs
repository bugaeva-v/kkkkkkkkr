using System;

namespace System.Transactions
{
	/// <summary>Описывает объект ресурса, который поддерживает оптимизацию однофазной фиксации для участия в транзакции.</summary>
	// Token: 0x02000017 RID: 23
	public interface ISinglePhaseNotification : IEnlistmentNotification
	{
		/// <summary>Представляет реализацию диспетчером ресурсов функции обратного вызова для оптимизации однофазной фиксации.</summary>
		/// <param name="singlePhaseEnlistment">Объект <see cref="T:System.Transactions.SinglePhaseEnlistment" />, используемый для передачи отклика диспетчеру транзакций.</param>
		// Token: 0x06000037 RID: 55
		void SinglePhaseCommit(SinglePhaseEnlistment singlePhaseEnlistment);
	}
}
