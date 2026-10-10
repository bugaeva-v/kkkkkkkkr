using System;

namespace System.Security.Permissions
{
	/// <summary>Задает права доступа для шифрования данных и памяти.</summary>
	// Token: 0x0200000B RID: 11
	[Flags]
	[Serializable]
	public enum DataProtectionPermissionFlags
	{
		/// <summary>Возможности защиты отсутствуют.</summary>
		// Token: 0x0400007A RID: 122
		NoFlags = 0,
		/// <summary>Возможность шифрования данных.</summary>
		// Token: 0x0400007B RID: 123
		ProtectData = 1,
		/// <summary>Возможность расшифровки данных.</summary>
		// Token: 0x0400007C RID: 124
		UnprotectData = 2,
		/// <summary>Возможность шифрования памяти.</summary>
		// Token: 0x0400007D RID: 125
		ProtectMemory = 4,
		/// <summary>Возможность расшифровки памяти.</summary>
		// Token: 0x0400007E RID: 126
		UnprotectMemory = 8,
		/// <summary>Возможность шифрования данных, шифрования памяти, расшифровки данных и расшифровки памяти.</summary>
		// Token: 0x0400007F RID: 127
		AllFlags = 15
	}
}
