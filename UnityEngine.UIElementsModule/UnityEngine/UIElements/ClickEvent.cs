using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000222 RID: 546
	public sealed class ClickEvent : PointerEventBase<ClickEvent>
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x000430E8 File Offset: 0x000412E8
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00040A37 File Offset: 0x0003EC37
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000430F9 File Offset: 0x000412F9
		public ClickEvent()
		{
			this.LocalInit();
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0004310C File Offset: 0x0004130C
		internal static ClickEvent GetPooled(PointerUpEvent pointerEvent, int clickCount)
		{
			ClickEvent pooled = PointerEventBase<ClickEvent>.GetPooled(pointerEvent);
			pooled.clickCount = clickCount;
			return pooled;
		}
	}
}
