using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Представляет элемент счетчика производительности в файле конфигурации <see langword="System.Net" />, который определяет, включены ли счетчики производительности сети. Этот класс не наследуется.</summary>
	// Token: 0x02000771 RID: 1905
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x06003C00 RID: 15360 RVA: 0x000CD7F5 File Offset: 0x000CB9F5
		static PerformanceCountersElement()
		{
			PerformanceCountersElement.properties.Add(PerformanceCountersElement.enabledProp);
		}

		/// <summary>Возвращает или задает значение, указывающее, включены ли счетчики производительности.</summary>
		/// <returns>Значение <see langword="true" />, если счетчики производительности включены; в противном случае — <see langword="false" />.</returns>
		// Token: 0x17000D9E RID: 3486
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x000CD82F File Offset: 0x000CBA2F
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x000CD841 File Offset: 0x000CBA41
		[ConfigurationProperty("enabled", DefaultValue = "False")]
		public bool Enabled
		{
			get
			{
				return (bool)base[PerformanceCountersElement.enabledProp];
			}
			set
			{
				base[PerformanceCountersElement.enabledProp] = value;
			}
		}

		// Token: 0x17000D9F RID: 3487
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x000CD854 File Offset: 0x000CBA54
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return PerformanceCountersElement.properties;
			}
		}

		// Token: 0x0400239D RID: 9117
		private static ConfigurationProperty enabledProp = new ConfigurationProperty("enabled", typeof(bool), false);

		// Token: 0x0400239E RID: 9118
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
