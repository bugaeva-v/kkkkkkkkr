using System;
using System.Runtime.CompilerServices;
using Unity.Services.Analytics;
using Unity.Services.Core;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000007 RID: 7
	[Preserve]
	internal class AnalyticsServiceWrapper : IAnalyticsServiceWrapper
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002178 File Offset: 0x00000378
		[NullableContext(2)]
		public IAnalyticsService AnalyticsServiceInstance()
		{
			IAnalyticsService result;
			try
			{
				result = AnalyticsService.Instance;
			}
			catch (ServicesInitializationException ex)
			{
				Debug.Log("Unity Purchasing: Failed to initialize Unity Analytics. " + ex.Message + " Disabling analytics.");
				result = null;
			}
			return result;
		}
	}
}
