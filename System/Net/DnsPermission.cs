using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net
{
	/// <summary>Управляет правами доступа к DNS-серверам в сети.</summary>
	// Token: 0x0200067E RID: 1662
	[Serializable]
	public sealed class DnsPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Создает новый экземпляр класса <see cref="T:System.Net.DnsPermission" />, который или разрешает неограниченный доступ к DNS, или запрещает доступ к DNS.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="state" /> не является допустимым значением <see cref="T:System.Security.Permissions.PermissionState" />.</exception>
		// Token: 0x06003456 RID: 13398 RVA: 0x000B650B File Offset: 0x000B470B
		public DnsPermission(PermissionState state)
		{
			this.m_noRestriction = (state == PermissionState.Unrestricted);
		}

		/// <summary>Создает идентичную копию текущего экземпляра разрешения.</summary>
		/// <returns>Новый экземпляр класса <see cref="T:System.Net.DnsPermission" />, который является идентичной копией текущего экземпляра.</returns>
		// Token: 0x06003457 RID: 13399 RVA: 0x000B651D File Offset: 0x000B471D
		public override IPermission Copy()
		{
			return new DnsPermission(this.m_noRestriction ? PermissionState.Unrestricted : PermissionState.None);
		}

		/// <summary>Создает экземпляр разрешения, представляющий собой пересечение текущего и заданного экземпляров разрешений.</summary>
		/// <param name="target">Экземпляр <see cref="T:System.Net.DnsPermission" /> для пересечения с текущим экземпляром.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.DnsPermission" />, представляющий собой пересечение текущего экземпляра <see cref="T:System.Net.DnsPermission" /> с заданным экземпляром <see cref="T:System.Net.DnsPermission" /> или <see langword="null" />, если пересечение является пустым. Если и текущий экземпляр и <paramref name="target" /> являются неограниченными, этот метод возвращает новый, неограниченный экземпляр <see cref="T:System.Net.DnsPermission" />; в противном случае возвращается <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является ни <see cref="T:System.Net.DnsPermission" />, ни <see langword="null" />.</exception>
		// Token: 0x06003458 RID: 13400 RVA: 0x000B6530 File Offset: 0x000B4730
		public override IPermission Intersect(IPermission target)
		{
			DnsPermission dnsPermission = this.Cast(target);
			if (dnsPermission == null)
			{
				return null;
			}
			if (this.IsUnrestricted() && dnsPermission.IsUnrestricted())
			{
				return new DnsPermission(PermissionState.Unrestricted);
			}
			return null;
		}

		/// <summary>Определяет, является ли текущий экземпляр разрешения подмножеством заданного экземпляра разрешения.</summary>
		/// <param name="target">Второй экземпляр <see cref="T:System.Net.DnsPermission" />, для которого требуется проверить соотношение подмножеств.</param>
		/// <returns>Значение <see langword="false" />, если текущий экземпляр является неограниченным, а <paramref name="target" /> является <see langword="null" /> или неограниченным разрешением; в противном случае — значение <see langword="true" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является ни <see cref="T:System.Net.DnsPermission" />, ни <see langword="null" />.</exception>
		// Token: 0x06003459 RID: 13401 RVA: 0x000B6564 File Offset: 0x000B4764
		public override bool IsSubsetOf(IPermission target)
		{
			DnsPermission dnsPermission = this.Cast(target);
			if (dnsPermission == null)
			{
				return this.IsEmpty();
			}
			return dnsPermission.IsUnrestricted() || this.m_noRestriction == dnsPermission.m_noRestriction;
		}

		/// <summary>Проверяет полное состояние разрешения для объекта.</summary>
		/// <returns>Значение <see langword="true" />, если экземпляр класса <see cref="T:System.Net.DnsPermission" /> был создан со свойством <see cref="F:System.Security.Permissions.PermissionState.Unrestricted" />; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600345A RID: 13402 RVA: 0x000B659B File Offset: 0x000B479B
		public bool IsUnrestricted()
		{
			return this.m_noRestriction;
		}

		/// <summary>Создает кодировку XML для экземпляра <see cref="T:System.Net.DnsPermission" /> и его текущего состояния.</summary>
		/// <returns>Экземпляр <see cref="T:System.Security.SecurityElement" />, содержащий XML-кодированное представление объекта безопасности, включая сведения о состоянии.</returns>
		// Token: 0x0600345B RID: 13403 RVA: 0x000B65A4 File Offset: 0x000B47A4
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(typeof(DnsPermission), 1);
			if (this.m_noRestriction)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			return securityElement;
		}

		/// <summary>Восстанавливает экземпляр <see cref="T:System.Net.DnsPermission" /> из кодировки XML.</summary>
		/// <param name="securityElement">Кодировка XML, используемая для восстановления экземпляра <see cref="T:System.Net.DnsPermission" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="securityElement" /> не является элементом <see cref="T:System.Net.DnsPermission" />.</exception>
		// Token: 0x0600345C RID: 13404 RVA: 0x000B65DB File Offset: 0x000B47DB
		public override void FromXml(SecurityElement securityElement)
		{
			PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			if (securityElement.Tag != "IPermission")
			{
				throw new ArgumentException("securityElement");
			}
			this.m_noRestriction = PermissionHelper.IsUnrestricted(securityElement);
		}

		/// <summary>Создает экземпляр разрешения, представляющий собой объединение текущего и заданного экземпляров разрешений.</summary>
		/// <param name="target">Экземпляр <see cref="T:System.Net.DnsPermission" /> для объединения с текущим экземпляром.</param>
		/// <returns>Экземпляр <see cref="T:System.Net.DnsPermission" />, представляющий собой объединение текущего экземпляра <see cref="T:System.Net.DnsPermission" /> с заданным экземпляром <see cref="T:System.Net.DnsPermission" />. Если значение параметра <paramref name="target" /> — <see langword="null" />, данный метод возвращает копию текущего экземпляра. Если текущий экземпляр или <paramref name="target" /> является неограниченным, этот метод возвращает неограниченный экземпляр <see cref="T:System.Net.DnsPermission" />; в противном случае возвращается экземпляр <see cref="T:System.Net.DnsPermission" />, который является ограниченным.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является ни <see cref="T:System.Net.DnsPermission" />, ни <see langword="null" />.</exception>
		// Token: 0x0600345D RID: 13405 RVA: 0x000B6614 File Offset: 0x000B4814
		public override IPermission Union(IPermission target)
		{
			DnsPermission dnsPermission = this.Cast(target);
			if (dnsPermission == null)
			{
				return this.Copy();
			}
			if (this.IsUnrestricted() || dnsPermission.IsUnrestricted())
			{
				return new DnsPermission(PermissionState.Unrestricted);
			}
			return new DnsPermission(PermissionState.None);
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000B6650 File Offset: 0x000B4850
		private bool IsEmpty()
		{
			return !this.m_noRestriction;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000B665B File Offset: 0x000B485B
		private DnsPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			DnsPermission dnsPermission = target as DnsPermission;
			if (dnsPermission == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(DnsPermission));
			}
			return dnsPermission;
		}

		// Token: 0x04001E8D RID: 7821
		private const int version = 1;

		// Token: 0x04001E8E RID: 7822
		private bool m_noRestriction;
	}
}
