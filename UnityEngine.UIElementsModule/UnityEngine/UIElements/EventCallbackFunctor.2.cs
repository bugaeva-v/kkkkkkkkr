using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020001D8 RID: 472
	internal class EventCallbackFunctor<TEventType, TCallbackArgs> : EventCallbackFunctorBase where TEventType : EventBase<TEventType>, new()
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0003E71D File Offset: 0x0003C91D
		// (set) Token: 0x06000F15 RID: 3861 RVA: 0x0003E725 File Offset: 0x0003C925
		internal TCallbackArgs userArgs { get; set; }

		// Token: 0x06000F16 RID: 3862 RVA: 0x0003E72E File Offset: 0x0003C92E
		public EventCallbackFunctor(EventCallback<TEventType, TCallbackArgs> callback, TCallbackArgs userArgs, CallbackPhase phase, InvokePolicy invokePolicy) : base(phase, invokePolicy)
		{
			this.userArgs = userArgs;
			this.m_Callback = callback;
			this.m_EventTypeId = EventBase<TEventType>.TypeId();
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x0003E758 File Offset: 0x0003C958
		public override void Invoke(EventBase evt, PropagationPhase propagationPhase)
		{
			bool flag = evt == null;
			if (flag)
			{
				throw new ArgumentNullException("evt");
			}
			bool flag2 = evt.eventTypeId != this.m_EventTypeId;
			if (!flag2)
			{
				bool flag3 = base.PhaseMatches(propagationPhase);
				if (flag3)
				{
					using (new EventDebuggerLogCall(this.m_Callback, evt))
					{
						this.m_Callback(evt as TEventType, this.userArgs);
					}
				}
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0003E7EC File Offset: 0x0003C9EC
		public override bool IsEquivalentTo(long eventTypeId, Delegate callback, CallbackPhase phase)
		{
			return this.m_EventTypeId == eventTypeId && this.m_Callback == callback && base.phase == phase;
		}

		// Token: 0x040006F4 RID: 1780
		private readonly EventCallback<TEventType, TCallbackArgs> m_Callback;

		// Token: 0x040006F5 RID: 1781
		private readonly long m_EventTypeId;
	}
}
