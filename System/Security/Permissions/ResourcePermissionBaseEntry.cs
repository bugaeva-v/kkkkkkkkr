using System;

namespace System.Security.Permissions
{
	/// <summary>Определяет наименьший элемент набора разрешений управления доступом для кода.</summary>
	// Token: 0x02000297 RID: 663
	[Serializable]
	public class ResourcePermissionBaseEntry
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" />.</summary>
		// Token: 0x060014F6 RID: 5366 RVA: 0x000552AB File Offset: 0x000534AB
		public ResourcePermissionBaseEntry()
		{
			this.permissionAccessPath = new string[0];
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ResourcePermissionBaseEntry" /> с указанным разрешением на доступ и путем разрешения на доступ.</summary>
		/// <param name="permissionAccess">Целочисленное представление значения перечисления уровня доступа к разрешениям. Это значение присваивается свойству <see cref="P:System.Security.Permissions.ResourcePermissionBaseEntry.PermissionAccess" />.</param>
		/// <param name="permissionAccessPath">Массив строк, обозначающих защищаемый ресурс. Это значение присваивается свойству <see cref="P:System.Security.Permissions.ResourcePermissionBaseEntry.PermissionAccessPath" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Заданный объект <paramref name="permissionAccessPath" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060014F7 RID: 5367 RVA: 0x000552BF File Offset: 0x000534BF
		public ResourcePermissionBaseEntry(int permissionAccess, string[] permissionAccessPath)
		{
			if (permissionAccessPath == null)
			{
				throw new ArgumentNullException("permissionAccessPath");
			}
			this.permissionAccess = permissionAccess;
			this.permissionAccessPath = permissionAccessPath;
		}

		/// <summary>Получает целочисленное представление значения перечисления уровня доступа.</summary>
		/// <returns>Значение перечисления уровня доступа.</returns>
		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000552E3 File Offset: 0x000534E3
		public int PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
		}

		/// <summary>Получает массив строк, обозначающих защищаемый ресурс.</summary>
		/// <returns>Массив строк, обозначающих защищаемый ресурс.</returns>
		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x000552EB File Offset: 0x000534EB
		public string[] PermissionAccessPath
		{
			get
			{
				return this.permissionAccessPath;
			}
		}

		// Token: 0x04000BC1 RID: 3009
		private int permissionAccess;

		// Token: 0x04000BC2 RID: 3010
		private string[] permissionAccessPath;
	}
}
