using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200045E RID: 1118
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class StrongNameIdentityPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StrongNameIdentityPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002D73 RID: 11635 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public StrongNameIdentityPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает имя идентификатора строгого имени.</summary>
		/// <returns>Имя, которое необходимо сравнить с именем, указанным поставщиком безопасности.</returns>
		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000A2FC4 File Offset: 0x000A11C4
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x000A2FCC File Offset: 0x000A11CC
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		/// <summary>Получает или задает значение открытого ключа идентификатора строгого имени, выраженного в виде шестнадцатеричной строки.</summary>
		/// <returns>Значение открытого ключа идентификатора строгого имени, выраженное в виде шестнадцатеричной строки.</returns>
		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000A2FD5 File Offset: 0x000A11D5
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x000A2FDD File Offset: 0x000A11DD
		public string PublicKey
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		/// <summary>Получает или задает версию идентификатора строгого имени.</summary>
		/// <returns>Номер версии идентификатора строгого имени.</returns>
		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000A2FE6 File Offset: 0x000A11E6
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x000A2FEE File Offset: 0x000A11EE
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.StrongNameIdentityPermission" />, соответствующий этому атрибуту.</returns>
		/// <exception cref="T:System.ArgumentException">Этот метод не выполнен, поскольку значение ключа - <see langword="null" />.</exception>
		// Token: 0x06002D7A RID: 11642 RVA: 0x000A2FF8 File Offset: 0x000A11F8
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new StrongNameIdentityPermission(PermissionState.Unrestricted);
			}
			if (this.name == null && this.key == null && this.version == null)
			{
				return new StrongNameIdentityPermission(PermissionState.None);
			}
			if (this.key == null)
			{
				throw new ArgumentException(Locale.GetText("PublicKey is required"));
			}
			StrongNamePublicKeyBlob blob = StrongNamePublicKeyBlob.FromString(this.key);
			Version version = null;
			if (this.version != null)
			{
				version = new Version(this.version);
			}
			return new StrongNameIdentityPermission(blob, this.name, version);
		}

		// Token: 0x040020B4 RID: 8372
		private string name;

		// Token: 0x040020B5 RID: 8373
		private string key;

		// Token: 0x040020B6 RID: 8374
		private string version;
	}
}
