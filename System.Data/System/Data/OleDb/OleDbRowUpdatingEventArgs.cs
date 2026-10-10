using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.OleDb.OleDbDataAdapter.RowUpdating" />.</summary>
	// Token: 0x02000171 RID: 369
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbRowUpdatingEventArgs : RowUpdatingEventArgs
	{
		// Token: 0x17000356 RID: 854
		// (get) Token: 0x060013CB RID: 5067 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060013CC RID: 5068 RVA: 0x00007EED File Offset: 0x000060ED
		protected override IDbCommand BaseCommand
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Возвращает или задает команду <see cref="T:System.Data.OleDb.OleDbCommand" />, которую необходимо выполнить в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.OleDb.OleDbCommand" />, которую необходимо выполнить в процессе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x17000357 RID: 855
		// (get) Token: 0x060013CD RID: 5069 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		// (set) Token: 0x060013CE RID: 5070 RVA: 0x00007EED File Offset: 0x000060ED
		public new OleDbCommand Command
		{
			get
			{
				throw ADP.OleDb();
			}
			set
			{
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbRowUpdatingEventArgs" />.</summary>
		/// <param name="dataRow">Объект <see cref="T:System.Data.DataRow" /> для метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="command">
		///   <see cref="T:System.Data.IDbCommand" /> для выполнения в методе <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x060013CF RID: 5071 RVA: 0x0005AE29 File Offset: 0x00059029
		public OleDbRowUpdatingEventArgs(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(null, null, StatementType.Select, null)
		{
			throw ADP.OleDb();
		}
	}
}
