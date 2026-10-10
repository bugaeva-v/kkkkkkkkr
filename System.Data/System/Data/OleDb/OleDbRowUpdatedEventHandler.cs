using System;

namespace System.Data.OleDb
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.OleDb.OleDbDataAdapter.RowUpdated" /> для <see cref="T:System.Data.OleDb.OleDbDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.OleDb.OleDbRowUpdatedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000170 RID: 368
	// (Invoke) Token: 0x060013C8 RID: 5064
	public delegate void OleDbRowUpdatedEventHandler(object sender, OleDbRowUpdatedEventArgs e);
}
