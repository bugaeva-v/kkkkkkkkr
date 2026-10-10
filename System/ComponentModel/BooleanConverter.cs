using System;
using System.Globalization;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Boolean" /> в прочие представления и обратно.</summary>
	// Token: 0x02000386 RID: 902
	public class BooleanConverter : TypeConverter
	{
		/// <summary>Возвращает значение, показывающее, может ли этот преобразователь выполнить преобразование объекта заданного исходного типа в объект типа Boolean, используя заданный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Тип <see cref="T:System.Type" />, представляющий тип, из которого нужно выполнить преобразование.</param>
		/// <returns>
		///   <see langword="true" />, если этот объект может выполнить преобразование; в противном случае — <see langword="false" />.</returns>
		// Token: 0x06001DC6 RID: 7622 RVA: 0x0001846B File Offset: 0x0001666B
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		/// <summary>Преобразует данный объект значения в объект Boolean.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, определяющий язык и региональные параметры для преобразования.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <returns>Объект <see cref="T:System.Object" />, представляющий преобразованное значение <paramref name="value" />.</returns>
		/// <exception cref="T:System.FormatException">Значение <paramref name="value" /> не является допустимым значением для конечного типа.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001DC7 RID: 7623 RVA: 0x000698A0 File Offset: 0x00067AA0
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				text = text.Trim();
				try
				{
					return bool.Parse(text);
				}
				catch (FormatException innerException)
				{
					throw new FormatException(SR.Format("{0} is not a valid value for {1}.", (string)value, "Boolean"), innerException);
				}
			}
			return base.ConvertFrom(context, culture, value);
		}

		/// <summary>Возвращает коллекцию стандартных значений для типа данных Boolean.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, содержащая стандартный набор допустимых значений.</returns>
		// Token: 0x06001DC8 RID: 7624 RVA: 0x00069904 File Offset: 0x00067B04
		public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			TypeConverter.StandardValuesCollection result;
			if ((result = BooleanConverter.s_values) == null)
			{
				result = (BooleanConverter.s_values = new TypeConverter.StandardValuesCollection(new object[]
				{
					true,
					false
				}));
			}
			return result;
		}

		/// <summary>Возвращает значение, показывающее, является ли список стандартных значений, возвращенных методом <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, исчерпывающим.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как коллекция <see cref="T:System.ComponentModel.TypeConverter.StandardValuesCollection" />, возвращенная методом <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />, является исчерпывающим списком возможных значений. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06001DC9 RID: 7625 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return true;
		}

		/// <summary>Получает значение, показывающее, поддерживает ли этот объект стандартный набор значений, которые можно выбрать из списка.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <returns>Значение <see langword="true" />, так как для поиска общего набора значений, поддерживаемых объектом, можно вызвать метод <see cref="M:System.ComponentModel.BooleanConverter.GetStandardValues(System.ComponentModel.ITypeDescriptorContext)" />. Этот метод никогда не возвращает значение <see langword="false" />.</returns>
		// Token: 0x06001DCA RID: 7626 RVA: 0x0000390E File Offset: 0x00001B0E
		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return true;
		}

		// Token: 0x04000EF5 RID: 3829
		private static volatile TypeConverter.StandardValuesCollection s_values;
	}
}
