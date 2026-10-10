using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>Класс <see cref="T:System.Drawing.SizeConverter" /> используется для преобразования одного типа данных в другой. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x02000013 RID: 19
	public class SizeConverter : TypeConverter
	{
		/// <summary>Определяет, может ли этот преобразователь преобразовывать объект заданного исходного типа в собственный тип преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование.</returns>
		// Token: 0x06000031 RID: 49 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Это может быть значение <see langword="null" />, поэтому следует всегда выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
		/// <param name="destinationType">Класс <see cref="T:System.Type" />, представляющий тип, в который нужно выполнить преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000032 RID: 50 RVA: 0x00003356 File Offset: 0x00001556
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект в собственный тип преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий конкретные сведения о языке и региональных параметрах, например языке, календаре и культурном контексте определенной культуры. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000033 RID: 51 RVA: 0x00003374 File Offset: 0x00001574
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			string text2 = text.Trim();
			if (text2.Length == 0)
			{
				return null;
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			char separator = culture.TextInfo.ListSeparator[0];
			string[] array = text2.Split(separator, StringSplitOptions.None);
			int[] array2 = new int[array.Length];
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = (int)converter.ConvertFromString(context, culture, array[i]);
			}
			if (array2.Length == 2)
			{
				return new Size(array2[0], array2[1]);
			}
			throw new ArgumentException(SR.Format("Text \"{0}\" cannot be parsed. The expected text format is \"{1}\".", new object[]
			{
				text2,
				"Width,Height"
			}));
		}

		/// <summary>Преобразует указанный объект в заданный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий конкретные сведения о языке и региональных параметрах, например языке, календаре и культурном контексте определенной культуры. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000034 RID: 52 RVA: 0x00003450 File Offset: 0x00001650
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (value is Size)
			{
				if (destinationType == typeof(string))
				{
					Size size = (Size)value;
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					string separator = culture.TextInfo.ListSeparator + " ";
					TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
					string[] array = new string[2];
					int num = 0;
					array[num++] = converter.ConvertToString(context, culture, size.Width);
					array[num++] = converter.ConvertToString(context, culture, size.Height);
					return string.Join(separator, array);
				}
				if (destinationType == typeof(InstanceDescriptor))
				{
					Size size2 = (Size)value;
					ConstructorInfo constructor = typeof(Size).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int)
					});
					if (constructor != null)
					{
						return new InstanceDescriptor(constructor, new object[]
						{
							size2.Width,
							size2.Height
						});
					}
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Создает объект данного типа, используя указанный набор значений свойств для объекта. Это облегчает создание неизменяемых объектов с изменяемыми свойствами.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="propertyValues">Словарь новых значений свойств. Словарь содержит ряд пар имя-значение, по одной для каждого свойства, возвращенного из метода <see cref="M:System.Drawing.SizeConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />.</param>
		/// <returns>Вновь созданный объект или <see langword="null" />, если объект не был создан. Реализация по умолчанию возвращает значение <see langword="null" />.</returns>
		// Token: 0x06000035 RID: 53 RVA: 0x0000359C File Offset: 0x0000179C
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (propertyValues == null)
			{
				throw new ArgumentNullException("propertyValues");
			}
			object obj = propertyValues["Width"];
			object obj2 = propertyValues["Height"];
			if (obj == null || obj2 == null || !(obj is int) || !(obj2 is int))
			{
				throw new ArgumentException(SR.Format("IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object's properties.", Array.Empty<object>()));
			}
			return new Size((int)obj, (int)obj2);
		}

		/// <summary>Определяет, необходимо ли при изменении значения данного объекта вызывать метод <see cref="M:System.Drawing.SizeConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" />, чтобы создать новое значение.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="M:System.Drawing.SizeConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> должен вызываться при внесении изменений в одно или несколько свойств данного объекта.</returns>
		// Token: 0x06000036 RID: 54 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Извлекает набор свойств для данного типа. По умолчанию тип не обладает свойствами, которые необходимо возвращать.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Значение объекта, для которого извлекаются свойства.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Набор свойств, который должен быть представлен для этого типа данных. Если представление свойств не требуется, может возвращаться значение <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x06000037 RID: 55 RVA: 0x00003613 File Offset: 0x00001813
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(typeof(Size), attributes).Sort(SizeConverter.s_propertySort);
		}

		/// <summary>Определяет, поддерживаются ли свойства этим объектом. По умолчанию используется значение <see langword="false" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Значение <see langword="true" />, если метод <see cref="M:System.Drawing.SizeConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" /> должен вызываться для поиска свойств данного объекта.</returns>
		// Token: 0x06000038 RID: 56 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0400014B RID: 331
		private static readonly string[] s_propertySort = new string[]
		{
			"Width",
			"Height"
		};
	}
}
