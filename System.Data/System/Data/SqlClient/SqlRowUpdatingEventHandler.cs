using System;

namespace System.Data.SqlClient
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.SqlClient.SqlDataAdapter.RowUpdating" /> объекта <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.SqlClient.SqlRowUpdatingEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000224 RID: 548
	// (Invoke) Token: 0x06001A82 RID: 6786
	public delegate void SqlRowUpdatingEventHandler(object sender, SqlRowUpdatingEventArgs e);
}
