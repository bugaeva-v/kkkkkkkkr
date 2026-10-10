using System;

namespace System.Security.Permissions
{
	/// <summary>Указывает тип доступа к буферу обмена, допустимый для вызывающего кода.</summary>
	// Token: 0x02000430 RID: 1072
	public enum UIPermissionClipboard
	{
		/// <summary>Буфер обмена может быть использован без ограничений.</summary>
		// Token: 0x04001FFC RID: 8188
		AllClipboard = 2,
		/// <summary>Буфер обмена не может быть использован.</summary>
		// Token: 0x04001FFD RID: 8189
		NoClipboard = 0,
		/// <summary>Возможность помещения данных в буфер обмена ( <see langword="Copy" />, <see langword="Cut" /> ) неограничена. Элементы управления, которые принимают команду <see langword="Paste" />, например текстовое поле, могут получать данные из буфера обмена, но пользовательские элементы управления, в которых чтение из буфера обмена выполняется программно, такого доступа не имеют.</summary>
		// Token: 0x04001FFE RID: 8190
		OwnClipboard
	}
}
