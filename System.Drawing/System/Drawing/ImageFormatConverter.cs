using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Drawing.Imaging;
using System.Globalization;
using System.Reflection;

namespace System.Drawing
{
	/// <summary>
	///   <see cref="T:System.Drawing.ImageFormatConverter" /> — класс, который может использоваться для преобразования объектов <see cref="T:System.Drawing.Imaging.ImageFormat" /> из одного типа данных в другой тип данных. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x02000083 RID: 131
	public class ImageFormatConverter : TypeConverter
	{
		/// <summary>Определяет, может ли преобразователь преобразовывать объект заданного типа источника в собственный тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект используется для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="sourceType">Тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование.</returns>
		// Token: 0x06000637 RID: 1591 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Получает значение, показывающее, может ли данный преобразователь преобразовать объект с помощью контекста в указанный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, определяющий контекст для данного преобразования типа.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, в который нужно преобразовать объект <see cref="T:System.Drawing.Imaging.ImageFormat" />.</param>
		/// <returns>Данный метод возвращает значение <see langword="true" />, если объект может выполнить преобразование.</returns>
		// Token: 0x06000638 RID: 1592 RVA: 0x0000BB98 File Offset: 0x00009D98
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект в объект <see cref="T:System.Drawing.Imaging.ImageFormat" />.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект используется для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий соглашения по форматированию для конкретных региональных параметров и языка.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000639 RID: 1593 RVA: 0x000120F0 File Offset: 0x000102F0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (text[0] == '[')
			{
				if (text.Equals(ImageFormat.Bmp.ToString()))
				{
					return ImageFormat.Bmp;
				}
				if (text.Equals(ImageFormat.Emf.ToString()))
				{
					return ImageFormat.Emf;
				}
				if (text.Equals(ImageFormat.Exif.ToString()))
				{
					return ImageFormat.Exif;
				}
				if (text.Equals(ImageFormat.Gif.ToString()))
				{
					return ImageFormat.Gif;
				}
				if (text.Equals(ImageFormat.Icon.ToString()))
				{
					return ImageFormat.Icon;
				}
				if (text.Equals(ImageFormat.Jpeg.ToString()))
				{
					return ImageFormat.Jpeg;
				}
				if (text.Equals(ImageFormat.MemoryBmp.ToString()))
				{
					return ImageFormat.MemoryBmp;
				}
				if (text.Equals(ImageFormat.Png.ToString()))
				{
					return ImageFormat.Png;
				}
				if (text.Equals(ImageFormat.Tiff.ToString()))
				{
					return ImageFormat.Tiff;
				}
				if (text.Equals(ImageFormat.Wmf.ToString()))
				{
					return ImageFormat.Wmf;
				}
			}
			else
			{
				if (string.Compare(text, "Bmp", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Bmp;
				}
				if (string.Compare(text, "Emf", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Emf;
				}
				if (string.Compare(text, "Exif", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Exif;
				}
				if (string.Compare(text, "Gif", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Gif;
				}
				if (string.Compare(text, "Icon", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Icon;
				}
				if (string.Compare(text, "Jpeg", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Jpeg;
				}
				if (string.Compare(text, "MemoryBmp", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.MemoryBmp;
				}
				if (string.Compare(text, "Png", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Png;
				}
				if (string.Compare(text, "Tiff", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Tiff;
				}
				if (string.Compare(text, "Wmf", StringComparison.OrdinalIgnoreCase) == 0)
				{
					return ImageFormat.Wmf;
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанный объект в заданный тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект используется для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий соглашения по форматированию для конкретных региональных параметров и языка.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>Преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> равно <see langword="null." /></exception>
		// Token: 0x0600063A RID: 1594 RVA: 0x000122E4 File Offset: 0x000104E4
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is ImageFormat)
			{
				ImageFormat imageFormat = (ImageFormat)value;
				string text = null;
				if (imageFormat.Guid.Equals(ImageFormat.Bmp.Guid))
				{
					text = "Bmp";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Emf.Guid))
				{
					text = "Emf";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Exif.Guid))
				{
					text = "Exif";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Gif.Guid))
				{
					text = "Gif";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Icon.Guid))
				{
					text = "Icon";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Jpeg.Guid))
				{
					text = "Jpeg";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.MemoryBmp.Guid))
				{
					text = "MemoryBmp";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Png.Guid))
				{
					text = "Png";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Tiff.Guid))
				{
					text = "Tiff";
				}
				else if (imageFormat.Guid.Equals(ImageFormat.Wmf.Guid))
				{
					text = "Wmf";
				}
				if (destinationType == typeof(string))
				{
					if (text == null)
					{
						return imageFormat.ToString();
					}
					return text;
				}
				else if (destinationType == typeof(InstanceDescriptor))
				{
					if (text != null)
					{
						return new InstanceDescriptor(typeof(ImageFormat).GetTypeInfo().GetProperty(text), null);
					}
					return new InstanceDescriptor(typeof(ImageFormat).GetTypeInfo().GetConstructor(new Type[]
					{
						typeof(Guid)
					}), new object[]
					{
						imageFormat.Guid
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Получает коллекцию, содержащую набор стандартных значений для типа данных, для которого предназначен данный проверяющий элемент управления. Возвращает <see langword="null" />, если тип данных не поддерживает стандартный набор значений.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект используется для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <returns>Коллекция, содержащая стандартный набор значений или <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x0600063B RID: 1595 RVA: 0x00012508 File Offset: 0x00010708
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return new TypeConverter.StandardValuesCollection(new ImageFormat[]
			{
				ImageFormat.MemoryBmp,
				ImageFormat.Bmp,
				ImageFormat.Emf,
				ImageFormat.Wmf,
				ImageFormat.Gif,
				ImageFormat.Jpeg,
				ImageFormat.Png,
				ImageFormat.Tiff,
				ImageFormat.Exif,
				ImageFormat.Icon
			});
		}

		/// <summary>Показывает, поддерживает ли объект стандартный набор значений, которые можно выбрать в списке.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает <see langword="true" />, если следует вызвать метод <see cref="Overload:System.Drawing.ImageFormatConverter.GetStandardValues" /> для поиска общего набора значений, который поддерживается данным объектом.</returns>
		// Token: 0x0600063C RID: 1596 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
