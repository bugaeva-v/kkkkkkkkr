using System;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022A RID: 554
	public class TooltipEvent : EventBase<TooltipEvent>
	{
		// Token: 0x170003AF RID: 943
		// (get) Token: 0x060010E0 RID: 4320 RVA: 0x000433AE File Offset: 0x000415AE
		// (set) Token: 0x060010E1 RID: 4321 RVA: 0x000433B6 File Offset: 0x000415B6
		public string tooltip { get; set; }

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x060010E2 RID: 4322 RVA: 0x000433BF File Offset: 0x000415BF
		// (set) Token: 0x060010E3 RID: 4323 RVA: 0x000433C7 File Offset: 0x000415C7
		public Rect rect { get; set; }

		// Token: 0x060010E4 RID: 4324 RVA: 0x000433D0 File Offset: 0x000415D0
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x000433E4 File Offset: 0x000415E4
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown);
			this.rect = default(Rect);
			this.tooltip = string.Empty;
			base.ignoreCompositeRoots = true;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00043420 File Offset: 0x00041620
		internal static TooltipEvent GetPooled(string tooltip, Rect rect)
		{
			TooltipEvent pooled = EventBase<TooltipEvent>.GetPooled();
			pooled.tooltip = tooltip;
			pooled.rect = rect;
			return pooled;
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00043449 File Offset: 0x00041649
		public TooltipEvent()
		{
			this.LocalInit();
		}
	}
}
