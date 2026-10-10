using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000224 RID: 548
	public sealed class PointerLeaveEvent : PointerEventBase<PointerLeaveEvent>
	{
		// Token: 0x060010D3 RID: 4307 RVA: 0x0004315C File Offset: 0x0004135C
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x0004313F File Offset: 0x0004133F
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.IgnoreCompositeRoots);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x0004316D File Offset: 0x0004136D
		public PointerLeaveEvent()
		{
			this.LocalInit();
		}
	}
}
