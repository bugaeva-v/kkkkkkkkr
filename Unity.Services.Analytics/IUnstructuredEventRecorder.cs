using System;
using System.Collections.Generic;

namespace Unity.Services.Analytics
{
	// Token: 0x02000006 RID: 6
	internal interface IUnstructuredEventRecorder
	{
		// Token: 0x0600000F RID: 15
		void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool isStandardEvent, string callingMethodIdentifier);
	}
}
