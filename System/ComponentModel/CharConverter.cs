using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов символов Юникода в другие представления и обратно.</summary>
	// Token: 0x02000389 RID: 905
	public class CharConverter : TypeConverter
	{
		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в символьный объект Юникод, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001DD5 RID: 7637 RVA: 0x0001846B File Offset: 0x0001666B
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Преобразовывает объект с заданным значением в символьный объект Юникод, используя аргументы.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Язык и региональные параметры, в которые будет выполнено преобразование <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001DD6 RID: 7638 RVA: 0x00069989 File Offset: 0x00067B89
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == typeof(string) && value is char && (char)value == '\0')
			{
				return "";
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		/// <summary>Преобразует данный объект в символьный объект Юникод.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Язык и региональные параметры, в которые будет выполнено преобразование <paramref name="value" />.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001DD7 RID: 7639 RVA: 0x000699C0 File Offset: 0x00067BC0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			if (text.Length > 1)
			{
				text = text.Trim();
			}
			if (text.Length <= 0)
			{
				return '\0';
			}
			if (text.Length != 1)
			{
				throw new FormatException(SR.Format("{0} is not a valid value for {1}.", text, "Char"));
			}
			return text[0];
		}
	}
}
