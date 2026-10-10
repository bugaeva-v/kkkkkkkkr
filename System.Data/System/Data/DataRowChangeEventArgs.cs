using System;

namespace System.Data
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="M:System.Data.DataTable.OnRowDeleting(System.Data.DataRowChangeEventArgs)" /> и <see cref="M:System.Data.DataTable.OnRowDeleted(System.Data.DataRowChangeEventArgs)" />.</summary>
	// Token: 0x020000C0 RID: 192
	public class DataRowChangeEventArgs : EventArgs
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Data.DataRowChangeEventArgs" />.</summary>
		/// <param name="row">Объект <see cref="T:System.Data.DataRow" />, в отношении которого происходит действие.</param>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Data.DataRowAction" />.</param>
		// Token: 0x06000BFC RID: 3068 RVA: 0x00031FD6 File Offset: 0x000301D6
		public DataRowChangeEventArgs(DataRow row, DataRowAction action)
		{
			this.Row = row;
			this.Action = action;
		}

		/// <summary>Возвращает строку, в отношении которой произошло действие.</summary>
		/// <returns>Объект <see cref="T:System.Data.DataRow" />, в отношении которого происходит действие.</returns>
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x00031FEC File Offset: 0x000301EC
		public DataRow Row { get; }

		/// <summary>Возвращает действие, выполненное в отношении объекта <see cref="T:System.Data.DataRow" />.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Data.DataRowAction" />.</returns>
		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00031FF4 File Offset: 0x000301F4
		public DataRowAction Action { get; }
	}
}
