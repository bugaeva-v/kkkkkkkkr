using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Transactions;

namespace System.Data.Common
{
	/// <summary>Представляет подключение к базе данных.</summary>
	// Token: 0x0200038D RID: 909
	public abstract class DbConnection : Component, IDbConnection, IDisposable, IAsyncDisposable
	{
		/// <summary>Возвращает или задает строку, используемую для открытия подключения.</summary>
		/// <returns>Строка подключения использована для установления первоначального подключения. Точное содержимое строки подключения зависит от конкретного источника данных для этого подключения. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002B88 RID: 11144
		// (set) Token: 0x06002B89 RID: 11145
		[DefaultValue("")]
		[SettingsBindable(true)]
		[RefreshProperties(RefreshProperties.All)]
		[RecommendedAsConfigurable(true)]
		public abstract string ConnectionString { get; set; }

		/// <summary>Получает время ожидания при установлении подключения, по истечении которого попытка подключения завершается и генерируется ошибка.</summary>
		/// <returns>Время (в секундах), в течение которого должно производиться ожидание открытия соединения. Значение по умолчанию определяется конкретным типом используемого подключения.</returns>
		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000BBC0D File Offset: 0x000B9E0D
		public virtual int ConnectionTimeout
		{
			get
			{
				return 15;
			}
		}

		/// <summary>Получает имя текущей базы данных после открытия подключения или имя базы данных, указанное в строке подключения, перед открытием подключения.</summary>
		/// <returns>Имя текущей базы данных или базы данных, которая будет использоваться после открытия подключения. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002B8B RID: 11147
		public abstract string Database { get; }

		/// <summary>Получает имя сервера базы данных, к которому осуществляется подключение.</summary>
		/// <returns>Имя сервера базы данных, к которому осуществляется подключение. Значение по умолчанию - пустая строка.</returns>
		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002B8C RID: 11148
		public abstract string DataSource { get; }

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DbProviderFactory" /> для данного объекта <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Набор методов для создания экземпляров классов поставщиков, реализующих источник данных.</returns>
		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x00003E32 File Offset: 0x00002032
		protected virtual DbProviderFactory DbProviderFactory
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000BBC11 File Offset: 0x000B9E11
		internal DbProviderFactory ProviderFactory
		{
			get
			{
				return this.DbProviderFactory;
			}
		}

		/// <summary>Получает строку, представляющую версию сервера, к которому подключен объект.</summary>
		/// <returns>Версия базы данных. Формат возвращенной строки зависит от конкретного типа используемого подключения.</returns>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Data.Common.DbConnection.ServerVersion" /> был вызван, когда возвращаемая задача не была завершена, и не было открыто соединение после вызова <see cref="Overload:System.Data.Common.DbConnection.OpenAsync" />.</exception>
		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06002B8F RID: 11151
		[Browsable(false)]
		public abstract string ServerVersion { get; }

		/// <summary>Получает строку, описывающую состояние подключения.</summary>
		/// <returns>Состояние подключения. Формат возвращенной строки зависит от конкретного типа используемого подключения.</returns>
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06002B90 RID: 11152
		[Browsable(false)]
		public abstract ConnectionState State { get; }

		/// <summary>Происходит при изменении состояния события.</summary>
		// Token: 0x1400002D RID: 45
		// (add) Token: 0x06002B91 RID: 11153 RVA: 0x000BBC1C File Offset: 0x000B9E1C
		// (remove) Token: 0x06002B92 RID: 11154 RVA: 0x000BBC54 File Offset: 0x000B9E54
		public virtual event StateChangeEventHandler StateChange;

		/// <summary>Начинает транзакцию базы данных.</summary>
		/// <param name="isolationLevel">Указывает уровень изоляции транзакции.</param>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06002B93 RID: 11155
		protected abstract DbTransaction BeginDbTransaction(IsolationLevel isolationLevel);

		/// <summary>Начинает транзакцию базы данных.</summary>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06002B94 RID: 11156 RVA: 0x000BBC89 File Offset: 0x000B9E89
		public DbTransaction BeginTransaction()
		{
			return this.BeginDbTransaction(IsolationLevel.Unspecified);
		}

		/// <summary>Начинает транзакцию базы данных с указанным уровнем изоляции.</summary>
		/// <param name="isolationLevel">Указывает уровень изоляции транзакции.</param>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06002B95 RID: 11157 RVA: 0x000BBC92 File Offset: 0x000B9E92
		public DbTransaction BeginTransaction(IsolationLevel isolationLevel)
		{
			return this.BeginDbTransaction(isolationLevel);
		}

		/// <summary>Начинает транзакцию базы данных.</summary>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06002B96 RID: 11158 RVA: 0x000BBC89 File Offset: 0x000B9E89
		IDbTransaction IDbConnection.BeginTransaction()
		{
			return this.BeginDbTransaction(IsolationLevel.Unspecified);
		}

		/// <summary>Начинает транзакцию базы данных с указанным значением <see cref="T:System.Data.IsolationLevel" />.</summary>
		/// <param name="isolationLevel">Одно из значений <see cref="T:System.Data.IsolationLevel" />.</param>
		/// <returns>Объект, представляющий новую транзакцию.</returns>
		// Token: 0x06002B97 RID: 11159 RVA: 0x000BBC92 File Offset: 0x000B9E92
		IDbTransaction IDbConnection.BeginTransaction(IsolationLevel isolationLevel)
		{
			return this.BeginDbTransaction(isolationLevel);
		}

		/// <summary>Закрывает соединение с базой данных. Рекомендуется использовать этот метод для закрытия любого открытого подключения.</summary>
		/// <exception cref="T:System.Data.Common.DbException">При открытии подключения произошла ошибка на уровне подключения.</exception>
		// Token: 0x06002B98 RID: 11160
		public abstract void Close();

		/// <summary>Изменяет текущую базу данных для открытого подключения.</summary>
		/// <param name="databaseName">Указывает имя базы данных для используемого подключения.</param>
		// Token: 0x06002B99 RID: 11161
		public abstract void ChangeDatabase(string databaseName);

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.Common.DbCommand" />, связанный с текущим подключением.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06002B9A RID: 11162 RVA: 0x000BBC9B File Offset: 0x000B9E9B
		public DbCommand CreateCommand()
		{
			return this.CreateDbCommand();
		}

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.Common.DbCommand" />, связанный с текущим подключением.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbCommand" />, связанный с подключением.</returns>
		// Token: 0x06002B9B RID: 11163 RVA: 0x000BBC9B File Offset: 0x000B9E9B
		IDbCommand IDbConnection.CreateCommand()
		{
			return this.CreateDbCommand();
		}

		/// <summary>Создает и возвращает объект <see cref="T:System.Data.Common.DbCommand" />, связанный с текущим подключением.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbCommand" />.</returns>
		// Token: 0x06002B9C RID: 11164
		protected abstract DbCommand CreateDbCommand();

		/// <summary>Выполняет прикрепление в указанной транзакции.</summary>
		/// <param name="transaction">Ссылка на существующий объект <see cref="T:System.Transactions.Transaction" />, к которому выполняется присоединение.</param>
		// Token: 0x06002B9D RID: 11165 RVA: 0x00008E4B File Offset: 0x0000704B
		public virtual void EnlistTransaction(Transaction transaction)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.Common.DbConnection" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		// Token: 0x06002B9E RID: 11166 RVA: 0x00008E4B File Offset: 0x0000704B
		public virtual DataTable GetSchema()
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.Common.DbConnection" />, используя указанную строку в качестве имени схемы.</summary>
		/// <param name="collectionName">Определяет имя схемы, которая должна быть возвращена.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collectionName" /> задается как значение NULL.</exception>
		// Token: 0x06002B9F RID: 11167 RVA: 0x00008E4B File Offset: 0x0000704B
		public virtual DataTable GetSchema(string collectionName)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает сведения о схеме для источника данных этого объекта <see cref="T:System.Data.Common.DbConnection" />, используя указанную строку в качестве имени схемы и указанный массив строк для значений ограничений.</summary>
		/// <param name="collectionName">Определяет имя схемы, которая должна быть возвращена.</param>
		/// <param name="restrictionValues">Задает набор значений ограничений для запрошенной схемы.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="collectionName" /> задается как значение NULL.</exception>
		// Token: 0x06002BA0 RID: 11168 RVA: 0x00008E4B File Offset: 0x0000704B
		public virtual DataTable GetSchema(string collectionName, string[] restrictionValues)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Вызывает событие <see cref="E:System.Data.Common.DbConnection.StateChange" />.</summary>
		/// <param name="stateChange">Объект <see cref="T:System.Data.StateChangeEventArgs" />, содержащий данные события.</param>
		// Token: 0x06002BA1 RID: 11169 RVA: 0x000BBCA3 File Offset: 0x000B9EA3
		protected virtual void OnStateChange(StateChangeEventArgs stateChange)
		{
			if (this._suppressStateChangeForReconnection)
			{
				return;
			}
			StateChangeEventHandler stateChange2 = this.StateChange;
			if (stateChange2 == null)
			{
				return;
			}
			stateChange2(this, stateChange);
		}

		/// <summary>Открывает подключение к базе данных с параметрами, определяемыми свойством <see cref="P:System.Data.Common.DbConnection.ConnectionString" />.</summary>
		// Token: 0x06002BA2 RID: 11170
		public abstract void Open();

		/// <summary>Асинхронная версия <see cref="M:System.Data.Common.DbConnection.Open" />, которая открывает соединение с базой данных с параметрами, указанными <see cref="P:System.Data.Common.DbConnection.ConnectionString" />. Этот метод вызывает виртуальный метод <see cref="M:System.Data.Common.DbConnection.OpenAsync(System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		// Token: 0x06002BA3 RID: 11171 RVA: 0x000BBCC0 File Offset: 0x000B9EC0
		public Task OpenAsync()
		{
			return this.OpenAsync(CancellationToken.None);
		}

		/// <summary>Это асинхронная версия метода <see cref="M:System.Data.Common.DbConnection.Open" />. Поставщики должны выполнить переопределение с помощью соответствующей реализации. При необходимости можно учитывать токен отмены.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbConnection.Open" /> и возвращает выполненную задачу. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный cancellationToken. Исключения, создаваемые Open, будут связаны через возвращаемое свойство исключения задачи.  
		/// Не вызывайте другие методы и свойства объекта <see langword="DbConnection" /> до тех пор, пока возвращаемая задача не будет завершена.</summary>
		/// <param name="cancellationToken">Инструкция отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		// Token: 0x06002BA4 RID: 11172 RVA: 0x000BBCD0 File Offset: 0x000B9ED0
		public virtual Task OpenAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Open();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x000BBD18 File Offset: 0x000B9F18
		protected virtual ValueTask<DbTransaction> BeginDbTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return new ValueTask<DbTransaction>(Task.FromCanceled<DbTransaction>(cancellationToken));
			}
			ValueTask<DbTransaction> result;
			try
			{
				result = new ValueTask<DbTransaction>(this.BeginDbTransaction(isolationLevel));
			}
			catch (Exception exception)
			{
				result = new ValueTask<DbTransaction>(Task.FromException<DbTransaction>(exception));
			}
			return result;
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x000BBD68 File Offset: 0x000B9F68
		public ValueTask<DbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			return this.BeginDbTransactionAsync(IsolationLevel.Unspecified, cancellationToken);
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x000BBD72 File Offset: 0x000B9F72
		public ValueTask<DbTransaction> BeginTransactionAsync(IsolationLevel isolationLevel, CancellationToken cancellationToken = default(CancellationToken))
		{
			return this.BeginDbTransactionAsync(isolationLevel, cancellationToken);
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x000BBD7C File Offset: 0x000B9F7C
		public virtual Task CloseAsync()
		{
			Task result;
			try
			{
				this.Close();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x000BBDB0 File Offset: 0x000B9FB0
		public virtual ValueTask DisposeAsync()
		{
			base.Dispose();
			return default(ValueTask);
		}

		// Token: 0x06002BAA RID: 11178 RVA: 0x000BBDCC File Offset: 0x000B9FCC
		public virtual Task ChangeDatabaseAsync(string databaseName, CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.ChangeDatabase(databaseName);
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x04001B35 RID: 6965
		internal bool _suppressStateChangeForReconnection;
	}
}
