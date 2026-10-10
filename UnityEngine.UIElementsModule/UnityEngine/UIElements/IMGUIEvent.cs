using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000233 RID: 563
	public class IMGUIEvent : EventBase<IMGUIEvent>
	{
		// Token: 0x06001101 RID: 4353 RVA: 0x0004366C File Offset: 0x0004186C
		public static IMGUIEvent GetPooled(Event systemEvent)
		{
			IMGUIEvent pooled = EventBase<IMGUIEvent>.GetPooled();
			pooled.imguiEvent = systemEvent;
			return pooled;
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x0004368D File Offset: 0x0004188D
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00040BF1 File Offset: 0x0003EDF1
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0004369E File Offset: 0x0004189E
		public IMGUIEvent()
		{
			this.LocalInit();
		}
	}
}
