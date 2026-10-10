using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет права доступа, которые можно применять к объектам именованных системных событий.</summary>
	// Token: 0x02000525 RID: 1317
	[Flags]
	public enum EventWaitHandleRights
	{
		/// <summary>Право устанавливать или сбрасывать сигнальное состояние именованного события.</summary>
		// Token: 0x04002486 RID: 9350
		Modify = 2,
		/// <summary>Право на удаление именованного события.</summary>
		// Token: 0x04002487 RID: 9351
		Delete = 65536,
		/// <summary>Право открывать и копировать правила доступа и аудита, связанные с именованным событием.</summary>
		// Token: 0x04002488 RID: 9352
		ReadPermissions = 131072,
		/// <summary>Право изменять правила безопасности и аудита, связанные с именованным событием.</summary>
		// Token: 0x04002489 RID: 9353
		ChangePermissions = 262144,
		/// <summary>Право изменять владельца именованного события.</summary>
		// Token: 0x0400248A RID: 9354
		TakeOwnership = 524288,
		/// <summary>Право ожидания именованного события.</summary>
		// Token: 0x0400248B RID: 9355
		Synchronize = 1048576,
		/// <summary>Право на полный контроль над именованным событием, а также на изменение правил доступа и аудита.</summary>
		// Token: 0x0400248C RID: 9356
		FullControl = 2031619
	}
}
