using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.PrincipalPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x0200044E RID: 1102
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class PrincipalPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.PrincipalPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002CB2 RID: 11442 RVA: 0x000A08F1 File Offset: 0x0009EAF1
		public PrincipalPermissionAttribute(SecurityAction action) : base(action)
		{
			this.authenticated = true;
		}

		/// <summary>Возвращает или задает значение, указывающее, прошел ли текущий субъект проверку подлинности от основного поставщика безопасности на основе ролей.</summary>
		/// <returns>Значение <see langword="true" />, если текущий субъект прошел проверку подлинности; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x000A0901 File Offset: 0x0009EB01
		// (set) Token: 0x06002CB4 RID: 11444 RVA: 0x000A0909 File Offset: 0x0009EB09
		public bool Authenticated
		{
			get
			{
				return this.authenticated;
			}
			set
			{
				this.authenticated = value;
			}
		}

		/// <summary>Получает или задает имя удостоверения, связанного с текущим субъектом.</summary>
		/// <returns>Имя для сопоставления с именем, предоставляемым базовым поставщиком безопасности на основе ролей.</returns>
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000A0912 File Offset: 0x0009EB12
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x000A091A File Offset: 0x0009EB1A
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

		/// <summary>Возвращает или задает членство в указанной роли безопасности.</summary>
		/// <returns>Имя роли, предоставленное основным поставщиком безопасности на основе ролей.</returns>
		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002CB7 RID: 11447 RVA: 0x000A0923 File Offset: 0x0009EB23
		// (set) Token: 0x06002CB8 RID: 11448 RVA: 0x000A092B File Offset: 0x0009EB2B
		public string Role
		{
			get
			{
				return this.role;
			}
			set
			{
				this.role = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.PrincipalPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.PrincipalPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002CB9 RID: 11449 RVA: 0x000A0934 File Offset: 0x0009EB34
		public override IPermission CreatePermission()
		{
			PrincipalPermission result;
			if (base.Unrestricted)
			{
				result = new PrincipalPermission(PermissionState.Unrestricted);
			}
			else
			{
				result = new PrincipalPermission(this.name, this.role, this.authenticated);
			}
			return result;
		}

		// Token: 0x04002071 RID: 8305
		private bool authenticated;

		// Token: 0x04002072 RID: 8306
		private string name;

		// Token: 0x04002073 RID: 8307
		private string role;
	}
}
