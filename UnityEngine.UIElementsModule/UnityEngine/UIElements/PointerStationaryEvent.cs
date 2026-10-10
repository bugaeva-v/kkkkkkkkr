using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200021F RID: 543
	public sealed class PointerStationaryEvent : PointerEventBase<PointerStationaryEvent>
	{
		// Token: 0x060010C1 RID: 4289 RVA: 0x00042EF8 File Offset: 0x000410F8
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x00042F09 File Offset: 0x00041109
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable);
			((IPointerEventInternal)this).triggeredByOS = true;
			((IPointerEventInternal)this).recomputeTopElementUnderPointer = true;
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x00042F24 File Offset: 0x00041124
		public PointerStationaryEvent()
		{
			this.LocalInit();
		}
	}
}
