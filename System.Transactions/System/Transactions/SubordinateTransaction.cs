using System;

namespace System.Transactions
{
	/// <summary>Представляет некорневую транзакцию, которая может быть делегирована. Этот класс не наследуется.</summary>
	// Token: 0x0200001C RID: 28
	[Serializable]
	public sealed class SubordinateTransaction : Transaction
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Transactions.SubordinateTransaction" />.</summary>
		/// <param name="isoLevel">Уровень изоляции транзакции.</param>
		/// <param name="superior">
		///   <see cref="T:System.Transactions.ISimpleTransactionSuperior" />
		/// </param>
		// Token: 0x0600004C RID: 76 RVA: 0x000022D4 File Offset: 0x000004D4
		public SubordinateTransaction(IsolationLevel isoLevel, ISimpleTransactionSuperior superior) : base(isoLevel)
		{
			throw new NotImplementedException();
		}
	}
}
