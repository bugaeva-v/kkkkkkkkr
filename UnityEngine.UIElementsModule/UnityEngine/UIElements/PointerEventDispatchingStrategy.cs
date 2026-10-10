using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000217 RID: 535
	internal class PointerEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x00041E5C File Offset: 0x0004005C
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt is IPointerEvent;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00041E77 File Offset: 0x00040077
		public virtual void DispatchEvent(EventBase evt, IPanel panel)
		{
			PointerEventDispatchingStrategy.SetBestTargetForEvent(evt, panel);
			PointerEventDispatchingStrategy.SendEventToTarget(evt);
			evt.stopDispatch = true;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00041E94 File Offset: 0x00040094
		private static void SendEventToTarget(EventBase evt)
		{
			bool flag = evt.target != null;
			if (flag)
			{
				EventDispatchUtilities.PropagateEvent(evt);
			}
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00041EB8 File Offset: 0x000400B8
		private static void SetBestTargetForEvent(EventBase evt, IPanel panel)
		{
			VisualElement visualElement;
			PointerEventDispatchingStrategy.UpdateElementUnderPointer(evt, panel, out visualElement);
			bool flag = evt.target == null && visualElement != null;
			if (flag)
			{
				evt.propagateToIMGUI = false;
				evt.target = visualElement;
			}
			else
			{
				bool flag2 = evt.target == null && visualElement == null;
				if (flag2)
				{
					bool flag3 = panel != null && panel.contextType == ContextType.Editor && evt.eventTypeId == EventBase<PointerUpEvent>.TypeId();
					if (flag3)
					{
						Panel panel2 = panel as Panel;
						evt.target = ((panel2 != null) ? panel2.rootIMGUIContainer : null);
					}
					else
					{
						evt.target = ((panel != null) ? panel.visualTree : null);
					}
				}
				else
				{
					bool flag4 = evt.target != null;
					if (flag4)
					{
						evt.propagateToIMGUI = false;
					}
				}
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00041F78 File Offset: 0x00040178
		private static void UpdateElementUnderPointer(EventBase evt, IPanel panel, out VisualElement elementUnderPointer)
		{
			IPointerEvent pointerEvent = evt as IPointerEvent;
			BaseVisualElementPanel baseVisualElementPanel = panel as BaseVisualElementPanel;
			IPointerEventInternal pointerEventInternal = evt as IPointerEventInternal;
			elementUnderPointer = ((pointerEventInternal == null || pointerEventInternal.recomputeTopElementUnderPointer) ? ((baseVisualElementPanel != null) ? baseVisualElementPanel.RecomputeTopElementUnderPointer(pointerEvent.pointerId, pointerEvent.position, evt) : null) : ((baseVisualElementPanel != null) ? baseVisualElementPanel.GetTopElementUnderPointer(pointerEvent.pointerId) : null));
		}
	}
}
