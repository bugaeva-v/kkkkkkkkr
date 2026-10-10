using System;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Core.Analytics.Internal
{
	// Token: 0x02000026 RID: 38
	[RequireImplementors]
	public interface IAnalyticsUserId : IServiceComponent
	{
		// Token: 0x0600006A RID: 106
		string GetAnalyticsUserId();
	}
}
