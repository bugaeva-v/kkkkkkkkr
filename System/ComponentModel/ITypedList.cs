using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет функциональные возможности, необходимые для обнаружения схемы списка возможных связываний, в которой свойства доступные для связывания, отличаются от открытых свойств объекта связывания.</summary>
	// Token: 0x020003BD RID: 957
	public interface ITypedList
	{
		/// <summary>Возвращает имя списка.</summary>
		/// <param name="listAccessors">Массив объектов <see cref="T:System.ComponentModel.PropertyDescriptor" />, для которых возвращается имя списка. Это может быть <see langword="null" />.</param>
		/// <returns>Имя списка.</returns>
		// Token: 0x06001F22 RID: 7970
		string GetListName(PropertyDescriptor[] listAccessors);

		/// <summary>Возвращает <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющий свойства каждого элемента, используемого для привязки данных.</summary>
		/// <param name="listAccessors">Массив объектов <see cref="T:System.ComponentModel.PropertyDescriptor" />, которые ищутся в коллекции как пригодные для привязки. Это может быть <see langword="null" />.</param>
		/// <returns>
		///   <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющий свойства каждого элемента, используемого для привязки данных.</returns>
		// Token: 0x06001F23 RID: 7971
		PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors);
	}
}
