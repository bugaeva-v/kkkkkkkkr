using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.ProviderBase;

namespace System.Data.Common
{
	/// <summary>Помогает в реализации интерфейса <see cref="T:System.Data.IDbDataAdapter" />. Разработчики производных классов <see cref="T:System.Data.Common.DbDataAdapter" /> реализуют набор функций, обеспечивающий строгую типизацию, но наследуют большинство функций, необходимых для полной реализации DataAdapter.</summary>
	// Token: 0x02000390 RID: 912
	public abstract class DbDataAdapter : DataAdapter, IDbDataAdapter, IDataAdapter, ICloneable
	{
		/// <summary>Инициализирует новый экземпляр класса DataAdapter.</summary>
		// Token: 0x06002BEE RID: 11246 RVA: 0x000B89D2 File Offset: 0x000B6BD2
		protected DbDataAdapter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see langword="DataAdapter" /> из существующего объекта того же типа.</summary>
		/// <param name="adapter">Объект <see langword="DataAdapter" /> используется для создания нового <see langword="DataAdapter" />.</param>
		// Token: 0x06002BEF RID: 11247 RVA: 0x000BCA05 File Offset: 0x000BAC05
		protected DbDataAdapter(DbDataAdapter adapter) : base(adapter)
		{
			this.CloneFrom(adapter);
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x00005696 File Offset: 0x00003896
		private IDbDataAdapter _IDbDataAdapter
		{
			get
			{
				return this;
			}
		}

		/// <summary>Возвращает или задает команду для удаления записей из набора данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> для удаления записей в источнике данных, соответствующих удаленным строкам в наборе данных.</returns>
		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06002BF1 RID: 11249 RVA: 0x000BCA15 File Offset: 0x000BAC15
		// (set) Token: 0x06002BF2 RID: 11250 RVA: 0x000BCA27 File Offset: 0x000BAC27
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DbCommand DeleteCommand
		{
			get
			{
				return (DbCommand)this._IDbDataAdapter.DeleteCommand;
			}
			set
			{
				this._IDbDataAdapter.DeleteCommand = value;
			}
		}

		/// <summary>Возвращает или задает оператор SQL для удаления записей из набора данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для удаления записей в источнике данных, соответствующих удаленным строкам в наборе данных.</returns>
		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06002BF3 RID: 11251 RVA: 0x000BCA35 File Offset: 0x000BAC35
		// (set) Token: 0x06002BF4 RID: 11252 RVA: 0x000BCA3D File Offset: 0x000BAC3D
		IDbCommand IDbDataAdapter.DeleteCommand
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

		/// <summary>Возвращает или задает реакцию команды, использованной для заполнения адаптера данных.</summary>
		/// <returns>Значение типа <see cref="T:System.Data.CommandBehavior" /> команды, использованной для заполнения адаптера данных.</returns>
		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06002BF5 RID: 11253 RVA: 0x000BCA46 File Offset: 0x000BAC46
		// (set) Token: 0x06002BF6 RID: 11254 RVA: 0x000BCA51 File Offset: 0x000BAC51
		protected internal CommandBehavior FillCommandBehavior
		{
			get
			{
				return this._fillCommandBehavior | CommandBehavior.SequentialAccess;
			}
			set
			{
				this._fillCommandBehavior = (value | CommandBehavior.SequentialAccess);
			}
		}

		/// <summary>Возвращает или задает команду SQL для вставки новых записей в источник данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> для вставки записей в источник данных, соответствующих новым строкам в наборе данных.</returns>
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06002BF7 RID: 11255 RVA: 0x000BCA5D File Offset: 0x000BAC5D
		// (set) Token: 0x06002BF8 RID: 11256 RVA: 0x000BCA6F File Offset: 0x000BAC6F
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DbCommand InsertCommand
		{
			get
			{
				return (DbCommand)this._IDbDataAdapter.InsertCommand;
			}
			set
			{
				this._IDbDataAdapter.InsertCommand = value;
			}
		}

		/// <summary>Возвращает или задает оператор SQL для вставки новых записей в источник данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для вставки записей в источник данных, соответствующих новым строкам в наборе данных.</returns>
		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06002BF9 RID: 11257 RVA: 0x000BCA7D File Offset: 0x000BAC7D
		// (set) Token: 0x06002BFA RID: 11258 RVA: 0x000BCA85 File Offset: 0x000BAC85
		IDbCommand IDbDataAdapter.InsertCommand
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

		/// <summary>Возвращает или задает команду, используемую для выбора записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06002BFB RID: 11259 RVA: 0x000BCA8E File Offset: 0x000BAC8E
		// (set) Token: 0x06002BFC RID: 11260 RVA: 0x000BCAA0 File Offset: 0x000BACA0
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DbCommand SelectCommand
		{
			get
			{
				return (DbCommand)this._IDbDataAdapter.SelectCommand;
			}
			set
			{
				this._IDbDataAdapter.SelectCommand = value;
			}
		}

		/// <summary>Возвращает или задает оператор SQL для выбора записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06002BFD RID: 11261 RVA: 0x000BCAAE File Offset: 0x000BACAE
		// (set) Token: 0x06002BFE RID: 11262 RVA: 0x000BCAB6 File Offset: 0x000BACB6
		IDbCommand IDbDataAdapter.SelectCommand
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

		/// <summary>Возвращает или задает значение, которое включает или отключает поддержку пакетной обработки и задает количество команд, которые могут выполняться в рамках одного пакета.</summary>
		/// <returns>Количество строк, которые необходимо обработать с помощью одного пакета.  
		///   Значение 
		///   Действие 
		///   0 
		///   Размер пакета не ограничен.  
		///
		///   1 
		///   Отключает пакетное обновление.  
		///
		///   &gt; 1 
		///   Изменения отправляются с помощью пакетов, единовременное количество операций в которых определяется свойством <see cref="P:System.Data.Common.DbDataAdapter.UpdateBatchSize" />.  
		///
		///
		///
		///  Если для этого параметра значение, отличное от 1, все команды, связанные с <see cref="T:System.Data.Common.DbDataAdapter" /> должен иметь их <see cref="P:System.Data.IDbCommand.UpdatedRowSource" /> свойство значение None или OutputParameters. В противном случае будет выдаваться исключение.</returns>
		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06002BFF RID: 11263 RVA: 0x00006D61 File Offset: 0x00004F61
		// (set) Token: 0x06002C00 RID: 11264 RVA: 0x000BCABF File Offset: 0x000BACBF
		[DefaultValue(1)]
		public virtual int UpdateBatchSize
		{
			get
			{
				return 1;
			}
			set
			{
				if (1 != value)
				{
					throw ADP.NotSupported();
				}
			}
		}

		/// <summary>Возвращает или задает команду, используемую для обновления записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" /> для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06002C01 RID: 11265 RVA: 0x000BCACB File Offset: 0x000BACCB
		// (set) Token: 0x06002C02 RID: 11266 RVA: 0x000BCADD File Offset: 0x000BACDD
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public DbCommand UpdateCommand
		{
			get
			{
				return (DbCommand)this._IDbDataAdapter.UpdateCommand;
			}
			set
			{
				this._IDbDataAdapter.UpdateCommand = value;
			}
		}

		/// <summary>Возвращает или задает оператор SQL для обновления записей в источнике данных.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время применения метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000BCAEB File Offset: 0x000BACEB
		// (set) Token: 0x06002C04 RID: 11268 RVA: 0x000BCAF3 File Offset: 0x000BACF3
		IDbCommand IDbDataAdapter.UpdateCommand
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

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06002C05 RID: 11269 RVA: 0x000BCAFC File Offset: 0x000BACFC
		private MissingMappingAction UpdateMappingAction
		{
			get
			{
				if (MissingMappingAction.Passthrough == base.MissingMappingAction)
				{
					return MissingMappingAction.Passthrough;
				}
				return MissingMappingAction.Error;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06002C06 RID: 11270 RVA: 0x000BCB0C File Offset: 0x000BAD0C
		private MissingSchemaAction UpdateSchemaAction
		{
			get
			{
				MissingSchemaAction missingSchemaAction = base.MissingSchemaAction;
				if (MissingSchemaAction.Add == missingSchemaAction || MissingSchemaAction.AddWithKey == missingSchemaAction)
				{
					return MissingSchemaAction.Ignore;
				}
				return MissingSchemaAction.Error;
			}
		}

		/// <summary>Добавляет интерфейс <see cref="T:System.Data.IDbCommand" /> к текущему пакету.</summary>
		/// <param name="command">Интерфейс <see cref="T:System.Data.IDbCommand" />, добавляемый к пакету.</param>
		/// <returns>Число команд в пакете, имевшееся до добавления интерфейса <see cref="T:System.Data.IDbCommand" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Адаптер не поддерживает пакеты.</exception>
		// Token: 0x06002C07 RID: 11271 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual int AddToBatch(IDbCommand command)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Удаляет все объекты <see cref="T:System.Data.IDbCommand" /> из пакета.</summary>
		/// <exception cref="T:System.NotSupportedException">Адаптер не поддерживает пакеты.</exception>
		// Token: 0x06002C08 RID: 11272 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual void ClearBatch()
		{
			throw ADP.NotSupported();
		}

		/// <summary>Создает новый объект, являющийся копией текущего экземпляра.</summary>
		/// <returns>Новый объект, являющийся копией этого экземпляра.</returns>
		// Token: 0x06002C09 RID: 11273 RVA: 0x000BCB2B File Offset: 0x000BAD2B
		object ICloneable.Clone()
		{
			DbDataAdapter dbDataAdapter = (DbDataAdapter)this.CloneInternals();
			dbDataAdapter.CloneFrom(this);
			return dbDataAdapter;
		}

		// Token: 0x06002C0A RID: 11274 RVA: 0x000BCB40 File Offset: 0x000BAD40
		private void CloneFrom(DbDataAdapter from)
		{
			IDbDataAdapter idbDataAdapter = from._IDbDataAdapter;
			this._IDbDataAdapter.SelectCommand = this.CloneCommand(idbDataAdapter.SelectCommand);
			this._IDbDataAdapter.InsertCommand = this.CloneCommand(idbDataAdapter.InsertCommand);
			this._IDbDataAdapter.UpdateCommand = this.CloneCommand(idbDataAdapter.UpdateCommand);
			this._IDbDataAdapter.DeleteCommand = this.CloneCommand(idbDataAdapter.DeleteCommand);
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000BCBB0 File Offset: 0x000BADB0
		private IDbCommand CloneCommand(IDbCommand command)
		{
			return (IDbCommand)((command is ICloneable) ? ((ICloneable)command).Clone() : null);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.RowUpdatedEventArgs" />.</summary>
		/// <param name="dataRow">Объект <see cref="T:System.Data.DataRow" />, использованный для обновления источника данных.</param>
		/// <param name="command">Интерфейс <see cref="T:System.Data.IDbCommand" /> выполняется во время использования метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Является ли команда оператором UPDATE, INSERT, DELETE или SELECT.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.RowUpdatedEventArgs" />.</returns>
		// Token: 0x06002C0C RID: 11276 RVA: 0x000BCBCD File Offset: 0x000BADCD
		protected virtual RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new RowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.RowUpdatingEventArgs" />.</summary>
		/// <param name="dataRow">Объект <see cref="T:System.Data.DataRow" />, который обновляет источник данных.</param>
		/// <param name="command">Интерфейс <see cref="T:System.Data.IDbCommand" /> для выполнения при применении метода <see cref="M:System.Data.IDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Является ли команда оператором UPDATE, INSERT, DELETE или SELECT.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" />.</param>
		/// <returns>Новый экземпляр класса <see cref="T:System.Data.Common.RowUpdatingEventArgs" />.</returns>
		// Token: 0x06002C0D RID: 11277 RVA: 0x000BCBD9 File Offset: 0x000BADD9
		protected virtual RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			return new RowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
		}

		/// <summary>Освобождает неуправляемые ресурсы, используемые объектом <see cref="T:System.Data.Common.DbDataAdapter" />, а при необходимости освобождает также управляемые ресурсы.</summary>
		/// <param name="disposing">Значение <see langword="true" /> позволяет освободить как управляемые, так и неуправляемые ресурсы; значение <see langword="false" /> освобождает только неуправляемые ресурсы.</param>
		// Token: 0x06002C0E RID: 11278 RVA: 0x000BCBE5 File Offset: 0x000BADE5
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				((IDbDataAdapter)this).SelectCommand = null;
				((IDbDataAdapter)this).InsertCommand = null;
				((IDbDataAdapter)this).UpdateCommand = null;
				((IDbDataAdapter)this).DeleteCommand = null;
			}
			base.Dispose(disposing);
		}

		/// <summary>Выполняет текущий пакет.</summary>
		/// <returns>Возвращает значение из последней команды в пакете.</returns>
		// Token: 0x06002C0F RID: 11279 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual int ExecuteBatch()
		{
			throw ADP.NotSupported();
		}

		/// <summary>Настраивает схему указанного объекта <see cref="T:System.Data.DataTable" /> на основе указанного <see cref="T:System.Data.SchemaType" />.</summary>
		/// <param name="dataTable">Объект <see cref="T:System.Data.DataTable" /> для заполнения схемой из источника данных.</param>
		/// <param name="schemaType">Одно из значений <see cref="T:System.Data.SchemaType" />.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" />, содержащий сведения о схеме, возвращенные из источника данных.</returns>
		// Token: 0x06002C10 RID: 11280 RVA: 0x000BCC10 File Offset: 0x000BAE10
		public DataTable FillSchema(DataTable dataTable, SchemaType schemaType)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, SchemaType>("<comm.DbDataAdapter.FillSchema|API> {0}, dataTable, schemaType={1}", base.ObjectID, schemaType);
			DataTable result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.FillSchema(dataTable, schemaType, selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.DataTable" /> с именем Table в указанный объект <see cref="T:System.Data.DataSet" /> и настраивает схему для соответствия этому объекту в источнике данных на основе указанного значения типа <see cref="T:System.Data.SchemaType" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, куда вставляется схема.</param>
		/// <param name="schemaType">Одно из значений <see cref="T:System.Data.SchemaType" />, указывающее, как следует вставлять схему.</param>
		/// <returns>Ссылка на коллекцию объектов <see cref="T:System.Data.DataTable" />, которые были добавлены в <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x06002C11 RID: 11281 RVA: 0x000BCC74 File Offset: 0x000BAE74
		public override DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, SchemaType>("<comm.DbDataAdapter.FillSchema|API> {0}, dataSet, schemaType={1}", base.ObjectID, schemaType);
			DataTable[] result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				if (base.DesignMode && (selectCommand == null || selectCommand.Connection == null || string.IsNullOrEmpty(selectCommand.CommandText)))
				{
					result = Array.Empty<DataTable>();
				}
				else
				{
					CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
					result = this.FillSchema(dataSet, schemaType, selectCommand, "Table", fillCommandBehavior);
				}
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.DataTable" /> в указанный объект <see cref="T:System.Data.DataSet" /> и настраивает схему для соответствия этому объекту в источнике данных на основе указанных <see cref="T:System.Data.SchemaType" /> и <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, куда вставляется схема.</param>
		/// <param name="schemaType">Одно из значений <see cref="T:System.Data.SchemaType" />, указывающее, как следует вставлять схему.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <returns>Ссылка на коллекцию объектов <see cref="T:System.Data.DataTable" />, которые были добавлены в <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.ArgumentException">Не удалось найти исходную таблицу для получения схемы.</exception>
		// Token: 0x06002C12 RID: 11282 RVA: 0x000BCD04 File Offset: 0x000BAF04
		public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType, string srcTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, string>("<comm.DbDataAdapter.FillSchema|API> {0}, dataSet, schemaType={1}, srcTable={2}", base.ObjectID, (int)schemaType, srcTable);
			DataTable[] result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.FillSchema(dataSet, schemaType, selectCommand, srcTable, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет объект <see cref="T:System.Data.DataTable" /> к указанному объекту <see cref="T:System.Data.DataSet" /> и настраивает схему в соответствии с источником данных, основанном на указанном значении типа <see cref="T:System.Data.SchemaType" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения схемой из источника данных.</param>
		/// <param name="schemaType">Одно из значений <see cref="T:System.Data.SchemaType" />.</param>
		/// <param name="command">Оператор SQL SELECT используется для извлечения строки из источника данных.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Массив объектов <see cref="T:System.Data.DataTable" />, который содержит сведения схемы, возвращенные из источника данных.</returns>
		// Token: 0x06002C13 RID: 11283 RVA: 0x000BCD68 File Offset: 0x000BAF68
		protected virtual DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType, IDbCommand command, string srcTable, CommandBehavior behavior)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, CommandBehavior>("<comm.DbDataAdapter.FillSchema|API> {0}, dataSet, schemaType, command, srcTable, behavior={1}", base.ObjectID, behavior);
			DataTable[] result;
			try
			{
				if (dataSet == null)
				{
					throw ADP.ArgumentNull("dataSet");
				}
				if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
				{
					throw ADP.InvalidSchemaType(schemaType);
				}
				if (string.IsNullOrEmpty(srcTable))
				{
					throw ADP.FillSchemaRequiresSourceTableName("srcTable");
				}
				if (command == null)
				{
					throw ADP.MissingSelectCommand("FillSchema");
				}
				result = (DataTable[])this.FillSchemaInternal(dataSet, null, schemaType, command, srcTable, behavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Настраивает схему для указанного объекта <see cref="T:System.Data.DataTable" />, основываясь на указанном значении типа <see cref="T:System.Data.SchemaType" />, командной строке и значениях типа <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="dataTable">Объект <see cref="T:System.Data.DataTable" /> для заполнения схемой из источника данных.</param>
		/// <param name="schemaType">Одно из значений <see cref="T:System.Data.SchemaType" />.</param>
		/// <param name="command">Оператор SQL SELECT используется для извлечения строки из источника данных.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Объект <see cref="T:System.Data.DataTable" /> содержит сведения схемы, возвращенные из источника данных.</returns>
		// Token: 0x06002C14 RID: 11284 RVA: 0x000BCE00 File Offset: 0x000BB000
		protected virtual DataTable FillSchema(DataTable dataTable, SchemaType schemaType, IDbCommand command, CommandBehavior behavior)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, CommandBehavior>("<comm.DbDataAdapter.FillSchema|API> {0}, dataTable, schemaType, command, behavior={1}", base.ObjectID, behavior);
			DataTable result;
			try
			{
				if (dataTable == null)
				{
					throw ADP.ArgumentNull("dataTable");
				}
				if (SchemaType.Source != schemaType && SchemaType.Mapped != schemaType)
				{
					throw ADP.InvalidSchemaType(schemaType);
				}
				if (command == null)
				{
					throw ADP.MissingSelectCommand("FillSchema");
				}
				string text = dataTable.TableName;
				int num = base.IndexOfDataSetTable(text);
				if (-1 != num)
				{
					text = base.TableMappings[num].SourceTable;
				}
				result = (DataTable)this.FillSchemaInternal(null, dataTable, schemaType, command, text, behavior | CommandBehavior.SingleResult);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000BCEAC File Offset: 0x000BB0AC
		private object FillSchemaInternal(DataSet dataset, DataTable datatable, SchemaType schemaType, IDbCommand command, string srcTable, CommandBehavior behavior)
		{
			object result = null;
			bool flag = command.Connection == null;
			try
			{
				IDbConnection connection = DbDataAdapter.GetConnection3(this, command, "FillSchema");
				ConnectionState originalState = ConnectionState.Open;
				try
				{
					DbDataAdapter.QuietOpen(connection, out originalState);
					using (IDataReader dataReader = command.ExecuteReader(behavior | CommandBehavior.SchemaOnly | CommandBehavior.KeyInfo))
					{
						if (datatable != null)
						{
							result = this.FillSchema(datatable, schemaType, dataReader);
						}
						else
						{
							result = this.FillSchema(dataset, schemaType, srcTable, dataReader);
						}
					}
				}
				finally
				{
					DbDataAdapter.QuietClose(connection, originalState);
				}
			}
			finally
			{
				if (flag)
				{
					command.Transaction = null;
					command.Connection = null;
				}
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в объекте <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		// Token: 0x06002C16 RID: 11286 RVA: 0x000BCF60 File Offset: 0x000BB160
		public override int Fill(DataSet dataSet)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbDataAdapter.Fill|API> {0}, dataSet", base.ObjectID);
			int result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.Fill(dataSet, 0, 0, "Table", selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в объекте <see cref="T:System.Data.DataSet" /> для получения соответствия строкам в источнике данных с помощью имен <see cref="T:System.Data.DataSet" /> и <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		/// <exception cref="T:System.SystemException">Исходная таблица является недопустимой.</exception>
		// Token: 0x06002C17 RID: 11287 RVA: 0x000BCFC8 File Offset: 0x000BB1C8
		public int Fill(DataSet dataSet, string srcTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<comm.DbDataAdapter.Fill|API> {0}, dataSet, srcTable='{1}'", base.ObjectID, srcTable);
			int result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.Fill(dataSet, 0, 0, srcTable, selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в указанном диапазоне в объект <see cref="T:System.Data.DataSet" /> для получения соответствия строкам в источнике данных с использованием имен <see cref="T:System.Data.DataSet" /> и <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="startRecord">Номер записи (с нуля), с которой необходимо начать.</param>
		/// <param name="maxRecords">Максимальное число извлекаемых записей.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		/// <exception cref="T:System.SystemException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.  
		/// -или- 
		/// Подключение является недопустимым.</exception>
		/// <exception cref="T:System.InvalidCastException">Не удалось найти подключение.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startRecord" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="maxRecords" /> меньше 0.</exception>
		// Token: 0x06002C18 RID: 11288 RVA: 0x000BD02C File Offset: 0x000BB22C
		public int Fill(DataSet dataSet, int startRecord, int maxRecords, string srcTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, int, string>("<comm.DbDataAdapter.Fill|API> {0}, dataSet, startRecord={1}, maxRecords={2}, srcTable='{3}'", base.ObjectID, startRecord, maxRecords, srcTable);
			int result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.Fill(dataSet, startRecord, maxRecords, srcTable, selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в указанном диапазоне в объект <see cref="T:System.Data.DataSet" /> для получения соответствия строкам в источнике данных с помощью имен <see cref="T:System.Data.DataSet" /> и исходной таблицы, командной строки и поведения команды.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="startRecord">Номер записи (с нуля), с которой необходимо начать.</param>
		/// <param name="maxRecords">Максимальное число извлекаемых записей.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <param name="command">Оператор SQL SELECT используется для извлечения строки из источника данных.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startRecord" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="maxRecords" /> меньше 0.</exception>
		// Token: 0x06002C19 RID: 11289 RVA: 0x000BD094 File Offset: 0x000BB294
		protected virtual int Fill(DataSet dataSet, int startRecord, int maxRecords, string srcTable, IDbCommand command, CommandBehavior behavior)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, CommandBehavior>("<comm.DbDataAdapter.Fill|API> {0}, dataSet, startRecord, maxRecords, srcTable, command, behavior={1}", base.ObjectID, behavior);
			int result;
			try
			{
				if (dataSet == null)
				{
					throw ADP.FillRequires("dataSet");
				}
				if (startRecord < 0)
				{
					throw ADP.InvalidStartRecord("startRecord", startRecord);
				}
				if (maxRecords < 0)
				{
					throw ADP.InvalidMaxRecords("maxRecords", maxRecords);
				}
				if (string.IsNullOrEmpty(srcTable))
				{
					throw ADP.FillRequiresSourceTableName("srcTable");
				}
				if (command == null)
				{
					throw ADP.MissingSelectCommand("Fill");
				}
				result = this.FillInternal(dataSet, null, startRecord, maxRecords, srcTable, command, behavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в указанном диапазоне в объект <see cref="T:System.Data.DataSet" /> для получения соответствия строкам в источнике данных с использованием имени <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataTable">Имя объекта <see cref="T:System.Data.DataTable" />, используемое для сопоставления таблицы.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		// Token: 0x06002C1A RID: 11290 RVA: 0x000BD13C File Offset: 0x000BB33C
		public int Fill(DataTable dataTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbDataAdapter.Fill|API> {0}, dataTable", base.ObjectID);
			int result;
			try
			{
				DataTable[] dataTables = new DataTable[]
				{
					dataTable
				};
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.Fill(dataTables, 0, 0, selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в объекте <see cref="T:System.Data.DataTable" /> для получения соответствия строкам в источнике данных, начиная с указанной записи и вплоть до заданного максимального количества получаемых записей.</summary>
		/// <param name="startRecord">Номер записи (с нуля), с которой необходимо начать.</param>
		/// <param name="maxRecords">Максимальное число извлекаемых записей.</param>
		/// <param name="dataTables">Объект <see cref="T:System.Data.DataTable" /> для заполнения из источника данных.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataTable" />. Это значение не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		// Token: 0x06002C1B RID: 11291 RVA: 0x000BD1AC File Offset: 0x000BB3AC
		public int Fill(int startRecord, int maxRecords, params DataTable[] dataTables)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, int, int>("<comm.DbDataAdapter.Fill|API> {0}, startRecord={1}, maxRecords={2}, dataTable[]", base.ObjectID, startRecord, maxRecords);
			int result;
			try
			{
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				CommandBehavior fillCommandBehavior = this.FillCommandBehavior;
				result = this.Fill(dataTables, startRecord, maxRecords, selectCommand, fillCommandBehavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в объекте <see cref="T:System.Data.DataTable" /> для получения соответствия строкам в источнике данных с помощью указанного объекта <see cref="T:System.Data.DataTable" />, интерфейса <see cref="T:System.Data.IDbCommand" /> и значения типа <see cref="T:System.Data.CommandBehavior" />.</summary>
		/// <param name="dataTable">Объект <see cref="T:System.Data.DataTable" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="command">Оператор SQL SELECT используется для извлечения строки из источника данных.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataTable" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		// Token: 0x06002C1C RID: 11292 RVA: 0x000BD210 File Offset: 0x000BB410
		protected virtual int Fill(DataTable dataTable, IDbCommand command, CommandBehavior behavior)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, CommandBehavior>("<comm.DbDataAdapter.Fill|API> {0}, dataTable, command, behavior={1}", base.ObjectID, behavior);
			int result;
			try
			{
				DataTable[] dataTables = new DataTable[]
				{
					dataTable
				};
				result = this.Fill(dataTables, 0, 0, command, behavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Добавляет или обновляет строки в указанном диапазоне в объект <see cref="T:System.Data.DataSet" /> для получения соответствия строкам в источнике данных с использованием имен <see cref="T:System.Data.DataSet" /> и <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataTables">Объект <see cref="T:System.Data.DataTable" /> для заполнения из источника данных.</param>
		/// <param name="startRecord">Номер записи (с нуля), с которой необходимо начать.</param>
		/// <param name="maxRecords">Максимальное число извлекаемых записей.</param>
		/// <param name="command">Интерфейс <see cref="T:System.Data.IDbCommand" />, исполняемый для заполнения объектов <see cref="T:System.Data.DataTable" />.</param>
		/// <param name="behavior">Одно из значений <see cref="T:System.Data.CommandBehavior" />.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в таблицах данных.</returns>
		/// <exception cref="T:System.SystemException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.  
		/// -или- 
		/// Подключение является недопустимым.</exception>
		/// <exception cref="T:System.InvalidCastException">Не удалось найти подключение.</exception>
		/// <exception cref="T:System.ArgumentException">Значение параметра <paramref name="startRecord" /> меньше 0.  
		/// -или- 
		/// Значение параметра <paramref name="maxRecords" /> меньше 0.</exception>
		// Token: 0x06002C1D RID: 11293 RVA: 0x000BD26C File Offset: 0x000BB46C
		protected virtual int Fill(DataTable[] dataTables, int startRecord, int maxRecords, IDbCommand command, CommandBehavior behavior)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, CommandBehavior>("<comm.DbDataAdapter.Fill|API> {0}, dataTables[], startRecord, maxRecords, command, behavior={1}", base.ObjectID, behavior);
			int result;
			try
			{
				if (dataTables == null || dataTables.Length == 0 || dataTables[0] == null)
				{
					throw ADP.FillRequires("dataTable");
				}
				if (startRecord < 0)
				{
					throw ADP.InvalidStartRecord("startRecord", startRecord);
				}
				if (maxRecords < 0)
				{
					throw ADP.InvalidMaxRecords("maxRecords", maxRecords);
				}
				if (1 < dataTables.Length && (startRecord != 0 || maxRecords != 0))
				{
					throw ADP.OnlyOneTableForStartRecordOrMaxRecords();
				}
				if (command == null)
				{
					throw ADP.MissingSelectCommand("Fill");
				}
				if (1 == dataTables.Length)
				{
					behavior |= CommandBehavior.SingleResult;
				}
				result = this.FillInternal(null, dataTables, startRecord, maxRecords, null, command, behavior);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000BD324 File Offset: 0x000BB524
		private int FillInternal(DataSet dataset, DataTable[] datatables, int startRecord, int maxRecords, string srcTable, IDbCommand command, CommandBehavior behavior)
		{
			int result = 0;
			bool flag = command.Connection == null;
			try
			{
				IDbConnection connection = DbDataAdapter.GetConnection3(this, command, "Fill");
				ConnectionState originalState = ConnectionState.Open;
				if (MissingSchemaAction.AddWithKey == base.MissingSchemaAction)
				{
					behavior |= CommandBehavior.KeyInfo;
				}
				try
				{
					DbDataAdapter.QuietOpen(connection, out originalState);
					behavior |= CommandBehavior.SequentialAccess;
					IDataReader dataReader = null;
					try
					{
						dataReader = command.ExecuteReader(behavior);
						if (datatables != null)
						{
							result = this.Fill(datatables, dataReader, startRecord, maxRecords);
						}
						else
						{
							result = this.Fill(dataset, srcTable, dataReader, startRecord, maxRecords);
						}
					}
					finally
					{
						if (dataReader != null)
						{
							dataReader.Dispose();
						}
					}
				}
				finally
				{
					DbDataAdapter.QuietClose(connection, originalState);
				}
			}
			finally
			{
				if (flag)
				{
					command.Transaction = null;
					command.Connection = null;
				}
			}
			return result;
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Data.IDataParameter" /> из одной из команд в текущем пакете.</summary>
		/// <param name="commandIdentifier">Индекс команды, из которой извлекается параметр.</param>
		/// <param name="parameterIndex">Индекс параметра внутри команды.</param>
		/// <returns>Указанный <see cref="T:System.Data.IDataParameter" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Адаптер не поддерживает пакеты.</exception>
		// Token: 0x06002C1F RID: 11295 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex)
		{
			throw ADP.NotSupported();
		}

		/// <summary>Возвращает сведения об отдельной попытке обновления в рамках большего по своему объему пакета обновления.</summary>
		/// <param name="commandIdentifier">Порядковый номер (с нуля) столбца отдельной команды в пакете.</param>
		/// <param name="recordsAffected">Количество строк в хранилище данных, на которые было оказано воздействие указанной командой в пакете.</param>
		/// <param name="error">Исключение <see cref="T:System.Exception" />, выданное при выполнении указанной команды. Возвращает значение <see langword="null" /> (<see langword="Nothing" /> в Visual Basic), если исключение не было выдано.</param>
		/// <returns>Сведения об отдельной попытке обновления в рамках большего по своему объему пакета обновления.</returns>
		// Token: 0x06002C20 RID: 11296 RVA: 0x000BD3F0 File Offset: 0x000BB5F0
		protected virtual bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out Exception error)
		{
			recordsAffected = 1;
			error = null;
			return true;
		}

		/// <summary>Получает параметры, заданные пользователем при выполнении оператора SQL SELECT.</summary>
		/// <returns>Массив объектов <see cref="T:System.Data.IDataParameter" /> содержит параметры, заданные пользователем.</returns>
		// Token: 0x06002C21 RID: 11297 RVA: 0x000BD3FC File Offset: 0x000BB5FC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public override IDataParameter[] GetFillParameters()
		{
			IDataParameter[] array = null;
			IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
			if (selectCommand != null)
			{
				IDataParameterCollection parameters = selectCommand.Parameters;
				if (parameters != null)
				{
					array = new IDataParameter[parameters.Count];
					parameters.CopyTo(array, 0);
				}
			}
			if (array == null)
			{
				array = Array.Empty<IDataParameter>();
			}
			return array;
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000BD444 File Offset: 0x000BB644
		internal DataTableMapping GetTableMapping(DataTable dataTable)
		{
			DataTableMapping dataTableMapping = null;
			int num = base.IndexOfDataSetTable(dataTable.TableName);
			if (-1 != num)
			{
				dataTableMapping = base.TableMappings[num];
			}
			if (dataTableMapping == null)
			{
				if (MissingMappingAction.Error == base.MissingMappingAction)
				{
					throw ADP.MissingTableMappingDestination(dataTable.TableName);
				}
				dataTableMapping = new DataTableMapping(dataTable.TableName, dataTable.TableName);
			}
			return dataTableMapping;
		}

		/// <summary>Инициализирует пакетную обработку для объекта <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Адаптер не поддерживает пакеты.</exception>
		// Token: 0x06002C23 RID: 11299 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual void InitializeBatching()
		{
			throw ADP.NotSupported();
		}

		/// <summary>Вызывает событие <see langword="RowUpdated" /> поставщика данных .NET Framework.</summary>
		/// <param name="value">Объект <see cref="T:System.Data.Common.RowUpdatedEventArgs" />, содержащий данные события.</param>
		// Token: 0x06002C24 RID: 11300 RVA: 0x00007EED File Offset: 0x000060ED
		protected virtual void OnRowUpdated(RowUpdatedEventArgs value)
		{
		}

		/// <summary>Вызывает событие <see langword="RowUpdating" /> поставщика данных .NET Framework.</summary>
		/// <param name="value">Объект класса <see cref="T:System.Data.Common.RowUpdatingEventArgs" />, содержащий данные события.</param>
		// Token: 0x06002C25 RID: 11301 RVA: 0x00007EED File Offset: 0x000060ED
		protected virtual void OnRowUpdating(RowUpdatingEventArgs value)
		{
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000BD49C File Offset: 0x000BB69C
		private void ParameterInput(IDataParameterCollection parameters, StatementType typeIndex, DataRow row, DataTableMapping mappings)
		{
			MissingMappingAction updateMappingAction = this.UpdateMappingAction;
			MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
			foreach (object obj in parameters)
			{
				IDataParameter dataParameter = (IDataParameter)obj;
				if (dataParameter != null && (ParameterDirection.Input & dataParameter.Direction) != (ParameterDirection)0)
				{
					string sourceColumn = dataParameter.SourceColumn;
					if (!string.IsNullOrEmpty(sourceColumn))
					{
						DataColumn dataColumn = mappings.GetDataColumn(sourceColumn, null, row.Table, updateMappingAction, updateSchemaAction);
						if (dataColumn != null)
						{
							DataRowVersion parameterSourceVersion = DbDataAdapter.GetParameterSourceVersion(typeIndex, dataParameter);
							dataParameter.Value = row[dataColumn, parameterSourceVersion];
						}
						else
						{
							dataParameter.Value = null;
						}
						DbParameter dbParameter = dataParameter as DbParameter;
						if (dbParameter != null && dbParameter.SourceColumnNullMapping)
						{
							dataParameter.Value = (ADP.IsNull(dataParameter.Value) ? DbDataAdapter.s_parameterValueNullValue : DbDataAdapter.s_parameterValueNonNullValue);
						}
					}
				}
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000BD590 File Offset: 0x000BB790
		private void ParameterOutput(IDataParameter parameter, DataRow row, DataTableMapping mappings, MissingMappingAction missingMapping, MissingSchemaAction missingSchema)
		{
			if ((ParameterDirection.Output & parameter.Direction) != (ParameterDirection)0)
			{
				object value = parameter.Value;
				if (value != null)
				{
					string sourceColumn = parameter.SourceColumn;
					if (!string.IsNullOrEmpty(sourceColumn))
					{
						DataColumn dataColumn = mappings.GetDataColumn(sourceColumn, null, row.Table, missingMapping, missingSchema);
						if (dataColumn != null)
						{
							if (dataColumn.ReadOnly)
							{
								try
								{
									dataColumn.ReadOnly = false;
									row[dataColumn] = value;
									return;
								}
								finally
								{
									dataColumn.ReadOnly = true;
								}
							}
							row[dataColumn] = value;
						}
					}
				}
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000BD610 File Offset: 0x000BB810
		private void ParameterOutput(IDataParameterCollection parameters, DataRow row, DataTableMapping mappings)
		{
			MissingMappingAction updateMappingAction = this.UpdateMappingAction;
			MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
			foreach (object obj in parameters)
			{
				IDataParameter dataParameter = (IDataParameter)obj;
				if (dataParameter != null)
				{
					this.ParameterOutput(dataParameter, row, mappings, updateMappingAction, updateSchemaAction);
				}
			}
		}

		/// <summary>Завершает пакетную обработку для объекта <see cref="T:System.Data.Common.DbDataAdapter" />.</summary>
		/// <exception cref="T:System.NotSupportedException">Адаптер не поддерживает пакеты.</exception>
		// Token: 0x06002C29 RID: 11305 RVA: 0x00008E4B File Offset: 0x0000704B
		protected virtual void TerminateBatching()
		{
			throw ADP.NotSupported();
		}

		/// <summary>Обновляет значения в базе данных, выполняя соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в указанном <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, использованный для обновления источника данных.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06002C2A RID: 11306 RVA: 0x000BD67C File Offset: 0x000BB87C
		public override int Update(DataSet dataSet)
		{
			return this.Update(dataSet, "Table");
		}

		/// <summary>Обновляет значения в базе данных, выполняя соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в указанном массиве объектов <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataRows">Массив объектов <see cref="T:System.Data.DataRow" />, использованный для обновления источника данных.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.SystemException">Не существует объект <see cref="T:System.Data.DataRow" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataTable" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataSet" /> для использования в качестве источника.</exception>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06002C2B RID: 11307 RVA: 0x000BD68C File Offset: 0x000BB88C
		public int Update(DataRow[] dataRows)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbDataAdapter.Update|API> {0}, dataRows[]", base.ObjectID);
			int result;
			try
			{
				int num = 0;
				if (dataRows == null)
				{
					throw ADP.ArgumentNull("dataRows");
				}
				if (dataRows.Length != 0)
				{
					DataTable dataTable = null;
					for (int i = 0; i < dataRows.Length; i++)
					{
						if (dataRows[i] != null && dataTable != dataRows[i].Table)
						{
							if (dataTable != null)
							{
								throw ADP.UpdateMismatchRowTable(i);
							}
							dataTable = dataRows[i].Table;
						}
					}
					if (dataTable != null)
					{
						DataTableMapping tableMapping = this.GetTableMapping(dataTable);
						num = this.Update(dataRows, tableMapping);
					}
				}
				result = num;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Обновляет значения в базе данных, выполняя соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в указанном <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataTable">Объект <see cref="T:System.Data.DataTable" />, использованный для обновления источника данных.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataTable" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.SystemException">Не существует объект <see cref="T:System.Data.DataRow" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataTable" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataSet" /> для использования в качестве источника.</exception>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06002C2C RID: 11308 RVA: 0x000BD730 File Offset: 0x000BB930
		public int Update(DataTable dataTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbDataAdapter.Update|API> {0}, dataTable", base.ObjectID);
			int result;
			try
			{
				if (dataTable == null)
				{
					throw ADP.UpdateRequiresDataTable("dataTable");
				}
				DataTableMapping dataTableMapping = null;
				int num = base.IndexOfDataSetTable(dataTable.TableName);
				if (-1 != num)
				{
					dataTableMapping = base.TableMappings[num];
				}
				if (dataTableMapping == null)
				{
					if (MissingMappingAction.Error == base.MissingMappingAction)
					{
						throw ADP.MissingTableMappingDestination(dataTable.TableName);
					}
					dataTableMapping = new DataTableMapping("Table", dataTable.TableName);
				}
				result = this.UpdateFromDataTable(dataTable, dataTableMapping);
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Обновляет значения в базе данных, выполняя соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в <see cref="T:System.Data.DataSet" /> с заданным именем <see cref="T:System.Data.DataTable" />.</summary>
		/// <param name="dataSet">Объект <see cref="T:System.Data.DataSet" />, используемый для обновления источника данных.</param>
		/// <param name="srcTable">Имя исходной таблицы, используемое для сопоставления таблиц.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06002C2D RID: 11309 RVA: 0x000BD7D4 File Offset: 0x000BB9D4
		public int Update(DataSet dataSet, string srcTable)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int, string>("<comm.DbDataAdapter.Update|API> {0}, dataSet, srcTable='{1}'", base.ObjectID, srcTable);
			int result;
			try
			{
				if (dataSet == null)
				{
					throw ADP.UpdateRequiresNonNullDataSet("dataSet");
				}
				if (string.IsNullOrEmpty(srcTable))
				{
					throw ADP.UpdateRequiresSourceTableName("srcTable");
				}
				int num = 0;
				MissingMappingAction updateMappingAction = this.UpdateMappingAction;
				DataTableMapping tableMappingBySchemaAction = base.GetTableMappingBySchemaAction(srcTable, srcTable, this.UpdateMappingAction);
				MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
				DataTable dataTableBySchemaAction = tableMappingBySchemaAction.GetDataTableBySchemaAction(dataSet, updateSchemaAction);
				if (dataTableBySchemaAction != null)
				{
					num = this.UpdateFromDataTable(dataTableBySchemaAction, tableMappingBySchemaAction);
				}
				else if (!base.HasTableMappings() || -1 == base.TableMappings.IndexOf(tableMappingBySchemaAction))
				{
					throw ADP.UpdateRequiresSourceTable(srcTable);
				}
				result = num;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return result;
		}

		/// <summary>Обновляет значения в базе данных, выполняя соответствующие операторы INSERT, UPDATE или DELETE для каждой вставленной, обновленной или удаленной строки в указанном массиве объектов <see cref="T:System.Data.DataSet" />.</summary>
		/// <param name="dataRows">Массив объектов <see cref="T:System.Data.DataRow" />, использованный для обновления источника данных.</param>
		/// <param name="tableMapping">Используемая коллекция <see cref="P:System.Data.IDataAdapter.TableMappings" />.</param>
		/// <returns>Количество строк, успешно обновленных из объекта <see cref="T:System.Data.DataSet" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <see cref="T:System.Data.DataSet" /> не является допустимым.</exception>
		/// <exception cref="T:System.InvalidOperationException">Исходная таблица является недопустимой.</exception>
		/// <exception cref="T:System.SystemException">Не существует объект <see cref="T:System.Data.DataRow" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataTable" /> для обновления.  
		/// -или- 
		/// Не существует объект <see cref="T:System.Data.DataSet" /> для использования в качестве источника.</exception>
		/// <exception cref="T:System.Data.DBConcurrencyException">Попытка выполнить оператор INSERT, UPDATE или DELETE привела к нулевому количеству обработанных записей.</exception>
		// Token: 0x06002C2E RID: 11310 RVA: 0x000BD894 File Offset: 0x000BBA94
		protected virtual int Update(DataRow[] dataRows, DataTableMapping tableMapping)
		{
			long scopeId = DataCommonEventSource.Log.EnterScope<int>("<comm.DbDataAdapter.Update|API> {0}, dataRows[], tableMapping", base.ObjectID);
			int i;
			try
			{
				int num = 0;
				IDbConnection[] array = new IDbConnection[5];
				ConnectionState[] array2 = new ConnectionState[5];
				bool useSelectConnectionState = false;
				IDbCommand selectCommand = this._IDbDataAdapter.SelectCommand;
				if (selectCommand != null)
				{
					array[0] = selectCommand.Connection;
					if (array[0] != null)
					{
						array2[0] = array[0].State;
						useSelectConnectionState = true;
					}
				}
				int num2 = Math.Min(this.UpdateBatchSize, dataRows.Length);
				if (num2 < 1)
				{
					num2 = dataRows.Length;
				}
				DbDataAdapter.BatchCommandInfo[] array3 = new DbDataAdapter.BatchCommandInfo[num2];
				DataRow[] array4 = new DataRow[num2];
				int num3 = 0;
				try
				{
					try
					{
						if (1 != num2)
						{
							this.InitializeBatching();
						}
						StatementType statementType = StatementType.Select;
						IDbCommand dbCommand = null;
						foreach (DataRow dataRow in dataRows)
						{
							if (dataRow != null)
							{
								bool flag = false;
								DataRowState rowState = dataRow.RowState;
								if (rowState <= DataRowState.Added)
								{
									if (rowState - DataRowState.Detached <= 1)
									{
										goto IL_59B;
									}
									if (rowState != DataRowState.Added)
									{
										goto IL_115;
									}
									statementType = StatementType.Insert;
									dbCommand = this._IDbDataAdapter.InsertCommand;
								}
								else if (rowState != DataRowState.Deleted)
								{
									if (rowState != DataRowState.Modified)
									{
										goto IL_115;
									}
									statementType = StatementType.Update;
									dbCommand = this._IDbDataAdapter.UpdateCommand;
								}
								else
								{
									statementType = StatementType.Delete;
									dbCommand = this._IDbDataAdapter.DeleteCommand;
								}
								RowUpdatingEventArgs rowUpdatingEventArgs = this.CreateRowUpdatingEvent(dataRow, dbCommand, statementType, tableMapping);
								try
								{
									dataRow.RowError = null;
									if (dbCommand != null)
									{
										this.ParameterInput(dbCommand.Parameters, statementType, dataRow, tableMapping);
									}
								}
								catch (Exception ex) when (ADP.IsCatchableExceptionType(ex))
								{
									ADP.TraceExceptionForCapture(ex);
									rowUpdatingEventArgs.Errors = ex;
									rowUpdatingEventArgs.Status = UpdateStatus.ErrorsOccurred;
								}
								this.OnRowUpdating(rowUpdatingEventArgs);
								IDbCommand command = rowUpdatingEventArgs.Command;
								flag = (dbCommand != command);
								dbCommand = command;
								UpdateStatus status = rowUpdatingEventArgs.Status;
								if (status != UpdateStatus.Continue)
								{
									if (UpdateStatus.ErrorsOccurred == status)
									{
										this.UpdatingRowStatusErrors(rowUpdatingEventArgs, dataRow);
										goto IL_59B;
									}
									if (UpdateStatus.SkipCurrentRow == status)
									{
										if (DataRowState.Unchanged == dataRow.RowState)
										{
											num++;
											goto IL_59B;
										}
										goto IL_59B;
									}
									else
									{
										if (UpdateStatus.SkipAllRemainingRows != status)
										{
											throw ADP.InvalidUpdateStatus(status);
										}
										if (DataRowState.Unchanged == dataRow.RowState)
										{
											num++;
											break;
										}
										break;
									}
								}
								else
								{
									rowUpdatingEventArgs = null;
									RowUpdatedEventArgs rowUpdatedEventArgs = null;
									if (1 == num2)
									{
										if (dbCommand != null)
										{
											array3[0]._commandIdentifier = 0;
											array3[0]._parameterCount = dbCommand.Parameters.Count;
											array3[0]._statementType = statementType;
											array3[0]._updatedRowSource = dbCommand.UpdatedRowSource;
										}
										array3[0]._row = dataRow;
										array4[0] = dataRow;
										num3 = 1;
									}
									else
									{
										Exception ex2 = null;
										try
										{
											if (dbCommand != null)
											{
												if ((UpdateRowSource.FirstReturnedRecord & dbCommand.UpdatedRowSource) == UpdateRowSource.None)
												{
													array3[num3]._commandIdentifier = this.AddToBatch(dbCommand);
													array3[num3]._parameterCount = dbCommand.Parameters.Count;
													array3[num3]._row = dataRow;
													array3[num3]._statementType = statementType;
													array3[num3]._updatedRowSource = dbCommand.UpdatedRowSource;
													array4[num3] = dataRow;
													num3++;
													if (num3 < num2)
													{
														goto IL_59B;
													}
												}
												else
												{
													ex2 = ADP.ResultsNotAllowedDuringBatch();
												}
											}
											else
											{
												ex2 = ADP.UpdateRequiresCommand(statementType, flag);
											}
										}
										catch (Exception ex3) when (ADP.IsCatchableExceptionType(ex3))
										{
											ADP.TraceExceptionForCapture(ex3);
											ex2 = ex3;
										}
										if (ex2 != null)
										{
											rowUpdatedEventArgs = this.CreateRowUpdatedEvent(dataRow, dbCommand, StatementType.Batch, tableMapping);
											rowUpdatedEventArgs.Errors = ex2;
											rowUpdatedEventArgs.Status = UpdateStatus.ErrorsOccurred;
											this.OnRowUpdated(rowUpdatedEventArgs);
											if (ex2 != rowUpdatedEventArgs.Errors)
											{
												for (int j = 0; j < array3.Length; j++)
												{
													array3[j]._errors = null;
												}
											}
											num += this.UpdatedRowStatus(rowUpdatedEventArgs, array3, num3);
											if (UpdateStatus.SkipAllRemainingRows == rowUpdatedEventArgs.Status)
											{
												break;
											}
											goto IL_59B;
										}
									}
									rowUpdatedEventArgs = this.CreateRowUpdatedEvent(dataRow, dbCommand, statementType, tableMapping);
									try
									{
										if (1 != num2)
										{
											IDbConnection connection = DbDataAdapter.GetConnection1(this);
											ConnectionState connectionState = this.UpdateConnectionOpen(connection, StatementType.Batch, array, array2, useSelectConnectionState);
											rowUpdatedEventArgs.AdapterInit(array4);
											if (ConnectionState.Open == connectionState)
											{
												this.UpdateBatchExecute(array3, num3, rowUpdatedEventArgs);
											}
											else
											{
												rowUpdatedEventArgs.Errors = ADP.UpdateOpenConnectionRequired(StatementType.Batch, false, connectionState);
												rowUpdatedEventArgs.Status = UpdateStatus.ErrorsOccurred;
											}
										}
										else if (dbCommand != null)
										{
											IDbConnection connection2 = DbDataAdapter.GetConnection4(this, dbCommand, statementType, flag);
											ConnectionState connectionState2 = this.UpdateConnectionOpen(connection2, statementType, array, array2, useSelectConnectionState);
											if (ConnectionState.Open == connectionState2)
											{
												this.UpdateRowExecute(rowUpdatedEventArgs, dbCommand, statementType);
												array3[0]._recordsAffected = new int?(rowUpdatedEventArgs.RecordsAffected);
												array3[0]._errors = null;
											}
											else
											{
												rowUpdatedEventArgs.Errors = ADP.UpdateOpenConnectionRequired(statementType, flag, connectionState2);
												rowUpdatedEventArgs.Status = UpdateStatus.ErrorsOccurred;
											}
										}
										else
										{
											rowUpdatedEventArgs.Errors = ADP.UpdateRequiresCommand(statementType, flag);
											rowUpdatedEventArgs.Status = UpdateStatus.ErrorsOccurred;
										}
									}
									catch (Exception ex4) when (ADP.IsCatchableExceptionType(ex4))
									{
										ADP.TraceExceptionForCapture(ex4);
										rowUpdatedEventArgs.Errors = ex4;
										rowUpdatedEventArgs.Status = UpdateStatus.ErrorsOccurred;
									}
									bool flag2 = UpdateStatus.ErrorsOccurred == rowUpdatedEventArgs.Status;
									Exception errors = rowUpdatedEventArgs.Errors;
									this.OnRowUpdated(rowUpdatedEventArgs);
									if (errors != rowUpdatedEventArgs.Errors)
									{
										for (int k = 0; k < array3.Length; k++)
										{
											array3[k]._errors = null;
										}
									}
									num += this.UpdatedRowStatus(rowUpdatedEventArgs, array3, num3);
									if (UpdateStatus.SkipAllRemainingRows != rowUpdatedEventArgs.Status)
									{
										if (1 != num2)
										{
											this.ClearBatch();
											num3 = 0;
										}
										for (int l = 0; l < array3.Length; l++)
										{
											array3[l] = default(DbDataAdapter.BatchCommandInfo);
										}
										num3 = 0;
										goto IL_59B;
									}
									if (flag2 && 1 != num2)
									{
										this.ClearBatch();
										num3 = 0;
										break;
									}
									break;
								}
								IL_115:
								throw ADP.InvalidDataRowState(dataRow.RowState);
							}
							IL_59B:;
						}
						if (1 != num2 && 0 < num3)
						{
							RowUpdatedEventArgs rowUpdatedEventArgs2 = this.CreateRowUpdatedEvent(null, dbCommand, statementType, tableMapping);
							try
							{
								IDbConnection connection3 = DbDataAdapter.GetConnection1(this);
								ConnectionState connectionState3 = this.UpdateConnectionOpen(connection3, StatementType.Batch, array, array2, useSelectConnectionState);
								DataRow[] array5 = array4;
								if (num3 < array4.Length)
								{
									array5 = new DataRow[num3];
									Array.Copy(array4, 0, array5, 0, num3);
								}
								rowUpdatedEventArgs2.AdapterInit(array5);
								if (ConnectionState.Open == connectionState3)
								{
									this.UpdateBatchExecute(array3, num3, rowUpdatedEventArgs2);
								}
								else
								{
									rowUpdatedEventArgs2.Errors = ADP.UpdateOpenConnectionRequired(StatementType.Batch, false, connectionState3);
									rowUpdatedEventArgs2.Status = UpdateStatus.ErrorsOccurred;
								}
							}
							catch (Exception ex5) when (ADP.IsCatchableExceptionType(ex5))
							{
								ADP.TraceExceptionForCapture(ex5);
								rowUpdatedEventArgs2.Errors = ex5;
								rowUpdatedEventArgs2.Status = UpdateStatus.ErrorsOccurred;
							}
							Exception errors2 = rowUpdatedEventArgs2.Errors;
							this.OnRowUpdated(rowUpdatedEventArgs2);
							if (errors2 != rowUpdatedEventArgs2.Errors)
							{
								for (int m = 0; m < array3.Length; m++)
								{
									array3[m]._errors = null;
								}
							}
							num += this.UpdatedRowStatus(rowUpdatedEventArgs2, array3, num3);
						}
					}
					finally
					{
						if (1 != num2)
						{
							this.TerminateBatching();
						}
					}
				}
				finally
				{
					for (int n = 0; n < array.Length; n++)
					{
						DbDataAdapter.QuietClose(array[n], array2[n]);
					}
				}
				i = num;
			}
			finally
			{
				DataCommonEventSource.Log.ExitScope(scopeId);
			}
			return i;
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x000BE048 File Offset: 0x000BC248
		private void UpdateBatchExecute(DbDataAdapter.BatchCommandInfo[] batchCommands, int commandCount, RowUpdatedEventArgs rowUpdatedEvent)
		{
			try
			{
				int recordsAffected = this.ExecuteBatch();
				rowUpdatedEvent.AdapterInit(recordsAffected);
			}
			catch (DbException ex)
			{
				ADP.TraceExceptionForCapture(ex);
				rowUpdatedEvent.Errors = ex;
				rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
			}
			MissingMappingAction updateMappingAction = this.UpdateMappingAction;
			MissingSchemaAction updateSchemaAction = this.UpdateSchemaAction;
			int num = 0;
			bool flag = false;
			List<DataRow> list = null;
			for (int i = 0; i < commandCount; i++)
			{
				DbDataAdapter.BatchCommandInfo batchCommandInfo = batchCommands[i];
				StatementType statementType = batchCommandInfo._statementType;
				int num2;
				if (this.GetBatchedRecordsAffected(batchCommandInfo._commandIdentifier, out num2, out batchCommands[i]._errors))
				{
					batchCommands[i]._recordsAffected = new int?(num2);
				}
				if (batchCommands[i]._errors == null && batchCommands[i]._recordsAffected != null)
				{
					if (StatementType.Update == statementType || StatementType.Delete == statementType)
					{
						num++;
						if (num2 == 0)
						{
							if (list == null)
							{
								list = new List<DataRow>();
							}
							batchCommands[i]._errors = ADP.UpdateConcurrencyViolation(batchCommands[i]._statementType, 0, 1, new DataRow[]
							{
								rowUpdatedEvent.Rows[i]
							});
							flag = true;
							list.Add(rowUpdatedEvent.Rows[i]);
						}
					}
					if ((StatementType.Insert == statementType || StatementType.Update == statementType) && (UpdateRowSource.OutputParameters & batchCommandInfo._updatedRowSource) != UpdateRowSource.None && num2 != 0)
					{
						if (StatementType.Insert == statementType)
						{
							rowUpdatedEvent.Rows[i].AcceptChanges();
						}
						for (int j = 0; j < batchCommandInfo._parameterCount; j++)
						{
							IDataParameter batchedParameter = this.GetBatchedParameter(batchCommandInfo._commandIdentifier, j);
							this.ParameterOutput(batchedParameter, batchCommandInfo._row, rowUpdatedEvent.TableMapping, updateMappingAction, updateSchemaAction);
						}
					}
				}
			}
			if (rowUpdatedEvent.Errors == null && rowUpdatedEvent.Status == UpdateStatus.Continue && 0 < num && (rowUpdatedEvent.RecordsAffected == 0 || flag))
			{
				DataRow[] array = (list != null) ? list.ToArray() : rowUpdatedEvent.Rows;
				rowUpdatedEvent.Errors = ADP.UpdateConcurrencyViolation(StatementType.Batch, commandCount - array.Length, commandCount, array);
				rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
			}
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x000BE248 File Offset: 0x000BC448
		private ConnectionState UpdateConnectionOpen(IDbConnection connection, StatementType statementType, IDbConnection[] connections, ConnectionState[] connectionStates, bool useSelectConnectionState)
		{
			if (connection != connections[(int)statementType])
			{
				DbDataAdapter.QuietClose(connections[(int)statementType], connectionStates[(int)statementType]);
				connections[(int)statementType] = connection;
				connectionStates[(int)statementType] = ConnectionState.Closed;
				DbDataAdapter.QuietOpen(connection, out connectionStates[(int)statementType]);
				if (useSelectConnectionState && connections[0] == connection)
				{
					connectionStates[(int)statementType] = connections[0].State;
				}
			}
			return connection.State;
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000BE29C File Offset: 0x000BC49C
		private int UpdateFromDataTable(DataTable dataTable, DataTableMapping tableMapping)
		{
			int result = 0;
			DataRow[] array = ADP.SelectAdapterRows(dataTable, false);
			if (array != null && array.Length != 0)
			{
				result = this.Update(array, tableMapping);
			}
			return result;
		}

		// Token: 0x06002C32 RID: 11314 RVA: 0x000BE2C4 File Offset: 0x000BC4C4
		private void UpdateRowExecute(RowUpdatedEventArgs rowUpdatedEvent, IDbCommand dataCommand, StatementType cmdIndex)
		{
			bool flag = true;
			UpdateRowSource updatedRowSource = dataCommand.UpdatedRowSource;
			if (StatementType.Delete == cmdIndex || (UpdateRowSource.FirstReturnedRecord & updatedRowSource) == UpdateRowSource.None)
			{
				int recordsAffected = dataCommand.ExecuteNonQuery();
				rowUpdatedEvent.AdapterInit(recordsAffected);
			}
			else if (StatementType.Insert == cmdIndex || StatementType.Update == cmdIndex)
			{
				using (IDataReader dataReader = dataCommand.ExecuteReader(CommandBehavior.SequentialAccess))
				{
					DataReaderContainer dataReaderContainer = DataReaderContainer.Create(dataReader, this.ReturnProviderSpecificTypes);
					try
					{
						bool flag2 = false;
						while (0 >= dataReaderContainer.FieldCount)
						{
							if (!dataReader.NextResult())
							{
								IL_61:
								if (flag2 && dataReader.RecordsAffected != 0)
								{
									SchemaMapping schemaMapping = new SchemaMapping(this, null, rowUpdatedEvent.Row.Table, dataReaderContainer, false, SchemaType.Mapped, rowUpdatedEvent.TableMapping.SourceTable, true, null, null);
									if (schemaMapping.DataTable != null && schemaMapping.DataValues != null && dataReader.Read())
									{
										if (StatementType.Insert == cmdIndex && flag)
										{
											rowUpdatedEvent.Row.AcceptChanges();
											flag = false;
										}
										schemaMapping.ApplyToDataRow(rowUpdatedEvent.Row);
									}
								}
								goto IL_F2;
							}
						}
						flag2 = true;
						goto IL_61;
					}
					finally
					{
						dataReader.Close();
						int recordsAffected2 = dataReader.RecordsAffected;
						rowUpdatedEvent.AdapterInit(recordsAffected2);
					}
				}
			}
			IL_F2:
			if ((StatementType.Insert == cmdIndex || StatementType.Update == cmdIndex) && (UpdateRowSource.OutputParameters & updatedRowSource) != UpdateRowSource.None && rowUpdatedEvent.RecordsAffected != 0)
			{
				if (StatementType.Insert == cmdIndex && flag)
				{
					rowUpdatedEvent.Row.AcceptChanges();
				}
				this.ParameterOutput(dataCommand.Parameters, rowUpdatedEvent.Row, rowUpdatedEvent.TableMapping);
			}
			if (rowUpdatedEvent.Status == UpdateStatus.Continue && cmdIndex - StatementType.Update <= 1 && rowUpdatedEvent.RecordsAffected == 0)
			{
				rowUpdatedEvent.Errors = ADP.UpdateConcurrencyViolation(cmdIndex, rowUpdatedEvent.RecordsAffected, 1, new DataRow[]
				{
					rowUpdatedEvent.Row
				});
				rowUpdatedEvent.Status = UpdateStatus.ErrorsOccurred;
			}
		}

		// Token: 0x06002C33 RID: 11315 RVA: 0x000BE460 File Offset: 0x000BC660
		private int UpdatedRowStatus(RowUpdatedEventArgs rowUpdatedEvent, DbDataAdapter.BatchCommandInfo[] batchCommands, int commandCount)
		{
			int result;
			switch (rowUpdatedEvent.Status)
			{
			case UpdateStatus.Continue:
				result = this.UpdatedRowStatusContinue(rowUpdatedEvent, batchCommands, commandCount);
				break;
			case UpdateStatus.ErrorsOccurred:
				result = this.UpdatedRowStatusErrors(rowUpdatedEvent, batchCommands, commandCount);
				break;
			case UpdateStatus.SkipCurrentRow:
			case UpdateStatus.SkipAllRemainingRows:
				result = this.UpdatedRowStatusSkip(batchCommands, commandCount);
				break;
			default:
				throw ADP.InvalidUpdateStatus(rowUpdatedEvent.Status);
			}
			return result;
		}

		// Token: 0x06002C34 RID: 11316 RVA: 0x000BE4C0 File Offset: 0x000BC6C0
		private int UpdatedRowStatusContinue(RowUpdatedEventArgs rowUpdatedEvent, DbDataAdapter.BatchCommandInfo[] batchCommands, int commandCount)
		{
			int num = 0;
			bool acceptChangesDuringUpdate = base.AcceptChangesDuringUpdate;
			for (int i = 0; i < commandCount; i++)
			{
				DataRow row = batchCommands[i]._row;
				if (batchCommands[i]._errors == null && batchCommands[i]._recordsAffected != null && batchCommands[i]._recordsAffected.Value != 0)
				{
					if (acceptChangesDuringUpdate && ((DataRowState.Added | DataRowState.Deleted | DataRowState.Modified) & row.RowState) != (DataRowState)0)
					{
						row.AcceptChanges();
					}
					num++;
				}
			}
			return num;
		}

		// Token: 0x06002C35 RID: 11317 RVA: 0x000BE53C File Offset: 0x000BC73C
		private int UpdatedRowStatusErrors(RowUpdatedEventArgs rowUpdatedEvent, DbDataAdapter.BatchCommandInfo[] batchCommands, int commandCount)
		{
			Exception ex = rowUpdatedEvent.Errors;
			if (ex == null)
			{
				ex = ADP.RowUpdatedErrors();
				rowUpdatedEvent.Errors = ex;
			}
			int result = 0;
			bool flag = false;
			string message = ex.Message;
			for (int i = 0; i < commandCount; i++)
			{
				DataRow row = batchCommands[i]._row;
				if (batchCommands[i]._errors != null)
				{
					string text = batchCommands[i]._errors.Message;
					if (string.IsNullOrEmpty(text))
					{
						text = message;
					}
					DataRow dataRow = row;
					dataRow.RowError += text;
					flag = true;
				}
			}
			if (!flag)
			{
				for (int j = 0; j < commandCount; j++)
				{
					DataRow row2 = batchCommands[j]._row;
					row2.RowError += message;
				}
			}
			else
			{
				result = this.UpdatedRowStatusContinue(rowUpdatedEvent, batchCommands, commandCount);
			}
			if (!base.ContinueUpdateOnError)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000BE618 File Offset: 0x000BC818
		private int UpdatedRowStatusSkip(DbDataAdapter.BatchCommandInfo[] batchCommands, int commandCount)
		{
			int num = 0;
			for (int i = 0; i < commandCount; i++)
			{
				DataRow row = batchCommands[i]._row;
				if (((DataRowState.Detached | DataRowState.Unchanged) & row.RowState) != (DataRowState)0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000BE650 File Offset: 0x000BC850
		private void UpdatingRowStatusErrors(RowUpdatingEventArgs rowUpdatedEvent, DataRow dataRow)
		{
			Exception ex = rowUpdatedEvent.Errors;
			if (ex == null)
			{
				ex = ADP.RowUpdatingErrors();
				rowUpdatedEvent.Errors = ex;
			}
			string message = ex.Message;
			dataRow.RowError += message;
			if (!base.ContinueUpdateOnError)
			{
				throw ex;
			}
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000BE698 File Offset: 0x000BC898
		private static IDbConnection GetConnection1(DbDataAdapter adapter)
		{
			IDbCommand dbCommand = adapter._IDbDataAdapter.SelectCommand;
			if (dbCommand == null)
			{
				dbCommand = adapter._IDbDataAdapter.InsertCommand;
				if (dbCommand == null)
				{
					dbCommand = adapter._IDbDataAdapter.UpdateCommand;
					if (dbCommand == null)
					{
						dbCommand = adapter._IDbDataAdapter.DeleteCommand;
					}
				}
			}
			IDbConnection dbConnection = null;
			if (dbCommand != null)
			{
				dbConnection = dbCommand.Connection;
			}
			if (dbConnection == null)
			{
				throw ADP.UpdateConnectionRequired(StatementType.Batch, false);
			}
			return dbConnection;
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000BE6F8 File Offset: 0x000BC8F8
		private static IDbConnection GetConnection3(DbDataAdapter adapter, IDbCommand command, string method)
		{
			IDbConnection connection = command.Connection;
			if (connection == null)
			{
				throw ADP.ConnectionRequired_Res(method);
			}
			return connection;
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000BE718 File Offset: 0x000BC918
		private static IDbConnection GetConnection4(DbDataAdapter adapter, IDbCommand command, StatementType statementType, bool isCommandFromRowUpdating)
		{
			IDbConnection connection = command.Connection;
			if (connection == null)
			{
				throw ADP.UpdateConnectionRequired(statementType, isCommandFromRowUpdating);
			}
			return connection;
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000BE738 File Offset: 0x000BC938
		private static DataRowVersion GetParameterSourceVersion(StatementType statementType, IDataParameter parameter)
		{
			switch (statementType)
			{
			case StatementType.Select:
			case StatementType.Batch:
				throw ADP.UnwantedStatementType(statementType);
			case StatementType.Insert:
				return DataRowVersion.Current;
			case StatementType.Update:
				return parameter.SourceVersion;
			case StatementType.Delete:
				return DataRowVersion.Original;
			default:
				throw ADP.InvalidStatementType(statementType);
			}
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x000BE776 File Offset: 0x000BC976
		private static void QuietClose(IDbConnection connection, ConnectionState originalState)
		{
			if (connection != null && originalState == ConnectionState.Closed)
			{
				connection.Close();
			}
		}

		// Token: 0x06002C3D RID: 11325 RVA: 0x000BE784 File Offset: 0x000BC984
		private static void QuietOpen(IDbConnection connection, out ConnectionState originalState)
		{
			originalState = connection.State;
			if (originalState == ConnectionState.Closed)
			{
				connection.Open();
			}
		}

		/// <summary>Имя по умолчанию, используемое объектом <see cref="T:System.Data.Common.DataAdapter" /> для сопоставлений таблиц.</summary>
		// Token: 0x04001B42 RID: 6978
		public const string DefaultSourceTableName = "Table";

		// Token: 0x04001B43 RID: 6979
		internal static readonly object s_parameterValueNonNullValue = 0;

		// Token: 0x04001B44 RID: 6980
		internal static readonly object s_parameterValueNullValue = 1;

		// Token: 0x04001B45 RID: 6981
		private IDbCommand _deleteCommand;

		// Token: 0x04001B46 RID: 6982
		private IDbCommand _insertCommand;

		// Token: 0x04001B47 RID: 6983
		private IDbCommand _selectCommand;

		// Token: 0x04001B48 RID: 6984
		private IDbCommand _updateCommand;

		// Token: 0x04001B49 RID: 6985
		private CommandBehavior _fillCommandBehavior;

		// Token: 0x02000391 RID: 913
		private struct BatchCommandInfo
		{
			// Token: 0x04001B4A RID: 6986
			internal int _commandIdentifier;

			// Token: 0x04001B4B RID: 6987
			internal int _parameterCount;

			// Token: 0x04001B4C RID: 6988
			internal DataRow _row;

			// Token: 0x04001B4D RID: 6989
			internal StatementType _statementType;

			// Token: 0x04001B4E RID: 6990
			internal UpdateRowSource _updatedRowSource;

			// Token: 0x04001B4F RID: 6991
			internal int? _recordsAffected;

			// Token: 0x04001B50 RID: 6992
			internal Exception _errors;
		}
	}
}
