using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Управляет доступом к серверам SMTP (Simple Mail Transport Protocol).</summary>
	// Token: 0x0200083C RID: 2108
	[Serializable]
	public sealed class SmtpPermission : CodeAccessPermission, IUnrestrictedPermission
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpPermission" /> с заданным состоянием.</summary>
		/// <param name="unrestricted">
		///   <see langword="true" />, если новое разрешение не ограничено; в противном случае — <see langword="false" />.</param>
		// Token: 0x06004327 RID: 17191 RVA: 0x000EA019 File Offset: 0x000E8219
		public SmtpPermission(bool unrestricted)
		{
			this.unrestricted = unrestricted;
			this.access = (unrestricted ? SmtpAccess.ConnectToUnrestrictedPort : SmtpAccess.None);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpPermission" />, используя заданное значение состояния разрешения.</summary>
		/// <param name="state">Одно из значений <see cref="T:System.Security.Permissions.PermissionState" />.</param>
		// Token: 0x06004328 RID: 17192 RVA: 0x000EA035 File Offset: 0x000E8235
		public SmtpPermission(PermissionState state)
		{
			this.unrestricted = (state == PermissionState.Unrestricted);
			this.access = (this.unrestricted ? SmtpAccess.ConnectToUnrestrictedPort : SmtpAccess.None);
		}

		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpPermission" />, используя указанный уровень доступа.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Net.Mail.SmtpAccess" />.</param>
		// Token: 0x06004329 RID: 17193 RVA: 0x000EA059 File Offset: 0x000E8259
		public SmtpPermission(SmtpAccess access)
		{
			this.access = access;
		}

		/// <summary>Возвращает уровень доступа к серверам SMTP, которым управляет разрешение.</summary>
		/// <returns>Одно из значений <see cref="T:System.Net.Mail.SmtpAccess" />.</returns>
		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x0600432A RID: 17194 RVA: 0x000EA068 File Offset: 0x000E8268
		public SmtpAccess Access
		{
			get
			{
				return this.access;
			}
		}

		/// <summary>Добавляет указанное значение уровня доступа в разрешение.</summary>
		/// <param name="access">Одно из значений <see cref="T:System.Net.Mail.SmtpAccess" />.</param>
		// Token: 0x0600432B RID: 17195 RVA: 0x000EA070 File Offset: 0x000E8270
		public void AddPermission(SmtpAccess access)
		{
			if (!this.unrestricted && access > this.access)
			{
				this.access = access;
			}
		}

		/// <summary>Создает и возвращает идентичную копию текущего разрешения.</summary>
		/// <returns>Объект <see cref="T:System.Net.Mail.SmtpPermission" />, идентичный текущему разрешению.</returns>
		// Token: 0x0600432C RID: 17196 RVA: 0x000EA08A File Offset: 0x000E828A
		public override IPermission Copy()
		{
			if (this.unrestricted)
			{
				return new SmtpPermission(true);
			}
			return new SmtpPermission(this.access);
		}

		/// <summary>Создает и возвращает разрешение, представляющее собой пересечение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, пересекающееся с текущим разрешением. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Объект <see cref="T:System.Net.Mail.SmtpPermission" />, представляющий собой пересечение текущего и заданного разрешений. Возвращает значение <see langword="null" />, если пересечение пустое или параметр <paramref name="target" /> имеет значение <see langword="null" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x0600432D RID: 17197 RVA: 0x000EA0A8 File Offset: 0x000E82A8
		public override IPermission Intersect(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return null;
			}
			if (this.unrestricted && smtpPermission.unrestricted)
			{
				return new SmtpPermission(true);
			}
			if (this.access > smtpPermission.access)
			{
				return new SmtpPermission(smtpPermission.access);
			}
			return new SmtpPermission(this.access);
		}

		/// <summary>Возвращает значение, определяющее, является ли текущее разрешение подмножеством заданного разрешения.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, для которого требуется проверить соотношение подмножеств. Его тип должен совпадать с типом текущего разрешения.</param>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является подмножеством указанного разрешения. В противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x0600432E RID: 17198 RVA: 0x000EA100 File Offset: 0x000E8300
		public override bool IsSubsetOf(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return this.IsEmpty();
			}
			if (this.unrestricted)
			{
				return smtpPermission.unrestricted;
			}
			return this.access <= smtpPermission.access;
		}

		/// <summary>Возвращает значение, указывающее, является ли текущее разрешение неограниченным.</summary>
		/// <returns>Значение <see langword="true" />, если текущее разрешение является неограниченным. В противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600432F RID: 17199 RVA: 0x000EA13F File Offset: 0x000E833F
		public bool IsUnrestricted()
		{
			return this.unrestricted;
		}

		/// <summary>Создает XML-кодирование состояния разрешения.</summary>
		/// <returns>Объект <see cref="T:System.Security.SecurityElement" />, который содержит XML-кодирование текущего разрешения.</returns>
		// Token: 0x06004330 RID: 17200 RVA: 0x000EA148 File Offset: 0x000E8348
		public override SecurityElement ToXml()
		{
			SecurityElement securityElement = PermissionHelper.Element(typeof(SmtpPermission), 1);
			if (this.unrestricted)
			{
				securityElement.AddAttribute("Unrestricted", "true");
			}
			else
			{
				SmtpAccess smtpAccess = this.access;
				if (smtpAccess != SmtpAccess.Connect)
				{
					if (smtpAccess == SmtpAccess.ConnectToUnrestrictedPort)
					{
						securityElement.AddAttribute("Access", "ConnectToUnrestrictedPort");
					}
				}
				else
				{
					securityElement.AddAttribute("Access", "Connect");
				}
			}
			return securityElement;
		}

		/// <summary>Задает состояние разрешения, используя указанное XML-кодирование.</summary>
		/// <param name="securityElement">XML-кодирование, используемое для установки состояния текущего разрешения.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="securityElement" /> не описывает объект <see cref="T:System.Net.Mail.SmtpPermission" />.  
		/// -или- 
		///  <paramref name="securityElement" /> не содержит необходимой информации о состоянии для воссоздания разрешения.</exception>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="securityElement" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x06004331 RID: 17201 RVA: 0x000EA1B4 File Offset: 0x000E83B4
		public override void FromXml(SecurityElement securityElement)
		{
			PermissionHelper.CheckSecurityElement(securityElement, "securityElement", 1, 1);
			if (securityElement.Tag != "IPermission")
			{
				throw new ArgumentException("securityElement");
			}
			if (PermissionHelper.IsUnrestricted(securityElement))
			{
				this.access = SmtpAccess.Connect;
				return;
			}
			this.access = SmtpAccess.None;
		}

		/// <summary>Создает разрешение, представляющее собой объединение текущего и указанного разрешений.</summary>
		/// <param name="target">Разрешение <see cref="T:System.Security.IPermission" />, используемое в сочетании с текущим разрешением.</param>
		/// <returns>Новое разрешение <see cref="T:System.Net.Mail.SmtpPermission" />, представляющее собой объединение текущего и заданного разрешений.</returns>
		/// <exception cref="T:System.ArgumentException">Параметр <paramref name="target" /> не является классом <see cref="T:System.Net.Mail.SmtpPermission" />.</exception>
		// Token: 0x06004332 RID: 17202 RVA: 0x000EA204 File Offset: 0x000E8404
		public override IPermission Union(IPermission target)
		{
			SmtpPermission smtpPermission = this.Cast(target);
			if (smtpPermission == null)
			{
				return this.Copy();
			}
			if (this.unrestricted || smtpPermission.unrestricted)
			{
				return new SmtpPermission(true);
			}
			if (this.access > smtpPermission.access)
			{
				return new SmtpPermission(this.access);
			}
			return new SmtpPermission(smtpPermission.access);
		}

		// Token: 0x06004333 RID: 17203 RVA: 0x000EA25F File Offset: 0x000E845F
		private bool IsEmpty()
		{
			return !this.unrestricted && this.access == SmtpAccess.None;
		}

		// Token: 0x06004334 RID: 17204 RVA: 0x000EA274 File Offset: 0x000E8474
		private SmtpPermission Cast(IPermission target)
		{
			if (target == null)
			{
				return null;
			}
			SmtpPermission smtpPermission = target as SmtpPermission;
			if (smtpPermission == null)
			{
				PermissionHelper.ThrowInvalidPermission(target, typeof(SmtpPermission));
			}
			return smtpPermission;
		}

		// Token: 0x040028A7 RID: 10407
		private const int version = 1;

		// Token: 0x040028A8 RID: 10408
		private bool unrestricted;

		// Token: 0x040028A9 RID: 10409
		private SmtpAccess access;
	}
}
