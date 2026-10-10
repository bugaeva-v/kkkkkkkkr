using System;

namespace System.Security.Permissions
{
	/// <summary>Указывает разрешенный доступ к значениям и разделам реестра.</summary>
	// Token: 0x0200042F RID: 1071
	[Flags]
	public enum RegistryPermissionAccess
	{
		/// <summary>Доступ <see cref="F:System.Security.Permissions.RegistryPermissionAccess.Create" />, <see cref="F:System.Security.Permissions.RegistryPermissionAccess.Read" /> и <see cref="F:System.Security.Permissions.RegistryPermissionAccess.Write" /> к переменным реестра. Флаг <see cref="F:System.Security.Permissions.RegistryPermissionAccess.AllAccess" /> представляет несколько значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />, поэтому при его использовании в качестве параметра <paramref name="access" /> метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.RegistryPermission.GetPathList(System.Security.Permissions.RegistryPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x04001FF6 RID: 8182
		AllAccess = 7,
		/// <summary>Доступ к переменным реестра с разрешением на создание.</summary>
		// Token: 0x04001FF7 RID: 8183
		Create = 4,
		/// <summary>Отсутствие доступа к переменным реестра. Флаг <see cref="F:System.Security.Permissions.RegistryPermissionAccess.NoAccess" /> не представляет допустимых значений <see cref="T:System.Security.Permissions.RegistryPermissionAccess" />, поэтому при его использовании в качестве параметра метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.RegistryPermission.GetPathList(System.Security.Permissions.RegistryPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x04001FF8 RID: 8184
		NoAccess = 0,
		/// <summary>Доступ к переменным реестра с разрешением на чтение.</summary>
		// Token: 0x04001FF9 RID: 8185
		Read = 1,
		/// <summary>Доступ к переменным реестра с разрешением на запись.</summary>
		// Token: 0x04001FFA RID: 8186
		Write = 2
	}
}
