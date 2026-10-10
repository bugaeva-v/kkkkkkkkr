using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000A01 RID: 2561
	public class PollingCounter : DiagnosticCounter
	{
		// Token: 0x06005B4D RID: 23373 RVA: 0x0013445C File Offset: 0x0013265C
		public PollingCounter(string name, EventSource eventSource, Func<double> metricProvider) : base(name, eventSource)
		{
		}
	}
}
