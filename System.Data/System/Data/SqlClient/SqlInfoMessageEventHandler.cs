using System;

namespace System.Data.SqlClient
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.SqlClient.SqlConnection.InfoMessage" /> объекта <see cref="T:System.Data.SqlClient.SqlConnection" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.SqlClient.SqlInfoMessageEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000204 RID: 516
	// (Invoke) Token: 0x06001906 RID: 6406
	public delegate void SqlInfoMessageEventHandler(object sender, SqlInfoMessageEventArgs e);
}
