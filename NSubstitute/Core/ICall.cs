using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x0200007C RID: 124
	public interface ICall
	{
		// Token: 0x060001DA RID: 474
		Type GetReturnType();

		// Token: 0x060001DB RID: 475
		MethodInfo GetMethodInfo();

		// Token: 0x060001DC RID: 476
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		object[] GetArguments();

		// Token: 0x060001DD RID: 477
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		object[] GetOriginalArguments();

		// Token: 0x060001DE RID: 478
		object Target();

		// Token: 0x060001DF RID: 479
		IParameterInfo[] GetParameterInfos();

		// Token: 0x060001E0 RID: 480
		IList<IArgumentSpecification> GetArgumentSpecifications();

		// Token: 0x060001E1 RID: 481
		void AssignSequenceNumber(long number);

		// Token: 0x060001E2 RID: 482
		long GetSequenceNumber();

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001E3 RID: 483
		bool CanCallBase { get; }

		// Token: 0x060001E4 RID: 484
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		Maybe<object> TryCallBase();
	}
}
