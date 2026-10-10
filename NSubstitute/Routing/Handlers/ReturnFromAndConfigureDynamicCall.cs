using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002D RID: 45
	public class ReturnFromAndConfigureDynamicCall : ICallHandler
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00003915 File Offset: 0x00001B15
		public ReturnFromAndConfigureDynamicCall(IConfigureCall configureCall)
		{
			this._configureCall = configureCall;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003924 File Offset: 0x00001B24
		public RouteAction Handle(ICall call)
		{
			if (this.ReturnsDynamic(call))
			{
				ReturnFromAndConfigureDynamicCall.DynamicStub value = new ReturnFromAndConfigureDynamicCall.DynamicStub();
				this._configureCall.SetResultForCall(call, new ReturnValue(value), MatchArgs.AsSpecifiedInCall);
				return RouteAction.Return(new ReturnFromAndConfigureDynamicCall.DynamicStub());
			}
			return RouteAction.Continue();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003968 File Offset: 0x00001B68
		private bool ReturnsDynamic(ICall call)
		{
			ParameterInfo returnParameter = call.GetMethodInfo().ReturnParameter;
			return returnParameter != null && returnParameter.GetCustomAttributes(ReturnFromAndConfigureDynamicCall.DynamicAttributeType, false).Length != 0;
		}

		// Token: 0x0400003E RID: 62
		private static readonly Type DynamicAttributeType = typeof(DynamicAttribute);

		// Token: 0x0400003F RID: 63
		private readonly IConfigureCall _configureCall;

		// Token: 0x020000F7 RID: 247
		public class DynamicStub
		{
			// Token: 0x060003EE RID: 1006 RVA: 0x00009610 File Offset: 0x00007810
			public ConfiguredCall Returns<T>([Nullable(2)] T returnThis, [Nullable(new byte[]
			{
				0,
				2
			})] params T[] returnThese)
			{
				return default(T).Returns(returnThis, returnThese);
			}

			// Token: 0x060003EF RID: 1007 RVA: 0x00009630 File Offset: 0x00007830
			public ConfiguredCall Returns<T>([Nullable(new byte[]
			{
				0,
				0,
				2
			})] Func<CallInfo, T> returnThis, [Nullable(new byte[]
			{
				0,
				0,
				0,
				2
			})] params Func<CallInfo, T>[] returnThese)
			{
				return default(T).Returns(returnThis, returnThese);
			}

			// Token: 0x060003F0 RID: 1008 RVA: 0x00009650 File Offset: 0x00007850
			public ConfiguredCall ReturnsForAnyArgs<T>([Nullable(2)] T returnThis, [Nullable(new byte[]
			{
				0,
				2
			})] params T[] returnThese)
			{
				return default(T).ReturnsForAnyArgs(returnThis, returnThese);
			}

			// Token: 0x060003F1 RID: 1009 RVA: 0x00009670 File Offset: 0x00007870
			public ConfiguredCall ReturnsForAnyArgs<T>([Nullable(new byte[]
			{
				0,
				0,
				2
			})] Func<CallInfo, T> returnThis, [Nullable(new byte[]
			{
				0,
				0,
				0,
				2
			})] params Func<CallInfo, T>[] returnThese)
			{
				return default(T).ReturnsForAnyArgs(returnThis, returnThese);
			}
		}
	}
}
