using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A0 RID: 160
	public class InterfaceProxyTargetContributor : CompositeTypeContributor
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x0000E281 File Offset: 0x0000C481
		public InterfaceProxyTargetContributor(Type proxyTargetType, bool canChangeTarget, INamingScope namingScope) : base(namingScope)
		{
			this.proxyTargetType = proxyTargetType;
			this.canChangeTarget = canChangeTarget;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0000E298 File Offset: 0x0000C498
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			foreach (Type @interface in this.interfaces)
			{
				MembersCollector collectorForInterface = this.GetCollectorForInterface(@interface);
				collectorForInterface.Logger = base.Logger;
				collectorForInterface.CollectMembersToProxy(hook);
				yield return collectorForInterface;
			}
			IEnumerator<Type> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x0000E2AF File Offset: 0x0000C4AF
		protected virtual MembersCollector GetCollectorForInterface(Type @interface)
		{
			return new InterfaceMembersOnClassCollector(@interface, false, this.proxyTargetType.GetTypeInfo().GetRuntimeInterfaceMap(@interface));
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000E2CC File Offset: 0x0000C4CC
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			if (!method.Proxyable)
			{
				return new ForwardingMethodGenerator(method, overrideMethod, (ClassEmitter c, MethodInfo m) => c.GetField("__target"));
			}
			Type invocationType = this.GetInvocationType(method, @class, options);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, (ClassEmitter c, MethodInfo m) => c.GetField("__target").ToExpression(), overrideMethod, null);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x0000E348 File Offset: 0x0000C548
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = @class.ModuleScope;
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
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => new CompositionInvocationTypeGenerator(method.Method.DeclaringType, method, method.Method, this.canChangeTarget, null).Generate(@class, options, this.namingScope).BuildType());
		}

		// Token: 0x0400011F RID: 287
		private readonly bool canChangeTarget;

		// Token: 0x04000120 RID: 288
		private readonly Type proxyTargetType;
	}
}
