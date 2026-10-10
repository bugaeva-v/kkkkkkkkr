using System;
using System.Reflection;

namespace Castle.DynamicProxy
{
	// Token: 0x02000011 RID: 17
	public interface IProxyGenerationHook
	{
		// Token: 0x0600006D RID: 109
		void MethodsInspected();

		// Token: 0x0600006E RID: 110
		void NonProxyableMemberNotification(Type type, MemberInfo memberInfo);

		// Token: 0x0600006F RID: 111
		bool ShouldInterceptMethod(Type type, MethodInfo methodInfo);
	}
}
