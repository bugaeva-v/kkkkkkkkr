using System;

namespace System.Security.Principal
{
	/// <summary>Определяет привилегии учетной записи пользователя, связанной с токеном доступа.</summary>
	// Token: 0x020004DD RID: 1245
	[Flags]
	public enum TokenAccessLevels
	{
		/// <summary>Пользователь может присоединять основной токен к процессу.</summary>
		// Token: 0x040022A6 RID: 8870
		AssignPrimary = 1,
		/// <summary>Пользователь может дублировать токен.</summary>
		// Token: 0x040022A7 RID: 8871
		Duplicate = 2,
		/// <summary>Пользователь может олицетворять клиента.</summary>
		// Token: 0x040022A8 RID: 8872
		Impersonate = 4,
		/// <summary>Пользователь может запрашивать токен.</summary>
		// Token: 0x040022A9 RID: 8873
		Query = 8,
		/// <summary>Пользователь может запрашивать источник токена.</summary>
		// Token: 0x040022AA RID: 8874
		QuerySource = 16,
		/// <summary>Пользователь может включать или отключать привилегии в токене.</summary>
		// Token: 0x040022AB RID: 8875
		AdjustPrivileges = 32,
		/// <summary>Пользователь может изменять атрибуты групп в токене.</summary>
		// Token: 0x040022AC RID: 8876
		AdjustGroups = 64,
		/// <summary>Пользователь может изменять владельца по умолчанию, основную группу или список управления доступом на уровне пользователей (DACL) токена.</summary>
		// Token: 0x040022AD RID: 8877
		AdjustDefault = 128,
		/// <summary>Пользователь может изменять идентификатор сеанса токена.</summary>
		// Token: 0x040022AE RID: 8878
		AdjustSessionId = 256,
		/// <summary>Пользователь имеет стандартные права чтения и привилегию <see cref="F:System.Security.Principal.TokenAccessLevels.Query" /> для токена.</summary>
		// Token: 0x040022AF RID: 8879
		Read = 131080,
		/// <summary>Пользователь имеет стандартные права записи и привилегии <see cref="F:System.Security.Principal.TokenAccessLevels.AdjustPrivileges" />, <see cref="F:System.Security.Principal.TokenAccessLevels.AdjustGroups" /> и <see cref="F:System.Security.Principal.TokenAccessLevels.AdjustDefault" /> для токена.</summary>
		// Token: 0x040022B0 RID: 8880
		Write = 131296,
		/// <summary>Пользователь имеет полный доступ к токену.</summary>
		// Token: 0x040022B1 RID: 8881
		AllAccess = 983551,
		/// <summary>Максимальное значение, которое может быть назначено перечислению <see cref="T:System.Security.Principal.TokenAccessLevels" />.</summary>
		// Token: 0x040022B2 RID: 8882
		MaximumAllowed = 33554432
	}
}
