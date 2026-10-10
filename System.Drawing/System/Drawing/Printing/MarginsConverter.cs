using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Text.RegularExpressions;

namespace System.Drawing.Printing
{
	/// <summary>Предоставляет <see cref="T:System.Drawing.Printing.MarginsConverter" /> для <see cref="T:System.Drawing.Printing.Margins" />.</summary>
	// Token: 0x020000CC RID: 204
	public class MarginsConverter : ExpandableObjectConverter
	{
		/// <summary>Возвращает значение, определяющее, может ли преобразователь преобразовывать объект заданного типа источника с помощью контекста в собственный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий конечный тип преобразования.</param>
		/// <returns>
		///   <see langword="true" />, если объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06000AD4 RID: 2772 RVA: 0x00003338 File Offset: 0x00001538
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Возвращает значение, определяющее, может ли преобразователь преобразовывать объект с помощью контекста в заданный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">
		///   <see cref="T:System.Type" /> представляет нужный результат конвертирования.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000BB98 File Offset: 0x00009D98
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует указанный объект в собственный тип преобразователя.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">
		///   <see cref="T:System.Globalization.CultureInfo" />, предоставляющий язык, в который нужно преобразовать объект.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="value" /> не содержит значения для всех четырех полей. Например, значение "100,100,100,100" задает левое, правое, верхнее и нижнее поля равными 1 дюйму.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000AD6 RID: 2774 RVA: 0x000187A4 File Offset: 0x000169A4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			if (!(value is string))
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (value == null)
			{
				return new Margins();
			}
			string text = "( |\\t)*";
			text = text + ";" + text;
			Match match = new Regex(string.Concat(new string[]
			{
				"(?<left>\\d+)",
				text,
				"(?<right>\\d+)",
				text,
				"(?<top>\\d+)",
				text,
				"(?<bottom>\\d+)"
			})).Match(value as string);
			if (!match.Success)
			{
				throw new ArgumentException("value");
			}
			int left;
			int right;
			int top;
			int bottom;
			try
			{
				left = int.Parse(match.Groups["left"].Value);
				right = int.Parse(match.Groups["right"].Value);
				top = int.Parse(match.Groups["top"].Value);
				bottom = int.Parse(match.Groups["bottom"].Value);
			}
			catch (Exception innerException)
			{
				throw new ArgumentException("value", innerException);
			}
			return new Margins(left, right, top, bottom);
		}

		/// <summary>Преобразует указанное значение объекта с помощью указанного контекста и аргументов в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">
		///   <see cref="T:System.Globalization.CultureInfo" />, предоставляющий язык, в который нужно преобразовать объект.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, для которого требуется преобразовать значение.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="destinationType" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06000AD7 RID: 2775 RVA: 0x000188D8 File Offset: 0x00016AD8
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is Margins)
			{
				Margins margins = value as Margins;
				return string.Format("{0}; {1}; {2}; {3}", new object[]
				{
					margins.Left,
					margins.Right,
					margins.Top,
					margins.Bottom
				});
			}
			if (destinationType == typeof(InstanceDescriptor) && value is Margins)
			{
				Margins margins2 = (Margins)value;
				return new InstanceDescriptor(typeof(Margins).GetTypeInfo().GetConstructor(new Type[]
				{
					typeof(int),
					typeof(int),
					typeof(int),
					typeof(int)
				}), new object[]
				{
					margins2.Left,
					margins2.Right,
					margins2.Top,
					margins2.Bottom
				});
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Возвращает значение, показывающее, требуется ли при изменении значения этого объекта вызывать метод <see cref="M:System.Drawing.Printing.MarginsConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" />, чтобы создать новое значение, используя заданную контекстную информацию.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, если для изменения свойства в этом объекте требуется вызов <see cref="M:System.Drawing.Printing.MarginsConverter.CreateInstance(System.ComponentModel.ITypeDescriptorContext,System.Collections.IDictionary)" />, чтобы создать новое значение; в противном случае — значение <see langword="false" />. Этот метод всегда возвращает значение <see langword="true" />.</returns>
		// Token: 0x06000AD8 RID: 2776 RVA: 0x00003610 File Offset: 0x00001810
		public override bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Создает объект <see cref="T:System.Object" />, задающий набор значений свойства для объекта.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="propertyValues">
		///   <see cref="T:System.Collections.IDictionary" /> новых значений свойств.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий указанный <see cref="T:System.Collections.IDictionary" />, or <see langword="null" />, если объект создать невозможно.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="propertyValues" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000AD9 RID: 2777 RVA: 0x00018A18 File Offset: 0x00016C18
		public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			object result;
			try
			{
				result = new Margins
				{
					Left = int.Parse(propertyValues["Left"].ToString()),
					Right = int.Parse(propertyValues["Right"].ToString()),
					Top = int.Parse(propertyValues["Top"].ToString()),
					Bottom = int.Parse(propertyValues["Bottom"].ToString())
				};
			}
			catch (Exception)
			{
				result = null;
			}
			return result;
		}
	}
}
