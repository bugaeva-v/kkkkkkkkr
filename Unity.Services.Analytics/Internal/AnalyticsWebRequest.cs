using System;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003E RID: 62
	internal class AnalyticsWebRequest : UnityWebRequest, IWebRequest, IDisposable
	{
		// Token: 0x06000195 RID: 405 RVA: 0x0000654E File Offset: 0x0000474E
		internal AnalyticsWebRequest(string url, string method) : base(url, method)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00006558 File Offset: 0x00004758
		public bool IsNetworkError
		{
			get
			{
				return base.result == UnityWebRequest.Result.ConnectionError;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00006563 File Offset: 0x00004763
		UnityWebRequestAsyncOperation IWebRequest.SendWebRequest()
		{
			return base.SendWebRequest();
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000656B File Offset: 0x0000476B
		UploadHandler IWebRequest.get_uploadHandler()
		{
			return base.uploadHandler;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00006573 File Offset: 0x00004773
		void IWebRequest.set_uploadHandler(UploadHandler value)
		{
			base.uploadHandler = value;
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000657C File Offset: 0x0000477C
		void IWebRequest.SetRequestHeader(string key, string value)
		{
			base.SetRequestHeader(key, value);
		}
	}
}
