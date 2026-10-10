using System;
using System.Data.Common;

namespace System.Data.OleDb
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.OleDb.OleDbDataAdapter.RowUpdated" />.</summary>
	// Token: 0x0200016F RID: 367
	[MonoTODO("OleDb is not implemented.")]
	public sealed class OleDbRowUpdatedEventArgs : RowUpdatedEventArgs
	{
		/// <summary>Получает объект <see cref="T:System.Data.OleDb.OleDbCommand" />, выполняемый при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</summary>
		/// <returns>Команда <see cref="T:System.Data.OleDb.OleDbCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</returns>
		// Token: 0x17000355 RID: 853
		// (get) Token: 0x060013C5 RID: 5061 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public new OleDbCommand Command
		{
			get
			{
				throw ADP.OleDb();
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.OleDb.OleDbRowUpdatedEventArgs" />.</summary>
		/// <param name="dataRow">Объект <see cref="T:System.Data.DataRow" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="command">Команда <see cref="T:System.Data.IDbCommand" />, выполняемая при вызове метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		/// <param name="statementType">Одно из значений <see cref="T:System.Data.StatementType" />, указывающих тип выполненного запроса.</param>
		/// <param name="tableMapping">Объект <see cref="T:System.Data.Common.DataTableMapping" /> отправлен с помощью метода <see cref="M:System.Data.Common.DbDataAdapter.Update(System.Data.DataSet)" />.</param>
		// Token: 0x060013C6 RID: 5062 RVA: 0x0005AE18 File Offset: 0x00059018
		public OleDbRowUpdatedEventArgs(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping) : base(null, null, StatementType.Select, null)
		{
			throw ADP.OleDb();
		}
	}
}
