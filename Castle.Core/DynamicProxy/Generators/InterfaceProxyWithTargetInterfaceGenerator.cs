using System;
using System.Collections.Generic;
using System.Reflection;
using Castle.DynamicProxy.Contributors;
using Castle.DynamicProxy.Generators.Emitters;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using Castle.DynamicProxy.Internal;
using Castle.DynamicProxy.Serialization;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x0200003E RID: 62
	public class InterfaceProxyWithTargetInterfaceGenerator : InterfaceProxyWithTargetGenerator
	{
		// Token: 0x060001E1 RID: 481 RVA: 0x00007ED0 File Offset: 0x000060D0
		public InterfaceProxyWithTargetInterfaceGenerator(ModuleScope scope, Type @interface) : base(scope, @interface)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007EDA File Offset: 0x000060DA
		protected override bool AllowChangeTarget
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007EDD File Offset: 0x000060DD
		protected override string GeneratorType
		{
			get
			{
				return ProxyTypeConstants.InterfaceWithTargetInterface;
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007EE4 File Offset: 0x000060E4
		protected override ITypeContributor AddMappingForTargetType(IDictionary<Type, ITypeContributor> typeImplementerMapping, Type proxyTargetType, ICollection<Type> targetInterfaces, ICollection<Type> additionalInterfaces, INamingScope namingScope)
		{
			InterfaceProxyWithTargetInterfaceTargetContributor interfaceProxyWithTargetInterfaceTargetContributor = new InterfaceProxyWithTargetInterfaceTargetContributor(proxyTargetType, this.AllowChangeTarget, namingScope)
			{
				Logger = base.Logger
			};
			foreach (Type @interface in this.targetType.GetAllInterfaces())
			{
				interfaceProxyWithTargetInterfaceTargetContributor.AddInterfaceToProxy(@interface);
				base.AddMappingNoCheck(@interface, interfaceProxyWithTargetInterfaceTargetContributor, typeImplementerMapping);
			}
			return interfaceProxyWithTargetInterfaceTargetContributor;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00007F3B File Offset: 0x0000613B
		protected override InterfaceProxyWithoutTargetContributor GetContributorForAdditionalInterfaces(INamingScope namingScope)
		{
			return new InterfaceProxyWithOptionalTargetContributor(namingScope, new GetTargetExpressionDelegate(this.GetTargetExpression), new GetTargetReferenceDelegate(this.GetTarget))
			{
				Logger = base.Logger
			};
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007F67 File Offset: 0x00006167
		private Reference GetTarget(ClassEmitter @class, MethodInfo method)
		{
			return new AsTypeReference(@class.GetField("__target"), method.DeclaringType);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00007F7F File Offset: 0x0000617F
		private Expression GetTargetExpression(ClassEmitter @class, MethodInfo method)
		{
			return this.GetTarget(@class, method).ToExpression();
		}
	}
}
