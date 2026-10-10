using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200005E RID: 94
	public class PropertyEmitter : IMemberEmitter
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0000B570 File Offset: 0x00009770
		public PropertyEmitter(AbstractTypeEmitter parentTypeEmitter, string name, PropertyAttributes attributes, Type propertyType, Type[] arguments)
		{
			this.parentTypeEmitter = parentTypeEmitter;
			this.builder = parentTypeEmitter.TypeBuilder.DefineProperty(name, attributes, CallingConventions.HasThis, propertyType, null, null, arguments, null, null);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x0000B5A7 File Offset: 0x000097A7
		public MemberInfo Member
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x0000B5AA File Offset: 0x000097AA
		public Type ReturnType
		{
			get
			{
				return this.builder.PropertyType;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B5B7 File Offset: 0x000097B7
		public MethodEmitter CreateGetMethod(string name, MethodAttributes attrs, MethodInfo methodToOverride, params Type[] parameters)
		{
			if (this.getMethod != null)
			{
				throw new InvalidOperationException("A get method exists");
			}
			this.getMethod = new MethodEmitter(this.parentTypeEmitter, name, attrs, methodToOverride);
			return this.getMethod;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B5E6 File Offset: 0x000097E6
		public MethodEmitter CreateGetMethod(string name, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return this.CreateGetMethod(name, attributes, methodToOverride, Type.EmptyTypes);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B5F6 File Offset: 0x000097F6
		public MethodEmitter CreateSetMethod(string name, MethodAttributes attrs, MethodInfo methodToOverride, params Type[] parameters)
		{
			if (this.setMethod != null)
			{
				throw new InvalidOperationException("A set method exists");
			}
			this.setMethod = new MethodEmitter(this.parentTypeEmitter, name, attrs, methodToOverride);
			return this.setMethod;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B625 File Offset: 0x00009825
		public MethodEmitter CreateSetMethod(string name, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			return this.CreateSetMethod(name, attributes, methodToOverride, Type.EmptyTypes);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B635 File Offset: 0x00009835
		public void DefineCustomAttribute(CustomAttributeBuilder attribute)
		{
			this.builder.SetCustomAttribute(attribute);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000B643 File Offset: 0x00009843
		public void EnsureValidCodeBlock()
		{
			if (this.setMethod != null)
			{
				this.setMethod.EnsureValidCodeBlock();
			}
			if (this.getMethod != null)
			{
				this.getMethod.EnsureValidCodeBlock();
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000B66C File Offset: 0x0000986C
		public void Generate()
		{
			if (this.setMethod != null)
			{
				this.setMethod.Generate();
				this.builder.SetSetMethod(this.setMethod.MethodBuilder);
			}
			if (this.getMethod != null)
			{
				this.getMethod.Generate();
				this.builder.SetGetMethod(this.getMethod.MethodBuilder);
			}
		}

		// Token: 0x040000BD RID: 189
		private readonly PropertyBuilder builder;

		// Token: 0x040000BE RID: 190
		private readonly AbstractTypeEmitter parentTypeEmitter;

		// Token: 0x040000BF RID: 191
		private MethodEmitter getMethod;

		// Token: 0x040000C0 RID: 192
		private MethodEmitter setMethod;
	}
}
