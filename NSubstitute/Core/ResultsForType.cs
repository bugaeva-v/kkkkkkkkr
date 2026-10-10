using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x020000B0 RID: 176
	public class ResultsForType : IResultsForType
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x000072BF File Offset: 0x000054BF
		public ResultsForType(ICallInfoFactory callInfoFactory)
		{
			this._results = new CallResults(callInfoFactory);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x000072D3 File Offset: 0x000054D3
		public void SetResult(Type type, IReturn resultToReturn)
		{
			this._results.SetResult(new ResultsForType.MatchingReturnTypeSpecification(type), resultToReturn);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000072E7 File Offset: 0x000054E7
		public bool TryGetResult(ICall call, [Nullable(2)] out object result)
		{
			return this._results.TryGetResult(call, out result);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000072F6 File Offset: 0x000054F6
		public void Clear()
		{
			this._results.Clear();
		}

		// Token: 0x040000B3 RID: 179
		private readonly CallResults _results;

		// Token: 0x0200012F RID: 303
		private class MatchingReturnTypeSpecification : ICallSpecification
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x0000A181 File Offset: 0x00008381
			public MatchingReturnTypeSpecification(Type expectedReturnType)
			{
				this._expectedReturnType = expectedReturnType;
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x0000A190 File Offset: 0x00008390
			public bool IsSatisfiedBy(ICall call)
			{
				return call.GetReturnType() == this._expectedReturnType;
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x0000A1A3 File Offset: 0x000083A3
			public string Format(ICall call)
			{
				throw new NotSupportedException();
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x0000A1AA File Offset: 0x000083AA
			public ICallSpecification CreateCopyThatMatchesAnyArguments()
			{
				throw new NotSupportedException();
			}

			// Token: 0x060004A8 RID: 1192 RVA: 0x0000A1B1 File Offset: 0x000083B1
			public void InvokePerArgumentActions(CallInfo callInfo)
			{
				throw new NotSupportedException();
			}

			// Token: 0x060004A9 RID: 1193 RVA: 0x0000A1B8 File Offset: 0x000083B8
			public IEnumerable<ArgumentMatchInfo> NonMatchingArguments(ICall call)
			{
				throw new NotSupportedException();
			}

			// Token: 0x060004AA RID: 1194 RVA: 0x0000A1BF File Offset: 0x000083BF
			public MethodInfo GetMethodInfo()
			{
				throw new NotSupportedException();
			}

			// Token: 0x060004AB RID: 1195 RVA: 0x0000A1C6 File Offset: 0x000083C6
			public Type ReturnType()
			{
				throw new NotSupportedException();
			}

			// Token: 0x0400017F RID: 383
			private readonly Type _expectedReturnType;
		}
	}
}
