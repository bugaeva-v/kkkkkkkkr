using System;

namespace System.Data.Odbc
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.Odbc.OdbcDataAdapter.RowUpdated" /> для <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.Odbc.OdbcRowUpdatedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020002F7 RID: 759
	// (Invoke) Token: 0x060021D3 RID: 8659
	public delegate void OdbcRowUpdatedEventHandler(object sender, OdbcRowUpdatedEventArgs e);
}
