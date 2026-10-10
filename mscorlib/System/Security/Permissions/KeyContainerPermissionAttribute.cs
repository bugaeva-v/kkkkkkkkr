using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.KeyContainerPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000449 RID: 1097
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class KeyContainerPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Выполняет инициализацию нового экземпляра класса <see cref="T:System.Security.Permissions.KeyContainerPermissionAttribute" /> с заданным действием по обеспечению безопасности.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002C7E RID: 11390 RVA: 0x0009FC16 File Offset: 0x0009DE16
		public KeyContainerPermissionAttribute(SecurityAction action) : base(action)
		{
			this._spec = -1;
			this._type = -1;
		}

		/// <summary>Получает или задает разрешения контейнера ключа.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />. Значение по умолчанию — <see cref="F:System.Security.Permissions.KeyContainerPermissionFlags.NoFlags" />.</returns>
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002C7F RID: 11391 RVA: 0x0009FC2D File Offset: 0x0009DE2D
		// (set) Token: 0x06002C80 RID: 11392 RVA: 0x0009FC35 File Offset: 0x0009DE35
		public KeyContainerPermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}

		/// <summary>Получает или задает имя контейнера ключа.</summary>
		/// <returns>Имя контейнера ключа.</returns>
		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002C81 RID: 11393 RVA: 0x0009FC3E File Offset: 0x0009DE3E
		// (set) Token: 0x06002C82 RID: 11394 RVA: 0x0009FC46 File Offset: 0x0009DE46
		public string KeyContainerName
		{
			get
			{
				return this._containerName;
			}
			set
			{
				this._containerName = value;
			}
		}

		/// <summary>Получает или задает спецификацию ключа.</summary>
		/// <returns>Одно из значений AT_, определенное в файле заголовка Wincrypt.h.</returns>
		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x0009FC4F File Offset: 0x0009DE4F
		// (set) Token: 0x06002C84 RID: 11396 RVA: 0x0009FC57 File Offset: 0x0009DE57
		public int KeySpec
		{
			get
			{
				return this._spec;
			}
			set
			{
				this._spec = value;
			}
		}

		/// <summary>Получает или задает имя хранилища ключей.</summary>
		/// <returns>Имя хранилища ключей. По умолчанию используется "*".</returns>
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x0009FC60 File Offset: 0x0009DE60
		// (set) Token: 0x06002C86 RID: 11398 RVA: 0x0009FC68 File Offset: 0x0009DE68
		public string KeyStore
		{
			get
			{
				return this._store;
			}
			set
			{
				this._store = value;
			}
		}

		/// <summary>Получает или задает имя поставщика.</summary>
		/// <returns>Имя поставщика.</returns>
		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x0009FC71 File Offset: 0x0009DE71
		// (set) Token: 0x06002C88 RID: 11400 RVA: 0x0009FC79 File Offset: 0x0009DE79
		public string ProviderName
		{
			get
			{
				return this._providerName;
			}
			set
			{
				this._providerName = value;
			}
		}

		/// <summary>Получает или задает тип поставщика.</summary>
		/// <returns>Одно из значений PROV_, определенное в файле заголовка Wincrypt.h.</returns>
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002C89 RID: 11401 RVA: 0x0009FC82 File Offset: 0x0009DE82
		// (set) Token: 0x06002C8A RID: 11402 RVA: 0x0009FC8A File Offset: 0x0009DE8A
		public int ProviderType
		{
			get
			{
				return this._type;
			}
			set
			{
				this._type = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.KeyContainerPermission" />.</summary>
		/// <returns>
		///   <see cref="T:System.Security.Permissions.KeyContainerPermission" />, которое соответствует этому атрибуту.</returns>
		// Token: 0x06002C8B RID: 11403 RVA: 0x0009FC94 File Offset: 0x0009DE94
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new KeyContainerPermission(PermissionState.Unrestricted);
			}
			if (this.EmptyEntry())
			{
				return new KeyContainerPermission(this._flags);
			}
			KeyContainerPermissionAccessEntry[] accessList = new KeyContainerPermissionAccessEntry[]
			{
				new KeyContainerPermissionAccessEntry(this._store, this._providerName, this._type, this._containerName, this._spec, this._flags)
			};
			return new KeyContainerPermission(this._flags, accessList);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x0009FD03 File Offset: 0x0009DF03
		private bool EmptyEntry()
		{
			return this._containerName == null && this._spec == 0 && this._store == null && this._providerName == null && this._type == 0;
		}

		// Token: 0x04002055 RID: 8277
		private KeyContainerPermissionFlags _flags;

		// Token: 0x04002056 RID: 8278
		private string _containerName;

		// Token: 0x04002057 RID: 8279
		private int _spec;

		// Token: 0x04002058 RID: 8280
		private string _store;

		// Token: 0x04002059 RID: 8281
		private string _providerName;

		// Token: 0x0400205A RID: 8282
		private int _type;
	}
}
