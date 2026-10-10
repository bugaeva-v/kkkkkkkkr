using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace System.Drawing
{
	/// <summary>
	///   <see cref="T:System.Drawing.ImageConverter" /> — класс, который может использоваться для преобразования объектов <see cref="T:System.Drawing.Image" /> из одного типа данных в другой тип данных. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x02000082 RID: 130
	public class ImageConverter : TypeConverter
	{
		/// <summary>Определяет, может ли этот объект <see cref="T:System.Drawing.ImageConverter" /> преобразовать экземпляр определенного типа в объект <see cref="T:System.Drawing.Image" />, используя указанный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" /> задает тип, который необходимо преобразовать.</param>
		/// <returns>Метод возвращает значение <see langword="true" />, если код <see cref="T:System.Drawing.ImageConverter" /> способен выполнить преобразование; иначе он возвращает <see langword="false" />.</returns>
		// Token: 0x06000630 RID: 1584 RVA: 0x00010DA2 File Offset: 0x0000EFA2
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(byte[]);
		}

		/// <summary>Определяет, может ли преобразователь <see cref="T:System.Drawing.ImageConverter" /> преобразовать объект <see cref="T:System.Drawing.Image" /> в экземпляр заданного типа, используя указанный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, задающий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Метод возвращает значение <see langword="true" />, если код <see cref="T:System.Drawing.ImageConverter" /> способен выполнить преобразование; иначе он возвращает <see langword="false" />.</returns>
		// Token: 0x06000631 RID: 1585 RVA: 0x00010DB9 File Offset: 0x0000EFB9
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(byte[]) || destinationType == typeof(string);
		}

		/// <summary>Преобразует указанный объект в <see cref="T:System.Drawing.Image" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий сведения о заданных языке и региональных параметрах.</param>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Object" />.</param>
		/// <returns>В случае успешного выполнения, метод возвращает объект <see cref="T:System.Drawing.Image" />, созданный им путем преобразования указанного объекта. В противном случае выдается исключение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000632 RID: 1586 RVA: 0x0001200C File Offset: 0x0001020C
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			byte[] array = value as byte[];
			if (array == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			return Image.FromStream(new MemoryStream(array));
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.Image" /> (или объект, который может быть приведен к виду <see cref="T:System.Drawing.Image" />) в указанный тип.</summary>
		/// <param name="context">Контекст модуля форматирования. Данный объект используется для получения дополнительных сведений о среде, из которой вызывается этот преобразователь. Параметр может принимать значение <see langword="null" />, поэтому всегда следует выполнять проверку. Свойства объекта контекста также могут возвращать значение <see langword="null" />.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, который задает соглашение о форматировании, используемое для конкретного языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Drawing.Image" />.</param>
		/// <param name="destinationType">Объект класса <see cref="T:System.Type" />, в который преобразуется класс <see cref="T:System.Drawing.Image" />.</param>
		/// <returns>Данный метод возвращает преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000633 RID: 1587 RVA: 0x00012038 File Offset: 0x00010238
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value == null)
			{
				return "(none)";
			}
			if (value is Image)
			{
				if (destinationType == typeof(string))
				{
					return value.ToString();
				}
				if (this.CanConvertTo(null, destinationType))
				{
					using (MemoryStream memoryStream = new MemoryStream())
					{
						((Image)value).Save(memoryStream, ((Image)value).RawFormat);
						return memoryStream.ToArray();
					}
				}
			}
			throw new NotSupportedException(Locale.GetText("ImageConverter can not convert from type '{0}'.", new object[]
			{
				value.GetType()
			}));
		}

		/// <summary>Получает набор свойств данного типа.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <param name="value">Значение объекта, для которого извлекаются свойства.</param>
		/// <param name="attributes">Массив объектов <see cref="T:System.Attribute" />, описывающих свойства.</param>
		/// <returns>Набор свойств, который должен быть представлен для этого типа данных. Если не должны предоставляться никакие свойства, может возвращаться значение <see langword="null" />. Реализация по умолчанию всегда возвращает значение <see langword="null" />.</returns>
		// Token: 0x06000634 RID: 1588 RVA: 0x000120DC File Offset: 0x000102DC
		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return TypeDescriptor.GetProperties(typeof(Image), attributes);
		}

		/// <summary>Определяет, поддерживает ли данный объект свойства. По умолчанию используется значение <see langword="false" />.</summary>
		/// <param name="context">Дескриптор типа, с помощью которого может быть предоставлен дополнительный контекст.</param>
		/// <returns>Данный метод возвращает <see langword="true" />, если следует вызвать метод <see cref="Overload:System.Drawing.ImageConverter.GetProperties" /> для поиска свойств данного объекта.</returns>
		// Token: 0x06000635 RID: 1589 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return true;
		}
	}
}
