using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Exceptions;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x0200006C RID: 108
	public class CallRouter : ICallRouter
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public CallRouter(ISubstituteState substituteState, IThreadLocalContext threadContext, IRouteFactory routeFactory, bool canConfigureBaseCalls)
		{
			this._substituteState = substituteState;
			this._threadContext = threadContext;
			this._routeFactory = routeFactory;
			this._canConfigureBaseCalls = canConfigureBaseCalls;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600018B RID: 395 RVA: 0x00005ADD File Offset: 0x00003CDD
		// (set) Token: 0x0600018C RID: 396 RVA: 0x00005AEF File Offset: 0x00003CEF
		public bool CallBaseByDefault
		{
			get
			{
				return this._substituteState.CallBaseConfiguration.CallBaseByDefault;
			}
			set
			{
				if (!this._canConfigureBaseCalls)
				{
					throw CouldNotConfigureCallBaseException.ForAllCalls();
				}
				this._substituteState.CallBaseConfiguration.CallBaseByDefault = value;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00005B10 File Offset: 0x00003D10
		public void Clear(ClearOptions options)
		{
			if ((options & ClearOptions.CallActions) == ClearOptions.CallActions)
			{
				this._substituteState.CallActions.Clear();
			}
			if ((options & ClearOptions.ReturnValues) == ClearOptions.ReturnValues)
			{
				this._substituteState.CallResults.Clear();
				this._substituteState.ResultsForType.Clear();
			}
			if ((options & ClearOptions.ReceivedCalls) == ClearOptions.ReceivedCalls)
			{
				this._substituteState.ReceivedCalls.Clear();
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00005B6F File Offset: 0x00003D6F
		public IEnumerable<ICall> ReceivedCalls()
		{
			return this._substituteState.ReceivedCalls.AllCalls();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00005B81 File Offset: 0x00003D81
		public void SetRoute(Func<ISubstituteState, IRoute> getRoute)
		{
			this._threadContext.SetNextRoute(this, getRoute);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00005B90 File Offset: 0x00003D90
		[return: Nullable(2)]
		public object Route(ICall call)
		{
			this._threadContext.SetLastCallRouter(this);
			bool isQuerying = this._threadContext.IsQuerying;
			Func<ICall, object[]> pendingRaisingEventArgs = this._threadContext.UsePendingRaisingEventArgumentsFactory();
			Func<ISubstituteState, IRoute> queuedNextRouteFactory = this._threadContext.UseNextRoute(this);
			return this.ResolveCurrentRoute(call, isQuerying, pendingRaisingEventArgs, queuedNextRouteFactory).Handle(call);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00005BE0 File Offset: 0x00003DE0
		private IRoute ResolveCurrentRoute(ICall call, bool isQuerying, [Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})] Func<ICall, object[]> pendingRaisingEventArgs, [Nullable(new byte[]
		{
			2,
			0,
			0
		})] Func<ISubstituteState, IRoute> queuedNextRouteFactory)
		{
			if (isQuerying)
			{
				return this._routeFactory.CallQuery(this._substituteState);
			}
			if (pendingRaisingEventArgs != null)
			{
				return this._routeFactory.RaiseEvent(this._substituteState, pendingRaisingEventArgs);
			}
			if (queuedNextRouteFactory != null)
			{
				return queuedNextRouteFactory(this._substituteState);
			}
			if (CallRouter.IsSpecifyingACall(call))
			{
				return this._routeFactory.RecordCallSpecification(this._substituteState);
			}
			return this._routeFactory.RecordReplay(this._substituteState);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00005C55 File Offset: 0x00003E55
		private static bool IsSpecifyingACall(ICall call)
		{
			return call.GetOriginalArguments().Length != 0 && call.GetArgumentSpecifications().Count != 0;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00005C70 File Offset: 0x00003E70
		public ConfiguredCall LastCallShouldReturn(IReturn returnValue, MatchArgs matchArgs, PendingSpecificationInfo pendingSpecInfo)
		{
			return this._substituteState.ConfigureCall.SetResultForLastCall(returnValue, matchArgs, pendingSpecInfo);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00005C85 File Offset: 0x00003E85
		public void SetReturnForType(Type type, IReturn returnValue)
		{
			this._substituteState.ResultsForType.SetResult(type, returnValue);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00005C99 File Offset: 0x00003E99
		public void RegisterCustomCallHandlerFactory(CallHandlerFactory factory)
		{
			if (factory == null)
			{
				throw new ArgumentNullException("factory");
			}
			this._substituteState.CustomHandlers.AddCustomHandlerFactory(factory);
		}

		// Token: 0x04000083 RID: 131
		private readonly ISubstituteState _substituteState;

		// Token: 0x04000084 RID: 132
		private readonly IThreadLocalContext _threadContext;

		// Token: 0x04000085 RID: 133
		private readonly IRouteFactory _routeFactory;

		// Token: 0x04000086 RID: 134
		private readonly bool _canConfigureBaseCalls;
	}
}
