using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует строку в стандартное бесконечное <see cref="T:System.TimeSpan" /> значение и обратно.</summary>
	// Token: 0x02000046 RID: 70
	public sealed class InfiniteTimeSpanConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see cref="F:System.TimeSpan.MaxValue" />, если параметр <paramref name="data" /> равен "бесконечности" <see cref="T:System.String" />; в противном случае — <see cref="T:System.TimeSpan" />, представляющее значение параметра <paramref name="data" /> в минутах.</returns>
		// Token: 0x06000251 RID: 593 RVA: 0x00007AD6 File Offset: 0x00005CD6
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if ((string)data == "Infinite")
			{
				return TimeSpan.MaxValue;
			}
			return TimeSpan.Parse((string)data);
		}

		/// <summary>Преобразует <see cref="T:System.TimeSpan" /> в <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">
		///   <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования объекта.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <param name="type">Тип преобразования.</param>
		/// <returns>
		///   <see cref="T:System.String" /> "бесконечность", если параметр <paramref name="value" /> равен <see cref="F:System.TimeSpan.MaxValue" />; в противном случае — <see cref="T:System.String" />, представляющее параметр <paramref name="value" /> в минутах.</returns>
		// Token: 0x06000252 RID: 594 RVA: 0x00007B05 File Offset: 0x00005D05
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value.GetType() != typeof(TimeSpan))
			{
				throw new ArgumentException();
			}
			if ((TimeSpan)value == TimeSpan.MaxValue)
			{
				return "Infinite";
			}
			return value.ToString();
		}
	}
}
