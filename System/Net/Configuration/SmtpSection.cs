using System;
using System.Configuration;
using System.Net.Mail;

namespace System.Net.Configuration
{
	/// <summary>Представляет раздел SMTP в файле конфигурации <see langword="System.Net" />.</summary>
	// Token: 0x0200077A RID: 1914
	public sealed class SmtpSection : ConfigurationSection
	{
		/// <summary>Возвращает или задает метод доставки по протоколу SMTP. По умолчанию используется метод доставки <see cref="F:System.Net.Mail.SmtpDeliveryMethod.Network" />.</summary>
		/// <returns>Строка, представляющая метод доставки SMTP.</returns>
		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x000CE091 File Offset: 0x000CC291
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x000CE0A3 File Offset: 0x000CC2A3
		[ConfigurationProperty("deliveryMethod", DefaultValue = "Network")]
		public SmtpDeliveryMethod DeliveryMethod
		{
			get
			{
				return (SmtpDeliveryMethod)base["deliveryMethod"];
			}
			set
			{
				base["deliveryMethod"] = value;
			}
		}

		/// <summary>Получает или задает формат доставки, используемый для отправки исходящих сообщений электронной почты по протоколу SMTP.</summary>
		/// <returns>Возвращает <see cref="T:System.Net.Mail.SmtpDeliveryFormat" />.  
		/// Формат доставки, используемый для отправки исходящих сообщений электронной почты, с помощью SMTP.</returns>
		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x000CE0B6 File Offset: 0x000CC2B6
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x000CE0C8 File Offset: 0x000CC2C8
		[ConfigurationProperty("deliveryFormat", DefaultValue = SmtpDeliveryFormat.SevenBit)]
		public SmtpDeliveryFormat DeliveryFormat
		{
			get
			{
				return (SmtpDeliveryFormat)base["deliveryFormat"];
			}
			set
			{
				base["deliveryFormat"] = value;
			}
		}

		/// <summary>Получает или задает значение отправителя сообщений электронной почты по умолчанию.</summary>
		/// <returns>Строка, представляющая значение отправителя сообщений электронной почты по умолчанию.</returns>
		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x000CE0DB File Offset: 0x000CC2DB
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x000CE0ED File Offset: 0x000CC2ED
		[ConfigurationProperty("from")]
		public string From
		{
			get
			{
				return (string)base["from"];
			}
			set
			{
				base["from"] = value;
			}
		}

		/// <summary>Возвращает элемент конфигурации, который контролирует сетевые параметры, используемые протоколом SMTP. file<see cref="T:System.Net.Configuration.SmtpNetworkElement" />.</summary>
		/// <returns>Объект <see cref="T:System.Net.Configuration.SmtpNetworkElement" />.  
		/// Элемент конфигурации, контролирующий параметры сети, используемые SMTP.</returns>
		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x000CE0FB File Offset: 0x000CC2FB
		[ConfigurationProperty("network")]
		public SmtpNetworkElement Network
		{
			get
			{
				return (SmtpNetworkElement)base["network"];
			}
		}

		/// <summary>Получает каталог раскладки для использования клиентом SMPT.</summary>
		/// <returns>Объект <see cref="T:System.Net.Configuration.SmtpSpecifiedPickupDirectoryElement" />, определяющий папку каталога раскладки.</returns>
		// Token: 0x17000DCC RID: 3532
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x000CE10D File Offset: 0x000CC30D
		[ConfigurationProperty("specifiedPickupDirectory")]
		public SmtpSpecifiedPickupDirectoryElement SpecifiedPickupDirectory
		{
			get
			{
				return (SmtpSpecifiedPickupDirectoryElement)base["specifiedPickupDirectory"];
			}
		}

		// Token: 0x17000DCD RID: 3533
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x00031787 File Offset: 0x0002F987
		protected override ConfigurationPropertyCollection Properties
		{
			get
			{
				return base.Properties;
			}
		}
	}
}
