using System;
using System.Collections.Generic;
using Castle.DynamicProxy;
using NSubstitute.Core;
using NSubstitute.Core.Arguments;

namespace NSubstitute.Proxies.CastleDynamicProxy
{
	// Token: 0x02000041 RID: 65
	public class CastleInvocationMapper
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x000042F7 File Offset: 0x000024F7
		public CastleInvocationMapper(ICallFactory callFactory, IArgumentSpecificationDequeue argSpecificationDequeue)
		{
			this._callFactory = callFactory;
			this._argSpecificationDequeue = argSpecificationDequeue;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00004310 File Offset: 0x00002510
		public virtual ICall Map(IInvocation castleInvocation)
		{
			Func<object> baseMethod = null;
			if (castleInvocation.InvocationTarget != null && castleInvocation.MethodInvocationTarget.IsVirtual && !castleInvocation.MethodInvocationTarget.IsAbstract && !castleInvocation.MethodInvocationTarget.IsFinal)
			{
				baseMethod = CastleInvocationMapper.CreateBaseResultInvocation(castleInvocation);
			}
			IList<IArgumentSpecification> argumentSpecifications = this._argSpecificationDequeue.DequeueAllArgumentSpecificationsForMethod(castleInvocation.Arguments.Length);
			return this._callFactory.Create(castleInvocation.Method, castleInvocation.Arguments, castleInvocation.Proxy, argumentSpecifications, baseMethod);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00004388 File Offset: 0x00002588
		private static Func<object> CreateBaseResultInvocation(IInvocation invocation)
		{
			Func<object> valueFactory = delegate()
			{
				invocation.Proceed();
				return invocation.ReturnValue;
			};
			Lazy<object> result = new Lazy<object>(valueFactory);
			return () => result.Value;
		}

		// Token: 0x04000056 RID: 86
		private readonly ICallFactory _callFactory;

		// Token: 0x04000057 RID: 87
		private readonly IArgumentSpecificationDequeue _argSpecificationDequeue;
	}
}
