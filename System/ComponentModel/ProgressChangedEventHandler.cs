using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.BackgroundWorker.ProgressChanged" /> класса <see cref="T:System.ComponentModel.BackgroundWorker" />. Этот класс не наследуется.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.ProgressChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200041B RID: 1051
	// (Invoke) Token: 0x060021F2 RID: 8690
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void ProgressChangedEventHandler(object sender, ProgressChangedEventArgs e);
}
