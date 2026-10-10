using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001BF RID: 447
	public abstract class PointerCaptureEventBase<T> : EventBase<T>, IPointerCaptureEvent, IPointerCaptureEventInternal where T : PointerCaptureEventBase<T>, new()
	{
		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000E7C RID: 3708 RVA: 0x0003CFF9 File Offset: 0x0003B1F9
		// (set) Token: 0x06000E7D RID: 3709 RVA: 0x0003D001 File Offset: 0x0003B201
		public IEventHandler relatedTarget { get; private set; }

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E7E RID: 3710 RVA: 0x0003D00A File Offset: 0x0003B20A
		// (set) Token: 0x06000E7F RID: 3711 RVA: 0x0003D012 File Offset: 0x0003B212
		public int pointerId { get; private set; }

		// Token: 0x06000E80 RID: 3712 RVA: 0x0003D01B File Offset: 0x0003B21B
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x0003D02C File Offset: 0x0003B22C
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
			this.relatedTarget = null;
			this.pointerId = PointerId.invalidPointerId;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x0003D04C File Offset: 0x0003B24C
		public static T GetPooled(IEventHandler target, IEventHandler relatedTarget, int pointerId)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.target = target;
			pooled.relatedTarget = relatedTarget;
			pooled.pointerId = pointerId;
			return pooled;
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x0003D08C File Offset: 0x0003B28C
		protected PointerCaptureEventBase()
		{
			this.LocalInit();
		}
	}
}
