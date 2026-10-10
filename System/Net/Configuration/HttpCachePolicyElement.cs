using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Представляет политику HTTP-кэширования сетевых ресурсов. Этот класс не наследуется.</summary>
	// Token: 0x02000769 RID: 1897
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06003BCD RID: 15309 RVA: 0x000CD024 File Offset: 0x000CB224
		static HttpCachePolicyElement()
		{
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.maximumAgeProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.maximumStaleProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.minimumFreshProp);
			HttpCachePolicyElement.properties.Add(HttpCachePolicyElement.policyLevelProp);
		}

		/// <summary>Получает или задает максимальное допустимое время существования ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, указывающее максимальное время существования кэшированных ресурсов, заданных в файле конфигурации.</returns>
		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x000CD100 File Offset: 0x000CB300
		// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x000CD112 File Offset: 0x000CB312
		[ConfigurationProperty("maximumAge", DefaultValue = "10675199.02:48:05.4775807")]
		public TimeSpan MaximumAge
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.maximumAgeProp];
			}
			set
			{
				base[HttpCachePolicyElement.maximumAgeProp] = value;
			}
		}

		/// <summary>Получает или задает максимальное значение устаревания, которое разрешено для ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, равное максимальному времени устаревания, указанному в файле конфигурации.</returns>
		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x000CD125 File Offset: 0x000CB325
		// (set) Token: 0x06003BD2 RID: 15314 RVA: 0x000CD137 File Offset: 0x000CB337
		[ConfigurationProperty("maximumStale", DefaultValue = "-10675199.02:48:05.4775808")]
		public TimeSpan MaximumStale
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.maximumStaleProp];
			}
			set
			{
				base[HttpCachePolicyElement.maximumStaleProp] = value;
			}
		}

		/// <summary>Получает или задает минимальное допустимое время актуальности для ресурса, получаемого из кэша.</summary>
		/// <returns>Значение <see cref="T:System.TimeSpan" />, задающее минимальное значение времени актуальности, указанное в файле конфигурации.</returns>
		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x000CD14A File Offset: 0x000CB34A
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x000CD15C File Offset: 0x000CB35C
		[ConfigurationProperty("minimumFresh", DefaultValue = "-10675199.02:48:05.4775808")]
		public TimeSpan MinimumFresh
		{
			get
			{
				return (TimeSpan)base[HttpCachePolicyElement.minimumFreshProp];
			}
			set
			{
				base[HttpCachePolicyElement.minimumFreshProp] = value;
			}
		}

		/// <summary>Получает или задает поведение HTTP-кэширования для локального компьютера.</summary>
		/// <returns>Значение <see cref="T:System.Net.Cache.HttpRequestCacheLevel" />, определяющее поведение кэширования.</returns>
		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x000CD16F File Offset: 0x000CB36F
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x000CD181 File Offset: 0x000CB381
		[ConfigurationProperty("policyLevel", DefaultValue = "Default", Options = ConfigurationPropertyOptions.IsRequired)]
		public HttpRequestCacheLevel PolicyLevel
		{
			get
			{
				return (HttpRequestCacheLevel)base[HttpCachePolicyElement.policyLevelProp];
			}
			set
			{
				base[HttpCachePolicyElement.policyLevelProp] = value;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x000CD194 File Offset: 0x000CB394
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return HttpCachePolicyElement.properties;
			}
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400238F RID: 9103
		private static ConfigurationProperty maximumAgeProp = new ConfigurationProperty("maximumAge", typeof(TimeSpan), TimeSpan.MaxValue);

		// Token: 0x04002390 RID: 9104
		private static ConfigurationProperty maximumStaleProp = new ConfigurationProperty("maximumStale", typeof(TimeSpan), TimeSpan.MinValue);

		// Token: 0x04002391 RID: 9105
		private static ConfigurationProperty minimumFreshProp = new ConfigurationProperty("minimumFresh", typeof(TimeSpan), TimeSpan.MinValue);

		// Token: 0x04002392 RID: 9106
		private static ConfigurationProperty policyLevelProp = new ConfigurationProperty("policyLevel", typeof(HttpRequestCacheLevel), HttpRequestCacheLevel.Default, ConfigurationPropertyOptions.IsRequired);

		// Token: 0x04002393 RID: 9107
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
