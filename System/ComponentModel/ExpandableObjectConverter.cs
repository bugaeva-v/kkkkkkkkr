using System;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типа для преобразования расширяемых объектов в прочие представления и обратно.</summary>
	// Token: 0x020003A9 RID: 937
	public class ExpandableObjectConverter : TypeConverter
	{
		/// <summary>Возвращает коллекцию свойств для типа объекта, заданного параметром значения.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, задающий тип объекта, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, который будет использоваться как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, предоставляемыми для компонента, или <see langword="null" /> в случае отсутствия свойств.</returns>
		// Token: 0x06001EB9 RID: 7865 RVA: 0x0006C934 File Offset: 0x0006AB34
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(value, attributes);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли свойства этот объект, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как для поиска свойств данного объекта следует вызывать метод <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" />.  Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06001EBA RID: 7866 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
