using System;

namespace System.Data.Odbc
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Data.Odbc.OdbcConnection.InfoMessage" /> для <see cref="T:System.Data.Odbc.OdbcConnection" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Data.Odbc.OdbcInfoMessageEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020002ED RID: 749
	// (Invoke) Token: 0x06002128 RID: 8488
	public delegate void OdbcInfoMessageEventHandler(object sender, OdbcInfoMessageEventArgs e);
}
