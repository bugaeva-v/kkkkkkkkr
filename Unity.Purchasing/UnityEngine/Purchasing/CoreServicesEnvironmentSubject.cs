using System;
using System.Collections.Generic;

namespace UnityEngine.Purchasing
{
	// Token: 0x020000A7 RID: 167
	internal class CoreServicesEnvironmentSubject
	{
		// Token: 0x060002FB RID: 763 RVA: 0x00007235 File Offset: 0x00005435
		internal static CoreServicesEnvironmentSubject Instance()
		{
			if (CoreServicesEnvironmentSubject.s_Instance == null)
			{
				CoreServicesEnvironmentSubject.s_Instance = new CoreServicesEnvironmentSubject();
			}
			return CoreServicesEnvironmentSubject.s_Instance;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000724D File Offset: 0x0000544D
		public void SubscribeToUpdatesAndGetCurrent(ICoreServicesEnvironmentObserver newObserver)
		{
			if (!this.m_Observers.Contains(newObserver))
			{
				this.m_Observers.Add(newObserver);
				newObserver.OnUpdatedCoreServicesEnvironment(this.m_LastKnownEnvironment);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00007275 File Offset: 0x00005475
		internal void UpdateCurrentEnvironment(string currentEnvironment)
		{
			this.m_LastKnownEnvironment = currentEnvironment;
			this.NotifyObservers();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00007284 File Offset: 0x00005484
		private void NotifyObservers()
		{
			foreach (ICoreServicesEnvironmentObserver coreServicesEnvironmentObserver in this.m_Observers)
			{
				coreServicesEnvironmentObserver.OnUpdatedCoreServicesEnvironment(this.m_LastKnownEnvironment);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000072DC File Offset: 0x000054DC
		internal bool IsDefaultLiveEnvironment(string environment)
		{
			return environment == "production";
		}

		// Token: 0x040000E4 RID: 228
		private static CoreServicesEnvironmentSubject s_Instance;

		// Token: 0x040000E5 RID: 229
		private const string k_DefaultLiveEnvironment = "production";

		// Token: 0x040000E6 RID: 230
		private string m_LastKnownEnvironment;

		// Token: 0x040000E7 RID: 231
		private readonly List<ICoreServicesEnvironmentObserver> m_Observers = new List<ICoreServicesEnvironmentObserver>();
	}
}
