using System;

namespace System.IO.Pipes
{
	/// <summary>
	///         Определяет права доступа для использования при создании доступа и аудита.
	///       </summary>
	// Token: 0x02000347 RID: 839
	[Flags]
	public enum PipeAccessRights
	{
		/// <summary>
		///         Право на чтение данных из канала.
		///          Это включает право на чтение атрибутов файловой системы, дополнительных атрибутов файловой системы или правил доступа и аудита.
		///       </summary>
		// Token: 0x04000C28 RID: 3112
		ReadData = 1,
		/// <summary>
		///         Право на запись данных в канал.
		///          Право на запись атрибутов файловой системы или дополнительных файловой системы атрибуты отсутствуют.
		///       </summary>
		// Token: 0x04000C29 RID: 3113
		WriteData = 2,
		/// <summary>
		///         Право на чтение атрибутов файловой системы из канала.
		///          Это не включает в себя право на чтение данных, дополнительных атрибутов файловой системы или доступа и аудита.
		///       </summary>
		// Token: 0x04000C2A RID: 3114
		ReadAttributes = 128,
		/// <summary>
		///         Право на запись атрибутов файловой системы в канал.
		///          Право на запись данных или расширенных атрибутов системы отсутствует.
		///       </summary>
		// Token: 0x04000C2B RID: 3115
		WriteAttributes = 256,
		/// <summary>
		///         Право на чтение дополнительных атрибутов файловой системы из канала.
		///          Это не включает в себя право на чтение данных, атрибутов файловой системы или доступа и аудита.
		///       </summary>
		// Token: 0x04000C2C RID: 3116
		ReadExtendedAttributes = 8,
		/// <summary>
		///         Право на запись дополнительных атрибутов файловой системы в канал.
		///          Это включает право на запись данных или атрибутов файла.
		///       </summary>
		// Token: 0x04000C2D RID: 3117
		WriteExtendedAttributes = 16,
		/// <summary>
		///         Право на создание нового канала.
		///          Установка это право доступа также наборы <see cref="F:System.IO.Pipes.PipeAccessRights.Synchronize" /> вправо.
		///       </summary>
		// Token: 0x04000C2E RID: 3118
		CreateNewInstance = 4,
		/// <summary>
		///         Право на удаление канала.
		///       </summary>
		// Token: 0x04000C2F RID: 3119
		Delete = 65536,
		/// <summary>
		///         Право на чтение правил и аудита из канала.
		///          Это не включает в себя право на чтение данных, атрибутов файловой системы или дополнительных атрибутов файловой системы.
		///       </summary>
		// Token: 0x04000C30 RID: 3120
		ReadPermissions = 131072,
		/// <summary>
		///         Право на изменение параметров безопасности и аудита, связанных с каналом.
		///       </summary>
		// Token: 0x04000C31 RID: 3121
		ChangePermissions = 262144,
		/// <summary>
		///         Право на смену владельца канала.
		///          Обратите внимание, что владельцы канала имеют полный доступ к этому ресурсу.
		///       </summary>
		// Token: 0x04000C32 RID: 3122
		TakeOwnership = 524288,
		/// <summary>
		///         Указывает, может ли приложение ждать дескриптора канала для синхронизации с завершением операции ввода-вывода.
		///       </summary>
		// Token: 0x04000C33 RID: 3123
		Synchronize = 1048576,
		/// <summary>
		///         Право на полный контроль над каналом, а также изменение управления доступом и аудита.
		///          Это значение представляет комбинацию всех прав в этом перечислении.
		///       </summary>
		// Token: 0x04000C34 RID: 3124
		FullControl = 2032031,
		/// <summary>
		///         Право на чтение из канала.
		///          Это право включает <see cref="F:System.IO.Pipes.PipeAccessRights.ReadAttributes" />, <see cref="F:System.IO.Pipes.PipeAccessRights.ReadData" />, <see cref="F:System.IO.Pipes.PipeAccessRights.ReadExtendedAttributes" />, и <see cref="F:System.IO.Pipes.PipeAccessRights.ReadPermissions" /> права.
		///       </summary>
		// Token: 0x04000C35 RID: 3125
		Read = 131209,
		/// <summary>
		///         Указывает право на запись в канал.
		///          Это право включает <see cref="F:System.IO.Pipes.PipeAccessRights.WriteAttributes" />, <see cref="F:System.IO.Pipes.PipeAccessRights.WriteData" />, и <see cref="F:System.IO.Pipes.PipeAccessRights.WriteExtendedAttributes" /> права.
		///       </summary>
		// Token: 0x04000C36 RID: 3126
		Write = 274,
		/// <summary>
		///         Право на чтение и запись из канала.
		///          Это право включает <see cref="F:System.IO.Pipes.PipeAccessRights.ReadAttributes" />, <see cref="F:System.IO.Pipes.PipeAccessRights.ReadData" />, <see cref="F:System.IO.Pipes.PipeAccessRights.ReadExtendedAttributes" />, <see cref="F:System.IO.Pipes.PipeAccessRights.ReadPermissions" />, <see cref="F:System.IO.Pipes.PipeAccessRights.WriteAttributes" />, <see cref="F:System.IO.Pipes.PipeAccessRights.WriteData" />, и <see cref="F:System.IO.Pipes.PipeAccessRights.WriteExtendedAttributes" /> права.
		///       </summary>
		// Token: 0x04000C37 RID: 3127
		ReadWrite = 131483,
		/// <summary>
		///         Право вносить изменения в системе управления доступом (SACL).
		///       </summary>
		// Token: 0x04000C38 RID: 3128
		AccessSystemSecurity = 16777216
	}
}
