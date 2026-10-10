using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.BackgroundWorker.DoWork" />. Этот класс не наследуется.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.DoWorkEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000414 RID: 1044
	// (Invoke) Token: 0x060021B9 RID: 8633
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void DoWorkEventHandler(object sender, DoWorkEventArgs e);
}
