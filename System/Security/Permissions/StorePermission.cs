using System;

namespace System.Security.Permissions
{
	/// <summary>Управляет доступом к хранилищам, содержащим сертификаты X.509. Этот класс не наследуется.</summary>
	// Token: 0x02000298 RID: 664
	[Serializable]
	public sealed class StorePermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StorePermission" /> с указанным состоянием разрешения: полностью ограниченное или неограниченное.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым значением <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x060014FA RID: 5370 RVA: 0x000552F3 File Offset: 0x000534F3
		public StorePermission(PermissionState state)
		{
			if (PermissionHelper.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this._flags = StorePermissionFlags.AllFlags;
				return;
			}
			this._flags = StorePermissionFlags.NoFlags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.StorePermission" /> с заданным доступом.</summary>
		/// <param name="flag">Поразрядное сочетание значений <see cref="T:System.Security.Permissions.StorePermissionFlags" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="flag" /> не является допустимым сочетанием значений <see cref="T:System.Security.Permissions.StorePermissionFlags" />.</exception>
		// Token: 0x060014FB RID: 5371 RVA: 0x00055318 File Offset: 0x00053518
		public StorePermission(StorePermissionFlags flag)
		{
			this.Flags = flag;
		}

		/// <summary>Получает или задает тип доступа <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />, разрешаемого текущим разрешением.</summary>
		/// <returns>Поразрядное сочетание значений <see cref="T:System.Security.Permissions.StorePermissionFlags" />.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка задать этому свойству недопустимое значение. Допустимые значения см. в разделе <see cref="T:System.Security.Permissions.StorePermissionFlags" />.</exception>
		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x00055327 File Offset: 0x00053527
		// (set) Token: 0x060014FD RID: 5373 RVA: 0x0005532F File Offset: 0x0005352F
		public StorePermissionFlags Flags
		{
			get
			{
				return this._flags;
			}
			set
			{
				if (value != StorePermissionFlags.NoFlags && (value & StorePermissionFlags.AllFlags) == StorePermissionFlags.NoFlags)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "StorePermissionFlags");
				}
				this._flags = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x060014FE RID: 5374 RVA: 0x00055364 File Offset: 0x00053564
		public bool IsUnrestricted()
		{
			return this._flags == StorePermissionFlags.AllFlags;
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x060014FF RID: 5375 RVA: 0x00055373 File Offset: 0x00053573
		public override IPermission Copy()
		{
			if (this._flags == StorePermissionFlags.NoFlags)
			{
				return null;
			}
			return new StorePermission(this._flags);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06001500 RID: 5376 RVA: 0x0005538C File Offset: 0x0005358C
		public override IPermission Intersect(IPermission target)
		{
			StorePermission storePermission = this.Cast(target);
			if (storePermission == null)
			{
				return null;
			}
			if (this.IsUnrestricted() && storePermission.IsUnrestricted())
			{
				return new StorePermission(PermissionState.Unrestricted);
			}
			if (this.IsUnrestricted())
			{
				return storePermission.Copy();
			}
			if (storePermission.IsUnrestricted())
			{
				return this.Copy();
			}
			StorePermissionFlags storePermissionFlags = this._flags & storePermission._flags;
			if (storePermissionFlags == StorePermissionFlags.NoFlags)
			{
				return null;
			}
			return new StorePermission(storePermissionFlags);
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06001501 RID: 5377 RVA: 0x000553F4 File Offset: 0x000535F4
		public override IPermission Union(IPermission target)
		{
			StorePermission storePermission = this.Cast(target);
			if (storePermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || storePermission.IsUnrestricted())
			{
				return new StorePermission(PermissionState.Unrestricted);
			}
			StorePermissionFlags storePermissionFlags = this._flags | storePermission._flags;
			if (storePermissionFlags == StorePermissionFlags.NoFlags)
			{
				return null;
			}
			return new StorePermission(storePermissionFlags);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение на проверку наличия связи подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06001502 RID: 5378 RVA: 0x00055444 File Offset: 0x00053644
		public override bool IsSubsetOf(IPermission target)
		{
			StorePermission storePermission = this.Cast(target);
			if (storePermission == null)
			{
				return this._flags == StorePermissionFlags.NoFlags;
			}
			return storePermission.IsUnrestricted() || (!this.IsUnrestricted() && (this._flags & ~storePermission._flags) == StorePermissionFlags.NoFlags);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="securityElement">Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML, используемую для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="securityElement" /> — <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> не является допустимым элементом разрешения.  
		/// -или- 
		/// Номер версии в <paramref name="securityElement" /> не является допустимым.</exception>
		// Token: 0x06001503 RID: 5379 RVA: 0x0005548C File Offset: 0x0005368C
		public override void FromXml(SecurityElement securityElement)
		{
			PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			string text = securityElement.Attribute("Flags");
			if (text == null)
			{
				this._flags = StorePermissionFlags.NoFlags;
				return;
			}
			this._flags = (StorePermissionFlags)Enum.Parse(typeof(StorePermissionFlags), text);
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, содержащий кодировку XML разрешения, включая сведения о состоянии.</returns>
		// Token: 0x06001504 RID: 5380 RVA: 0x000554DC File Offset: 0x000536DC
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(typeof(StorePermission), 1);
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", bool.TrueString);
			}
			else
			{
				securityElement.AddAttribute("Flags", this._flags.ToString());
			}
			return securityElement;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00055531 File Offset: 0x00053731
		private StorePermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			StorePermission storePermission = target as StorePermission;
			if (storePermission == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(StorePermission));
			}
			return storePermission;
		}

		// Token: 0x04000BC3 RID: 3011
		private const int version = 1;

		// Token: 0x04000BC4 RID: 3012
		private StorePermissionFlags _flags;
	}
}
