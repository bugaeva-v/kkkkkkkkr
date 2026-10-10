using System;

namespace Unity.Services.Analytics.Internal
{
	// Token: 0x0200003A RID: 58
	internal interface IPersistence
	{
		// Token: 0x06000183 RID: 387
		void SaveValue(string key, int value);

		// Token: 0x06000184 RID: 388
		void SaveValue(string key, string value);

		// Token: 0x06000185 RID: 389
		int LoadInt(string key);

		// Token: 0x06000186 RID: 390
		string LoadString(string key);

		// Token: 0x06000187 RID: 391
		void ClearValue(string key);
	}
}
