using System;

namespace System.Security.Policy
{
	/// <summary>Определяет метод, создающий новое разрешение идентификации.</summary>
	// Token: 0x020003F9 RID: 1017
	public interface IIdentityPermissionFactory
	{
		/// <summary>Создает новое разрешение идентификации для указанного свидетельства.</summary>
		/// <param name="evidence">Свидетельство, для которого создается новое разрешение идентификации.</param>
		/// <returns>Новое разрешение идентификации.</returns>
		// Token: 0x060029AE RID: 10670
		IPermission CreateIdentityPermission(Evidence evidence);
	}
}
