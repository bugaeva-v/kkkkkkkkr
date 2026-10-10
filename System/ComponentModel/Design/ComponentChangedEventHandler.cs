using System;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" />.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.Design.ComponentChangedEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000441 RID: 1089
	// (Invoke) Token: 0x06002393 RID: 9107
	public delegate void ComponentChangedEventHandler(object sender, ComponentChangedEventArgs e);
}
