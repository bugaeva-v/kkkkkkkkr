using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет раздел дескриптора безопасности для запроса или установки.</summary>
	// Token: 0x0200054A RID: 1354
	[Flags]
	public enum SecurityInfos
	{
		/// <summary>Идентификатор владельца.</summary>
		// Token: 0x040024FF RID: 9471
		Owner = 1,
		/// <summary>Идентификатор основной группы.</summary>
		// Token: 0x04002500 RID: 9472
		Group = 2,
		/// <summary>Список управления доступом на уровне пользователей.</summary>
		// Token: 0x04002501 RID: 9473
		DiscretionaryAcl = 4,
		/// <summary>Системный список управления доступом.</summary>
		// Token: 0x04002502 RID: 9474
		SystemAcl = 8
	}
}
