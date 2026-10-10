using System;
using System.Runtime.CompilerServices;

namespace UnityEngine.Purchasing
{
	// Token: 0x0200000B RID: 11
	[NullableContext(1)]
	[Nullable(0)]
	internal class JavaBridge : AndroidJavaProxy, IUnityCallback
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000221C File Offset: 0x0000041C
		public JavaBridge(IUnityCallback forwardTo) : base("com.unity.purchasing.common.IUnityCallback")
		{
			this.forwardTo = forwardTo;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002230 File Offset: 0x00000430
		public JavaBridge(IUnityCallback forwardTo, string javaInterface) : base(javaInterface)
		{
			this.forwardTo = forwardTo;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002240 File Offset: 0x00000440
		public void OnProductsFetched(string json)
		{
			this.forwardTo.OnProductsFetched(json);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000224E File Offset: 0x0000044E
		public void OnProductsFetchFailed(string jsonFailureDescription)
		{
			this.forwardTo.OnProductsFetchFailed(jsonFailureDescription);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000225C File Offset: 0x0000045C
		public void OnPurchasesRetrievalFailed(string jsonFailureDescription)
		{
			this.forwardTo.OnPurchasesRetrievalFailed(jsonFailureDescription);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000226A File Offset: 0x0000046A
		public void OnPurchasesFetched(string json)
		{
			this.forwardTo.OnPurchasesFetched(json);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002278 File Offset: 0x00000478
		public void OnPurchaseSucceeded(string id, string receipt, string transactionID)
		{
			this.forwardTo.OnPurchaseSucceeded(id, receipt, transactionID);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002288 File Offset: 0x00000488
		public void OnPurchaseFailed(string json)
		{
			this.forwardTo.OnPurchaseFailed(json);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002296 File Offset: 0x00000496
		public void OnPurchaseDeferred(string json)
		{
			this.forwardTo.OnPurchaseDeferred(json);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000022A4 File Offset: 0x000004A4
		public void OnStoreConnectionSucceeded()
		{
			this.forwardTo.OnStoreConnectionSucceeded();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000022B1 File Offset: 0x000004B1
		public void OnStoreConnectionFailed(string jsonFailureDescription)
		{
			this.forwardTo.OnStoreConnectionFailed(jsonFailureDescription);
		}

		// Token: 0x04000004 RID: 4
		private readonly IUnityCallback forwardTo;
	}
}
