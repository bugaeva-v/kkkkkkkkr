using System;

namespace System.Configuration
{
	/// <summary>Определяет механизм сериализации, который должен использовать поставщик параметров. Этот класс не наследуется.</summary>
	// Token: 0x020001D8 RID: 472
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
	public sealed class SettingsSerializeAsAttribute : Attribute
	{
		/// <summary>Инициализирует экземпляр класса <see cref="T:System.Configuration.SettingsSerializeAsAttribute" />.</summary>
		/// <param name="serializeAs">Перечисленное значение <see cref="T:System.Configuration.SettingsSerializeAs" />, указывающее схему сериализации.</param>
		// Token: 0x06000C56 RID: 3158 RVA: 0x00032756 File Offset: 0x00030956
		public SettingsSerializeAsAttribute(SettingsSerializeAs serializeAs)
		{
			this.serializeAs = serializeAs;
		}

		/// <summary>Возвращает значение перечисления <see cref="T:System.Configuration.SettingsSerializeAs" />, указывающее схему сериализации.</summary>
		/// <returns>Перечисленное значение <see cref="T:System.Configuration.SettingsSerializeAs" />, указывающее схему сериализации.</returns>
		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00032765 File Offset: 0x00030965
		public SettingsSerializeAs SerializeAs
		{
			get
			{
				return this.serializeAs;
			}
		}

		// Token: 0x040007B8 RID: 1976
		private SettingsSerializeAs serializeAs;
	}
}
