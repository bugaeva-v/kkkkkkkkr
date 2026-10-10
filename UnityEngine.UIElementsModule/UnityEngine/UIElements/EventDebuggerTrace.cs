using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000240 RID: 576
	internal class EventDebuggerTrace
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x000453A6 File Offset: 0x000435A6
		public EventDebuggerEventRecord eventBase { get; }

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000453AE File Offset: 0x000435AE
		public IEventHandler focusedElement { get; }

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x000453B6 File Offset: 0x000435B6
		public IEventHandler mouseCapture { get; }

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x000453BE File Offset: 0x000435BE
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x000453C6 File Offset: 0x000435C6
		public long duration { get; set; }

		// Token: 0x06001183 RID: 4483 RVA: 0x000453D0 File Offset: 0x000435D0
		public EventDebuggerTrace(IPanel panel, EventBase evt, long duration, IEventHandler mouseCapture)
		{
			this.eventBase = new EventDebuggerEventRecord(evt);
			object obj;
			if (panel == null)
			{
				obj = null;
			}
			else
			{
				FocusController focusController = panel.focusController;
				obj = ((focusController != null) ? focusController.focusedElement : null);
			}
			this.focusedElement = obj;
			this.mouseCapture = mouseCapture;
			this.duration = duration;
		}
	}
}
