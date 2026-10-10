using System;
using System.Reflection;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x02000029 RID: 41
	public abstract class InheritanceInvocation : AbstractInvocation
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000058A2 File Offset: 0x00003AA2
		protected InheritanceInvocation(Type targetType, object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments) : base(proxy, interceptors, proxiedMethod, arguments)
		{
			this.targetType = targetType;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600015A RID: 346 RVA: 0x000058B7 File Offset: 0x00003AB7
		public override object InvocationTarget
		{
			get
			{
				return base.Proxy;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000058BF File Offset: 0x00003ABF
		public override MethodInfo MethodInvocationTarget
		{
			get
			{
				return InvocationHelper.GetMethodOnType(this.targetType, base.Method);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000058D2 File Offset: 0x00003AD2
		public override Type TargetType
		{
			get
			{
				return this.targetType;
			}
		}

		// Token: 0x0600015D RID: 349
		protected abstract override void InvokeMethodOnTarget();

		// Token: 0x04000064 RID: 100
		private readonly Type targetType;
	}
}
