using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет интерфейс, с помощью которого предоставляются динамические сведения о пользовательских типах объектов.</summary>
	// Token: 0x020003B3 RID: 947
	public interface ICustomTypeDescriptor
	{
		/// <summary>Возвращает коллекцию настраиваемых атрибутов для этого экземпляра компонента.</summary>
		/// <returns>
		///   <see cref="T:System.ComponentModel.AttributeCollection" />, содержащий атрибуты для этого объекта.</returns>
		// Token: 0x06001F04 RID: 7940
		AttributeCollection GetAttributes();

		/// <summary>Возвращает имя класса для этого экземпляра компонента.</summary>
		/// <returns>Имя класса объекта или <see langword="null" />, если класс не имеет имени.</returns>
		// Token: 0x06001F05 RID: 7941
		string GetClassName();

		/// <summary>Возвращает имя этого экземпляра компонента.</summary>
		/// <returns>Имя объекта или <see langword="null" />, если объект не имеет имени.</returns>
		// Token: 0x06001F06 RID: 7942
		string GetComponentName();

		/// <summary>Возвращает преобразователь типов для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.TypeConverter" />, который является преобразователем для данного объекта, или значение <see langword="null" /> в случае отсутствия <see cref="T:System.ComponentModel.TypeConverter" /> для данного объекта.</returns>
		// Token: 0x06001F07 RID: 7943
		TypeConverter GetConverter();

		/// <summary>Возвращает событие по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.EventDescriptor" />, представляющее событие по умолчанию для этого объекта, или <see langword="null" />, если этот объект не имеет событий.</returns>
		// Token: 0x06001F08 RID: 7944
		EventDescriptor GetDefaultEvent();

		/// <summary>Возвращает свойство по умолчанию для этого экземпляра компонента.</summary>
		/// <returns>Значение <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющее свойство по умолчанию для данного объекта, или <see langword="null" />, если этот объект не имеет свойств.</returns>
		// Token: 0x06001F09 RID: 7945
		PropertyDescriptor GetDefaultProperty();

		/// <summary>Возвращает редактор указанного типа для этого экземпляра компонента.</summary>
		/// <param name="editorBaseType">Объект <see cref="T:System.Type" />, который представляет редактор для этого объекта.</param>
		/// <returns>Объект <see cref="T:System.Object" /> заданного типа, являющийся редактором для этого объекта, или <see langword="null" />, если редактор не найден.</returns>
		// Token: 0x06001F0A RID: 7946
		object GetEditor(Type editorBaseType);

		/// <summary>Возвращает события для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий события для этого экземпляра компонента.</returns>
		// Token: 0x06001F0B RID: 7947
		EventDescriptorCollection GetEvents();

		/// <summary>Возвращает события для этого экземпляра компонента с помощью заданного массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Объект <see cref="T:System.ComponentModel.EventDescriptorCollection" />, представляющий отфильтрованные события для этого экземпляра компонента.</returns>
		// Token: 0x06001F0C RID: 7948
		EventDescriptorCollection GetEvents(Attribute[] attributes);

		/// <summary>Возвращает свойства для этого экземпляра компонента.</summary>
		/// <returns>Объект <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющий свойства для этого экземпляра компонента.</returns>
		// Token: 0x06001F0D RID: 7949
		PropertyDescriptorCollection GetProperties();

		/// <summary>Возвращает свойства для этого экземпляра компонента с помощью массива атрибутов в качестве фильтра.</summary>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, используемый в качестве фильтра.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, представляющая отфильтрованные свойства для этого экземпляра компонента.</returns>
		// Token: 0x06001F0E RID: 7950
		PropertyDescriptorCollection GetProperties(Attribute[] attributes);

		/// <summary>Возвращает объект, содержащий свойство, описанное указанным дескриптором свойства.</summary>
		/// <param name="pd">Дескриптор <see cref="T:System.ComponentModel.PropertyDescriptor" />, представляющий свойство, владельца которого требуется найти.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий владельца заданного свойства.</returns>
		// Token: 0x06001F0F RID: 7951
		object GetPropertyOwner(PropertyDescriptor pd);
	}
}
