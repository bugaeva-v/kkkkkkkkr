using System;
using System.Runtime.CompilerServices;
using Unity.Services.Analytics;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000009 RID: 9
	[NullableContext(2)]
	internal interface IAnalyticsServiceWrapper
	{
		// Token: 0x06000015 RID: 21
		IAnalyticsService AnalyticsServiceInstance();
	}
}
