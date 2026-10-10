using System;
using System.Runtime.InteropServices;

namespace System.Security
{
	/// <summary>Указывает компоненты политики безопасности, которые должны использоваться диспетчером безопасности узла.</summary>
	// Token: 0x020003E0 RID: 992
	[Flags]
	[ComVisible(true)]
	[Serializable]
	public enum HostSecurityManagerOptions
	{
		/// <summary>Компоненты политики безопасности не используются.</summary>
		// Token: 0x04001EB8 RID: 7864
		None = 0,
		/// <summary>Используется свидетельство домена приложения.</summary>
		// Token: 0x04001EB9 RID: 7865
		HostAppDomainEvidence = 1,
		/// <summary>Использование уровня политики, указанного в свойстве <see cref="P:System.Security.HostSecurityManager.DomainPolicy" />.</summary>
		// Token: 0x04001EBA RID: 7866
		HostPolicyLevel = 2,
		/// <summary>Используется свидетельство сборки.</summary>
		// Token: 0x04001EBB RID: 7867
		HostAssemblyEvidence = 4,
		/// <summary>Перенаправление вызовов метода <see cref="M:System.Security.Policy.ApplicationSecurityManager.DetermineApplicationTrust(System.ActivationContext,System.Security.Policy.TrustManagerContext)" /> методу <see cref="M:System.Security.HostSecurityManager.DetermineApplicationTrust(System.Security.Policy.Evidence,System.Security.Policy.Evidence,System.Security.Policy.TrustManagerContext)" />.</summary>
		// Token: 0x04001EBC RID: 7868
		HostDetermineApplicationTrust = 8,
		/// <summary>Использование метода <see cref="M:System.Security.HostSecurityManager.ResolvePolicy(System.Security.Policy.Evidence)" /> для разрешения свидетельства приложения.</summary>
		// Token: 0x04001EBD RID: 7869
		HostResolvePolicy = 16,
		/// <summary>Используются все компоненты политики безопасности.</summary>
		// Token: 0x04001EBE RID: 7870
		AllFlags = 31
	}
}
