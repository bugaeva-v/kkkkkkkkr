using System;
using System.Collections.Generic;
using System.Reflection;

namespace Castle.DynamicProxy
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	public class AllMethodsHook : IProxyGenerationHook
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002499 File Offset: 0x00000699
		public virtual bool ShouldInterceptMethod(Type type, MethodInfo methodInfo)
		{
			return !AllMethodsHook.SkippedTypes.Contains(methodInfo.DeclaringType);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000024AE File Offset: 0x000006AE
		public virtual void NonProxyableMemberNotification(Type type, MemberInfo memberInfo)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000024B0 File Offset: 0x000006B0
		public virtual void MethodsInspected()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000024B2 File Offset: 0x000006B2
		public override bool Equals(object obj)
		{
			return obj != null && obj.GetType() == base.GetType();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000024CA File Offset: 0x000006CA
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}

		// Token: 0x0400000C RID: 12
		protected static readonly ICollection<Type> SkippedTypes = new Type[]
		{
			typeof(object),
			typeof(MarshalByRefObject),
			typeof(ContextBoundObject)
		};
	}
}
