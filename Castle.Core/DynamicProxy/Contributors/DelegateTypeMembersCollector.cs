using System;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Internal;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x0200009A RID: 154
	internal sealed class DelegateTypeMembersCollector : MembersCollector
	{
		// Token: 0x060003D2 RID: 978 RVA: 0x0000DFD5 File Offset: 0x0000C1D5
		public DelegateTypeMembersCollector(Type delegateType) : base(delegateType)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000DFDE File Offset: 0x0000C1DE
		protected override MetaMethod GetMethodToGenerate(MethodInfo method, IProxyGenerationHook hook, bool isStandalone)
		{
			if (method.Name == "Invoke" && method.DeclaringType.IsDelegateType())
			{
				return new MetaMethod(method, method, isStandalone, true, false);
			}
			return null;
		}
	}
}
