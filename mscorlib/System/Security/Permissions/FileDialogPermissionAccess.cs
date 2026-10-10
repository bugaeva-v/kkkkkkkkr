using System;

namespace System.Security.Permissions
{
	/// <summary>Указывает разрешенный тип доступа к файлам посредством диалогового окна Файл.</summary>
	// Token: 0x02000429 RID: 1065
	[Flags]
	public enum FileDialogPermissionAccess
	{
		/// <summary>Нет доступа к файлам посредством диалоговых окон Файл.</summary>
		// Token: 0x04001FCE RID: 8142
		None = 0,
		/// <summary>Возможность открывать файлы посредством диалоговых окон Файл.</summary>
		// Token: 0x04001FCF RID: 8143
		Open = 1,
		/// <summary>Возможность открывать и сохранять файлы посредством диалоговых окон Файл.</summary>
		// Token: 0x04001FD0 RID: 8144
		OpenSave = 3,
		/// <summary>Возможность сохранять файлы посредством диалоговых окон Файл.</summary>
		// Token: 0x04001FD1 RID: 8145
		Save = 2
	}
}
