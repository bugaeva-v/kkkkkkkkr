using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Разрешает применять меры безопасности для <see cref="T:System.Security.Permissions.FileDialogPermission" /> к коду с помощью декларативной безопасности. Этот класс не наследуется.</summary>
	// Token: 0x02000437 RID: 1079
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[ComVisible(true)]
	[Serializable]
	public sealed class FileDialogPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileDialogPermissionAttribute" /> указанным значением <see cref="T:System.Security.Permissions.SecurityAction" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />.</param>
		// Token: 0x06002BC0 RID: 11200 RVA: 0x0009DCF4 File Offset: 0x0009BEF4
		public FileDialogPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Получает или задает значение, определяющее, объявлено ли разрешение на открытие файлов с помощью диалогового окна "Файл".</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на открытие файлов с помощью диалогового окна "Файл" объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06002BC1 RID: 11201 RVA: 0x0009DFB4 File Offset: 0x0009C1B4
		// (set) Token: 0x06002BC2 RID: 11202 RVA: 0x0009DFBC File Offset: 0x0009C1BC
		public bool Open
		{
			get
			{
				return this.canOpen;
			}
			set
			{
				this.canOpen = value;
			}
		}

		/// <summary>Получает или задает значение, определяющее, объявлено ли разрешение на сохранение файлов с помощью диалогового окна "Файл".</summary>
		/// <returns>Значение <see langword="true" />, если разрешение на сохранение файлов с помощью диалогового окна "Файл" объявлено; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x0009DFC5 File Offset: 0x0009C1C5
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x0009DFCD File Offset: 0x0009C1CD
		public bool Save
		{
			get
			{
				return this.canSave;
			}
			set
			{
				this.canSave = value;
			}
		}

		/// <summary>Создает и возвращает новый объект <see cref="T:System.Security.Permissions.FileDialogPermission" />.</summary>
		/// <returns>Объект <see cref="T:System.Security.Permissions.FileDialogPermission" />, соответствующий этому атрибуту.</returns>
		// Token: 0x06002BC5 RID: 11205 RVA: 0x0009DFD8 File Offset: 0x0009C1D8
		public override IPermission CreatePermission()
		{
			FileDialogPermission result;
			if (base.Unrestricted)
			{
				result = new FileDialogPermission(PermissionState.Unrestricted);
			}
			else
			{
				FileDialogPermissionAccess fileDialogPermissionAccess = FileDialogPermissionAccess.None;
				if (this.canOpen)
				{
					fileDialogPermissionAccess |= FileDialogPermissionAccess.Open;
				}
				if (this.canSave)
				{
					fileDialogPermissionAccess |= FileDialogPermissionAccess.Save;
				}
				result = new FileDialogPermission(fileDialogPermissionAccess);
			}
			return result;
		}

		// Token: 0x04002011 RID: 8209
		private bool canOpen;

		// Token: 0x04002012 RID: 8210
		private bool canSave;
	}
}
