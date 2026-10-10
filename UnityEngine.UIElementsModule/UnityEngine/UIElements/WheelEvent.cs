using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FC RID: 508
	public class WheelEvent : MouseEventBase<WheelEvent>
	{
		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000FF9 RID: 4089 RVA: 0x00040C55 File Offset: 0x0003EE55
		// (set) Token: 0x06000FFA RID: 4090 RVA: 0x00040C5D File Offset: 0x0003EE5D
		public Vector3 delta { get; private set; }

		// Token: 0x06000FFB RID: 4091 RVA: 0x00040C68 File Offset: 0x0003EE68
		public new static WheelEvent GetPooled(Event systemEvent)
		{
			WheelEvent pooled = MouseEventBase<WheelEvent>.GetPooled(systemEvent);
			pooled.imguiEvent = systemEvent;
			bool flag = systemEvent != null;
			if (flag)
			{
				pooled.delta = systemEvent.delta;
			}
			return pooled;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00040CA8 File Offset: 0x0003EEA8
		internal static WheelEvent GetPooled(Vector3 delta, Vector3 mousePosition)
		{
			WheelEvent pooled = EventBase<WheelEvent>.GetPooled();
			pooled.delta = delta;
			pooled.mousePosition = mousePosition;
			return pooled;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00040CD8 File Offset: 0x0003EED8
		internal static WheelEvent GetPooled(Vector3 delta, IPointerEvent pointerEvent)
		{
			WheelEvent pooled = MouseEventBase<WheelEvent>.GetPooled(pointerEvent);
			pooled.delta = delta;
			return pooled;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00040CFA File Offset: 0x0003EEFA
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00040D0B File Offset: 0x0003EF0B
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
			this.delta = Vector3.zero;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00040D23 File Offset: 0x0003EF23
		public WheelEvent()
		{
			this.LocalInit();
		}
	}
}
