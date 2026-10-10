using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс, позволяющий конструктору получать доступ и фильтровать словари класса <see cref="T:System.ComponentModel.TypeDescriptor" />, в которых хранятся дескрипторы свойств, атрибутов и событий, предоставляемые конструктором компонентов в среде режима разработки.</summary>
	// Token: 0x0200045B RID: 1115
	public interface IDesignerFilter
	{
		/// <summary>При переопределении в производном классе позволяет конструктору изменять или удалять элементы из набора атрибутов, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="attributes">Объекты <see cref="T:System.Attribute" /> класса компонента. Ключи в словаре атрибутов являются значениями <see cref="P:System.Attribute.TypeId" /> атрибутов.</param>
		// Token: 0x0600241D RID: 9245
		void PostFilterAttributes(IDictionary attributes);

		/// <summary>При переопределении в производном классе позволяет конструктору изменять или удалять элементы из набора событий, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="events">Объекты <see cref="T:System.ComponentModel.EventDescriptor" />, представляющие события класса компонента. Ключи в словаре событий являются именами событий.</param>
		// Token: 0x0600241E RID: 9246
		void PostFilterEvents(IDictionary events);

		/// <summary>При переопределении в производном классе позволяет конструктору изменять или удалять элементы из набора свойств, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="properties">Объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющие свойства класса компонента. Ключи в словаре свойств являются именами свойств.</param>
		// Token: 0x0600241F RID: 9247
		void PostFilterProperties(IDictionary properties);

		/// <summary>При переопределении в производном классе позволяет конструктору добавлять элементы в набор атрибутов, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="attributes">Объекты <see cref="T:System.Attribute" /> класса компонента. Ключи в словаре атрибутов являются значениями <see cref="P:System.Attribute.TypeId" /> атрибутов.</param>
		// Token: 0x06002420 RID: 9248
		void PreFilterAttributes(IDictionary attributes);

		/// <summary>При переопределении в производном классе позволяет конструктору добавлять элементы в набор событий, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="events">Объекты <see cref="T:System.ComponentModel.EventDescriptor" />, представляющие события класса компонента. Ключи в словаре событий являются именами событий.</param>
		// Token: 0x06002421 RID: 9249
		void PreFilterEvents(IDictionary events);

		/// <summary>При переопределении в производном классе позволяет конструктору добавлять элементы в набор свойств, предоставляемых через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="properties">Объекты <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющие свойства класса компонента. Ключи в словаре свойств являются именами свойств.</param>
		// Token: 0x06002422 RID: 9250
		void PreFilterProperties(IDictionary properties);
	}
}
