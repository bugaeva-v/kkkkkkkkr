using System;
using System.ComponentModel;

namespace System.Configuration
{
	/// <summary>Представляет отдельную именованную строку подключения в разделе строк подключения файла конфигурации.</summary>
	// Token: 0x02000038 RID: 56
	public sealed class ConnectionStringSettings : ConfigurationElement
	{
		// Token: 0x060001F3 RID: 499 RVA: 0x000073B8 File Offset: 0x000055B8
		static ConnectionStringSettings()
		{
			ConnectionStringSettings._propConnectionString = new ConfigurationProperty("connectionString", typeof(string), "", ConfigurationPropertyOptions.IsRequired);
			ConnectionStringSettings._properties.Add(ConnectionStringSettings._propName);
			ConnectionStringSettings._properties.Add(ConnectionStringSettings._propProviderName);
			ConnectionStringSettings._properties.Add(ConnectionStringSettings._propConnectionString);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConnectionStringSettings" />.</summary>
		// Token: 0x060001F4 RID: 500 RVA: 0x000067BB File Offset: 0x000049BB
		public ConnectionStringSettings()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Configuration.ConnectionStringSettings" />.</summary>
		/// <param name="name">Имя строки соединения.</param>
		/// <param name="connectionString">Строка подключения.</param>
		// Token: 0x060001F5 RID: 501 RVA: 0x00007465 File Offset: 0x00005665
		public ConnectionStringSettings(string name, string connectionString) : this(name, connectionString, "")
		{
		}

		/// <summary>Выполняет инициализацию нового экземпляра объекта <see cref="T:System.Configuration.ConnectionStringSettings" />.</summary>
		/// <param name="name">Имя строки соединения.</param>
		/// <param name="connectionString">Строка подключения.</param>
		/// <param name="providerName">Имя поставщика, используемое в строке подключения.</param>
		// Token: 0x060001F6 RID: 502 RVA: 0x00007474 File Offset: 0x00005674
		public ConnectionStringSettings(string name, string connectionString, string providerName)
		{
			this.Name = name;
			this.ConnectionString = connectionString;
			this.ProviderName = providerName;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00007491 File Offset: 0x00005691
		protected internal override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ConnectionStringSettings._properties;
			}
		}

		/// <summary>Возвращает или задает имя <see cref="T:System.Configuration.ConnectionStringSettings" />.</summary>
		/// <returns>Строковое значение, назначенное свойству <see cref="P:System.Configuration.ConnectionStringSettings.Name" />.</returns>
		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00007498 File Offset: 0x00005698
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x000074AA File Offset: 0x000056AA
		[ConfigurationProperty("name", DefaultValue = "", Options = (ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey))]
		public string Name
		{
			get
			{
				return (string)base[ConnectionStringSettings._propName];
			}
			set
			{
				base[ConnectionStringSettings._propName] = value;
			}
		}

		/// <summary>Возвращает или задает свойство имени поставщика.</summary>
		/// <returns>Свойство <see cref="P:System.Configuration.ConnectionStringSettings.ProviderName" />.</returns>
		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001FA RID: 506 RVA: 0x000074B8 File Offset: 0x000056B8
		// (set) Token: 0x060001FB RID: 507 RVA: 0x000074CA File Offset: 0x000056CA
		[ConfigurationProperty("providerName", DefaultValue = "System.Data.SqlClient")]
		public string ProviderName
		{
			get
			{
				return (string)base[ConnectionStringSettings._propProviderName];
			}
			set
			{
				base[ConnectionStringSettings._propProviderName] = value;
			}
		}

		/// <summary>Возвращает или задает строку подключения.</summary>
		/// <returns>Строковое значение, назначенное свойству <see cref="P:System.Configuration.ConnectionStringSettings.ConnectionString" />.</returns>
		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001FC RID: 508 RVA: 0x000074D8 File Offset: 0x000056D8
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000074EA File Offset: 0x000056EA
		[ConfigurationProperty("connectionString", DefaultValue = "", Options = ConfigurationPropertyOptions.IsRequired)]
		public string ConnectionString
		{
			get
			{
				return (string)base[ConnectionStringSettings._propConnectionString];
			}
			set
			{
				base[ConnectionStringSettings._propConnectionString] = value;
			}
		}

		/// <summary>Возвращает строковое представление объекта.</summary>
		/// <returns>Строковое представление объекта.</returns>
		// Token: 0x060001FE RID: 510 RVA: 0x000074F8 File Offset: 0x000056F8
		public override string ToString()
		{
			return this.ConnectionString;
		}

		// Token: 0x040000D7 RID: 215
		private static ConfigurationPropertyCollection _properties = new ConfigurationPropertyCollection();

		// Token: 0x040000D8 RID: 216
		private static readonly ConfigurationProperty _propConnectionString;

		// Token: 0x040000D9 RID: 217
		private static readonly ConfigurationProperty _propName = new ConfigurationProperty("name", typeof(string), null, TypeDescriptor.GetConverter(typeof(string)), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);

		// Token: 0x040000DA RID: 218
		private static readonly ConfigurationProperty _propProviderName = new ConfigurationProperty("providerName", typeof(string), "", ConfigurationPropertyOptions.None);
	}
}
