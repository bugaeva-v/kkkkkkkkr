using System;

namespace System.Data
{
	/// <summary>Предоставляет данные для события <see cref="E:System.Data.DataTable.ColumnChanging" />.</summary>
	// Token: 0x020000B1 RID: 177
	public class DataColumnChangeEventArgs : EventArgs
	{
		// Token: 0x06000AB8 RID: 2744 RVA: 0x0002CAD3 File Offset: 0x0002ACD3
		internal DataColumnChangeEventArgs(DataRow row)
		{
			this.Row = row;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataColumnChangeEventArgs" />.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" /> столбца с изменяющимся значением.</param>
		/// <param name="column">Объект <see cref="T:System.Data.DataColumn" /> с изменяющимся значением.</param>
		/// <param name="value">Новое значение.</param>
		// Token: 0x06000AB9 RID: 2745 RVA: 0x0002CAE2 File Offset: 0x0002ACE2
		public DataColumnChangeEventArgs(DataRow row, DataColumn column, object value)
		{
			this.Row = row;
			this._column = column;
			this.ProposedValue = value;
		}

		/// <summary>Получает объект <see cref="T:System.Data.DataColumn" /> с изменяющимся значением.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataColumn" /> с изменяющимся значением.</returns>
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000ABA RID: 2746 RVA: 0x0002CAFF File Offset: 0x0002ACFF
		public DataColumn Column
		{
			get
			{
				return this._column;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Data.DataRow" /> столбца с изменяющимся значением.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataRow" /> столбца с изменяющимся значением.</returns>
		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002CB07 File Offset: 0x0002AD07
		public DataRow Row { get; }

		/// <summary>Возвращает или задает предложенное новое значение для столбца.</summary>
		/// <returns>Предложенное значение типа <see cref="T:System.Object" />.</returns>
		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002CB0F File Offset: 0x0002AD0F
		// (set) Token: 0x06000ABD RID: 2749 RVA: 0x0002CB17 File Offset: 0x0002AD17
		public object ProposedValue { get; set; }

		// Token: 0x06000ABE RID: 2750 RVA: 0x0002CB20 File Offset: 0x0002AD20
		internal void InitializeColumnChangeEvent(DataColumn column, object value)
		{
			this._column = column;
			this.ProposedValue = value;
		}

		// Token: 0x0400078E RID: 1934
		private DataColumn _column;
	}
}
