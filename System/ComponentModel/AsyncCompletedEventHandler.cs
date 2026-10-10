using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Представляет метод, обрабатывающий событие MethodName<see langword="Completed" /> асинхронной операции.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект класса <see cref="T:System.ComponentModel.AsyncCompletedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000409 RID: 1033
	// (Invoke) Token: 0x06002160 RID: 8544
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public delegate void AsyncCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
}
