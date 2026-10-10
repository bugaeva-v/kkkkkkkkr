using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000052 RID: 82
	public class EventEmitter : IMemberEmitter
	{
		// Token: 0x0600029B RID: 667 RVA: 0x0000A544 File Offset: 0x00008744
		public EventEmitter(AbstractTypeEmitter typeEmitter, string name, EventAttributes attributes, Type type)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.typeEmitter = typeEmitter;
			this.type = type;
			this.eventBuilder = typeEmitter.TypeBuilder.DefineEvent(name, attributes, type);
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600029C RID: 668 RVA: 0x0000A59E File Offset: 0x0000879E
		public MemberInfo Member
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000A5A1 File Offset: 0x000087A1
		public Type ReturnType
		{
			get
			{
				return this.type;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A5A9 File Offset: 0x000087A9
		public MethodEmitter CreateAddMethod(string addMethodName, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			if (this.addMethod != null)
			{
				throw new InvalidOperationException("An add method exists");
			}
			this.addMethod = new MethodEmitter(this.typeEmitter, addMethodName, attributes, methodToOverride);
			return this.addMethod;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000A5D8 File Offset: 0x000087D8
		public MethodEmitter CreateRemoveMethod(string removeMethodName, MethodAttributes attributes, MethodInfo methodToOverride)
		{
			if (this.removeMethod != null)
			{
				throw new InvalidOperationException("A remove method exists");
			}
			this.removeMethod = new MethodEmitter(this.typeEmitter, removeMethodName, attributes, methodToOverride);
			return this.removeMethod;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A607 File Offset: 0x00008807
		public void EnsureValidCodeBlock()
		{
			this.addMethod.EnsureValidCodeBlock();
			this.removeMethod.EnsureValidCodeBlock();
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000A620 File Offset: 0x00008820
		public void Generate()
		{
			if (this.addMethod == null)
			{
				throw new InvalidOperationException("Event add method was not created");
			}
			if (this.removeMethod == null)
			{
				throw new InvalidOperationException("Event remove method was not created");
			}
			this.addMethod.Generate();
			this.eventBuilder.SetAddOnMethod(this.addMethod.MethodBuilder);
			this.removeMethod.Generate();
			this.eventBuilder.SetRemoveOnMethod(this.removeMethod.MethodBuilder);
		}

		// Token: 0x040000B0 RID: 176
		private readonly EventBuilder eventBuilder;

		// Token: 0x040000B1 RID: 177
		private readonly Type type;

		// Token: 0x040000B2 RID: 178
		private readonly AbstractTypeEmitter typeEmitter;

		// Token: 0x040000B3 RID: 179
		private MethodEmitter addMethod;

		// Token: 0x040000B4 RID: 180
		private MethodEmitter removeMethod;
	}
}
