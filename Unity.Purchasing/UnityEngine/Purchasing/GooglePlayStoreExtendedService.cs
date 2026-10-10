using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000089 RID: 137
	[NullableContext(1)]
	[Nullable(0)]
	internal class GooglePlayStoreExtendedService : StoreService, IGooglePlayStoreExtendedService, IStoreServiceExtension
	{
		// Token: 0x0600025E RID: 606 RVA: 0x0000679C File Offset: 0x0000499C
		[Preserve]
		internal GooglePlayStoreExtendedService(IGooglePlayStoreSetObfuscatedIdUseCase googlePlayStoreSetObfuscatedIdUseCase, IGooglePlayStoreConnectionUseCase googlePlayStoreConnectionUseCase, IStoreConnectUseCase connectUseCase) : base(connectUseCase)
		{
			this.m_GooglePlayStoreSetObfuscatedIdUseCase = googlePlayStoreSetObfuscatedIdUseCase;
			this.m_GooglePlayStoreConnectionUseCase = googlePlayStoreConnectionUseCase;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000067B3 File Offset: 0x000049B3
		[NullableContext(2)]
		public void SetInitializeConnectionFailureListener(Action listener)
		{
			this.m_InitializationConnectionListener = listener;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000067BC File Offset: 0x000049BC
		public void NotifyInitializationConnectionFailed()
		{
			Action initializationConnectionListener = this.m_InitializationConnectionListener;
			if (initializationConnectionListener == null)
			{
				return;
			}
			initializationConnectionListener();
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000067CE File Offset: 0x000049CE
		public void SetObfuscatedAccountId(string accountId)
		{
			this.m_GooglePlayStoreSetObfuscatedIdUseCase.SetObfuscatedAccountId(accountId);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000067DC File Offset: 0x000049DC
		public void SetObfuscatedProfileId(string profileId)
		{
			this.m_GooglePlayStoreSetObfuscatedIdUseCase.SetObfuscatedProfileId(profileId);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000067EA File Offset: 0x000049EA
		public void EndConnection()
		{
			this.m_GooglePlayStoreConnectionUseCase.EndConnection();
		}

		// Token: 0x040000C1 RID: 193
		[Nullable(2)]
		private Action m_InitializationConnectionListener;

		// Token: 0x040000C2 RID: 194
		private readonly IGooglePlayStoreSetObfuscatedIdUseCase m_GooglePlayStoreSetObfuscatedIdUseCase;

		// Token: 0x040000C3 RID: 195
		private readonly IGooglePlayStoreConnectionUseCase m_GooglePlayStoreConnectionUseCase;
	}
}
