using System;

namespace System.Configuration
{
	/// <summary>Представляют собой группу установок приложений пользователя в файле конфигурации.</summary>
	// Token: 0x0200019B RID: 411
	public sealed class ClientSettingsSection : ConfigurationSection
	{
		// Token: 0x06000ACF RID: 2767 RVA: 0x0002EA09 File Offset: 0x0002CC09
		static ClientSettingsSection()
		{
			ClientSettingsSection.properties = new ConfigurationPropertyCollection();
			ClientSettingsSection.properties.Add(ClientSettingsSection.settings_prop);
		}

		/// <summary>Возвращает коллекцию установок клиента для раздела.</summary>
		/// <returns>
		///   <see cref="T:System.Configuration.SettingElementCollection" /> содержит все установки клиента, найденные в текущем разделе конфигурации.</returns>
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002EA47 File Offset: 0x0002CC47
		[ConfigurationProperty("", Options = ConfigurationPropertyOptions.IsDefaultCollection)]
		public SettingElementCollection Settings
		{
			get
			{
				return (SettingElementCollection)base[ClientSettingsSection.settings_prop];
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002EA59 File Offset: 0x0002CC59
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ClientSettingsSection.properties;
			}
		}

		// Token: 0x0400072D RID: 1837
		private static ConfigurationPropertyCollection properties;

		// Token: 0x0400072E RID: 1838
		private static ConfigurationProperty settings_prop = new ConfigurationProperty("", typeof(SettingElementCollection), null, ConfigurationPropertyOptions.IsDefaultCollection);
	}
}
