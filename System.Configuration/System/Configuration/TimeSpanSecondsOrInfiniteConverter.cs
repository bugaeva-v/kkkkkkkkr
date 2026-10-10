using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует <see cref="T:System.TimeSpan" />, выраженный в секундах или как стандартный бесконечный временной диапазон.</summary>
	// Token: 0x02000071 RID: 113
	public sealed class TimeSpanSecondsOrInfiniteConverter : TimeSpanSecondsConverter
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see cref="F:System.TimeSpan.MaxValue" />, если параметр <paramref name="data" /> равен "бесконечности" <see cref="T:System.String" />; в противном случае — <see cref="T:System.TimeSpan" />, представляющее параметр <paramref name="data" /> в секундах.</returns>
		// Token: 0x060003C8 RID: 968 RVA: 0x0000AB65 File Offset: 0x00008D65
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if ((string)data == "Infinite")
			{
				return TimeSpan.MaxValue;
			}
			return base.ConvertFrom(ctx, ci, data);
		}

		/// <summary>Преобразует <see cref="T:System.TimeSpan" /> в. <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <param name="type">Тип преобразования.</param>
		/// <returns>"Бесконечность" <see cref="T:System.String" />, если параметр <paramref name="value" /> равен <see cref="F:System.TimeSpan.MaxValue" />; в противном случае — <see cref="T:System.String" /> представляющее параметр <paramref name="value" /> в секундах.</returns>
		// Token: 0x060003C9 RID: 969 RVA: 0x0000AB90 File Offset: 0x00008D90
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
			return base.ConvertTo(ctx, ci, value, type);
		}
	}
}
