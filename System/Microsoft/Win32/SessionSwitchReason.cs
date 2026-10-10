using System;

namespace Microsoft.Win32
{
	/// <summary>Определяет идентификаторы, используемые для представления типа события переключения сеанса.</summary>
	// Token: 0x02000129 RID: 297
	public enum SessionSwitchReason
	{
		/// <summary>Сеанс был подключен с консоли.</summary>
		// Token: 0x040004DA RID: 1242
		ConsoleConnect = 1,
		/// <summary>Сеанс был отключен с консоли.</summary>
		// Token: 0x040004DB RID: 1243
		ConsoleDisconnect,
		/// <summary>Сеанс был подключен с удаленной консоли.</summary>
		// Token: 0x040004DC RID: 1244
		RemoteConnect,
		/// <summary>Сеанс был отключен с удаленной консоли.</summary>
		// Token: 0x040004DD RID: 1245
		RemoteDisconnect,
		/// <summary>Пользователь вошел в сеанс.</summary>
		// Token: 0x040004DE RID: 1246
		SessionLogon,
		/// <summary>Пользователь вышел из сеанса.</summary>
		// Token: 0x040004DF RID: 1247
		SessionLogoff,
		/// <summary>Сеанс заблокирован.</summary>
		// Token: 0x040004E0 RID: 1248
		SessionLock,
		/// <summary>Сеанс разблокирован.</summary>
		// Token: 0x040004E1 RID: 1249
		SessionUnlock,
		/// <summary>Сеанс изменил свой статус, устанавливая режим с удаленным управлением или выходя из этого режима.</summary>
		// Token: 0x040004E2 RID: 1250
		SessionRemoteControl
	}
}
