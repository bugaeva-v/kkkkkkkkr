using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Содержит свидетельство безопасности для приложения. Этот класс не наследуется.</summary>
	// Token: 0x02000401 RID: 1025
	[ComVisible(true)]
	public sealed class ApplicationSecurityInfo
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.Security.Policy.ApplicationSecurityInfo" />, используя предоставленный контекст активации.</summary>
		/// <param name="activationContext">Объект <see cref="T:System.ActivationContext" />, однозначно идентифицирующий целевое приложение.</param>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="activationContext" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060029E4 RID: 10724 RVA: 0x00098108 File Offset: 0x00096308
		public ApplicationSecurityInfo(ActivationContext activationContext)
		{
			if (activationContext == null)
			{
				throw new ArgumentNullException("activationContext");
			}
		}

		/// <summary>Возвращает или задает свидетельство для приложения.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.Evidence" /> для приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Security.Policy.ApplicationSecurityInfo.ApplicationEvidence" /> задается значение <see langword="null" />.</exception>
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060029E5 RID: 10725 RVA: 0x0009811E File Offset: 0x0009631E
		// (set) Token: 0x060029E6 RID: 10726 RVA: 0x00098126 File Offset: 0x00096326
		public Evidence ApplicationEvidence
		{
			get
			{
				return this._evidence;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("ApplicationEvidence");
				}
				this._evidence = value;
			}
		}

		/// <summary>Возвращает или задает информацию идентификации приложения.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationId" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Security.Policy.ApplicationSecurityInfo.ApplicationId" /> задается значение <see langword="null" />.</exception>
		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060029E7 RID: 10727 RVA: 0x0009813D File Offset: 0x0009633D
		// (set) Token: 0x060029E8 RID: 10728 RVA: 0x00098145 File Offset: 0x00096345
		public ApplicationId ApplicationId
		{
			get
			{
				return this._appid;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("ApplicationId");
				}
				this._appid = value;
			}
		}

		/// <summary>Возвращает или задает набора разрешений по умолчанию.</summary>
		/// <returns>Объект <see cref="T:System.Security.PermissionSet" />, представляющий разрешения по умолчанию для приложения. Значением по умолчанию является <see cref="T:System.Security.PermissionSet" /> с состоянием разрешения объекта <see cref="F:System.Security.Permissions.PermissionState.None" /></returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Security.Policy.ApplicationSecurityInfo.DefaultRequestSet" /> задается значение <see langword="null" />.</exception>
		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060029E9 RID: 10729 RVA: 0x0009815C File Offset: 0x0009635C
		// (set) Token: 0x060029EA RID: 10730 RVA: 0x00098173 File Offset: 0x00096373
		public PermissionSet DefaultRequestSet
		{
			get
			{
				if (this._defaultSet == null)
				{
					return new PermissionSet(PermissionState.None);
				}
				return this._defaultSet;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("DefaultRequestSet");
				}
				this._defaultSet = value;
			}
		}

		/// <summary>Возвращает или задает верхний элемент в приложении, который описан в идентификации развертывания.</summary>
		/// <returns>Объект <see cref="T:System.ApplicationId" />, описывающий верхний элемент приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметру <see cref="P:System.Security.Policy.ApplicationSecurityInfo.DeploymentId" /> задается значение <see langword="null" />.</exception>
		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060029EB RID: 10731 RVA: 0x0009818A File Offset: 0x0009638A
		// (set) Token: 0x060029EC RID: 10732 RVA: 0x00098192 File Offset: 0x00096392
		public ApplicationId DeploymentId
		{
			get
			{
				return this._deployid;
			}
			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("DeploymentId");
				}
				this._deployid = value;
			}
		}

		// Token: 0x04001F55 RID: 8021
		private Evidence _evidence;

		// Token: 0x04001F56 RID: 8022
		private ApplicationId _appid;

		// Token: 0x04001F57 RID: 8023
		private PermissionSet _defaultSet;

		// Token: 0x04001F58 RID: 8024
		private ApplicationId _deployid;
	}
}
