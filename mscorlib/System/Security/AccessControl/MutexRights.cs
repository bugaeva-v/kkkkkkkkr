using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет права доступа, которые можно применять к объектам именованных системных мьютексов.</summary>
	// Token: 0x02000533 RID: 1331
	[Flags]
	public enum MutexRights
	{
		/// <summary>Право на высвобождение именованного мьютекса.</summary>
		// Token: 0x040024B1 RID: 9393
		Modify = 1,
		/// <summary>Право на удаление именованного мьютекса.</summary>
		// Token: 0x040024B2 RID: 9394
		Delete = 65536,
		/// <summary>Право открывать и копировать правила доступа и аудита, связанные с именованным мьютексом.</summary>
		// Token: 0x040024B3 RID: 9395
		ReadPermissions = 131072,
		/// <summary>Право изменять правила безопасности и аудита, связанные с именованным мьютексом.</summary>
		// Token: 0x040024B4 RID: 9396
		ChangePermissions = 262144,
		/// <summary>Право изменять владельца именованного мьютекса.</summary>
		// Token: 0x040024B5 RID: 9397
		TakeOwnership = 524288,
		/// <summary>Право ожидания именованного мьютекса.</summary>
		// Token: 0x040024B6 RID: 9398
		Synchronize = 1048576,
		/// <summary>Право на полный контроль над именованным мьютексом, а также на изменение правил доступа и аудита.</summary>
		// Token: 0x040024B7 RID: 9399
		FullControl = 2031617
	}
}
