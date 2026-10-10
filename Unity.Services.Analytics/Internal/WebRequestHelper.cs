using System;
using UnityEngine;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003F RID: 63
	internal class WebRequestHelper : IWebRequestHelper
	{
		// Token: 0x0600019B RID: 411 RVA: 0x00006588 File Offset: 0x00004788
		public IWebRequest CreateWebRequest(string url, string method, byte[] postBytes)
		{
			AnalyticsWebRequest analyticsWebRequest = new AnalyticsWebRequest(url, method);
			UploadHandlerRaw uploadHandler = new UploadHandlerRaw(postBytes)
			{
				contentType = "application/json"
			};
			analyticsWebRequest.uploadHandler = uploadHandler;
			analyticsWebRequest.SetRequestHeader("x-client-id", this.k_ClientIdHeaderValue);
			return analyticsWebRequest;
		}

		// Token: 0x0600019C RID: 412 RVA: 0x000065C8 File Offset: 0x000047C8
		public void SendWebRequest(IWebRequest request, Action<long> onCompleted)
		{
			UnityWebRequestAsyncOperation requestOp = request.SendWebRequest();
			requestOp.completed += delegate(AsyncOperation <p0>)
			{
				onCompleted(requestOp.webRequest.responseCode);
			};
		}

		// Token: 0x040000CC RID: 204
		private readonly string k_ClientIdHeaderValue = "com.unity.services.analytics@" + SdkVersion.SDK_VERSION;
	}
}
