using System;
using System.Collections;
using System.Globalization;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов коллекций в другие представления и обратно.</summary>
	// Token: 0x0200040B RID: 1035
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class CollectionConverter : TypeConverter
	{
		/// <summary>Преобразовывает указанное значение объекта в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Язык и региональные параметры, к которым будет преобразован параметр <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />. Этот параметр должен наследоваться из <see cref="T:System.Collections.ICollection" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06002178 RID: 8568 RVA: 0x00072860 File Offset: 0x00070A60
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is ICollection)
			{
				return SR.GetString("(Collection)");
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает коллекцию свойств для типа массива, заданного параметром value, используя заданные контекст и атрибуты.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, задающий тип массива, для которого нужно получить свойства.</param>
		/// <param name="attributes">Массив типа <see cref="T:System.Attribute" />, который будет использоваться как фильтр.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" /> со свойствами, доступными для этого типа данных, или значение <see langword="null" />, если свойства отсутствуют. Этот метод всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x06002179 RID: 8569 RVA: 0x00002F6A File Offset: 0x0000116A
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		/// <summary>Возвращает значение, показывающее, поддерживает ли свойства этот объект.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="false" />, так как метод <see cref="M:System.ComponentModel.CollectionConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" /> не следует вызывать для поиска свойств данного объекта.  Этот метод никогда не возвращает значение <see langword="true" />.</returns>
		// Token: 0x0600217A RID: 8570 RVA: 0x00003062 File Offset: 0x00001262
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}
}
