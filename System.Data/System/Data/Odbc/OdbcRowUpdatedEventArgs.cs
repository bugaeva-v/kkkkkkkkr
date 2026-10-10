using System;
using System.Data.Common;

namespace System.Data.Odbc
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.Odbc.OdbcDataAdapter.RowUpdated" />.</summary>
	// Token: 0x020002F9 RID: 761
	public sealed class OdbcRowUpdatedEventArgs : RowUpdatedEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.Odbc.OdbcRowUpdatedEventArgs" />.</summary>
		/// <param name="row">Объект <see langword="DataRow" />, пропускаемый через операцию обновления.</param>
		/// <param name="command">Команда <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" />, пропускаемый через <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x060021DB RID: 8667 RVA: 0x0007A394 File Offset: 0x00078594
		public OdbcRowUpdatedEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(row, command, statementType, tableMapping)
		{
		}

		/// <summary>Получает объект <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемый при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.Odbc.OdbcCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060021DC RID: 8668 RVA: 0x0009DCEE File Offset: 0x0009BEEE
		public new OdbcCommand Command
		{
			get
			{
				return (OdbcCommand)base.Command;
			}
		}
	}
}
