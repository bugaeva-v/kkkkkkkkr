using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.GacIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200043C RID: 1084
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class GacIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.GacIdentityPermissionAttribute" /> заданным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="action" /> не является допустимым значением <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06002C0B RID: 11275 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public GacIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Создает новый объект <see cref="T:System.Security.Permissions.GacIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.GacIdentityPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002C0C RID: 11276 RVA: 0x0009A086 File Offset: 0x00098286
		public override IPermission CreatePermission()
		{
			return new GacIdentityPermission();
		}
	}
}
