using System;
using System.ComponentModel;

namespace System.Drawing.Design
{
	/// <summary>Представляет метод, обрабатывающий событие <see cref="P:System.Drawing.Design.PropertyValueUIItem.InvokeHandler" /> объекта <see cref="T:System.Drawing.Design.PropertyValueUIItem" />.</summary>
	/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> для свойства, связанного со значком, для которого был выполнен двойной щелчок.</param>
	/// <param name="descriptor">Свойство, связанное со значком, для которого был выполнен двойной щелчок.</param>
	/// <param name="invokedItem">Объект <see cref="T:System.Drawing.Design.PropertyValueUIItem" />, связанный со значком, для которого был выполнен двойной щелчок.</param>
	// Token: 0x02000128 RID: 296
	// (Invoke) Token: 0x06000DA8 RID: 3496
	public delegate void PropertyValueUIItemInvokeHandler(ITypeDescriptorContext context, PropertyDescriptor descriptor, PropertyValueUIItem invokedItem);
}
