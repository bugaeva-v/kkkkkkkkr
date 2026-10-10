using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.SessionEnded" />.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.SessionEndedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000124 RID: 292
	// (Invoke) Token: 0x060006CE RID: 1742
	public delegate void SessionEndedEventHandler(object sender, SessionEndedEventArgs e);
}
