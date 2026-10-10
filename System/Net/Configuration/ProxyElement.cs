using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Идентифицирует параметры конфигурации сервера веб-прокси. Этот класс не наследуется.</summary>
	// Token: 0x02000772 RID: 1906
	public sealed class ProxyElement : ConfigurationElement
	{
		// Token: 0x06003C05 RID: 15365 RVA: 0x000CD85C File Offset: 0x000CBA5C
		static ProxyElement()
		{
			ProxyElement.properties = new ConfigurationPropertyCollection();
			ProxyElement.properties.Add(ProxyElement.autoDetectProp);
			ProxyElement.properties.Add(ProxyElement.bypassOnLocalProp);
			ProxyElement.properties.Add(ProxyElement.proxyAddressProp);
			ProxyElement.properties.Add(ProxyElement.scriptLocationProp);
			ProxyElement.properties.Add(ProxyElement.useSystemDefaultProp);
		}

		/// <summary>Получает или задает значение <see cref="T:System.Net.Configuration.ProxyElement.AutoDetectValues" />, управляющее использованием автоматического обнаружения веб-прокси.</summary>
		/// <returns>Значение <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.True" />, если веб-прокси <see cref="T:System.Net.WebProxy" /> обнаруживается автоматически; значение <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.False" />, если веб-прокси <see cref="T:System.Net.WebProxy" /> автоматически не обнаруживается; либо значение <see cref="F:System.Net.Configuration.ProxyElement.AutoDetectValues.Unspecified" />.</returns>
		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x000CD94F File Offset: 0x000CBB4F
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x000CD961 File Offset: 0x000CBB61
		[ConfigurationProperty("autoDetect", DefaultValue = "Unspecified")]
		public ProxyElement.AutoDetectValues AutoDetect
		{
			get
			{
				return (ProxyElement.AutoDetectValues)base[ProxyElement.autoDetectProp];
			}
			set
			{
				base[ProxyElement.autoDetectProp] = value;
			}
		}

		/// <summary>Получает или задает значение, указывающее, будет ли использоваться сервер веб-прокси для локальных ресурсов.</summary>
		/// <returns>Значение, указывающее, будет ли локальные ресурсы с помощью прокси-сервера веб-сервера.</returns>
		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000CD974 File Offset: 0x000CBB74
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x000CD986 File Offset: 0x000CBB86
		[ConfigurationProperty("bypassonlocal", DefaultValue = "Unspecified")]
		public ProxyElement.BypassOnLocalValues BypassOnLocal
		{
			get
			{
				return (ProxyElement.BypassOnLocalValues)base[ProxyElement.bypassOnLocalProp];
			}
			set
			{
				base[ProxyElement.bypassOnLocalProp] = value;
			}
		}

		/// <summary>Получает или задает код URI, который идентифицирует используемый сервер веб-прокси.</summary>
		/// <returns>URI, который идентифицирует сервер веб-прокси для использования.</returns>
		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000CD999 File Offset: 0x000CBB99
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x000CD9AB File Offset: 0x000CBBAB
		[ConfigurationProperty("proxyaddress")]
		public Uri ProxyAddress
		{
			get
			{
				return (Uri)base[ProxyElement.proxyAddressProp];
			}
			set
			{
				base[ProxyElement.proxyAddressProp] = value;
			}
		}

		/// <summary>Получает или задает значение <see cref="T:System.Uri" />, указывающее местоположение скрипта автоматического обнаружения прокси-сервера.</summary>
		/// <returns>Объект <see cref="T:System.Uri" />, указывающий местоположение скрипта автоматического обнаружения прокси-сервера.</returns>
		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x000CD9B9 File Offset: 0x000CBBB9
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x000CD9CB File Offset: 0x000CBBCB
		[ConfigurationProperty("scriptLocation")]
		public Uri ScriptLocation
		{
			get
			{
				return (Uri)base[ProxyElement.scriptLocationProp];
			}
			set
			{
				base[ProxyElement.scriptLocationProp] = value;
			}
		}

		/// <summary>Получает или задает значение типа <see cref="T:System.Boolean" />, управляющее использованием параметров веб-прокси обозревателя Internet Explorer.</summary>
		/// <returns>Значение <see langword="true" />, если параметры настройки локальной сети обозревателя Internet Explorer применяются для обнаружения и настройки веб-прокси по умолчанию <see cref="T:System.Net.WebProxy" />, используемого для запросов; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x000CD9D9 File Offset: 0x000CBBD9
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x000CD9EB File Offset: 0x000CBBEB
		[ConfigurationProperty("usesystemdefault", DefaultValue = "Unspecified")]
		public ProxyElement.UseSystemDefaultValues UseSystemDefault
		{
			get
			{
				return (ProxyElement.UseSystemDefaultValues)base[ProxyElement.useSystemDefaultProp];
			}
			set
			{
				base[ProxyElement.useSystemDefaultProp] = value;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x000CD9FE File Offset: 0x000CBBFE
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ProxyElement.properties;
			}
		}

		// Token: 0x0400239F RID: 9119
		private static ConfigurationPropertyCollection properties;

		// Token: 0x040023A0 RID: 9120
		private static ConfigurationProperty autoDetectProp = new ConfigurationProperty("autoDetect", typeof(ProxyElement.AutoDetectValues), ProxyElement.AutoDetectValues.Unspecified);

		// Token: 0x040023A1 RID: 9121
		private static ConfigurationProperty bypassOnLocalProp = new ConfigurationProperty("bypassonlocal", typeof(ProxyElement.BypassOnLocalValues), ProxyElement.BypassOnLocalValues.Unspecified);

		// Token: 0x040023A2 RID: 9122
		private static ConfigurationProperty proxyAddressProp = new ConfigurationProperty("proxyaddress", typeof(Uri), null);

		// Token: 0x040023A3 RID: 9123
		private static ConfigurationProperty scriptLocationProp = new ConfigurationProperty("scriptLocation", typeof(Uri), null);

		// Token: 0x040023A4 RID: 9124
		private static ConfigurationProperty useSystemDefaultProp = new ConfigurationProperty("usesystemdefault", typeof(ProxyElement.UseSystemDefaultValues), ProxyElement.UseSystemDefaultValues.Unspecified);

		/// <summary>Указывает, используется ли прокси-сервер для локальных ресурсов.</summary>
		// Token: 0x02000773 RID: 1907
		public enum BypassOnLocalValues
		{
			/// <summary>Не указано.</summary>
			// Token: 0x040023A6 RID: 9126
			Unspecified = -1,
			/// <summary>Прямой доступ к локальным ресурсам.</summary>
			// Token: 0x040023A7 RID: 9127
			True = 1,
			/// <summary>Для всех запросов локальных ресурсов должен использоваться прокси-сервер.</summary>
			// Token: 0x040023A8 RID: 9128
			False = 0
		}

		/// <summary>Указывает, следует ли использовать локальные параметры настройки прокси-сервера для определения необходимости обхода прокси-сервера для локальных ресурсов.</summary>
		// Token: 0x02000774 RID: 1908
		public enum UseSystemDefaultValues
		{
			/// <summary>Системные параметры прокси-сервера по умолчанию не заданы.</summary>
			// Token: 0x040023AA RID: 9130
			Unspecified = -1,
			/// <summary>Использовать значения системных параметров прокси-сервера по умолчанию.</summary>
			// Token: 0x040023AB RID: 9131
			True = 1,
			/// <summary>Не использовать значения системных параметров прокси-сервера по умолчанию.</summary>
			// Token: 0x040023AC RID: 9132
			False = 0
		}

		/// <summary>Указывает, обнаруживается ли прокси-сервер автоматически.</summary>
		// Token: 0x02000775 RID: 1909
		public enum AutoDetectValues
		{
			/// <summary>Не указано.</summary>
			// Token: 0x040023AE RID: 9134
			Unspecified = -1,
			/// <summary>Прокси-сервер обнаруживается автоматически.</summary>
			// Token: 0x040023AF RID: 9135
			True = 1,
			/// <summary>Прокси-сервер не обнаруживаются автоматически.</summary>
			// Token: 0x040023B0 RID: 9136
			False = 0
		}
	}
}
