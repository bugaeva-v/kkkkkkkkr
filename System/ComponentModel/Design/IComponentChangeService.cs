using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для добавления или удаления обработчиков событий, добавляющих, удаляющих или переименовывающих компоненты. Предоставляет методы для вызова событий <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" /> и <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" />.</summary>
	// Token: 0x02000456 RID: 1110
	public interface IComponentChangeService
	{
		/// <summary>Происходит после добавления компонента.</summary>
		// Token: 0x14000033 RID: 51
		// (add) Token: 0x060023FC RID: 9212
		// (remove) Token: 0x060023FD RID: 9213
		event ComponentEventHandler ComponentAdded;

		/// <summary>Происходит перед самым добавлением компонента.</summary>
		// Token: 0x14000034 RID: 52
		// (add) Token: 0x060023FE RID: 9214
		// (remove) Token: 0x060023FF RID: 9215
		event ComponentEventHandler ComponentAdding;

		/// <summary>Происходит после изменения компонента.</summary>
		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06002400 RID: 9216
		// (remove) Token: 0x06002401 RID: 9217
		event ComponentChangedEventHandler ComponentChanged;

		/// <summary>Происходит в процессе изменения компонента.</summary>
		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06002402 RID: 9218
		// (remove) Token: 0x06002403 RID: 9219
		event ComponentChangingEventHandler ComponentChanging;

		/// <summary>Происходит после удаления компонента.</summary>
		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06002404 RID: 9220
		// (remove) Token: 0x06002405 RID: 9221
		event ComponentEventHandler ComponentRemoved;

		/// <summary>Происходит в процессе удаления компонента.</summary>
		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06002406 RID: 9222
		// (remove) Token: 0x06002407 RID: 9223
		event ComponentEventHandler ComponentRemoving;

		/// <summary>Происходит после переименования компонента.</summary>
		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06002408 RID: 9224
		// (remove) Token: 0x06002409 RID: 9225
		event ComponentRenameEventHandler ComponentRename;

		/// <summary>Сообщает службе изменения компонентов об изменении определенного компонента.</summary>
		/// <param name="component">Измененный компонент.</param>
		/// <param name="member">Измененный элемент. Значение <see langword="null" />, если изменение относится к нескольким элементам.</param>
		/// <param name="oldValue">Прежнее значение элемента. Это свойство имеет смысл только в том случае, если элемент не равен <see langword="null" />.</param>
		/// <param name="newValue">Новое значение элемента. Это свойство имеет смысл только в том случае, если элемент не равен <see langword="null" />.</param>
		// Token: 0x0600240A RID: 9226
		void OnComponentChanged(object component, MemberDescriptor member, object oldValue, object newValue);

		/// <summary>Сообщает службе изменения компонентов об изменении определенного компонента перед внесением изменений.</summary>
		/// <param name="component">Компонент непосредственно перед изменением.</param>
		/// <param name="member">Изменяемый элемент. Значение <see langword="null" />, если изменение относится к нескольким элементам.</param>
		// Token: 0x0600240B RID: 9227
		void OnComponentChanging(object component, MemberDescriptor member);
	}
}
