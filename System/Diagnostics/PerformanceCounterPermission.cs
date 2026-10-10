using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Позволяет контролировать разрешения на доступ к коду для счетчика <see cref="T:System.Diagnostics.PerformanceCounter" />.</summary>
	// Token: 0x02000276 RID: 630
	[Serializable]
	public sealed class PerformanceCounterPermission : ResourcePermissionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermission" />.</summary>
		// Token: 0x06001417 RID: 5143 RVA: 0x00052CDD File Offset: 0x00050EDD
		public PerformanceCounterPermission()
		{
			this.SetUp();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermission" /> с указанными записями уровней доступа к разрешениям.</summary>
		/// <param name="permissionAccessEntries">Массив объектов <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntry" />. Это значение присваивается свойству <see cref="P:System.Diagnostics.PerformanceCounterPermission.PermissionEntries" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="permissionAccessEntries" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001418 RID: 5144 RVA: 0x00052CEB File Offset: 0x00050EEB
		public PerformanceCounterPermission(PerformanceCounterPermissionEntry[] permissionAccessEntries)
		{
			if (permissionAccessEntries == null)
			{
				throw new ArgumentNullException("permissionAccessEntries");
			}
			this.SetUp();
			this.innerCollection = new PerformanceCounterPermissionEntryCollection(this);
			this.innerCollection.AddRange(permissionAccessEntries);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermission" /> с заданным состоянием разрешения.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06001419 RID: 5145 RVA: 0x00052D1F File Offset: 0x00050F1F
		public PerformanceCounterPermission(PermissionState state) : base(state)
		{
			this.SetUp();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermission" /> с заданными уровнями доступа, именем используемого компьютера и категорией, связанной с данным счетчиком производительности.</summary>
		/// <param name="permissionAccess">Одно из значений перечисления <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" />.</param>
		/// <param name="machineName">Сервер, на котором постоянно находятся счетчик производительности и связанная с ним категория.</param>
		/// <param name="categoryName">Имя категории счетчика производительности (объект производительности), которому соответствует счетчик производительности.</param>
		// Token: 0x0600141A RID: 5146 RVA: 0x00052D2E File Offset: 0x00050F2E
		public PerformanceCounterPermission(PerformanceCounterPermissionAccess permissionAccess, string machineName, string categoryName)
		{
			this.SetUp();
			this.innerCollection = new PerformanceCounterPermissionEntryCollection(this);
			this.innerCollection.Add(new PerformanceCounterPermissionEntry(permissionAccess, machineName, categoryName));
		}

		/// <summary>Получает коллекцию из элементов разрешений для данного запроса разрешений.</summary>
		/// <returns>Коллекция <see cref="T:System.Diagnostics.PerformanceCounterPermissionEntryCollection" />, которая содержит элементы разрешений для этого запроса разрешений.</returns>
		// Token: 0x170003BF RID: 959
		// (get) Token: 0x0600141B RID: 5147 RVA: 0x00052D5C File Offset: 0x00050F5C
		public PerformanceCounterPermissionEntryCollection PermissionEntries
		{
			get
			{
				if (this.innerCollection == null)
				{
					this.innerCollection = new PerformanceCounterPermissionEntryCollection(this);
				}
				return this.innerCollection;
			}
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00052D78 File Offset: 0x00050F78
		private void SetUp()
		{
			base.TagNames = new string[]
			{
				"Machine",
				"Category"
			};
			base.PermissionAccessType = typeof(PerformanceCounterPermissionAccess);
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x00050EC1 File Offset: 0x0004F0C1
		internal ResourcePermissionBaseEntry[] GetEntries()
		{
			return base.GetPermissionEntries();
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x00050EC9 File Offset: 0x0004F0C9
		internal void ClearEntries()
		{
			base.Clear();
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x00052DA8 File Offset: 0x00050FA8
		internal void Add(object obj)
		{
			PerformanceCounterPermissionEntry performanceCounterPermissionEntry = obj as PerformanceCounterPermissionEntry;
			base.AddPermissionAccess(performanceCounterPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00052DC8 File Offset: 0x00050FC8
		internal void Remove(object obj)
		{
			PerformanceCounterPermissionEntry performanceCounterPermissionEntry = obj as PerformanceCounterPermissionEntry;
			base.RemovePermissionAccess(performanceCounterPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x04000B23 RID: 2851
		private PerformanceCounterPermissionEntryCollection innerCollection;
	}
}
