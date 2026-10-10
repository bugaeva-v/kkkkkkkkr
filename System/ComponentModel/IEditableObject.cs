using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет функциональные возможности для фиксации изменений объекта, используемого в качестве источника данных, или отказа от этих изменений.</summary>
	// Token: 0x020003FD RID: 1021
	public interface IEditableObject
	{
		/// <summary>Начинает редактирование объекта.</summary>
		// Token: 0x0600213B RID: 8507
		void BeginEdit();

		/// <summary>Помещает в базовый объект изменения, выполненные с момента последнего вызова метода <see cref="M:System.ComponentModel.IEditableObject.BeginEdit" /> или <see cref="M:System.ComponentModel.IBindingList.AddNew" />.</summary>
		// Token: 0x0600213C RID: 8508
		void EndEdit();

		/// <summary>Уничтожает изменения, выполненные после последнего вызова метода <see cref="M:System.ComponentModel.IEditableObject.BeginEdit" />.</summary>
		// Token: 0x0600213D RID: 8509
		void CancelEdit();
	}
}
