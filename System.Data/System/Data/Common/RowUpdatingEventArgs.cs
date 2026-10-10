using System;

namespace System.Data.Common
{
	/// <summary>Предоставляет данные для события RowUpdating поставщика данных .NET Framework.</summary>
	// Token: 0x020003A8 RID: 936
	public class RowUpdatingEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Common.RowUpdatingEventArgs" />.</summary>
		/// <param name="dataRow">Объект <see cref="T:System.Data.DataRow" /> для метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="command">Команда <see cref="T:System.Data.IDbCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Тип инструкции SQL для выполнения.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" />, отправляемый с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x06002D66 RID: 11622 RVA: 0x000C0C0C File Offset: 0x000BEE0C
		public RowUpdatingEventArgs(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
		{
			ADP.CheckArgumentNull(dataRow, "dataRow");
			ADP.CheckArgumentNull(tableMapping, "tableMapping");
			if (statementType <= StatementType.Delete)
			{
				this._dataRow = dataRow;
				this._command = command;
				this._statementType = statementType;
				this._tableMapping = tableMapping;
				return;
			}
			if (statementType == StatementType.Batch)
			{
				throw ADP.NotSupportedStatementType(statementType, "RowUpdatingEventArgs");
			}
			throw ADP.InvalidStatementType(statementType);
		}

		/// <summary>Возвращает или задает объект <see cref="T:System.Data.IDbCommand" /> для экземпляра этого класса.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" /> для выполнения при применении метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000C0C6E File Offset: 0x000BEE6E
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x000C0C76 File Offset: 0x000BEE76
		protected virtual IDbCommand BaseCommand
		{
			get
			{
				return this._command;
			}
			set
			{
				this._command = value;
			}
		}

		/// <summary>Возвращает интерфейс <see cref="T:System.Data.IDbCommand" /> для выполнения во время операции <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Интерфейс <see cref="T:System.Data.IDbCommand" /> для выполнения при применении метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000C0C7F File Offset: 0x000BEE7F
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x000C0C87 File Offset: 0x000BEE87
		public IDbCommand Command
		{
			get
			{
				return this.BaseCommand;
			}
			set
			{
				this.BaseCommand = value;
			}
		}

		/// <summary>Возвращает ошибки, создаваемые поставщиком данных .NET Framework при выполнении <see cref="P:System.Data.Common.RowUpdatedEventArgs.Command" />.</summary>
		/// <returns>Ошибки, создаваемые поставщиком данных .NET Framework при выполнении свойства <see cref="P:System.Data.Common.RowUpdatedEventArgs.Command" />.</returns>
		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06002D6B RID: 11627 RVA: 0x000C0C90 File Offset: 0x000BEE90
		// (set) Token: 0x06002D6C RID: 11628 RVA: 0x000C0C98 File Offset: 0x000BEE98
		public Exception Errors
		{
			get
			{
				return this._errors;
			}
			set
			{
				this._errors = value;
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.DataRow" />, который будет отправлен на сервер в качестве части операции вставки, обновления или удаления.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataRow" />, отправляемый с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06002D6D RID: 11629 RVA: 0x000C0CA1 File Offset: 0x000BEEA1
		public DataRow Row
		{
			get
			{
				return this._dataRow;
			}
		}

		/// <summary>Получает тип инструкции SQL для выполнения.</summary>
		/// <returns>Тип инструкции SQL для выполнения.</returns>
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000C0CA9 File Offset: 0x000BEEA9
		public StatementType StatementType
		{
			get
			{
				return this._statementType;
			}
		}

		/// <summary>Возвращает или задает значение <see cref="T:System.Data.UpdateStatus" /> свойства <see cref="P:System.Data.Common.RowUpdatedEventArgs.Command" />.</summary>
		/// <returns>Одно из значений <see cref="T:System.Data.UpdateStatus" />. Значение по умолчанию: <see langword="Continue" />.</returns>
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x000C0CB1 File Offset: 0x000BEEB1
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x000C0CB9 File Offset: 0x000BEEB9
		public UpdateStatus Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if (value <= UpdateStatus.SkipAllRemainingRows)
				{
					this._status = value;
					return;
				}
				throw ADP.InvalidUpdateStatus(value);
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Data.Common.DataTableMapping" /> для отправки с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Объект <see cref="T:System.Data.Common.DataTableMapping" />, отправляемый с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x000C0CCD File Offset: 0x000BEECD
		public DataTableMapping TableMapping
		{
			get
			{
				return this._tableMapping;
			}
		}

		// Token: 0x04001BA4 RID: 7076
		private IDbCommand _command;

		// Token: 0x04001BA5 RID: 7077
		private StatementType _statementType;

		// Token: 0x04001BA6 RID: 7078
		private DataTableMapping _tableMapping;

		// Token: 0x04001BA7 RID: 7079
		private Exception _errors;

		// Token: 0x04001BA8 RID: 7080
		private DataRow _dataRow;

		// Token: 0x04001BA9 RID: 7081
		private UpdateStatus _status;
	}
}
