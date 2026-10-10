using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.BackgroundWorker.RunWorkerCompleted" /> класса <see cref="T:System.ComponentModel.BackgroundWorker" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.RunWorkerCompletedEventArgs" />, содержащий данные, которые относятся к событию.</param>
	// Token: 0x02000420 RID: 1056
	// (Invoke) Token: 0x06002259 RID: 8793
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void RunWorkerCompletedEventHandler(object sender, RunWorkerCompletedEventArgs e);
}
