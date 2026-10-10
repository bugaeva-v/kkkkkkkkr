using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь базовых типов для числовых типов без плавающей запятой.</summary>
	// Token: 0x02000381 RID: 897
	public abstract class BaseNumberConverter : TypeConverter
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.ComponentModel.BaseNumberConverter" />.</summary>
		// Token: 0x06001D77 RID: 7543 RVA: 0x00018550 File Offset: 0x00016750
		internal BaseNumberConverter()
		{
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0000390E File Offset: 0x00001B0E
		internal virtual bool AllowHex
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001D79 RID: 7545
		internal abstract Type TargetType { get; }

		// Token: 0x06001D7A RID: 7546
		internal abstract object FromString(string value, int radix);

		// Token: 0x06001D7B RID: 7547
		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		// Token: 0x06001D7C RID: 7548
		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		/// <summary>Определяет, может ли данный преобразователь преобразовывать объект заданного типа источника в собственный тип преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий конечный тип преобразования.</param>
		/// <returns>Значение <see langword="true" />, если данный преобразователь может выполнить операцию, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D7D RID: 7549 RVA: 0x0001846B File Offset: 0x0001666B
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Преобразует указанный объект в тип, используемый преобразователем.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для представления числа.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.Exception">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001D7E RID: 7550 RVA: 0x00068FAC File Offset: 0x000671AC
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					if (this.AllowHex && text[0] == '#')
					{
						return this.FromString(text.Substring(1), 16);
					}
					if ((this.AllowHex && text.StartsWith("0x", StringComparison.OrdinalIgnoreCase)) || text.StartsWith("&h", StringComparison.OrdinalIgnoreCase))
					{
						return this.FromString(text.Substring(2), 16);
					}
					if (culture == null)
					{
						culture = CultureInfo.CurrentCulture;
					}
					NumberFormatInfo formatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
					return this.FromString(text, formatInfo);
				}
				catch (Exception innerException)
				{
					throw new ArgumentException(SR.Format("{0} is not a valid value for {1}.", text, this.TargetType.Name), "value", innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует указанный объект в другой тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для представления числа.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать объект.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="destinationType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001D7F RID: 7551 RVA: 0x00069094 File Offset: 0x00067294
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(string) && value != null && this.TargetType.IsInstanceOfType(value))
			{
				if (culture == null)
				{
					culture = CultureInfo.CurrentCulture;
				}
				NumberFormatInfo formatInfo = (NumberFormatInfo)culture.GetFormat(typeof(NumberFormatInfo));
				return this.ToString(value, formatInfo);
			}
			if (destinationType.IsPrimitive)
			{
				return Convert.ChangeType(value, destinationType, culture);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает значение, показывающее, может ли данный преобразователь преобразовать объект с помощью контекста в конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="t">
		///   <see cref="T:System.Type" /> представляет нужный результат конвертирования.</param>
		/// <returns>Значение <see langword="true" />, если данный преобразователь может выполнить операцию, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001D80 RID: 7552 RVA: 0x00069121 File Offset: 0x00067321
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return base.CanConvertTo(context, destinationType) || destinationType.IsPrimitive;
		}
	}
}
