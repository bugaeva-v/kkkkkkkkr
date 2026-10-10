using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanged" />. Этот класс не наследуется.</summary>
	// Token: 0x02000440 RID: 1088
	public sealed class ComponentChangedEventArgs : EventArgs
	{
		/// <summary>Возвращает измененный компонент.</summary>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий измененный компонент.</returns>
		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600238D RID: 9101 RVA: 0x000810FE File Offset: 0x0007F2FE
		public object Component { get; }

		/// <summary>Возвращает измененный элемент.</summary>
		/// <returns>Идентификатор <see cref="T:System.ComponentModel.MemberDescriptor" />, обозначающий измененный элемент.</returns>
		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600238E RID: 9102 RVA: 0x00081106 File Offset: 0x0007F306
		public MemberDescriptor Member { get; }

		/// <summary>Возвращает новое значение измененного элемента.</summary>
		/// <returns>Новое значение измененного элемента. Это свойство может иметь значение <see langword="null" />.</returns>
		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x0600238F RID: 9103 RVA: 0x0008110E File Offset: 0x0007F30E
		public object NewValue { get; }

		/// <summary>Возвращает прежнее значение измененного элемента.</summary>
		/// <returns>Прежнее значение измененного элемента. Это свойство может иметь значение <see langword="null" />.</returns>
		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06002390 RID: 9104 RVA: 0x00081116 File Offset: 0x0007F316
		public object OldValue { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.ComponentChangedEventArgs" />.</summary>
		/// <param name="component">Измененный компонент.</param>
		/// <param name="member">Идентификатор <see cref="T:System.ComponentModel.MemberDescriptor" />, представляющий измененный элемент.</param>
		/// <param name="oldValue">Прежнее значение измененного элемента.</param>
		/// <param name="newValue">Новое значение измененного элемента.</param>
		// Token: 0x06002391 RID: 9105 RVA: 0x0008111E File Offset: 0x0007F31E
		public ComponentChangedEventArgs(object component, MemberDescriptor member, object oldValue, object newValue)
		{
			this.Component = component;
			this.Member = member;
			this.OldValue = oldValue;
			this.NewValue = newValue;
		}
	}
}
