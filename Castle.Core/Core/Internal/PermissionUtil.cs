using System;
using System.Security;
using System.Security.Permissions;

namespace Castle.Core.Internal
{
	// Token: 0x020000E7 RID: 231
	public static class PermissionUtil
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x0001210B File Offset: 0x0001030B
		[SecuritySafeCritical]
		public static bool IsGranted(this IPermission permission)
		{
			PermissionSet permissionSet = new PermissionSet(PermissionState.None);
			permissionSet.AddPermission(permission);
			return permissionSet.IsSubsetOf(AppDomain.CurrentDomain.PermissionSet);
		}
	}
}
