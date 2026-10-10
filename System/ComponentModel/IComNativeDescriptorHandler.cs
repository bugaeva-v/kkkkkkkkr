using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет уровень сопоставления верхнего уровня между COM-объектом и объектом <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x020003B2 RID: 946
	[Obsolete("This interface has been deprecated. Add a TypeDescriptionProvider to handle type TypeDescriptor.ComObjectType instead.  https://go.microsoft.com/fwlink/?linkid=14202")]
	public interface IComNativeDescriptorHandler
	{
		/// <summary>Получает атрибуты для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить атрибуты.</param>
		/// <returns>Коллекция атрибутов для компонента <paramref name="component" />.</returns>
		// Token: 0x06001EF8 RID: 7928
		AttributeCollection GetAttributes(object component);

		/// <summary>Получает имя класса для указанного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить имя класса.</param>
		/// <returns>Имя класса, соответствующего компоненту <paramref name="component" />.</returns>
		// Token: 0x06001EF9 RID: 7929
		string GetClassName(object component);

		/// <summary>Получает преобразователь типов для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить преобразователь <see cref="T:System.ComponentModel.TypeConverter" />.</param>
		/// <returns>Объект макета <see cref="T:System.ComponentModel.TypeConverter" /> декоративного элемента <paramref name="component" />.</returns>
		// Token: 0x06001EFA RID: 7930
		TypeConverter GetConverter(object component);

		/// <summary>Получает событие по умолчанию для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить событие по умолчанию.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptor" />, представляющий событие по умолчанию для компонента <paramref name="component" />.</returns>
		// Token: 0x06001EFB RID: 7931
		EventDescriptor GetDefaultEvent(object component);

		/// <summary>Получает свойство по умолчанию для указанного компонента.</summary>
		/// <param name="component">Компонент, для которого требуется получить свойство по умолчанию.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий свойство по умолчанию для компонента <paramref name="component" />.</returns>
		// Token: 0x06001EFC RID: 7932
		PropertyDescriptor GetDefaultProperty(object component);

		/// <summary>Получает редактор для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого нужно получить редактор.</param>
		/// <param name="baseEditorType">Базовый тип редактора для компонента <paramref name="component" />.</param>
		/// <returns>Редактор для компонента <paramref name="component" />.</returns>
		// Token: 0x06001EFD RID: 7933
		object GetEditor(object component, Type baseEditorType);

		/// <summary>Получает имя указанного компонента.</summary>
		/// <param name="component">Компонент, имя которого необходимо получить.</param>
		/// <returns>Имя компонента <paramref name="component" />.</returns>
		// Token: 0x06001EFE RID: 7934
		string GetName(object component);

		/// <summary>Получает события для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить события.</param>
		/// <returns>Коллекция дескрипторов событий для компонента <paramref name="component" />.</returns>
		// Token: 0x06001EFF RID: 7935
		EventDescriptorCollection GetEvents(object component);

		/// <summary>Получает события с указанными атрибутами для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить события.</param>
		/// <param name="attributes">Атрибуты, используемые для фильтрации событий.</param>
		/// <returns>Коллекция дескрипторов событий для компонента <paramref name="component" />.</returns>
		// Token: 0x06001F00 RID: 7936
		EventDescriptorCollection GetEvents(object component, Attribute[] attributes);

		/// <summary>Получает свойства с указанными атрибутами для заданного компонента.</summary>
		/// <param name="component">Компонент, для которого необходимо получить события.</param>
		/// <param name="attributes">Атрибуты, используемые для фильтрации свойств.</param>
		/// <returns>Коллекция дескрипторов свойств для компонента <paramref name="component" />.</returns>
		// Token: 0x06001F01 RID: 7937
		PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes);

		/// <summary>Получает значение свойства с заданным именем.</summary>
		/// <param name="component">Объект, которому принадлежит это свойство.</param>
		/// <param name="propertyName">Имя свойства.</param>
		/// <param name="success">Значение типа <see cref="T:System.Boolean" />, передаваемое по ссылке и показывающее, было ли возвращено свойство.</param>
		/// <returns>Значение свойства с заданным именем.</returns>
		// Token: 0x06001F02 RID: 7938
		object GetPropertyValue(object component, string propertyName, ref bool success);

		/// <summary>Получает значение свойства с заданным идентификатором диспетчеризации.</summary>
		/// <param name="component">Объект, которому принадлежит это свойство.</param>
		/// <param name="dispid">Идентификатор диспетчеризации.</param>
		/// <param name="success">Значение типа <see cref="T:System.Boolean" />, передаваемое по ссылке и показывающее, было ли возвращено свойство.</param>
		/// <returns>Значение свойства с заданным идентификатором диспетчеризации.</returns>
		// Token: 0x06001F03 RID: 7939
		object GetPropertyValue(object component, int dispid, ref bool success);
	}
}
