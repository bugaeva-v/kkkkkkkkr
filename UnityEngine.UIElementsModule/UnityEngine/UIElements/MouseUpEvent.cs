using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F9 RID: 505
	public class MouseUpEvent : MouseEventBase<MouseUpEvent>
	{
		// Token: 0x06000FEB RID: 4075 RVA: 0x00040AFC File Offset: 0x0003ECFC
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00040A37 File Offset: 0x0003EC37
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00040B0D File Offset: 0x0003ED0D
		public MouseUpEvent()
		{
			this.LocalInit();
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00040B20 File Offset: 0x0003ED20
		public new static MouseUpEvent GetPooled(Event systemEvent)
		{
			bool flag = systemEvent != null;
			if (flag)
			{
				PointerDeviceState.ReleaseButton(PointerId.mousePointerId, systemEvent.button);
			}
			return MouseEventBase<MouseUpEvent>.GetPooled(systemEvent);
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00040B54 File Offset: 0x0003ED54
		private static MouseUpEvent MakeFromPointerEvent(IPointerEvent pointerEvent)
		{
			bool flag = pointerEvent != null && pointerEvent.button >= 0;
			if (flag)
			{
				PointerDeviceState.ReleaseButton(PointerId.mousePointerId, pointerEvent.button);
			}
			return MouseEventBase<MouseUpEvent>.GetPooled(pointerEvent);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00040B98 File Offset: 0x0003ED98
		internal static MouseUpEvent GetPooled(PointerUpEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00040BB0 File Offset: 0x0003EDB0
		internal static MouseUpEvent GetPooled(PointerMoveEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00040BC8 File Offset: 0x0003EDC8
		internal static MouseUpEvent GetPooled(PointerCancelEvent pointerEvent)
		{
			return MouseUpEvent.MakeFromPointerEvent(pointerEvent);
		}
	}
}
