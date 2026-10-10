using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Tokens;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x02000091 RID: 145
	public class ClassProxyTargetContributor : CompositeTypeContributor
	{
		// Token: 0x0600039A RID: 922 RVA: 0x0000D31F File Offset: 0x0000B51F
		public ClassProxyTargetContributor(Type targetType, IList<MethodInfo> methodsToSkip, INamingScope namingScope) : base(namingScope)
		{
			this.targetType = targetType;
			this.methodsToSkip = methodsToSkip;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000D336 File Offset: 0x0000B536
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			ClassMembersCollector classMembersCollector = new ClassMembersCollector(this.targetType)
			{
				Logger = base.Logger
			};
			classMembersCollector.CollectMembersToProxy(hook);
			yield return classMembersCollector;
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

		// Token: 0x0600039C RID: 924 RVA: 0x0000D350 File Offset: 0x0000B550
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
			if (this.ExplicitlyImplementedInterfaceMethod(method))
			{
				return this.ExplicitlyImplementedInterfaceMethodGenerator(method, @class, options, overrideMethod);
			}
			Type invocationType = this.GetInvocationType(method, @class, options);
			GetTargetExpressionDelegate getTargetExpressionDelegate = (ClassEmitter c, MethodInfo m) => new TypeTokenExpression(this.targetType);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, getTargetExpressionDelegate, getTargetExpressionDelegate, overrideMethod, null);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		private Type BuildInvocationType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			MethodInfo method2 = method.Method;
			if (!method.HasTarget)
			{
				return new InheritanceInvocationTypeGenerator(this.targetType, method, null, null).Generate(@class, options, this.namingScope).BuildType();
			}
			MethodBuilder methodBuilder = this.CreateCallbackMethod(@class, method2, method.MethodOnTarget);
			return new InheritanceInvocationTypeGenerator(methodBuilder.DeclaringType, method, methodBuilder, null).Generate(@class, options, this.namingScope).BuildType();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000D434 File Offset: 0x0000B634
		private MethodBuilder CreateCallbackMethod(ClassEmitter emitter, MethodInfo methodInfo, MethodInfo methodOnTarget)
		{
			MethodInfo methodInfo2 = methodOnTarget ?? methodInfo;
			MethodEmitter methodEmitter = emitter.CreateMethod(this.namingScope.GetUniqueName(methodInfo.Name + "_callback"), methodInfo2);
			if (methodInfo2.IsGenericMethod)
			{
				methodInfo2 = methodInfo2.MakeGenericMethod(methodEmitter.GenericTypeParams.AsTypeArray());
			}
			Expression[] array = new Expression[methodEmitter.Arguments.Length];
			for (int i = 0; i < methodEmitter.Arguments.Length; i++)
			{
				array[i] = methodEmitter.Arguments[i].ToExpression();
			}
			methodEmitter.CodeBuilder.AddStatement(new ReturnStatement(new MethodInvocationExpression(SelfReference.Self, methodInfo2, array)));
			return methodEmitter.MethodBuilder;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000D4D9 File Offset: 0x0000B6D9
		private bool ExplicitlyImplementedInterfaceMethod(MetaMethod method)
		{
			return method.MethodOnTarget.IsPrivate;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		private MethodGenerator ExplicitlyImplementedInterfaceMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			Type delegateType = this.GetDelegateType(method, @class, options);
			IInvocationCreationContributor contributor = this.GetContributor(delegateType, method);
			Type invocation = new InheritanceInvocationTypeGenerator(this.targetType, method, null, contributor).Generate(@class, options, this.namingScope).BuildType();
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocation, (ClassEmitter c, MethodInfo m) => new TypeTokenExpression(this.targetType), overrideMethod, contributor);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000D54A File Offset: 0x0000B74A
		private IInvocationCreationContributor GetContributor(Type @delegate, MetaMethod method)
		{
			if (!@delegate.GetTypeInfo().IsGenericType)
			{
				return new InvocationWithDelegateContributor(@delegate, this.targetType, method, this.namingScope);
			}
			return new InvocationWithGenericDelegateContributor(@delegate, method, new FieldReference(InvocationMethods.ProxyObject));
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000D580 File Offset: 0x0000B780
		private Type GetDelegateType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			ModuleScope moduleScope = @class.ModuleScope;
			CacheKey key = new CacheKey(typeof(Delegate).GetTypeInfo(), this.targetType, new Type[]
			{
				method.MethodOnTarget.ReturnType
			}.Concat(ArgumentsUtil.GetTypes(method.MethodOnTarget.GetParameters())).ToArray<Type>(), null);
			return moduleScope.TypeCache.GetOrAddWithoutTakingLock(key, (CacheKey _) => new DelegateTypeGenerator(method, this.targetType).Generate(@class, options, this.namingScope).BuildType());
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000D627 File Offset: 0x0000B827
		private Type GetInvocationType(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options)
		{
			return this.BuildInvocationType(method, @class, options);
		}

		// Token: 0x0400010E RID: 270
		private readonly IList<MethodInfo> methodsToSkip;

		// Token: 0x0400010F RID: 271
		private readonly Type targetType;
	}
}
