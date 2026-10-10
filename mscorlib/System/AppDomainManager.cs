using System;
using System.Reflection;
using System.Runtime.Hosting;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Threading;

namespace System
{
	/// <summary>Предоставляет управляемый эквивалент неуправляемого основного приложения.</summary>
	// Token: 0x02000226 RID: 550
	[ComVisible(true)]
	[SecurityPermission(SecurityAction.InheritanceDemand, Infrastructure = true)]
	[SecurityPermission(SecurityAction.LinkDemand, Infrastructure = true)]
	public class AppDomainManager : MarshalByRefObject
	{
		/// <summary>Инициализирует новый экземпляр класса <see cref="T:System.AppDomainManager" />.</summary>
		// Token: 0x06001881 RID: 6273 RVA: 0x0005D910 File Offset: 0x0005BB10
		public AppDomainManager()
		{
			this._flags = AppDomainManagerInitializationOptions.None;
		}

		/// <summary>Возвращает активатор, управляющий активацией предназначенных для домена надстроек и приложений на основе манифеста.</summary>
		/// <returns>Активатор приложения.</returns>
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0005D91F File Offset: 0x0005BB1F
		public virtual ApplicationActivator ApplicationActivator
		{
			get
			{
				if (this._activator == null)
				{
					this._activator = new ApplicationActivator();
				}
				return this._activator;
			}
		}

		/// <summary>Возвращает входную сборку для приложения.</summary>
		/// <returns>Входная сборка для приложения.</returns>
		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0005D93A File Offset: 0x0005BB3A
		public virtual Assembly EntryAssembly
		{
			get
			{
				return Assembly.GetEntryAssembly();
			}
		}

		/// <summary>Возвращает диспетчер контекста выполнения сайта, управляющий потоком контекста выполнения.</summary>
		/// <returns>Диспетчер контекста выполнения основного приложения.</returns>
		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x000479F8 File Offset: 0x00045BF8
		[MonoTODO]
		public virtual HostExecutionContextManager HostExecutionContextManager
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		/// <summary>Возвращает диспетчер безопасности сайта, который участвует в принятии решений относительно безопасности домена приложения.</summary>
		/// <returns>Диспетчер безопасности основного приложения.</returns>
		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0000AF5E File Offset: 0x0000915E
		public virtual HostSecurityManager HostSecurityManager
		{
			get
			{
				return null;
			}
		}

		/// <summary>Возвращает флаги инициализации для диспетчеров пользовательских доменов приложений.</summary>
		/// <returns>Побитовое сочетание значений перечисления, определяющее действие, которое необходимо выполнить для инициализации. Значение по умолчанию: <see cref="F:System.AppDomainManagerInitializationOptions.None" />.</returns>
		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0005D941 File Offset: 0x0005BB41
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x0005D949 File Offset: 0x0005BB49
		public AppDomainManagerInitializationOptions InitializationFlags
		{
			get
			{
				return this._flags;
			}
			set
			{
				this._flags = value;
			}
		}

		/// <summary>Возвращает новый или существующий домен приложения.</summary>
		/// <param name="friendlyName">Понятное имя домена.</param>
		/// <param name="securityInfo">Объект, в котором содержится свидетельство, сопоставленное посредством политики безопасности и задающее набор разрешений для вершины стека.</param>
		/// <param name="appDomainInfo">Объект, в котором содержатся сведения об инициализации домена приложения.</param>
		/// <returns>Новый или существующий домен приложения.</returns>
		// Token: 0x06001888 RID: 6280 RVA: 0x0005D954 File Offset: 0x0005BB54
		public virtual AppDomain CreateDomain(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
		{
			this.InitializeNewDomain(appDomainInfo);
			AppDomain appDomain = AppDomainManager.CreateDomainHelper(friendlyName, securityInfo, appDomainInfo);
			if ((this.HostSecurityManager.Flags & HostSecurityManagerOptions.HostPolicyLevel) == HostSecurityManagerOptions.HostPolicyLevel)
			{
				PolicyLevel domainPolicy = this.HostSecurityManager.DomainPolicy;
				if (domainPolicy != null)
				{
					appDomain.SetAppDomainPolicy(domainPolicy);
				}
			}
			return appDomain;
		}

		/// <summary>Инициализирует новый домен приложения.</summary>
		/// <param name="appDomainInfo">Объект, в котором содержатся сведения об инициализации домена приложения.</param>
		// Token: 0x06001889 RID: 6281 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public virtual void InitializeNewDomain(AppDomainSetup appDomainInfo)
		{
		}

		/// <summary>Показывает, разрешена ли заданная операция в домене приложения.</summary>
		/// <param name="state">Подкласс объекта <see cref="T:System.Security.SecurityState" />, который определяет операцию, для которой запрашивается состояние безопасности.</param>
		/// <returns>Значение <see langword="true" />, если основное приложение разрешает выполнять операцию, заданную в параметре <paramref name="state" />, в домене приложения; в противном случае — значение <see langword="false" />.</returns>
		// Token: 0x0600188A RID: 6282 RVA: 0x0000DDA9 File Offset: 0x0000BFA9
		public virtual bool CheckSecuritySettings(SecurityState state)
		{
			return false;
		}

		/// <summary>Предоставляет вспомогательный метод для создания домена приложения.</summary>
		/// <param name="friendlyName">Понятное имя домена.</param>
		/// <param name="securityInfo">Объект, в котором содержится свидетельство, сопоставленное посредством политики безопасности и задающее набор разрешений для вершины стека.</param>
		/// <param name="appDomainInfo">Объект, в котором содержатся сведения об инициализации домена приложения.</param>
		/// <returns>Только что созданный домен приложения.</returns>
		/// <exception cref="T:System.ArgumentNullException">Свойство <paramref name="friendlyName" /> имеет значение <see langword="null" />.</exception>
		// Token: 0x0600188B RID: 6283 RVA: 0x0005D998 File Offset: 0x0005BB98
		protected static AppDomain CreateDomainHelper(string friendlyName, Evidence securityInfo, AppDomainSetup appDomainInfo)
		{
			return AppDomain.CreateDomain(friendlyName, securityInfo, appDomainInfo);
		}

		// Token: 0x040016B9 RID: 5817
		private ApplicationActivator _activator;

		// Token: 0x040016BA RID: 5818
		private AppDomainManagerInitializationOptions _flags;
	}
}
