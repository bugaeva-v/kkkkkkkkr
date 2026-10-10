using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует тип в строковое значение и обратно. Этот класс не наследуется.</summary>
	// Token: 0x02000074 RID: 116
	public sealed class TypeNameConverter : ConfigurationConverterBase
	{
		/// <summary>Преобразует объект <see cref="T:System.String" /> в объект <see cref="T:System.Type" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>
		///   <see cref="T:System.Type" />, представляющий параметр <paramref name="data" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение <see cref="T:System.Type" /> не удается разрешить.</exception>
		// Token: 0x060003DA RID: 986 RVA: 0x0000ADE5 File Offset: 0x00008FE5
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			return Type.GetType((string)data);
		}

		/// <summary>Преобразует объект <see cref="T:System.Type" /> в объект <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>
		///   <see cref="T:System.String" />, представляющий параметр <paramref name="value" />.</returns>
		// Token: 0x060003DB RID: 987 RVA: 0x0000ADF2 File Offset: 0x00008FF2
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			if (value == null)
			{
				return null;
			}
			if (!(value is Type))
			{
				throw new ArgumentException("value");
			}
			return ((Type)value).AssemblyQualifiedName;
		}
	}
}
