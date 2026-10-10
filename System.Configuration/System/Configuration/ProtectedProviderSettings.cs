using System;

namespace System.Configuration
{
	/// <summary>Представляет группу элементов конфигурации, используемых для настройки поставщиков для раздела конфигурации <see langword="&lt;configProtectedData&gt;" />.</summary>
	// Token: 0x02000060 RID: 96
	public class ProtectedProviderSettings : ConfigurationElement
	{
		// Token: 0x0600031C RID: 796 RVA: 0x00008D04 File Offset: 0x00006F04
		static ProtectedProviderSettings()
		{
			ProtectedProviderSettings.properties.Add(ProtectedProviderSettings.providersProp);
		}

		/// <summary>Возвращает коллекцию <see cref="T:System.Configuration.ConfigurationPropertyCollection" />, представляющую свойства поставщиков для защищенных данных конфигурации.</summary>
		/// <returns>
		///   <see cref="T:System.Configuration.ConfigurationPropertyCollection" />, представляющая свойства поставщиков для защищенных данных конфигурации.</returns>
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00008D3C File Offset: 0x00006F3C
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ProtectedProviderSettings.properties;
			}
		}

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Configuration.ProviderSettings" />, представляющих свойства поставщиков для защищенных данных конфигурации.</summary>
		/// <returns>Коллекция объектов <see cref="T:System.Configuration.ProviderSettings" /> , представляющая свойства поставщиков для защищенных данных конфигурации.</returns>
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00008D43 File Offset: 0x00006F43
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public ProviderSettingsCollection Providers
		{
			get
			{
				return (ProviderSettingsCollection)base[ProtectedProviderSettings.providersProp];
			}
		}

		// Token: 0x04000125 RID: 293
		private static ConfigurationProperty providersProp = new ConfigurationProperty("", typeof(ProviderSettingsCollection), null, null, null, ConfigurationPropertyOptions.IsDefaultCollection);

		// Token: 0x04000126 RID: 294
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
