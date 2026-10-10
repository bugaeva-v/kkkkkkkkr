using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет разделы дескриптора безопасности для сохранения и загрузки.</summary>
	// Token: 0x02000501 RID: 1281
	[Flags]
	public enum AccessControlSections
	{
		/// <summary>Ни один из разделов.</summary>
		// Token: 0x04002405 RID: 9221
		None = 0,
		/// <summary>Системный список управления доступом.</summary>
		// Token: 0x04002406 RID: 9222
		Audit = 1,
		/// <summary>Список управления доступом на уровне пользователей.</summary>
		// Token: 0x04002407 RID: 9223
		Access = 2,
		/// <summary>Владелец.</summary>
		// Token: 0x04002408 RID: 9224
		Owner = 4,
		/// <summary>Основная группа.</summary>
		// Token: 0x04002409 RID: 9225
		Group = 8,
		/// <summary>Весь дескриптор безопасности.</summary>
		// Token: 0x0400240A RID: 9226
		All = 15
	}
}
