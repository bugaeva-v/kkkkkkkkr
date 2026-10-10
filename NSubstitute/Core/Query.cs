using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NSubstitute.Core
{
	// Token: 0x020000AD RID: 173
	public class Query : IQuery, IQueryResults
	{
		// Token: 0x060002A2 RID: 674 RVA: 0x00006F21 File Offset: 0x00005121
		public Query(ICallSpecificationFactory callSpecificationFactory)
		{
			this._callSpecificationFactory = callSpecificationFactory;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00006F4C File Offset: 0x0000514C
		public void RegisterCall(ICall call)
		{
			object obj = call.Target();
			ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, MatchArgs.AsSpecifiedInCall);
			this._querySpec.Add(new CallSpecAndTarget(callSpecification, obj));
			IEnumerable<ICall> other = obj.ReceivedCalls<object>().Where(new Func<ICall, bool>(callSpecification.IsSatisfiedBy));
			this._matchingCalls.UnionWith(other);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00006FA9 File Offset: 0x000051A9
		public IQueryResults Result()
		{
			return this;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00006FAC File Offset: 0x000051AC
		IEnumerable<ICall> IQueryResults.MatchingCallsInOrder()
		{
			return from x in this._matchingCalls
			orderby x.GetSequenceNumber()
			select x;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00006FD8 File Offset: 0x000051D8
		IEnumerable<CallSpecAndTarget> IQueryResults.QuerySpecification()
		{
			return from x in this._querySpec
			select x;
		}

		// Token: 0x040000B0 RID: 176
		private readonly List<CallSpecAndTarget> _querySpec = new List<CallSpecAndTarget>();

		// Token: 0x040000B1 RID: 177
		private readonly HashSet<ICall> _matchingCalls = new HashSet<ICall>(new Query.CallSequenceNumberComparer());

		// Token: 0x040000B2 RID: 178
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x0200012B RID: 299
		private class CallSequenceNumberComparer : IEqualityComparer<ICall>
		{
			// Token: 0x06000497 RID: 1175 RVA: 0x0000A098 File Offset: 0x00008298
			[NullableContext(2)]
			public bool Equals(ICall x, ICall y)
			{
				long? num = (x != null) ? new long?(x.GetSequenceNumber()) : null;
				long? num2 = (y != null) ? new long?(y.GetSequenceNumber()) : null;
				return num.GetValueOrDefault() == num2.GetValueOrDefault() & num != null == (num2 != null);
			}

			// Token: 0x06000498 RID: 1176 RVA: 0x0000A0FC File Offset: 0x000082FC
			public int GetHashCode(ICall obj)
			{
				return obj.GetSequenceNumber().GetHashCode();
			}
		}
	}
}
