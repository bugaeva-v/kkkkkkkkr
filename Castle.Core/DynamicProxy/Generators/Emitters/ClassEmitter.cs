using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200004E RID: 78
	public class ClassEmitter : AbstractTypeEmitter
	{
		// Token: 0x06000287 RID: 647 RVA: 0x0000A27A File Offset: 0x0000847A
		public ClassEmitter(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces) : this(modulescope, name, baseType, interfaces, TypeAttributes.Public | TypeAttributes.Serializable, ClassEmitter.ShouldForceUnsigned())
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0000A291 File Offset: 0x00008491
		public ClassEmitter(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces, TypeAttributes flags) : this(modulescope, name, baseType, interfaces, flags, ClassEmitter.ShouldForceUnsigned())
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public ClassEmitter(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces, TypeAttributes flags, bool forceUnsigned) : this(ClassEmitter.CreateTypeBuilder(modulescope, name, baseType, interfaces, flags, forceUnsigned))
		{
			interfaces = this.InitializeGenericArgumentsFromBases(ref baseType, interfaces);
			if (interfaces != null)
			{
				foreach (Type type in interfaces)
				{
					if (type.GetTypeInfo().IsInterface)
					{
						base.TypeBuilder.AddInterfaceImplementation(type);
					}
				}
			}
			base.TypeBuilder.SetParent(baseType);
			this.moduleScope = modulescope;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0000A33C File Offset: 0x0000853C
		public ClassEmitter(TypeBuilder typeBuilder) : base(typeBuilder)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0000A345 File Offset: 0x00008545
		public ModuleScope ModuleScope
		{
			get
			{
				return this.moduleScope;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000A34D File Offset: 0x0000854D
		internal bool InStrongNamedModule
		{
			get
			{
				return base.TypeBuilder.Assembly.IsAssemblySigned();
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000A360 File Offset: 0x00008560
		protected virtual IEnumerable<Type> InitializeGenericArgumentsFromBases(ref Type baseType, IEnumerable<Type> interfaces)
		{
			if (baseType != null && baseType.GetTypeInfo().IsGenericTypeDefinition)
			{
				throw new NotSupportedException("ClassEmitter does not support open generic base types. Type: " + baseType.FullName);
			}
			if (interfaces == null)
			{
				return interfaces;
			}
			foreach (Type type in interfaces)
			{
				if (type.GetTypeInfo().IsGenericTypeDefinition)
				{
					throw new NotSupportedException("ClassEmitter does not support open generic interfaces. Type: " + type.FullName);
				}
			}
			return interfaces;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000A3FC File Offset: 0x000085FC
		private static TypeBuilder CreateTypeBuilder(ModuleScope modulescope, string name, Type baseType, IEnumerable<Type> interfaces, TypeAttributes flags, bool forceUnsigned)
		{
			bool inSignedModulePreferably = !forceUnsigned && !StrongNameUtil.IsAnyTypeFromUnsignedAssembly(baseType, interfaces);
			return modulescope.DefineType(inSignedModulePreferably, name, flags);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x0000A425 File Offset: 0x00008625
		private static bool ShouldForceUnsigned()
		{
			return !StrongNameUtil.CanStrongNameAssembly;
		}

		// Token: 0x040000AB RID: 171
		internal const TypeAttributes DefaultAttributes = TypeAttributes.Public | TypeAttributes.Serializable;

		// Token: 0x040000AC RID: 172
		private readonly ModuleScope moduleScope;
	}
}
