using System;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices
{
	/// <summary>Настраивает роль для приложения или компонента. Этот класс не наследуется.</summary>
	// Token: 0x02000045 RID: 69
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Interface, AllowMultiple = true)]
	[ComVisible(false)]
	public sealed class SecurityRoleAttribute : Attribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.SecurityRoleAttribute" /> и задает значение свойства <see cref="P:System.EnterpriseServices.SecurityRoleAttribute.Role" />.</summary>
		/// <param name="role">Роль безопасности для приложения, компонента, интерфейса или метода.</param>
		// Token: 0x060000F9 RID: 249 RVA: 0x0000254F File Offset: 0x0000074F
		public SecurityRoleAttribute(string role) : this(role, false)
		{
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.EnterpriseServices.SecurityRoleAttribute" /> и задает значения свойств <see cref="P:System.EnterpriseServices.SecurityRoleAttribute.Role" /> и <see cref="P:System.EnterpriseServices.SecurityRoleAttribute.SetEveryoneAccess" />.</summary>
		/// <param name="role">Роль безопасности для приложения, компонента, интерфейса или метода.</param>
		/// <param name="everyone">Значение <see langword="true" />, чтобы потребовать добавления в качестве пользователя во вновь созданную роль группы пользователей "Все"; в противном случае — значение <see langword="false" />.</param>
		// Token: 0x060000FA RID: 250 RVA: 0x00002559 File Offset: 0x00000759
		public SecurityRoleAttribute(string role, bool everyone)
		{
			this.description = string.Empty;
			this.everyone = everyone;
			this.role = role;
		}

		/// <summary>Получает или задает описание роли.</summary>
		/// <returns>Описание роли.</returns>
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000257A File Offset: 0x0000077A
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002582 File Offset: 0x00000782
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				this.description = value;
			}
		}

		/// <summary>Получает или задает роль безопасности.</summary>
		/// <returns>Роль безопасности, примененная к приложению, компоненту, интерфейсу или методу.</returns>
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000FD RID: 253 RVA: 0x0000258B File Offset: 0x0000078B
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002593 File Offset: 0x00000793
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

		/// <summary>Задает значение, показывающее, следует ли добавлять группу пользователей "Все" в качестве пользователя.</summary>
		/// <returns>Значение <see langword="true" />, чтобы потребовать добавления во вновь созданную роль группы пользователей "Все" в качестве пользователя (роли, уже существующие в приложении, не изменяются). В противном случае, значение <see langword="false" />, чтобы запретить добавление группы пользователей "Все" в качестве пользователя.</returns>
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000FF RID: 255 RVA: 0x0000259C File Offset: 0x0000079C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x000025A4 File Offset: 0x000007A4
		public bool SetEveryoneAccess
		{
			get
			{
				return this.everyone;
			}
			set
			{
				this.everyone = value;
			}
		}

		// Token: 0x04000083 RID: 131
		private string description;

		// Token: 0x04000084 RID: 132
		private bool everyone;

		// Token: 0x04000085 RID: 133
		private string role;
	}
}
