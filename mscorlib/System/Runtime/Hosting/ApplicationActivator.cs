using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Policy;

namespace System.Runtime.Hosting
{
	/// <summary>Предоставляет базовый класс для активации сборок на основе манифестов.</summary>
	// Token: 0x02000556 RID: 1366
	[ComVisible(true)]
	[MonoTODO("missing manifest support")]
	public class ApplicationActivator
	{
		/// <summary>Создает экземпляр приложения, которое должно быть активировано, используя указанный контекст активации.</summary>
		/// <param name="activationContext">Контекст активации <see cref="T:System.ActivationContext" />, определяющий активируемое приложение.</param>
		/// <returns>Дескриптор <see cref="T:System.Runtime.Remoting.ObjectHandle" />, являющийся оболочкой для возвращаемого при выполнении приложения значения. Необходимо развернуть возвращенное значение, чтобы получить доступ к истинному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="activationContext" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035C9 RID: 13769 RVA: 0x000C2120 File Offset: 0x000C0320
		public virtual ObjectHandle CreateInstance(ActivationContext activationContext)
		{
			return this.CreateInstance(activationContext, null);
		}

		/// <summary>Создает экземпляр приложения, которое необходимо активировать, используя заданный контекст активации и пользовательские данные активации.</summary>
		/// <param name="activationContext">Контекст активации <see cref="T:System.ActivationContext" />, определяющий активируемое приложение.</param>
		/// <param name="activationCustomData">Пользовательские данные активации.</param>
		/// <returns>Дескриптор <see cref="T:System.Runtime.Remoting.ObjectHandle" />, являющийся оболочкой для возвращаемого при выполнении приложения значения. Необходимо развернуть возвращенное значение, чтобы получить доступ к истинному объекту.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="activationContext" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x060035CA RID: 13770 RVA: 0x000C212A File Offset: 0x000C032A
		public virtual ObjectHandle CreateInstance(ActivationContext activationContext, string[] activationCustomData)
		{
			if (activationContext == null)
			{
				throw new ArgumentNullException("activationContext");
			}
			return ApplicationActivator.CreateInstanceHelper(new AppDomainSetup(activationContext));
		}

		/// <summary>Создает экземпляр приложения с помощью указанного объекта <see cref="T:System.AppDomainSetup" />.</summary>
		/// <param name="adSetup">Объект <see cref="T:System.AppDomainSetup" />, свойство <see cref="P:System.AppDomainSetup.ActivationArguments" /> которого определяет активируемое приложение.</param>
		/// <returns>Дескриптор <see cref="T:System.Runtime.Remoting.ObjectHandle" />, являющийся оболочкой для возвращаемого при выполнении приложения значения. Необходимо развернуть возвращенное значение, чтобы получить доступ к истинному объекту.</returns>
		/// <exception cref="T:System.ArgumentException">Свойство <see cref="P:System.AppDomainSetup.ActivationArguments" /> параметра <paramref name="adSetup" /> равно <see langword="null" />.</exception>
		/// <exception cref="T:System.Security.Policy.PolicyException">Выполнение экземпляра приложения не удалось, поскольку настройки политики в текущем домене приложения не разрешают выполнение приложения.</exception>
		// Token: 0x060035CB RID: 13771 RVA: 0x000C2148 File Offset: 0x000C0348
		protected static ObjectHandle CreateInstanceHelper(AppDomainSetup adSetup)
		{
			if (adSetup == null)
			{
				throw new ArgumentNullException("adSetup");
			}
			if (adSetup.ActivationArguments == null)
			{
				throw new ArgumentException(string.Format(Locale.GetText("{0} is missing it's {1} property"), "AppDomainSetup", "ActivationArguments"), "adSetup");
			}
			HostSecurityManager hostSecurityManager;
			if (AppDomain.CurrentDomain.DomainManager != null)
			{
				hostSecurityManager = AppDomain.CurrentDomain.DomainManager.HostSecurityManager;
			}
			else
			{
				hostSecurityManager = new HostSecurityManager();
			}
			Evidence evidence = new Evidence();
			evidence.AddHost(adSetup.ActivationArguments);
			TrustManagerContext context = new TrustManagerContext();
			if (!hostSecurityManager.DetermineApplicationTrust(evidence, null, context).IsApplicationTrustedToRun)
			{
				throw new PolicyException(Locale.GetText("Current policy doesn't allow execution of addin."));
			}
			return AppDomain.CreateDomain("friendlyName", null, adSetup).CreateInstance("assemblyName", "typeName", null);
		}
	}
}
