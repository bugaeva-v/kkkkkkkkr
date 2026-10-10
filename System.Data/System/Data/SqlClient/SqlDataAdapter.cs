using System;
using System.Data.Common;

namespace System.Data.SqlClient
{
	/// <summary>Представляет набор команд данных и подключение к базе данных, которые используются для заполнения <see cref="T:System.Data.DataSet" /> и обновления базы данных SQL Server. Этот класс не наследуется.</summary>
	// Token: 0x020001E4 RID: 484
	public sealed class SqlDataAdapter : DbDataAdapter, IDbDataAdapter, IDataAdapter, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</summary>
		// Token: 0x06001786 RID: 6022 RVA: 0x0006A6B1 File Offset: 0x000688B1
		public SqlDataAdapter()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDataAdapter" /> с помощью указанной команды <see cref="T:System.Data.SqlClient.SqlCommand" /> в качестве свойства <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" />.</summary>
		/// <param name="selectCommand">Объект <see cref="T:System.Data.SqlClient.SqlCommand" />, содержащий инструкцию Transact-SQL SELECT или хранимую процедуру, задаваемый в свойстве <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</param>
		// Token: 0x06001787 RID: 6023 RVA: 0x0006A6C6 File Offset: 0x000688C6
		public SqlDataAdapter(SqlCommand selectCommand) : this()
		{
			this.SelectCommand = selectCommand;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDataAdapter" /> с помощью <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" /> и строки подключения.</summary>
		/// <param name="selectCommandText">Объект <see cref="T:System.String" />, содержащий инструкцию Transact-SQL SELECT или хранимую процедуру для использования в свойстве <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</param>
		/// <param name="selectConnectionString">Строка подключения. Если в строке подключения не используется <see langword="Integrated Security = true" />, можно использовать <see cref="M:System.Data.SqlClient.SqlDataAdapter.#ctor(System.String,System.Data.SqlClient.SqlConnection)" /> и <see cref="T:System.Data.SqlClient.SqlCredential" /> для передачи идентификатора пользователя и пароля с большей безопасностью, чем при указании идентификатора пользователя и пароля в виде текста в строке подключения.</param>
		// Token: 0x06001788 RID: 6024 RVA: 0x0006A6D8 File Offset: 0x000688D8
		public SqlDataAdapter(string selectCommandText, string selectConnectionString) : this()
		{
			SqlConnection connection = new SqlConnection(selectConnectionString);
			this.SelectCommand = new SqlCommand(selectCommandText, connection);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlDataAdapter" /> с помощью <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" /> и объекта <see cref="T:System.Data.SqlClient.SqlConnection" />.</summary>
		/// <param name="selectCommandText">Объект <see cref="T:System.String" />, содержащий инструкцию Transact-SQL SELECT или хранимую процедуру для использования в свойстве <see cref="P:System.Data.SqlClient.SqlDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</param>
		/// <param name="selectConnection">
		///   <see cref="T:System.Data.SqlClient.SqlConnection" />, предоставляющее подключение. Если строка подключения не использует <see langword="Integrated Security = true" />, можно использовать <see cref="T:System.Data.SqlClient.SqlCredential" /> для более безопасной передачи идентификатора пользователя и пароля, чем при указании идентификатора пользователя и пароля в строке подключения в виде текста.</param>
		// Token: 0x06001789 RID: 6025 RVA: 0x0006A6FF File Offset: 0x000688FF
		public SqlDataAdapter(string selectCommandText, SqlConnection selectConnection) : this()
		{
			this.SelectCommand = new SqlCommand(selectCommandText, selectConnection);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0006A714 File Offset: 0x00068914
		private SqlDataAdapter(SqlDataAdapter from) : base(from)
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Возвращает или задает инструкцию Transact-SQL или хранимую процедуру, используемую для удаления записей из набора данных.</summary>
		/// <returns>
		///   <see cref="T:System.Data.SqlClient.SqlCommand" /> используется в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для удаления записей, соответствующих удаленным строкам в <see cref="T:System.Data.DataSet" />, из базы данных.</returns>
		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0006A72A File Offset: 0x0006892A
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0006A732 File Offset: 0x00068932
		public new SqlCommand DeleteCommand
		{
			get
			{
				return this._deleteCommand;
			}
			set
			{
				this._deleteCommand = value;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.DeleteCommand" />.</summary>
		/// <returns>
		///   <see cref="T:System.Data.IDbCommand" /> — используется при <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для удаления записей в источнике данных для удаленных строк в наборе данных.</returns>
		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x0006A72A File Offset: 0x0006892A
		// (set) Token: 0x0600178E RID: 6030 RVA: 0x0006A73B File Offset: 0x0006893B
		IDbCommand IDbDataAdapter.DeleteCommand
		{
			get
			{
				return this._deleteCommand;
			}
			set
			{
				this._deleteCommand = (SqlCommand)value;
			}
		}

		/// <summary>Возвращает или задает инструкцию Transact-SQL или хранимую процедуру, используемую для вставки новых записей в источник данных.</summary>
		/// <returns>
		///   <see cref="T:System.Data.SqlClient.SqlCommand" /> используется в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для вставки записей, соответствующих новым строкам в <see cref="T:System.Data.DataSet" />, в базу данных.</returns>
		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0006A749 File Offset: 0x00068949
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x0006A751 File Offset: 0x00068951
		public new SqlCommand InsertCommand
		{
			get
			{
				return this._insertCommand;
			}
			set
			{
				this._insertCommand = value;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.InsertCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для вставки записей в источник данных, соответствующих новым строкам в наборе данных.</returns>
		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x0006A749 File Offset: 0x00068949
		// (set) Token: 0x06001792 RID: 6034 RVA: 0x0006A75A File Offset: 0x0006895A
		IDbCommand IDbDataAdapter.InsertCommand
		{
			get
			{
				return this._insertCommand;
			}
			set
			{
				this._insertCommand = (SqlCommand)value;
			}
		}

		/// <summary>Возвращает или задает инструкцию Transact-SQL или хранимую процедуру, используемую для выбора записей из источника данных.</summary>
		/// <returns>
		///   <see cref="T:System.Data.SqlClient.SqlCommand" />, используемый во время выполнения <see cref="M:System.Data.Common.DbDataAdapter.Fill(System.Data.DataSet)" /> для выбора записей из базы данных для помещения в <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x0006A768 File Offset: 0x00068968
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x0006A770 File Offset: 0x00068970
		public new SqlCommand SelectCommand
		{
			get
			{
				return this._selectCommand;
			}
			set
			{
				this._selectCommand = value;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.SelectCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x0006A768 File Offset: 0x00068968
		// (set) Token: 0x06001796 RID: 6038 RVA: 0x0006A779 File Offset: 0x00068979
		IDbCommand IDbDataAdapter.SelectCommand
		{
			get
			{
				return this._selectCommand;
			}
			set
			{
				this._selectCommand = (SqlCommand)value;
			}
		}

		/// <summary>Возвращает или задает инструкцию Transact-SQL или хранимую процедуру, используемую для обновления записей в источнике данных.</summary>
		/// <returns>
		///   <see cref="T:System.Data.SqlClient.SqlCommand" /> используется в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для обновления записей в базе данных, соответствующих измененным строкам в <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x0006A787 File Offset: 0x00068987
		// (set) Token: 0x06001798 RID: 6040 RVA: 0x0006A78F File Offset: 0x0006898F
		public new SqlCommand UpdateCommand
		{
			get
			{
				return this._updateCommand;
			}
			set
			{
				this._updateCommand = value;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.UpdateCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x0006A787 File Offset: 0x00068987
		// (set) Token: 0x0600179A RID: 6042 RVA: 0x0006A798 File Offset: 0x00068998
		IDbCommand IDbDataAdapter.UpdateCommand
		{
			get
			{
				return this._updateCommand;
			}
			set
			{
				this._updateCommand = (SqlCommand)value;
			}
		}

		/// <summary>Возвращает или задает число строк, обработанных при каждом обращении к серверу.</summary>
		/// <returns>Количество строк, которые необходимо обработать с помощью одного пакета.  
		///   Значение 
		///   Действие 
		///   0 
		///   Размер пакета не ограничен. 
		///
		///   1 
		///   Отключает пакетное обновление.  
		///
		///   &gt;1 
		///   Изменения отправляются с помощью пакетов, единовременное количество операций в которых определяется свойством <see cref="P:System.Data.SqlClient.SqlDataAdapter.UpdateBatchSize" />.  
		///
		///
		///
		///  Если для этого параметра значение, отличное от 1, все команды, связанные с <see cref="T:System.Data.SqlClient.SqlDataAdapter" /> обязательно иметь их UpdatedRowSource свойство значение <see langword="None" /> или <see langword="OutputParameters" />. В противном случае возникает исключение.</returns>
		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x0006A7A6 File Offset: 0x000689A6
		// (set) Token: 0x0600179C RID: 6044 RVA: 0x0006A7AE File Offset: 0x000689AE
		public override int UpdateBatchSize
		{
			get
			{
				return this._updateBatchSize;
			}
			set
			{
				if (0 > value)
				{
					throw ADP.ArgumentOutOfRange("UpdateBatchSize");
				}
				this._updateBatchSize = value;
			}
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0006A7C6 File Offset: 0x000689C6
		protected override int AddToBatch(IDbCommand command)
		{
			int commandCount = this._commandSet.CommandCount;
			this._commandSet.Append((SqlCommand)command);
			return commandCount;
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0006A7E4 File Offset: 0x000689E4
		protected override void ClearBatch()
		{
			this._commandSet.Clear();
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0006A7F1 File Offset: 0x000689F1
		protected override int ExecuteBatch()
		{
			return this._commandSet.ExecuteNonQuery();
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0006A7FE File Offset: 0x000689FE
		protected override IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex)
		{
			return this._commandSet.GetParameter(commandIdentifier, parameterIndex);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0006A80D File Offset: 0x00068A0D
		protected override bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out Exception error)
		{
			return this._commandSet.GetBatchedAffected(commandIdentifier, out recordsAffected, out error);
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0006A820 File Offset: 0x00068A20
		protected override void InitializeBatching()
		{
			this._commandSet = new SqlCommandSet();
			SqlCommand sqlCommand = this.SelectCommand;
			if (sqlCommand == null)
			{
				sqlCommand = this.InsertCommand;
				if (sqlCommand == null)
				{
					sqlCommand = this.UpdateCommand;
					if (sqlCommand == null)
					{
						sqlCommand = this.DeleteCommand;
					}
				}
			}
			if (sqlCommand != null)
			{
				this._commandSet.Connection = sqlCommand.Connection;
				this._commandSet.Transaction = sqlCommand.Transaction;
				this._commandSet.CommandTimeout = sqlCommand.CommandTimeout;
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0006A893 File Offset: 0x00068A93
		protected override void TerminateBatching()
		{
			if (this._commandSet != null)
			{
				this._commandSet.Dispose();
				this._commandSet = null;
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект, который является копией текущего экземпляра.</returns>
		// Token: 0x060017A4 RID: 6052 RVA: 0x0006A8AF File Offset: 0x00068AAF
		object ICloneable.Clone()
		{
			return new SqlDataAdapter(this);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0006A8B7 File Offset: 0x00068AB7
		protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new SqlRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x0006A8C3 File Offset: 0x00068AC3
		protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new SqlRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
		}

		/// <summary>Происходит во время <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> после выполнения команды для источника данных. Сделана попытка обновления, поэтому создается событие.</summary>
		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060017A7 RID: 6055 RVA: 0x0006A8CF File Offset: 0x00068ACF
		// (remove) Token: 0x060017A8 RID: 6056 RVA: 0x0006A8E2 File Offset: 0x00068AE2
		public event SqlRowUpdatedEventHandler RowUpdated
		{
			add
			{
				base.Events.AddHandler(SqlDataAdapter.EventRowUpdated, value);
			}
			remove
			{
				base.Events.RemoveHandler(SqlDataAdapter.EventRowUpdated, value);
			}
		}

		/// <summary>Происходит во время <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> перед выполнением команды в отношении источника данных. Сделана попытка обновления, поэтому создается событие.</summary>
		// Token: 0x14000027 RID: 39
		// (add) Token: 0x060017A9 RID: 6057 RVA: 0x0006A8F8 File Offset: 0x00068AF8
		// (remove) Token: 0x060017AA RID: 6058 RVA: 0x0006A95C File Offset: 0x00068B5C
		public event SqlRowUpdatingEventHandler RowUpdating
		{
			add
			{
				SqlRowUpdatingEventHandler sqlRowUpdatingEventHandler = (SqlRowUpdatingEventHandler)base.Events[SqlDataAdapter.EventRowUpdating];
				if (sqlRowUpdatingEventHandler != null && value.Target is DbCommandBuilder)
				{
					SqlRowUpdatingEventHandler sqlRowUpdatingEventHandler2 = (SqlRowUpdatingEventHandler)ADP.FindBuilder(sqlRowUpdatingEventHandler);
					if (sqlRowUpdatingEventHandler2 != null)
					{
						base.Events.RemoveHandler(SqlDataAdapter.EventRowUpdating, sqlRowUpdatingEventHandler2);
					}
				}
				base.Events.AddHandler(SqlDataAdapter.EventRowUpdating, value);
			}
			remove
			{
				base.Events.RemoveHandler(SqlDataAdapter.EventRowUpdating, value);
			}
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0006A970 File Offset: 0x00068B70
		protected override void OnRowUpdated(RowUpdatedEventArgs value)
		{
			SqlRowUpdatedEventHandler sqlRowUpdatedEventHandler = (SqlRowUpdatedEventHandler)base.Events[SqlDataAdapter.EventRowUpdated];
			if (sqlRowUpdatedEventHandler != null && value is SqlRowUpdatedEventArgs)
			{
				sqlRowUpdatedEventHandler(this, (SqlRowUpdatedEventArgs)value);
			}
			base.OnRowUpdated(value);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0006A9B4 File Offset: 0x00068BB4
		protected override void OnRowUpdating(RowUpdatingEventArgs value)
		{
			SqlRowUpdatingEventHandler sqlRowUpdatingEventHandler = (SqlRowUpdatingEventHandler)base.Events[SqlDataAdapter.EventRowUpdating];
			if (sqlRowUpdatingEventHandler != null && value is SqlRowUpdatingEventArgs)
			{
				sqlRowUpdatingEventHandler(this, (SqlRowUpdatingEventArgs)value);
			}
			base.OnRowUpdating(value);
		}

		// Token: 0x04000F2C RID: 3884
		private static readonly object EventRowUpdated = new object();

		// Token: 0x04000F2D RID: 3885
		private static readonly object EventRowUpdating = new object();

		// Token: 0x04000F2E RID: 3886
		private SqlCommand _deleteCommand;

		// Token: 0x04000F2F RID: 3887
		private SqlCommand _insertCommand;

		// Token: 0x04000F30 RID: 3888
		private SqlCommand _selectCommand;

		// Token: 0x04000F31 RID: 3889
		private SqlCommand _updateCommand;

		// Token: 0x04000F32 RID: 3890
		private SqlCommandSet _commandSet;

		// Token: 0x04000F33 RID: 3891
		private int _updateBatchSize = 1;
	}
}
