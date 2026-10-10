using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.UIPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000461 RID: 1121
	[ComVisible(true)]
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class UIPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.UIPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений перечисления <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002D93 RID: 11667 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public UIPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает разрешенный тип доступа к буферу обмена.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.UIPermissionClipboard" />.</returns>
		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000A358F File Offset: 0x000A178F
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x000A3597 File Offset: 0x000A1797
		public UIPermissionClipboard Clipboard
		{
			get
			{
				return this.clipboard;
			}
			set
			{
				this.clipboard = value;
			}
		}

		/// <summary>Получает или задает разрешенный тип доступа к ресурсам окна.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.Permissions.UIPermissionWindow" />.</returns>
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000A35A0 File Offset: 0x000A17A0
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x000A35A8 File Offset: 0x000A17A8
		public UIPermissionWindow Window
		{
			get
			{
				return this.window;
			}
			set
			{
				this.window = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.UIPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.UIPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002D98 RID: 11672 RVA: 0x000A35B4 File Offset: 0x000A17B4
		public override IPermission CreatePermission()
		{
			UIPermission result;
			if (base.Unrestricted)
			{
				result = new UIPermission(PermissionState.Unrestricted);
			}
			else
			{
				result = new UIPermission(this.window, this.clipboard);
			}
			return result;
		}

		// Token: 0x040020BB RID: 8379
		private UIPermissionClipboard clipboard;

		// Token: 0x040020BC RID: 8380
		private UIPermissionWindow window;
	}
}
