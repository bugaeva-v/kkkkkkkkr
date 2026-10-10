using System;
using System.Linq;
using NSubstitute.Core;

namespace NSubstitute.Routing.Handlers
{
	// Token: 0x02000025 RID: 37
	public class PropertySetterHandler : ICallHandler
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000035BD File Offset: 0x000017BD
		public PropertySetterHandler(IPropertyHelper propertyHelper, IConfigureCall configureCall)
		{
			this._propertyHelper = propertyHelper;
			this._configureCall = configureCall;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000035D4 File Offset: 0x000017D4
		public RouteAction Handle(ICall call)
		{
			if (this._propertyHelper.IsCallToSetAReadWriteProperty(call))
			{
				ICall call2 = this._propertyHelper.CreateCallToPropertyGetterFromSetterCall(call);
				object value = call.GetOriginalArguments().Last<object>();
				this._configureCall.SetResultForCall(call2, new ReturnValue(value), MatchArgs.AsSpecifiedInCall);
			}
			return RouteAction.Continue();
		}

		// Token: 0x0400002C RID: 44
		private readonly IPropertyHelper _propertyHelper;

		// Token: 0x0400002D RID: 45
		private readonly IConfigureCall _configureCall;
	}
}
