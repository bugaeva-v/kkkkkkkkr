using System;
using System.Runtime.InteropServices;
using System.Security.Claims;

namespace System.Security.Principal
{
	/// <summary>Представляет универсального участника.</summary>
	// Token: 0x020004E2 RID: 1250
	[ComVisible(true)]
	[Serializable]
	public class GenericPrincipal : ClaimsPrincipal
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.GenericPrincipal" /> из удостоверения пользователя и массива имен ролей, которые назначены представляемому этим удостоверением пользователю.</summary>
		/// <param name="identity">Базовая реализация <see cref="T:System.Security.Principal.IIdentity" /> — представляет любого пользователя.</param>
		/// <param name="roles">Массив имен ролей, назначенных пользователям, которые представлены параметром <paramref name="identity" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="identity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060031E9 RID: 12777 RVA: 0x000B7ACC File Offset: 0x000B5CCC
		public GenericPrincipal(IIdentity identity, string[] roles)
		{
			if (identity == null)
			{
				throw new ArgumentNullException("identity");
			}
			this.m_identity = identity;
			if (roles != null)
			{
				this.m_roles = new string[roles.Length];
				for (int i = 0; i < roles.Length; i++)
				{
					this.m_roles[i] = roles[i];
				}
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060031EA RID: 12778 RVA: 0x000B7B1E File Offset: 0x000B5D1E
		internal string[] Roles
		{
			get
			{
				return this.m_roles;
			}
		}

		/// <summary>Получает удостоверение <see cref="T:System.Security.Principal.GenericIdentity" /> пользователя, представленного текущим элементом <see cref="T:System.Security.Principal.GenericPrincipal" />.</summary>
		/// <returns>Удостоверение <see cref="T:System.Security.Principal.GenericIdentity" /> пользователя, представленного элементом <see cref="T:System.Security.Principal.GenericPrincipal" />.</returns>
		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060031EB RID: 12779 RVA: 0x000B7B26 File Offset: 0x000B5D26
		public override IIdentity Identity
		{
			get
			{
				return this.m_identity;
			}
		}

		/// <summary>Определяет, относится ли текущий элемент <see cref="T:System.Security.Principal.GenericPrincipal" /> к указанной роли.</summary>
		/// <param name="role">Имя роли, для которой требуется проверить членство.</param>
		/// <returns>
		///   <see langword="true" />, если текущий элемент <see cref="T:System.Security.Principal.GenericPrincipal" /> является элементом указанной роли; в противном случае — <see langword="false" />.</returns>
		// Token: 0x060031EC RID: 12780 RVA: 0x000B7B30 File Offset: 0x000B5D30
		public override bool IsInRole(string role)
		{
			if (this.m_roles == null)
			{
				return false;
			}
			int length = role.Length;
			foreach (string text in this.m_roles)
			{
				if (text != null && length == text.Length && string.Compare(role, 0, text, 0, length, true) == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040022BD RID: 8893
		private IIdentity m_identity;

		// Token: 0x040022BE RID: 8894
		private string[] m_roles;
	}
}
