using System;

namespace System.ComponentModel
{
	/// <summary>Показывает, преобразует ли класс события изменения свойства в события <see cref="E:System.ComponentModel.IBindingList.ListChanged" />.</summary>
	// Token: 0x020003BA RID: 954
	public interface IRaiseItemChangedEvents
	{
		/// <summary>Возвращает значение, показывающее, вызывает ли объект <see cref="T:System.ComponentModel.IRaiseItemChangedEvents" /> события <see cref="E:System.ComponentModel.IBindingList.ListChanged" />.</summary>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.ComponentModel.IRaiseItemChangedEvents" /> вызывает события <see cref="E:System.ComponentModel.IBindingList.ListChanged" /> при изменении одного из значений его свойств; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001F19 RID: 7961
		bool RaisesItemChangedEvents { get; }
	}
}
