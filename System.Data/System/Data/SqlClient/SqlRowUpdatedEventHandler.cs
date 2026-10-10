using System;

namespace System.Data.SqlClient
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.SqlClient.SqlDataAdapter.RowUpdated" /> объекта <see cref="T:System.Data.SqlClient.SqlDataAdapter" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.Data.SqlClient.SqlRowUpdatedEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000222 RID: 546
	// (Invoke) Token: 0x06001A79 RID: 6777
	public delegate void SqlRowUpdatedEventHandler(object sender, SqlRowUpdatedEventArgs e);
}
