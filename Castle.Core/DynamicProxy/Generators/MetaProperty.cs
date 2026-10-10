using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000042 RID: 66
	public class MetaProperty : MetaTypeElement, IEquatable<MetaProperty>
	{
		// Token: 0x06000215 RID: 533 RVA: 0x00008A64 File Offset: 0x00006C64
		public MetaProperty(string name, Type propertyType, Type declaringType, MetaMethod getter, MetaMethod setter, IEnumerable<CustomAttributeBuilder> customAttributes, Type[] arguments) : base(declaringType)
		{
			this.name = name;
			this.type = propertyType;
			this.getter = getter;
			this.setter = setter;
			this.attributes = PropertyAttributes.None;
			this.customAttributes = customAttributes;
			this.arguments = (arguments ?? Type.EmptyTypes);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00008AB6 File Offset: 0x00006CB6
		public Type[] Arguments
		{
			get
			{
				return this.arguments;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00008ABE File Offset: 0x00006CBE
		public bool CanRead
		{
			get
			{
				return this.getter != null;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00008AC9 File Offset: 0x00006CC9
		public bool CanWrite
		{
			get
			{
				return this.setter != null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00008AD4 File Offset: 0x00006CD4
		public PropertyEmitter Emitter
		{
			get
			{
				if (this.emitter == null)
				{
					throw new InvalidOperationException("Emitter is not initialized. You have to initialize it first using 'BuildPropertyEmitter' method");
				}
				return this.emitter;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00008AEF File Offset: 0x00006CEF
		public MethodInfo GetMethod
		{
			get
			{
				if (!this.CanRead)
				{
					throw new InvalidOperationException();
				}
				return this.getter.Method;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00008B0A File Offset: 0x00006D0A
		public MetaMethod Getter
		{
			get
			{
				return this.getter;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00008B12 File Offset: 0x00006D12
		public MethodInfo SetMethod
		{
			get
			{
				if (!this.CanWrite)
				{
					throw new InvalidOperationException();
				}
				return this.setter.Method;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00008B2D File Offset: 0x00006D2D
		public MetaMethod Setter
		{
			get
			{
				return this.setter;
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00008B38 File Offset: 0x00006D38
		public void BuildPropertyEmitter(ClassEmitter classEmitter)
		{
			if (this.emitter != null)
			{
				throw new InvalidOperationException("Emitter is already created. It is illegal to invoke this method twice.");
			}
			this.emitter = classEmitter.CreateProperty(this.name, this.attributes, this.type, this.arguments);
			foreach (CustomAttributeBuilder attribute in this.customAttributes)
			{
				this.emitter.DefineCustomAttribute(attribute);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00008BC4 File Offset: 0x00006DC4
		public override bool Equals(object obj)
		{
			return obj != null && (this == obj || (!(obj.GetType() != typeof(MetaProperty)) && this.Equals((MetaProperty)obj)));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008BF8 File Offset: 0x00006DF8
		public override int GetHashCode()
		{
			return ((this.GetMethod != null) ? this.GetMethod.GetHashCode() : 0) * 397 ^ ((this.SetMethod != null) ? this.SetMethod.GetHashCode() : 0);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008C44 File Offset: 0x00006E44
		public bool Equals(MetaProperty other)
		{
			if (other == null)
			{
				return false;
			}
			if (this == other)
			{
				return true;
			}
			if (!this.type.Equals(other.type))
			{
				return false;
			}
			if (!StringComparer.OrdinalIgnoreCase.Equals(this.name, other.name))
			{
				return false;
			}
			if (this.Arguments.Length != other.Arguments.Length)
			{
				return false;
			}
			for (int i = 0; i < this.Arguments.Length; i++)
			{
				if (!this.Arguments[i].Equals(other.Arguments[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008CCC File Offset: 0x00006ECC
		internal override void SwitchToExplicitImplementation()
		{
			this.name = MetaTypeElementUtil.CreateNameForExplicitImplementation(this.sourceType, this.name);
			if (this.setter != null)
			{
				this.setter.SwitchToExplicitImplementation();
			}
			if (this.getter != null)
			{
				this.getter.SwitchToExplicitImplementation();
			}
		}

		// Token: 0x04000087 RID: 135
		private readonly Type[] arguments;

		// Token: 0x04000088 RID: 136
		private readonly PropertyAttributes attributes;

		// Token: 0x04000089 RID: 137
		private readonly IEnumerable<CustomAttributeBuilder> customAttributes;

		// Token: 0x0400008A RID: 138
		private readonly MetaMethod getter;

		// Token: 0x0400008B RID: 139
		private readonly MetaMethod setter;

		// Token: 0x0400008C RID: 140
		private readonly Type type;

		// Token: 0x0400008D RID: 141
		private PropertyEmitter emitter;

		// Token: 0x0400008E RID: 142
		private string name;
	}
}
