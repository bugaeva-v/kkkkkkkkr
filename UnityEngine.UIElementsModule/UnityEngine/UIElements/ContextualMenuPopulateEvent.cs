using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000203 RID: 515
	public class ContextualMenuPopulateEvent : MouseEventBase<ContextualMenuPopulateEvent>
	{
		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00040EA4 File Offset: 0x0003F0A4
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00040EAC File Offset: 0x0003F0AC
		public DropdownMenu menu { get; private set; }

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x00040EB5 File Offset: 0x0003F0B5
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00040EBD File Offset: 0x0003F0BD
		public EventBase triggerEvent { get; private set; }

		// Token: 0x06001016 RID: 4118 RVA: 0x00040EC8 File Offset: 0x0003F0C8
		public static ContextualMenuPopulateEvent GetPooled(EventBase triggerEvent, DropdownMenu menu, IEventHandler target, ContextualMenuManager menuManager)
		{
			ContextualMenuPopulateEvent pooled = EventBase<ContextualMenuPopulateEvent>.GetPooled(triggerEvent);
			bool flag = triggerEvent != null;
			if (flag)
			{
				triggerEvent.Acquire();
				pooled.triggerEvent = triggerEvent;
				IMouseEvent mouseEvent = triggerEvent as IMouseEvent;
				bool flag2 = mouseEvent != null;
				if (flag2)
				{
					pooled.modifiers = mouseEvent.modifiers;
					pooled.mousePosition = mouseEvent.mousePosition;
					pooled.localMousePosition = mouseEvent.mousePosition;
					pooled.mouseDelta = mouseEvent.mouseDelta;
					pooled.button = mouseEvent.button;
					pooled.clickCount = mouseEvent.clickCount;
				}
				else
				{
					IPointerEvent pointerEvent = triggerEvent as IPointerEvent;
					bool flag3 = pointerEvent != null;
					if (flag3)
					{
						pooled.modifiers = pointerEvent.modifiers;
						pooled.mousePosition = pointerEvent.position;
						pooled.localMousePosition = pointerEvent.position;
						pooled.mouseDelta = pointerEvent.deltaPosition;
						pooled.button = pointerEvent.button;
						pooled.clickCount = pointerEvent.clickCount;
					}
				}
				IMouseEventInternal mouseEventInternal = triggerEvent as IMouseEventInternal;
				bool flag4 = mouseEventInternal != null;
				if (flag4)
				{
					((IMouseEventInternal)pooled).triggeredByOS = mouseEventInternal.triggeredByOS;
				}
				else
				{
					IPointerEventInternal pointerEventInternal = triggerEvent as IPointerEventInternal;
					bool flag5 = pointerEventInternal != null;
					if (flag5)
					{
						((IMouseEventInternal)pooled).triggeredByOS = pointerEventInternal.triggeredByOS;
					}
				}
			}
			pooled.target = target;
			pooled.menu = menu;
			pooled.m_ContextualMenuManager = menuManager;
			return pooled;
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0004103B File Offset: 0x0003F23B
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x0004104C File Offset: 0x0003F24C
		private void LocalInit()
		{
			this.menu = null;
			this.m_ContextualMenuManager = null;
			bool flag = this.triggerEvent != null;
			if (flag)
			{
				this.triggerEvent.Dispose();
				this.triggerEvent = null;
			}
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x0004108C File Offset: 0x0003F28C
		public ContextualMenuPopulateEvent()
		{
			this.LocalInit();
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x000410A0 File Offset: 0x0003F2A0
		protected internal override void PostDispatch(IPanel panel)
		{
			bool flag = !base.isDefaultPrevented && this.m_ContextualMenuManager != null;
			if (flag)
			{
				this.menu.PrepareForDisplay(this.triggerEvent);
				this.m_ContextualMenuManager.DoDisplayMenu(this.menu, this.triggerEvent);
			}
			base.PostDispatch(panel);
		}

		// Token: 0x0400072D RID: 1837
		private ContextualMenuManager m_ContextualMenuManager;
	}
}
