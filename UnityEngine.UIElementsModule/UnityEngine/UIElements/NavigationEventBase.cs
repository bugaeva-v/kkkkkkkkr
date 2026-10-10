using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000208 RID: 520
	public abstract class NavigationEventBase<T> : EventBase<T>, INavigationEvent where T : NavigationEventBase<T>, new()
	{
		// Token: 0x06001022 RID: 4130 RVA: 0x000416FB File Offset: 0x0003F8FB
		protected NavigationEventBase()
		{
			this.LocalInit();
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x0004170C File Offset: 0x0003F90C
		protected override void Init()
		{
			base.Init();
			this.LocalInit();
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x0004171D File Offset: 0x0003F91D
		private void LocalInit()
		{
			base.propagation = (EventBase.EventPropagation.Bubbles | EventBase.EventPropagation.TricklesDown | EventBase.EventPropagation.Cancellable | EventBase.EventPropagation.SkipDisabledElements);
			base.propagateToIMGUI = false;
		}
	}
}
