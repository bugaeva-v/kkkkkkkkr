using System;

namespace System.Net.Mail
{
	/// <summary>Задает способ доставки сообщений электронной почты.</summary>
	// Token: 0x02000838 RID: 2104
	public enum SmtpDeliveryMethod
	{
		/// <summary>Электронная почта отправляется по сети на сервер SMTP.</summary>
		// Token: 0x040028A1 RID: 10401
		Network,
		/// <summary>Электронная почта копируется в каталог, указанный свойством <see cref="P:System.Net.Mail.SmtpClient.PickupDirectoryLocation" />, для доставки внешним приложением.</summary>
		// Token: 0x040028A2 RID: 10402
		SpecifiedPickupDirectory,
		/// <summary>Электронная почта копируется в каталог раскладки, используемый локальными службами IIS для доставки.</summary>
		// Token: 0x040028A3 RID: 10403
		PickupDirectoryFromIis
	}
}
