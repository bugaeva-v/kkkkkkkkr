using System;
using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Configuration.MailSettingsSectionGroup" />.</summary>
	// Token: 0x0200076C RID: 1900
	public sealed class MailSettingsSectionGroup : ConfigurationSectionGroup
	{
		/// <summary>Получает параметры SMTP локального компьютера.</summary>
		/// <returns>Объект <see cref="T:System.Net.Configuration.SmtpSection" />, содержащий сведения о конфигурации локального компьютера.</returns>
		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x000CD36E File Offset: 0x000CB56E
		public SmtpSection Smtp
		{
			get
			{
				return (SmtpSection)base.Sections["smtp"];
			}
		}
	}
}
