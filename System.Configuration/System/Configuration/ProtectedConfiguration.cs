using System;

namespace System.Configuration
{
	/// <summary>Предоставляет доступ к поставщикам защищенных конфигураций для файла конфигурации текущего приложения.</summary>
	// Token: 0x0200005C RID: 92
	public static class ProtectedConfiguration
	{
		/// <summary>Возвращает имя поставщика защищенной конфигурации по умолчанию.</summary>
		/// <returns>имя по умолчанию поставщика защищенной конфигурация.</returns>
		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00008AD3 File Offset: 0x00006CD3
		public static string DefaultProvider
		{
			get
			{
				return ProtectedConfiguration.Section.DefaultProvider;
			}
		}

		/// <summary>Возвращает коллекцию установленных поставщиков защищенных конфигураций.</summary>
		/// <returns>Коллекция <see cref="T:System.Configuration.ProtectedConfigurationProviderCollection" /> установленных <see cref="T:System.Configuration.ProtectedConfigurationProvider" /> объектов.</returns>
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000309 RID: 777 RVA: 0x00008ADF File Offset: 0x00006CDF
		public static ProtectedConfigurationProviderCollection Providers
		{
			get
			{
				return ProtectedConfiguration.Section.GetAllProviders();
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00008AEB File Offset: 0x00006CEB
		internal static ProtectedConfigurationSection Section
		{
			get
			{
				return (ProtectedConfigurationSection)ConfigurationManager.GetSection("configProtectedData");
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00008AFC File Offset: 0x00006CFC
		internal static ProtectedConfigurationProvider GetProvider(string name, bool throwOnError)
		{
			ProtectedConfigurationProvider protectedConfigurationProvider = ProtectedConfiguration.Providers[name];
			if (protectedConfigurationProvider == null && throwOnError)
			{
				throw new Exception(string.Format("The protection provider '{0}' was not found.", name));
			}
			return protectedConfigurationProvider;
		}

		/// <summary>Имя поставщика защищенных данных.</summary>
		// Token: 0x0400011E RID: 286
		public const string DataProtectionProviderName = "DataProtectionConfigurationProvider";

		/// <summary>Имя раздела защищенных данных.</summary>
		// Token: 0x0400011F RID: 287
		public const string ProtectedDataSectionName = "configProtectedData";

		/// <summary>Имя поставщика RSA.</summary>
		// Token: 0x04000120 RID: 288
		public const string RsaProviderName = "RsaProtectedConfigurationProvider";
	}
}
