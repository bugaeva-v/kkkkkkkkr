using System;
using Unity;

namespace System.Configuration
{
	/// <summary>Представляет собой раздел URI в файле конфигурации.</summary>
	// Token: 0x020001DC RID: 476
	public sealed class UriSection : ConfigurationSection
	{
		// Token: 0x06000C5C RID: 3164 RVA: 0x000327F0 File Offset: 0x000309F0
		static UriSection()
		{
			UriSection.properties = new ConfigurationPropertyCollection();
			UriSection.properties.Add(UriSection.idn_prop);
			UriSection.properties.Add(UriSection.iriParsing_prop);
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.IdnElement" />, который содержит параметры конфигурации для международного домена имен (IDN), считываемые классом <see cref="T:System.Uri" />.</summary>
		/// <returns>Параметр конфигурации для обработки международного доменного имени (IDN) в классе <see cref="T:System.Uri" />.</returns>
		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000C5E RID: 3166 RVA: 0x00032859 File Offset: 0x00030A59
		[ConfigurationProperty("idn")]
		public IdnElement Idn
		{
			get
			{
				return (IdnElement)base[UriSection.idn_prop];
			}
		}

		/// <summary>Возвращает объект <see cref="T:System.Configuration.IriParsingElement" />, который содержит параметры конфигурации для международного домена имен (IRI), считываемые классом <see cref="T:System.Uri" />.</summary>
		/// <returns>Параметр конфигурации для разбора международных идентификаторов ресурсов (IRI) в классе <see cref="T:System.Uri" />.</returns>
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000C5F RID: 3167 RVA: 0x0003286B File Offset: 0x00030A6B
		[ConfigurationProperty("iriParsing")]
		public IriParsingElement IriParsing
		{
			get
			{
				return (IriParsingElement)base[UriSection.iriParsing_prop];
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003287D File Offset: 0x00030A7D
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return UriSection.properties;
			}
		}

		/// <summary>Получает объект <see cref="T:System.Configuration.SchemeSettingElementCollection" />, содержащий параметры конфигурации для разбора схем в классе <see cref="T:System.Uri" />.</summary>
		/// <returns>Параметры конфигурации для разбора схем в классе <see cref="T:System.Uri" /></returns>
		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x00032884 File Offset: 0x00030A84
		public SchemeSettingElementCollection SchemeSettings
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return null;
			}
		}

		// Token: 0x040007BD RID: 1981
		private static ConfigurationPropertyCollection properties;

		// Token: 0x040007BE RID: 1982
		private static ConfigurationProperty idn_prop = new ConfigurationProperty("idn", typeof(IdnElement), null);

		// Token: 0x040007BF RID: 1983
		private static ConfigurationProperty iriParsing_prop = new ConfigurationProperty("iriParsing", typeof(IriParsingElement), null);
	}
}
