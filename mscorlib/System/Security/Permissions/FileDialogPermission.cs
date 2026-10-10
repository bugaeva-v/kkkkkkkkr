using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Управляет возможностью доступа к файлам или папкам с помощью диалогового окна Файл. Этот класс не наследуется.</summary>
	// Token: 0x02000436 RID: 1078
	[ComVisible(true)]
	[Serializable]
	public sealed class FileDialogPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileDialogPermission" /> с указанным состоянием разрешения: ограниченным или неограниченным.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" /> (<see langword="Unrestricted" /> или <see langword="None" />).</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002BB3 RID: 11187 RVA: 0x0009DD8E File Offset: 0x0009BF8E
		public FileDialogPermission(PermissionState state)
		{
			if (CodeAccessPermission.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._access = FileDialogPermissionAccess.OpenSave;
				return;
			}
			this._access = FileDialogPermissionAccess.None;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.FileDialogPermission" /> с заданным доступом.</summary>
		/// <param name="access">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="access" /> не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" />.</exception>
		// Token: 0x06002BB4 RID: 11188 RVA: 0x0009DDAF File Offset: 0x0009BFAF
		public FileDialogPermission(FileDialogPermissionAccess access)
		{
			this.Access = access;
		}

		/// <summary>Получает или задает разрешенный доступ к файлам.</summary>
		/// <returns>Разрешенный доступ к файлам.</returns>
		/// <exception cref="T:System.ArgumentException">Попытка установить для параметра <paramref name="access" /> значение, которое не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.FileDialogPermissionAccess" />.</exception>
		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06002BB5 RID: 11189 RVA: 0x0009DDBE File Offset: 0x0009BFBE
		// (set) Token: 0x06002BB6 RID: 11190 RVA: 0x0009DDC6 File Offset: 0x0009BFC6
		public FileDialogPermissionAccess Access
		{
			get
			{
				return this._access;
			}
			set
			{
				if (!Enum.IsDefined(typeof(FileDialogPermissionAccess), value))
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "FileDialogPermissionAccess");
				}
				this._access = value;
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002BB7 RID: 11191 RVA: 0x0009DE06 File Offset: 0x0009C006
		public override IPermission Copy()
		{
			return new FileDialogPermission(this._access);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Номер версии параметра <paramref name="esd" /> не поддерживается.</exception>
		// Token: 0x06002BB8 RID: 11192 RVA: 0x0009DE14 File Offset: 0x0009C014
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(esd))
			{
				this._access = FileDialogPermissionAccess.OpenSave;
				return;
			}
			string text = esd.Attribute("Access");
			if (text == null)
			{
				this._access = FileDialogPermissionAccess.None;
				return;
			}
			this._access = (FileDialogPermissionAccess)Enum.Parse(typeof(FileDialogPermissionAccess), text);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BB9 RID: 11193 RVA: 0x0009DE74 File Offset: 0x0009C074
		public override IPermission Intersect(IPermission target)
		{
			FileDialogPermission fileDialogPermission = this.Cast(target);
			if (fileDialogPermission == null)
			{
				return null;
			}
			FileDialogPermissionAccess fileDialogPermissionAccess = this._access & fileDialogPermission._access;
			if (fileDialogPermissionAccess != FileDialogPermissionAccess.None)
			{
				return new FileDialogPermission(fileDialogPermissionAccess);
			}
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BBA RID: 11194 RVA: 0x0009DEA8 File Offset: 0x0009C0A8
		public override bool IsSubsetOf(IPermission target)
		{
			FileDialogPermission fileDialogPermission = this.Cast(target);
			return fileDialogPermission != null && (this._access & fileDialogPermission._access) == this._access;
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002BBB RID: 11195 RVA: 0x0009DED7 File Offset: 0x0009C0D7
		public bool IsUnrestricted()
		{
			return this._access == FileDialogPermissionAccess.OpenSave;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая сведения о состоянии.</returns>
		// Token: 0x06002BBC RID: 11196 RVA: 0x0009DEE4 File Offset: 0x0009C0E4
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			switch (this._access)
			{
			case FileDialogPermissionAccess.Open:
				securityElement.AddAttribute("Access", "Open");
				break;
			case FileDialogPermissionAccess.Save:
				securityElement.AddAttribute("Access", "Save");
				break;
			case FileDialogPermissionAccess.OpenSave:
				securityElement.AddAttribute("Unrestricted", "true");
				break;
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002BBD RID: 11197 RVA: 0x0009DF4C File Offset: 0x0009C14C
		public override IPermission Union(IPermission target)
		{
			FileDialogPermission fileDialogPermission = this.Cast(target);
			if (fileDialogPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || fileDialogPermission.IsUnrestricted())
			{
				return new FileDialogPermission(PermissionState.Unrestricted);
			}
			return new FileDialogPermission(this._access | fileDialogPermission._access);
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000040F7 File Offset: 0x000022F7
		int IBuiltInPermission.GetTokenIndex()
		{
			return 1;
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x0009DF94 File Offset: 0x0009C194
		private FileDialogPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			FileDialogPermission fileDialogPermission = target as FileDialogPermission;
			if (fileDialogPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(FileDialogPermission));
			}
			return fileDialogPermission;
		}

		// Token: 0x0400200F RID: 8207
		private const int version = 1;

		// Token: 0x04002010 RID: 8208
		private FileDialogPermissionAccess _access;
	}
}
