using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000206 RID: 518
	internal class NavigationEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x0600101F RID: 4127 RVA: 0x00041694 File Offset: 0x0003F894
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt is INavigationEvent;
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x000416B0 File Offset: 0x0003F8B0
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			bool flag = panel != null;
			if (flag)
			{
				evt.target = (panel.focusController.GetLeafFocusedElement() ?? panel.visualTree);
				EventDispatchUtilities.PropagateEvent(evt);
			}
			evt.propagateToIMGUI = false;
			evt.stopDispatch = true;
		}
	}
}
