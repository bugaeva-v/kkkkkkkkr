using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.UserPreferenceChanged" />.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.UserPreferenceChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x0200012F RID: 303
	// (Invoke) Token: 0x0600070A RID: 1802
	public delegate void UserPreferenceChangedEventHandler(object sender, UserPreferenceChangedEventArgs e);
}
