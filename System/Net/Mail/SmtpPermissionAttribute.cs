using System;
using System.Security;
using System.Security.Permissions;

namespace System.Net.Mail
{
	/// <summary>Управляет доступом к серверам SMTP (Simple Mail Transport Protocol).</summary>
	// Token: 0x0200083D RID: 2109
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
	[Serializable]
	public sealed class SmtpPermissionAttribute : CodeAccessSecurityAttribute
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Net.Mail.SmtpPermissionAttribute" />.</summary>
		/// <param name="action">Одно из значений <see cref="T:System.Security.Permissions.SecurityAction" />, которое задает поведение разрешения.</param>
		/// <exception cref="T:System.ArgumentException">
		///   <paramref name="action" /> не является допустимым <see cref="T:System.Security.Permissions.SecurityAction" />.</exception>
		// Token: 0x06004335 RID: 17205 RVA: 0x000A97B6 File Offset: 0x000A79B6
		public SmtpPermissionAttribute(SecurityAction action) : base(action)
		{
		}

		/// <summary>Возвращает или задает уровень доступа к серверам SMTP, управляемым атрибутом.</summary>
		/// <returns>Значение <see cref="T:System.String" />. Допустимыми значениями являются "Connect" и "None".</returns>
		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004336 RID: 17206 RVA: 0x000EA294 File Offset: 0x000E8494
		// (set) Token: 0x06004337 RID: 17207 RVA: 0x000EA29C File Offset: 0x000E849C
		public string Access
		{
			get
			{
				return this.access;
			}
			set
			{
				this.access = value;
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x000EA2A8 File Offset: 0x000E84A8
		private SmtpAccess GetSmtpAccess()
		{
			if (this.access == null)
			{
				return SmtpAccess.None;
			}
			string a = this.access.ToLowerInvariant();
			if (a == "connecttounrestrictedport")
			{
				return SmtpAccess.ConnectToUnrestrictedPort;
			}
			if (a == "connect")
			{
				return SmtpAccess.Connect;
			}
			if (!(a == "none"))
			{
				string text = Locale.GetText("Invalid Access='{0}' value.", new object[]
				{
					this.access
				});
				throw new ArgumentException("Access", text);
			}
			return SmtpAccess.None;
		}

		/// <summary>Создает объект разрешения, который может быть сохранен с <see cref="T:System.Security.Permissions.SecurityAction" /> в метаданных сборки.</summary>
		/// <returns>Экземпляр <see cref="T:System.Net.Mail.SmtpPermission" />.</returns>
		// Token: 0x06004339 RID: 17209 RVA: 0x000EA31F File Offset: 0x000E851F
		public override IPermission CreatePermission()
		{
			if (base.Unrestricted)
			{
				return new SmtpPermission(true);
			}
			return new SmtpPermission(this.GetSmtpAccess());
		}

		// Token: 0x040028AA RID: 10410
		private string access;
	}
}
