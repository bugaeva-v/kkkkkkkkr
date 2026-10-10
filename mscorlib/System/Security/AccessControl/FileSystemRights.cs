using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет права доступа, которые используются при создании правил доступа и аудита.</summary>
	// Token: 0x0200052A RID: 1322
	[Flags]
	public enum FileSystemRights
	{
		/// <summary>Право на чтение содержимого каталога.</summary>
		// Token: 0x0400248E RID: 9358
		ListDirectory = 1,
		/// <summary>Право открывать и копировать файл или папку.  Оно не включает в себя право на чтение атрибутов файловой системы, дополнительных атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x0400248F RID: 9359
		ReadData = 1,
		/// <summary>Право на создание файла.</summary>
		// Token: 0x04002490 RID: 9360
		CreateFiles = 2,
		/// <summary>Право открытия и записи для файла или папки.  Оно не включает в себя право на открытие и запись атрибутов файловой системы, дополнительных атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x04002491 RID: 9361
		WriteData = 2,
		/// <summary>Право добавлять данные в конец файла.</summary>
		// Token: 0x04002492 RID: 9362
		AppendData = 4,
		/// <summary>Право на создание папки.</summary>
		// Token: 0x04002493 RID: 9363
		CreateDirectories = 4,
		/// <summary>Право открывать и копировать дополнительные атрибуты файловой системы для папки или файла.  Например, оно позволяет просматривать сведения об авторе или содержимом.  Оно не включает в себя право на чтение данных, атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x04002494 RID: 9364
		ReadExtendedAttributes = 8,
		/// <summary>Право открытия и записи дополнительных атрибутов файловой системы для папки или файла.  Оно не включает в себя право на запись данных, атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x04002495 RID: 9365
		WriteExtendedAttributes = 16,
		/// <summary>Право на запуск файла приложения.</summary>
		// Token: 0x04002496 RID: 9366
		ExecuteFile = 32,
		/// <summary>Право на получение списка содержимого папки и на запуск содержащихся в этой папке приложений.</summary>
		// Token: 0x04002497 RID: 9367
		Traverse = 32,
		/// <summary>Право на удаление папки и всех файлов в ней.</summary>
		// Token: 0x04002498 RID: 9368
		DeleteSubdirectoriesAndFiles = 64,
		/// <summary>Право открывать и копировать атрибуты файловой системы для папки или файла.  Например, это значение дает право на просмотр даты создания или изменения файла.  Оно не включает в себя право на чтение данных, дополнительных атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x04002499 RID: 9369
		ReadAttributes = 128,
		/// <summary>Право открытия и записи атрибутов файловой системы для папки или файла. Оно не включает в себя право на запись данных, дополнительных атрибутов файловой системы или правил доступа и аудита.</summary>
		// Token: 0x0400249A RID: 9370
		WriteAttributes = 256,
		/// <summary>Право создавать папки и файлы, а также добавлять данные в файлы и удалять данные из файлов.  Это право включает в себя права <see cref="F:System.Security.AccessControl.FileSystemRights.WriteData" />, <see cref="F:System.Security.AccessControl.FileSystemRights.AppendData" />, <see cref="F:System.Security.AccessControl.FileSystemRights.WriteExtendedAttributes" /> и <see cref="F:System.Security.AccessControl.FileSystemRights.WriteAttributes" />.</summary>
		// Token: 0x0400249B RID: 9371
		Write = 278,
		/// <summary>Право на удаление папки или файла.</summary>
		// Token: 0x0400249C RID: 9372
		Delete = 65536,
		/// <summary>Право открывать и копировать правила доступа и аудита для папки или файла.  Оно не включает в себя право на чтение данных, атрибутов файловой системы и дополнительных атрибутов файловой системы.</summary>
		// Token: 0x0400249D RID: 9373
		ReadPermissions = 131072,
		/// <summary>Право открывать и копировать папки и файлы с разрешением только для чтения.  Это право включает в себя права <see cref="F:System.Security.AccessControl.FileSystemRights.ReadData" />, <see cref="F:System.Security.AccessControl.FileSystemRights.ReadExtendedAttributes" />, <see cref="F:System.Security.AccessControl.FileSystemRights.ReadAttributes" /> и <see cref="F:System.Security.AccessControl.FileSystemRights.ReadPermissions" />.</summary>
		// Token: 0x0400249E RID: 9374
		Read = 131209,
		/// <summary>Право открывать и копировать и файлы с разрешением только для чтения, а также запускать файлы приложений.  Это право включает права <see cref="F:System.Security.AccessControl.FileSystemRights.Read" /> и <see cref="F:System.Security.AccessControl.FileSystemRights.ExecuteFile" />.</summary>
		// Token: 0x0400249F RID: 9375
		ReadAndExecute = 131241,
		/// <summary>Право на чтение, запись, получение содержимого папки, удаление папок и файлов, а также на запуск файлов приложений.  Это право включает права <see cref="F:System.Security.AccessControl.FileSystemRights.ReadAndExecute" />, <see cref="F:System.Security.AccessControl.FileSystemRights.Write" /> и <see cref="F:System.Security.AccessControl.FileSystemRights.Delete" />.</summary>
		// Token: 0x040024A0 RID: 9376
		Modify = 197055,
		/// <summary>Право на изменение правил безопасности и аудита, связанных с файлом или папкой.</summary>
		// Token: 0x040024A1 RID: 9377
		ChangePermissions = 262144,
		/// <summary>Право менять владельца файла или папки.  Следует иметь в виду, что владельцы ресурса имеют полный доступ к этому ресурсу.</summary>
		// Token: 0x040024A2 RID: 9378
		TakeOwnership = 524288,
		/// <summary>Указывает, может ли приложение ждать синхронизации дескриптора файла с завершением операции ввода-вывода.</summary>
		// Token: 0x040024A3 RID: 9379
		Synchronize = 1048576,
		/// <summary>Право на полный контроль над папкой или файлом, а также на изменение правил управления доступом и аудита.  Это значение представляет право выполнять над файлом любые операции и является объединением всех входящих в перечисление прав.</summary>
		// Token: 0x040024A4 RID: 9380
		FullControl = 2032127
	}
}
