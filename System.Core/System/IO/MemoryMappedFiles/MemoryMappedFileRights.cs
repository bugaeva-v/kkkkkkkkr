using System;

namespace System.IO.MemoryMappedFiles
{
	/// <summary>
	///         Задает права доступа, размещенный в памяти файл, который не связан с файлом на диске.
	///       </summary>
	// Token: 0x02000336 RID: 822
	[Flags]
	public enum MemoryMappedFileRights
	{
		/// <summary>
		///         Право на чтение и запись в файл с тем ограничением, что все операции записи не будет виден другим процессам.
		///       </summary>
		// Token: 0x04000BF9 RID: 3065
		CopyOnWrite = 1,
		/// <summary>
		///         Право добавлять данные в файл или удалить данные из файла.
		///       </summary>
		// Token: 0x04000BFA RID: 3066
		Write = 2,
		/// <summary>
		///         Право открывать и копировать файл только для чтения.
		///       </summary>
		// Token: 0x04000BFB RID: 3067
		Read = 4,
		/// <summary>
		///         Право на запуск файла приложения.
		///       </summary>
		// Token: 0x04000BFC RID: 3068
		Execute = 8,
		/// <summary>
		///         Право на удаление файла.
		///       </summary>
		// Token: 0x04000BFD RID: 3069
		Delete = 65536,
		/// <summary>
		///         Право открывать и копировать доступа и аудита правил из файла.
		///          Это не включает в себя право на чтение данных, атрибутов файловой системы или дополнительных атрибутов файловой системы.
		///       </summary>
		// Token: 0x04000BFE RID: 3070
		ReadPermissions = 131072,
		/// <summary>
		///         Право на изменение параметров безопасности и аудита, связанные с файлом.
		///       </summary>
		// Token: 0x04000BFF RID: 3071
		ChangePermissions = 262144,
		/// <summary>
		///         Право изменять владельца файла.
		///       </summary>
		// Token: 0x04000C00 RID: 3072
		TakeOwnership = 524288,
		/// <summary>
		///         Право открывать и копировать файлы и право добавлять данные в файл или удалить данные из файла.
		///       </summary>
		// Token: 0x04000C01 RID: 3073
		ReadWrite = 6,
		/// <summary>
		///         Право открывать и копировать папки или файла только для чтения, а также запускать файлы приложений.
		///          Это право включает <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileRights.Read" /> вправо и <see cref="F:System.IO.MemoryMappedFiles.MemoryMappedFileRights.Execute" /> вправо.
		///       </summary>
		// Token: 0x04000C02 RID: 3074
		ReadExecute = 12,
		/// <summary>
		///         Право открывать и копировать файл право добавлять данные в файл или удалить данные из файла и право на запуск файла приложения.
		///       </summary>
		// Token: 0x04000C03 RID: 3075
		ReadWriteExecute = 14,
		/// <summary>
		///         Право на полный контроль над файлом и изменение управления доступом и аудита.
		///          Это значение представляет право выполнять любые операции с файлом и представляет собой сочетание всех прав в этом перечислении.
		///       </summary>
		// Token: 0x04000C04 RID: 3076
		FullControl = 983055,
		/// <summary>
		///         Право на получение или задание разрешений для файла.
		///       </summary>
		// Token: 0x04000C05 RID: 3077
		AccessSystemSecurity = 16777216
	}
}
