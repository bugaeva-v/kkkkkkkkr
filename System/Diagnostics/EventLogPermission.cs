using System;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Управляет разрешениями на доступ к коду для записи событий в журнал.</summary>
	// Token: 0x02000260 RID: 608
	[Serializable]
	public sealed class EventLogPermission : ResourcePermissionBase
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogPermission" />.</summary>
		// Token: 0x06001306 RID: 4870 RVA: 0x00050E01 File Offset: 0x0004F001
		public EventLogPermission()
		{
			this.SetUp();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogPermission" /> с заданными записями разрешений.</summary>
		/// <param name="permissionAccessEntries">Массив объектов, представляющих записи разрешений. Это значение присваивается свойству <see cref="P:System.Diagnostics.EventLogPermission.PermissionEntries" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="permissionAccessEntries" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06001307 RID: 4871 RVA: 0x00050E0F File Offset: 0x0004F00F
		public EventLogPermission(EventLogPermissionEntry[] permissionAccessEntries)
		{
			if (permissionAccessEntries == null)
			{
				throw new ArgumentNullException("permissionAccessEntries");
			}
			this.SetUp();
			this.innerCollection = new EventLogPermissionEntryCollection(this);
			this.innerCollection.AddRange(permissionAccessEntries);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogPermission" /> с заданным состоянием разрешения.</summary>
		/// <param name="state">Одно из значений перечисления, задающее состояние разрешения (полный доступ или отсутствие доступа к ресурсам).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06001308 RID: 4872 RVA: 0x00050E43 File Offset: 0x0004F043
		public EventLogPermission(PermissionState state) : base(state)
		{
			this.SetUp();
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.EventLogPermission" /> с заданными уровнями доступа и именем используемого компьютера.</summary>
		/// <param name="permissionAccess">Одно из значений перечисления, указывающее уровень доступа.</param>
		/// <param name="machineName">Имя компьютера, на котором производится чтение и запись событий.</param>
		// Token: 0x06001309 RID: 4873 RVA: 0x00050E52 File Offset: 0x0004F052
		public EventLogPermission(EventLogPermissionAccess permissionAccess, string machineName)
		{
			this.SetUp();
			this.innerCollection = new EventLogPermissionEntryCollection(this);
			this.innerCollection.Add(new EventLogPermissionEntry(permissionAccess, machineName));
		}

		/// <summary>Получает коллекцию из элементов разрешений для данного запроса разрешений.</summary>
		/// <returns>Коллекция, содержащая записи разрешений для данного запроса разрешений.</returns>
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00050E7F File Offset: 0x0004F07F
		public EventLogPermissionEntryCollection PermissionEntries
		{
			get
			{
				if (this.innerCollection == null)
				{
					this.innerCollection = new EventLogPermissionEntryCollection(this);
				}
				return this.innerCollection;
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00050E9B File Offset: 0x0004F09B
		private void SetUp()
		{
			base.TagNames = new string[]
			{
				"Machine"
			};
			base.PermissionAccessType = typeof(EventLogPermissionAccess);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00050EC1 File Offset: 0x0004F0C1
		internal ResourcePermissionBaseEntry[] GetEntries()
		{
			return base.GetPermissionEntries();
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00050EC9 File Offset: 0x0004F0C9
		internal void ClearEntries()
		{
			base.Clear();
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00050ED4 File Offset: 0x0004F0D4
		internal void Add(object obj)
		{
			EventLogPermissionEntry eventLogPermissionEntry = obj as EventLogPermissionEntry;
			base.AddPermissionAccess(eventLogPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00050EF4 File Offset: 0x0004F0F4
		internal void Remove(object obj)
		{
			EventLogPermissionEntry eventLogPermissionEntry = obj as EventLogPermissionEntry;
			base.RemovePermissionAccess(eventLogPermissionEntry.CreateResourcePermissionBaseEntry());
		}

		// Token: 0x04000ACF RID: 2767
		private EventLogPermissionEntryCollection innerCollection;
	}
}
