using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.RegistryPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000454 RID: 1108
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class RegistryPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.RegistryPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="action" /> не является допустимым <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06002CFD RID: 11517 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public RegistryPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или устанавливает полный доступ для указанных разделов реестра.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой), к которым предоставлен полный доступ.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызывается метод доступа Get; он предоставляется только для совместимости компилятора C#.</exception>
		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x0009DCFD File Offset: 0x0009BEFD
		// (set) Token: 0x06002CFF RID: 11519 RVA: 0x000A1A34 File Offset: 0x0009FC34
		[Obsolete("use newer properties")]
		public string All
		{
			get
			{
				throw new NotSupportedException("All");
			}
			set
			{
				this.create = value;
				this.read = value;
				this.write = value;
			}
		}

		/// <summary>Получает или устанавливает для указанных разделов реестра созданный уровень доступа.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой) для созданного уровня доступа.</returns>
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x06002D00 RID: 11520 RVA: 0x000A1A4B File Offset: 0x0009FC4B
		// (set) Token: 0x06002D01 RID: 11521 RVA: 0x000A1A53 File Offset: 0x0009FC53
		public string Create
		{
			get
			{
				return this.create;
			}
			set
			{
				this.create = value;
			}
		}

		/// <summary>Получает или устанавливает доступ на чтение для указанных разделов реестра.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой), к которым предоставлен доступ на чтение.</returns>
		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06002D02 RID: 11522 RVA: 0x000A1A5C File Offset: 0x0009FC5C
		// (set) Token: 0x06002D03 RID: 11523 RVA: 0x000A1A64 File Offset: 0x0009FC64
		public string Read
		{
			get
			{
				return this.read;
			}
			set
			{
				this.read = value;
			}
		}

		/// <summary>Получает или устанавливает доступ на запись для указанных разделов реестра.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой), к которым предоставлен доступ на запись.</returns>
		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000A1A6D File Offset: 0x0009FC6D
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000A1A75 File Offset: 0x0009FC75
		public string Write
		{
			get
			{
				return this.write;
			}
			set
			{
				this.write = value;
			}
		}

		/// <summary>Получает или устанавливает для указанных разделов реестра управление доступом к изменениям.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой) для управления доступом к изменениям. .</returns>
		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000A1A7E File Offset: 0x0009FC7E
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000A1A86 File Offset: 0x0009FC86
		public string ChangeAccessControl
		{
			get
			{
				return this.changeAccessControl;
			}
			set
			{
				this.changeAccessControl = value;
			}
		}

		/// <summary>Получает или устанавливает для указанных разделов реестра управление доступом к просмотру.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой) для управления доступом к просмотру.</returns>
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x000A1A8F File Offset: 0x0009FC8F
		// (set) Token: 0x06002D09 RID: 11529 RVA: 0x000A1A97 File Offset: 0x0009FC97
		public string ViewAccessControl
		{
			get
			{
				return this.viewAccessControl;
			}
			set
			{
				this.viewAccessControl = value;
			}
		}

		/// <summary>Получает или устанавливает указанный набор разделов реестра, который можно просматривать и изменять.</summary>
		/// <returns>Список путей к разделам реестра (разделенный точкой с запятой) для созданного уровня доступа, а также для доступа на чтение и запись.</returns>
		/// <exception cref="T:System.NotSupportedException">Вызывается метод доступа Get; он предоставляется только для совместимости компилятора C#.</exception>
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x000472C8 File Offset: 0x000454C8
		// (set) Token: 0x06002D0B RID: 11531 RVA: 0x000A1A34 File Offset: 0x0009FC34
		public string ViewAndModify
		{
			get
			{
				throw new NotSupportedException();
			}
			set
			{
				this.create = value;
				this.read = value;
				this.write = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.RegistryPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.RegistryPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002D0C RID: 11532 RVA: 0x000A1AA0 File Offset: 0x0009FCA0
		public override IPermission CreatePermission()
		{
			RegistryPermission registryPermission;
			if (base.Unrestricted)
			{
				registryPermission = new RegistryPermission(PermissionState.Unrestricted);
			}
			else
			{
				registryPermission = new RegistryPermission(PermissionState.None);
				if (this.create != null)
				{
					registryPermission.AddPathList(RegistryPermissionAccess.Create, this.create);
				}
				if (this.read != null)
				{
					registryPermission.AddPathList(RegistryPermissionAccess.Read, this.read);
				}
				if (this.write != null)
				{
					registryPermission.AddPathList(RegistryPermissionAccess.Write, this.write);
				}
			}
			return registryPermission;
		}

		// Token: 0x04002084 RID: 8324
		private string create;

		// Token: 0x04002085 RID: 8325
		private string read;

		// Token: 0x04002086 RID: 8326
		private string write;

		// Token: 0x04002087 RID: 8327
		private string changeAccessControl;

		// Token: 0x04002088 RID: 8328
		private string viewAccessControl;
	}
}
