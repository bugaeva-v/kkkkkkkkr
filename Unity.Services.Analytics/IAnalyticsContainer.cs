using System;

namespace Unity.Services.Analytics
{
	// Token: 0x02000019 RID: 25
	internal interface IAnalyticsContainer
	{
		// Token: 0x06000092 RID: 146
		void Initialize(AnalyticsServiceInstance service);

		// Token: 0x06000093 RID: 147
		void Enable();

		// Token: 0x06000094 RID: 148
		void Disable();
	}
}
