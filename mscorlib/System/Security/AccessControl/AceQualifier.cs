using System;

namespace System.Security.AccessControl
{
	/// <summary>Задает функцию элемента управления доступом.</summary>
	// Token: 0x02000507 RID: 1287
	public enum AceQualifier
	{
		/// <summary>Разрешить доступ.</summary>
		// Token: 0x0400241D RID: 9245
		AccessAllowed,
		/// <summary>Запретить доступ.</summary>
		// Token: 0x0400241E RID: 9246
		AccessDenied,
		/// <summary>Вызвать системный аудит.</summary>
		// Token: 0x0400241F RID: 9247
		SystemAudit,
		/// <summary>Вызвать системное оповещение.</summary>
		// Token: 0x04002420 RID: 9248
		SystemAlarm
	}
}
