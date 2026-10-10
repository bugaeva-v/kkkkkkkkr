using System;
using System.ComponentModel;
using System.Globalization;

namespace System.Configuration
{
	/// <summary>Преобразует между строковым типом и типом перечисления.</summary>
	// Token: 0x02000042 RID: 66
	public sealed class GenericEnumConverter : ConfigurationConverterBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.GenericEnumConverter" />.</summary>
		/// <param name="typeEnum">Преобразуемый тип перечисления.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="typeEnum" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06000240 RID: 576 RVA: 0x000079FD File Offset: 0x00005BFD
		public GenericEnumConverter(Type typeEnum)
		{
			if (typeEnum == null)
			{
				throw new ArgumentNullException("typeEnum");
			}
			this.typeEnum = typeEnum;
		}

		/// <summary>Преобразует <see cref="T:System.String" /> в тип <see cref="T:System.Enum" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="data">Преобразуемый объект <see cref="T:System.String" />.</param>
		/// <returns>Тип <see cref="T:System.Enum" />, представляющий параметр <paramref name="data" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="data" /> имеет значение null или равен пустой строке ("").  
		/// -или- 
		///  <paramref name="data" /> начинается с числового символа.  
		/// -или- 
		///  <paramref name="data" /> включает пробел.</exception>
		// Token: 0x06000241 RID: 577 RVA: 0x00007A20 File Offset: 0x00005C20
		public override object ConvertFrom(ITypeDescriptorContext ctx, CultureInfo ci, object data)
		{
			if (data == null)
			{
				throw new ArgumentException();
			}
			return Enum.Parse(this.typeEnum, (string)data);
		}

		/// <summary>Преобразует тип <see cref="T:System.Enum" /> в значение <see cref="T:System.String" />.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="ci">Объект <see cref="T:System.Globalization.CultureInfo" />, используемый в процессе преобразования.</param>
		/// <param name="value">Целевое значение преобразования.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>
		///   <see cref="T:System.String" />, представляющий параметр <paramref name="value" />.</returns>
		// Token: 0x06000242 RID: 578 RVA: 0x00007A3C File Offset: 0x00005C3C
		public override object ConvertTo(ITypeDescriptorContext ctx, CultureInfo ci, object value, Type type)
		{
			return value.ToString();
		}

		// Token: 0x040000EA RID: 234
		private Type typeEnum;
	}
}
