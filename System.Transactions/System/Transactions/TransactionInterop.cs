using System;

namespace System.Transactions
{
	/// <summary>Облегчает взаимодействие между <see cref="N:System.Transactions" /> и компонентами, которые были разработаны ранее для взаимодействия с MSDTC, COM+ или <see cref="N:System.EnterpriseServices" />. Этот класс не наследуется.</summary>
	// Token: 0x02000024 RID: 36
	[MonoTODO]
	public static class TransactionInterop
	{
		/// <summary>Получает экземпляр <see cref="T:System.Transactions.IDtcTransaction" />, который представляет <see cref="T:System.Transactions.Transaction" />.</summary>
		/// <param name="transaction">Экземпляр <see cref="T:System.Transactions.Transaction" />, который необходимо маршалировать.</param>
		/// <returns>Экземпляр <see cref="T:System.Transactions.IDtcTransaction" />, который представляет <see cref="T:System.Transactions.Transaction" />.  Экземпляр <see cref="T:System.Transactions.IDtcTransaction" /> совместим с неуправляемой формой ITransaction, используемой MSDTC, и с управляемой формой <see cref="T:System.EnterpriseServices.ITransaction" />, используемой <see cref="N:System.EnterpriseServices" />.</returns>
		// Token: 0x060000A2 RID: 162 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static IDtcTransaction GetDtcTransaction(Transaction transaction)
		{
			throw new NotImplementedException();
		}

		/// <summary>Преобразует объект транзакции в файл cookie транзакции экспорта.</summary>
		/// <param name="transaction">Объект <see cref="T:System.Transactions.Transaction" />, который необходимо маршалировать.</param>
		/// <param name="whereabouts">Адрес, описывающий расположение целевого диспетчера транзакций. Это позволяет двум диспетчерам транзакций взаимодействовать друг с другом и тем самым распространять транзакцию из одной системы в другую.</param>
		/// <returns>Файл cookie транзакции экспорта, представляющий указанный объект <see cref="T:System.Transactions.Transaction" />.</returns>
		// Token: 0x060000A3 RID: 163 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static byte[] GetExportCookie(Transaction transaction, byte[] whereabouts)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает объект <see cref="T:System.Transactions.Transaction" /> из указанного объекта <see cref="T:System.Transactions.IDtcTransaction" />.</summary>
		/// <param name="transactionNative">Объект <see cref="T:System.Transactions.IDtcTransaction" />, который необходимо маршалировать.</param>
		/// <returns>Экземпляр <see cref="T:System.Transactions.Transaction" />, который представляет заданный объект <see cref="T:System.Transactions.IDtcTransaction" />.</returns>
		// Token: 0x060000A4 RID: 164 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static Transaction GetTransactionFromDtcTransaction(IDtcTransaction transactionNative)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает <see cref="T:System.Transactions.Transaction" /> из заданного файла cookie экспорта.</summary>
		/// <param name="cookie">Маршалируемая форма объекта транзакции.</param>
		/// <returns>
		///   <see cref="T:System.Transactions.Transaction" /> из заданного файла cookie экспорта.</returns>
		// Token: 0x060000A5 RID: 165 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static Transaction GetTransactionFromExportCookie(byte[] cookie)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает экземпляр <see cref="T:System.Transactions.Transaction" /> из токена распространения указанного передатчика.</summary>
		/// <param name="propagationToken">Токен распространения, представляющий транзакцию.</param>
		/// <returns>
		///   <see cref="T:System.Transactions.Transaction" /> из токена распространения указанного передатчика.</returns>
		/// <exception cref="T:System.Transactions.TransactionManagerCommunicationException">Сбой при десериализации транзакции вследствие невозможности установить соединение с диспетчером транзакций. Он может быть вызван настройками брандмауэра или настройками безопасности.</exception>
		// Token: 0x060000A6 RID: 166 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static Transaction GetTransactionFromTransmitterPropagationToken(byte[] propagationToken)
		{
			throw new NotImplementedException();
		}

		/// <summary>Создает токен распространения для указанного <see cref="T:System.Transactions.Transaction" />.</summary>
		/// <param name="transaction">Транзакция, которую следует маршалировать в токен распространения.</param>
		/// <returns>Этот метод совместно с методом <see cref="M:System.Transactions.TransactionInterop.GetTransactionFromTransmitterPropagationToken(System.Byte[])" /> предоставляет средства для распространения транзакции по модели «передатчик/приемник», в соответствии с которой транзакция «извлекается» из удаленного компьютера при вызове второго метода для демаршалинга транзакции.  
		/// Подробнее о различных моделях распространения см. в описании класса <see cref="T:System.Transactions.TransactionInterop" />.</returns>
		// Token: 0x060000A7 RID: 167 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static byte[] GetTransmitterPropagationToken(Transaction transaction)
		{
			throw new NotImplementedException();
		}

		/// <summary>Получает сведения о расположении диспетчера распределенных транзакций, который используется методом <see cref="N:System.Transactions" />.</summary>
		/// <returns>Сведения о расположении диспетчера распределенных транзакций, который используется методом <see cref="N:System.Transactions" />.</returns>
		// Token: 0x060000A8 RID: 168 RVA: 0x0000216A File Offset: 0x0000036A
		[MonoTODO]
		public static byte[] GetWhereabouts()
		{
			throw new NotImplementedException();
		}

		/// <summary>Тип обработчика распределенных транзакций.</summary>
		// Token: 0x0400005F RID: 95
		public static readonly Guid PromoterTypeDtc = new Guid("14229753-FFE1-428D-82B7-DF73045CB8DA");
	}
}
