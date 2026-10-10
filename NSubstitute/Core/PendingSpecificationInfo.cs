using System;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000AA RID: 170
	public class PendingSpecificationInfo
	{
		// Token: 0x06000290 RID: 656 RVA: 0x00006CB3 File Offset: 0x00004EB3
		[NullableContext(2)]
		private PendingSpecificationInfo(ICallSpecification callSpecification, ICall lastCall)
		{
			this._callSpecification = callSpecification;
			this._lastCall = lastCall;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00006CC9 File Offset: 0x00004EC9
		public T Handle<T>(Func<ICallSpecification, T> onCallSpec, Func<ICall, T> onLastCall)
		{
			if (this._callSpecification == null)
			{
				return onLastCall(this._lastCall);
			}
			return onCallSpec(this._callSpecification);
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00006CEC File Offset: 0x00004EEC
		public static PendingSpecificationInfo FromLastCall(ICall lastCall)
		{
			return new PendingSpecificationInfo(null, lastCall);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00006CF5 File Offset: 0x00004EF5
		public static PendingSpecificationInfo FromCallSpecification(ICallSpecification callSpecification)
		{
			return new PendingSpecificationInfo(callSpecification, null);
		}

		// Token: 0x040000AC RID: 172
		[Nullable(2)]
		private readonly ICallSpecification _callSpecification;

		// Token: 0x040000AD RID: 173
		[Nullable(2)]
		private readonly ICall _lastCall;
	}
}
