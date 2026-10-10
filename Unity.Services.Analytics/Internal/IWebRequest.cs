using System;
using UnityEngine.Networking;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003C RID: 60
	internal interface IWebRequest : IDisposable
	{
		// Token: 0x0600018E RID: 398
		UnityWebRequestAsyncOperation SendWebRequest();

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600018F RID: 399
		// (set) Token: 0x06000190 RID: 400
		UploadHandler uploadHandler { get; set; }

		// Token: 0x06000191 RID: 401
		void SetRequestHeader(string key, string value);

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000192 RID: 402
		bool IsNetworkError { get; }
	}
}
