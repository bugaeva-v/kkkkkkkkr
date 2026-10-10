using System;
using System.Collections.Concurrent;

namespace NSubstitute.Core
{
	// Token: 0x02000064 RID: 100
	public class CallActions : ICallActions
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00005288 File Offset: 0x00003488
		public CallActions(ICallInfoFactory callInfoFactory)
		{
			this._callInfoFactory = callInfoFactory;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000052A2 File Offset: 0x000034A2
		public void Add(ICallSpecification callSpecification, Action<CallInfo> action)
		{
			this._actions.Enqueue(new CallActions.CallAction(callSpecification, action));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000052B6 File Offset: 0x000034B6
		public void Add(ICallSpecification callSpecification)
		{
			this.Add(callSpecification, CallActions.EmptyAction);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000052C4 File Offset: 0x000034C4
		public void MoveActionsForSpecToNewSpec(ICallSpecification oldCallSpecification, ICallSpecification newCallSpecification)
		{
			foreach (CallActions.CallAction callAction in this._actions)
			{
				if (callAction.IsFor(oldCallSpecification))
				{
					callAction.UpdateCallSpecification(newCallSpecification);
				}
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000531C File Offset: 0x0000351C
		public void Clear()
		{
			this._actions = new ConcurrentQueue<CallActions.CallAction>();
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000532C File Offset: 0x0000352C
		public void InvokeMatchingActions(ICall call)
		{
			if (this._actions.IsEmpty)
			{
				return;
			}
			CallInfo callInfo = null;
			foreach (CallActions.CallAction callAction in this._actions)
			{
				if (callAction.IsSatisfiedBy(call))
				{
					if (callInfo == null)
					{
						callInfo = this._callInfoFactory.Create(call);
					}
					callAction.Invoke(callInfo);
				}
			}
		}

		// Token: 0x04000078 RID: 120
		private static readonly Action<CallInfo> EmptyAction = delegate(CallInfo x)
		{
		};

		// Token: 0x04000079 RID: 121
		private readonly ICallInfoFactory _callInfoFactory;

		// Token: 0x0400007A RID: 122
		private ConcurrentQueue<CallActions.CallAction> _actions = new ConcurrentQueue<CallActions.CallAction>();

		// Token: 0x0200010E RID: 270
		private class CallAction
		{
			// Token: 0x0600043A RID: 1082 RVA: 0x00009BE4 File Offset: 0x00007DE4
			public CallAction(ICallSpecification callSpecification, Action<CallInfo> action)
			{
				this._callSpecification = callSpecification;
				this._action = action;
			}

			// Token: 0x0600043B RID: 1083 RVA: 0x00009BFA File Offset: 0x00007DFA
			public bool IsSatisfiedBy(ICall call)
			{
				return this._callSpecification.IsSatisfiedBy(call);
			}

			// Token: 0x0600043C RID: 1084 RVA: 0x00009C08 File Offset: 0x00007E08
			public void Invoke(CallInfo callInfo)
			{
				this._action(callInfo);
				this._callSpecification.InvokePerArgumentActions(callInfo);
			}

			// Token: 0x0600043D RID: 1085 RVA: 0x00009C22 File Offset: 0x00007E22
			public bool IsFor(ICallSpecification spec)
			{
				return this._callSpecification == spec;
			}

			// Token: 0x0600043E RID: 1086 RVA: 0x00009C2D File Offset: 0x00007E2D
			public void UpdateCallSpecification(ICallSpecification spec)
			{
				this._callSpecification = spec;
			}

			// Token: 0x04000140 RID: 320
			private ICallSpecification _callSpecification;

			// Token: 0x04000141 RID: 321
			private readonly Action<CallInfo> _action;
		}
	}
}
