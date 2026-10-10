using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NSubstitute.Core;
using NSubstitute.Routing.AutoValues;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x0200002A RID: 42
	public class ReturnAutoValue : ICallHandler
	{
		// Token: 0x0600009D RID: 157 RVA: 0x000037DC File Offset: 0x000019DC
		public ReturnAutoValue(AutoValueBehaviour autoValueBehaviour, IEnumerable<IAutoValueProvider> autoValueProviders, ICallResults callResults, ICallSpecificationFactory callSpecificationFactory)
		{
			this._autoValueProviders = autoValueProviders.AsArray<IAutoValueProvider>();
			this._callResults = callResults;
			this._callSpecificationFactory = callSpecificationFactory;
			this._autoValueBehaviour = autoValueBehaviour;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003808 File Offset: 0x00001A08
		public RouteAction Handle(ICall call)
		{
			object value;
			if (this._callResults.TryGetResult(call, out value))
			{
				return RouteAction.Return(value);
			}
			Type returnType = call.GetReturnType();
			foreach (IAutoValueProvider autoValueProvider in this._autoValueProviders)
			{
				if (autoValueProvider.CanProvideValueFor(returnType))
				{
					return RouteAction.Return(this.GetResultValueUsingProvider(call, returnType, autoValueProvider));
				}
			}
			return RouteAction.Continue();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000386C File Offset: 0x00001A6C
		[return: Nullable(2)]
		private object GetResultValueUsingProvider(ICall call, Type type, IAutoValueProvider provider)
		{
			object value = provider.GetValue(type);
			if (this._autoValueBehaviour == AutoValueBehaviour.UseValueForSubsequentCalls)
			{
				ICallSpecification callSpecification = this._callSpecificationFactory.CreateFrom(call, MatchArgs.AsSpecifiedInCall);
				this._callResults.SetResult(callSpecification, new ReturnValue(value));
			}
			return value;
		}

		// Token: 0x04000038 RID: 56
		private readonly IAutoValueProvider[] _autoValueProviders;

		// Token: 0x04000039 RID: 57
		private readonly ICallResults _callResults;

		// Token: 0x0400003A RID: 58
		private readonly ICallSpecificationFactory _callSpecificationFactory;

		// Token: 0x0400003B RID: 59
		private readonly AutoValueBehaviour _autoValueBehaviour;
	}
}
