using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NSubstitute.Core.Arguments;
using NSubstitute.Exceptions;
using NSubstitute.ReceivedExtensions;

namespace NSubstitute.Core
{
	// Token: 0x020000AE RID: 174
	public class ReceivedCallsExceptionThrower : IReceivedCallsExceptionThrower
	{
		// Token: 0x060002A7 RID: 679 RVA: 0x00007004 File Offset: 0x00005204
		public void Throw(ICallSpecification callSpecification, IEnumerable<ICall> matchingCalls, IEnumerable<ICall> nonMatchingCalls, Quantity requiredQuantity)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine(string.Format("Expected to receive {0} matching:\n\t{1}", requiredQuantity.Describe("call", "calls"), callSpecification));
			this.AppendMatchingCalls(callSpecification, matchingCalls, stringBuilder);
			if (requiredQuantity.RequiresMoreThan<ICall>(matchingCalls))
			{
				this.AppendNonMatchingCalls(callSpecification, nonMatchingCalls, stringBuilder);
			}
			throw new ReceivedCallsException(stringBuilder.ToString());
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00007064 File Offset: 0x00005264
		private void AppendNonMatchingCalls(ICallSpecification callSpecification, IEnumerable<ICall> nonMatchingCalls, StringBuilder builder)
		{
			if (nonMatchingCalls.Any<ICall>())
			{
				int num = nonMatchingCalls.Count<ICall>();
				builder.AppendLine(string.Format("Received {0} non-matching {1} (non-matching arguments indicated with '*' characters):", num, (num == 1) ? "call" : "calls"));
				this.WriteCallsWithRespectToCallSpec(callSpecification, nonMatchingCalls, builder);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000070B0 File Offset: 0x000052B0
		private void AppendMatchingCalls(ICallSpecification callSpecification, IEnumerable<ICall> matchingCalls, StringBuilder builder)
		{
			int num = matchingCalls.Count<ICall>();
			if (num == 0)
			{
				builder.AppendLine("Actually received no matching calls.");
				return;
			}
			builder.AppendLine(string.Format("Actually received {0} matching {1}:", num, (num == 1) ? "call" : "calls"));
			this.WriteCallsWithRespectToCallSpec(callSpecification, matchingCalls, builder);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00007104 File Offset: 0x00005304
		private void WriteCallsWithRespectToCallSpec(ICallSpecification callSpecification, IEnumerable<ICall> relatedCalls, StringBuilder builder)
		{
			foreach (ICall call in relatedCalls)
			{
				builder.AppendFormat("\t{0}\n", callSpecification.Format(call));
				string text = this.DescribeNonMatches(call, callSpecification).Trim();
				if (!string.IsNullOrEmpty(text))
				{
					builder.AppendFormat("\t\t{0}\n", text.Replace("\n", "\n\t\t"));
				}
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000718C File Offset: 0x0000538C
		private string DescribeNonMatches(ICall call, ICallSpecification callSpecification)
		{
			IEnumerable<string> values = from x in callSpecification.NonMatchingArguments(call)
			select x.DescribeNonMatch() into x
			where !string.IsNullOrEmpty(x)
			select x;
			return string.Join("\n", values);
		}
	}
}
