using System;

namespace Microsoft.Win32
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:Microsoft.Win32.SystemEvents.SessionSwitch" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:Microsoft.Win32.SessionSwitchEventArgs" />, показывающий тип события изменения сеанса.</param>
	// Token: 0x02000128 RID: 296
	// (Invoke) Token: 0x060006DC RID: 1756
	public delegate void SessionSwitchEventHandler(object sender, SessionSwitchEventArgs e);
}
