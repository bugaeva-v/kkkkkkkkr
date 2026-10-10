using System;
using System.Linq;
using System.Reflection;
using NSubstitute.Exceptions;

namespace NSubstitute.Core.SequenceChecking
{
	// Token: 0x020000BF RID: 191
	public class SequenceInOrderAssertion
	{
		// Token: 0x0600031E RID: 798 RVA: 0x00008018 File Offset: 0x00006218
		public void Assert(IQueryResults queryResult)
		{
			ICall[] array = (from x in queryResult.MatchingCallsInOrder()
			where this.IsNotPropertyGetterCall(x.GetMethodInfo())
			select x).ToArray<ICall>();
			CallSpecAndTarget[] array2 = (from x in queryResult.QuerySpecification()
			where this.IsNotPropertyGetterCall(x.CallSpecification.GetMethodInfo())
			select x).ToArray<CallSpecAndTarget>();
			if (array.Length != array2.Length)
			{
				throw new CallSequenceNotFoundException(this.GetExceptionMessage(array2, array));
			}
			if (array.Zip(array2, (ICall call, CallSpecAndTarget specAndTarget) => new
			{
				Call = call,
				Spec = specAndTarget.CallSpecification,
				IsMatch = this.Matches(call, specAndTarget)
			}).Any(x => !x.IsMatch))
			{
				throw new CallSequenceNotFoundException(this.GetExceptionMessage(array2, array));
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x000080BC File Offset: 0x000062BC
		private bool Matches(ICall call, CallSpecAndTarget specAndTarget)
		{
			return call.Target() == specAndTarget.Target && specAndTarget.CallSpecification.IsSatisfiedBy(call);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x000080DA File Offset: 0x000062DA
		private bool IsNotPropertyGetterCall(MethodInfo methodInfo)
		{
			return methodInfo.GetPropertyFromGetterCallOrNull() == null;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x000080E8 File Offset: 0x000062E8
		private string GetExceptionMessage(CallSpecAndTarget[] querySpec, ICall[] matchingCallsInOrder)
		{
			SequenceFormatter sequenceFormatter = new SequenceFormatter("\n    ", querySpec, matchingCallsInOrder);
			return string.Format("\nExpected to receive these calls in order:\n{0}{1}\n\nActually received matching calls in this order:\n{0}{2}\n\n{3}", new object[]
			{
				"\n    ",
				sequenceFormatter.FormatQuery(),
				sequenceFormatter.FormatActualCalls(),
				"*** Note: calls to property getters are not considered part of the query. ***"
			});
		}
	}
}
