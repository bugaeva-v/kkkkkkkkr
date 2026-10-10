using System;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов между различными представлениями.</summary>
	// Token: 0x0200040E RID: 1038
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class ComponentConverter : ReferenceConverter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.ComponentConverter" />.</summary>
		/// <param name="type">Тип <see cref="T:System.Type" />, представляющий тип для связи с преобразователем компонента.</param>
		// Token: 0x0600218E RID: 8590 RVA: 0x00072ADB File Offset: 0x00070CDB
		public ComponentConverter(Type type) : base(type)
		{
		}

		/// <summary>Возвращает коллекцию свойств для типа компонента, заданного параметром значения.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, задающий тип компонента, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, который будет использоваться как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, предоставляемыми для компонента, или <see langword="null" /> в случае отсутствия свойств.</returns>
		// Token: 0x0600218F RID: 8591 RVA: 0x0006C934 File Offset: 0x0006AB34
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(value, attributes);
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли свойства этот объект, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как для поиска свойств данного объекта следует вызывать метод <see cref="M:System.ComponentModel.TypeConverter.GetProperties(System.Object)" />.  Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06002190 RID: 8592 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
