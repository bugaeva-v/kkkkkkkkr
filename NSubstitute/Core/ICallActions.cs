using System;

namespace NSubstitute.Core
{
	// Token: 0x0200007D RID: 125
	public interface ICallActions
	{
		// Token: 0x060001E5 RID: 485
		void Add(ICallSpecification callSpecification, Action<CallInfo> action);

		// Token: 0x060001E6 RID: 486
		void Add(ICallSpecification callSpec);

		// Token: 0x060001E7 RID: 487
		void InvokeMatchingActions(ICall callInfo);

		// Token: 0x060001E8 RID: 488
		void MoveActionsForSpecToNewSpec(ICallSpecification oldCallSpecification, ICallSpecification newCallSpecification);

		// Token: 0x060001E9 RID: 489
		void Clear();
	}
}
