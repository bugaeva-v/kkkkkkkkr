using System;

namespace System.ComponentModel.Design
{
	/// <summary>Представляет метод, предназначенный для обработки событий <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdding" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdded" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoving" /> и <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoved" />, вызываемых для событий уровня компонентов.</summary>
	/// <param name="sender">Источник события.</param>
	/// <param name="e">Объект <see cref="T:System.ComponentModel.Design.ComponentEventArgs" />, содержащий данные события.</param>
	// Token: 0x02000445 RID: 1093
	// (Invoke) Token: 0x060023A0 RID: 9120
	public delegate void ComponentEventHandler(object sender, ComponentEventArgs e);
}
