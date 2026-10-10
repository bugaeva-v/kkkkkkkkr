using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;

namespace System.Net.Configuration
{
	/// <summary>Представляет политику FTP-кэширования сетевых ресурсов. Этот класс не наследуется.</summary>
	// Token: 0x02000768 RID: 1896
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x000CCFBD File Offset: 0x000CB1BD
		static FtpCachePolicyElement()
		{
			FtpCachePolicyElement.properties.Add(FtpCachePolicyElement.policyLevelProp);
		}

		/// <summary>Получает или задает поведение FTP-кэширования для локального компьютера.</summary>
		/// <returns>Значение <see cref="T:System.Net.Cache.RequestCacheLevel" />, определяющее поведение кэширования.</returns>
		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06003BC8 RID: 15304 RVA: 0x000CCFF7 File Offset: 0x000CB1F7
		// (set) Token: 0x06003BC9 RID: 15305 RVA: 0x000CD009 File Offset: 0x000CB209
		[ConfigurationProperty("policyLevel", DefaultValue = "Default")]
		public RequestCacheLevel PolicyLevel
		{
			get
			{
				return (RequestCacheLevel)base[FtpCachePolicyElement.policyLevelProp];
			}
			set
			{
				base[FtpCachePolicyElement.policyLevelProp] = value;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06003BCA RID: 15306 RVA: 0x000CD01C File Offset: 0x000CB21C
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return FtpCachePolicyElement.properties;
			}
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0000829A File Offset: 0x0000649A
		[MonoTODO]
		protected override void Reset(ConfigurationElement parentElement)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0400238D RID: 9101
		private static ConfigurationProperty policyLevelProp = new ConfigurationProperty("policyLevel", typeof(RequestCacheLevel), RequestCacheLevel.Default);

		// Token: 0x0400238E RID: 9102
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
