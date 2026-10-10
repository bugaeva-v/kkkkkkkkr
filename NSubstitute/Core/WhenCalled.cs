using System;
using NSubstitute.Routing;

namespace NSubstitute.Core
{
	// Token: 0x020000BC RID: 188
	public class WhenCalled<T>
	{
		// Token: 0x0600030B RID: 779 RVA: 0x00007C7C File Offset: 0x00005E7C
		public WhenCalled(ISubstitutionContext context, T substitute, Action<T> call, MatchArgs matchArgs)
		{
			this._substitute = substitute;
			this._call = call;
			this._matchArgs = matchArgs;
			this._callRouter = context.GetCallRouterFor(substitute);
			this._routeFactory = context.RouteFactory;
			this._threadContext = context.ThreadContext;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00007CD0 File Offset: 0x00005ED0
		public void Do(Action<CallInfo> callbackWithArguments)
		{
			this._threadContext.SetNextRoute(this._callRouter, (ISubstituteState x) => this._routeFactory.DoWhenCalled(x, callbackWithArguments, this._matchArgs));
			this._call(this._substitute);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00007D20 File Offset: 0x00005F20
		public void Do(Callback callback)
		{
			this._threadContext.SetNextRoute(this._callRouter, (ISubstituteState x) => this._routeFactory.DoWhenCalled(x, new Action<CallInfo>(callback.Call), this._matchArgs));
			this._call(this._substitute);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00007D6F File Offset: 0x00005F6F
		public void DoNotCallBase()
		{
			this._threadContext.SetNextRoute(this._callRouter, (ISubstituteState x) => this._routeFactory.DoNotCallBase(x, this._matchArgs));
			this._call(this._substitute);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00007D9F File Offset: 0x00005F9F
		public void CallBase()
		{
			this._threadContext.SetNextRoute(this._callRouter, (ISubstituteState x) => this._routeFactory.CallBase(x, this._matchArgs));
			this._call(this._substitute);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00007DD0 File Offset: 0x00005FD0
		public void Throw(Exception exception)
		{
			this.Do(delegate(CallInfo ci)
			{
				throw exception;
			});
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00007DFC File Offset: 0x00005FFC
		public TException Throw<TException>() where TException : Exception, new()
		{
			TException exception = Activator.CreateInstance<TException>();
			this.Do(delegate(CallInfo _)
			{
				throw exception;
			});
			return exception;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00007E34 File Offset: 0x00006034
		public void Throw(Func<CallInfo, Exception> createException)
		{
			this.Do(delegate(CallInfo ci)
			{
				throw createException(ci);
			});
		}

		// Token: 0x040000DE RID: 222
		private readonly T _substitute;

		// Token: 0x040000DF RID: 223
		private readonly Action<T> _call;

		// Token: 0x040000E0 RID: 224
		private readonly MatchArgs _matchArgs;

		// Token: 0x040000E1 RID: 225
		private readonly ICallRouter _callRouter;

		// Token: 0x040000E2 RID: 226
		private readonly IThreadLocalContext _threadContext;

		// Token: 0x040000E3 RID: 227
		private readonly IRouteFactory _routeFactory;
	}
}
