using System;

namespace System.IO
{
	/// <summary>Указывает, каким образом операционная система должна открыть файл.</summary>
	// Token: 0x02000B07 RID: 2823
	public enum FileMode
	{
		/// <summary>Указывает, что операционная система должна создавать новый файл. Для этого требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />. Если файл уже существует, создается исключение <see cref="T:System.IO.IOException" />.</summary>
		// Token: 0x04003B34 RID: 15156
		CreateNew = 1,
		/// <summary>Указывает, что операционная система должна создавать новый файл. Если файл уже существует, он будет перезаписан. Для этого требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />. Значение <see langword="FileMode.Create" /> эквивалентно требованию использовать значение <see cref="F:System.IO.FileMode.CreateNew" />, если файл не существует, и значение <see cref="F:System.IO.FileMode.Truncate" /> в противном случае. Если файл уже существует, но является скрытым, создается исключение <see cref="T:System.UnauthorizedAccessException" />.</summary>
		// Token: 0x04003B35 RID: 15157
		Create,
		/// <summary>Указывает, что операционная система должна открыть существующий файл. Возможность открыть данный файл зависит от значения, задаваемого перечислением <see cref="T:System.IO.FileAccess" />. Исключение <see cref="T:System.IO.FileNotFoundException" /> создается, если файл не существует.</summary>
		// Token: 0x04003B36 RID: 15158
		Open,
		/// <summary>Указывает, что операционная система должна открыть файл, если он существует, в противном случае должен быть создан новый файл. Если файл открыт с помощью <see langword="FileAccess.Read" />, требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" />. Если доступ к файлу является <see langword="FileAccess.Write" />, требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />. Если файл открыт с помощью <see langword="FileAccess.ReadWrite" />, требуются разрешения <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Read" /> и <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />.</summary>
		// Token: 0x04003B37 RID: 15159
		OpenOrCreate,
		/// <summary>Указывает, что операционная система должна открыть существующий файл. Если файл открыт, он должен быть усечен таким образом, чтобы его размер стал равен нулю байтов. Для этого требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Write" />. Попытки выполнить чтение из файла, открытого с помощью <see langword="FileMode.Truncate" />, вызывают исключение <see cref="T:System.ArgumentException" />.</summary>
		// Token: 0x04003B38 RID: 15160
		Truncate,
		/// <summary>Открывает файл, если он существует, и находит конец файла; либо создает новый файл. Для этого требуется разрешение <see cref="F:System.Security.Permissions.FileIOPermissionAccess.Append" />. <see langword="FileMode.Append" /> можно использовать только вместе с <see langword="FileAccess.Write" />. Попытка поиска положения перед концом файла вызывает исключение <see cref="T:System.IO.IOException" />, и любая попытка чтения заканчивается неудачей, и создает исключение <see cref="T:System.NotSupportedException" />.</summary>
		// Token: 0x04003B39 RID: 15161
		Append
	}
}
