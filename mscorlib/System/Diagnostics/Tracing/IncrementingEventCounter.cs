using System;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020009FF RID: 2559
	public class IncrementingEventCounter : DiagnosticCounter
	{
		// Token: 0x06005B46 RID: 23366 RVA: 0x0013445C File Offset: 0x0013265C
		public IncrementingEventCounter(string name, EventSource eventSource) : base(name, eventSource)
		{
		}

		// Token: 0x06005B47 RID: 23367 RVA: 0x00004BF9 File Offset: 0x00002DF9
		public void Increment(double increment = 1.0)
		{
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06005B48 RID: 23368 RVA: 0x0013491B File Offset: 0x00132B1B
		// (set) Token: 0x06005B49 RID: 23369 RVA: 0x00134923 File Offset: 0x00132B23
		public TimeSpan DisplayRateTimeScale { get; set; }
	}
}
