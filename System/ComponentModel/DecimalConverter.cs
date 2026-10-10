using System;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel
{
	/// <summary>Предоставляет преобразователь типов для преобразования объектов <see cref="T:System.Decimal" /> в прочие представления и обратно.</summary>
	// Token: 0x02000399 RID: 921
	public class DecimalConverter : BaseNumberConverter
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00003062 File Offset: 0x00001262
		internal override bool AllowHex
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0006B8A2 File Offset: 0x00069AA2
		internal override Type TargetType
		{
			get
			{
				return typeof(decimal);
			}
		}

		/// <summary>Возвращает значение, указывающее, может ли данный преобразователь преобразовать объект с помощью контекста в заданный конечный тип.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="destinationType">Объект <see cref="T:System.Type" />, представляющий тип, в который необходимо выполнить преобразование.</param>
		/// <returns>Имеет значение <see langword="true" />, если преобразователь может выполнить преобразование, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06001E2C RID: 7724 RVA: 0x0006B8AE File Offset: 0x00069AAE
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return destinationType == typeof(InstanceDescriptor) || base.CanConvertTo(context, destinationType);
		}

		/// <summary>Преобразует объект с заданным значением в <see cref="T:System.Decimal" />, используя заданные аргументы.</summary>
		/// <param name="context">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, предоставляющий контекст формата.</param>
		/// <param name="culture">Необязательный класс <see cref="T:System.Globalization.CultureInfo" />. Если не предоставляются, предполагается использование текущего языка и региональных параметров.</param>
		/// <param name="value">Преобразуемый объект <see cref="T:System.Object" />.</param>
		/// <param name="destinationType">Тип <see cref="T:System.Type" />, к которому следует привести значение.</param>
		/// <returns>
		///   <see cref="T:System.Object" />, представляющий преобразованное значение.</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="destinationType" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.NotSupportedException">Преобразование не может быть выполнено.</exception>
		// Token: 0x06001E2D RID: 7725 RVA: 0x0006B8CC File Offset: 0x00069ACC
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			if (destinationType == null)
			{
				throw new ArgumentNullException("destinationType");
			}
			if (!(destinationType == typeof(InstanceDescriptor)) || !(value is decimal))
			{
				return base.ConvertTo(context, culture, value, destinationType);
			}
			object[] arguments = new object[]
			{
				decimal.GetBits((decimal)value)
			};
			MemberInfo constructor = typeof(decimal).GetConstructor(new Type[]
			{
				typeof(int[])
			});
			if (constructor != null)
			{
				return new InstanceDescriptor(constructor, arguments);
			}
			return null;
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x0006B95F File Offset: 0x00069B5F
		internal override object FromString(string value, int radix)
		{
			return Convert.ToDecimal(value, CultureInfo.CurrentCulture);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x0006B971 File Offset: 0x00069B71
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return decimal.Parse(value, NumberStyles.Float, formatInfo);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x0006B984 File Offset: 0x00069B84
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return ((decimal)value).ToString("G", formatInfo);
		}
	}
}
