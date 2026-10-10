using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001CE RID: 462
	internal class DefaultDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003D3C4 File Offset: 0x0003B5C4
		public bool CanDispatchEvent(EventBase evt)
		{
			return !(evt is IMGUIEvent);
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0003D3E4 File Offset: 0x0003B5E4
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			bool flag = evt.target != null;
			if (flag)
			{
				evt.propagateToIMGUI = (evt.target is IMGUIContainer);
				EventDispatchUtilities.PropagateEvent(evt);
			}
			else
			{
				bool flag2 = !evt.isPropagationStopped && panel != null;
				if (flag2)
				{
					bool flag3 = evt.propagateToIMGUI || evt.eventTypeId == EventBase<MouseEnterWindowEvent>.TypeId() || evt.eventTypeId == EventBase<MouseLeaveWindowEvent>.TypeId();
					if (flag3)
					{
						EventDispatchUtilities.PropagateToIMGUIContainer(panel.visualTree, evt);
					}
				}
			}
			evt.stopDispatch = true;
		}
	}
}
