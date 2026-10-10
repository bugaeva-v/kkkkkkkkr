using System;
using System.Reflection;

namespace Castle.DynamicProxy.Internal
{
	// Token: 0x02000028 RID: 40
	public abstract class CompositionInvocation : AbstractInvocation
	{
		// Token: 0x06000153 RID: 339 RVA: 0x00005818 File Offset: 0x00003A18
		protected CompositionInvocation(object target, object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments) : base(proxy, interceptors, proxiedMethod, arguments)
		{
			this.target = target;
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000582D File Offset: 0x00003A2D
		public override object InvocationTarget
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00005835 File Offset: 0x00003A35
		public override MethodInfo MethodInvocationTarget
		{
			get
			{
				return InvocationHelper.GetMethodOnObject(this.target, base.Method);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00005848 File Offset: 0x00003A48
		public override Type TargetType
		{
			get
			{
				return TypeUtil.GetTypeOrNull(this.target);
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005855 File Offset: 0x00003A55
		protected void EnsureValidProxyTarget(object newTarget)
		{
			if (newTarget == null)
			{
				throw new ArgumentNullException("newTarget");
			}
			if (newTarget != this.proxyObject)
			{
				return;
			}
			throw new InvalidOperationException("This is a DynamicProxy2 error: target of proxy has been set to the proxy itself. This would result in recursively calling proxy methods over and over again until stack overflow, which may destabilize your program.This usually signifies a bug in the calling code. Make sure no interceptor sets proxy as its own target.");
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005879 File Offset: 0x00003A79
		protected void EnsureValidTarget()
		{
			if (this.target == null)
			{
				base.ThrowOnNoTarget();
			}
			if (this.target != this.proxyObject)
			{
				return;
			}
			throw new InvalidOperationException("This is a DynamicProxy2 error: target of invocation has been set to the proxy itself. This may result in recursively calling the method over and over again until stack overflow, which may destabilize your program.This usually signifies a bug in the calling code. Make sure no interceptor sets proxy as its invocation target.");
		}

		// Token: 0x04000063 RID: 99
		protected object target;
	}
}
