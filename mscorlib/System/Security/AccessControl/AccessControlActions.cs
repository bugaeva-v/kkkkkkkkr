using System;

namespace System.Security.AccessControl
{
	/// <summary>Определяет действия, разрешенные для защищаемых объектов.</summary>
	// Token: 0x020004FF RID: 1279
	[Flags]
	public enum AccessControlActions
	{
		/// <summary>Доступ запрещен.</summary>
		// Token: 0x040023FA RID: 9210
		None = 0,
		/// <summary>Разрешен доступ только для чтения.</summary>
		// Token: 0x040023FB RID: 9211
		View = 1,
		/// <summary>Разрешен доступ только для записи.</summary>
		// Token: 0x040023FC RID: 9212
		Change = 2
	}
}
