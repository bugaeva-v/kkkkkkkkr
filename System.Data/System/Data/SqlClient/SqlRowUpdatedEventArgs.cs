using System;
using System.Data.Common;

namespace System.Data.SqlClient
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.SqlClient.SqlDataAdapter.RowUpdated" />.</summary>
	// Token: 0x02000221 RID: 545
	public sealed class SqlRowUpdatedEventArgs : RowUpdatedEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlRowUpdatedEventArgs" />.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="command">Команда <see cref="T:System.Data.IDbCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x06001A76 RID: 6774 RVA: 0x0007A394 File Offset: 0x00078594
		public SqlRowUpdatedEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(row, command, statementType, tableMapping)
		{
		}

		/// <summary>Возвращает или задает <see cref="T:System.Data.SqlClient.SqlCommand" />, которая выполняется при вызове <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.SqlClient.SqlCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0007A3A1 File Offset: 0x000785A1
		public new SqlCommand Command
		{
			get
			{
				return (SqlCommand)base.Command;
			}
		}
	}
}
