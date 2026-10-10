using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace System.Drawing
{
	/// <summary>Преобразует объект <see cref="T:System.Drawing.Icon" /> из одного типа данных в другой. Доступ к данному классу осуществляется с помощью объекта <see cref="T:System.ComponentModel.TypeDescriptor" />.</summary>
	// Token: 0x0200007C RID: 124
	public class IconConverter : ExpandableObjectConverter
	{
		/// <summary>Определяет, может ли этот объект <see cref="T:System.Drawing.IconConverter" /> преобразовать экземпляр определенного типа в объект <see cref="T:System.Drawing.Icon" />, используя указанный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="sourceType">Объект <see cref="T:System.Type" /> задает тип, который необходимо преобразовать.</param>
		/// <returns>Метод возвращает значение <see langword="true" />, если код <see cref="T:System.Drawing.IconConverter" /> способен выполнить преобразование; иначе он возвращает <see langword="false" />.</returns>
		// Token: 0x060005DC RID: 1500 RVA: 0x00010DA2 File Offset: 0x0000EFA2
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return sourceType == typeof(byte[]);
		}

		/// <summary>Определяет, может ли преобразователь <see cref="T:System.Drawing.IconConverter" /> преобразовать объект <see cref="T:System.Drawing.Icon" /> в экземпляр заданного типа, используя указанный контекст.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, задающий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Метод возвращает значение <see langword="true" />, если код <see cref="T:System.Drawing.IconConverter" /> способен выполнить преобразование; иначе он возвращает <see langword="false" />.</returns>
		// Token: 0x060005DD RID: 1501 RVA: 0x00010DB9 File Offset: 0x0000EFB9
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(byte[]) || destinationType == typeof(string);
		}

		/// <summary>Преобразует указанный объект в <see cref="T:System.Drawing.Icon" />.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, содержащий сведения о заданных языке и региональных параметрах.</param>
		/// <param name="value">Преобразуемая структура <see cref="T:System.Object" />.</param>
		/// <returns>В случае успешного выполнения, метод возвращает объект <see cref="T:System.Drawing.Icon" />, созданный им путем преобразования указанного объекта. В противном случае выдается исключение.</returns>
		/// <exception cref="T:System.NotSupportedException">Не удалось выполнить преобразование.</exception>
		// Token: 0x060005DE RID: 1502 RVA: 0x00010DE4 File Offset: 0x0000EFE4
		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			byte[] array = value as byte[];
			if (array == null)
			{
				return base.ConvertFrom(context, culture, value);
			}
			return new Icon(new MemoryStream(array));
		}

		/// <summary>Преобразует объект <see cref="T:System.Drawing.Icon" /> (или объект, который может быть приведен к типу <see cref="T:System.Drawing.Icon" />) в указанный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Объект <see cref="T:System.Globalization.CultureInfo" />, который задает соглашение о форматировании, используемое для конкретного языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект. Этот объект должен относиться к типу "значок" (Icon) или такому типу, который может быть приведен к типу <see cref="T:System.Drawing.Icon" />.</param>
		/// <param name="destinationType">Тип, в который требуется преобразовать значок.</param>
		/// <returns>Данный метод возвращает преобразованный объект.</returns>
		/// <exception cref="T:System.NotSupportedException">Не удалось выполнить преобразование.</exception>
		// Token: 0x060005DF RID: 1503 RVA: 0x00010E10 File Offset: 0x0000F010
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (value is Icon && destinationType == typeof(string))
			{
				return value.ToString();
			}
			if (value == null && destinationType == typeof(string))
			{
				return "(none)";
			}
			if (this.CanConvertTo(null, destinationType))
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					((Icon)value).Save(memoryStream);
					return memoryStream.ToArray();
				}
			}
			string str = "IconConverter can not convert from ";
			Type type = value.GetType();
			return new NotSupportedException(str + ((type != null) ? type.ToString() : null));
		}
	}
}
