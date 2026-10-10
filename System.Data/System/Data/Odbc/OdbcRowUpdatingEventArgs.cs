using System;
using System.Data.Common;

namespace System.Data.Odbc
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.Odbc.OdbcDataAdapter.RowUpdating" />.</summary>
	// Token: 0x020002F8 RID: 760
	public sealed class OdbcRowUpdatingEventArgs : RowUpdatingEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcRowUpdatingEventArgs" />.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" />, который требуется обновить.</param>
		/// <param name="command">Команда <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемая во время операции обновления.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" />, пропускаемый через <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x060021D6 RID: 8662 RVA: 0x0007A3AE File Offset: 0x000785AE
		public OdbcRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(row, command, statementType, tableMapping)
		{
		}

		/// <summary>Возвращает или задает команду <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемую при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060021D7 RID: 8663 RVA: 0x0009DCD3 File Offset: 0x0009BED3
		// (set) Token: 0x060021D8 RID: 8664 RVA: 0x0007A3C8 File Offset: 0x000785C8
		public new OdbcCommand Command
		{
			get
			{
				return base.Command as OdbcCommand;
			}
			set
			{
				base.Command = value;
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x0007A3D1 File Offset: 0x000785D1
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x0009DCE0 File Offset: 0x0009BEE0
		protected override IDbCommand BaseCommand
		{
			get
			{
				return base.BaseCommand;
			}
			set
			{
				base.BaseCommand = (value as OdbcCommand);
			}
		}
	}
}
