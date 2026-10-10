using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для событий <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdded" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentAdding" />, <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoved" /> и <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentRemoving" />.</summary>
	// Token: 0x02000444 RID: 1092
	public class ComponentEventArgs : EventArgs
	{
		/// <summary>Возвращает компонент, связанный с событием.</summary>
		/// <returns>Компонент, связанный с событием.</returns>
		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x0600239D RID: 9117 RVA: 0x00081169 File Offset: 0x0007F369
		public virtual IComponent Component { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.ComponentEventArgs" />.</summary>
		/// <param name="component">Компонент, являющийся источником события.</param>
		// Token: 0x0600239E RID: 9118 RVA: 0x00081171 File Offset: 0x0007F371
		public ComponentEventArgs(IComponent component)
		{
			this.Component = component;
		}
	}
}
