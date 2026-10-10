using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000093 RID: 147
	public class ClassProxyWithTargetTargetContributor : CompositeTypeContributor
	{
		// Token: 0x060003A8 RID: 936 RVA: 0x0000D666 File Offset: 0x0000B866
		public ClassProxyWithTargetTargetContributor(Type targetType, IList<MethodInfo> methodsToSkip, INamingScope namingScope) : base(namingScope)
		{
			this.targetType = targetType;
			this.methodsToSkip = methodsToSkip;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000D67D File Offset: 0x0000B87D
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			WrappedClassMembersCollector wrappedClassMembersCollector = new WrappedClassMembersCollector(this.targetType)
			{
				Logger = base.Logger
			};
			wrappedClassMembersCollector.CollectMembersToProxy(hook);
			yield return wrappedClassMembersCollector;
			foreach (Type type in this.interfaces)
			{
				InterfaceMembersOnClassCollector interfaceMembersOnClassCollector = new InterfaceMembersOnClassCollector(type, true, this.targetType.GetTypeInfo().GetRuntimeInterfaceMap(type))
				{
					Logger = base.Logger
				};
				interfaceMembersOnClassCollector.CollectMembersToProxy(hook);
				yield return interfaceMembersOnClassCollector;
			}
			IEnumerator<Type> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000D694 File Offset: 0x0000B894
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			if (this.methodsToSkip.Contains(method.Method))
			{
				return null;
			}
			if (!method.Proxyable)
			{
				return new MinimialisticMethodGenerator(method, overrideMethod);
			}
			if (!this.IsDirectlyAccessible(method))
			{
				return this.IndirectlyCalledMethodGenerator(method, @class, options, overrideMethod);
			}
			Type invocationType = this.GetInvocationType(method, @class, options);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, (ClassEmitter c, MethodInfo m) => c.GetField("__target").ToExpression(), overrideMethod, null);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000D71C File Offset: 0x0000B91C
		private Type BuildInvocationType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			if (!method.HasTarget)
			{
				return new InheritanceInvocationTypeGenerator(this.targetType, method, null, null).Generate(@class, options, this.namingScope).BuildType();
			}
			return new CompositionInvocationTypeGenerator(method.Method.DeclaringType, method, method.Method, false, null).Generate(@class, options, this.namingScope).BuildType();
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000D77D File Offset: 0x0000B97D
		private IInvocationCreationContributor GetContributor(Type @delegate, MetaMethod method)
		{
			if (!@delegate.GetTypeInfo().IsGenericType)
			{
				return new InvocationWithDelegateContributor(@delegate, this.targetType, method, this.namingScope);
			}
			return new InvocationWithGenericDelegateContributor(@delegate, method, new FieldReference(InvocationMethods.CompositionInvocationTarget));
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000D7B4 File Offset: 0x0000B9B4
		private Type GetDelegateType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = @class.ModuleScope;
			CacheKey key = new CacheKey(typeof(Delegate).GetTypeInfo(), this.targetType, new Type[]
			{
				method.MethodOnTarget.ReturnType
			}.Concat(ArgumentsUtil.GetTypes(method.MethodOnTarget.GetParameters())).ToArray<Type>(), null);
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => new DelegateTypeGenerator(method, this.targetType).Generate(@class, options, this.namingScope).BuildType());
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000D85C File Offset: 0x0000BA5C
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = @class.ModuleScope;
			Type[] interfaces = new Type[]
			{
				typeof(IInvocation)
			};
			CacheKey key = new CacheKey(method.Method, CompositionInvocationTypeGenerator.BaseType, interfaces, null);
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => this.BuildInvocationType(method, @class, options));
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000D8DC File Offset: 0x0000BADC
		private MethodGenerator IndirectlyCalledMethodGenerator(MetaMethod method, ClassEmitter proxy, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			Type delegateType = this.GetDelegateType(method, proxy, options);
			IInvocationCreationContributor contributor = this.GetContributor(delegateType, method);
			Type invocation = new CompositionInvocationTypeGenerator(this.targetType, method, null, false, contributor).Generate(proxy, options, this.namingScope).BuildType();
			return new MethodWithInvocationGenerator(method, proxy.GetField("__interceptors"), invocation, (ClassEmitter c, MethodInfo m) => c.GetField("__target").ToExpression(), overrideMethod, contributor);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000D952 File Offset: 0x0000BB52
		private bool IsDirectlyAccessible(MetaMethod method)
		{
			return method.MethodOnTarget.IsPublic;
		}

		// Token: 0x04000110 RID: 272
		private readonly IList<MethodInfo> methodsToSkip;

		// Token: 0x04000111 RID: 273
		private readonly Type targetType;
	}
}
