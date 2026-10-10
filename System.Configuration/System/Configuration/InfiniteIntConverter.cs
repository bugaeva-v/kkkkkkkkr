using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует строку в стандартное бесконечное или целое число и обратно.</summary>
	// Token: 0x02000045 RID: 69
	public sealed class InfiniteIntConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.Int32" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see cref="F:System.Int32.MaxValue" />, если параметр <paramref name="data" /> равен "бесконечности" <see cref="T:System.String" />; в противном случае — <see cref="T:System.Int32" />, представляющее целое значение параметра <paramref name="data" />.</returns>
		// Token: 0x0600024E RID: 590 RVA: 0x00007A6D File Offset: 0x00005C6D
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if ((string)data == "Infinite")
			{
				return int.MaxValue;
			}
			return Convert.ToInt32((string)data, 10);
		}

		/// <summary>Преобразует <see cref="T:System.Int32" /> в <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>"Бесконечность" <see cref="T:System.String" />, если значение <paramref name="value" /> равно <see cref="F:System.Int32.MaxValue" />; в противном случае — <see cref="T:System.String" />, представляющее параметр <paramref name="value" />.</returns>
		// Token: 0x0600024F RID: 591 RVA: 0x00007A9E File Offset: 0x00005C9E
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value.GetType() != typeof(int))
			{
				throw new ArgumentException();
			}
			if ((int)value == 2147483647)
			{
				return "Infinite";
			}
			return value.ToString();
		}
	}
}
