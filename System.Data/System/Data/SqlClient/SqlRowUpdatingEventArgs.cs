using System;
using System.Data.Common;

namespace System.Data.SqlClient
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.SqlClient.SqlDataAdapter.RowUpdating" />.</summary>
	// Token: 0x02000223 RID: 547
	public sealed class SqlRowUpdatingEventArgs : RowUpdatingEventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.SqlClient.SqlRowUpdatingEventArgs" />.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" /> для метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="command">
		///   <see cref="T:System.Data.IDbCommand" /> для выполнения в методе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x06001A7C RID: 6780 RVA: 0x0007A3AE File Offset: 0x000785AE
		public SqlRowUpdatingEventArgs(DataRow row, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(row, command, statementType, tableMapping)
		{
		}

		/// <summary>Возвращает или задает команду <see cref="T:System.Data.SqlClient.SqlCommand" />, которую необходимо выполнить в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.SqlClient.SqlCommand" />, которую необходимо выполнить в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x0007A3BB File Offset: 0x000785BB
		// (set) Token: 0x06001A7E RID: 6782 RVA: 0x0007A3C8 File Offset: 0x000785C8
		public new SqlCommand Command
		{
			get
			{
				return base.Command as SqlCommand;
			}
			set
			{
				base.Command = value;
			}
		}

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0007A3D1 File Offset: 0x000785D1
		// (set) Token: 0x06001A80 RID: 6784 RVA: 0x0007A3D9 File Offset: 0x000785D9
		protected override IDbCommand BaseCommand
		{
			get
			{
				return base.BaseCommand;
			}
			set
			{
				base.BaseCommand = (value as SqlCommand);
			}
		}
	}
}
