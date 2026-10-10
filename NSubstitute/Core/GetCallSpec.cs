using System;

namespace NSubstitute.Core
{
	// Token: 0x0200007A RID: 122
	public class GetCallSpec : IGetCallSpec
	{
		// Token: 0x060001D3 RID: 467 RVA: 0x000067BF File Offset: 0x000049BF
		public GetCallSpec(ICallCollection receivedCalls, ICallSpecificationFactory callSpecificationFactory, ICallActions callActions)
		{
			this._receivedCalls = receivedCalls;
			this._callSpecificationFactory = callSpecificationFactory;
			this._callActions = callActions;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000067DC File Offset: 0x000049DC
		public ICallSpecification FromPendingSpecification(MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo)
		{
			return pendingSpecInfo.Handle<ICallSpecification>((ICallSpecification callSpec) => this.FromExistingSpec(callSpec, matchArgs), delegate(ICall lastCall)
			{
				this._receivedCalls.Delete(lastCall);
				return this.FromCall(lastCall, matchArgs);
			});
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000681B File Offset: 0x00004A1B
		public ICallSpecification FromCall(ICall call, MatchArgs matchArgs)
		{
			return this._callSpecificationFactory.CreateFrom(call, matchArgs);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000682A File Offset: 0x00004A2A
		public ICallSpecification FromExistingSpec(ICallSpecification spec, MatchArgs matchArgs)
		{
			if (matchArgs != MatchArgs.AsSpecifiedInCall)
			{
				return this.UpdateCallSpecToMatchAnyArgs(spec);
			}
			return spec;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00006840 File Offset: 0x00004A40
		private ICallSpecification UpdateCallSpecToMatchAnyArgs(ICallSpecification callSpecification)
		{
			ICallSpecification callSpecification2 = callSpecification.CreateCopyThatMatchesAnyArguments();
			this._callActions.MoveActionsForSpecToNewSpec(callSpecification, callSpecification2);
			return callSpecification2;
		}

		// Token: 0x0400009D RID: 157
		private readonly ICallCollection _receivedCalls;

		// Token: 0x0400009E RID: 158
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x0400009F RID: 159
		private readonly ICallActions _callActions;
	}
}
