using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Определяет наименьшую единицу разрешения на управление доступом для кода, заданную для объекта <see cref="T:System.Diagnostics.EventLog" />.</summary>
	// Token: 0x02000263 RID: 611
	[Serializable]
	public class EventLogPermissionEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogPermissionEntry" />.</summary>
		/// <param name="permissionAccess">Поразрядное сочетание значений <see cref="T:System.Diagnostics.EventLogPermissionAccess" />. Это значение присваивается свойству <see cref="P:System.Diagnostics.EventLogPermissionEntry.PermissionAccess" />.</param>
		/// <param name="machineName">Имя компьютера, на котором производится чтение и запись событий. Это значение присваивается свойству <see cref="P:System.Diagnostics.EventLogPermissionEntry.MachineName" />.</param>
		/// <exception cref="T:System.ArgumentException">Недопустимое имя компьютера.</exception>
		// Token: 0x06001316 RID: 4886 RVA: 0x00050F7A File Offset: 0x0004F17A
		public EventLogPermissionEntry(EventLogPermissionAccess permissionAccess, string machineName)
		{
			ResourcePermissionBase.ValidateMachineName(machineName);
			this.permissionAccess = permissionAccess;
			this.machineName = machineName;
		}

		/// <summary>Возвращает имя компьютера, на котором производится чтение или запись событий.</summary>
		/// <returns>Имя компьютера, на котором производится чтение и запись событий.</returns>
		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001317 RID: 4887 RVA: 0x00050F96 File Offset: 0x0004F196
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
		}

		/// <summary>Получает уровни доступа к разрешениям, используемым в запросе разрешений.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Diagnostics.EventLogPermissionAccess" />.</returns>
		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x00050F9E File Offset: 0x0004F19E
		public EventLogPermissionAccess PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00050FA6 File Offset: 0x0004F1A6
		internal ResourcePermissionBaseEntry CreateResourcePermissionBaseEntry()
		{
			return new ResourcePermissionBaseEntry((int)this.permissionAccess, new string[]
			{
				this.machineName
			});
		}

		// Token: 0x04000AD9 RID: 2777
		private EventLogPermissionAccess permissionAccess;

		// Token: 0x04000ADA RID: 2778
		private string machineName;
	}
}
