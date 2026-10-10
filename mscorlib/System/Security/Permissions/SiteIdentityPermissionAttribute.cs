using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.SiteIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200045B RID: 1115
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class SiteIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.SiteIdentityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002D51 RID: 11601 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public SiteIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает имя веб-узла вызывающего кода.</summary>
		/// <returns>Имя веб-узла для сравнения с именем веб-узла, указанного поставщиком безопасности.</returns>
		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000A2494 File Offset: 0x000A0694
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x000A249C File Offset: 0x000A069C
		public string Site
		{
			get
			{
				return this.site;
			}
			set
			{
				this.site = value;
			}
		}

		/// <summary>Создает и возвращает новый экземпляр объекта <see cref="T:System.Security.Permissions.SiteIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.SiteIdentityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002D54 RID: 11604 RVA: 0x000A24A8 File Offset: 0x000A06A8
		public override IPermission CreatePermission()
		{
			SiteIdentityPermission result;
			if (base.Unrestricted)
			{
				result = new SiteIdentityPermission(PermissionState.Unrestricted);
			}
			else if (this.site == null)
			{
				result = new SiteIdentityPermission(PermissionState.None);
			}
			else
			{
				result = new SiteIdentityPermission(this.site);
			}
			return result;
		}

		// Token: 0x040020AC RID: 8364
		private string site;
	}
}
