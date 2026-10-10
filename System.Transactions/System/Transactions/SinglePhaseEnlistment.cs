using System;

namespace System.Transactions
{
	/// <summary>Предоставляет набор обратных вызовов, которые облегчают взаимодействие между участником, присоединенным к однофазной фиксации, и диспетчером транзакций при получении уведомления <see cref="M:System.Transactions.ISinglePhaseNotification.SinglePhaseCommit(System.Transactions.SinglePhaseEnlistment)" />.</summary>
	// Token: 0x0200001B RID: 27
	public class SinglePhaseEnlistment : Enlistment
	{
		// Token: 0x06000045 RID: 69 RVA: 0x0000228B File Offset: 0x0000048B
		internal SinglePhaseEnlistment()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002293 File Offset: 0x00000493
		internal SinglePhaseEnlistment(Transaction tx, object abortingEnlisted)
		{
			this.tx = tx;
			this.abortingEnlisted = abortingEnlisted;
		}

		/// <summary>Представляет функцию обратного вызова, используемую для передачи диспетчеру транзакций указания откатить транзакцию.</summary>
		// Token: 0x06000047 RID: 71 RVA: 0x000022A9 File Offset: 0x000004A9
		public void Aborted()
		{
			this.Aborted(null);
		}

		/// <summary>Представляет функцию обратного вызова, используемую для передачи диспетчеру транзакций указания откатить транзакцию, а также предоставляет объяснение.</summary>
		/// <param name="e">Объяснение, почему был инициирован откат.</param>
		// Token: 0x06000048 RID: 72 RVA: 0x000022B2 File Offset: 0x000004B2
		public void Aborted(Exception e)
		{
			if (this.tx != null)
			{
				this.tx.Rollback(e, this.abortingEnlisted);
			}
		}

		/// <summary>Представляет функцию обратного вызова, используемую для передачи диспетчеру транзакций уведомления о том, что однофазная фиксация была успешно завершена.</summary>
		// Token: 0x06000049 RID: 73 RVA: 0x000021EE File Offset: 0x000003EE
		[MonoTODO]
		public void Committed()
		{
		}

		/// <summary>Представляет функцию обратного вызова, используемую для передачи диспетчеру транзакций уведомления о том, что состояние транзакции — сомнительное.</summary>
		// Token: 0x0600004A RID: 74 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		public void InDoubt()
		{
			throw new NotImplementedException();
		}

		/// <summary>Представляет функцию обратного вызова, используемую для передачи диспетчеру транзакций уведомления о том, что состояние транзакции — сомнительное, а также предоставляет объяснение.</summary>
		/// <param name="e">Объяснение, почему транзакция сомнительна.</param>
		// Token: 0x0600004B RID: 75 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO("Not implemented")]
		public void InDoubt(Exception e)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000048 RID: 72
		private Transaction tx;

		// Token: 0x04000049 RID: 73
		private object abortingEnlisted;
	}
}
