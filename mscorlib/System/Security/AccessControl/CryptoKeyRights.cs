using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет операцию с ключом шифрования, доступ и аудит которой обеспечивается правилом авторизации.</summary>
	// Token: 0x0200051D RID: 1309
	[Flags]
	public enum CryptoKeyRights
	{
		/// <summary>Чтение данных ключа.</summary>
		// Token: 0x04002473 RID: 9331
		ReadData = 1,
		/// <summary>Запись данных ключа.</summary>
		// Token: 0x04002474 RID: 9332
		WriteData = 2,
		/// <summary>Чтение дополнительных атрибутов ключа.</summary>
		// Token: 0x04002475 RID: 9333
		ReadExtendedAttributes = 8,
		/// <summary>Запись дополнительных атрибутов ключа.</summary>
		// Token: 0x04002476 RID: 9334
		WriteExtendedAttributes = 16,
		/// <summary>Чтение атрибутов ключа.</summary>
		// Token: 0x04002477 RID: 9335
		ReadAttributes = 128,
		/// <summary>Запись атрибутов ключа.</summary>
		// Token: 0x04002478 RID: 9336
		WriteAttributes = 256,
		/// <summary>Удаление ключа.</summary>
		// Token: 0x04002479 RID: 9337
		Delete = 65536,
		/// <summary>Чтение разрешений для ключа.</summary>
		// Token: 0x0400247A RID: 9338
		ReadPermissions = 131072,
		/// <summary>Изменение разрешений для ключа.</summary>
		// Token: 0x0400247B RID: 9339
		ChangePermissions = 262144,
		/// <summary>Получение ключа во владение.</summary>
		// Token: 0x0400247C RID: 9340
		TakeOwnership = 524288,
		/// <summary>Использование ключа для синхронизации.</summary>
		// Token: 0x0400247D RID: 9341
		Synchronize = 1048576,
		/// <summary>Полный контроль над ключом.</summary>
		// Token: 0x0400247E RID: 9342
		FullControl = 2032027,
		/// <summary>Комбинация <see cref="F:System.Security.AccessControl.CryptoKeyRights.GenericRead" /> и <see cref="F:System.Security.AccessControl.CryptoKeyRights.GenericWrite" />.</summary>
		// Token: 0x0400247F RID: 9343
		GenericAll = 268435456,
		/// <summary>Не используется.</summary>
		// Token: 0x04002480 RID: 9344
		GenericExecute = 536870912,
		/// <summary>Запись данных ключа, расширенных атрибутов ключа, атрибутов ключа и разрешений для ключа.</summary>
		// Token: 0x04002481 RID: 9345
		GenericWrite = 1073741824,
		/// <summary>Чтение данных ключа, расширенных атрибутов ключа, атрибутов ключа и разрешений для ключа.</summary>
		// Token: 0x04002482 RID: 9346
		GenericRead = -2147483648
	}
}
