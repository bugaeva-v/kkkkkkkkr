using System;

namespace System.Data.SqlClient
{
	/// <summary>Обрабатывает событие <see cref="E:System.Data.SqlClient.SqlDependency.OnChange" />, генерируемое при получении уведомления для любой команды, связанной с объектом <see cref="T:System.Data.SqlClient.SqlDependency" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.SqlClient.SqlNotificationEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000187 RID: 391
	// (Invoke) Token: 0x0600141B RID: 5147
	public delegate void OnChangeEventHandler(object sender, SqlNotificationEventArgs e);
}
