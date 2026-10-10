using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует временной интервал, выраженный в минутах.</summary>
	// Token: 0x0200006E RID: 110
	public class TimeSpanMinutesConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует <see cref="T:System.String" /> в <see cref="T:System.TimeSpan" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, представляющий параметр <paramref name="data" /> в минутах.</returns>
		// Token: 0x060003BF RID: 959 RVA: 0x0000A9FD File Offset: 0x00008BFD
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			return TimeSpan.FromMinutes((double)long.Parse((string)data));
		}

		/// <summary>Преобразует <see cref="T:System.TimeSpan" /> в <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>Объект <see cref="T:System.String" />, представляющий параметр <paramref name="value" /> в минутах.</returns>
		// Token: 0x060003C0 RID: 960 RVA: 0x0000AA18 File Offset: 0x00008C18
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value.GetType() != typeof(TimeSpan))
			{
				throw new ArgumentException();
			}
			return ((long)((TimeSpan)value).TotalMinutes).ToString();
		}
	}
}
