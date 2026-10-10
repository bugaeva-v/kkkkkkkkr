using System;
using System.Collections;
using System.ComponentModel;

namespace System.Drawing.Design
{
	/// <summary>Предоставляет метод, который добавляет делегат в реализацию <see cref="T:System.Drawing.Design.IPropertyValueUIService" />.</summary>
	/// <param name="context">Интерфейс <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для получения дополнительных сведений о контексте.</param>
	/// <param name="propDesc">Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий запрашиваемое свойство.</param>
	/// <param name="valueUIItemList">Объект <see cref="T:System.Collections.ArrayList" /> объектов <see cref="T:System.Drawing.Design.PropertyValueUIItem" />, содержащий элементы интерфейса пользователя, связанные со свойством.</param>
	// Token: 0x02000126 RID: 294
	// (Invoke) Token: 0x06000D9F RID: 3487
	public delegate void PropertyValueUIHandler(ITypeDescriptorContext context, PropertyDescriptor propDesc, ArrayList valueUIItemList);
}
