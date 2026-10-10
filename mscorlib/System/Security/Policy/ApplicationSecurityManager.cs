using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Security.Policy
{
	/// <summary>Управляет решениями о доверии для приложений, активируемых на основе манифеста.</summary>
	// Token: 0x02000402 RID: 1026
	[ComVisible(true)]
	public static class ApplicationSecurityManager
	{
		/// <summary>Получает текущий диспетчер доверия приложения.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.IApplicationTrustManager" />, представляющий текущий диспетчер доверия.</returns>
		/// <exception cref="T:System.Security.Policy.PolicyException">Политика на этом приложении не имеет диспетчера доверия.</exception>
		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060029ED RID: 10733 RVA: 0x000981A9 File Offset: 0x000963A9
		public static IApplicationTrustManager ApplicationTrustManager
		{
			[SecurityPermission(SecurityAction.Demand, ControlPolicy = true)]
			get
			{
				if (ApplicationSecurityManager._appTrustManager == null)
				{
					ApplicationSecurityManager._appTrustManager = new MonoTrustManager();
				}
				return ApplicationSecurityManager._appTrustManager;
			}
		}

		/// <summary>Получает коллекцию доверия приложения, которая содержит кэшированные решения о доверии для пользователя.</summary>
		/// <returns>Объект <see cref="T:System.Security.Policy.ApplicationTrustCollection" />, который содержит кэшированные решения о доверии для пользователя.</returns>
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060029EE RID: 10734 RVA: 0x000981C1 File Offset: 0x000963C1
		public static ApplicationTrustCollection UserApplicationTrusts
		{
			get
			{
				if (ApplicationSecurityManager._userAppTrusts == null)
				{
					ApplicationSecurityManager._userAppTrusts = new ApplicationTrustCollection();
				}
				return ApplicationSecurityManager._userAppTrusts;
			}
		}

		/// <summary>Определяет, утверждает ли пользователь указанное приложение для его исполнения с запрошенным набором разрешений.</summary>
		/// <param name="activationContext">Объект <see cref="T:System.ActivationContext" />, определяющий контекст активации для приложения.</param>
		/// <param name="context">Объект <see cref="T:System.Security.Policy.TrustManagerContext" />, определяющий контекст диспетчера доверия для приложения.</param>
		/// <returns>Значение <see langword="true" /> для исполнения заданного приложения; в противном случае — значение <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">Параметр <paramref name="activationContext" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060029EF RID: 10735 RVA: 0x000981D9 File Offset: 0x000963D9
		[MonoTODO("Missing application manifest support")]
		[SecurityPermission(SecurityAction.Demand, ControlPolicy = true, ControlEvidence = true)]
		public static bool DetermineApplicationTrust(ActivationContext activationContext, TrustManagerContext context)
		{
			if (activationContext == null)
			{
				throw new NullReferenceException("activationContext");
			}
			return ApplicationSecurityManager.ApplicationTrustManager.DetermineApplicationTrust(activationContext, context).IsApplicationTrustedToRun;
		}

		// Token: 0x04001F59 RID: 8025
		private static IApplicationTrustManager _appTrustManager;

		// Token: 0x04001F5A RID: 8026
		private static ApplicationTrustCollection _userAppTrusts;
	}
}
