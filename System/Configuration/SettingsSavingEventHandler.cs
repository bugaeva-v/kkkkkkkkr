using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.Configuration.ApplicationSettingsBase.SettingsSaving" />.</summary>
	/// <param name="sender">Источник события, обычно, — контейнер с данными или коллекция, связанная с данными.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.CancelEventArgs" />, содержащий данные события.</param>
	// Token: 0x020001D6 RID: 470
	// (Invoke) Token: 0x06000C53 RID: 3155
	public delegate void SettingsSavingEventHandler(object sender, CancelEventArgs e);
}
