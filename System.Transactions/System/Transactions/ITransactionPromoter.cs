using System;

namespace System.Transactions
{
	/// <summary>Описывает делегированную транзакцию для существующей транзакции, которая может быть расширена, чтобы при необходимости находиться под управлением MSDTC.</summary>
	// Token: 0x02000018 RID: 24
	public interface ITransactionPromoter
	{
		/// <summary>Уведомляет включенный в список объект о затребованной эскалации делегированной транзакции.</summary>
		/// <returns>Токен распространения передатчика или приемника, который маршалирует распределенную транзакцию. Дополнительные сведения см. в разделе <see cref="M:System.Transactions.TransactionInterop.GetTransactionFromTransmitterPropagationToken(System.Byte[])" />.</returns>
		// Token: 0x06000038 RID: 56
		byte[] Promote();
	}
}
