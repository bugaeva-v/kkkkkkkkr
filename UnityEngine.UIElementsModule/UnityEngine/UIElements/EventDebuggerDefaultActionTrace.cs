using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000242 RID: 578
	internal class EventDebuggerDefaultActionTrace : EventDebuggerTrace
	{
		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x0004547E File Offset: 0x0004367E
		public PropagationPhase phase { get; }

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00045488 File Offset: 0x00043688
		public string targetName
		{
			get
			{
				return base.eventBase.target.GetType().FullName;
			}
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x000454AF File Offset: 0x000436AF
		public EventDebuggerDefaultActionTrace(IPanel panel, EventBase evt, PropagationPhase phase, long duration, IEventHandler mouseCapture) : base(panel, evt, duration, mouseCapture)
		{
			this.phase = phase;
		}
	}
}
