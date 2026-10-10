using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000221 RID: 545
	public sealed class PointerCancelEvent : PointerEventBase<PointerCancelEvent>
	{
		// Token: 0x060010C8 RID: 4296 RVA: 0x00043000 File Offset: 0x00041200
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x00043011 File Offset: 0x00041211
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.SkipDisabledElements);
			((IPointerEventInternal)this).triggeredByOS = true;
			((IPointerEventInternal)this).recomputeTopElementUnderPointer = true;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x0004302D File Offset: 0x0004122D
		public PointerCancelEvent()
		{
			this.LocalInit();
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x00043040 File Offset: 0x00041240
		protected internal override void PostDispatch(IPanel panel)
		{
			bool flag = PointerType.IsDirectManipulationDevice(base.pointerType);
			if (flag)
			{
				panel.ReleasePointer(base.pointerId);
				BaseVisualElementPanel baseVisualElementPanel = panel as BaseVisualElementPanel;
				if (baseVisualElementPanel != null)
				{
					baseVisualElementPanel.ClearCachedElementUnderPointer(base.pointerId, this);
				}
			}
			bool flag2 = panel.ShouldSendCompatibilityMouseEvents(this);
			if (flag2)
			{
				using (MouseUpEvent pooled = MouseUpEvent.GetPooled(this))
				{
					pooled.target = base.target;
					base.target.SendEvent(pooled);
				}
			}
			base.PostDispatch(panel);
			panel.ActivateCompatibilityMouseEvents(base.pointerId);
		}
	}
}
