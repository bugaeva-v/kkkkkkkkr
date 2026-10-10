using System;
using System.Configuration;
using System.Net.Security;
using Unity;

namespace System.Net.Configuration
{
	/// <summary>Представляет параметры по умолчанию, используемые для создания подключения к удаленному компьютеру. Этот класс не наследуется.</summary>
	// Token: 0x02000777 RID: 1911
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x06003C21 RID: 15393 RVA: 0x000CDBF8 File Offset: 0x000CBDF8
		static ServicePointManagerElement()
		{
			ServicePointManagerElement.properties = new ConfigurationPropertyCollection();
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.checkCertificateNameProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.checkCertificateRevocationListProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.dnsRefreshTimeoutProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.enableDnsRoundRobinProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.expect100ContinueProp);
			ServicePointManagerElement.properties.Add(ServicePointManagerElement.useNagleAlgorithmProp);
		}

		/// <summary>Получает или задает логическое значение, управляющее проверкой сведений об имени узла в сертификате X509.</summary>
		/// <returns>Значение <see langword="true" /> для указания проверки имени узла; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x000CDD27 File Offset: 0x000CBF27
		// (set) Token: 0x06003C24 RID: 15396 RVA: 0x000CDD39 File Offset: 0x000CBF39
		[ConfigurationProperty("checkCertificateName", DefaultValue = "True")]
		public bool CheckCertificateName
		{
			get
			{
				return (bool)base[ServicePointManagerElement.checkCertificateNameProp];
			}
			set
			{
				base[ServicePointManagerElement.checkCertificateNameProp] = value;
			}
		}

		/// <summary>Возвращает или задает логическое значение, указывающее, проверяется ли сертификат по списку отзыва сертификатов.</summary>
		/// <returns>Значение <see langword="true" />, если проверяется список отзыва сертификатов; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="false" />.</returns>
		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x000CDD4C File Offset: 0x000CBF4C
		// (set) Token: 0x06003C26 RID: 15398 RVA: 0x000CDD5E File Offset: 0x000CBF5E
		[ConfigurationProperty("checkCertificateRevocationList", DefaultValue = "False")]
		public bool CheckCertificateRevocationList
		{
			get
			{
				return (bool)base[ServicePointManagerElement.checkCertificateRevocationListProp];
			}
			set
			{
				base[ServicePointManagerElement.checkCertificateRevocationListProp] = value;
			}
		}

		/// <summary>Получает или задает интервал времени, через который обновляются сведения об адресе.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, указывающий, когда выполняется разрешение адресов с использованием службы DNS.</returns>
		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x000CDD71 File Offset: 0x000CBF71
		// (set) Token: 0x06003C28 RID: 15400 RVA: 0x000CDD83 File Offset: 0x000CBF83
		[ConfigurationProperty("dnsRefreshTimeout", DefaultValue = "120000")]
		public int DnsRefreshTimeout
		{
			get
			{
				return (int)base[ServicePointManagerElement.dnsRefreshTimeoutProp];
			}
			set
			{
				base[ServicePointManagerElement.dnsRefreshTimeoutProp] = value;
			}
		}

		/// <summary>Получает или задает логическое значение, управляющее использованием различных IP-адресов при подключениях к одному и тому же серверу.</summary>
		/// <returns>Значение <see langword="true" /> для включения циклического перебора DNS; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x000CDD96 File Offset: 0x000CBF96
		// (set) Token: 0x06003C2A RID: 15402 RVA: 0x000CDDA8 File Offset: 0x000CBFA8
		[ConfigurationProperty("enableDnsRoundRobin", DefaultValue = "False")]
		public bool EnableDnsRoundRobin
		{
			get
			{
				return (bool)base[ServicePointManagerElement.enableDnsRoundRobinProp];
			}
			set
			{
				base[ServicePointManagerElement.enableDnsRoundRobinProp] = value;
			}
		}

		/// <summary>Получает или задает логическое значение, которое управляет использованием поведения 100-Continue.</summary>
		/// <returns>Значение <see langword="true" /> для ожидания ответов 100-Continue для запросов <see langword="POST" />; в противном случае — <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x000CDDBB File Offset: 0x000CBFBB
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x000CDDCD File Offset: 0x000CBFCD
		[ConfigurationProperty("expect100Continue", DefaultValue = "True")]
		public bool Expect100Continue
		{
			get
			{
				return (bool)base[ServicePointManagerElement.expect100ContinueProp];
			}
			set
			{
				base[ServicePointManagerElement.expect100ContinueProp] = value;
			}
		}

		/// <summary>Получает или задает логическое значение, которое управляет использованием алгоритма Nagle.</summary>
		/// <returns>Значение <see langword="true" /> для использования алгоритма Nagle; в противном случае — значение <see langword="false" />. Значение по умолчанию — <see langword="true" />.</returns>
		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x000CDDE0 File Offset: 0x000CBFE0
		// (set) Token: 0x06003C2E RID: 15406 RVA: 0x000CDDF2 File Offset: 0x000CBFF2
		[ConfigurationProperty("useNagleAlgorithm", DefaultValue = "True")]
		public bool UseNagleAlgorithm
		{
			get
			{
				return (bool)base[ServicePointManagerElement.useNagleAlgorithmProp];
			}
			set
			{
				base[ServicePointManagerElement.useNagleAlgorithmProp] = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06003C2F RID: 15407 RVA: 0x000CDE05 File Offset: 0x000CC005
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return ServicePointManagerElement.properties;
			}
		}

		// Token: 0x06003C30 RID: 15408 RVA: 0x00003917 File Offset: 0x00001B17
		[MonoTODO]
		protected override void PostDeserialize()
		{
		}

		/// <summary>Получает или задает объект <see cref="T:System.Net.Security.EncryptionPolicy" /> для использования.</summary>
		/// <returns>Политика шифрования, используемая для экземпляра <see cref="T:System.Net.ServicePointManager" />.</returns>
		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x000CDE0C File Offset: 0x000CC00C
		// (set) Token: 0x06003C32 RID: 15410 RVA: 0x00013BCA File Offset: 0x00011DCA
		public EncryptionPolicy EncryptionPolicy
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return EncryptionPolicy.RequireEncryption;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		// Token: 0x040023B8 RID: 9144
		private static ConfigurationPropertyCollection properties;

		// Token: 0x040023B9 RID: 9145
		private static ConfigurationProperty checkCertificateNameProp = new ConfigurationProperty("checkCertificateName", typeof(bool), true);

		// Token: 0x040023BA RID: 9146
		private static ConfigurationProperty checkCertificateRevocationListProp = new ConfigurationProperty("checkCertificateRevocationList", typeof(bool), false);

		// Token: 0x040023BB RID: 9147
		private static ConfigurationProperty dnsRefreshTimeoutProp = new ConfigurationProperty("dnsRefreshTimeout", typeof(int), 120000);

		// Token: 0x040023BC RID: 9148
		private static ConfigurationProperty enableDnsRoundRobinProp = new ConfigurationProperty("enableDnsRoundRobin", typeof(bool), false);

		// Token: 0x040023BD RID: 9149
		private static ConfigurationProperty expect100ContinueProp = new ConfigurationProperty("expect100Continue", typeof(bool), true);

		// Token: 0x040023BE RID: 9150
		private static ConfigurationProperty useNagleAlgorithmProp = new ConfigurationProperty("useNagleAlgorithm", typeof(bool), true);
	}
}
