using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Определяет наименьшую единицу разрешения системы управления доступом для кода, заданного для объекта <see cref="T:System.Diagnostics.PerformanceCounter" />.</summary>
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class PerformanceCounterPermissionEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />.</summary>
		/// <param name="permissionAccess">Поразрядное сочетание значений <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" />. Это значение присваивается свойству <see cref="P:System.Diagnostics.PerformanceCounterPermissionEntry.PermissionAccess" />.</param>
		/// <param name="machineName">Сервер, на котором постоянно размещается категория счетчика производительности.</param>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует этот счетчик производительности.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="categoryName" /> имеет значение <see langword="null" />.  
		///
		/// или - 
		/// Свойство <paramref name="machineName" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="permissionAccess" /> не является допустимым значением <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" />.  
		///
		/// или - 
		/// Параметр <paramref name="machineName" /> не является допустимым именем компьютера.</exception>
		// Token: 0x06001429 RID: 5161 RVA: 0x00052E80 File Offset: 0x00051080
		public PerformanceCounterPermissionEntry(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName)
		{
			if (machineName == null)
			{
				throw new ArgumentNullException("machineName");
			}
			if ((permissionAccess | PerformanceCounterPermissionAccess.Administer) != PerformanceCounterPermissionAccess.Administer)
			{
				throw new ArgumentException("permissionAccess");
			}
			ResourcePermissionBase.ValidateMachineName(machineName);
			if (categoryName == null)
			{
				throw new ArgumentNullException("categoryName");
			}
			this.permissionAccess = permissionAccess;
			this.machineName = machineName;
			this.categoryName = categoryName;
		}

		/// <summary>Возвращает имя категории счетчика производительности (объект производительности).</summary>
		/// <returns>Имя категории счетчика производительности (объект производительности).</returns>
		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x0600142A RID: 5162 RVA: 0x00052EDB File Offset: 0x000510DB
		public string CategoryName
		{
			get
			{
				return this.categoryName;
			}
		}

		/// <summary>Возвращает имя сервера, на котором постоянно размещается категория счетчика производительности.</summary>
		/// <returns>Имя сервера, на котором постоянно размещается категория.</returns>
		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x0600142B RID: 5163 RVA: 0x00052EE3 File Offset: 0x000510E3
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
		}

		/// <summary>Возвращает уровень доступа разрешения записи.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" />.</returns>
		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x0600142C RID: 5164 RVA: 0x00052EEB File Offset: 0x000510EB
		public PerformanceCounterPermissionAccess PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
		}

		// Token: 0x0600142D RID: 5165 RVA: 0x00052EF3 File Offset: 0x000510F3
		internal ResourcePermissionBaseEntry CreateResourcePermissionBaseEntry()
		{
			return new ResourcePermissionBaseEntry((int)this.permissionAccess, new string[]
			{
				this.machineName,
				this.categoryName
			});
		}

		// Token: 0x04000B2E RID: 2862
		private const PerformanceCounterPermissionAccess All = PerformanceCounterPermissionAccess.Administer;

		// Token: 0x04000B2F RID: 2863
		private PerformanceCounterPermissionAccess permissionAccess;

		// Token: 0x04000B30 RID: 2864
		private string machineName;

		// Token: 0x04000B31 RID: 2865
		private string categoryName;
	}
}
