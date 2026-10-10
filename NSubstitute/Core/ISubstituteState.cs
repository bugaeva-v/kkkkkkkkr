using System;
using System.Collections.Generic;
using NSubstitute.Routing.AutoValues;

namespace NSubstitute.Core
{
	// Token: 0x020000A1 RID: 161
	public interface ISubstituteState
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600024E RID: 590
		ICallBaseConfiguration CallBaseConfiguration { get; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600024F RID: 591
		ICallCollection ReceivedCalls { get; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000250 RID: 592
		ICallResults CallResults { get; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000251 RID: 593
		ICallActions CallActions { get; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000252 RID: 594
		IConfigureCall ConfigureCall { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000253 RID: 595
		IEventHandlerRegistry EventHandlerRegistry { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000254 RID: 596
		IReadOnlyCollection<IAutoValueProvider> AutoValueProviders { get; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000255 RID: 597
		ICallResults AutoValuesCallResults { get; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000256 RID: 598
		IResultsForType ResultsForType { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000257 RID: 599
		ICustomHandlers CustomHandlers { get; }
	}
}
