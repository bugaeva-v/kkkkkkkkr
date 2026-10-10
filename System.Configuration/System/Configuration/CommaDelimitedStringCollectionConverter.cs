using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует строковое значение, разделенное запятыми в объект <see cref="T:System.Configuration.CommaDelimitedStringCollection" /> и обратно. Этот класс не наследуется.</summary>
	// Token: 0x02000010 RID: 16
	public sealed class CommaDelimitedStringCollectionConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует объект <see cref="T:System.String" /> в объект <see cref="T:System.Configuration.CommaDelimitedStringCollection" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразования типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемое строковое разделенное запятой значение <see cref="T:System.String" />.</param>
		/// <returns>Объект <see cref="T:System.Configuration.CommaDelimitedStringCollection" />, содержащий преобразованное значение.</returns>
		// Token: 0x06000037 RID: 55 RVA: 0x00002594 File Offset: 0x00000794
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			CommaDelimitedStringCollection commaDelimitedStringCollection = new CommaDelimitedStringCollection();
			foreach (string text in ((string)data).Split(',', StringSplitOptions.None))
			{
				commaDelimitedStringCollection.Add(text.Trim());
			}
			commaDelimitedStringCollection.UpdateStringHash();
			return commaDelimitedStringCollection;
		}

		/// <summary>Преобразует объект <see cref="T:System.Configuration.CommaDelimitedStringCollection" /> в объект <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразования типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Преобразуемое значение.</param>
		/// <param name="type">Тип преобразования.</param>
		/// <returns>Объект <see cref="T:System.String" />, представляющий преобразованный параметр <paramref name="value" />, который является <see cref="T:System.Configuration.CommaDelimitedStringCollection" />.</returns>
		// Token: 0x06000038 RID: 56 RVA: 0x000025DB File Offset: 0x000007DB
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value == null)
			{
				return null;
			}
			if (!typeof(StringCollection).IsAssignableFrom(value.GetType()))
			{
				throw new ArgumentException();
			}
			return value.ToString();
		}
	}
}
