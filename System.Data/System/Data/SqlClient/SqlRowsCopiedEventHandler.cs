using System;

namespace System.Data.SqlClient
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.SqlClient.SqlBulkCopy.SqlRowsCopied" /><see cref="T:System.Data.SqlClient.SqlBulkCopy" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.SqlClient.SqlRowsCopiedEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200018A RID: 394
	// (Invoke) Token: 0x06001424 RID: 5156
	public delegate void SqlRowsCopiedEventHandler(object sender, SqlRowsCopiedEventArgs e);
}
