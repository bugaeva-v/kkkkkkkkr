using System;
using UnityEngine.Assertions;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F4 RID: 500
	internal class MouseEventDispatchingStrategy : IEventDispatchingStrategy
	{
		// Token: 0x06000FA3 RID: 4003 RVA: 0x00040074 File Offset: 0x0003E274
		public bool CanDispatchEvent(EventBase evt)
		{
			return evt is IMouseEvent;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00040090 File Offset: 0x0003E290
		public void DispatchEvent(EventBase evt, IPanel iPanel)
		{
			bool flag = iPanel != null;
			if (flag)
			{
				Assert.IsTrue(iPanel is BaseVisualElementPanel);
				BaseVisualElementPanel panel = (BaseVisualElementPanel)iPanel;
				MouseEventDispatchingStrategy.SetBestTargetForEvent(evt, panel);
				MouseEventDispatchingStrategy.SendEventToTarget(evt, panel);
			}
			evt.stopDispatch = true;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000400D8 File Offset: 0x0003E2D8
		private static bool SendEventToTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			return MouseEventDispatchingStrategy.SendEventToRegularTarget(evt, panel) || MouseEventDispatchingStrategy.SendEventToIMGUIContainer(evt, panel);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00040100 File Offset: 0x0003E300
		private static bool SendEventToRegularTarget(EventBase evt, BaseVisualElementPanel panel)
		{
			bool flag = evt.target == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				EventDispatchUtilities.PropagateEvent(evt);
				result = MouseEventDispatchingStrategy.IsDone(evt);
			}
			return result;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00040130 File Offset: 0x0003E330
		private static bool SendEventToIMGUIContainer(EventBase evt, BaseVisualElementPanel panel)
		{
			bool flag = evt.imguiEvent == null;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				IMGUIContainer rootIMGUIContainer = panel.rootIMGUIContainer;
				bool flag2 = rootIMGUIContainer == null;
				if (flag2)
				{
					result = false;
				}
				else
				{
					bool flag3 = evt.propagateToIMGUI || evt.eventTypeId == EventBase<MouseEnterWindowEvent>.TypeId() || evt.eventTypeId == EventBase<MouseLeaveWindowEvent>.TypeId();
					if (flag3)
					{
						evt.skipElements.Add(evt.target);
						EventDispatchUtilities.PropagateToIMGUIContainer(panel.visualTree, evt);
					}
					result = MouseEventDispatchingStrategy.IsDone(evt);
				}
			}
			return result;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000401B8 File Offset: 0x0003E3B8
		private static void SetBestTargetForEvent(EventBase evt, BaseVisualElementPanel panel)
		{
			VisualElement visualElement;
			MouseEventDispatchingStrategy.UpdateElementUnderMouse(evt, panel, out visualElement);
			bool flag = evt.target != null;
			if (flag)
			{
				evt.propagateToIMGUI = false;
			}
			else
			{
				bool flag2 = visualElement != null;
				if (flag2)
				{
					evt.propagateToIMGUI = false;
					evt.target = visualElement;
				}
				else
				{
					evt.target = ((panel != null) ? panel.visualTree : null);
				}
			}
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0004021C File Offset: 0x0003E41C
		private static void UpdateElementUnderMouse(EventBase evt, BaseVisualElementPanel panel, out VisualElement elementUnderMouse)
		{
			IMouseEventInternal mouseEventInternal = evt as IMouseEventInternal;
			elementUnderMouse = ((mouseEventInternal == null || mouseEventInternal.recomputeTopElementUnderMouse) ? panel.RecomputeTopElementUnderPointer(PointerId.mousePointerId, ((IMouseEvent)evt).mousePosition, evt) : panel.GetTopElementUnderPointer(PointerId.mousePointerId));
			bool flag = evt.eventTypeId == EventBase<MouseLeaveWindowEvent>.TypeId() && (evt as MouseLeaveWindowEvent).pressedButtons == 0;
			if (flag)
			{
				panel.ClearCachedElementUnderPointer(PointerId.mousePointerId, evt);
			}
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00040298 File Offset: 0x0003E498
		private static bool IsDone(EventBase evt)
		{
			Event imguiEvent = evt.imguiEvent;
			bool flag = imguiEvent != null && imguiEvent.rawType == EventType.Used;
			if (flag)
			{
				evt.StopPropagation();
			}
			return evt.isPropagationStopped;
		}
	}
}
