using System;

namespace System.Data.Odbc
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.Odbc.OdbcDataAdapter.RowUpdating" /> для <see cref="T:System.Data.Odbc.OdbcDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.Odbc.OdbcRowUpdatingEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020002F6 RID: 758
	// (Invoke) Token: 0x060021CF RID: 8655
	public delegate void OdbcRowUpdatingEventHandler(object sender, OdbcRowUpdatingEventArgs e);
}
