using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет максимальное количество подключений к удаленному компьютеру. Этот класс не наследуется.</summary>
	// Token: 0x02000760 RID: 1888
	public sealed class ConnectionManagementElement : ConfigurationElement
	{
		// Token: 0x06003B91 RID: 15249 RVA: 0x000CC530 File Offset: 0x000CA730
		static ConnectionManagementElement()
		{
			ConnectionManagementElement.properties = new ConfigurationPropertyCollection();
			ConnectionManagementElement.properties.Add(ConnectionManagementElement.addressProp);
			ConnectionManagementElement.properties.Add(ConnectionManagementElement.maxConnectionProp);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.ConnectionManagementElement" />.</summary>
		// Token: 0x06003B92 RID: 15250 RVA: 0x00031238 File Offset: 0x0002F438
		public ConnectionManagementElement()
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.ConnectionManagementElement" /> с указанными сведениями об адресе и максимальном количестве подключений.</summary>
		/// <param name="address">Строка, определяющая адрес удаленного компьютера.</param>
		/// <param name="maxConnection">Целое число, определяющее максимально допустимое количество подключений к компьютеру по адресу <paramref name="address" /> с локального компьютера.</param>
		// Token: 0x06003B93 RID: 15251 RVA: 0x000CC5A0 File Offset: 0x000CA7A0
		public ConnectionManagementElement(string address, int maxConnection)
		{
			this.Address = address;
			this.MaxConnection = maxConnection;
		}

		/// <summary>Возвращает или задает адрес удаленных компьютеров.</summary>
		/// <returns>Строка, содержащая регулярное выражение, описывающее IP-адрес или DNS-имя.</returns>
		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06003B94 RID: 15252 RVA: 0x000CC5B6 File Offset: 0x000CA7B6
		// (set) Token: 0x06003B95 RID: 15253 RVA: 0x000CC5C8 File Offset: 0x000CA7C8
		[ConfigurationProperty("address", Options = (ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey))]
		public string Address
		{
			get
			{
				return (string)base[ConnectionManagementElement.addressProp];
			}
			set
			{
				base[ConnectionManagementElement.addressProp] = value;
			}
		}

		/// <summary>Возвращает или задает максимальное количество подключений к удаленному компьютеру.</summary>
		/// <returns>Целое число, задающее максимальное количество подключений.</returns>
		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x06003B96 RID: 15254 RVA: 0x000CC5D6 File Offset: 0x000CA7D6
		// (set) Token: 0x06003B97 RID: 15255 RVA: 0x000CC5E8 File Offset: 0x000CA7E8
		[ConfigurationProperty("maxconnection", DefaultValue = "6", Options = ConfigurationPropertyOptions.IsRequired)]
		public int MaxConnection
		{
			get
			{
				return (int)base[ConnectionManagementElement.maxConnectionProp];
			}
			set
			{
				base[ConnectionManagementElement.maxConnectionProp] = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06003B98 RID: 15256 RVA: 0x000CC5FB File Offset: 0x000CA7FB
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ConnectionManagementElement.properties;
			}
		}

		// Token: 0x04002380 RID: 9088
		private static ConfigurationPropertyCollection properties;

		// Token: 0x04002381 RID: 9089
		private static ConfigurationProperty addressProp = new ConfigurationProperty("address", typeof(string), null, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);

		// Token: 0x04002382 RID: 9090
		private static ConfigurationProperty maxConnectionProp = new ConfigurationProperty("maxconnection", typeof(int), 1, ConfigurationPropertyOptions.IsRequired);
	}
}
