using System;
using System.Collections;

namespace System.ComponentModel.Design
{
	/// <summary>Предоставляет интерфейс для изменения набора дескрипторов элементов для компонента в режиме разработки.</summary>
	// Token: 0x0200046C RID: 1132
	public interface ITypeDescriptorFilterService
	{
		/// <summary>Фильтрует атрибуты, предоставляемые компонентом через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="component">Компонент, атрибуты которого необходимо отфильтровать.</param>
		/// <param name="attributes">Словарь атрибутов, которые можно изменить.</param>
		/// <returns>Значение <see langword="true" />, если набор отфильтрованных атрибутов должен быть помещен в кэш; значение <see langword="false" />, если служба фильтрации должна снова сделать запрос.</returns>
		// Token: 0x0600247C RID: 9340
		bool FilterAttributes(IComponent component, IDictionary attributes);

		/// <summary>Фильтрует события, предоставляемые компонентом через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="component">Компонент, для которого необходимо отфильтровать события.</param>
		/// <param name="events">Словарь событий, которые можно изменить.</param>
		/// <returns>Значение <see langword="true" />, если набор отфильтрованных событий должен быть помещен в кэш; значение <see langword="false" />, если служба фильтрации должна снова сделать запрос.</returns>
		// Token: 0x0600247D RID: 9341
		bool FilterEvents(IComponent component, IDictionary events);

		/// <summary>Фильтрует свойства, предоставляемые компонентом через класс <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
		/// <param name="component">Компонент, для которого необходимо отфильтровать свойства.</param>
		/// <param name="properties">Словарь свойств, которые можно изменить.</param>
		/// <returns>Значение <see langword="true" />, если набор отфильтрованных свойств должен быть кэширован; значение <see langword="false" />, если служба фильтрации должна снова делать запрос.</returns>
		// Token: 0x0600247E RID: 9342
		bool FilterProperties(IComponent component, IDictionary properties);
	}
}
