using System;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет данные для события <see cref="E:System.ComponentModel.Design.IComponentChangeService.ComponentChanging" />. Этот класс не наследуется.</summary>
	// Token: 0x02000442 RID: 1090
	public sealed class ComponentChangingEventArgs : EventArgs
	{
		/// <summary>Возвращает компонент, в который будут вноситься изменения, или компонент, являющийся родительским контейнером изменяемого элемента.</summary>
		/// <returns>Компонент, в элемент которого будут внесены изменения.</returns>
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06002396 RID: 9110 RVA: 0x00081143 File Offset: 0x0007F343
		public object Component { get; }

		/// <summary>Возвращает изменяемый элемент компонента.</summary>
		/// <returns>Идентификатор <see cref="T:System.ComponentModel.MemberDescriptor" />, обозначающий изменяемый элемент, если он известен, или <see langword="null" /> в противном случае.</returns>
		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06002397 RID: 9111 RVA: 0x0008114B File Offset: 0x0007F34B
		public MemberDescriptor Member { get; }

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.Design.ComponentChangingEventArgs" />.</summary>
		/// <param name="component">Изменяемый компонент.</param>
		/// <param name="member">Свойство <see cref="T:System.ComponentModel.MemberDescriptor" /> обозначает изменяемый элемент компонента.</param>
		// Token: 0x06002398 RID: 9112 RVA: 0x00081153 File Offset: 0x0007F353
		public ComponentChangingEventArgs(object component, MemberDescriptor member)
		{
			this.Component = component;
			this.Member = member;
		}
	}
}
