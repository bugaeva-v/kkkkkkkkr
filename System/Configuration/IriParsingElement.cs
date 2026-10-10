using System;

namespace System.Configuration
{
	/// <summary>Предоставляет параметры конфигурации для универсального идентификатора ресурса (IRI) в класс <see cref="T:System.Uri" />.</summary>
	// Token: 0x020001B7 RID: 439
	public sealed class IriParsingElement : ConfigurationElement
	{
		// Token: 0x06000B91 RID: 2961 RVA: 0x0003129E File Offset: 0x0002F49E
		static IriParsingElement()
		{
			IriParsingElement.properties = new ConfigurationPropertyCollection();
			IriParsingElement.properties.Add(IriParsingElement.enabled_prop);
		}

		/// <summary>Получает или задает значение параметра конфигурации <see cref="T:System.Configuration.IriParsingElement" />.</summary>
		/// <returns>Логическое выражение показывает, активирован ли универсальный идентификатор ресурса (IRI).</returns>
		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000B93 RID: 2963 RVA: 0x000312D9 File Offset: 0x0002F4D9
		// (set) Token: 0x06000B94 RID: 2964 RVA: 0x000312EB File Offset: 0x0002F4EB
		[ConfigurationProperty("enabled", DefaultValue = false, Options = (ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey))]
		public bool Enabled
		{
			get
			{
				return (bool)base[IriParsingElement.enabled_prop];
			}
			set
			{
				base[IriParsingElement.enabled_prop] = value;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x000312FE File Offset: 0x0002F4FE
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return IriParsingElement.properties;
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x00031308 File Offset: 0x0002F508
		public override bool Equals(object o)
		{
			IriParsingElement iriParsingElement = o as IriParsingElement;
			return iriParsingElement != null && iriParsingElement.Enabled == this.Enabled;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003132F File Offset: 0x0002F52F
		public override int GetHashCode()
		{
			return Convert.ToInt32(this.Enabled) ^ 127;
		}

		// Token: 0x04000783 RID: 1923
		private static ConfigurationPropertyCollection properties;

		// Token: 0x04000784 RID: 1924
		private static ConfigurationProperty enabled_prop = new ConfigurationProperty("enabled", typeof(bool), false, ConfigurationPropertyOptions.IsRequired | ConfigurationPropertyOptions.IsKey);
	}
}
