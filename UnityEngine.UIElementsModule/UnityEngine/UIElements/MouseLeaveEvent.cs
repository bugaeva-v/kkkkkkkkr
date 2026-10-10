using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FE RID: 510
	public class MouseLeaveEvent : MouseEventBase<MouseLeaveEvent>
	{
		// Token: 0x06001004 RID: 4100 RVA: 0x00040D62 File Offset: 0x0003EF62
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00040D45 File Offset: 0x0003EF45
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.IgnoreCompositeRoots);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00040D73 File Offset: 0x0003EF73
		public MouseLeaveEvent()
		{
			this.LocalInit();
		}
	}
}
