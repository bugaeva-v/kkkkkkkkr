using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A9 RID: 169
	public class MixinContributor : CompositeTypeContributor
	{
		// Token: 0x06000412 RID: 1042 RVA: 0x0000ED61 File Offset: 0x0000CF61
		public MixinContributor(INamingScope namingScope, bool canChangeTarget) : base(namingScope)
		{
			this.canChangeTarget = canChangeTarget;
			this.getTargetExpression = this.BuildGetTargetExpression();
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000ED98 File Offset: 0x0000CF98
		public IEnumerable<FieldReference> Fields
		{
			get
			{
				return this.fields.Values;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000EDA5 File Offset: 0x0000CFA5
		public void AddEmptyInterface(Type @interface)
		{
			this.empty.Add(@interface);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000EDB4 File Offset: 0x0000CFB4
		public override void Generate(ClassEmitter @class, ProxyGenerationOptions options)
		{
			foreach (Type type in this.interfaces)
			{
				this.fields[type] = this.BuildTargetField(@class, type);
			}
			foreach (Type type2 in this.empty)
			{
				this.fields[type2] = this.BuildTargetField(@class, type2);
			}
			base.Generate(@class, options);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000EE60 File Offset: 0x0000D060
		protected override IEnumerable<MembersCollector> CollectElementsToProxyInternal(IProxyGenerationHook hook)
		{
			foreach (Type type in this.interfaces)
			{
				MembersCollector membersCollector;
				if (type.GetTypeInfo().IsInterface)
				{
					membersCollector = new InterfaceMembersCollector(type);
				}
				else
				{
					membersCollector = new DelegateTypeMembersCollector(type);
				}
				membersCollector.CollectMembersToProxy(hook);
				yield return membersCollector;
			}
			IEnumerator<Type> enumerator = null;
			yield break;
			yield break;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x0000EE78 File Offset: 0x0000D078
		protected override MethodGenerator GetMethodGenerator(MetaMethod method, ClassEmitter @class, ProxyGenerationOptions options, OverrideMethodDelegate overrideMethod)
		{
			if (!method.Proxyable)
			{
				return new ForwardingMethodGenerator(method, overrideMethod, (ClassEmitter c, MethodInfo i) => this.fields[i.DeclaringType]);
			}
			Type invocationType = this.GetInvocationType(method, @class, options);
			return new MethodWithInvocationGenerator(method, @class.GetField("__interceptors"), invocationType, this.getTargetExpression, overrideMethod, null);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0000EEC7 File Offset: 0x0000D0C7
		private GetTargetExpressionDelegate BuildGetTargetExpression()
		{
			if (!this.canChangeTarget)
			{
				return (ClassEmitter c, MethodInfo m) => this.fields[m.DeclaringType].ToExpression();
			}
			return (ClassEmitter c, MethodInfo m) => new NullCoalescingOperatorExpression(new AsTypeReference(c.GetField("__target"), m.DeclaringType).ToExpression(), this.fields[m.DeclaringType].ToExpression());
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0000EEEC File Offset: 0x0000D0EC
		private FieldReference BuildTargetField(ClassEmitter @class, Type type)
		{
			string suggestedName = "__mixin_" + type.FullName.Replace(".", "_");
			return @class.CreateField(this.namingScope.GetUniqueName(suggestedName), type);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0000EF2C File Offset: 0x0000D12C
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

		// Token: 0x04000132 RID: 306
		private readonly bool canChangeTarget;

		// Token: 0x04000133 RID: 307
		private readonly IList<Type> empty = new List<Type>();

		// Token: 0x04000134 RID: 308
		private readonly IDictionary<Type, FieldReference> fields = new SortedDictionary<Type, FieldReference>(new FieldReferenceComparer());

		// Token: 0x04000135 RID: 309
		private readonly GetTargetExpressionDelegate getTargetExpression;
	}
}
