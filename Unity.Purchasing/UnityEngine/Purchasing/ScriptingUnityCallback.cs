using System;
using Uniject;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000C RID: 12
	internal class ScriptingUnityCallback : IUnityCallback
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000022BF File Offset: 0x000004BF
		public ScriptingUnityCallback(IUnityCallback forwardTo, IUtil util)
		{
			this.forwardTo = forwardTo;
			this.util = util;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000022D8 File Offset: 0x000004D8
		public void OnProductsFetched(string json)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnProductsFetched(json);
			});
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002310 File Offset: 0x00000510
		public void OnProductsFetchFailed(string jsonFailureDescription)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnProductsFetchFailed(jsonFailureDescription);
			});
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002348 File Offset: 0x00000548
		public void OnPurchasesRetrievalFailed(string jsonFailureDescription)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnPurchasesRetrievalFailed(jsonFailureDescription);
			});
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002380 File Offset: 0x00000580
		public void OnPurchasesFetched(string json)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnPurchasesFetched(json);
			});
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000023B8 File Offset: 0x000005B8
		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnPurchaseSucceeded(id, receipt, transactionID);
			});
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002400 File Offset: 0x00000600
		public void OnPurchaseFailed(string json)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnPurchaseFailed(json);
			});
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002438 File Offset: 0x00000638
		public void OnPurchaseDeferred(string json)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnPurchaseDeferred(json);
			});
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002470 File Offset: 0x00000670
		public void OnStoreConnectionSucceeded()
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnStoreConnectionSucceeded();
			});
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000248C File Offset: 0x0000068C
		public void OnStoreConnectionFailed(string jsonFailureDescription)
		{
			this.util.RunOnMainThread(delegate
			{
				this.forwardTo.OnStoreConnectionFailed(jsonFailureDescription);
			});
		}

		// Token: 0x04000005 RID: 5
		private readonly IUnityCallback forwardTo;

		// Token: 0x04000006 RID: 6
		private readonly IUtil util;
	}
}
