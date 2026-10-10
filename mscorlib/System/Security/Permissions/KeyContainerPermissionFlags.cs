using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Задает разрешенный тип доступа к контейнеру ключей.</summary>
	// Token: 0x0200044A RID: 1098
	[ComVisible(true)]
	[Flags]
	[Serializable]
	public enum KeyContainerPermissionFlags
	{
		/// <summary>Нет доступа к контейнеру ключей.</summary>
		// Token: 0x0400205C RID: 8284
		NoFlags = 0,
		/// <summary>Создание контейнера ключей.</summary>
		// Token: 0x0400205D RID: 8285
		Create = 1,
		/// <summary>Откройте контейнер ключей и используйте открытый ключ.</summary>
		// Token: 0x0400205E RID: 8286
		Open = 2,
		/// <summary>Удаление контейнера ключей.</summary>
		// Token: 0x0400205F RID: 8287
		Delete = 4,
		/// <summary>Импорт ключа в контейнер ключей.</summary>
		// Token: 0x04002060 RID: 8288
		Import = 16,
		/// <summary>Экспорт ключа из контейнера ключей.</summary>
		// Token: 0x04002061 RID: 8289
		Export = 32,
		/// <summary>Подпишите файл, используя ключ.</summary>
		// Token: 0x04002062 RID: 8290
		Sign = 256,
		/// <summary>Расшифровка контейнера ключей.</summary>
		// Token: 0x04002063 RID: 8291
		Decrypt = 512,
		/// <summary>Просматривает список управления доступом (ACL) для контейнера ключей.</summary>
		// Token: 0x04002064 RID: 8292
		ViewAcl = 4096,
		/// <summary>Изменяет список управления доступом (ACL) для контейнера ключей.</summary>
		// Token: 0x04002065 RID: 8293
		ChangeAcl = 8192,
		/// <summary>Создание, расшифровка, удаление и открывание контейнера ключей; экспорт и импорт ключа; подписывание файлов с помощью ключа; просмотр и изменение списка управления доступом для контейнера ключей.</summary>
		// Token: 0x04002066 RID: 8294
		AllFlags = 13111
	}
}
