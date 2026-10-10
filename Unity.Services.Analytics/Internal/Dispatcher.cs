using System;
using UnityEngine;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x02000035 RID: 53
	internal class Dispatcher : IDispatcher, IDispatcherDebug
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00006207 File Offset: 0x00004407
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000620F File Offset: 0x0000440F
		public int ConsecutiveFailedUploadCount { get; private set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00006218 File Offset: 0x00004418
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00006220 File Offset: 0x00004420
		public bool FlushInProgress { get; private set; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x0600016C RID: 364 RVA: 0x0000622C File Offset: 0x0000442C
		// (remove) Token: 0x0600016D RID: 365 RVA: 0x00006264 File Offset: 0x00004464
		public event Action<byte[]> FlushStarted;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x0600016E RID: 366 RVA: 0x0000629C File Offset: 0x0000449C
		// (remove) Token: 0x0600016F RID: 367 RVA: 0x000062D4 File Offset: 0x000044D4
		public event Action<int, bool, bool, bool, bool, byte[]> FlushFinished;

		// Token: 0x06000170 RID: 368 RVA: 0x00006309 File Offset: 0x00004509
		public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl)
		{
			this.m_WebRequestHelper = webRequestHelper;
			this.m_CollectUrl = collectUrl;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000631F File Offset: 0x0000451F
		public void SetBuffer(IBuffer buffer)
		{
			this.m_DataBuffer = buffer;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00006328 File Offset: 0x00004528
		public void Flush()
		{
			if (this.FlushInProgress)
			{
				Debug.LogWarning("Analytics Dispatcher is already flushing.");
				return;
			}
			this.FlushBufferToService();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006344 File Offset: 0x00004544
		private void FlushBufferToService()
		{
			this.FlushInProgress = true;
			byte[] array = this.m_DataBuffer.Serialize();
			this.m_FlushBufferIndex = this.m_DataBuffer.Length;
			this.m_LastFlushPayload = array;
			if (array == null || array.Length == 0)
			{
				this.FlushInProgress = false;
				this.m_FlushBufferIndex = 0;
				return;
			}
			this.m_FlushRequest = this.m_WebRequestHelper.CreateWebRequest(this.m_CollectUrl, "POST", array);
			this.m_FlushRequest.SetRequestHeader("PIPL_EXPORT", "true");
			this.m_FlushRequest.SetRequestHeader("PIPL_CONSENT", "true");
			this.m_WebRequestHelper.SendWebRequest(this.m_FlushRequest, new Action<long>(this.UploadCompleted));
			if (this.FlushStarted != null)
			{
				this.FlushStarted(array);
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000640C File Offset: 0x0000460C
		private void UploadCompleted(long responseCode)
		{
			bool flag = responseCode >= 200L && responseCode <= 299L;
			bool flag2 = responseCode >= 400L && responseCode <= 499L;
			bool flag3 = (responseCode >= 500L && responseCode <= 599L) || this.m_FlushRequest.IsNetworkError;
			if (this.FlushFinished != null)
			{
				this.FlushFinished((int)responseCode, flag, flag2, flag3, this.m_FlushRequest.IsNetworkError, this.m_LastFlushPayload);
			}
			if (flag || flag2)
			{
				this.ConsecutiveFailedUploadCount = 0;
				this.m_DataBuffer.ClearBuffer((long)this.m_FlushBufferIndex);
				this.m_DataBuffer.ClearDiskCache();
			}
			else if (flag3)
			{
				int consecutiveFailedUploadCount = this.ConsecutiveFailedUploadCount;
				this.ConsecutiveFailedUploadCount = consecutiveFailedUploadCount + 1;
				this.m_DataBuffer.FlushToDisk();
			}
			this.FlushInProgress = false;
			this.m_FlushBufferIndex = 0;
			this.m_FlushRequest.Dispose();
			this.m_FlushRequest = null;
		}

		// Token: 0x040000BF RID: 191
		private readonly IWebRequestHelper m_WebRequestHelper;

		// Token: 0x040000C0 RID: 192
		private readonly string m_CollectUrl;

		// Token: 0x040000C1 RID: 193
		internal const string k_PiplConsentHeaderKey = "PIPL_CONSENT";

		// Token: 0x040000C2 RID: 194
		internal const string k_PiplExportHeaderKey = "PIPL_EXPORT";

		// Token: 0x040000C3 RID: 195
		internal const string k_HeaderTrueValue = "true";

		// Token: 0x040000C4 RID: 196
		private IBuffer m_DataBuffer;

		// Token: 0x040000C5 RID: 197
		private IWebRequest m_FlushRequest;

		// Token: 0x040000C6 RID: 198
		private byte[] m_LastFlushPayload;

		// Token: 0x040000C7 RID: 199
		private int m_FlushBufferIndex;
	}
}
