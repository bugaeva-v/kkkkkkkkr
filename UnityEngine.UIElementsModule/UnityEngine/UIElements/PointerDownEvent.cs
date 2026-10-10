using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021D RID: 541
	public sealed class PointerDownEvent : PointerEventBase<PointerDownEvent>
	{
		// Token: 0x060010B7 RID: 4279 RVA: 0x00042CA7 File Offset: 0x00040EA7
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x00042CB8 File Offset: 0x00040EB8
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
			((IPointerEventInternal)this).triggeredByOS = true;
			((IPointerEventInternal)this).recomputeTopElementUnderPointer = true;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00042CD4 File Offset: 0x00040ED4
		public PointerDownEvent()
		{
			this.LocalInit();
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00042CE8 File Offset: 0x00040EE8
		protected internal override void PostDispatch(IPanel panel)
		{
			bool flag = !base.isDefaultPrevented;
			if (flag)
			{
				bool flag2 = panel.ShouldSendCompatibilityMouseEvents(this);
				if (flag2)
				{
					using (MouseDownEvent pooled = MouseDownEvent.GetPooled(this))
					{
						pooled.target = base.target;
						pooled.target.SendEvent(pooled);
					}
				}
			}
			else
			{
				panel.PreventCompatibilityMouseEvents(base.pointerId);
			}
			base.PostDispatch(panel);
		}
	}
}
