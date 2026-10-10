using System;
using System.Security;
using System.Security.Permissions;

namespace System.Diagnostics
{
	/// <summary>Позволяет проводить декларативные проверки разрешения счетчика производительности.</summary>
	// Token: 0x02000278 RID: 632
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Event, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public class PerformanceCounterPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Diagnostics.PerformanceCounterPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06001421 RID: 5153 RVA: 0x00052DE8 File Offset: 0x00050FE8
		public PerformanceCounterPermissionAttribute(SecurityAction action) : base(action)
		{
			this.categoryName = "*";
			this.machineName = ".";
			this.permissionAccess = PerformanceCounterPermissionAccess.Write;
		}

		/// <summary>Получает или задает имя категории счетчика производительности.</summary>
		/// <returns>Имя категории счетчика производительности (объект производительности).</returns>
		/// <exception cref="T:System.ArgumentNullException">Значение — <see langword="null" />.</exception>
		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001422 RID: 5154 RVA: 0x00052E0E File Offset: 0x0005100E
		// (set) Token: 0x06001423 RID: 5155 RVA: 0x00052E16 File Offset: 0x00051016
		public string CategoryName
		{
			get
			{
				return this.categoryName;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("CategoryName");
				}
				this.categoryName = value;
			}
		}

		/// <summary>Получает или задает имя компьютера для данного счетчика производительности.</summary>
		/// <returns>Сервер, на котором постоянно размещается категория счетчика производительности.</returns>
		/// <exception cref="T:System.ArgumentException">Недопустимый формат <see cref="P:System.Diagnostics.PerformanceCounterPermissionAttribute.MachineName" />.</exception>
		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001424 RID: 5156 RVA: 0x00052E2D File Offset: 0x0005102D
		// (set) Token: 0x06001425 RID: 5157 RVA: 0x00052E35 File Offset: 0x00051035
		public string MachineName
		{
			get
			{
				return this.machineName;
			}
			set
			{
				ResourcePermissionBase.ValidateMachineName(value);
				this.machineName = value;
			}
		}

		/// <summary>Получает или задает уровни доступа, используемые в запросе разрешений.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Diagnostics.PerformanceCounterPermissionAccess" />. Значение по умолчанию — <see cref="F:System.Diagnostics.EventLogPermissionAccess.Write" />.</returns>
		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x00052E44 File Offset: 0x00051044
		// (set) Token: 0x06001427 RID: 5159 RVA: 0x00052E4C File Offset: 0x0005104C
		public PerformanceCounterPermissionAccess PermissionAccess
		{
			get
			{
				return this.permissionAccess;
			}
			set
			{
				this.permissionAccess = value;
			}
		}

		/// <summary>Создает разрешение на атрибут, где разрешения основаны на запрашиваемом уровне доступа, заданном через свойство <see cref="P:System.Diagnostics.PerformanceCounterPermissionAttribute.PermissionAccess" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.IPermission" />, представляющий созданное разрешение.</returns>
		// Token: 0x06001428 RID: 5160 RVA: 0x00052E55 File Offset: 0x00051055
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new PerformanceCounterPermission(PermissionState.Unrestricted);
			}
			return new PerformanceCounterPermission(this.permissionAccess, this.machineName, this.categoryName);
		}

		// Token: 0x04000B2B RID: 2859
		private string categoryName;

		// Token: 0x04000B2C RID: 2860
		private string machineName;

		// Token: 0x04000B2D RID: 2861
		private PerformanceCounterPermissionAccess permissionAccess;
	}
}
