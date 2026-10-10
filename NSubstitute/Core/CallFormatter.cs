using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NSubstitute.Core
{
	// Token: 0x02000068 RID: 104
	public class CallFormatter : IMethodInfoFormatter
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000055C3 File Offset: 0x000037C3
		internal static IMethodInfoFormatter Default { get; } = new CallFormatter();

		// Token: 0x06000172 RID: 370 RVA: 0x000055CA File Offset: 0x000037CA
		public CallFormatter()
		{
			this._methodInfoFormatters = new IMethodInfoFormatter[]
			{
				new PropertyCallFormatter(),
				new EventCallFormatter(EventCallFormatter.IsSubscription),
				new EventCallFormatter(EventCallFormatter.IsUnsubscription),
				new MethodFormatter()
			};
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00005608 File Offset: 0x00003808
		public bool CanFormat(MethodInfo methodInfo)
		{
			return true;
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000560C File Offset: 0x0000380C
		public string Format(MethodInfo methodInfoOfCall, IEnumerable<string> formattedArguments)
		{
			return this._methodInfoFormatters.First((IMethodInfoFormatter x) => x.CanFormat(methodInfoOfCall)).Format(methodInfoOfCall, formattedArguments);
		}

		// Token: 0x0400007F RID: 127
		private readonly IEnumerable<IMethodInfoFormatter> _methodInfoFormatters;
	}
}
