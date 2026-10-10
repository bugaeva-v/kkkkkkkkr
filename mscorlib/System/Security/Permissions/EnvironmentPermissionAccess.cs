using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Задает доступ к переменным среды.</summary>
	// Token: 0x02000434 RID: 1076
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum EnvironmentPermissionAccess
	{
		/// <summary>Доступ к переменным среды запрещен. Флаг <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.NoAccess" /> не представляет допустимых значений <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />, поэтому при его использовании в качестве параметра метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.EnvironmentPermission.GetPathList(System.Security.Permissions.EnvironmentPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x04002009 RID: 8201
		NoAccess = 0,
		/// <summary>Задается только доступ с правом на чтение переменных среды. Изменение, удаление и создание переменных среды не предусмотрено на этом уровне доступа.</summary>
		// Token: 0x0400200A RID: 8202
		Read = 1,
		/// <summary>Задается только доступ с правом на запись переменных среды. Доступ с правом на запись предусматривает создание и удаление переменных среды, а также изменение существующих значений. Чтение переменных среды не предусмотрено на этом уровне доступа.</summary>
		// Token: 0x0400200B RID: 8203
		Write = 2,
		/// <summary>Доступ <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.Read" /> и <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.Write" /> к переменным среды. Флаг <see cref="F:System.Security.Permissions.EnvironmentPermissionAccess.AllAccess" /> представляет несколько значений <see cref="T:System.Security.Permissions.EnvironmentPermissionAccess" />, поэтому при его использовании в качестве параметра <paramref name="flag" /> метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.EnvironmentPermission.GetPathList(System.Security.Permissions.EnvironmentPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x0400200C RID: 8204
		AllAccess = 3
	}
}
