using System;
using System.Collections.Specialized;

namespace System.Configuration
{
	/// <summary>Обеспечивает поддержку рабочих версий 1.0 и 1.1, поддерживающих чтение разделов конфигурации и общих параметров конфигурации.</summary>
	// Token: 0x020001A6 RID: 422
	public sealed class ConfigurationSettings
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x0000219B File Offset: 0x0000039B
		private ConfigurationSettings()
		{
		}

		/// <summary>Возвращает <see cref="T:System.Configuration.ConfigurationSection" /> объект для проверенного имени и пути раздела конфигурации.</summary>
		/// <param name="sectionName">Имя и путь конфигурации, такие как system.net/settings.</param>
		/// <returns>Объект <see cref="T:System.Configuration.ConfigurationSection" /> для проверенного имени и пути раздела конфигурации.  
		///
		///  <see cref="T:System.Configuration.ConfigurationSettings" /> класс обеспечивает только обратную совместимость. Следует использовать <see cref="T:System.Configuration.ConfigurationManager" /> класс, или <see cref="T:System.Web.Configuration.WebConfigurationManager" /> класс, вместо предыдущего.</returns>
		/// <exception cref="T:System.Configuration.ConfigurationException">Не удалось извлечь запрашиваемый раздел.</exception>
		// Token: 0x06000B12 RID: 2834 RVA: 0x0002DC32 File Offset: 0x0002BE32
		[Obsolete("This method is obsolete, it has been replaced by System.Configuration!System.Configuration.ConfigurationManager.GetSection")]
		public static object GetConfig(string sectionName)
		{
			return ConfigurationManager.GetSection(sectionName);
		}

		/// <summary>Устанавливается как доступный только для чтения <see cref="T:System.Collections.Specialized.NameValueCollection" /> в разделе параметров приложения файла конфигурации.</summary>
		/// <returns>Устанавливается как доступный только для чтения<see cref="T:System.Collections.Specialized.NameValueCollection" /> в разделе параметров приложения файла конфигурации.</returns>
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x0002F348 File Offset: 0x0002D548
		[Obsolete("This property is obsolete.  Please use System.Configuration.ConfigurationManager.AppSettings")]
		public static NameValueCollection AppSettings
		{
			get
			{
				object obj = ConfigurationManager.GetSection("appSettings");
				if (obj == null)
				{
					obj = new NameValueCollection();
				}
				return (NameValueCollection)obj;
			}
		}

		// Token: 0x06000B14 RID: 2836 RVA: 0x0002F370 File Offset: 0x0002D570
		internal static IConfigurationSystem ChangeConfigurationSystem(IConfigurationSystem newSystem)
		{
			if (newSystem == null)
			{
				throw new ArgumentNullException("newSystem");
			}
			object obj = ConfigurationSettings.lockobj;
			IConfigurationSystem result;
			lock (obj)
			{
				IConfigurationSystem configurationSystem = ConfigurationSettings.config;
				ConfigurationSettings.config = newSystem;
				result = configurationSystem;
			}
			return result;
		}

		// Token: 0x04000742 RID: 1858
		private static IConfigurationSystem config = DefaultConfig.GetInstance();

		// Token: 0x04000743 RID: 1859
		private static object lockobj = new object();
	}
}
