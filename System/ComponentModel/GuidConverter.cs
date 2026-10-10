using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Guid" /> в прочие представления и обратно.</summary>
	// Token: 0x020003AC RID: 940
	public class GuidConverter : TypeConverter
	{
		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в объект GUID, используя контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001ED1 RID: 7889 RVA: 0x0001846B File Offset: 0x0001666B
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001ED2 RID: 7890 RVA: 0x00069ED5 File Offset: 0x000680D5
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует данный объект в объект GUID.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Необязательный класс <see cref="T:System.Globalization.CultureInfo" />. Если не предоставляются, предполагается использование текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001ED3 RID: 7891 RVA: 0x0006CBC4 File Offset: 0x0006ADC4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				return new Guid(text);
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанный объект в другой тип.</summary>
		/// <param name="context">Контекст модуля форматирования.</param>
		/// <param name="culture">Язык и региональные параметры, в которые будет выполнено преобразование <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001ED4 RID: 7892 RVA: 0x0006CBF8 File Offset: 0x0006ADF8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(InstanceDescriptor) && value is Guid)
			{
				ConstructorInfo constructor = typeof(Guid).GetConstructor(new Type[]
				{
					typeof(string)
				});
				if (constructor != null)
				{
					return new InstanceDescriptor(constructor, new object[]
					{
						value.ToString()
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
