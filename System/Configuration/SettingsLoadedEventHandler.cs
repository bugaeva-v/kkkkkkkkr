using System;

namespace System.Configuration
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsLoaded" />.</summary>
	/// <param name="sender">Источник события, обычно класс событий.</param>
	/// <param name="e">Объект <see cref="T:System.Configuration.SettingsLoadedEventArgs" />, содержащий данные события.</param>
	// Token: 0x020001C9 RID: 457
	// (Invoke) Token: 0x06000BF4 RID: 3060
	public delegate void SettingsLoadedEventHandler(object sender, SettingsLoadedEventArgs e);
}
