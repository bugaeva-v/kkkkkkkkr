using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.UrlIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000463 RID: 1123
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class UrlIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UrlIdentityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002DA7 RID: 11687 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public UrlIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает полный URL-адрес вызывающего кода.</summary>
		/// <returns>URL-адрес, который необходимо сравнить с URL-адресом, указанным хостом.</returns>
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x000A38EC File Offset: 0x000A1AEC
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x000A38F4 File Offset: 0x000A1AF4
		public string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				this.url = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.UrlIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.UrlIdentityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002DAA RID: 11690 RVA: 0x000A38FD File Offset: 0x000A1AFD
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new UrlIdentityPermission(PermissionState.Unrestricted);
			}
			if (this.url == null)
			{
				return new UrlIdentityPermission(PermissionState.None);
			}
			return new UrlIdentityPermission(this.url);
		}

		// Token: 0x040020BF RID: 8383
		private string url;
	}
}
