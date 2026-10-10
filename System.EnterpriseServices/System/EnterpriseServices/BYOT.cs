using System;

namespace System.EnterpriseServices
{
	/// <summary>Заключает в оболочку класс <see langword="ByotServerEx" /> COM+, а также интерфейсы DTC <see langword="ICreateWithTransactionEx" /> и <see langword="ICreateWithTipTransactionEx" /> COM+. Этот класс не наследуется.</summary>
	// Token: 0x02000014 RID: 20
	public sealed class BYOT
	{
		// Token: 0x06000038 RID: 56 RVA: 0x000021E0 File Offset: 0x000003E0
		private BYOT()
		{
		}

		/// <summary>Создает объект, который вовлекается в ручную транзакцию с помощью протокола TIP (транзактный протокол Интернета — Transaction Internet Protocol).</summary>
		/// <param name="url">Адрес URL протокола TIP, определяющий транзакцию.</param>
		/// <param name="t">Тип.</param>
		/// <returns>Запрошенная транзакция.</returns>
		// Token: 0x06000039 RID: 57 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static object CreateWithTipTransaction(string url, Type t)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает объект, вовлеченный в ручную транзакцию.</summary>
		/// <param name="transaction">Объект <see cref="T:System.EnterpriseServices.ITransaction" /> или <see cref="T:System.Transactions.Transaction" />, который задает транзакцию.</param>
		/// <param name="t">Заданный тип.</param>
		/// <returns>Запрошенная транзакция.</returns>
		// Token: 0x0600003A RID: 58 RVA: 0x00002085 File Offset: 0x00000285
		[MonoTODO]
		public static object CreateWithTransaction(object transaction, Type t)
		{
			throw new NotImplementedException();
		}
	}
}
