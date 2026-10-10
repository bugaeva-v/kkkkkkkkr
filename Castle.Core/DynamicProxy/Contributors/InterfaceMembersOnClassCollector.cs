using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009E RID: 158
	public class InterfaceMembersOnClassCollector : MembersCollector
	{
		// Token: 0x060003DA RID: 986 RVA: 0x0000E0EF File Offset: 0x0000C2EF
		public InterfaceMembersOnClassCollector(Type type, bool onlyProxyVirtual, InterfaceMapping map) : base(type)
		{
			this.onlyProxyVirtual = onlyProxyVirtual;
			this.map = map;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000E108 File Offset: 0x0000C308
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (!ProxyUtil.IsAccessibleMethod(method))
			{
				return null;
			}
			if (this.onlyProxyVirtual && this.IsVirtuallyImplementedInterfaceMethod(method))
			{
				return null;
			}
			MethodInfo methodOnTarget = this.GetMethodOnTarget(method);
			bool proxyable = base.AcceptMethod(method, this.onlyProxyVirtual, hook);
			return new MetaMethod(method, methodOnTarget, isStandalone, proxyable, !methodOnTarget.IsPrivate);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000E15C File Offset: 0x0000C35C
		private MethodInfo GetMethodOnTarget(MethodInfo method)
		{
			int num = Array.IndexOf<MethodInfo>(this.map.InterfaceMethods, method);
			if (num == -1)
			{
				return null;
			}
			return this.map.TargetMethods[num];
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000E190 File Offset: 0x0000C390
		private bool IsVirtuallyImplementedInterfaceMethod(MethodInfo method)
		{
			MethodInfo methodOnTarget = this.GetMethodOnTarget(method);
			return methodOnTarget != null && !methodOnTarget.IsFinal;
		}

		// Token: 0x0400011D RID: 285
		private readonly InterfaceMapping map;

		// Token: 0x0400011E RID: 286
		private readonly bool onlyProxyVirtual;
	}
}
