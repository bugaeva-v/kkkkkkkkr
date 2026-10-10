using System;

namespace System.Security.Permissions
{
	/// <summary>Управляет возможностью доступа к зашифрованным данным и памяти. Этот класс не наследуется.</summary>
	// Token: 0x02000009 RID: 9
	[Serializable]
	public sealed class DataProtectionPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.DataProtectionPermission" /> с заданным состоянием разрешения.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым значением <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x0600000B RID: 11 RVA: 0x0000215D File Offset: 0x0000035D
		public DataProtectionPermission(PermissionState state)
		{
			if (PermissionHelper.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._flags = DataProtectionPermissionFlags.AllFlags;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.DataProtectionPermission" /> с заданными флагами разрешения.</summary>
		/// <param name="flag">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.DataProtectionPermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="flag" /> не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.DataProtectionPermissionFlags" />.</exception>
		// Token: 0x0600000C RID: 12 RVA: 0x00002177 File Offset: 0x00000377
		public DataProtectionPermission(DataProtectionPermissionFlags flag)
		{
			this.Flags = flag;
		}

		/// <summary>Получает или задает флаги для защиты данных и памяти.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.DataProtectionPermissionFlags" />.</returns>
		/// <exception cref="T:System.ArgumentException">Указанное значение не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.DataProtectionPermissionFlags" />.</exception>
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000218E File Offset: 0x0000038E
		public DataProtectionPermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				if ((value & ~(DataProtectionPermissionFlags.ProtectData | DataProtectionPermissionFlags.UnprotectData | DataProtectionPermissionFlags.ProtectMemory | DataProtectionPermissionFlags.UnprotectMemory)) != DataProtectionPermissionFlags.NoFlags)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "DataProtectionPermissionFlags");
				}
				this._flags = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600000F RID: 15 RVA: 0x000021BD File Offset: 0x000003BD
		public bool IsUnrestricted()
		{
			return this._flags == DataProtectionPermissionFlags.AllFlags;
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06000010 RID: 16 RVA: 0x000021C9 File Offset: 0x000003C9
		public override IPermission Copy()
		{
			return new DataProtectionPermission(this._flags);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06000011 RID: 17 RVA: 0x000021D8 File Offset: 0x000003D8
		public override IPermission Intersect(IPermission target)
		{
			DataProtectionPermission dataProtectionPermission = this.Cast(target);
			if (dataProtectionPermission == null)
			{
				return null;
			}
			if (this.IsUnrestricted() && dataProtectionPermission.IsUnrestricted())
			{
				return new DataProtectionPermission(PermissionState.Unrestricted);
			}
			if (this.IsUnrestricted())
			{
				return dataProtectionPermission.Copy();
			}
			if (dataProtectionPermission.IsUnrestricted())
			{
				return this.Copy();
			}
			return new DataProtectionPermission(this._flags & dataProtectionPermission._flags);
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06000012 RID: 18 RVA: 0x0000223C File Offset: 0x0000043C
		public override IPermission Union(IPermission target)
		{
			DataProtectionPermission dataProtectionPermission = this.Cast(target);
			if (dataProtectionPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || dataProtectionPermission.IsUnrestricted())
			{
				return new SecurityPermission(PermissionState.Unrestricted);
			}
			return new DataProtectionPermission(this._flags | dataProtectionPermission._flags);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение на проверку наличия связи подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06000013 RID: 19 RVA: 0x00002284 File Offset: 0x00000484
		public override bool IsSubsetOf(IPermission target)
		{
			DataProtectionPermission dataProtectionPermission = this.Cast(target);
			if (dataProtectionPermission == null)
			{
				return this._flags == DataProtectionPermissionFlags.NoFlags;
			}
			return dataProtectionPermission.IsUnrestricted() || (!this.IsUnrestricted() && (this._flags & ~dataProtectionPermission._flags) == DataProtectionPermissionFlags.NoFlags);
		}

		/// <summary>Восстанавливает разрешение с определенным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML, используемую для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Номер версии <paramref name="securityElement" /> не поддерживается.</exception>
		// Token: 0x06000014 RID: 20 RVA: 0x000022CB File Offset: 0x000004CB
		public override void FromXml(SecurityElement securityElement)
		{
			PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			this._flags = (DataProtectionPermissionFlags)Enum.Parse(typeof(DataProtectionPermissionFlags), securityElement.Attribute("Flags"));
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая сведения о состоянии.</returns>
		// Token: 0x06000015 RID: 21 RVA: 0x00002300 File Offset: 0x00000500
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(typeof(DataProtectionPermission), 1);
			securityElement.AddAttribute("Flags", this._flags.ToString());
			return securityElement;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000232E File Offset: 0x0000052E
		private DataProtectionPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			DataProtectionPermission dataProtectionPermission = target as DataProtectionPermission;
			if (dataProtectionPermission == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(DataProtectionPermission));
			}
			return dataProtectionPermission;
		}

		// Token: 0x04000076 RID: 118
		private const int version = 1;

		// Token: 0x04000077 RID: 119
		private DataProtectionPermissionFlags _flags;
	}
}
