using System;
using Castle.DynamicProxy;
using NSubstitute.Core;

namespace NSubstitute.Proxies.CastleDynamicProxy
{
	// Token: 0x02000040 RID: 64
	public class CastleForwardingInterceptor : IInterceptor
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00004280 File Offset: 0x00002480
		public CastleForwardingInterceptor(CastleInvocationMapper invocationMapper, ICallRouter callRouter)
		{
			this._invocationMapper = invocationMapper;
			this._callRouter = callRouter;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00004298 File Offset: 0x00002498
		public void Intercept(IInvocation invocation)
		{
			ICall call = this._invocationMapper.Map(invocation);
			if (this._fullDispatchMode)
			{
				invocation.ReturnValue = this._callRouter.Route(call);
				return;
			}
			if (this._callRouter.CallBaseByDefault)
			{
				invocation.ReturnValue = call.TryCallBase().ValueOrDefault();
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000042EE File Offset: 0x000024EE
		public void SwitchToFullDispatchMode()
		{
			this._fullDispatchMode = true;
		}

		// Token: 0x04000053 RID: 83
		private readonly CastleInvocationMapper _invocationMapper;

		// Token: 0x04000054 RID: 84
		private readonly ICallRouter _callRouter;

		// Token: 0x04000055 RID: 85
		private bool _fullDispatchMode;
	}
}
