using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003D RID: 61
	internal interface IWebRequestHelper
	{
		// Token: 0x06000193 RID: 403
		IWebRequest CreateWebRequest(string url, string method, byte[] postBytes);

		// Token: 0x06000194 RID: 404
		void SendWebRequest(IWebRequest request, Action<long> onCompleted);
	}
}
