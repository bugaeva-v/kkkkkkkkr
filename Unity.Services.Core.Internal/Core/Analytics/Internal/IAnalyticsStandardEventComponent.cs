using System;
using System.Collections.Generic;
using Unity.Services.Core.Internal;
using UnityEngine.Scripting;

namespace Unity.Services.Core.Analytics.Internal
{
	// Token: 0x02000025 RID: 37
	[RequireImplementors]
	public interface IAnalyticsStandardEventComponent : IServiceComponent
	{
		// Token: 0x06000069 RID: 105
		void Record(string eventName, IDictionary<string, object> eventParameters, int eventVersion, string packageName);
	}
}
