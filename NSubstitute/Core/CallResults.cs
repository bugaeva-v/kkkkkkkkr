using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x0200006B RID: 107
	public class CallResults : ICallResults
	{
		// Token: 0x06000184 RID: 388 RVA: 0x000059B0 File Offset: 0x00003BB0
		public CallResults(ICallInfoFactory callInfoFactory)
		{
			this._results = new ConcurrentStack<CallResults.ResultForCallSpec>();
			this._callInfoFactory = callInfoFactory;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000059CA File Offset: 0x00003BCA
		public void SetResult(ICallSpecification callSpecification, IReturn result)
		{
			this._results.Push(new CallResults.ResultForCallSpec(callSpecification, result));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000059E0 File Offset: 0x00003BE0
		public bool TryGetResult(ICall call, [Nullable(2)] out object result)
		{
			result = null;
			if (CallResults.ReturnsVoidFrom(call))
			{
				return false;
			}
			CallResults.ResultForCallSpec resultForCallSpec;
			if (!this.TryFindResultForCall(call, out resultForCallSpec))
			{
				return false;
			}
			result = resultForCallSpec.GetResult(call, this._callInfoFactory);
			return true;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00005A18 File Offset: 0x00003C18
		private bool TryFindResultForCall(ICall call, out CallResults.ResultForCallSpec configuredResult)
		{
			if (this._results.IsEmpty)
			{
				configuredResult = default(CallResults.ResultForCallSpec);
				return false;
			}
			foreach (CallResults.ResultForCallSpec resultForCallSpec in this._results)
			{
				if (resultForCallSpec.IsResultFor(call))
				{
					configuredResult = resultForCallSpec;
					return true;
				}
			}
			configuredResult = default(CallResults.ResultForCallSpec);
			return false;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00005A94 File Offset: 0x00003C94
		public void Clear()
		{
			this._results.Clear();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00005AA1 File Offset: 0x00003CA1
		private static bool ReturnsVoidFrom(ICall call)
		{
			return call.GetReturnType() == typeof(void);
		}

		// Token: 0x04000081 RID: 129
		private readonly ICallInfoFactory _callInfoFactory;

		// Token: 0x04000082 RID: 130
		private readonly ConcurrentStack<CallResults.ResultForCallSpec> _results;

		// Token: 0x02000119 RID: 281
		private readonly struct ResultForCallSpec
		{
			// Token: 0x06000464 RID: 1124 RVA: 0x00009D9C File Offset: 0x00007F9C
			public ResultForCallSpec(ICallSpecification callSpecification, IReturn resultToReturn)
			{
				this._callSpecification = callSpecification;
				this._resultToReturn = resultToReturn;
			}

			// Token: 0x06000465 RID: 1125 RVA: 0x00009DAC File Offset: 0x00007FAC
			public bool IsResultFor(ICall call)
			{
				return this._callSpecification.IsSatisfiedBy(call);
			}

			// Token: 0x06000466 RID: 1126 RVA: 0x00009DBC File Offset: 0x00007FBC
			[return: Nullable(2)]
			public object GetResult(ICall call, ICallInfoFactory callInfoFactory)
			{
				ICallIndependentReturn callIndependentReturn = this._resultToReturn as ICallIndependentReturn;
				if (callIndependentReturn != null)
				{
					return callIndependentReturn.GetReturnValue();
				}
				CallInfo info = callInfoFactory.Create(call);
				return this._resultToReturn.ReturnFor(info);
			}

			// Token: 0x04000154 RID: 340
			private readonly ICallSpecification _callSpecification;

			// Token: 0x04000155 RID: 341
			private readonly IReturn _resultToReturn;
		}
	}
}
