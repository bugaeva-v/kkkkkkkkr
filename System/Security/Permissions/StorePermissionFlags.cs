using System;

namespace System.Security.Permissions
{
	/// <summary>Задает разрешенный доступ к хранилищу сертификатов X.509.</summary>
	// Token: 0x0200029A RID: 666
	[Flags]
	[Serializable]
	public enum StorePermissionFlags
	{
		/// <summary>Разрешение не предоставляется для выполнения действий, связанных с сертификатами или хранением.</summary>
		// Token: 0x04000BC7 RID: 3015
		NoFlags = 0,
		/// <summary>Возможность создания нового хранилища.</summary>
		// Token: 0x04000BC8 RID: 3016
		CreateStore = 1,
		/// <summary>Возможность удаления хранилища.</summary>
		// Token: 0x04000BC9 RID: 3017
		DeleteStore = 2,
		/// <summary>Возможность перечисления хранилищ в компьютере.</summary>
		// Token: 0x04000BCA RID: 3018
		EnumerateStores = 4,
		/// <summary>Возможность открытия хранилища.</summary>
		// Token: 0x04000BCB RID: 3019
		OpenStore = 16,
		/// <summary>Возможность добавления сертификата в хранилище.</summary>
		// Token: 0x04000BCC RID: 3020
		AddToStore = 32,
		/// <summary>Возможность удаления сертификата из хранилища.</summary>
		// Token: 0x04000BCD RID: 3021
		RemoveFromStore = 64,
		/// <summary>Возможность перечисления сертификатов в хранилище.</summary>
		// Token: 0x04000BCE RID: 3022
		EnumerateCertificates = 128,
		/// <summary>Возможность выполнять все действия, связанные с сертификатами и хранением.</summary>
		// Token: 0x04000BCF RID: 3023
		AllFlags = 247
	}
}
