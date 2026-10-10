using System;
using System.Runtime.InteropServices;

namespace System.Security.Permissions
{
	/// <summary>Определяет разрешение удостоверения для зоны, являющейся источником кода. Этот класс не наследуется.</summary>
	// Token: 0x02000464 RID: 1124
	[ComVisible(true)]
	[Serializable]
	public sealed class ZoneIdentityPermission : CodeAccessPermission, IBuiltInPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ZoneIdentityPermission" /> указанным значением <see cref="T:System.Security.Permissions.PermissionState" />.</summary>
		/// <param name="state">Одно из значений перечисления <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="state" /> не является допустимым значением для <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06002DAB RID: 11691 RVA: 0x000A3928 File Offset: 0x000A1B28
		public ZoneIdentityPermission(PermissionState state)
		{
			CodeAccessPermission.CheckPermissionState(state, false);
			this.zone = SecurityZone.NoZone;
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Permissions.ZoneIdentityPermission" /> для представления идентификатора указанной зоны.</summary>
		/// <param name="zone">Идентификатор зоны.</param>
		// Token: 0x06002DAC RID: 11692 RVA: 0x000A393F File Offset: 0x000A1B3F
		public ZoneIdentityPermission(SecurityZone zone)
		{
			this.SecurityZone = zone;
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Копия текущего разрешения.</returns>
		// Token: 0x06002DAD RID: 11693 RVA: 0x000A394E File Offset: 0x000A1B4E
		public override IPermission Copy()
		{
			return new ZoneIdentityPermission(this.zone);
		}

		/// <summary>Определяет, является ли текущее разрешение подмножеством указанного разрешения.</summary>
		/// <param name="target">Разрешение, для которого требуется проверить отношение подмножества. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является <see langword="null" />, это разрешение не представляет зону безопасности <see cref="F:System.Security.SecurityZone.NoZone" />, а указанное разрешение не совпадает с текущим разрешением.</exception>
		// Token: 0x06002DAE RID: 11694 RVA: 0x000A395C File Offset: 0x000A1B5C
		public override bool IsSubsetOf(IPermission target)
		{
			ZoneIdentityPermission zoneIdentityPermission = this.Cast(target);
			if (zoneIdentityPermission == null)
			{
				return this.zone == SecurityZone.NoZone;
			}
			return this.zone == SecurityZone.NoZone || this.zone == zoneIdentityPermission.zone;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, которое требуется объединить с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой объединение текущего и указанного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.  
		///
		/// или - 
		/// Два разрешения не являются одинаковыми, и текущее разрешение не представляет зону безопасности <see cref="F:System.Security.SecurityZone.NoZone" />.</exception>
		// Token: 0x06002DAF RID: 11695 RVA: 0x000A3998 File Offset: 0x000A1B98
		public override IPermission Union(IPermission target)
		{
			ZoneIdentityPermission zoneIdentityPermission = this.Cast(target);
			if (zoneIdentityPermission == null)
			{
				if (this.zone != SecurityZone.NoZone)
				{
					return this.Copy();
				}
				return null;
			}
			else
			{
				if (this.zone == zoneIdentityPermission.zone || zoneIdentityPermission.zone == SecurityZone.NoZone)
				{
					return this.Copy();
				}
				if (this.zone == SecurityZone.NoZone)
				{
					return zoneIdentityPermission.Copy();
				}
				throw new ArgumentException(Locale.GetText("Union impossible"));
			}
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Новое разрешение, представляющее собой пересечение текущего и указанного разрешений. Это новое разрешение равно <see langword="null" />, если пересечение является пустым.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не равен <see langword="null" /> и имеет тип, не совпадающий с типом текущего разрешения.</exception>
		// Token: 0x06002DB0 RID: 11696 RVA: 0x000A3A00 File Offset: 0x000A1C00
		public override IPermission Intersect(IPermission target)
		{
			ZoneIdentityPermission zoneIdentityPermission = this.Cast(target);
			if (zoneIdentityPermission == null || this.zone == SecurityZone.NoZone)
			{
				return null;
			}
			if (this.zone == zoneIdentityPermission.zone)
			{
				return this.Copy();
			}
			return null;
		}

		/// <summary>Восстанавливает разрешение с указанным состоянием из кодировки XML.</summary>
		/// <param name="esd">Кодировка XML, используемая для восстановления разрешения.</param>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="esd" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="esd" /> не является допустимым элементом разрешения.  
		///
		/// или - 
		/// Недопустимый номер версии параметра <paramref name="esd" />.</exception>
		// Token: 0x06002DB1 RID: 11697 RVA: 0x000A3A3C File Offset: 0x000A1C3C
		public override void FromXml(SecurityElement esd)
		{
			CodeAccessPermission.CheckSecurityElement(esd, "esd", 1, 1);
			string text = esd.Attribute("Zone");
			if (text == null)
			{
				this.zone = SecurityZone.NoZone;
				return;
			}
			this.zone = (SecurityZone)Enum.Parse(typeof(SecurityZone), text);
		}

		/// <summary>Создает кодировку XML для разрешения и его текущего состояния.</summary>
		/// <returns>Кодировка XML разрешения, включающая любые сведения о состоянии.</returns>
		// Token: 0x06002DB2 RID: 11698 RVA: 0x000A3A8C File Offset: 0x000A1C8C
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = base.Element(1);
			if (this.zone != SecurityZone.NoZone)
			{
				securityElement.AddAttribute("Zone", this.zone.ToString());
			}
			return securityElement;
		}

		/// <summary>Возвращает или задает зону, представленную текущим <see cref="T:System.Security.Permissions.ZoneIdentityPermission" />.</summary>
		/// <returns>Одно из значений перечисления <see cref="T:System.Security.SecurityZone" />.</returns>
		/// <exception cref="T:System.ArgumentException">Значение параметра не является допустимым значением для <see cref="T:System.Security.SecurityZone" />.</exception>
		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x000A3AC7 File Offset: 0x000A1CC7
		// (set) Token: 0x06002DB4 RID: 11700 RVA: 0x000A3ACF File Offset: 0x000A1CCF
		public SecurityZone SecurityZone
		{
			get
			{
				return this.zone;
			}
			set
			{
				if (!Enum.IsDefined(typeof(SecurityZone), value))
				{
					throw new ArgumentException(string.Format(Locale.GetText("Invalid enum {0}"), value), "SecurityZone");
				}
				this.zone = value;
			}
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x000286A2 File Offset: 0x000268A2
		int IBuiltInPermission.GetTokenIndex()
		{
			return 14;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000A3B0F File Offset: 0x000A1D0F
		private ZoneIdentityPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			ZoneIdentityPermission zoneIdentityPermission = target as ZoneIdentityPermission;
			if (zoneIdentityPermission == null)
			{
				CodeAccessPermission.ThrowInvalidPermission(target, typeof(ZoneIdentityPermission));
			}
			return zoneIdentityPermission;
		}

		// Token: 0x040020C0 RID: 8384
		private const int version = 1;

		// Token: 0x040020C1 RID: 8385
		private SecurityZone zone;
	}
}
