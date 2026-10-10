using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NSubstitute.Core
{
	// Token: 0x02000077 RID: 119
	public class EventCallFormatter : IMethodInfoFormatter
	{
		// Token: 0x060001C0 RID: 448 RVA: 0x0000631A File Offset: 0x0000451A
		public EventCallFormatter(Func<MethodInfo, Predicate<EventInfo>> eventsToFormat)
		{
			this._eventsToFormat = eventsToFormat;
			this._eventOperator = ((eventsToFormat == EventCallFormatter.IsSubscription) ? "+=" : "-=");
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00006348 File Offset: 0x00004548
		public bool CanFormat(MethodInfo methodInfo)
		{
			return methodInfo.DeclaringType.GetEvents().Any((EventInfo x) => this._eventsToFormat(methodInfo)(x));
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000638C File Offset: 0x0000458C
		public string Format(MethodInfo methodInfo, IEnumerable<string> arguments)
		{
			EventInfo eventInfo = methodInfo.DeclaringType.GetEvents().First((EventInfo x) => this._eventsToFormat(methodInfo)(x));
			return this.Format(eventInfo, this._eventOperator, arguments);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000063DD File Offset: 0x000045DD
		private string Format(EventInfo eventInfo, string eventOperator, IEnumerable<string> arguments)
		{
			return string.Concat(new string[]
			{
				eventInfo.Name,
				" ",
				eventOperator,
				" ",
				arguments.Join(", ")
			});
		}

		// Token: 0x04000098 RID: 152
		public static readonly Func<MethodInfo, Predicate<EventInfo>> IsSubscription = (MethodInfo call) => (EventInfo eventInfo) => eventInfo.GetAddMethod() == call;

		// Token: 0x04000099 RID: 153
		public static readonly Func<MethodInfo, Predicate<EventInfo>> IsUnsubscription = (MethodInfo call) => (EventInfo eventInfo) => eventInfo.GetRemoveMethod() == call;

		// Token: 0x0400009A RID: 154
		private readonly Func<MethodInfo, Predicate<EventInfo>> _eventsToFormat;

		// Token: 0x0400009B RID: 155
		private readonly string _eventOperator;
	}
}
