using System;

namespace System.Configuration
{
	/// <summary>Обеспечивает интерфейс для ввода параметров приложения от другого поставщика.</summary>
	// Token: 0x020001B4 RID: 436
	public interface ISettingsProviderService
	{
		/// <summary>Возвращает параметры поставщика совместимые со свойством определенных параметров.</summary>
		/// <param name="property">
		///   <see cref="T:System.Configuration.SettingsProperty" /> требует сериализации.</param>
		/// <returns>Если найдена <see cref="T:System.Configuration.SettingsProvider" />, что может сохранить заданные параметры, иначе <see langword="null" />.</returns>
		// Token: 0x06000B87 RID: 2951
		SettingsProvider GetSettingsProvider(SettingsProperty property);
	}
}
