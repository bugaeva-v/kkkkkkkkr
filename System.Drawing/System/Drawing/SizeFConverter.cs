using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>Преобразует объекты <see cref="T:System.Drawing.SizeF" /> из одного типа в другой.</summary>
	// Token: 0x02000014 RID: 20
	public class SizeFConverter : TypeConverter
	{
		/// <summary>Возвращает значение, показывающее, может ли преобразователь преобразовывать из заданного типа в тип <see cref="T:System.Drawing.SizeF" /> с помощью заданного контекста.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" />, представляющий тип, из которого необходимо выполнить преобразование.</param>
		/// <returns>Значение <see langword="true" />, показывающее, что преобразование может быть выполнено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600003B RID: 59 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, может ли преобразователь <see cref="T:System.Drawing.SizeFConverter" /> выполнить преобразование <see cref="T:System.Drawing.SizeF" /> в заданный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Значение <see langword="true" />, если преобразователь может выполнить преобразование; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600003C RID: 60 RVA: 0x00003356 File Offset: 0x00001556
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует заданный объект в тип этого преобразователя, используя указанные сведения о контексте и языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в качестве текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		// Token: 0x0600003D RID: 61 RVA: 0x00003654 File Offset: 0x00001854
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
			float[] array2 = new float[array.Length];
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(float));
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = (float)converter.ConvertFromString(context, culture, array[i]);
			}
			if (array2.Length == 2)
			{
				return new SizeF(array2[0], array2[1]);
			}
			throw new ArgumentException(SR.Format("Text \"{0}\" cannot be parsed. The expected text format is \"{1}\".", new object[]
			{
				text2,
				"Width,Height"
			}));
		}

		/// <summary>Преобразует данный объект значения в указанный тип, используя заданные сведения о контексте, а также о языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение null, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, в который преобразуется параметр значения.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		// Token: 0x0600003E RID: 62 RVA: 0x00003730 File Offset: 0x00001930
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value is SizeF)
			{
				SizeF sizeF = (SizeF)value;
				if (culture == null)
				{
					culture = CultureInfo.CurrentCulture;
				}
				string separator = culture.TextInfo.ListSeparator + " ";
				TypeConverter converter = TypeDescriptor.GetConverter(typeof(float));
				string[] array = new string[2];
				int num = 0;
				array[num++] = converter.ConvertToString(context, culture, sizeF.Width);
				array[num++] = converter.ConvertToString(context, culture, sizeF.Height);
				return string.Join(separator, array);
			}
			if (destinationType == typeof(InstanceDescriptor) && value is SizeF)
			{
				SizeF sizeF2 = (SizeF)value;
				ConstructorInfo constructor = typeof(SizeF).GetConstructor(new Type[]
				{
					typeof(float),
					typeof(float)
				});
				if (constructor != null)
				{
					return new InstanceDescriptor(constructor, new object[]
					{
						sizeF2.Width,
						sizeF2.Height
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Создает экземпляр <see cref="T:System.Drawing.SizeF" /> с заданными значениями свойств, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="propertyValues">Объект <see cref="T:System.Collections.IDictionary" />, содержащий имена и значения свойств.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий новый объект <see cref="T:System.Drawing.SizeF" /> или <see langword="null" />, если объект не может быть создан.</returns>
		// Token: 0x0600003F RID: 63 RVA: 0x00003884 File Offset: 0x00001A84
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			if (propertyValues == null)
			{
				throw new ArgumentNullException("propertyValues");
			}
			object obj = propertyValues["Width"];
			object obj2 = propertyValues["Height"];
			if (obj == null || obj2 == null || !(obj is float) || !(obj2 is float))
			{
				throw new ArgumentException(SR.Format("IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object's properties.", Array.Empty<object>()));
			}
			return new SizeF((float)obj, (float)obj2);
		}

		/// <summary>Возвращает значение, указывающее, требует ли изменение значения этого объекта вызова метода <see cref="Overload:System.Drawing.SizeFConverter.CreateInstance" />, чтобы создать новое значение.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата. Это может быть значение <see langword="null" />.</param>
		/// <returns>Всегда возвращает значение <see langword="true" />.</returns>
		// Token: 0x06000040 RID: 64 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Получает набор свойств для типа <see cref="T:System.Drawing.SizeF" />, используя заданный контекст и атрибуты.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Объект <see cref="T:System.Object" />, свойства которого возвращаются.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.PropertyDescriptorCollection" />, которая содержит свойства.</returns>
		// Token: 0x06000041 RID: 65 RVA: 0x000038F8 File Offset: 0x00001AF8
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(typeof(SizeF), attributes).Sort(SizeFConverter.s_propertySort);
		}

		/// <summary>Возвращает значение, указывающее, поддерживает ли тип <see cref="T:System.Drawing.SizeF" /> свойства.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Всегда возвращает значение <see langword="true" />.</returns>
		// Token: 0x06000042 RID: 66 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x0400014C RID: 332
		private static readonly string[] s_propertySort = new string[]
		{
			"Width",
			"Height"
		};
	}
}
