using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000243 RID: 579
	internal class EventDebuggerPathTrace : EventDebuggerTrace
	{
		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x000454C6 File Offset: 0x000436C6
		public PropagationPaths paths { get; }

		// Token: 0x0600118E RID: 4494 RVA: 0x000454CE File Offset: 0x000436CE
		public EventDebuggerPathTrace(IPanel panel, EventBase evt, PropagationPaths paths) : base(panel, evt, -1L, null)
		{
			this.paths = paths;
		}
	}
}
