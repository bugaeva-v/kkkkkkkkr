using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000241 RID: 577
	internal class EventDebuggerCallTrace : EventDebuggerTrace
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x0004541F File Offset: 0x0004361F
		public int callbackHashCode { get; }

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00045427 File Offset: 0x00043627
		public string callbackName { get; }

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x0004542F File Offset: 0x0004362F
		public bool propagationHasStopped { get; }

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00045437 File Offset: 0x00043637
		public bool immediatePropagationHasStopped { get; }

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x0004543F File Offset: 0x0004363F
		public bool defaultHasBeenPrevented { get; }

		// Token: 0x06001189 RID: 4489 RVA: 0x00045447 File Offset: 0x00043647
		public EventDebuggerCallTrace(IPanel panel, EventBase evt, int cbHashCode, string cbName, bool propagationHasStopped, bool immediatePropagationHasStopped, bool defaultHasBeenPrevented, long duration, IEventHandler mouseCapture) : base(panel, evt, duration, mouseCapture)
		{
			this.callbackHashCode = cbHashCode;
			this.callbackName = cbName;
			this.propagationHasStopped = propagationHasStopped;
			this.immediatePropagationHasStopped = immediatePropagationHasStopped;
			this.defaultHasBeenPrevented = defaultHasBeenPrevented;
		}
	}
}
