using System;

namespace System.Data.OleDb
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.OleDb.OleDbDataAdapter.RowUpdating" /> для <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.OleDb.OleDbRowUpdatingEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000172 RID: 370
	// (Invoke) Token: 0x060013D1 RID: 5073
	public delegate void OleDbRowUpdatingEventHandler(object sender, OleDbRowUpdatingEventArgs e);
}
