using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000024 RID: 36
	public class EventSubscriptionHandler : ICallHandler
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00003447 File Offset: 0x00001647
		public EventSubscriptionHandler(IEventHandlerRegistry eventHandlerRegistry)
		{
			this._eventHandlerRegistry = eventHandlerRegistry;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00003458 File Offset: 0x00001658
		public RouteAction Handle(ICall call)
		{
			if (EventSubscriptionHandler.CanBeSubscribeUnsubscribeCall(call))
			{
				EventSubscriptionHandler.If(call, new Func<ICall, Predicate<EventInfo>>(EventSubscriptionHandler.IsEventSubscription), new Action<string, object>(this._eventHandlerRegistry.Add));
				EventSubscriptionHandler.If(call, new Func<ICall, Predicate<EventInfo>>(EventSubscriptionHandler.IsEventUnsubscription), new Action<string, object>(this._eventHandlerRegistry.Remove));
			}
			return RouteAction.Continue();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000034BC File Offset: 0x000016BC
		private static bool CanBeSubscribeUnsubscribeCall(ICall call)
		{
			MethodInfo methodInfo = call.GetMethodInfo();
			return methodInfo.ReturnType == typeof(void) && (methodInfo.Name.StartsWith("add_", StringComparison.Ordinal) || methodInfo.Name.StartsWith("remove_", StringComparison.Ordinal));
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00003510 File Offset: 0x00001710
		private static void If(ICall call, Func<ICall, Predicate<EventInfo>> meetsThisSpecification, Action<string, object> takeThisAction)
		{
			EventInfo eventInfo = EventSubscriptionHandler.GetEvents(call, meetsThisSpecification).FirstOrDefault<EventInfo>();
			if (eventInfo != null)
			{
				takeThisAction(eventInfo.Name, call.GetOriginalArguments()[0]);
			}
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00003547 File Offset: 0x00001747
		private static Predicate<EventInfo> IsEventSubscription(ICall call)
		{
			return (EventInfo x) => call.GetMethodInfo() == x.GetAddMethod();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00003560 File Offset: 0x00001760
		private static Predicate<EventInfo> IsEventUnsubscription(ICall call)
		{
			return (EventInfo x) => call.GetMethodInfo() == x.GetRemoveMethod();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000357C File Offset: 0x0000177C
		private static IEnumerable<EventInfo> GetEvents(ICall call, Func<ICall, Predicate<EventInfo>> createPredicate)
		{
			Predicate<EventInfo> predicate = createPredicate(call);
			return from x in call.GetMethodInfo().DeclaringType.GetEvents()
			where predicate(x)
			select x;
		}

		// Token: 0x0400002B RID: 43
		private readonly IEventHandlerRegistry _eventHandlerRegistry;
	}
}
