using System;
using System.Security;
using System.Security.Permissions;

namespace System.Web
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Web.AspNetHostingPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x020001E2 RID: 482
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class AspNetHostingPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Web.AspNetHostingPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06000C98 RID: 3224 RVA: 0x00033678 File Offset: 0x00031878
		public AspNetHostingPermissionAttribute(SecurityAction action) : base(action)
		{
			this._level = AspNetHostingPermissionLevel.None;
		}

		/// <summary>Создает новое разрешение <see cref="T:System.Web.AspNetHostingPermission" /> с уровнем разрешений, предварительно указанным с помощью свойства <see cref="P:System.Web.AspNetHostingPermissionAttribute.Level" />.</summary>
		/// <returns>Новым значением <see cref="T:System.Security.IPermission" /> является <see cref="T:System.Web.AspNetHostingPermission" />.</returns>
		// Token: 0x06000C99 RID: 3225 RVA: 0x00033689 File Offset: 0x00031889
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new AspNetHostingPermission(PermissionState.Unrestricted);
			}
			return new AspNetHostingPermission(this._level);
		}

		/// <summary>Возвращает или задает текущий уровень разрешения среды.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Web.AspNetHostingPermissionLevel" />.</returns>
		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x000336A5 File Offset: 0x000318A5
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x000336AD File Offset: 0x000318AD
		public AspNetHostingPermissionLevel Level
		{
			get
			{
				return this._level;
			}
			set
			{
				if (value < AspNetHostingPermissionLevel.None || value > AspNetHostingPermissionLevel.Unrestricted)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}."), value), "Level");
				}
				this._level = value;
			}
		}

		// Token: 0x040007C2 RID: 1986
		private AspNetHostingPermissionLevel _level;
	}
}
