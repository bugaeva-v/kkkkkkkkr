using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Security.Permissions;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования структур <see cref="T:System.DateTimeOffset" /> в прочие представления и обратно.</summary>
	// Token: 0x02000411 RID: 1041
	[HostProtection(SecurityAction.LinkDemand, SharedState = true)]
	public class DateTimeOffsetConverter : TypeConverter
	{
		/// <summary>Возвращает значение, указывающее, можно преобразовать объект с заданным исходным типом в объект <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="context">Контекст формата даты.</param>
		/// <param name="sourceType">Проверяемый исходный тип.</param>
		/// <returns>Значение <see langword="true" />, если заданный тип можно преобразовать в объект <see cref="T:System.DateTimeOffset" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021A5 RID: 8613 RVA: 0x00069EB7 File Offset: 0x000680B7
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, указывающее, можно преобразовать объект <see cref="T:System.DateTimeOffset" /> в объект заданного типа.</summary>
		/// <param name="context">Контекст формата даты.</param>
		/// <param name="destinationType">Проверяемый конечный тип.</param>
		/// <returns>Значение <see langword="true" />, если объект <see cref="T:System.DateTimeOffset" /> можно привести к заданному типу; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060021A6 RID: 8614 RVA: 0x00069ED5 File Offset: 0x000680D5
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект в <see cref="T:System.DateTimeOffset" />.</summary>
		/// <param name="context">Контекст формата даты.</param>
		/// <param name="culture">Язык и региональные параметры, определяющие формат даты.</param>
		/// <param name="value">Преобразуемый объект.</param>
		/// <returns>Объект <see cref="T:System.DateTimeOffset" />, представляющий заданный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060021A7 RID: 8615 RVA: 0x00072FE8 File Offset: 0x000711E8
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value is string)
			{
				string text = ((string)value).Trim();
				if (text.Length == 0)
				{
					return DateTimeOffset.MinValue;
				}
				try
				{
					DateTimeFormatInfo dateTimeFormatInfo = null;
					if (culture != null)
					{
						dateTimeFormatInfo = (DateTimeFormatInfo)culture.GetFormat(typeof(DateTimeFormatInfo));
					}
					if (dateTimeFormatInfo != null)
					{
						return DateTimeOffset.Parse(text, dateTimeFormatInfo);
					}
					return DateTimeOffset.Parse(text, culture);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.GetString("{0} is not a valid value for {1}.", new object[]
					{
						(string)value,
						"DateTimeOffset"
					}), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует <see cref="T:System.DateTimeOffset" /> в объект заданного типа.</summary>
		/// <param name="context">Контекст формата даты.</param>
		/// <param name="culture">Язык и региональные параметры, определяющие формат даты.</param>
		/// <param name="value">Преобразуемая структура <see cref="T:System.DateTimeOffset" />.</param>
		/// <param name="destinationType">Целевой тип преобразования.</param>
		/// <returns>Объект заданного типа, представляющий объект <see cref="T:System.DateTimeOffset" />.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060021A8 RID: 8616 RVA: 0x000730A0 File Offset: 0x000712A0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!(destinationType == typeof(string)) || !(value is DateTimeOffset))
			{
				if (destinationType == typeof(InstanceDescriptor) && value is DateTimeOffset)
				{
					DateTimeOffset dateTimeOffset = (DateTimeOffset)value;
					if (dateTimeOffset.Ticks == 0L)
					{
						ConstructorInfo constructor = typeof(DateTimeOffset).GetConstructor(new Type[]
						{
							typeof(long)
						});
						if (constructor != null)
						{
							return new InstanceDescriptor(constructor, new object[]
							{
								dateTimeOffset.Ticks
							});
						}
					}
					ConstructorInfo constructor2 = typeof(DateTimeOffset).GetConstructor(new Type[]
					{
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(int),
						typeof(TimeSpan)
					});
					if (constructor2 != null)
					{
						return new InstanceDescriptor(constructor2, new object[]
						{
							dateTimeOffset.Year,
							dateTimeOffset.Month,
							dateTimeOffset.Day,
							dateTimeOffset.Hour,
							dateTimeOffset.Minute,
							dateTimeOffset.Second,
							dateTimeOffset.Millisecond,
							dateTimeOffset.Offset
						});
					}
				}
				return base.ConvertTo(context, culture, value, destinationType);
			}
			DateTimeOffset left = (DateTimeOffset)value;
			if (left == DateTimeOffset.MinValue)
			{
				return string.Empty;
			}
			if (culture == null)
			{
				culture = CultureInfo.CurrentCulture;
			}
			DateTimeFormatInfo dateTimeFormatInfo = (DateTimeFormatInfo)culture.GetFormat(typeof(DateTimeFormatInfo));
			if (culture != CultureInfo.InvariantCulture)
			{
				string format;
				if (left.TimeOfDay.TotalSeconds == 0.0)
				{
					format = dateTimeFormatInfo.ShortDatePattern + " zzz";
				}
				else
				{
					format = dateTimeFormatInfo.ShortDatePattern + " " + dateTimeFormatInfo.ShortTimePattern + " zzz";
				}
				return left.ToString(format, CultureInfo.CurrentCulture);
			}
			if (left.TimeOfDay.TotalSeconds == 0.0)
			{
				return left.ToString("yyyy-MM-dd zzz", culture);
			}
			return left.ToString(culture);
		}
	}
}
