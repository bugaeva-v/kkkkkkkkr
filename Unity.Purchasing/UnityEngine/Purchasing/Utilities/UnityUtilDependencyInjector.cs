using System;
using Purchasing.Utilities;
using Uniject;
using UnityEngine.Purchasing.Extension;

namespace UnityEngine.Purchasing.Utilities
{
	// Token: 0x02000109 RID: 265
	internal static class UnityUtilDependencyInjector
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x0000B53A File Offset: 0x0000973A
		internal static UnityUtil CreateUnityUtils()
		{
			DependencyInjectionService dependencyInjectionService = new DependencyInjectionService();
			((IDependencyInjectionService)dependencyInjectionService).AddInstance(UnityUtilDependencyInjector.CreateMonoBehaviourUtil());
			((IDependencyInjectionService)dependencyInjectionService).AddService<UnityThreadUtils>();
			((IDependencyInjectionService)dependencyInjectionService).AddService<UnityUtil>();
			return ((IDependencyInjectionService)dependencyInjectionService).GetInstance<UnityUtil>();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0000B55D File Offset: 0x0000975D
		private static MonoBehaviourUtil CreateMonoBehaviourUtil()
		{
			GameObject gameObject = new GameObject("IAPMonoBehaviourUtil");
			Object.DontDestroyOnLoad(gameObject);
			gameObject.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
			return gameObject.AddComponent<MonoBehaviourUtil>();
		}

		// Token: 0x0400022C RID: 556
		private const string k_IAPMonoBehaviourUtil = "IAPMonoBehaviourUtil";
	}
}
