using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Задает запрашиваемый тип доступа к файлу.</summary>
	// Token: 0x02000439 RID: 1081
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum FileIOPermissionAccess
	{
		/// <summary>Доступ к файлу или каталогу запрещен. Флаг <see cref="F:System.Security.Permissions.FileIOPermissionAccess.NoAccess" /> не представляет допустимых значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />, поэтому при его использовании в качестве параметра метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.FileIOPermission.GetPathList(System.Security.Permissions.FileIOPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x0400201E RID: 8222
		NoAccess = 0,
		/// <summary>Доступ на чтение из файла или каталога.</summary>
		// Token: 0x0400201F RID: 8223
		Read = 1,
		/// <summary>Доступ на запись в файл и каталог или на удаление файла и каталога. Доступ <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> включает право на удаление или перезапись файлов или каталогов.</summary>
		// Token: 0x04002020 RID: 8224
		Write = 2,
		/// <summary>Доступ на добавление данных к файлу или каталогу. Доступ <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Append" /> включает право создания нового файла или каталога.</summary>
		// Token: 0x04002021 RID: 8225
		Append = 4,
		/// <summary>Доступ к сведениям, включенным в путь. Это позволяет защитить конфиденциальные сведения, содержащиеся в пути, такие как имя пользователя, а также сведения о структуре каталога, которые отображает путь. Это значение не предоставляет доступа к файлам и папкам, на которые указывает путь.</summary>
		// Token: 0x04002022 RID: 8226
		PathDiscovery = 8,
		/// <summary>Доступ <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Append" />, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" />, <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" /> и <see cref="F:System.Security.Permissions.FileIOPermissionAccess.PathDiscovery" /> к файлу или каталогу. Флаг <see cref="F:System.Security.Permissions.FileIOPermissionAccess.AllAccess" /> представляет несколько значений <see cref="T:System.Security.Permissions.FileIOPermissionAccess" />, поэтому при его использовании в качестве параметра <paramref name="access" /> метода <see cref="T:System.ArgumentException" /> создается исключение <see cref="M:System.Security.Permissions.FileIOPermission.GetPathList(System.Security.Permissions.FileIOPermissionAccess)" />, поскольку данный метод принимает только одно значение.</summary>
		// Token: 0x04002023 RID: 8227
		AllAccess = 15
	}
}
