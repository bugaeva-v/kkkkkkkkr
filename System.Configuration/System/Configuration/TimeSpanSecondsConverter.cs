using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует временной интервал, выраженный в секундах.</summary>
	// Token: 0x02000070 RID: 112
	public class TimeSpanSecondsConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, представляющий параметр <paramref name="data" /> в секундах.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="data" /> не удается анализировать как целое число.</exception>
		// Token: 0x060003C5 RID: 965 RVA: 0x0000AADC File Offset: 0x00008CDC
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if (!(data is string))
			{
				throw new ArgumentException("data");
			}
			long num;
			if (!long.TryParse((string)data, out num))
			{
				throw new ArgumentException("data");
			}
			return TimeSpan.FromSeconds((double)num);
		}

		/// <summary>Преобразует <see cref="T:System.TimeSpan" /> в <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>Объект <see cref="T:System.String" />, который представляет параметр <paramref name="value" /> в минутах.</returns>
		// Token: 0x060003C6 RID: 966 RVA: 0x0000AB24 File Offset: 0x00008D24
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value.GetType() != typeof(TimeSpan))
			{
				throw new ArgumentException();
			}
			return ((long)((TimeSpan)value).TotalSeconds).ToString();
		}
	}
}
