using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Представляет набор команд данных и подключение к базе данных, которые используются для заполнения <see cref="T:System.Data.DataSet" /> и обновления источника данных.</summary>
	// Token: 0x02000161 RID: 353
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbDataAdapter : DbDataAdapter, IDataAdapter, IDbDataAdapter, ICloneable
	{
		/// <summary>Возвращает или задает оператор SQL или хранимую процедуру для удаления записей из набора данных.</summary>
		/// <returns>Команда <see cref="T:System.Data.OleDb.OleDbCommand" />, используемая в ходе обновления <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для удаления из источника данных записей, соответствующих удаленным строкам в наборе <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000323 RID: 803
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbCommand DeleteCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает инструкцию либо хранимую процедуру SQL, используемую для вставки записей в источнике данных.</summary>
		/// <returns>Команда <see cref="T:System.Data.OleDb.OleDbCommand" />, используемая в ходе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> для добавления в источник данных записей, соответствующих новым строкам в наборе <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbCommand InsertCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает оператор SQL или хранимую процедуру для выборки записей в источнике данных.</summary>
		/// <returns>Команда <see cref="T:System.Data.OleDb.OleDbCommand" />, используемая в ходе <see cref="M:System.Data.Common.DbDataAdapter.Fill(System.Data.DataSet)" /> для выборки из источника данных записей с целью их помещения в набор <see cref="T:System.Data.DataSet" />.</returns>
		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbCommand SelectCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.DeleteCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для удаления записей в источнике данных, соответствующих удаленным строкам в наборе данных.</returns>
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x00007EED File Offset: 0x000060ED
		IDbCommand IDbDataAdapter.DeleteCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.InsertCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для вставки записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06001314 RID: 4884 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001315 RID: 4885 RVA: 0x00007EED File Offset: 0x000060ED
		IDbCommand IDbDataAdapter.InsertCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.SelectCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для выбора записей из источника данных для размещения в наборе данных.</returns>
		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06001316 RID: 4886 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001317 RID: 4887 RVA: 0x00007EED File Offset: 0x000060ED
		IDbCommand IDbDataAdapter.SelectCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Описание этого члена см. в разделе <see cref="P:System.Data.IDbDataAdapter.UpdateCommand" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" />, используемый во время обновления для обновления записей в источнике данных, соответствующих измененным строкам в наборе данных.</returns>
		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00007EED File Offset: 0x000060ED
		IDbCommand IDbDataAdapter.UpdateCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает инструкцию SQL либо хранимую процедуру (используется для обновления записей в источнике данных).</summary>
		/// <returns>
		///   <see cref="T:System.Data.OleDb.OleDbCommand" /> — используется в ходе <see cref="T:System.Data.DataSet" /> для обновления записей в источнике данных в соответствии с измененными строками в <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x1700032A RID: 810
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbCommand UpdateCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</summary>
		// Token: 0x0600131C RID: 4892 RVA: 0x0005AC92 File Offset: 0x00058E92
		public OleDbDataAdapter()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbDataAdapter" /> с помощью указанной команды <see cref="T:System.Data.OleDb.OleDbCommand" /> в качестве свойства <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" />.</summary>
		/// <param name="selectCommand">Объект <see cref="T:System.Data.OleDb.OleDbCommand" />, представляющий собой оператор SELECT или хранимую процедуру и заданный как свойство <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</param>
		// Token: 0x0600131D RID: 4893 RVA: 0x0005AC9A File Offset: 0x00058E9A
		public OleDbDataAdapter(OleDbCommand selectCommand)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbDataAdapter" /> с помощью <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" />.</summary>
		/// <param name="selectCommandText">Строка, представляющая собой оператор SQL SELECT или хранимую процедуру, используемую в свойстве <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</param>
		/// <param name="selectConnection">
		///   <see cref="T:System.Data.OleDb.OleDbConnection" /> представляет подключение.</param>
		// Token: 0x0600131E RID: 4894 RVA: 0x0005AC9A File Offset: 0x00058E9A
		public OleDbDataAdapter(string selectCommandText, OleDbConnection selectConnection)
		{
			throw ADP.OleDb();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbDataAdapter" /> с помощью <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" />.</summary>
		/// <param name="selectCommandText">Строка, представляющая собой оператор SQL SELECT или хранимую процедуру, используемую в свойстве <see cref="P:System.Data.OleDb.OleDbDataAdapter.SelectCommand" /> объекта <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</param>
		/// <param name="selectConnectionString">Строка подключения.</param>
		// Token: 0x0600131F RID: 4895 RVA: 0x0005AC9A File Offset: 0x00058E9A
		public OleDbDataAdapter(string selectCommandText, string selectConnectionString)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет или обновляет строки в наборе <see cref="T:System.Data.DataSet" /> для соответствия строкам в объекте ADO <see langword="Recordset" /> или <see langword="Record" /> с помощью указанного набора <see cref="T:System.Data.DataSet" />, объекта ADO и имени таблицы источника.</summary>
		/// <param name="dataSet">Набор <see cref="T:System.Data.DataSet" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="ADODBRecordSet">Объект ADO <see langword="Recordset" /> или <see langword="Record" />.</param>
		/// <param name="srcTable">Таблица источника, используемая для установки соответствия таблиц.</param>
		/// <returns>Количество строк, успешно добавленных или обновленных в объекте <see cref="T:System.Data.DataSet" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		/// <exception cref="T:System.SystemException">Исходная таблица является недопустимой.</exception>
		// Token: 0x06001322 RID: 4898 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int Fill(DataSet dataSet, object ADODBRecordSet, string srcTable)
		{
			throw ADP.OleDb();
		}

		/// <summary>Добавляет или обновляет строки в <see cref="T:System.Data.DataTable" /> для соответствия строкам в объекте ADO <see langword="Recordset" /> или <see langword="Record" /> с помощью указанной таблицы <see cref="T:System.Data.DataTable" /> и объектов ADO.</summary>
		/// <param name="dataTable">Набор <see cref="T:System.Data.DataTable" /> для заполнения записями и, если необходимо, — схемой.</param>
		/// <param name="ADODBRecordSet">Объект ADO <see langword="Recordset" /> или <see langword="Record" />.</param>
		/// <returns>Число успешно обновленных строк в таблице <see cref="T:System.Data.DataTable" />. Не включает строки, на которые воздействуют операторы, не возвращающие строк.</returns>
		// Token: 0x06001323 RID: 4899 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public int Fill(DataTable dataTable, object ADODBRecordSet)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void OnRowUpdated(RowUpdatedEventArgs value)
		{
			throw ADP.OleDb();
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		protected override void OnRowUpdating(RowUpdatingEventArgs value)
		{
			throw ADP.OleDb();
		}

		/// <summary>Происходит во время <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> после выполнения команды для источника данных. Предпринята попытка обновления. Следовательно, происходит событие.</summary>
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x06001326 RID: 4902 RVA: 0x0005ACA8 File Offset: 0x00058EA8
		// (remove) Token: 0x06001327 RID: 4903 RVA: 0x0005ACE0 File Offset: 0x00058EE0
		public event OleDbRowUpdatedEventHandler RowUpdated;

		/// <summary>Происходит во время <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" /> перед выполнением команды в отношении источника данных. Предпринята попытка обновления. Следовательно, происходит событие.</summary>
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x06001328 RID: 4904 RVA: 0x0005AD18 File Offset: 0x00058F18
		// (remove) Token: 0x06001329 RID: 4905 RVA: 0x0005AD50 File Offset: 0x00058F50
		public event OleDbRowUpdatingEventHandler RowUpdating;

		/// <summary>Описание этого члена см. в разделе <see cref="M:System.ICloneable.Clone" />.</summary>
		/// <returns>Новый объект <see cref="T:System.Object" />, который является копией данного экземпляра.</returns>
		// Token: 0x0600132A RID: 4906 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		object ICloneable.Clone()
		{
			throw ADP.OleDb();
		}
	}
}
