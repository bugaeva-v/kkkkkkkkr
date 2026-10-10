using System;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A1 RID: 161
	public class InterfaceProxyWithOptionalTargetContributor : InterfaceProxyWithoutTargetContributor
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x0000E3F2 File Offset: 0x0000C5F2
		public InterfaceProxyWithOptionalTargetContributor(INamingScope namingScope, GetTargetExpressionDelegate getTarget, GetTargetReferenceDelegate getTargetReference) : base(namingScope, getTarget)
		{
			this.getTargetReference = getTargetReference;
			this.canChangeTarget = true;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0000E40A File Offset: 0x0000C60A
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			if (!method.Proxyable)
			{
				return new OptionallyForwardingMethodGenerator(method, overrideMethod, this.getTargetReference);
			}
			return base.GetMethodGenerator(method, @class, options, overrideMethod);
		}

		// Token: 0x04000121 RID: 289
		private readonly GetTargetReferenceDelegate getTargetReference;
	}
}
