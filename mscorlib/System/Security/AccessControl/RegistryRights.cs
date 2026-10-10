using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет права доступа, которые можно применять к объектам реестра.</summary>
	// Token: 0x02000547 RID: 1351
	[Flags]
	public enum RegistryRights
	{
		/// <summary>Право запрашивать пары "имя-значение" в разделе реестра.</summary>
		// Token: 0x040024DE RID: 9438
		QueryValues = 1,
		/// <summary>Право создавать, удалять и задавать пары "имя-значение" в разделе реестра.</summary>
		// Token: 0x040024DF RID: 9439
		SetValue = 2,
		/// <summary>Право создавать подразделы в разделе реестра.</summary>
		// Token: 0x040024E0 RID: 9440
		CreateSubKey = 4,
		/// <summary>Право создавать список подразделов в разделе реестра.</summary>
		// Token: 0x040024E1 RID: 9441
		EnumerateSubKeys = 8,
		/// <summary>Право запрашивать уведомление об изменениях раздела реестра.</summary>
		// Token: 0x040024E2 RID: 9442
		Notify = 16,
		/// <summary>Зарезервировано для системного использования.</summary>
		// Token: 0x040024E3 RID: 9443
		CreateLink = 32,
		/// <summary>Право удалить раздел реестра.</summary>
		// Token: 0x040024E4 RID: 9444
		Delete = 65536,
		/// <summary>Право открывать и копировать правила доступа и аудита, связанные с разделом реестра.</summary>
		// Token: 0x040024E5 RID: 9445
		ReadPermissions = 131072,
		/// <summary>Право создавать, удалять и задавать пары "имя-значение" в разделе реестра, создавать и удалять подразделы, запрашивать уведомление об изменениях, получать список подразделов, а также право на чтение правил доступа и аудита раздела.</summary>
		// Token: 0x040024E6 RID: 9446
		WriteKey = 131078,
		/// <summary>Право запрашивать пары "имя-значение" в разделе реестра, запрашивать уведомление об изменениях, получать список подразделов, а также право на чтение правил доступа и аудита раздела.</summary>
		// Token: 0x040024E7 RID: 9447
		ReadKey = 131097,
		/// <summary>Эквивалентно <see cref="F:System.Security.AccessControl.RegistryRights.ReadKey" />.</summary>
		// Token: 0x040024E8 RID: 9448
		ExecuteKey = 131097,
		/// <summary>Право изменять правила доступа и аудита, связанные с разделом реестра.</summary>
		// Token: 0x040024E9 RID: 9449
		ChangePermissions = 262144,
		/// <summary>Право изменять владельца раздела реестра.</summary>
		// Token: 0x040024EA RID: 9450
		TakeOwnership = 524288,
		/// <summary>Право на полный контроль над разделом реестра, а также на изменение правил доступа и аудита.</summary>
		// Token: 0x040024EB RID: 9451
		FullControl = 983103
	}
}
