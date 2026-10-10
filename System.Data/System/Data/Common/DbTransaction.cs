using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Common
{
	/// <summary>Базовый класс для транзакции.</summary>
	// Token: 0x0200039F RID: 927
	public abstract class DbTransaction : MarshalByRefObject, IDbTransaction, IDisposable, IAsyncDisposable
	{
		/// <summary>Задает объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией.</returns>
		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000BEFDF File Offset: 0x000BD1DF
		public DbConnection Connection
		{
			get
			{
				return this.DbConnection;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией, или пустую ссылку, если транзакция больше не является допустимой.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией.</returns>
		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06002D05 RID: 11525 RVA: 0x000BEFDF File Offset: 0x000BD1DF
		IDbConnection IDbTransaction.Connection
		{
			get
			{
				return this.DbConnection;
			}
		}

		/// <summary>Задает объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbConnection" />, связанный с транзакцией.</returns>
		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06002D06 RID: 11526
		protected abstract DbConnection DbConnection { get; }

		/// <summary>Указывает <see cref="T:System.Data.IsolationLevel" /> для этой транзакции.</summary>
		/// <returns>
		///   <see cref="T:System.Data.IsolationLevel" /> для этой транзакции.</returns>
		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06002D07 RID: 11527
		public abstract IsolationLevel IsolationLevel { get; }

		/// <summary>Фиксирует транзакцию базы данных.</summary>
		// Token: 0x06002D08 RID: 11528
		public abstract void Commit();

		/// <summary>Освобождает неуправляемые ресурсы, используемые <see cref="T:System.Data.Common.DbTransaction" />.</summary>
		// Token: 0x06002D09 RID: 11529 RVA: 0x000BEFE7 File Offset: 0x000BD1E7
		public void Dispose()
		{
			this.Dispose(true);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Data.Common.DbTransaction" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">При значении <see langword="true" /> этот метод освобождает все ресурсы, используемые любыми управляемыми объектами, на которые ссылается этот объект <see cref="T:System.Data.Common.DbTransaction" />.</param>
		// Token: 0x06002D0A RID: 11530 RVA: 0x00007EED File Offset: 0x000060ED
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Откатывает транзакцию из состояния ожидания.</summary>
		// Token: 0x06002D0B RID: 11531
		public abstract void Rollback();

		// Token: 0x06002D0C RID: 11532 RVA: 0x000BEFF0 File Offset: 0x000BD1F0
		public virtual Task CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Commit();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000BF038 File Offset: 0x000BD238
		public virtual ValueTask DisposeAsync()
		{
			this.Dispose();
			return default(ValueTask);
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x000BF054 File Offset: 0x000BD254
		public virtual Task RollbackAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Rollback();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}
	}
}
