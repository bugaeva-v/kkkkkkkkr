using System;
using System.Data.Common;

namespace System.Data.Odbc
{
	/// <summary>Представляет набор команд данных и подключение к базе данных, которые используются для заполнения <see cref="T:System.Data.DataSet" /> и обновления источника данных. Этот класс не наследуется.</summary>
	// Token: 0x020002E0 RID: 736
	public sealed class OdbcDataAdapter : DbDataAdapter, IDbDataAdapter, IDataAdapter, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</summary>
		// Token: 0x06002071 RID: 8305 RVA: 0x000970DE File Offset: 0x000952DE
		public OdbcDataAdapter()
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcDataAdapter" /> с заданным оператором SQL SELECT.</summary>
		/// <param name="selectCommand">Объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который является оператором SQL SELECT или хранимой процедурой и задается как свойство <see cref="P:System.Data.Odbc.OdbcDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</param>
		// Token: 0x06002072 RID: 8306 RVA: 0x000970EC File Offset: 0x000952EC
		public OdbcDataAdapter(OdbcCommand selectCommand) : this()
		{
			this.SelectCommand = selectCommand;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcDataAdapter" /> с оператором SQL SELECT и объектом <see cref="T:System.Data.Odbc.OdbcConnection" />.</summary>
		/// <param name="selectCommandText">Строка, представляющая собой оператор SQL SELECT или хранимую процедуру, используемую в свойстве <see cref="P:System.Data.Odbc.OdbcDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</param>
		/// <param name="selectConnection">
		///   <see cref="T:System.Data.Odbc.OdbcConnection" /> представляет подключение.</param>
		// Token: 0x06002073 RID: 8307 RVA: 0x000970FB File Offset: 0x000952FB
		public OdbcDataAdapter(string selectCommandText, OdbcConnection selectConnection) : this()
		{
			this.SelectCommand = new OdbcCommand(selectCommandText, selectConnection);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcDataAdapter" /> с оператором SQL SELECT и строкой подключения.</summary>
		/// <param name="selectCommandText">Строка, представляющая собой оператор SQL SELECT или хранимую процедуру, используемую в свойстве <see cref="P:System.Data.Odbc.OdbcDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</param>
		/// <param name="selectConnectionString">Строка подключения.</param>
		// Token: 0x06002074 RID: 8308 RVA: 0x00097110 File Offset: 0x00095310
		public OdbcDataAdapter(string selectCommandText, string selectConnectionString) : this()
		{
			OdbcConnection connection = new OdbcConnection(selectConnectionString);
			this.SelectCommand = new OdbcCommand(selectCommandText, connection);
		}

		// Token: 0x06002075 RID: 8309 RVA: 0x00097137 File Offset: 0x00095337
		private OdbcDataAdapter(OdbcDataAdapter from) : base(from)
		{
			GC.SuppressFinalize(this);
		}

		/// <summary>Возвращает или задает оператор SQL или хранимую процедуру, используемую для удаления записей в источнике данных.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcCommand" />, используемый во время операции обновления для удаления тех записей в источнике данных, которые соответствуют удаленным строкам в объекте <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x00097146 File Offset: 0x00095346
		// (set) Token: 0x06002077 RID: 8311 RVA: 0x0009714E File Offset: 0x0009534E
		public new OdbcCommand DeleteCommand
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
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для удаления записей в источнике данных, соответствующих удаленным строкам в наборе данных.</returns>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x00097146 File Offset: 0x00095346
		// (set) Token: 0x06002079 RID: 8313 RVA: 0x00097157 File Offset: 0x00095357
		IDbCommand IDbDataAdapter.DeleteCommand
		{
			get
			{
				return this._deleteCommand;
			}
			set
			{
				this._deleteCommand = (OdbcCommand)value;
			}
		}

		/// <summary>Возвращает или задает инструкцию либо хранимую процедуру SQL, используемую для вставки записей в источнике данных.</summary>
		/// <returns>Параметр <see cref="T:System.Data.Odbc.OdbcCommand" />, используемый в ходе операции вставки записей в источнике данных в соответствии с новыми строками в <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x00097165 File Offset: 0x00095365
		// (set) Token: 0x0600207B RID: 8315 RVA: 0x0009716D File Offset: 0x0009536D
		public new OdbcCommand InsertCommand
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
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для вставки записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x00097165 File Offset: 0x00095365
		// (set) Token: 0x0600207D RID: 8317 RVA: 0x00097176 File Offset: 0x00095376
		IDbCommand IDbDataAdapter.InsertCommand
		{
			get
			{
				return this._insertCommand;
			}
			set
			{
				this._insertCommand = (OdbcCommand)value;
			}
		}

		/// <summary>Возвращает или задает оператор SQL или хранимую процедуру для выборки записей в источнике данных.</summary>
		/// <returns>Объект <see cref="T:System.Data.Odbc.OdbcCommand" />, который используется во время операции заполнения для выбора записей из источника данных с целью их размещения в объекте <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x00097184 File Offset: 0x00095384
		// (set) Token: 0x0600207F RID: 8319 RVA: 0x0009718C File Offset: 0x0009538C
		public new OdbcCommand SelectCommand
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
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06002080 RID: 8320 RVA: 0x00097184 File Offset: 0x00095384
		// (set) Token: 0x06002081 RID: 8321 RVA: 0x00097195 File Offset: 0x00095395
		IDbCommand IDbDataAdapter.SelectCommand
		{
			get
			{
				return this._selectCommand;
			}
			set
			{
				this._selectCommand = (OdbcCommand)value;
			}
		}

		/// <summary>Возвращает или задает инструкцию SQL либо хранимую процедуру (используется для обновления записей в источнике данных).</summary>
		/// <returns>
		///   <see cref="T:System.Data.Odbc.OdbcCommand" /> — используется в ходе операции обновления записей в источнике данных в соответствии с измененными строками в <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x000971A3 File Offset: 0x000953A3
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x000971AB File Offset: 0x000953AB
		public new OdbcCommand UpdateCommand
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
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x000971A3 File Offset: 0x000953A3
		// (set) Token: 0x06002085 RID: 8325 RVA: 0x000971B4 File Offset: 0x000953B4
		IDbCommand IDbDataAdapter.UpdateCommand
		{
			get
			{
				return this._updateCommand;
			}
			set
			{
				this._updateCommand = (OdbcCommand)value;
			}
		}

		/// <summary>Происходит во время операции обновления после выполнения команды в отношении источника данных.</summary>
		// Token: 0x1400002A RID: 42
		// (add) Token: 0x06002086 RID: 8326 RVA: 0x000971C2 File Offset: 0x000953C2
		// (remove) Token: 0x06002087 RID: 8327 RVA: 0x000971D5 File Offset: 0x000953D5
		public event OdbcRowUpdatedEventHandler RowUpdated
		{
			add
			{
				base.Events.AddHandler(OdbcDataAdapter.s_eventRowUpdated, value);
			}
			remove
			{
				base.Events.RemoveHandler(OdbcDataAdapter.s_eventRowUpdated, value);
			}
		}

		/// <summary>Происходит во время <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> перед выполнением команды в отношении источника данных.</summary>
		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06002088 RID: 8328 RVA: 0x000971E8 File Offset: 0x000953E8
		// (remove) Token: 0x06002089 RID: 8329 RVA: 0x0009724C File Offset: 0x0009544C
		public event OdbcRowUpdatingEventHandler RowUpdating
		{
			add
			{
				OdbcRowUpdatingEventHandler odbcRowUpdatingEventHandler = (OdbcRowUpdatingEventHandler)base.Events[OdbcDataAdapter.s_eventRowUpdating];
				if (odbcRowUpdatingEventHandler != null && value.Target is OdbcCommandBuilder)
				{
					OdbcRowUpdatingEventHandler odbcRowUpdatingEventHandler2 = (OdbcRowUpdatingEventHandler)ADP.FindBuilder(odbcRowUpdatingEventHandler);
					if (odbcRowUpdatingEventHandler2 != null)
					{
						base.Events.RemoveHandler(OdbcDataAdapter.s_eventRowUpdating, odbcRowUpdatingEventHandler2);
					}
				}
				base.Events.AddHandler(OdbcDataAdapter.s_eventRowUpdating, value);
			}
			remove
			{
				base.Events.RemoveHandler(OdbcDataAdapter.s_eventRowUpdating, value);
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x0600208A RID: 8330 RVA: 0x0009725F File Offset: 0x0009545F
		object ICloneable.Clone()
		{
			return new OdbcDataAdapter(this);
		}

		// Token: 0x0600208B RID: 8331 RVA: 0x00097267 File Offset: 0x00095467
		protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new OdbcRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
		}

		// Token: 0x0600208C RID: 8332 RVA: 0x00097273 File Offset: 0x00095473
		protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new OdbcRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
		}

		// Token: 0x0600208D RID: 8333 RVA: 0x00097280 File Offset: 0x00095480
		protected override void OnRowUpdated(RowUpdatedEventArgs value)
		{
			OdbcRowUpdatedEventHandler odbcRowUpdatedEventHandler = (OdbcRowUpdatedEventHandler)base.Events[OdbcDataAdapter.s_eventRowUpdated];
			if (odbcRowUpdatedEventHandler != null && value is OdbcRowUpdatedEventArgs)
			{
				odbcRowUpdatedEventHandler(this, (OdbcRowUpdatedEventArgs)value);
			}
			base.OnRowUpdated(value);
		}

		// Token: 0x0600208E RID: 8334 RVA: 0x000972C4 File Offset: 0x000954C4
		protected override void OnRowUpdating(RowUpdatingEventArgs value)
		{
			OdbcRowUpdatingEventHandler odbcRowUpdatingEventHandler = (OdbcRowUpdatingEventHandler)base.Events[OdbcDataAdapter.s_eventRowUpdating];
			if (odbcRowUpdatingEventHandler != null && value is OdbcRowUpdatingEventArgs)
			{
				odbcRowUpdatingEventHandler(this, (OdbcRowUpdatingEventArgs)value);
			}
			base.OnRowUpdating(value);
		}

		// Token: 0x0400177F RID: 6015
		private static readonly object s_eventRowUpdated = new object();

		// Token: 0x04001780 RID: 6016
		private static readonly object s_eventRowUpdating = new object();

		// Token: 0x04001781 RID: 6017
		private OdbcCommand _deleteCommand;

		// Token: 0x04001782 RID: 6018
		private OdbcCommand _insertCommand;

		// Token: 0x04001783 RID: 6019
		private OdbcCommand _selectCommand;

		// Token: 0x04001784 RID: 6020
		private OdbcCommand _updateCommand;
	}
}
