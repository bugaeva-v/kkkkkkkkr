using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000210 RID: 528
	public abstract class PanelChangedEventBase<T> : EventBase<T>, IPanelChangedEvent where T : PanelChangedEventBase<T>, new()
	{
		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001036 RID: 4150 RVA: 0x000418F3 File Offset: 0x0003FAF3
		// (set) Token: 0x06001037 RID: 4151 RVA: 0x000418FB File Offset: 0x0003FAFB
		public IPanel originPanel { get; private set; }

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00041904 File Offset: 0x0003FB04
		// (set) Token: 0x06001039 RID: 4153 RVA: 0x0004190C File Offset: 0x0003FB0C
		public IPanel destinationPanel { get; private set; }

		// Token: 0x0600103A RID: 4154 RVA: 0x00041915 File Offset: 0x0003FB15
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00041926 File Offset: 0x0003FB26
		private void LocalInit()
		{
			this.originPanel = null;
			this.destinationPanel = null;
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x0004193C File Offset: 0x0003FB3C
		public static T GetPooled(IPanel originPanel, IPanel destinationPanel)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.originPanel = originPanel;
			pooled.destinationPanel = destinationPanel;
			return pooled;
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x0004196F File Offset: 0x0003FB6F
		protected PanelChangedEventBase()
		{
			this.LocalInit();
		}
	}
}
