using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Text;

namespace System.Drawing
{
	/// <summary>Преобразует прямоугольники из одного типа данных в другой. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x02000087 RID: 135
	public class RectangleConverter : TypeConverter
	{
		/// <summary>Определяет, может ли данный преобразователь преобразовывать объект заданного типа источника в собственный тип преобразователя.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Этот метод возвращает <see langword="true" />, если данный объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000709 RID: 1801 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста могут также возвращать значение <see langword="null" />.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который происходит преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x0600070A RID: 1802 RVA: 0x0000BB98 File Offset: 0x00009D98
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует данный объект в объект <see cref="T:System.Drawing.Rectangle" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий сведения о культурной среде, например язык, календарь и культурные соглашения, связанные с конкретным языком и региональными параметрами. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600070B RID: 1803 RVA: 0x00014E84 File Offset: 0x00013084
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			string[] array = text.Split(culture.TextInfo.ListSeparator.ToCharArray());
			Int32Converter int32Converter = new Int32Converter();
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = (int)int32Converter.ConvertFromString(context, culture, array[i]);
			}
			if (array.Length != 4)
			{
				throw new ArgumentException("Failed to parse Text(" + text + ") expected text in the format \"x,y,Width,Height.\"");
			}
			return new Rectangle(array2[0], array2[1], array2[2], array2[3]);
		}

		/// <summary>Преобразует указанный объект в заданный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, который может использоваться для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий сведения о культурной среде, например язык, календарь и культурные соглашения, связанные с конкретным языком и региональными параметрами. Он основан на стандарте RFC 1766.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x0600070C RID: 1804 RVA: 0x00014F30 File Offset: 0x00013130
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is Rectangle)
			{
				Rectangle rectangle = (Rectangle)value;
				if (destinationType == typeof(string))
				{
					string listSeparator = culture.TextInfo.ListSeparator;
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(rectangle.X.ToString(culture));
					stringBuilder.Append(listSeparator);
					stringBuilder.Append(" ");
					stringBuilder.Append(rectangle.Y.ToString(culture));
					stringBuilder.Append(listSeparator);
					stringBuilder.Append(" ");
					stringBuilder.Append(rectangle.Width.ToString(culture));
					stringBuilder.Append(listSeparator);
					stringBuilder.Append(" ");
					stringBuilder.Append(rectangle.Height.ToString(culture));
					return stringBuilder.ToString();
				}
				if (destinationType == typeof(InstanceDescriptor))
				{
					return new InstanceDescriptor(typeof(Rectangle).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int)
					}), new object[]
					{
						rectangle.X,
						rectangle.Y,
						rectangle.Width,
						rectangle.Height
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Создает экземпляр этого типа, задавая набор значений свойств для объекта. Это полезно для объектов, которые доступны только для чтения, но для которых нужно обеспечить возможность изменения свойств.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="propertyValues">Словарь новых значений свойств. Словарь содержит ряд пар "имя-значение", по одной на каждое свойство, возвращенное вызовом метода <see cref="M:System.Drawing.RectangleConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />.</param>
		/// <returns>Вновь созданный объект или <see langword="null" />, если объект не был создан. Реализация по умолчанию возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600070D RID: 1805 RVA: 0x000150C8 File Offset: 0x000132C8
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			object obj = propertyValues["X"];
			object obj2 = propertyValues["Y"];
			object obj3 = propertyValues["Width"];
			object obj4 = propertyValues["Height"];
			if (obj == null || obj2 == null || obj3 == null || obj4 == null)
			{
				throw new ArgumentException("propertyValues");
			}
			int x = (int)obj;
			int y = (int)obj2;
			int width = (int)obj3;
			int height = (int)obj4;
			return new Rectangle(x, y, width, height);
		}

		/// <summary>Определяет, требуется ли вызов <see cref="M:System.Drawing.RectangleConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> для создания нового значения при изменении значения объекта.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если метод <see cref="M:System.Drawing.RectangleConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" /> необходимо вызвать при изменении одного или нескольких свойств данного объекта. В противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x0600070E RID: 1806 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Извлекает набор свойств для данного типа. По умолчанию тип не возвращает свойства.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Значение объекта, для которого извлекаются свойства.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Набор свойств, который должен быть представлен для этого типа данных. Если представление свойств не требуется, может возвращаться значение <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600070F RID: 1807 RVA: 0x00015146 File Offset: 0x00013346
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			if (value is Rectangle)
			{
				return TypeDescriptor.GetProperties(value, attributes);
			}
			return base.GetProperties(context, value, attributes);
		}

		/// <summary>Определяет, поддерживает ли объект свойства. По умолчанию используется значение <see langword="false" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если для поиска свойств объекта следует вызывать метод <see cref="M:System.Drawing.RectangleConverter.GetProperties(System.ComponentModel.ITypeDescriptorContext,System.Object,System.Attribute[])" />; в противном случае возвращается значение <see langword="false" />.</returns>
		// Token: 0x06000710 RID: 1808 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
