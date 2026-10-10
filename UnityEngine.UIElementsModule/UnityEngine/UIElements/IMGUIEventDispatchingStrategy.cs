using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001EA RID: 490
	internal class IMGUIEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000F6D RID: 3949 RVA: 0x0003F970 File Offset: 0x0003DB70
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt is IMGUIEvent;
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x0003F98C File Offset: 0x0003DB8C
		public void DispatchEvent(EventBase evt, IPanel panel)
		{
			bool flag = panel != null;
			if (flag)
			{
				EventDispatchUtilities.PropagateToIMGUIContainer(panel.visualTree, evt);
			}
			evt.propagateToIMGUI = false;
			evt.stopDispatch = true;
		}
	}
}
