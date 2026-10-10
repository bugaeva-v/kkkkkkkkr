using System;
using System.Runtime.CompilerServices;
using NSubstitute.Core;
using NSubstitute.ReceivedExtensions;
using NSubstitute.Routing.Handlers;

namespace NSubstitute.Routing
{
	// Token: 0x0200001C RID: 28
	public class RouteFactory : IRouteFactory
	{
		// Token: 0x06000075 RID: 117 RVA: 0x00002E63 File Offset: 0x00001063
		public RouteFactory(SequenceNumberGenerator sequenceNumberGenerator, IThreadLocalContext threadLocalContext, ICallSpecificationFactory callSpecificationFactory, IReceivedCallsExceptionThrower receivedCallsExceptionThrower, IPropertyHelper propertyHelper, IDefaultForType defaultForType)
		{
			this._sequenceNumberGenerator = sequenceNumberGenerator;
			this._threadLocalContext = threadLocalContext;
			this._callSpecificationFactory = callSpecificationFactory;
			this._receivedCallsExceptionThrower = receivedCallsExceptionThrower;
			this._propertyHelper = propertyHelper;
			this._defaultForType = defaultForType;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002E98 File Offset: 0x00001098
		public IRoute CallQuery(ISubstituteState state)
		{
			return new Route(new ICallHandler[]
			{
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new AddCallToQueryResultHandler(this._threadLocalContext),
				new ReturnAutoValue(AutoValueBehaviour.UseValueForSubsequentCalls, state.AutoValueProviders, state.AutoValuesCallResults, this._callSpecificationFactory),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002EF8 File Offset: 0x000010F8
		public IRoute CheckReceivedCalls(ISubstituteState state, MatchArgs matchArgs, Quantity requiredQuantity)
		{
			return new Route(new ICallHandler[]
			{
				new ClearLastCallRouterHandler(this._threadLocalContext),
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new CheckReceivedCallsHandler(state.ReceivedCalls, this._callSpecificationFactory, this._receivedCallsExceptionThrower, matchArgs, requiredQuantity),
				new ReturnAutoValue(AutoValueBehaviour.ReturnAndForgetValue, state.AutoValueProviders, state.AutoValuesCallResults, this._callSpecificationFactory),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002F74 File Offset: 0x00001174
		public IRoute DoWhenCalled(ISubstituteState state, Action<CallInfo> doAction, MatchArgs matchArgs)
		{
			return new Route(new ICallHandler[]
			{
				new ClearLastCallRouterHandler(this._threadLocalContext),
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new SetActionForCallHandler(this._callSpecificationFactory, state.CallActions, doAction, matchArgs),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002FCC File Offset: 0x000011CC
		public IRoute DoNotCallBase(ISubstituteState state, MatchArgs matchArgs)
		{
			return new Route(new ICallHandler[]
			{
				new ClearLastCallRouterHandler(this._threadLocalContext),
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new DoNotCallBaseForCallHandler(this._callSpecificationFactory, state.CallBaseConfiguration, matchArgs),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00003024 File Offset: 0x00001224
		public IRoute CallBase(ISubstituteState state, MatchArgs matchArgs)
		{
			return new Route(new ICallHandler[]
			{
				new ClearLastCallRouterHandler(this._threadLocalContext),
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new CallBaseForCallHandler(this._callSpecificationFactory, state.CallBaseConfiguration, matchArgs),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000307C File Offset: 0x0000127C
		public IRoute RaiseEvent(ISubstituteState state, [Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getEventArguments)
		{
			return new Route(new ICallHandler[]
			{
				new ClearLastCallRouterHandler(this._threadLocalContext),
				new ClearUnusedCallSpecHandler(this._threadLocalContext.PendingSpecification),
				new RaiseEventHandler(state.EventHandlerRegistry, getEventArguments),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000030D0 File Offset: 0x000012D0
		public IRoute RecordCallSpecification(ISubstituteState state)
		{
			return new Route(new ICallHandler[]
			{
				new RecordCallSpecificationHandler(this._threadLocalContext.PendingSpecification, this._callSpecificationFactory, state.CallActions),
				new PropertySetterHandler(this._propertyHelper, state.ConfigureCall),
				new ReturnAutoValue(AutoValueBehaviour.UseValueForSubsequentCalls, state.AutoValueProviders, state.AutoValuesCallResults, this._callSpecificationFactory),
				new ReturnFromAndConfigureDynamicCall(state.ConfigureCall),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00003150 File Offset: 0x00001350
		public IRoute RecordReplay(ISubstituteState state)
		{
			return new Route(new ICallHandler[]
			{
				new TrackLastCallHandler(this._threadLocalContext.PendingSpecification),
				new RecordCallHandler(state.ReceivedCalls, this._sequenceNumberGenerator),
				new EventSubscriptionHandler(state.EventHandlerRegistry),
				new PropertySetterHandler(this._propertyHelper, state.ConfigureCall),
				new DoActionsCallHandler(state.CallActions),
				new ReturnConfiguredResultHandler(state.CallResults),
				new ReturnResultForTypeHandler(state.ResultsForType),
				new ReturnFromBaseIfRequired(state.CallBaseConfiguration),
				new ReturnFromCustomHandlers(state.CustomHandlers),
				new ReturnAutoValue(AutoValueBehaviour.UseValueForSubsequentCalls, state.AutoValueProviders, state.AutoValuesCallResults, this._callSpecificationFactory),
				new ReturnFromAndConfigureDynamicCall(state.ConfigureCall),
				this.ReturnDefaultForReturnTypeHandler()
			});
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000322D File Offset: 0x0000142D
		private ReturnDefaultForReturnTypeHandler ReturnDefaultForReturnTypeHandler()
		{
			return new ReturnDefaultForReturnTypeHandler(this._defaultForType);
		}

		// Token: 0x04000016 RID: 22
		private readonly SequenceNumberGenerator _sequenceNumberGenerator;

		// Token: 0x04000017 RID: 23
		private readonly IThreadLocalContext _threadLocalContext;

		// Token: 0x04000018 RID: 24
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x04000019 RID: 25
		private readonly IReceivedCallsExceptionThrower _receivedCallsExceptionThrower;

		// Token: 0x0400001A RID: 26
		private readonly IPropertyHelper _propertyHelper;

		// Token: 0x0400001B RID: 27
		private readonly IDefaultForType _defaultForType;
	}
}
