using System;

namespace System.Data.OleDb
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.OleDb.OleDbConnection.InfoMessage" /> для <see cref="T:System.Data.OleDb.OleDbConnection" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.OleDb.OleDbInfoMessageEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x02000169 RID: 361
	// (Invoke) Token: 0x06001376 RID: 4982
	public delegate void OleDbInfoMessageEventHandler(object sender, OleDbInfoMessageEventArgs e);
}
