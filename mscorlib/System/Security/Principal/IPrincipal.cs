using System;

namespace System.Security.Principal
{
	/// <summary>Определяет основные возможности объекта участника.</summary>
	// Token: 0x020004DF RID: 1247
	public interface IPrincipal
	{
		/// <summary>Возвращает удостоверение текущего участника.</summary>
		/// <returns>Объект <see cref="T:System.Security.Principal.IIdentity" />, связанный с текущим участником.</returns>
		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060031E7 RID: 12775
		IIdentity Identity { get; }

		/// <summary>Определяет, относится ли текущий участник к указанной роли.</summary>
		/// <param name="role">Имя роли, для которой требуется проверить членство.</param>
		/// <returns>
		///   <see langword="true" />, если текущий участник является элементом указанной роли; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060031E8 RID: 12776
		bool IsInRole(string role);
	}
}
