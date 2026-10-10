using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x0200005B RID: 91
	public class NestedClassEmitter : AbstractTypeEmitter
	{
		// Token: 0x060002D4 RID: 724 RVA: 0x0000B149 File Offset: 0x00009349
		public NestedClassEmitter(AbstractTypeEmitter maintype, string name, Type baseType, Type[] interfaces) : this(maintype, NestedClassEmitter.CreateTypeBuilder(maintype, name, TypeAttributes.NestedPublic | TypeAttributes.Sealed, baseType, interfaces))
		{
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B161 File Offset: 0x00009361
		public NestedClassEmitter(AbstractTypeEmitter maintype, string name, TypeAttributes attributes, Type baseType, Type[] interfaces) : this(maintype, NestedClassEmitter.CreateTypeBuilder(maintype, name, attributes, baseType, interfaces))
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B176 File Offset: 0x00009376
		public NestedClassEmitter(AbstractTypeEmitter maintype, TypeBuilder typeBuilder) : base(typeBuilder)
		{
			maintype.Nested.Add(this);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B18B File Offset: 0x0000938B
		private static TypeBuilder CreateTypeBuilder(AbstractTypeEmitter maintype, string name, TypeAttributes attributes, Type baseType, Type[] interfaces)
		{
			return maintype.TypeBuilder.DefineNestedType(name, attributes, baseType, interfaces);
		}
	}
}
