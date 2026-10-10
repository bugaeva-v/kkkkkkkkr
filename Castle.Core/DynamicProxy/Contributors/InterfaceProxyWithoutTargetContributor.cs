using System;
using System.Collections.Generic;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A2 RID: 162
	public class InterfaceProxyWithoutTargetContributor : CompositeTypeContributor
	{
		// Token: 0x060003E8 RID: 1000 RVA: 0x0000E42E File Offset: 0x0000C62E
		public InterfaceProxyWithoutTargetContributor(INamingScope namingScope, GetTargetExpressionDelegate getTarget) : base(namingScope)
		{
			this.getTargetExpression = getTarget;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000E43E File Offset: 0x0000C63E
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			foreach (Type @interface in this.interfaces)
			{
				InterfaceMembersCollector interfaceMembersCollector = new InterfaceMembersCollector(@interface);
				interfaceMembersCollector.CollectMembersToProxy(hook);
				yield return interfaceMembersCollector;
			}
			IEnumerator<Type> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000E458 File Offset: 0x0000C658
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			if (!method.Proxyable)
			{
				return new MinimialisticMethodGenerator(method, overrideMethod);
			}
			Type invocationType = this.GetInvocationType(method, @class, options);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, this.getTargetExpression, overrideMethod, null);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000E49C File Offset: 0x0000C69C
		private Type GetInvocationType(MetaMethod method, ClassEmitter emitter, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = emitter.ModuleScope;
			Type[] interfaces;
			if (this.canChangeTarget)
			{
				interfaces = new Type[]
				{
					typeof(IInvocation),
					typeof(IChangeProxyTarget)
				};
			}
			else
			{
				interfaces = new Type[]
				{
					typeof(IInvocation)
				};
			}
			CacheKey key = new CacheKey(method.Method, CompositionInvocationTypeGenerator.BaseType, interfaces, null);
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => new CompositionInvocationTypeGenerator(method.Method.DeclaringType, method, method.Method, this.canChangeTarget, null).Generate(emitter, options, this.namingScope).BuildType());
		}

		// Token: 0x04000122 RID: 290
		private readonly GetTargetExpressionDelegate getTargetExpression;

		// Token: 0x04000123 RID: 291
		protected bool canChangeTarget;
	}
}
