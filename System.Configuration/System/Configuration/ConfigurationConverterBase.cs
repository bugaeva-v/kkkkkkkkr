using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Базовый класс для типов преобразователя конфигурации.</summary>
	// Token: 0x02000018 RID: 24
	public abstract class ConfigurationConverterBase : TypeConverter
	{
		/// <summary>Определяет, разрешено ли преобразование.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" />, используемый для преобразований типов.</param>
		/// <param name="type">Тип <see cref="T:System.Type" />, из которого выполняется преобразование.</param>
		/// <returns>Значение <see langword="true" />, если преобразование разрешено, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000093 RID: 147 RVA: 0x000035AB File Offset: 0x000017AB
		public override bool CanConvertFrom(ITypeDescriptorContext ctx, Type type)
		{
			return type == typeof(string) || base.CanConvertFrom(ctx, type);
		}

		/// <summary>Определяет, разрешено ли преобразование.</summary>
		/// <param name="ctx">Объект <see cref="T:System.ComponentModel.ITypeDescriptorContext" /> используется для преобразования типов.</param>
		/// <param name="type">Целевой тип преобразования.</param>
		/// <returns>Значение <see langword="true" />, если преобразование разрешено, в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06000094 RID: 148 RVA: 0x000035C9 File Offset: 0x000017C9
		public override bool CanConvertTo(ITypeDescriptorContext ctx, Type type)
		{
			return type == typeof(string) || base.CanConvertTo(ctx, type);
		}
	}
}
