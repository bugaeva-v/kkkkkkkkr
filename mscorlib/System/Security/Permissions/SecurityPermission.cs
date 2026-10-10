using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Описывает набор разрешений безопасности, примененных к коду. Этот класс не наследуется.</summary>
	// Token: 0x02000457 RID: 1111
	[ComVisible(true)]
	[Serializable]
	public sealed class SecurityPermission : CodeAccessPermission, IUnrestrictedPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.SecurityPermission" /> с указанным состоянием разрешения: ограниченным или неограниченным.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002D13 RID: 11539 RVA: 0x000A1B38 File Offset: 0x0009FD38
		public SecurityPermission(PermissionState state)
		{
			if (CodeAccessPermission.CheckPermissionState(state, true) == PermissionState.Unrestricted)
			{
				this.flags = SecurityPermissionFlag.AllFlags;
				return;
			}
			this.flags = SecurityPermissionFlag.NoFlags;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.SecurityPermission" /> с заданным исходным состоянием флагов.</summary>
		/// <param name="flag">Начальное состояние разрешения, представленное побитовым сочетанием всех битов разрешений, определенных <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />, с помощью логической операции ИЛИ.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="flag" /> не является допустимым значением для <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />.</exception>
		// Token: 0x06002D14 RID: 11540 RVA: 0x000A1B5D File Offset: 0x0009FD5D
		public SecurityPermission(SecurityPermissionFlag flag)
		{
			this.Flags = flag;
		}

		/// <summary>Получает или задает флаги разрешений безопасности.</summary>
		/// <returns>Состояние текущего разрешения, представленное побитовым сочетанием всех битов разрешений, определенных <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />, с помощью логической операции ИЛИ.</returns>
		/// <exception cref="T:System.ArgumentException">Предпринята попытка задать этому свойству недопустимое значение. Допустимые значения см. в разделе <see cref="T:System.Security.Permissions.SecurityPermissionFlag" />.</exception>
		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000A1B6C File Offset: 0x0009FD6C
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000A1B74 File Offset: 0x0009FD74
		public SecurityPermissionFlag Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				if ((value & SecurityPermissionFlag.AllFlags) != value)
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid flags {0}"), value), "SecurityPermissionFlag");
				}
				this.flags = value;
			}
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x06002D17 RID: 11543 RVA: 0x000A1BA7 File Offset: 0x0009FDA7
		public bool IsUnrestricted()
		{
			return this.flags == SecurityPermissionFlag.AllFlags;
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002D18 RID: 11544 RVA: 0x000A1BB6 File Offset: 0x0009FDB6
		public override IPermission Copy()
		{
			return new SecurityPermission(this.flags);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новый объект разрешения, представляющий собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D19 RID: 11545 RVA: 0x000A1BC4 File Offset: 0x0009FDC4
		public override IPermission Intersect(IPermission target)
		{
			SecurityPermission securityPermission = this.Cast(target);
			if (securityPermission == null)
			{
				return null;
			}
			if (this.IsEmpty() || securityPermission.IsEmpty())
			{
				return null;
			}
			if (this.IsUnrestricted() && securityPermission.IsUnrestricted())
			{
				return new SecurityPermission(PermissionState.Unrestricted);
			}
			if (this.IsUnrestricted())
			{
				return securityPermission.Copy();
			}
			if (securityPermission.IsUnrestricted())
			{
				return this.Copy();
			}
			SecurityPermissionFlag securityPermissionFlag = this.flags & securityPermission.flags;
			if (securityPermissionFlag == SecurityPermissionFlag.NoFlags)
			{
				return null;
			}
			return new SecurityPermission(securityPermissionFlag);
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D1A RID: 11546 RVA: 0x000A1C40 File Offset: 0x0009FE40
		public override IPermission Union(IPermission target)
		{
			SecurityPermission securityPermission = this.Cast(target);
			if (securityPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || securityPermission.IsUnrestricted())
			{
				return new SecurityPermission(PermissionState.Unrestricted);
			}
			return new SecurityPermission(this.flags | securityPermission.flags);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002D1B RID: 11547 RVA: 0x000A1C88 File Offset: 0x0009FE88
		public override bool IsSubsetOf(IPermission target)
		{
			SecurityPermission securityPermission = this.Cast(target);
			if (securityPermission == null)
			{
				return this.IsEmpty();
			}
			return securityPermission.IsUnrestricted() || (!this.IsUnrestricted() && (this.flags & ~securityPermission.flags) == SecurityPermissionFlag.NoFlags);
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Номер версии параметра <paramref name="esd" /> не поддерживается.</exception>
		// Token: 0x06002D1C RID: 11548 RVA: 0x000A1CCC File Offset: 0x0009FECC
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			if (CodeAccessPermission.IsUnrestricted(esd))
			{
				this.flags = SecurityPermissionFlag.AllFlags;
				return;
			}
			string text = esd.Attribute("Flags");
			if (text == null)
			{
				this.flags = SecurityPermissionFlag.NoFlags;
				return;
			}
			this.flags = (SecurityPermissionFlag)Enum.Parse(typeof(SecurityPermissionFlag), text);
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002D1D RID: 11549 RVA: 0x000A1D30 File Offset: 0x0009FF30
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this.IsUnrestricted())
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				securityElement.AddAttribute("Flags", this.flags.ToString());
			}
			return securityElement;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000224A3 File Offset: 0x000206A3
		int IBuiltInPermission.GetTokenIndex()
		{
			return 6;
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000A1D7C File Offset: 0x0009FF7C
		private bool IsEmpty()
		{
			return this.flags == SecurityPermissionFlag.NoFlags;
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000A1D87 File Offset: 0x0009FF87
		private SecurityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			SecurityPermission securityPermission = target as SecurityPermission;
			if (securityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(SecurityPermission));
			}
			return securityPermission;
		}

		// Token: 0x04002095 RID: 8341
		private const int version = 1;

		// Token: 0x04002096 RID: 8342
		private SecurityPermissionFlag flags;
	}
}
