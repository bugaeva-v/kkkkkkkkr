using System;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Threading;

namespace System.Data.Odbc
{
	/// <summary>Представляет инструкцию SQL или хранимую процедуру, выполняемую с источником данных. Этот класс не наследуется.</summary>
	// Token: 0x020002D5 RID: 725
	public sealed class OdbcCommand : DbCommand, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommand" />.</summary>
		// Token: 0x06001F68 RID: 8040 RVA: 0x00094261 File Offset: 0x00092461
		public OdbcCommand()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommand" /> текстом запроса.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		// Token: 0x06001F69 RID: 8041 RVA: 0x0009428E File Offset: 0x0009248E
		public OdbcCommand(string cmdText) : this()
		{
			this.CommandText = cmdText;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommand" /> с текстом запроса и объектом <see cref="T:System.Data.Odbc.OdbcConnection" />.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		/// <param name="connection">Объект <see cref="T:System.Data.Odbc.OdbcConnection" />, представляющий подключение к источнику данных.</param>
		// Token: 0x06001F6A RID: 8042 RVA: 0x0009429D File Offset: 0x0009249D
		public OdbcCommand(string cmdText, OdbcConnection connection) : this()
		{
			this.CommandText = cmdText;
			this.Connection = connection;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcCommand" /> с текстом запроса, объектом <see cref="T:System.Data.Odbc.OdbcConnection" /> и транзакцией <see cref="P:System.Data.Odbc.OdbcCommand.Transaction" />.</summary>
		/// <param name="cmdText">Текст запроса.</param>
		/// <param name="connection">Объект <see cref="T:System.Data.Odbc.OdbcConnection" />, представляющий подключение к источнику данных.</param>
		/// <param name="transaction">Транзакция, в которой выполняется <see cref="T:System.Data.Odbc.OdbcCommand" />.</param>
		// Token: 0x06001F6B RID: 8043 RVA: 0x000942B3 File Offset: 0x000924B3
		public OdbcCommand(string cmdText, OdbcConnection connection, OdbcTransaction transaction) : this()
		{
			this.CommandText = cmdText;
			this.Connection = connection;
			this.Transaction = transaction;
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x000942D0 File Offset: 0x000924D0
		private void DisposeDeadDataReader()
		{
			if (ConnectionState.Fetching == this._cmdState && this._weakDataReaderReference != null && !this._weakDataReaderReference.IsAlive)
			{
				if (this._cmdWrapper != null)
				{
					this._cmdWrapper.FreeKeyInfoStatementHandle(ODBC32.STMT.CLOSE);
					this._cmdWrapper.FreeStatementHandle(ODBC32.STMT.CLOSE);
				}
				this.CloseFromDataReader();
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00094324 File Offset: 0x00092524
		private void DisposeDataReader()
		{
			if (this._weakDataReaderReference != null)
			{
				IDisposable disposable = (IDisposable)this._weakDataReaderReference.Target;
				if (disposable != null && this._weakDataReaderReference.IsAlive)
				{
					disposable.Dispose();
				}
				this.CloseFromDataReader();
			}
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x00094368 File Offset: 0x00092568
		internal void DisconnectFromDataReaderAndConnection()
		{
			OdbcDataReader odbcDataReader = null;
			if (this._weakDataReaderReference != null)
			{
				OdbcDataReader odbcDataReader2 = (OdbcDataReader)this._weakDataReaderReference.Target;
				if (this._weakDataReaderReference.IsAlive)
				{
					odbcDataReader = odbcDataReader2;
				}
			}
			if (odbcDataReader != null)
			{
				odbcDataReader.Command = null;
			}
			this._transaction = null;
			if (this._connection != null)
			{
				this._connection.RemoveWeakReference(this);
				this._connection = null;
			}
			if (odbcDataReader == null)
			{
				this.CloseCommandWrapper();
			}
			this._cmdWrapper = null;
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x000943DB File Offset: 0x000925DB
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.DisconnectFromDataReaderAndConnection();
				this._parameterCollection = null;
				this.CommandText = null;
			}
			this._cmdWrapper = null;
			this._isPrepared = false;
			base.Dispose(disposing);
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00094409 File Offset: 0x00092609
		internal bool Canceling
		{
			get
			{
				return this._cmdWrapper.Canceling;
			}
		}

		/// <summary>Возвращает или задает инструкцию или хранимую процедуру SQL, выполняемую с источником данных.</summary>
		/// <returns>Инструкция или хранимая процедура SQL, подлежащая выполнению. Значением по умолчанию является пустая строка ("").</returns>
		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001F71 RID: 8049 RVA: 0x00094418 File Offset: 0x00092618
		// (set) Token: 0x06001F72 RID: 8050 RVA: 0x00094436 File Offset: 0x00092636
		public override string CommandText
		{
			get
			{
				string commandText = this._commandText;
				if (commandText == null)
				{
					return ADP.StrEmpty;
				}
				return commandText;
			}
			set
			{
				if (this._commandText != value)
				{
					this.PropertyChanging();
					this._commandText = value;
				}
			}
		}

		/// <summary>Возвращает или задает время ожидания перед прекращением попытки выполнить команду и выводом ошибки.</summary>
		/// <returns>Время в секундах, в течение которого должно происходить ожидание выполнения команды. По умолчанию используется значение 30 секунд.</returns>
		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06001F73 RID: 8051 RVA: 0x00094453 File Offset: 0x00092653
		// (set) Token: 0x06001F74 RID: 8052 RVA: 0x0009445B File Offset: 0x0009265B
		public override int CommandTimeout
		{
			get
			{
				return this._commandTimeout;
			}
			set
			{
				if (value < 0)
				{
					throw ADP.InvalidCommandTimeout(value, "CommandTimeout");
				}
				if (value != this._commandTimeout)
				{
					this.PropertyChanging();
					this._commandTimeout = value;
				}
			}
		}

		/// <summary>Сбрасывает значение свойства <see cref="P:System.Data.Odbc.OdbcCommand.CommandTimeout" /> и задает ему значение по умолчанию.</summary>
		// Token: 0x06001F75 RID: 8053 RVA: 0x00094483 File Offset: 0x00092683
		public void ResetCommandTimeout()
		{
			if (30 != this._commandTimeout)
			{
				this.PropertyChanging();
				this._commandTimeout = 30;
			}
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0009449D File Offset: 0x0009269D
		private bool ShouldSerializeCommandTimeout()
		{
			return 30 != this._commandTimeout;
		}

		/// <summary>Возвращает или задает значение, которое указывает, как интерпретируется свойство <see cref="P:System.Data.Odbc.OdbcCommand.CommandText" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.CommandType" />. Значение по умолчанию — <see langword="Text" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение не является допустимым объектом <see cref="T:System.Data.CommandType" />.</exception>
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001F77 RID: 8055 RVA: 0x000944AC File Offset: 0x000926AC
		// (set) Token: 0x06001F78 RID: 8056 RVA: 0x000944C6 File Offset: 0x000926C6
		[DefaultValue(CommandType.Text)]
		public override CommandType CommandType
		{
			get
			{
				CommandType commandType = this._commandType;
				if (commandType == (CommandType)0)
				{
					return CommandType.Text;
				}
				return commandType;
			}
			set
			{
				if (value == CommandType.Text || value == CommandType.StoredProcedure)
				{
					this.PropertyChanging();
					this._commandType = value;
					return;
				}
				if (value != CommandType.TableDirect)
				{
					throw ADP.InvalidCommandType(value);
				}
				throw ODBC.NotSupportedCommandType(value);
			}
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.Odbc.OdbcConnection" />, используемый этим экземпляром класса <see cref="T:System.Data.Odbc.OdbcCommand" />.</summary>
		/// <returns>Подключение к источнику данных. Значение по умолчанию null.</returns>
		/// <exception cref="T:System.InvalidOperationException">Свойство <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> изменилось в течение транзакции.</exception>
		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000944F5 File Offset: 0x000926F5
		// (set) Token: 0x06001F7A RID: 8058 RVA: 0x000944FD File Offset: 0x000926FD
		public new OdbcConnection Connection
		{
			get
			{
				return this._connection;
			}
			set
			{
				if (value != this._connection)
				{
					this.PropertyChanging();
					this.DisconnectFromDataReaderAndConnection();
					this._connection = value;
				}
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001F7B RID: 8059 RVA: 0x0009451B File Offset: 0x0009271B
		// (set) Token: 0x06001F7C RID: 8060 RVA: 0x00094523 File Offset: 0x00092723
		protected override DbConnection DbConnection
		{
			get
			{
				return this.Connection;
			}
			set
			{
				this.Connection = (OdbcConnection)value;
			}
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06001F7D RID: 8061 RVA: 0x00094531 File Offset: 0x00092731
		protected override DbParameterCollection DbParameterCollection
		{
			get
			{
				return this.Parameters;
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06001F7E RID: 8062 RVA: 0x00094539 File Offset: 0x00092739
		// (set) Token: 0x06001F7F RID: 8063 RVA: 0x00094541 File Offset: 0x00092741
		protected override DbTransaction DbTransaction
		{
			get
			{
				return this.Transaction;
			}
			set
			{
				this.Transaction = (OdbcTransaction)value;
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, должен ли объект команды быть видимым в настраиваемом элементе управления интерфейса.</summary>
		/// <returns>
		///   <see langword="true" /> Если объект команды должен быть видимым в элементе управления; в противном случае <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06001F80 RID: 8064 RVA: 0x0009454F File Offset: 0x0009274F
		// (set) Token: 0x06001F81 RID: 8065 RVA: 0x0009455A File Offset: 0x0009275A
		[DefaultValue(true)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignOnly(true)]
		public override bool DesignTimeVisible
		{
			get
			{
				return !this._designTimeInvisible;
			}
			set
			{
				this._designTimeInvisible = !value;
				TypeDescriptor.Refresh(this);
			}
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06001F82 RID: 8066 RVA: 0x0009456C File Offset: 0x0009276C
		internal bool HasParameters
		{
			get
			{
				return this._parameterCollection != null;
			}
		}

		/// <summary>Возвращает набор <see cref="T:System.Data.Odbc.OdbcParameterCollection" />.</summary>
		/// <returns>Параметры инструкции SQL или хранимой процедуры. По умолчанию является пустой коллекцией.</returns>
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06001F83 RID: 8067 RVA: 0x00094577 File Offset: 0x00092777
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public new OdbcParameterCollection Parameters
		{
			get
			{
				if (this._parameterCollection == null)
				{
					this._parameterCollection = new OdbcParameterCollection();
				}
				return this._parameterCollection;
			}
		}

		/// <summary>Возвращает или задает транзакцию <see cref="T:System.Data.Odbc.OdbcTransaction" />, в которой выполняется команда <see cref="T:System.Data.Odbc.OdbcCommand" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcTransaction" />. Значение по умолчанию null.</returns>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06001F84 RID: 8068 RVA: 0x00094592 File Offset: 0x00092792
		// (set) Token: 0x06001F85 RID: 8069 RVA: 0x000945B6 File Offset: 0x000927B6
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new OdbcTransaction Transaction
		{
			get
			{
				if (this._transaction != null && this._transaction.Connection == null)
				{
					this._transaction = null;
				}
				return this._transaction;
			}
			set
			{
				if (this._transaction != value)
				{
					this.PropertyChanging();
					this._transaction = value;
				}
			}
		}

		/// <summary>Возвращает или задает значение, указывающее, каким образом метод Update должен применять результаты выполнения команды к DataRow.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.UpdateRowSource" />.</returns>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06001F86 RID: 8070 RVA: 0x000945CE File Offset: 0x000927CE
		// (set) Token: 0x06001F87 RID: 8071 RVA: 0x000945D6 File Offset: 0x000927D6
		[DefaultValue(UpdateRowSource.Both)]
		public override UpdateRowSource UpdatedRowSource
		{
			get
			{
				return this._updatedRowSource;
			}
			set
			{
				if (value <= UpdateRowSource.Both)
				{
					this._updatedRowSource = value;
					return;
				}
				throw ADP.InvalidUpdateRowSource(value);
			}
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x000945EA File Offset: 0x000927EA
		internal OdbcDescriptorHandle GetDescriptorHandle(ODBC32.SQL_ATTR attribute)
		{
			return this._cmdWrapper.GetDescriptorHandle(attribute);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x000945F8 File Offset: 0x000927F8
		internal CMDWrapper GetStatementHandle()
		{
			if (this._cmdWrapper == null)
			{
				this._cmdWrapper = new CMDWrapper(this._connection);
				this._connection.AddWeakReference(this, 1);
			}
			if (this._cmdWrapper._dataReaderBuf == null)
			{
				this._cmdWrapper._dataReaderBuf = new CNativeBuffer(4096);
			}
			if (this._cmdWrapper.StatementHandle == null)
			{
				this._isPrepared = false;
				this._cmdWrapper.CreateStatementHandle();
			}
			else if (this._parameterCollection != null && this._parameterCollection.RebindCollection)
			{
				this._cmdWrapper.FreeStatementHandle(ODBC32.STMT.RESET_PARAMS);
			}
			return this._cmdWrapper;
		}

		/// <summary>Пытается отменить выполнение <see cref="T:System.Data.Odbc.OdbcCommand" />.</summary>
		// Token: 0x06001F8A RID: 8074 RVA: 0x00094698 File Offset: 0x00092898
		public override void Cancel()
		{
			CMDWrapper cmdWrapper = this._cmdWrapper;
			if (cmdWrapper != null)
			{
				cmdWrapper.Canceling = true;
				OdbcStatementHandle statementHandle = cmdWrapper.StatementHandle;
				if (statementHandle != null)
				{
					OdbcStatementHandle obj = statementHandle;
					lock (obj)
					{
						ODBC32.RetCode retCode = statementHandle.Cancel();
						if (retCode > ODBC32.RetCode.SUCCESS_WITH_INFO)
						{
							throw cmdWrapper.Connection.HandleErrorNoThrow(statementHandle, retCode);
						}
					}
				}
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x06001F8B RID: 8075 RVA: 0x00094704 File Offset: 0x00092904
		object ICloneable.Clone()
		{
			OdbcCommand odbcCommand = new OdbcCommand();
			odbcCommand.CommandText = this.CommandText;
			odbcCommand.CommandTimeout = this.CommandTimeout;
			odbcCommand.CommandType = this.CommandType;
			odbcCommand.Connection = this.Connection;
			odbcCommand.Transaction = this.Transaction;
			odbcCommand.UpdatedRowSource = this.UpdatedRowSource;
			if (this._parameterCollection != null && 0 < this.Parameters.Count)
			{
				OdbcParameterCollection parameters = odbcCommand.Parameters;
				foreach (object obj in this.Parameters)
				{
					ICloneable cloneable = (ICloneable)obj;
					parameters.Add(cloneable.Clone());
				}
			}
			return odbcCommand;
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x000947D4 File Offset: 0x000929D4
		internal bool RecoverFromConnection()
		{
			this.DisposeDeadDataReader();
			return this._cmdState == ConnectionState.Closed;
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x000947E8 File Offset: 0x000929E8
		private void CloseCommandWrapper()
		{
			CMDWrapper cmdWrapper = this._cmdWrapper;
			if (cmdWrapper != null)
			{
				try
				{
					cmdWrapper.Dispose();
					if (this._connection != null)
					{
						this._connection.RemoveWeakReference(this);
					}
				}
				finally
				{
					this._cmdWrapper = null;
				}
			}
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x00094834 File Offset: 0x00092A34
		internal void CloseFromConnection()
		{
			if (this._parameterCollection != null)
			{
				this._parameterCollection.RebindCollection = true;
			}
			this.DisposeDataReader();
			this.CloseCommandWrapper();
			this._isPrepared = false;
			this._transaction = null;
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x00094864 File Offset: 0x00092A64
		internal void CloseFromDataReader()
		{
			this._weakDataReaderReference = null;
			this._cmdState = ConnectionState.Closed;
		}

		/// <summary>Создает новый экземпляр объекта <see cref="T:System.Data.Odbc.OdbcParameter" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcParameter" />.</returns>
		// Token: 0x06001F90 RID: 8080 RVA: 0x00094874 File Offset: 0x00092A74
		public new OdbcParameter CreateParameter()
		{
			return new OdbcParameter();
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0009487B File Offset: 0x00092A7B
		protected override DbParameter CreateDbParameter()
		{
			return this.CreateParameter();
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x00094883 File Offset: 0x00092A83
		protected override DbDataReader ExecuteDbDataReader(CommandBehavior behavior)
		{
			return this.ExecuteReader(behavior);
		}

		/// <summary>Выполняет оператор SQL применительно к свойству <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> и возвращает количество измененных командой строк.</summary>
		/// <returns>Операторы UPDATE, INSERT и DELETE возвращают количество строк, которые были обработаны с их помощью. Для всех прочих типов операторов возвращаемым значением является -1.</returns>
		/// <exception cref="T:System.InvalidOperationException">Подключение не существует.  
		/// -или- 
		/// Соединение не открыто.</exception>
		// Token: 0x06001F93 RID: 8083 RVA: 0x0009488C File Offset: 0x00092A8C
		public override int ExecuteNonQuery()
		{
			int recordsAffected;
			using (OdbcDataReader odbcDataReader = this.ExecuteReaderObject(CommandBehavior.Default, "ExecuteNonQuery", false))
			{
				odbcDataReader.Close();
				recordsAffected = odbcDataReader.RecordsAffected;
			}
			return recordsAffected;
		}

		/// <summary>Отправляет свойство <see cref="P:System.Data.Odbc.OdbcCommand.CommandText" /> свойству <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> и создает объект <see cref="T:System.Data.Odbc.OdbcDataReader" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcDataReader" />.</returns>
		// Token: 0x06001F94 RID: 8084 RVA: 0x000948D4 File Offset: 0x00092AD4
		public new OdbcDataReader ExecuteReader()
		{
			return this.ExecuteReader(CommandBehavior.Default);
		}

		/// <summary>Отправляет <see cref="P:System.Data.Odbc.OdbcCommand.CommandText" /> в <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> и создает <see cref="T:System.Data.Odbc.OdbcDataReader" />, используя одно из значений <see langword="CommandBehavior" />.</summary>
		/// <param name="behavior">Одно из значений <see langword="System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcDataReader" />.</returns>
		// Token: 0x06001F95 RID: 8085 RVA: 0x000948DD File Offset: 0x00092ADD
		public new OdbcDataReader ExecuteReader(CommandBehavior behavior)
		{
			return this.ExecuteReaderObject(behavior, "ExecuteReader", true);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000948EC File Offset: 0x00092AEC
		internal OdbcDataReader ExecuteReaderFromSQLMethod(object[] methodArguments, ODBC32.SQL_API method)
		{
			return this.ExecuteReaderObject(CommandBehavior.Default, method.ToString(), true, methodArguments, method);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00094905 File Offset: 0x00092B05
		private OdbcDataReader ExecuteReaderObject(CommandBehavior behavior, string method, bool needReader)
		{
			if (this.CommandText == null || this.CommandText.Length == 0)
			{
				throw ADP.CommandTextRequired(method);
			}
			return this.ExecuteReaderObject(behavior, method, needReader, null, ODBC32.SQL_API.SQLEXECDIRECT);
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00094930 File Offset: 0x00092B30
		private OdbcDataReader ExecuteReaderObject(CommandBehavior behavior, string method, bool needReader, object[] methodArguments, ODBC32.SQL_API odbcApiMethod)
		{
			OdbcDataReader odbcDataReader = null;
			try
			{
				this.DisposeDeadDataReader();
				this.ValidateConnectionAndTransaction(method);
				if ((CommandBehavior.SingleRow & behavior) != CommandBehavior.Default)
				{
					behavior |= CommandBehavior.SingleResult;
				}
				OdbcStatementHandle statementHandle = this.GetStatementHandle().StatementHandle;
				this._cmdWrapper.Canceling = false;
				if (this._weakDataReaderReference != null && this._weakDataReaderReference.IsAlive)
				{
					object target = this._weakDataReaderReference.Target;
					if (target != null && this._weakDataReaderReference.IsAlive && !((OdbcDataReader)target).IsClosed)
					{
						throw ADP.OpenReaderExists();
					}
				}
				odbcDataReader = new OdbcDataReader(this, this._cmdWrapper, behavior);
				if (!this.Connection.ProviderInfo.NoQueryTimeout)
				{
					this.TrySetStatementAttribute(statementHandle, ODBC32.SQL_ATTR.QUERY_TIMEOUT, (IntPtr)this.CommandTimeout);
				}
				if (needReader && this.Connection.IsV3Driver && !this.Connection.ProviderInfo.NoSqlSoptSSNoBrowseTable && !this.Connection.ProviderInfo.NoSqlSoptSSHiddenColumns)
				{
					if (odbcDataReader.IsBehavior(CommandBehavior.KeyInfo))
					{
						if (!this._cmdWrapper._ssKeyInfoModeOn)
						{
							this.TrySetStatementAttribute(statementHandle, (ODBC32.SQL_ATTR)1228, (IntPtr)1);
							this.TrySetStatementAttribute(statementHandle, ODBC32.SQL_ATTR.SQL_COPT_SS_TXN_ISOLATION, (IntPtr)1);
							this._cmdWrapper._ssKeyInfoModeOff = false;
							this._cmdWrapper._ssKeyInfoModeOn = true;
						}
					}
					else if (!this._cmdWrapper._ssKeyInfoModeOff)
					{
						this.TrySetStatementAttribute(statementHandle, (ODBC32.SQL_ATTR)1228, (IntPtr)0);
						this.TrySetStatementAttribute(statementHandle, ODBC32.SQL_ATTR.SQL_COPT_SS_TXN_ISOLATION, (IntPtr)0);
						this._cmdWrapper._ssKeyInfoModeOff = true;
						this._cmdWrapper._ssKeyInfoModeOn = false;
					}
				}
				if (odbcDataReader.IsBehavior(CommandBehavior.KeyInfo) || odbcDataReader.IsBehavior(CommandBehavior.SchemaOnly))
				{
					ODBC32.RetCode retCode = statementHandle.Prepare(this.CommandText);
					if (retCode != ODBC32.RetCode.SUCCESS)
					{
						this._connection.HandleError(statementHandle, retCode);
					}
				}
				bool flag = false;
				CNativeBuffer cnativeBuffer = this._cmdWrapper._nativeParameterBuffer;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					if (this._parameterCollection != null && 0 < this._parameterCollection.Count)
					{
						int num = this._parameterCollection.CalcParameterBufferSize(this);
						if (cnativeBuffer == null || cnativeBuffer.Length < num)
						{
							if (cnativeBuffer != null)
							{
								cnativeBuffer.Dispose();
							}
							cnativeBuffer = new CNativeBuffer(num);
							this._cmdWrapper._nativeParameterBuffer = cnativeBuffer;
						}
						else
						{
							cnativeBuffer.ZeroMemory();
						}
						cnativeBuffer.DangerousAddRef(ref flag);
						this._parameterCollection.Bind(this, this._cmdWrapper, cnativeBuffer);
					}
					if (!odbcDataReader.IsBehavior(CommandBehavior.SchemaOnly))
					{
						ODBC32.RetCode retCode;
						if ((odbcDataReader.IsBehavior(CommandBehavior.KeyInfo) || odbcDataReader.IsBehavior(CommandBehavior.SchemaOnly)) && this.CommandType != CommandType.StoredProcedure)
						{
							short num2;
							retCode = statementHandle.NumberOfResultColumns(out num2);
							if (retCode == ODBC32.RetCode.SUCCESS || retCode == ODBC32.RetCode.SUCCESS_WITH_INFO)
							{
								if (num2 > 0)
								{
									odbcDataReader.GetSchemaTable();
								}
							}
							else if (retCode != ODBC32.RetCode.NO_DATA)
							{
								this._connection.HandleError(statementHandle, retCode);
							}
						}
						if (odbcApiMethod <= ODBC32.SQL_API.SQLGETTYPEINFO)
						{
							if (odbcApiMethod != ODBC32.SQL_API.SQLEXECDIRECT)
							{
								if (odbcApiMethod == ODBC32.SQL_API.SQLCOLUMNS)
								{
									retCode = statementHandle.Columns((string)methodArguments[0], (string)methodArguments[1], (string)methodArguments[2], (string)methodArguments[3]);
									goto IL_42A;
								}
								if (odbcApiMethod == ODBC32.SQL_API.SQLGETTYPEINFO)
								{
									retCode = statementHandle.GetTypeInfo((short)methodArguments[0]);
									goto IL_42A;
								}
							}
							else
							{
								if (odbcDataReader.IsBehavior(CommandBehavior.KeyInfo) || this._isPrepared)
								{
									retCode = statementHandle.Execute();
									goto IL_42A;
								}
								retCode = statementHandle.ExecuteDirect(this.CommandText);
								goto IL_42A;
							}
						}
						else if (odbcApiMethod <= ODBC32.SQL_API.SQLTABLES)
						{
							if (odbcApiMethod == ODBC32.SQL_API.SQLSTATISTICS)
							{
								retCode = statementHandle.Statistics((string)methodArguments[0], (string)methodArguments[1], (string)methodArguments[2], (short)methodArguments[3], (short)methodArguments[4]);
								goto IL_42A;
							}
							if (odbcApiMethod == ODBC32.SQL_API.SQLTABLES)
							{
								retCode = statementHandle.Tables((string)methodArguments[0], (string)methodArguments[1], (string)methodArguments[2], (string)methodArguments[3]);
								goto IL_42A;
							}
						}
						else
						{
							if (odbcApiMethod == ODBC32.SQL_API.SQLPROCEDURECOLUMNS)
							{
								retCode = statementHandle.ProcedureColumns((string)methodArguments[0], (string)methodArguments[1], (string)methodArguments[2], (string)methodArguments[3]);
								goto IL_42A;
							}
							if (odbcApiMethod == ODBC32.SQL_API.SQLPROCEDURES)
							{
								retCode = statementHandle.Procedures((string)methodArguments[0], (string)methodArguments[1], (string)methodArguments[2]);
								goto IL_42A;
							}
						}
						throw ADP.InvalidOperation(method.ToString());
						IL_42A:
						if (retCode != ODBC32.RetCode.SUCCESS && ODBC32.RetCode.NO_DATA != retCode)
						{
							this._connection.HandleError(statementHandle, retCode);
						}
					}
				}
				finally
				{
					if (flag)
					{
						cnativeBuffer.DangerousRelease();
					}
				}
				this._weakDataReaderReference = new WeakReference(odbcDataReader);
				if (!odbcDataReader.IsBehavior(CommandBehavior.SchemaOnly))
				{
					odbcDataReader.FirstResult();
				}
				this._cmdState = ConnectionState.Fetching;
			}
			finally
			{
				if (ConnectionState.Fetching != this._cmdState)
				{
					if (odbcDataReader != null)
					{
						if (this._parameterCollection != null)
						{
							this._parameterCollection.ClearBindings();
						}
						((IDisposable)odbcDataReader).Dispose();
					}
					if (this._cmdState != ConnectionState.Closed)
					{
						this._cmdState = ConnectionState.Closed;
					}
				}
			}
			return odbcDataReader;
		}

		/// <summary>Выполняет запрос и возвращает первый столбец первой строки результирующего набора, возвращаемого запросом. Дополнительные столбцы или строки не обрабатываются.</summary>
		/// <returns>Первый столбец первой строки набора результатов или пустая ссылка, если набор результатов пуст.</returns>
		// Token: 0x06001F99 RID: 8089 RVA: 0x00094E18 File Offset: 0x00093018
		public override object ExecuteScalar()
		{
			object result = null;
			using (IDataReader dataReader = this.ExecuteReaderObject(CommandBehavior.Default, "ExecuteScalar", false))
			{
				if (dataReader.Read() && 0 < dataReader.FieldCount)
				{
					result = dataReader.GetValue(0);
				}
				dataReader.Close();
			}
			return result;
		}

		// Token: 0x06001F9A RID: 8090 RVA: 0x00094E74 File Offset: 0x00093074
		internal string GetDiagSqlState()
		{
			return this._cmdWrapper.GetDiagSqlState();
		}

		// Token: 0x06001F9B RID: 8091 RVA: 0x00094E81 File Offset: 0x00093081
		private void PropertyChanging()
		{
			this._isPrepared = false;
		}

		/// <summary>Создает подготовленную (или скомпилированную) версию команды в источнике данных.</summary>
		/// <exception cref="T:System.InvalidOperationException">
		///   <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> не указывается.  
		/// -или- 
		/// Свойство <see cref="P:System.Data.Odbc.OdbcCommand.Connection" /> не является методом <see cref="M:System.Data.Odbc.OdbcConnection.Open" />.</exception>
		// Token: 0x06001F9C RID: 8092 RVA: 0x00094E8C File Offset: 0x0009308C
		public override void Prepare()
		{
			this.ValidateOpenConnection("Prepare");
			if ((ConnectionState.Fetching & this._connection.InternalState) != ConnectionState.Closed)
			{
				throw ADP.OpenReaderExists();
			}
			if (this.CommandType == CommandType.TableDirect)
			{
				return;
			}
			this.DisposeDeadDataReader();
			this.GetStatementHandle();
			OdbcStatementHandle statementHandle = this._cmdWrapper.StatementHandle;
			ODBC32.RetCode retCode = statementHandle.Prepare(this.CommandText);
			if (retCode != ODBC32.RetCode.SUCCESS)
			{
				this._connection.HandleError(statementHandle, retCode);
			}
			this._isPrepared = true;
		}

		// Token: 0x06001F9D RID: 8093 RVA: 0x00094F04 File Offset: 0x00093104
		private void TrySetStatementAttribute(OdbcStatementHandle stmt, ODBC32.SQL_ATTR stmtAttribute, IntPtr value)
		{
			if (stmt.SetStatementAttribute(stmtAttribute, value, ODBC32.SQL_IS.UINTEGER) == ODBC32.RetCode.ERROR)
			{
				string a;
				stmt.GetDiagnosticField(out a);
				if (a == "HYC00" || a == "HY092")
				{
					this.Connection.FlagUnsupportedStmtAttr(stmtAttribute);
				}
			}
		}

		// Token: 0x06001F9E RID: 8094 RVA: 0x00094F50 File Offset: 0x00093150
		private void ValidateOpenConnection(string methodName)
		{
			OdbcConnection connection = this.Connection;
			if (connection == null)
			{
				throw ADP.ConnectionRequired(methodName);
			}
			ConnectionState state = connection.State;
			if (ConnectionState.Open != state)
			{
				throw ADP.OpenConnectionRequired(methodName, state);
			}
		}

		// Token: 0x06001F9F RID: 8095 RVA: 0x00094F81 File Offset: 0x00093181
		private void ValidateConnectionAndTransaction(string method)
		{
			if (this._connection == null)
			{
				throw ADP.ConnectionRequired(method);
			}
			this._transaction = this._connection.SetStateExecuting(method, this.Transaction);
			this._cmdState = ConnectionState.Executing;
		}

		// Token: 0x0400173C RID: 5948
		private static int s_objectTypeCount;

		// Token: 0x0400173D RID: 5949
		internal readonly int ObjectID = Interlocked.Increment(ref OdbcCommand.s_objectTypeCount);

		// Token: 0x0400173E RID: 5950
		private string _commandText;

		// Token: 0x0400173F RID: 5951
		private CommandType _commandType;

		// Token: 0x04001740 RID: 5952
		private int _commandTimeout = 30;

		// Token: 0x04001741 RID: 5953
		private UpdateRowSource _updatedRowSource = UpdateRowSource.Both;

		// Token: 0x04001742 RID: 5954
		private bool _designTimeInvisible;

		// Token: 0x04001743 RID: 5955
		private bool _isPrepared;

		// Token: 0x04001744 RID: 5956
		private OdbcConnection _connection;

		// Token: 0x04001745 RID: 5957
		private OdbcTransaction _transaction;

		// Token: 0x04001746 RID: 5958
		private WeakReference _weakDataReaderReference;

		// Token: 0x04001747 RID: 5959
		private CMDWrapper _cmdWrapper;

		// Token: 0x04001748 RID: 5960
		private OdbcParameterCollection _parameterCollection;

		// Token: 0x04001749 RID: 5961
		private ConnectionState _cmdState;
	}
}
