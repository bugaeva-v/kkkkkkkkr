using System;
using System.Configuration;
using Unity;

namespace System.Net.Configuration
{
	/// <summary>Представляет сведения, используемые для настройки скриптов веб-прокси. Этот класс не наследуется.</summary>
	// Token: 0x0200077D RID: 1917
	public sealed class WebProxyScriptElement : ConfigurationElement
	{
		// Token: 0x06003C6A RID: 15466 RVA: 0x000CE264 File Offset: 0x000CC464
		static WebProxyScriptElement()
		{
			WebProxyScriptElement.properties.Add(WebProxyScriptElement.downloadTimeoutProp);
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x00003917 File Offset: 0x00001B17
		protected override void PostDeserialize()
		{
		}

		/// <summary>Возвращает или задает время ожидания загрузки скрипта веб-прокси в формате часы:минуты:секунды.</summary>
		/// <returns>Объект <see cref="T:System.TimeSpan" />, содержащий значение времени ожидания. Значение по умолчанию — одна минута.</returns>
		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x06003C6C RID: 15468 RVA: 0x000CE2B1 File Offset: 0x000CC4B1
		// (set) Token: 0x06003C6D RID: 15469 RVA: 0x000CE2C3 File Offset: 0x000CC4C3
		[ConfigurationProperty("downloadTimeout", DefaultValue = "00:02:00")]
		public TimeSpan DownloadTimeout
		{
			get
			{
				return (TimeSpan)base[WebProxyScriptElement.downloadTimeoutProp];
			}
			set
			{
				base[WebProxyScriptElement.downloadTimeoutProp] = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x06003C6E RID: 15470 RVA: 0x000CE2D6 File Offset: 0x000CC4D6
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return WebProxyScriptElement.properties;
			}
		}

		/// <summary>Возвращает или задает значение, определяющее частоту (в секундах), с которой WinHttpAutoProxySvc будет пытаться повторить загрузку сценария AutoConfigUrl.</summary>
		/// <returns>Частота (в секундах), WinHttpAutoProxySvc попытается повторить загрузку AutoConfigUrl сценария.</returns>
		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x06003C70 RID: 15472 RVA: 0x000CE2E0 File Offset: 0x000CC4E0
		// (set) Token: 0x06003C71 RID: 15473 RVA: 0x00013BCA File Offset: 0x00011DCA
		public int AutoConfigUrlRetryInterval
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
			set
			{
				ThrowStub.ThrowNotSupportedException();
			}
		}

		// Token: 0x040023CB RID: 9163
		private static ConfigurationProperty downloadTimeoutProp = new ConfigurationProperty("downloadTimeout", typeof(TimeSpan), new TimeSpan(0, 0, 2, 0));

		// Token: 0x040023CC RID: 9164
		private static ConfigurationPropertyCollection properties = new ConfigurationPropertyCollection();
	}
}
