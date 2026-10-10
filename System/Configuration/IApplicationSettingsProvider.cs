using System;

namespace System.Configuration
{
	/// <summary>Определяет расширенные возможности для поставщиков установок для клиентских приложений.</summary>
	// Token: 0x020001AF RID: 431
	public interface IApplicationSettingsProvider
	{
		/// <summary>Возвращает значение указанного свойства установок для предыдущей версии того же приложения.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="property">
		///   <see cref="T:System.Configuration.SettingsProperty" />, значение которого должно быть возвращено.</param>
		/// <returns>Объект <see cref="T:System.Configuration.SettingsPropertyValue" />, содержащий значение указанного свойства установок, в том виде, как они были в последний раз установлены в предыдущей версии приложения; или <see langword="null" />, если установки не удается найти.</returns>
		// Token: 0x06000B78 RID: 2936
		SettingsPropertyValue GetPreviousVersion(SettingsContext context, SettingsProperty property);

		/// <summary>Возвращает установки, связанные с указанным приложением к значениям по умолчанию.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		// Token: 0x06000B79 RID: 2937
		void Reset(SettingsContext context);

		/// <summary>Указывает поставщику, что приложение было модернизировано. Это дает поставщику возможность обновлять хранимые параметры подходящим образом.</summary>
		/// <param name="context">Объект <see cref="T:System.Configuration.SettingsContext" />, описывающий текущее использование приложения.</param>
		/// <param name="properties">Объект <see cref="T:System.Configuration.SettingsPropertyCollection" />, содержащий группу свойств параметров, значения которых необходимо извлечь.</param>
		// Token: 0x06000B7A RID: 2938
		void Upgrade(SettingsContext context, SettingsPropertyCollection properties);
	}
}
