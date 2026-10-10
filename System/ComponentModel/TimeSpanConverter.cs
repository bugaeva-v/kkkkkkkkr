using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типа для преобразования объектов <see cref="T:System.TimeSpan" /> в другие представления и обратно.</summary>
	// Token: 0x020003EF RID: 1007
	public class TimeSpanConverter : TypeConverter
	{
		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в <see cref="T:System.TimeSpan" />, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060020ED RID: 8429 RVA: 0x0001846B File Offset: 0x0001666B
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.FormatException">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		// Token: 0x060020EE RID: 8430 RVA: 0x00069ED5 File Offset: 0x000680D5
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует данный объект в объект <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Необязательный класс <see cref="T:System.Globalization.CultureInfo" />. Если не предоставляются, предполагается использование текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		/// <exception cref="T:System.FormatException">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		// Token: 0x060020EF RID: 8431 RVA: 0x0007198C File Offset: 0x0006FB8C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					return TimeSpan.Parse(text, culture);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.Format("{0} is not a valid value for {1}.", (string)value, "TimeSpan"), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанный объект в другой тип.</summary>
		/// <param name="context">Контекст модуля форматирования.</param>
		/// <param name="culture">Язык и региональные параметры, в которые будет выполнено преобразование <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		// Token: 0x060020F0 RID: 8432 RVA: 0x000719F4 File Offset: 0x0006FBF4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(InstanceDescriptor) && value is TimeSpan)
			{
				MethodInfo method = typeof(TimeSpan).GetMethod("Parse", new Type[]
				{
					typeof(string)
				});
				if (method != null)
				{
					return new InstanceDescriptor(method, new object[]
					{
						value.ToString()
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
