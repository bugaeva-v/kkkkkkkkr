using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001E5 RID: 485
	public class FocusInEvent : FocusEventBase<FocusInEvent>
	{
		// Token: 0x06000F63 RID: 3939 RVA: 0x0003F4F3 File Offset: 0x0003D6F3
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x0003F499 File Offset: 0x0003D699
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x0003F504 File Offset: 0x0003D704
		public FocusInEvent()
		{
			this.LocalInit();
		}
	}
}
