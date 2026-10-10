using System;
using System.Runtime.InteropServices;

namespace System.Security.AccessControl
{
	/// <summary>Определяет права доступа, которые можно применять к объектам именованных системных семафоров.</summary>
	// Token: 0x02000290 RID: 656
	[Flags]
	[ComVisible(false)]
	public enum SemaphoreRights
	{
		/// <summary>Право на высвобождение именованного семафора.</summary>
		// Token: 0x04000BAE RID: 2990
		Modify = 2,
		/// <summary>Право на удаление именованного семафора.</summary>
		// Token: 0x04000BAF RID: 2991
		Delete = 65536,
		/// <summary>Право открывать и копировать правила доступа и аудита, связанные с именованным семафором.</summary>
		// Token: 0x04000BB0 RID: 2992
		ReadPermissions = 131072,
		/// <summary>Право изменять правила безопасности и аудита, связанные с именованным семафором.</summary>
		// Token: 0x04000BB1 RID: 2993
		ChangePermissions = 262144,
		/// <summary>Право изменять владельца именованного семафора.</summary>
		// Token: 0x04000BB2 RID: 2994
		TakeOwnership = 524288,
		/// <summary>Право на ожидание именованного семафора.</summary>
		// Token: 0x04000BB3 RID: 2995
		Synchronize = 1048576,
		/// <summary>Право на полный контроль над именованным семафором, а также на изменение правил доступа и аудита.</summary>
		// Token: 0x04000BB4 RID: 2996
		FullControl = 2031619
	}
}
