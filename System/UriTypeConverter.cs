using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace System
{
	/// <summary>Преобразует значение типа <see cref="T:System.String" /> к типу <see cref="T:System.Uri" /> и наоборот.</summary>
	// Token: 0x02000176 RID: 374
	public class UriTypeConverter : TypeConverter
	{
		// Token: 0x060009E6 RID: 2534 RVA: 0x0002BB05 File Offset: 0x00029D05
		private bool CanConvert(Type type)
		{
			return type == typeof(string) || type == typeof(Uri) || type == typeof(InstanceDescriptor);
		}

		/// <summary>Возвращает значение, указывающее, может ли этот преобразователь преобразовать объект заданного типа к типу этого преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, от которого требуется выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="sourceType" /> является типом <see cref="T:System.String" /> либо или к типу <see cref="T:System.Uri" /> может быть преобразовано значение типа <paramref name="sourceType" />; в противном случае — <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="sourceType" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060009E7 RID: 2535 RVA: 0x0002BB3F File Offset: 0x00029D3F
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			if (sourceType == null)
			{
				throw new ArgumentNullException("sourceType");
			}
			return this.CanConvert(sourceType);
		}

		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь преобразовать объект в заданный тип с помощью указанного контекста.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, представляющий тип, к которому требуется выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="destinationType" /> является типом <see cref="T:System.ComponentModel.Design.Serialization.InstanceDescriptor" />, <see cref="T:System.String" /> или <see cref="T:System.Uri" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060009E8 RID: 2536 RVA: 0x0002BB5C File Offset: 0x00029D5C
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return !(destinationType == null) && this.CanConvert(destinationType);
		}

		/// <summary>Преобразует заданный объект в тип этого преобразователя, используя указанные сведения о контексте и языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в качестве текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060009E9 RID: 2537 RVA: 0x0002BB70 File Offset: 0x00029D70
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (!this.CanConvertFrom(context, value.GetType()))
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert from value."));
			}
			if (value is Uri)
			{
				return value;
			}
			string text = value as string;
			if (text != null)
			{
				return new Uri(text, UriKind.RelativeOrAbsolute);
			}
			InstanceDescriptor instanceDescriptor = value as InstanceDescriptor;
			if (instanceDescriptor != null)
			{
				return instanceDescriptor.Invoke();
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Преобразует заданное значение объектного типа к заданному типу, используя заданные сведения о контексте и языке и региональных параметрах.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />. Если передано значение <see langword="null" />, используются текущие настройки языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">
		///   <see cref="T:System.Type" />, к которому преобразуется параметр <paramref name="value" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x060009EA RID: 2538 RVA: 0x0002BBE0 File Offset: 0x00029DE0
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (!this.CanConvertTo(context, destinationType))
			{
				throw new NotSupportedException(Locale.GetText("Cannot convert to destination type."));
			}
			Uri uri = value as Uri;
			if (uri != null)
			{
				if (destinationType == typeof(string))
				{
					return uri.ToString();
				}
				if (destinationType == typeof(Uri))
				{
					return uri;
				}
				if (destinationType == typeof(InstanceDescriptor))
				{
					return new InstanceDescriptor(typeof(Uri).GetConstructor(new Type[]
					{
						typeof(string),
						typeof(UriKind)
					}), new object[]
					{
						uri.ToString(),
						uri.IsAbsoluteUri ? UriKind.Absolute : UriKind.Relative
					});
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает значение, указывающее, является ли заданное значение объектного типа объектом <see cref="T:System.Uri" /> либо можно ли создать на основе этого значения объект <see cref="T:System.Uri" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="value">Объект <see cref="T:System.Object" /> для проверки на допустимость.</param>
		/// <returns>
		///   <see langword="true" />, если <paramref name="value" /> является значением типа <see cref="T:System.Uri" /> или значением типа <see cref="T:System.String" />, которое может быть преобразовано к типу <see cref="T:System.Uri" />; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060009EB RID: 2539 RVA: 0x0002BCC0 File Offset: 0x00029EC0
		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return value != null && (value is string || value is Uri);
		}
	}
}
