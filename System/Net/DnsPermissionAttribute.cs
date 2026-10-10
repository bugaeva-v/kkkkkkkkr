using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Устанавливает разрешение на запрос сведений с DNS-серверов.</summary>
	// Token: 0x0200067F RID: 1663
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class DnsPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.DnsPermissionAttribute" /> заданным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="action" /> не является допустимым <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06003460 RID: 13408 RVA: 0x000A97B6 File Offset: 0x000A79B6
		public DnsPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Создает и возвращает новый экземпляр класса <see cref="T:System.Net.DnsPermission" />.</summary>
		/// <returns>
		///   <see cref="T:System.Net.DnsPermission" />, соответствующее данному объявлению безопасности.</returns>
		// Token: 0x06003461 RID: 13409 RVA: 0x000B667B File Offset: 0x000B487B
		public override IPermission CreatePermission()
		{
			return new DnsPermission(base.Unrestricted ? PermissionState.Unrestricted : PermissionState.None);
		}
	}
}
