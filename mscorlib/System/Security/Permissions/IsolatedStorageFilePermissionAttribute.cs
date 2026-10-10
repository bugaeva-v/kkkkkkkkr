using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.IsolatedStorageFilePermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000442 RID: 1090
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class IsolatedStorageFilePermissionAttribute : IsolatedStoragePermissionAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.IsolatedStorageFilePermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002C3A RID: 11322 RVA: 0x0009F388 File Offset: 0x0009D588
		public IsolatedStorageFilePermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.IsolatedStorageFilePermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.IsolatedStorageFilePermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002C3B RID: 11323 RVA: 0x0009F394 File Offset: 0x0009D594
		public override IPermission CreatePermission()
		{
			IsolatedStorageFilePermission isolatedStorageFilePermission;
			if (base.Unrestricted)
			{
				isolatedStorageFilePermission = new IsolatedStorageFilePermission(PermissionState.Unrestricted);
			}
			else
			{
				isolatedStorageFilePermission = new IsolatedStorageFilePermission(PermissionState.None);
				isolatedStorageFilePermission.UsageAllowed = base.UsageAllowed;
				isolatedStorageFilePermission.UserQuota = base.UserQuota;
			}
			return isolatedStorageFilePermission;
		}
	}
}
