using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.Routing
{
	// Token: 0x0200001B RID: 27
	public class Route : IRoute
	{
		// Token: 0x06000072 RID: 114 RVA: 0x00002E0D File Offset: 0x0000100D
		public Route(ICallHandler[] handlers)
		{
			this._handlers = handlers;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00002E1C File Offset: 0x0000101C
		public IEnumerable<ICallHandler> Handlers
		{
			get
			{
				return this._handlers;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002E24 File Offset: 0x00001024
		[return: Nullable(2)]
		public object Handle(ICall call)
		{
			for (int i = 0; i < this._handlers.Length; i++)
			{
				RouteAction routeAction = this._handlers[i].Handle(call);
				if (routeAction.HasReturnValue)
				{
					return routeAction.ReturnValue;
				}
			}
			return null;
		}

		// Token: 0x04000015 RID: 21
		private readonly ICallHandler[] _handlers;
	}
}
