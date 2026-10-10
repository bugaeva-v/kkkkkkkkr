using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D6 RID: 470
	internal abstract class EventCallbackFunctorBase
	{
		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06000F0B RID: 3851 RVA: 0x0003E5B7 File Offset: 0x0003C7B7
		public CallbackPhase phase { get; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x0003E5BF File Offset: 0x0003C7BF
		public InvokePolicy invokePolicy { get; }

		// Token: 0x06000F0D RID: 3853 RVA: 0x0003E5C7 File Offset: 0x0003C7C7
		protected EventCallbackFunctorBase(CallbackPhase phase, InvokePolicy invokePolicy)
		{
			this.phase = phase;
			this.invokePolicy = invokePolicy;
		}

		// Token: 0x06000F0E RID: 3854
		public abstract void Invoke(EventBase evt, PropagationPhase propagationPhase);

		// Token: 0x06000F0F RID: 3855
		public abstract bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase);

		// Token: 0x06000F10 RID: 3856 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		protected bool PhaseMatches(PropagationPhase propagationPhase)
		{
			CallbackPhase phase = this.phase;
			CallbackPhase callbackPhase = phase;
			if (callbackPhase != CallbackPhase.TargetAndBubbleUp)
			{
				if (callbackPhase == CallbackPhase.TrickleDownAndTarget)
				{
					bool flag = propagationPhase != PropagationPhase.TrickleDown && propagationPhase != PropagationPhase.AtTarget;
					if (flag)
					{
						return false;
					}
				}
			}
			else
			{
				bool flag2 = propagationPhase != PropagationPhase.AtTarget && propagationPhase != PropagationPhase.BubbleUp;
				if (flag2)
				{
					return false;
				}
			}
			return true;
		}
	}
}
