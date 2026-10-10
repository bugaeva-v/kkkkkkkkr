using System;

namespace System.Net.Mail
{
	/// <summary>Задает уровень доступа, разрешенный для сервера SMTP (Simple Mail Transport Protocol).</summary>
	// Token: 0x0200082E RID: 2094
	public enum SmtpAccess
	{
		/// <summary>Нет доступа к узлу SMTP.</summary>
		// Token: 0x0400286A RID: 10346
		None,
		/// <summary>Подключение к узлу SMTP через стандартный порт (25).</summary>
		// Token: 0x0400286B RID: 10347
		Connect,
		/// <summary>Подключение к узлу SMTP через любой порт.</summary>
		// Token: 0x0400286C RID: 10348
		ConnectToUnrestrictedPort
	}
}
