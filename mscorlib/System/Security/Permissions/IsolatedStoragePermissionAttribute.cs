using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.IsolatedStoragePermission" /> к коду с помощью декларативной безопасности.</summary>
	// Token: 0x02000444 RID: 1092
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public abstract class IsolatedStoragePermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.IsolatedStoragePermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002C45 RID: 11333 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		protected IsolatedStoragePermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает уровень изолированного хранилища, которое должно быть объявлено.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.IsolatedStorageContainment" />.</returns>
		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002C46 RID: 11334 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
		// (set) Token: 0x06002C47 RID: 11335 RVA: 0x0009F5D8 File Offset: 0x0009D7D8
		public IsolatedStorageContainment UsageAllowed
		{
			get
			{
				return this.usage_allowed;
			}
			set
			{
				this.usage_allowed = value;
			}
		}

		/// <summary>Получает или задает максимальный размер квоты хранилища пользователя.</summary>
		/// <returns>Максимальный размер квоты хранилища пользователя в байтах.</returns>
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002C48 RID: 11336 RVA: 0x0009F5E1 File Offset: 0x0009D7E1
		// (set) Token: 0x06002C49 RID: 11337 RVA: 0x0009F5E9 File Offset: 0x0009D7E9
		public long UserQuota
		{
			get
			{
				return this.user_quota;
			}
			set
			{
				this.user_quota = value;
			}
		}

		// Token: 0x04002048 RID: 8264
		private IsolatedStorageContainment usage_allowed;

		// Token: 0x04002049 RID: 8265
		private long user_quota;
	}
}
