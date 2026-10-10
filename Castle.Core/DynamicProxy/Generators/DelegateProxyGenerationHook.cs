using System;
using System.Reflection;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000034 RID: 52
	public class DelegateProxyGenerationHook : IProxyGenerationHook
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00007228 File Offset: 0x00005428
		public override bool Equals(object obj)
		{
			return obj != null && obj.GetType() == typeof(DelegateProxyGenerationHook);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007244 File Offset: 0x00005444
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007251 File Offset: 0x00005451
		public void MethodsInspected()
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00007253 File Offset: 0x00005453
		public void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00007255 File Offset: 0x00005455
		public bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
		{
			return methodInfo.Name.Equals("Invoke");
		}
	}
}
