using System;
using System.Reflection;

namespace Castle.DynamicProxy
{
	// Token: 0x02000004 RID: 4
	public abstract class AbstractInvocation : IInvocation
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000022C0 File Offset: 0x000004C0
		protected AbstractInvocation(object proxy, IInterceptor[] interceptors, MethodInfo proxiedMethod, object[] arguments)
		{
			this.proxyObject = proxy;
			this.interceptors = interceptors;
			this.proxiedMethod = proxiedMethod;
			this.arguments = arguments;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000022EC File Offset: 0x000004EC
		public void SetGenericMethodArguments(Type[] arguments)
		{
			this.genericMethodArguments = arguments;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15
		public abstract object InvocationTarget { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16
		public abstract Type TargetType { get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000011 RID: 17
		public abstract MethodInfo MethodInvocationTarget { get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000022F5 File Offset: 0x000004F5
		public Type[] GenericArguments
		{
			get
			{
				return this.genericMethodArguments;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000013 RID: 19 RVA: 0x000022FD File Offset: 0x000004FD
		public object Proxy
		{
			get
			{
				return this.proxyObject;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002305 File Offset: 0x00000505
		public MethodInfo Method
		{
			get
			{
				return this.proxiedMethod;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000230D File Offset: 0x0000050D
		public MethodInfo GetConcreteMethod()
		{
			return this.EnsureClosedMethod(this.Method);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000231B File Offset: 0x0000051B
		public MethodInfo GetConcreteMethodInvocationTarget()
		{
			return this.MethodInvocationTarget;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002323 File Offset: 0x00000523
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000232B File Offset: 0x0000052B
		public object ReturnValue { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002334 File Offset: 0x00000534
		public object[] Arguments
		{
			get
			{
				return this.arguments;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000233C File Offset: 0x0000053C
		public void SetArgumentValue(int index, object value)
		{
			this.arguments[index] = value;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002347 File Offset: 0x00000547
		public object GetArgumentValue(int index)
		{
			return this.arguments[index];
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002354 File Offset: 0x00000554
		public void Proceed()
		{
			if (this.interceptors == null)
			{
				this.InvokeMethodOnTarget();
				return;
			}
			this.currentInterceptorIndex++;
			try
			{
				if (this.currentInterceptorIndex == this.interceptors.Length)
				{
					this.InvokeMethodOnTarget();
				}
				else
				{
					if (this.currentInterceptorIndex > this.interceptors.Length)
					{
						throw new InvalidOperationException("Cannot proceed past the end of the interception pipeline. This likely signifies a bug in the calling code.");
					}
					this.interceptors[this.currentInterceptorIndex].Intercept(this);
				}
			}
			finally
			{
				this.currentInterceptorIndex--;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000023E8 File Offset: 0x000005E8
		public IInvocationProceedInfo CaptureProceedInfo()
		{
			return new AbstractInvocation.ProceedInfo(this);
		}

		// Token: 0x0600001E RID: 30
		protected abstract void InvokeMethodOnTarget();

		// Token: 0x0600001F RID: 31 RVA: 0x000023F0 File Offset: 0x000005F0
		protected void ThrowOnNoTarget()
		{
			string text;
			if (this.interceptors.Length == 0)
			{
				text = "There are no interceptors specified";
			}
			else
			{
				text = "The interceptor attempted to 'Proceed'";
			}
			string text2;
			string text3;
			if (this.Method.DeclaringType.GetTypeInfo().IsClass && this.Method.IsAbstract)
			{
				text2 = "is abstract";
				text3 = "an abstract method";
			}
			else
			{
				text2 = "has no target";
				text3 = "method without target";
			}
			throw new NotImplementedException(string.Format("This is a DynamicProxy2 error: {0} for method '{1}' which {2}. When calling {3} there is no implementation to 'proceed' to and it is the responsibility of the interceptor to mimic the implementation (set return value, out arguments etc)", new object[]
			{
				text,
				this.Method,
				text2,
				text3
			}));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000247C File Offset: 0x0000067C
		private MethodInfo EnsureClosedMethod(MethodInfo method)
		{
			if (method.ContainsGenericParameters)
			{
				return method.GetGenericMethodDefinition().MakeGenericMethod(this.genericMethodArguments);
			}
			return method;
		}

		// Token: 0x04000005 RID: 5
		private readonly IInterceptor[] interceptors;

		// Token: 0x04000006 RID: 6
		private readonly object[] arguments;

		// Token: 0x04000007 RID: 7
		private int currentInterceptorIndex = -1;

		// Token: 0x04000008 RID: 8
		private Type[] genericMethodArguments;

		// Token: 0x04000009 RID: 9
		private readonly MethodInfo proxiedMethod;

		// Token: 0x0400000A RID: 10
		protected readonly object proxyObject;

		// Token: 0x020001B5 RID: 437
		private sealed class ProceedInfo : IInvocationProceedInfo
		{
			// Token: 0x06000D80 RID: 3456 RVA: 0x00020949 File Offset: 0x0001EB49
			public ProceedInfo(AbstractInvocation invocation)
			{
				this.invocation = invocation;
				this.interceptorIndex = invocation.currentInterceptorIndex;
			}

			// Token: 0x06000D81 RID: 3457 RVA: 0x00020964 File Offset: 0x0001EB64
			public void Invoke()
			{
				int currentInterceptorIndex = this.invocation.currentInterceptorIndex;
				try
				{
					this.invocation.currentInterceptorIndex = this.interceptorIndex;
					this.invocation.Proceed();
				}
				finally
				{
					this.invocation.currentInterceptorIndex = currentInterceptorIndex;
				}
			}

			// Token: 0x040002EC RID: 748
			private readonly AbstractInvocation invocation;

			// Token: 0x040002ED RID: 749
			private readonly int interceptorIndex;
		}
	}
}
