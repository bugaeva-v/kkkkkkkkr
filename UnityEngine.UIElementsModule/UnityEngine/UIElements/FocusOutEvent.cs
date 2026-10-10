using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E3 RID: 483
	public class FocusOutEvent : FocusEventBase<FocusOutEvent>
	{
		// Token: 0x06000F5E RID: 3934 RVA: 0x0003F488 File Offset: 0x0003D688
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x0003F499 File Offset: 0x0003D699
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x0003F4A4 File Offset: 0x0003D6A4
		public FocusOutEvent()
		{
			this.LocalInit();
		}
	}
}
