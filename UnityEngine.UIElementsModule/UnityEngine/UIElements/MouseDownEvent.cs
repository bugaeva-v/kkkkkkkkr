using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F8 RID: 504
	public class MouseDownEvent : MouseEventBase<MouseDownEvent>
	{
		// Token: 0x06000FE4 RID: 4068 RVA: 0x00040A26 File Offset: 0x0003EC26
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00040A37 File Offset: 0x0003EC37
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00040A43 File Offset: 0x0003EC43
		public MouseDownEvent()
		{
			this.LocalInit();
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00040A54 File Offset: 0x0003EC54
		public new static MouseDownEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.PressButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseDownEvent>.GetPooled(systemEvent);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00040A88 File Offset: 0x0003EC88
		private static MouseDownEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			bool flag = pointerEvent != null && pointerEvent.button >= 0;
			if (flag)
			{
				PointerDeviceState.PressButton(PointerId.mousePointerId, pointerEvent.button);
			}
			return MouseEventBase<MouseDownEvent>.GetPooled(pointerEvent);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00040ACC File Offset: 0x0003ECCC
		internal static MouseDownEvent GetPooled(PointerDownEvent pointerEvent)
		{
			return MouseDownEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00040AE4 File Offset: 0x0003ECE4
		internal static MouseDownEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			return MouseDownEvent.MakeFromPointerEvent(pointerEvent);
		}
	}
}
