using System;
using System.ComponentModel;

namespace System.Net.Mail
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Net.Mail.SmtpClient.SendCompleted" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200082D RID: 2093
	// (Invoke) Token: 0x060042B1 RID: 17073
	public delegate void SendCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
}
