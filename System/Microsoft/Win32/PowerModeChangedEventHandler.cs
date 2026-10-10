using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.PowerModeChanged" />.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.PowerModeChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000120 RID: 288
	// (Invoke) Token: 0x060006C8 RID: 1736
	public delegate void PowerModeChangedEventHandler(object sender, PowerModeChangedEventArgs e);
}
