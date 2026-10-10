using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>Преобразует объект <see cref="T:System.Drawing.Point" /> из одного типа данных в другой.</summary>
	// Token: 0x02000038 RID: 56
	public class PointConverter : TypeConverter
	{
		/// <summary>Определяет, может ли данный преобразователь преобразовывать объект заданного типа источника в собственный тип преобразователя.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если этот объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060000ED RID: 237 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который происходит преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000EE RID: 238 RVA: 0x00003356 File Offset: 0x00001556
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразовывает указанный объект в объект <see cref="T:System.Drawing.Point" />.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект, содержащий конкретные сведения о языке и региональных параметрах, например языке, календаре и культурном контексте определенной культуры. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060000EF RID: 239 RVA: 0x000054D4 File Offset: 0x000036D4
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
			char c = culture.TextInfo.ListSeparator[0];
			string[] array = text2.Split(new char[]
			{
				c
			});
			int[] array2 = new int[array.Length];
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = (int)converter.ConvertFromString(context, culture, array[i]);
			}
			if (array2.Length == 2)
			{
				return new Point(array2[0], array2[1]);
			}
			throw new ArgumentException(SR.Format("Text \"{0}\" cannot be parsed. The expected text format is \"{1}\".", new object[]
			{
				text2,
				"x, y"
			}));
		}

		/// <summary>Преобразует указанный объект в заданный тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект, содержащий конкретные сведения о языке и региональных параметрах, например языке, календаре и культурном контексте определенной культуры. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060000F0 RID: 240 RVA: 0x000055B8 File Offset: 0x000037B8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (value is Point)
			{
				if (destinationType == typeof(string))
				{
					Point point = (Point)value;
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					string separator = culture.TextInfo.ListSeparator + " ";
					TypeConverter converter = TypeDescriptor.GetConverter(typeof(int));
					string[] array = new string[2];
					int num = 0;
					array[num++] = converter.ConvertToString(context, culture, point.X);
					array[num++] = converter.ConvertToString(context, culture, point.Y);
					return string.Join(separator, array);
				}
				if (destinationType == typeof(InstanceDescriptor))
				{
					Point point2 = (Point)value;
					ConstructorInfo constructor = typeof(Point).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int)
					});
					if (constructor != null)
					{
						return new InstanceDescriptor(constructor, new object[]
						{
							point2.X,
							point2.Y
						});
					}
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Создает экземпляр этого типа, задавая набор значений свойств для объекта.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="propertyValues">Словарь новых значений свойств. Словарь содержит ряд пар "имя-значение", по одной для каждого свойства, возвращенного из метода <see cref="M:System.Drawing.PointConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />.</param>
		/// <returns>Вновь созданный объект или <see langword="null" />, если объект не был создан. Реализация по умолчанию возвращает значение <see langword="null" />.</returns>
		// Token: 0x060000F1 RID: 241 RVA: 0x00005704 File Offset: 0x00003904
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (propertyValues == null)
			{
				throw new ArgumentNullException("propertyValues");
			}
			object obj = propertyValues["X"];
			object obj2 = propertyValues["Y"];
			if (obj == null || obj2 == null || !(obj is int) || !(obj2 is int))
			{
				throw new ArgumentException(SR.Format("IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object's properties.", Array.Empty<object>()));
			}
			return new Point((int)obj, (int)obj2);
		}

		/// <summary>Определяет, требуется ли вызов <see cref="M:System.Drawing.PointConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> для создания нового значения при изменении значения объекта.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Значение <see langword="true" />, если метод <see cref="M:System.Drawing.PointConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> необходимо вызвать при изменении одного или нескольких свойств данного объекта. В противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x060000F2 RID: 242 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Извлекает набор свойств для данного типа. По умолчанию тип не возвращает свойства.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Значение объекта, для которого извлекаются свойства.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Набор свойств, представленных для этого типа данных. Если для этого типа свойств не представлено, метод может вернуть <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x060000F3 RID: 243 RVA: 0x00005778 File Offset: 0x00003978
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(typeof(Point), attributes).Sort(new string[]
			{
				"X",
				"Y"
			});
		}

		/// <summary>Определяет, поддерживает ли объект свойства. По умолчанию используется значение <see langword="false" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.TypeDescriptor" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Имеет значение <see langword="true" />, если для поиска свойств этого объекта следует вызвать метод <see cref="M:System.Drawing.PointConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060000F4 RID: 244 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
