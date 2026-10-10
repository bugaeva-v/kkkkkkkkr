using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Permissions;
using Mono;
using Unity;

namespace System.Security.Principal
{
	/// <summary>Включает код для проверки членства пользователя Windows в группе Windows.</summary>
	// Token: 0x020004EE RID: 1262
	[ComVisible(true)]
	[Serializable]
	public class WindowsPrincipal : ClaimsPrincipal
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Principal.WindowsPrincipal" />, используя указанный объект <see cref="T:System.Security.Principal.WindowsIdentity" />.</summary>
		/// <param name="ntIdentity">Объект, из которого создается новый экземпляр <see cref="T:System.Security.Principal.WindowsPrincipal" />.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="ntIdentity" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06003278 RID: 12920 RVA: 0x000B9997 File Offset: 0x000B7B97
		public WindowsPrincipal(WindowsIdentity ntIdentity)
		{
			if (ntIdentity == null)
			{
				throw new ArgumentNullException("ntIdentity");
			}
			this._identity = ntIdentity;
		}

		/// <summary>Возвращает удостоверение текущего участника.</summary>
		/// <returns>Объект <see cref="T:System.Security.Principal.WindowsIdentity" /> текущего субъекта.</returns>
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06003279 RID: 12921 RVA: 0x000B99B4 File Offset: 0x000B7BB4
		public override IIdentity Identity
		{
			get
			{
				return this._identity;
			}
		}

		/// <summary>Определяет, относится ли текущий участник к группе пользователей Windows с заданным относительным идентификатором (RID).</summary>
		/// <param name="rid">RID группы пользователей Windows, в которой требуется проверить состояние членства участника.</param>
		/// <returns>Значение <see langword="true" />, если текущий субъект является членом заданной группы пользователей Windows (в конкретной роли); в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600327A RID: 12922 RVA: 0x000B99BC File Offset: 0x000B7BBC
		public virtual bool IsInRole(int rid)
		{
			if (Environment.IsUnix)
			{
				return WindowsPrincipal.IsMemberOfGroupId(this.Token, (IntPtr)rid);
			}
			string role;
			switch (rid)
			{
			case 544:
				role = "BUILTIN\\Administrators";
				break;
			case 545:
				role = "BUILTIN\\Users";
				break;
			case 546:
				role = "BUILTIN\\Guests";
				break;
			case 547:
				role = "BUILTIN\\Power Users";
				break;
			case 548:
				role = "BUILTIN\\Account Operators";
				break;
			case 549:
				role = "BUILTIN\\System Operators";
				break;
			case 550:
				role = "BUILTIN\\Print Operators";
				break;
			case 551:
				role = "BUILTIN\\Backup Operators";
				break;
			case 552:
				role = "BUILTIN\\Replicator";
				break;
			default:
				return false;
			}
			return this.IsInRole(role);
		}

		/// <summary>Определяет, относится ли текущий субъект к группе пользователей Windows с заданным именем.</summary>
		/// <param name="role">Имя группы пользователей Windows, для которой требуется проверить членство.</param>
		/// <returns>Значение <see langword="true" />, если текущий участник является членом заданной группы пользователей Windows; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600327B RID: 12923 RVA: 0x000B9A68 File Offset: 0x000B7C68
		[SecuritySafeCritical]
		[SecurityPermission(SecurityAction.Demand, ControlPrincipal = true)]
		public override bool IsInRole(string role)
		{
			if (role == null)
			{
				return false;
			}
			if (Environment.IsUnix)
			{
				using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(role))
				{
					return WindowsPrincipal.IsMemberOfGroupName(this.Token, safeStringMarshal.Value);
				}
			}
			if (this.m_roles == null)
			{
				this.m_roles = WindowsIdentity._GetRoles(this.Token);
			}
			role = role.ToUpperInvariant();
			foreach (string text in this.m_roles)
			{
				if (text != null && role == text.ToUpperInvariant())
				{
					return true;
				}
			}
			return false;
		}

		/// <summary>Определяет, относится ли текущий субъект к группе пользователей Windows с заданным <see cref="T:System.Security.Principal.WindowsBuiltInRole" />.</summary>
		/// <param name="role">Одно из значений <see cref="T:System.Security.Principal.WindowsBuiltInRole" />.</param>
		/// <returns>Значение <see langword="true" />, если текущий участник является членом заданной группы пользователей Windows; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="role" /> не является допустимым значением <see cref="T:System.Security.Principal.WindowsBuiltInRole" />.</exception>
		// Token: 0x0600327C RID: 12924 RVA: 0x000B9B10 File Offset: 0x000B7D10
		public virtual bool IsInRole(WindowsBuiltInRole role)
		{
			if (!Environment.IsUnix)
			{
				return this.IsInRole((int)role);
			}
			if (role == WindowsBuiltInRole.Administrator)
			{
				string role2 = "root";
				return this.IsInRole(role2);
			}
			return false;
		}

		/// <summary>Определяет, относится ли текущий субъект к группе пользователей Windows с заданным идентификатором безопасности (SID).</summary>
		/// <param name="sid">Объект <see cref="T:System.Security.Principal.SecurityIdentifier" />, уникально определяющий группу пользователей Windows.</param>
		/// <returns>Значение <see langword="true" />, если текущий участник является членом заданной группы пользователей Windows; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="sid" /> имеет значение <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.SecurityException">Система Windows возвратила код ошибки Win32.</exception>
		// Token: 0x0600327D RID: 12925 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO("not implemented")]
		[ComVisible(false)]
		public virtual bool IsInRole(SecurityIdentifier sid)
		{
			throw new NotImplementedException();
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x0600327E RID: 12926 RVA: 0x000B9B47 File Offset: 0x000B7D47
		private IntPtr Token
		{
			get
			{
				return this._identity.Token;
			}
		}

		// Token: 0x0600327F RID: 12927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsMemberOfGroupId(IntPtr user, IntPtr group);

		// Token: 0x06003280 RID: 12928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool IsMemberOfGroupName(IntPtr user, IntPtr group);

		/// <summary>Получает все утверждения устройства Windows из этого субъекта.</summary>
		/// <returns>Коллекция всех требований устройства Windows из этого субъекта.</returns>
		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06003281 RID: 12929 RVA: 0x000B98FF File Offset: 0x000B7AFF
		public virtual IEnumerable<Claim> DeviceClaims
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		/// <summary>Получает все утверждения пользователя Windows из этого субъекта.</summary>
		/// <returns>Коллекция всех требований пользователя Windows из этого субъекта.</returns>
		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06003282 RID: 12930 RVA: 0x000B98FF File Offset: 0x000B7AFF
		public virtual IEnumerable<Claim> UserClaims
		{
			get
			{
				ThrowStub.ThrowNotSupportedException();
				return 0;
			}
		}

		// Token: 0x04002346 RID: 9030
		private WindowsIdentity _identity;

		// Token: 0x04002347 RID: 9031
		private string[] m_roles;
	}
}
