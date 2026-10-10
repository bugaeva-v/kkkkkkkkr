using System;
using System.Collections.Generic;
using System.Reflection;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Core
{
	// Token: 0x02000062 RID: 98
	public class ArgumentSpecificationDequeue : IArgumentSpecificationDequeue
	{
		// Token: 0x06000144 RID: 324 RVA: 0x0000508A File Offset: 0x0000328A
		public ArgumentSpecificationDequeue(Func<IList<IArgumentSpecification>> dequeueAllQueuedArgSpecs)
		{
			this._dequeueAllQueuedArgSpecs = dequeueAllQueuedArgSpecs;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005099 File Offset: 0x00003299
		public IList<IArgumentSpecification> DequeueAllArgumentSpecificationsForMethod(int parametersCount)
		{
			if (parametersCount == 0)
			{
				return ArgumentSpecificationDequeue.EmptySpecifications;
			}
			return this._dequeueAllQueuedArgSpecs();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000050AF File Offset: 0x000032AF
		public IList<IArgumentSpecification> DequeueAllArgumentSpecificationsForMethod(MethodInfo methodInfo)
		{
			return this.DequeueAllArgumentSpecificationsForMethod(methodInfo.GetParameters().Length);
		}

		// Token: 0x0400006D RID: 109
		private static readonly IArgumentSpecification[] EmptySpecifications = new IArgumentSpecification[0];

		// Token: 0x0400006E RID: 110
		private readonly Func<IList<IArgumentSpecification>> _dequeueAllQueuedArgSpecs;
	}
}
