using System;

namespace System.Security.Permissions
{
	/// <summary>Указывает, должно ли разрешение иметь полный доступ или не иметь никакого доступа к ресурсам при его создании.</summary>
	// Token: 0x0200042D RID: 1069
	public enum PermissionState
	{
		/// <summary>Доступ к ресурсу, который защищен данным разрешением, запрещен.</summary>
		// Token: 0x04001FEC RID: 8172
		None,
		/// <summary>Разрешение предоставляет полный доступ к защищаемому ресурсу.</summary>
		// Token: 0x04001FED RID: 8173
		Unrestricted
	}
}
