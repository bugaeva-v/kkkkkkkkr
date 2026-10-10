using System;

namespace System.Configuration
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Configuration.ApplicationSettingsBase.SettingChanging" />.</summary>
	/// <param name="sender">Источник события, в основном, класс-оболочка параметров приложения, производный от класса <see cref="T:System.Configuration.ApplicationSettingsBase" />.</param>
	/// <param name="e">
	///   <see cref="T:System.Configuration.SettingChangingEventArgs" />, содержащий данные о событии.</param>
	// Token: 0x020001BE RID: 446
	// (Invoke) Token: 0x06000BAF RID: 2991
	public delegate void SettingChangingEventHandler(object sender, SettingChangingEventArgs e);
}
