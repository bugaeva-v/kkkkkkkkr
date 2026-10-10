using System;

namespace System.Transactions
{
	/// <summary>Представляет транзакцию, которая не является корневой, но может быть расширена, чтобы находиться под управлением MSDTC.</summary>
	// Token: 0x02000016 RID: 22
	public interface ISimpleTransactionSuperior : ITransactionPromoter
	{
		/// <summary>Уведомляет включенный в список объект о выполняемом откате транзакции.</summary>
		// Token: 0x06000036 RID: 54
		void Rollback();
	}
}
