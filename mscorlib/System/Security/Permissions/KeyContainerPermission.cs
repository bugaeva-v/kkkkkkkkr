using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Управляет возможностью доступа к контейнерам ключей. Этот класс не наследуется.</summary>
	// Token: 0x02000445 RID: 1093
	[ComVisible(true)]
	[Serializable]
	public sealed class KeyContainerPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermission" /> состоянием разрешения: ограниченным или неограниченным.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым значением <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002C4A RID: 11338 RVA: 0x0009F5F2 File Offset: 0x0009D7F2
		public KeyContainerPermission(PermissionState state)
		{
			if (CodeAccessPermission.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._flags = KeyContainerPermissionFlags.AllFlags;
			}
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermission" /> с заданным доступом.</summary>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="flags" /> не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</exception>
		// Token: 0x06002C4B RID: 11339 RVA: 0x0009F60F File Offset: 0x0009D80F
		public KeyContainerPermission(KeyContainerPermissionFlags flags)
		{
			this.SetFlags(flags);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.KeyContainerPermission" /> с указанным глобальным доступом и правами доступа к конкретному контейнеру ключа.</summary>
		/// <param name="flags">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</param>
		/// <param name="accessList">Массив объектов <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, определяющих права доступа к конкретному контейнеру ключа.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="flags" /> не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="accessList" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06002C4C RID: 11340 RVA: 0x0009F620 File Offset: 0x0009D820
		public KeyContainerPermission(KeyContainerPermissionFlags flags, KeyContainerPermissionAccessEntry[] accessList)
		{
			this.SetFlags(flags);
			if (accessList != null)
			{
				this._accessEntries = new KeyContainerPermissionAccessEntryCollection();
				foreach (KeyContainerPermissionAccessEntry accessEntry in accessList)
				{
					this._accessEntries.Add(accessEntry);
				}
			}
		}

		/// <summary>Возвращает коллекцию объектов <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" />, связанных с текущим разрешением.</summary>
		/// <returns>Коллекция <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntryCollection" />, содержащая объекты <see cref="T:System.Security.Permissions.KeyContainerPermissionAccessEntry" /> для этого <see cref="T:System.Security.Permissions.KeyContainerPermission" />.</returns>
		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002C4D RID: 11341 RVA: 0x0009F669 File Offset: 0x0009D869
		public KeyContainerPermissionAccessEntryCollection AccessEntries
		{
			get
			{
				return this._accessEntries;
			}
		}

		/// <summary>Возвращает флаги разрешения контейнера ключей, применимые для всех контейнеров ключей, связанных с разрешением.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.KeyContainerPermissionFlags" />.</returns>
		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002C4E RID: 11342 RVA: 0x0009F671 File Offset: 0x0009D871
		public KeyContainerPermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002C4F RID: 11343 RVA: 0x0009F67C File Offset: 0x0009D87C
		public override IPermission Copy()
		{
			if (this._accessEntries.Count == 0)
			{
				return new KeyContainerPermission(this._flags);
			}
			KeyContainerPermissionAccessEntry[] array = new KeyContainerPermissionAccessEntry[this._accessEntries.Count];
			this._accessEntries.CopyTo(array, 0);
			return new KeyContainerPermission(this._flags, array);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML, используемую для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Номер версии <paramref name="securityElement" /> не поддерживается.</exception>
		// Token: 0x06002C50 RID: 11344 RVA: 0x0009F6CC File Offset: 0x0009D8CC
		[MonoTODO("(2.0) missing support for AccessEntries")]
		public override void FromXml(SecurityElement securityElement)
		{
			CodeAccessPermission.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(securityElement))
			{
				this._flags = KeyContainerPermissionFlags.AllFlags;
				return;
			}
			this._flags = (KeyContainerPermissionFlags)Enum.Parse(typeof(KeyContainerPermissionFlags), securityElement.Attribute("Flags"));
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06002C51 RID: 11345 RVA: 0x0000AF5E File Offset: 0x0000915E
		[MonoTODO("(2.0)")]
		public override IPermission Intersect(IPermission target)
		{
			return null;
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение на проверку наличия связи подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06002C52 RID: 11346 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		[MonoTODO("(2.0)")]
		public override bool IsSubsetOf(IPermission target)
		{
			return false;
		}

		/// <summary>Определяет, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002C53 RID: 11347 RVA: 0x0009F720 File Offset: 0x0009D920
		public bool IsUnrestricted()
		{
			return this._flags == KeyContainerPermissionFlags.AllFlags;
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML разрешения, включая сведения о состоянии.</returns>
		// Token: 0x06002C54 RID: 11348 RVA: 0x0009F730 File Offset: 0x0009D930
		[MonoTODO("(2.0) missing support for AccessEntries")]
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			return securityElement;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="target" /> не имеет значение <see langword="null" /> и не указывает разрешение того же типа, что и текущее разрешение.</exception>
		// Token: 0x06002C55 RID: 11349 RVA: 0x0009F760 File Offset: 0x0009D960
		public override IPermission Union(IPermission target)
		{
			KeyContainerPermission keyContainerPermission = this.Cast(target);
			if (keyContainerPermission == null)
			{
				return this.Copy();
			}
			KeyContainerPermissionAccessEntryCollection keyContainerPermissionAccessEntryCollection = new KeyContainerPermissionAccessEntryCollection();
			foreach (KeyContainerPermissionAccessEntry accessEntry in this._accessEntries)
			{
				keyContainerPermissionAccessEntryCollection.Add(accessEntry);
			}
			foreach (KeyContainerPermissionAccessEntry accessEntry2 in keyContainerPermission._accessEntries)
			{
				if (this._accessEntries.IndexOf(accessEntry2) == -1)
				{
					keyContainerPermissionAccessEntryCollection.Add(accessEntry2);
				}
			}
			if (keyContainerPermissionAccessEntryCollection.Count == 0)
			{
				return new KeyContainerPermission(this._flags | keyContainerPermission._flags);
			}
			KeyContainerPermissionAccessEntry[] array = new KeyContainerPermissionAccessEntry[keyContainerPermissionAccessEntryCollection.Count];
			keyContainerPermissionAccessEntryCollection.CopyTo(array, 0);
			return new KeyContainerPermission(this._flags | keyContainerPermission._flags, array);
		}

		// Token: 0x06002C56 RID: 11350 RVA: 0x00026EE1 File Offset: 0x000250E1
		int IBuiltInPermission.GetTokenIndex()
		{
			return 16;
		}

		// Token: 0x06002C57 RID: 11351 RVA: 0x0009F825 File Offset: 0x0009DA25
		private void SetFlags(KeyContainerPermissionFlags flags)
		{
			if ((flags & KeyContainerPermissionFlags.AllFlags) == KeyContainerPermissionFlags.NoFlags)
			{
				throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), flags), "KeyContainerPermissionFlags");
			}
			this._flags = flags;
		}

		// Token: 0x06002C58 RID: 11352 RVA: 0x0009F857 File Offset: 0x0009DA57
		private KeyContainerPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			KeyContainerPermission keyContainerPermission = target as KeyContainerPermission;
			if (keyContainerPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(KeyContainerPermission));
			}
			return keyContainerPermission;
		}

		// Token: 0x0400204A RID: 8266
		private KeyContainerPermissionAccessEntryCollection _accessEntries;

		// Token: 0x0400204B RID: 8267
		private KeyContainerPermissionFlags _flags;

		// Token: 0x0400204C RID: 8268
		private const int version = 1;
	}
}
