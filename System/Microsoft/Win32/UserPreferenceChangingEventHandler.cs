using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.UserPreferenceChanging" />.</summary>
	/// <param name="sender">Источник события. Когда это событие вызывается классом <see cref="T:Microsoft.Win32.SystemEvents" />, данный объект всегда равен <see langword="null" />.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.UserPreferenceChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000131 RID: 305
	// (Invoke) Token: 0x06000710 RID: 1808
	public delegate void UserPreferenceChangingEventHandler(object sender, UserPreferenceChangingEventArgs e);
}
