using System;

namespace System.Data
{
	/// <summary>Представляет транзакцию, выполняемую с источником данных; реализуется поставщиками данных платформы NET Framework, у которых есть доступ к реляционным базам данных.</summary>
	// Token: 0x02000107 RID: 263
	public interface IDbTransaction : IDisposable
	{
		/// <summary>Указывает объект Connection для связывания с транзакцией.</summary>
		/// <returns>Объект Connection для связывания с транзакцией.</returns>
		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000F72 RID: 3954
		IDbConnection Connection { get; }

		/// <summary>Указывает <see cref="T:System.Data.IsolationLevel" /> для этой транзакции.</summary>
		/// <returns>
		///   <see cref="T:System.Data.IsolationLevel" /> для этой транзакции. Значение по умолчанию: <see langword="ReadCommitted" />.</returns>
		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000F73 RID: 3955
		IsolationLevel IsolationLevel { get; }

		/// <summary>Фиксирует транзакцию базы данных.</summary>
		/// <exception cref="T:System.Exception">Ошибка при попытке фиксации транзакции.</exception>
		/// <exception cref="T:System.InvalidOperationException">Транзакция уже зафиксирована, или выполнен откат.  
		///
		/// или - 
		/// Соединение закрыто.</exception>
		// Token: 0x06000F74 RID: 3956
		void Commit();

		/// <summary>Откатывает транзакцию из состояния ожидания.</summary>
		/// <exception cref="T:System.Exception">Ошибка при попытке фиксации транзакции.</exception>
		/// <exception cref="T:System.InvalidOperationException">Транзакция уже зафиксирована, или выполнен откат.  
		///
		/// или - 
		/// Соединение закрыто.</exception>
		// Token: 0x06000F75 RID: 3957
		void Rollback();
	}
}
