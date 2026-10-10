using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.ZoneIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000465 RID: 1125
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class ZoneIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ZoneIdentityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002DB7 RID: 11703 RVA: 0x000A3B2F File Offset: 0x000A1D2F
		public ZoneIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
			this.zone = SecurityZone.NoZone;
		}

		/// <summary>Получает и задает членство в зоне содержимого, заданной значением свойства.</summary>
		/// <returns>Одно из значений <see cref="T:System.Security.SecurityZone" />.</returns>
		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06002DB8 RID: 11704 RVA: 0x000A3B3F File Offset: 0x000A1D3F
		// (set) Token: 0x06002DB9 RID: 11705 RVA: 0x000A3B47 File Offset: 0x000A1D47
		public SecurityZone Zone
		{
			get
			{
				return this.zone;
			}
			set
			{
				this.zone = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.ZoneIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.ZoneIdentityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002DBA RID: 11706 RVA: 0x000A3B50 File Offset: 0x000A1D50
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new ZoneIdentityPermission(PermissionState.Unrestricted);
			}
			return new ZoneIdentityPermission(this.zone);
		}

		// Token: 0x040020C2 RID: 8386
		private SecurityZone zone;
	}
}
