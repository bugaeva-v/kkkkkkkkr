using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FF RID: 511
	public class MouseEnterWindowEvent : MouseEventBase<MouseEnterWindowEvent>
	{
		// Token: 0x06001007 RID: 4103 RVA: 0x00040D84 File Offset: 0x0003EF84
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00040D95 File Offset: 0x0003EF95
		private void LocalInit()
		{
			base.propagation = EventBase.EventPropagation.Cancellable;
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00040DA0 File Offset: 0x0003EFA0
		public MouseEnterWindowEvent()
		{
			this.LocalInit();
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00040DB4 File Offset: 0x0003EFB4
		protected internal override void PostDispatch(IPanel panel)
		{
			EventBase eventBase = ((IMouseEventInternal)this).sourcePointerEvent as EventBase;
			bool flag = eventBase == null;
			if (flag)
			{
				BaseVisualElementPanel baseVisualElementPanel = panel as BaseVisualElementPanel;
				if (baseVisualElementPanel != null)
				{
					baseVisualElementPanel.CommitElementUnderPointers();
				}
			}
			base.PostDispatch(panel);
		}
	}
}
