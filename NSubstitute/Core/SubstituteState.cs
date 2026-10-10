using System;
using System.Collections.Generic;
using NSubstitute.Routing.AutoValues;

namespace NSubstitute.Core
{
	// Token: 0x020000B8 RID: 184
	public class SubstituteState : ISubstituteState
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000076B7 File Offset: 0x000058B7
		public ICallBaseConfiguration CallBaseConfiguration { get; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x000076BF File Offset: 0x000058BF
		public ICallCollection ReceivedCalls { get; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000076C7 File Offset: 0x000058C7
		public ICallResults CallResults { get; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000076CF File Offset: 0x000058CF
		public ICallActions CallActions { get; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000076D7 File Offset: 0x000058D7
		public IConfigureCall ConfigureCall { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000076DF File Offset: 0x000058DF
		public IEventHandlerRegistry EventHandlerRegistry { get; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000076E7 File Offset: 0x000058E7
		public IReadOnlyCollection<IAutoValueProvider> AutoValueProviders { get; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000076EF File Offset: 0x000058EF
		public ICallResults AutoValuesCallResults { get; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x000076F7 File Offset: 0x000058F7
		public IResultsForType ResultsForType { get; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000076FF File Offset: 0x000058FF
		public ICustomHandlers CustomHandlers { get; }

		// Token: 0x060002E2 RID: 738 RVA: 0x00007708 File Offset: 0x00005908
		public SubstituteState(ICallSpecificationFactory callSpecificationFactory, ICallInfoFactory callInfoFactory, IReadOnlyCollection<IAutoValueProvider> autoValueProviders)
		{
			this.AutoValueProviders = autoValueProviders;
			CallCollection callCollection = new CallCollection();
			this.ReceivedCalls = callCollection;
			this.CallBaseConfiguration = new CallBaseConfiguration();
			this.CallResults = new CallResults(callInfoFactory);
			this.AutoValuesCallResults = new CallResults(callInfoFactory);
			this.CallActions = new CallActions(callInfoFactory);
			this.ResultsForType = new ResultsForType(callInfoFactory);
			this.CustomHandlers = new CustomHandlers(this);
			GetCallSpec getCallSpec = new GetCallSpec(callCollection, callSpecificationFactory, this.CallActions);
			this.ConfigureCall = new ConfigureCall(this.CallResults, this.CallActions, getCallSpec);
			this.EventHandlerRegistry = new EventHandlerRegistry();
		}
	}
}
