using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Представляет транзакцию SQL, которую нужно выполнить в источнике данных. Этот класс не наследуется.</summary>
	// Token: 0x02000174 RID: 372
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbTransaction : DbTransaction
	{
		// Token: 0x060013D5 RID: 5077 RVA: 0x0005AE3A File Offset: 0x0005903A
		internal OleDbTransaction()
		{
		}

		/// <summary>Получает объект <see cref="T:System.Data.OleDb.OleDbConnection" />, связанный с транзакцией, или <see langword="null" />, если транзакция уже недействительна.</summary>
		/// <returns>Объект <see cref="T:System.Data.OleDb.OleDbConnection" />, связанный с транзакцией.</returns>
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x060013D6 RID: 5078 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbConnection Connection
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x060013D7 RID: 5079 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override DbConnection DbConnection
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Указывает <see cref="T:System.Data.IsolationLevel" /> для этой транзакции.</summary>
		/// <returns>
		///   <see cref="T:System.Data.IsolationLevel" /> для этой транзакции. Значение по умолчанию — <see langword="ReadCommitted" />.</returns>
		// Token: 0x1700035A RID: 858
		// (get) Token: 0x060013D8 RID: 5080 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override IsolationLevel IsolationLevel
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Начинает вложенную транзакцию базы данных.</summary>
		/// <returns>Вложенная транзакция базы данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Вложенные транзакции не поддерживаются.</exception>
		// Token: 0x060013D9 RID: 5081 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbTransaction Begin()
		{
			throw ADP.OleDb();
		}

		/// <summary>Начинает вложенную транзакцию базы данных и указывает уровень изоляции для новой транзакции.</summary>
		/// <param name="isolevel">Уровень изоляции для данной транзакции.</param>
		/// <returns>Вложенная транзакция базы данных.</returns>
		/// <exception cref="T:System.InvalidOperationException">Вложенные транзакции не поддерживаются.</exception>
		// Token: 0x060013DA RID: 5082 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public OleDbTransaction Begin(IsolationLevel isolevel)
		{
			throw ADP.OleDb();
		}

		/// <summary>Фиксирует транзакцию базы данных.</summary>
		/// <exception cref="T:System.Exception">Ошибка при попытке фиксации транзакции.</exception>
		/// <exception cref="T:System.InvalidOperationException">Транзакция уже зафиксирована, или выполнен откат.  
		///
		/// или - 
		/// Соединение закрыто.</exception>
		// Token: 0x060013DB RID: 5083 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Commit()
		{
			throw ADP.OleDb();
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void Dispose(bool disposing)
		{
			throw ADP.OleDb();
		}

		/// <summary>Откатывает транзакцию из состояния ожидания.</summary>
		/// <exception cref="T:System.Exception">Ошибка при попытке фиксации транзакции.</exception>
		/// <exception cref="T:System.InvalidOperationException">Транзакция уже зафиксирована, или выполнен откат.  
		///
		/// или - 
		/// Соединение закрыто.</exception>
		// Token: 0x060013DD RID: 5085 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public override void Rollback()
		{
			throw ADP.OleDb();
		}
	}
}
