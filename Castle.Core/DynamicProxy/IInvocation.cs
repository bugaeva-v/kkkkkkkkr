using System;
using System.Reflection;

namespace Castle.DynamicProxy
{
	// Token: 0x0200000C RID: 12
	public interface IInvocation
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004D RID: 77
		object[] Arguments { get; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004E RID: 78
		Type[] GenericArguments { get; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004F RID: 79
		object InvocationTarget { get; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000050 RID: 80
		MethodInfo Method { get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000051 RID: 81
		MethodInfo MethodInvocationTarget { get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000052 RID: 82
		object Proxy { get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83
		// (set) Token: 0x06000054 RID: 84
		object ReturnValue { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000055 RID: 85
		Type TargetType { get; }

		// Token: 0x06000056 RID: 86
		object GetArgumentValue(int index);

		// Token: 0x06000057 RID: 87
		MethodInfo GetConcreteMethod();

		// Token: 0x06000058 RID: 88
		MethodInfo GetConcreteMethodInvocationTarget();

		// Token: 0x06000059 RID: 89
		void Proceed();

		// Token: 0x0600005A RID: 90
		IInvocationProceedInfo CaptureProceedInfo();

		// Token: 0x0600005B RID: 91
		void SetArgumentValue(int index, object value);
	}
}
