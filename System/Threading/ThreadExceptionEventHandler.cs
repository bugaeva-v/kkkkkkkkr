using System;

namespace System.Threading
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Windows.Forms.Application.ThreadException" /><see cref="T:System.Windows.Forms.Application" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.Threading.ThreadExceptionEventArgs" />, содержащий данные, которые относятся к событию.</param>
	// Token: 0x02000181 RID: 385
	// (Invoke) Token: 0x06000A55 RID: 2645
	public delegate void ThreadExceptionEventHandler(object sender, ThreadExceptionEventArgs e);
}
