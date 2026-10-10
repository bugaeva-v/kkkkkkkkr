using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000095 RID: 149
	public class DelegateProxyTargetContributor : CompositeTypeContributor
	{
		// Token: 0x060003BC RID: 956 RVA: 0x0000DD24 File Offset: 0x0000BF24
		public DelegateProxyTargetContributor(Type targetType, INamingScope namingScope) : base(namingScope)
		{
			this.targetType = targetType;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000DD34 File Offset: 0x0000BF34
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			DelegateMembersCollector delegateMembersCollector = new DelegateMembersCollector(this.targetType)
			{
				Logger = base.Logger
			};
			delegateMembersCollector.CollectMembersToProxy(hook);
			yield return delegateMembersCollector;
			yield break;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			Type invocationType = this.GetInvocationType(method, @class, options);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, (ClassEmitter c, MethodInfo m) => c.GetField("__target").ToExpression(), overrideMethod, null);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000DD98 File Offset: 0x0000BF98
		private Type GetInvocationType(MetaMethod method, ClassEmitter emitter, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = emitter.ModuleScope;
			CacheKey key = new CacheKey(method.Method, CompositionInvocationTypeGenerator.BaseType, null, null);
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => new CompositionInvocationTypeGenerator(method.Method.DeclaringType, method, method.Method, false, null).Generate(emitter, options, this.namingScope).BuildType());
		}

		// Token: 0x04000118 RID: 280
		private readonly Type targetType;
	}
}
