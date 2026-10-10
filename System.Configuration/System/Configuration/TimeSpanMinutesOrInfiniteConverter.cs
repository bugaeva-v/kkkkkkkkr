using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует <see cref="T:System.TimeSpan" />, выраженный в минутах или как стандартный бесконечный временной диапазон.</summary>
	// Token: 0x0200006F RID: 111
	public sealed class TimeSpanMinutesOrInfiniteConverter : TimeSpanMinutesConverter
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see cref="F:System.TimeSpan.MaxValue" />, если параметр <paramref name="data" /> равен "бесконечности" <see cref="T:System.String" />; в противном случае — <see cref="T:System.TimeSpan" />, представляющее значение параметра <paramref name="data" /> в минутах.</returns>
		// Token: 0x060003C2 RID: 962 RVA: 0x0000AA59 File Offset: 0x00008C59
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if ((string)data == "Infinite")
			{
				return TimeSpan.MaxValue;
			}
			return base.ConvertFrom(ctx, ci, data);
		}

		/// <summary>Преобразует <see cref="T:System.TimeSpan" /> в <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <param name="type">Тип преобразования.</param>
		/// <returns>
		///   <see cref="T:System.String" /> "бесконечность", если параметр <paramref name="value" /> равен <see cref="F:System.TimeSpan.MaxValue" />; в противном случае — <see cref="T:System.String" />, представляющее параметр <paramref name="value" /> в минутах.</returns>
		// Token: 0x060003C3 RID: 963 RVA: 0x0000AA84 File Offset: 0x00008C84
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
