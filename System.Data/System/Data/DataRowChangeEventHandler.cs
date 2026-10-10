using System;

namespace System.Data
{
	/// <summary>Представляет метод, обрабатывающий события <see cref="E:System.Data.DataTable.RowChanging" />, <see cref="E:System.Data.DataTable.RowChanged" />, <see cref="E:System.Data.DataTable.RowDeleting" /> и <see cref="E:System.Data.DataTable.RowDeleted" /> объекта <see cref="T:System.Data.DataTable" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.DataRowChangeEventArgs" />, содержащий данные события.</param>
	// Token: 0x020000C1 RID: 193
	// (Invoke) Token: 0x06000C00 RID: 3072
	public delegate void DataRowChangeEventHandler(object sender, DataRowChangeEventArgs e);
}
