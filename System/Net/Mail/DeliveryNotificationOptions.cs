using System;

namespace System.Net.Mail
{
	/// <summary>Описывает параметры уведомления о доставке электронной почты.</summary>
	// Token: 0x02000828 RID: 2088
	[Flags]
	public enum DeliveryNotificationOptions
	{
		/// <summary>Сведения об уведомлениях не будут отправлены. Почтовый сервер будет использовать его настроенное поведение, чтобы определить, должен ли он создавать уведомление о доставке.</summary>
		// Token: 0x0400284C RID: 10316
		None = 0,
		/// <summary>Уведомлять об успешной доставке.</summary>
		// Token: 0x0400284D RID: 10317
		OnSuccess = 1,
		/// <summary>Уведомлять о неудачной доставке.</summary>
		// Token: 0x0400284E RID: 10318
		OnFailure = 2,
		/// <summary>Уведомлять при задержке доставки.</summary>
		// Token: 0x0400284F RID: 10319
		Delay = 4,
		/// <summary>Уведомление не должно создаваться ни при каких обстоятельствах.</summary>
		// Token: 0x04002850 RID: 10320
		Never = 134217728
	}
}
