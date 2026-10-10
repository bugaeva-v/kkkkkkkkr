using System;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core;
using NSubstitute.Exceptions;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000026 RID: 38
	public class RaiseEventHandler : ICallHandler
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00003624 File Offset: 0x00001824
		public RaiseEventHandler(IEventHandlerRegistry eventHandlerRegistry, [Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})] Func<ICall, object[]> getEventArguments)
		{
			this._eventHandlerRegistry = eventHandlerRegistry;
			this._getEventArguments = getEventArguments;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000363C File Offset: 0x0000183C
		public RouteAction Handle(ICall call)
		{
			EventInfo eventInfo = RaiseEventHandler.<Handle>g__FindEventInfo|3_0(call.GetMethodInfo());
			if (eventInfo == null)
			{
				throw new CouldNotRaiseEventException();
			}
			object[] args = this._getEventArguments(call);
			foreach (object obj in this._eventHandlerRegistry.GetHandlers(eventInfo.Name))
			{
				Delegate @delegate = (Delegate)obj;
				if (@delegate != null)
				{
					try
					{
						@delegate.DynamicInvoke(args);
					}
					catch (TargetInvocationException ex)
					{
						throw ex.InnerException;
					}
				}
			}
			return RouteAction.Continue();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000036E0 File Offset: 0x000018E0
		[CompilerGenerated]
		[return: Nullable(2)]
		internal static EventInfo <Handle>g__FindEventInfo|3_0(MethodInfo mi)
		{
			return mi.DeclaringType.GetEvents().FirstOrDefault((EventInfo e) => e.GetAddMethod() == mi || e.GetRemoveMethod() == mi);
		}

		// Token: 0x0400002E RID: 46
		private readonly IEventHandlerRegistry _eventHandlerRegistry;

		// Token: 0x0400002F RID: 47
		[Nullable(new byte[]
		{
			0,
			0,
			0,
			2
		})]
		private readonly Func<ICall, object[]> _getEventArguments;
	}
}
