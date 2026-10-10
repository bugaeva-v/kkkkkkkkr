using System;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002C RID: 44
	public class ReturnDefaultForReturnTypeHandler : ICallHandler
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000038E9 File Offset: 0x00001AE9
		public ReturnDefaultForReturnTypeHandler(IDefaultForType defaultForType)
		{
			this._defaultForType = defaultForType;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000038F8 File Offset: 0x00001AF8
		public RouteAction Handle(ICall call)
		{
			return RouteAction.Return(this._defaultForType.GetDefaultFor(call.GetMethodInfo().ReturnType));
		}

		// Token: 0x0400003D RID: 61
		private readonly IDefaultForType _defaultForType;
	}
}
