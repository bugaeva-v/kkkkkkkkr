using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.TimerElapsed" />.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.TimerElapsedEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200012C RID: 300
	// (Invoke) Token: 0x06000704 RID: 1796
	public delegate void TimerElapsedEventHandler(object sender, TimerElapsedEventArgs e);
}
