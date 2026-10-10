using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует строку в канонический формат.</summary>
	// Token: 0x02000076 RID: 118
	public sealed class WhiteSpaceTrimStringConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в каноническую форму.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект, представляющий значение для преобразования.</returns>
		// Token: 0x060003E1 RID: 993 RVA: 0x0000AE17 File Offset: 0x00009017
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			return ((string)data).Trim();
		}

		/// <summary>Преобразует <see cref="T:System.String" /> в каноническую форму.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>Объект, представляющий значение для преобразования.</returns>
		// Token: 0x060003E2 RID: 994 RVA: 0x0000AE24 File Offset: 0x00009024
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value == null)
			{
				return "";
			}
			if (!(value is string))
			{
				throw new ArgumentException("value");
			}
			return ((string)value).Trim();
		}
	}
}
