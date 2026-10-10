using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Common
{
	/// <summary>Представляет инструкцию SQL или хранимую процедуру, выполняемую с источником данных. Предоставляет базовый класс для классов, определяемых базой данных, которые представляют команды. <see cref="Overload:System.Data.Common.DbCommand.ExecuteNonQueryAsync" /></summary>
	// Token: 0x0200038B RID: 907
	public abstract class DbCommand : Component, IDbCommand, IDisposable, IAsyncDisposable
	{
		/// <summary>Возвращает или задает текстовую команду для выполнения в отношении источника данных.</summary>
		/// <returns>Текстовая команда для выполнения. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x06002B51 RID: 11089
		// (set) Token: 0x06002B52 RID: 11090
		[DefaultValue("")]
		[RefreshProperties(RefreshProperties.All)]
		public abstract string CommandText { get; set; }

		/// <summary>Возвращает или задает время ожидания перед завершением попытки выполнить команду и созданием ошибки.</summary>
		/// <returns>Время в секундах, в течение которого должно происходить ожидание выполнения команды.</returns>
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06002B53 RID: 11091
		// (set) Token: 0x06002B54 RID: 11092
		public abstract int CommandTimeout { get; set; }

		/// <summary>Указывает или определяет, как интерпретируется свойство <see cref="P:System.Data.Common.DbCommand.CommandText" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.CommandType" />. Значение по умолчанию — <see langword="Text" />.</returns>
		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x06002B55 RID: 11093
		// (set) Token: 0x06002B56 RID: 11094
		[DefaultValue(CommandType.Text)]
		[RefreshProperties(RefreshProperties.All)]
		public abstract CommandType CommandType { get; set; }

		/// <summary>Возвращает или задает соединение <see cref="T:System.Data.Common.DbConnection" />, используемое этой командой <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Подключение к источнику данных.</returns>
		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000BB8FE File Offset: 0x000B9AFE
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x000BB906 File Offset: 0x000B9B06
		[DefaultValue(null)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DbConnection Connection
		{
			get
			{
				return this.DbConnection;
			}
			set
			{
				this.DbConnection = value;
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.IDbConnection" />, используемый этим экземпляром класса <see cref="T:System.Data.IDbCommand" />.</summary>
		/// <returns>Подключение к источнику данных.</returns>
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000BB8FE File Offset: 0x000B9AFE
		// (set) Token: 0x06002B5A RID: 11098 RVA: 0x000BB90F File Offset: 0x000B9B0F
		IDbConnection IDbCommand.Connection
		{
			get
			{
				return this.DbConnection;
			}
			set
			{
				this.DbConnection = (DbConnection)value;
			}
		}

		/// <summary>Возвращает или задает соединение <see cref="T:System.Data.Common.DbConnection" />, используемое этой командой <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Подключение к источнику данных.</returns>
		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x06002B5B RID: 11099
		// (set) Token: 0x06002B5C RID: 11100
		protected abstract DbConnection DbConnection { get; set; }

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры.</returns>
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06002B5D RID: 11101
		protected abstract DbParameterCollection DbParameterCollection { get; }

		/// <summary>Возвращает или задает контекст <see cref="P:System.Data.Common.DbCommand.DbTransaction" />, в котором выполняется этот объект <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Транзакция, в которой выполняется объект Command поставщика данных .NET Framework. Значением по умолчанию является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x06002B5E RID: 11102
		// (set) Token: 0x06002B5F RID: 11103
		protected abstract DbTransaction DbTransaction { get; set; }

		/// <summary>Возвращает или задает значение, определяющее, должен ли объект команды выводиться на экран в настраиваемом элементе управления интерфейса.</summary>
		/// <returns>Значение <see langword="true" />, если объект команды должен выводиться на экран в элементе управления; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06002B60 RID: 11104
		// (set) Token: 0x06002B61 RID: 11105
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DefaultValue(true)]
		[DesignOnly(true)]
		[Browsable(false)]
		public abstract bool DesignTimeVisible { get; set; }

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Data.Common.DbParameter" />. Дополнительные сведения о параметрах см. в разделе Настройка параметров и типов данных параметров.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры.</returns>
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06002B62 RID: 11106 RVA: 0x000BB91D File Offset: 0x000B9B1D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DbParameterCollection Parameters
		{
			get
			{
				return this.DbParameterCollection;
			}
		}

		/// <summary>Возвращает набор <see cref="T:System.Data.IDataParameterCollection" />.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры.</returns>
		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000BB91D File Offset: 0x000B9B1D
		IDataParameterCollection IDbCommand.Parameters
		{
			get
			{
				return this.DbParameterCollection;
			}
		}

		/// <summary>Возвращает или задает контекст <see cref="T:System.Data.Common.DbTransaction" />, в котором выполняется этот объект <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Транзакция, в рамках которой выполняется объект <see langword="Command" /> поставщика данных .NET Framework. Значением по умолчанию является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000BB925 File Offset: 0x000B9B25
		// (set) Token: 0x06002B65 RID: 11109 RVA: 0x000BB92D File Offset: 0x000B9B2D
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DefaultValue(null)]
		public DbTransaction Transaction
		{
			get
			{
				return this.DbTransaction;
			}
			set
			{
				this.DbTransaction = value;
			}
		}

		/// <summary>Возвращает или задает контекст <see cref="P:System.Data.Common.DbCommand.DbTransaction" />, в котором выполняется этот объект <see cref="T:System.Data.Common.DbCommand" />.</summary>
		/// <returns>Транзакция, в рамках которой выполняется объект <see langword="Command" /> поставщика данных .NET Framework. Значением по умолчанию является пустая ссылка (<see langword="Nothing" /> в Visual Basic).</returns>
		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06002B66 RID: 11110 RVA: 0x000BB925 File Offset: 0x000B9B25
		// (set) Token: 0x06002B67 RID: 11111 RVA: 0x000BB936 File Offset: 0x000B9B36
		IDbTransaction IDbCommand.Transaction
		{
			get
			{
				return this.DbTransaction;
			}
			set
			{
				this.DbTransaction = (DbTransaction)value;
			}
		}

		/// <summary>Возвращает или задает способ применения результатов команды к объекту <see cref="T:System.Data.DataRow" />, если он используется методом Update объекта <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.UpdateRowSource" />. Значение по умолчанию — <see langword="Both" />, если команда не создается автоматически. Значение по умолчанию — <see langword="None" />.</returns>
		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06002B68 RID: 11112
		// (set) Token: 0x06002B69 RID: 11113
		[DefaultValue(UpdateRowSource.Both)]
		public abstract UpdateRowSource UpdatedRowSource { get; set; }

		// Token: 0x06002B6A RID: 11114 RVA: 0x000BB944 File Offset: 0x000B9B44
		internal void CancelIgnoreFailure()
		{
			try
			{
				this.Cancel();
			}
			catch (Exception)
			{
			}
		}

		/// <summary>Пытается отменить выполнение объекта <see cref="T:System.Data.Common.DbCommand" />.</summary>
		// Token: 0x06002B6B RID: 11115
		public abstract void Cancel();

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06002B6C RID: 11116 RVA: 0x000BB96C File Offset: 0x000B9B6C
		public DbParameter CreateParameter()
		{
			return this.CreateDbParameter();
		}

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.IDbDataParameter" />.</summary>
		/// <returns>Объект <see langword="IDbDataParameter" />.</returns>
		// Token: 0x06002B6D RID: 11117 RVA: 0x000BB96C File Offset: 0x000B9B6C
		IDbDataParameter IDbCommand.CreateParameter()
		{
			return this.CreateDbParameter();
		}

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.Common.DbParameter" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbParameter" />.</returns>
		// Token: 0x06002B6E RID: 11118
		protected abstract DbParameter CreateDbParameter();

		/// <summary>Выполняет текст команды применительно к подключению.</summary>
		/// <param name="behavior">Экземпляр <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Задача, представляющая операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B6F RID: 11119
		protected abstract DbDataReader ExecuteDbDataReader(CommandBehavior behavior);

		/// <summary>Выполняет оператор SQL применительно к объекту подключения.</summary>
		/// <returns>Число обработанных строк.</returns>
		// Token: 0x06002B70 RID: 11120
		public abstract int ExecuteNonQuery();

		/// <summary>Выполняет свойство <see cref="P:System.Data.Common.DbCommand.CommandText" /> применительно к свойству <see cref="P:System.Data.Common.DbCommand.Connection" /> и возвращает объект <see cref="T:System.Data.Common.DbDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002B71 RID: 11121 RVA: 0x000BB974 File Offset: 0x000B9B74
		public DbDataReader ExecuteReader()
		{
			return this.ExecuteDbDataReader(CommandBehavior.Default);
		}

		/// <summary>Выполняет <see cref="P:System.Data.IDbCommand.CommandText" /> в <see cref="P:System.Data.IDbCommand.Connection" /> и создает <see cref="T:System.Data.IDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />.</returns>
		// Token: 0x06002B72 RID: 11122 RVA: 0x000BB974 File Offset: 0x000B9B74
		IDataReader IDbCommand.ExecuteReader()
		{
			return this.ExecuteDbDataReader(CommandBehavior.Default);
		}

		/// <summary>Выполняет свойство <see cref="P:System.Data.Common.DbCommand.CommandText" /> применительно к свойству <see cref="P:System.Data.Common.DbCommand.Connection" /> и возвращает объект <see cref="T:System.Data.Common.DbDataReader" />, используя одно из значений типа <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Common.DbDataReader" />.</returns>
		// Token: 0x06002B73 RID: 11123 RVA: 0x000BB97D File Offset: 0x000B9B7D
		public DbDataReader ExecuteReader(CommandBehavior behavior)
		{
			return this.ExecuteDbDataReader(behavior);
		}

		/// <summary>Выполняет <see cref="P:System.Data.IDbCommand.CommandText" /> в <see cref="P:System.Data.IDbCommand.Connection" /> и строит <see cref="T:System.Data.IDataReader" /> с помощью одного из значений <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.IDataReader" />.</returns>
		// Token: 0x06002B74 RID: 11124 RVA: 0x000BB97D File Offset: 0x000B9B7D
		IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior)
		{
			return this.ExecuteDbDataReader(behavior);
		}

		/// <summary>Асинхронная версия <see cref="M:System.Data.Common.DbCommand.ExecuteNonQuery" />, которая выполняет инструкцию SQL относительно объекта соединения.  
		/// Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteNonQueryAsync(System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002B75 RID: 11125 RVA: 0x000BB986 File Offset: 0x000B9B86
		public Task<int> ExecuteNonQueryAsync()
		{
			return this.ExecuteNonQueryAsync(CancellationToken.None);
		}

		/// <summary>Это асинхронная версия метода <see cref="M:System.Data.Common.DbCommand.ExecuteNonQuery" />. Поставщики должны выполнить переопределение с помощью соответствующей реализации. При необходимости можно игнорировать токен отмены.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbCommand.ExecuteNonQuery" /> и возвращает завершенную задачу, блокируя вызывающий поток. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный токен отмены.  Исключения, создаваемые <see cref="M:System.Data.Common.DbCommand.ExecuteNonQuery" />, будут связаны через возвращаемое свойство исключения задачи.  
		/// Не вызывайте другие методы и свойства объекта <see langword="DbCommand" /> до тех пор, пока возвращаемая задача не будет завершена.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002B76 RID: 11126 RVA: 0x000BB994 File Offset: 0x000B9B94
		public virtual Task<int> ExecuteNonQueryAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<int>();
			}
			CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(delegate(object s)
				{
					((DbCommand)s).CancelIgnoreFailure();
				}, this);
			}
			Task<int> result;
			try
			{
				result = Task.FromResult<int>(this.ExecuteNonQuery());
			}
			catch (Exception exception)
			{
				result = Task.FromException<int>(exception);
			}
			finally
			{
				cancellationTokenRegistration.Dispose();
			}
			return result;
		}

		/// <summary>Асинхронная версия <see cref="Overload:System.Data.Common.DbCommand.ExecuteReader" />, которая выполняет <see cref="P:System.Data.Common.DbCommand.CommandText" /> относительно <see cref="P:System.Data.Common.DbCommand.Connection" /> и возвращает <see cref="T:System.Data.Common.DbDataReader" />.  
		/// Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteDbDataReaderAsync(System.Data.CommandBehavior,System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B77 RID: 11127 RVA: 0x000BBA28 File Offset: 0x000B9C28
		public Task<DbDataReader> ExecuteReaderAsync()
		{
			return this.ExecuteReaderAsync(CommandBehavior.Default, CancellationToken.None);
		}

		/// <summary>Асинхронная версия <see cref="Overload:System.Data.Common.DbCommand.ExecuteReader" />, которая выполняет <see cref="P:System.Data.Common.DbCommand.CommandText" /> относительно <see cref="P:System.Data.Common.DbCommand.Connection" /> и возвращает <see cref="T:System.Data.Common.DbDataReader" />. Этот метод распространяет уведомление о том, что операции следует отменить.  
		/// Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteDbDataReaderAsync(System.Data.CommandBehavior,System.Threading.CancellationToken)" />.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B78 RID: 11128 RVA: 0x000BBA36 File Offset: 0x000B9C36
		public Task<DbDataReader> ExecuteReaderAsync(CancellationToken cancellationToken)
		{
			return this.ExecuteReaderAsync(CommandBehavior.Default, cancellationToken);
		}

		/// <summary>Асинхронная версия <see cref="Overload:System.Data.Common.DbCommand.ExecuteReader" />, которая выполняет <see cref="P:System.Data.Common.DbCommand.CommandText" /> относительно <see cref="P:System.Data.Common.DbCommand.Connection" /> и возвращает <see cref="T:System.Data.Common.DbDataReader" />.  
		/// Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteDbDataReaderAsync(System.Data.CommandBehavior,System.Threading.CancellationToken)" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B79 RID: 11129 RVA: 0x000BBA40 File Offset: 0x000B9C40
		public Task<DbDataReader> ExecuteReaderAsync(CommandBehavior behavior)
		{
			return this.ExecuteReaderAsync(behavior, CancellationToken.None);
		}

		/// <summary>Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteDbDataReaderAsync(System.Data.CommandBehavior,System.Threading.CancellationToken)" />.</summary>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B7A RID: 11130 RVA: 0x000BBA4E File Offset: 0x000B9C4E
		public Task<DbDataReader> ExecuteReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
		{
			return this.ExecuteDbDataReaderAsync(behavior, cancellationToken);
		}

		/// <summary>Поставщики должны реализовать этот метод, чтобы предоставить реализацию, отличную от реализации по умолчанию, для перегрузок <see cref="Overload:System.Data.Common.DbCommand.ExecuteReader" />.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbCommand.ExecuteReader" /> и возвращает завершенную задачу, блокируя вызывающий поток. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный токен отмены. Исключения, создаваемые ExecuteReader, будут связаны через возвращаемое свойство исключения задачи.  
		/// Этот метод принимает токен отмены, который может использоваться для запроса ранней отмены операции. Реализации могут игнорировать данный запрос.</summary>
		/// <param name="behavior">Параметры для завершения инструкции и извлечения данных.</param>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		/// <exception cref="T:System.ArgumentException">Недопустимое значение <see cref="T:System.Data.CommandBehavior" />.</exception>
		// Token: 0x06002B7B RID: 11131 RVA: 0x000BBA58 File Offset: 0x000B9C58
		protected virtual Task<DbDataReader> ExecuteDbDataReaderAsync(CommandBehavior behavior, CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<DbDataReader>();
			}
			CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(delegate(object s)
				{
					((DbCommand)s).CancelIgnoreFailure();
				}, this);
			}
			Task<DbDataReader> result;
			try
			{
				result = Task.FromResult<DbDataReader>(this.ExecuteReader(behavior));
			}
			catch (Exception exception)
			{
				result = Task.FromException<DbDataReader>(exception);
			}
			finally
			{
				cancellationTokenRegistration.Dispose();
			}
			return result;
		}

		/// <summary>Асинхронная версия метода <see cref="M:System.Data.Common.DbCommand.ExecuteScalar" />, который выполняет запрос и возвращает первый столбец первой строки в наборе результатов, возвращаемых запросом. Все другие столбцы и строки игнорируются.  
		/// Вызывает <see cref="M:System.Data.Common.DbCommand.ExecuteScalarAsync(System.Threading.CancellationToken)" /> с CancellationToken.None.</summary>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002B7C RID: 11132 RVA: 0x000BBAEC File Offset: 0x000B9CEC
		public Task<object> ExecuteScalarAsync()
		{
			return this.ExecuteScalarAsync(CancellationToken.None);
		}

		/// <summary>Это асинхронная версия метода <see cref="M:System.Data.Common.DbCommand.ExecuteScalar" />. Поставщики должны выполнить переопределение с помощью соответствующей реализации. При необходимости можно игнорировать токен отмены.  
		/// Реализация по умолчанию вызывает синхронный метод <see cref="M:System.Data.Common.DbCommand.ExecuteScalar" /> и возвращает завершенную задачу, блокируя вызывающий поток. Реализация по умолчанию возвращает отмененную задачу, если ей передается уже отмененный токен отмены. Исключения, создаваемые ExecuteScalar, будут связаны через возвращаемое свойство исключения задачи.  
		/// Не вызывайте другие методы и свойства объекта <see langword="DbCommand" /> до тех пор, пока возвращаемая задача не будет завершена.</summary>
		/// <param name="cancellationToken">Токен для отслеживания запросов отмены.</param>
		/// <returns>Задача, представляющая асинхронную операцию.</returns>
		/// <exception cref="T:System.Data.Common.DbException">Ошибка, произошедшая при попытке выполнения текста команды.</exception>
		// Token: 0x06002B7D RID: 11133 RVA: 0x000BBAFC File Offset: 0x000B9CFC
		public virtual Task<object> ExecuteScalarAsync(CancellationToken cancellationToken)
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return ADP.CreatedTaskWithCancellation<object>();
			}
			CancellationTokenRegistration cancellationTokenRegistration = default(CancellationTokenRegistration);
			if (cancellationToken.CanBeCanceled)
			{
				cancellationTokenRegistration = cancellationToken.Register(delegate(object s)
				{
					((DbCommand)s).CancelIgnoreFailure();
				}, this);
			}
			Task<object> result;
			try
			{
				result = Task.FromResult<object>(this.ExecuteScalar());
			}
			catch (Exception exception)
			{
				result = Task.FromException<object>(exception);
			}
			finally
			{
				cancellationTokenRegistration.Dispose();
			}
			return result;
		}

		/// <summary>Выполняет запрос и возвращает первый столбец первой строки результирующего набора, возвращаемого запросом. Все другие столбцы и строки игнорируются.</summary>
		/// <returns>Первый столбец первой строки в результирующем наборе.</returns>
		// Token: 0x06002B7E RID: 11134
		public abstract object ExecuteScalar();

		/// <summary>Создает подготовленную (или скомпилированную) версию команды в источнике данных.</summary>
		// Token: 0x06002B7F RID: 11135
		public abstract void Prepare();

		// Token: 0x06002B80 RID: 11136 RVA: 0x000BBB90 File Offset: 0x000B9D90
		public virtual Task PrepareAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			if (cancellationToken.IsCancellationRequested)
			{
				return Task.FromCanceled(cancellationToken);
			}
			Task result;
			try
			{
				this.Prepare();
				result = Task.CompletedTask;
			}
			catch (Exception exception)
			{
				result = Task.FromException(exception);
			}
			return result;
		}

		// Token: 0x06002B81 RID: 11137 RVA: 0x000BBBD8 File Offset: 0x000B9DD8
		public virtual ValueTask DisposeAsync()
		{
			base.Dispose();
			return default(ValueTask);
		}
	}
}
