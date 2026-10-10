using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006D RID: 109
	public class DefaultValueExpression : Expression
	{
		// Token: 0x0600031C RID: 796 RVA: 0x0000BFB1 File Offset: 0x0000A1B1
		public DefaultValueExpression(Type type)
		{
			this.type = type;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000BFC0 File Offset: 0x0000A1C0
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			if (this.IsPrimitiveOrClass(this.type))
			{
				OpCodeUtil.EmitLoadOpCodeForDefaultValueOfType(gen, this.type);
				return;
			}
			if (this.type.GetTypeInfo().IsValueType || this.type.GetTypeInfo().IsGenericParameter)
			{
				LocalBuilder local = gen.DeclareLocal(this.type);
				gen.Emit(OpCodes.Ldloca_S, local);
				gen.Emit(OpCodes.Initobj, this.type);
				gen.Emit(OpCodes.Ldloc, local);
				return;
			}
			if (this.type.GetTypeInfo().IsByRef)
			{
				this.EmitByRef(gen);
				return;
			}
			throw new ProxyGenerationException("Can't emit default value for type " + this.type);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C074 File Offset: 0x0000A274
		private void EmitByRef(ILGenerator gen)
		{
			Type elementType = this.type.GetElementType();
			if (this.IsPrimitiveOrClass(elementType))
			{
				OpCodeUtil.EmitLoadOpCodeForDefaultValueOfType(gen, elementType);
				OpCodeUtil.EmitStoreIndirectOpCodeForType(gen, elementType);
				return;
			}
			if (elementType.GetTypeInfo().IsGenericParameter || elementType.GetTypeInfo().IsValueType)
			{
				gen.Emit(OpCodes.Initobj, elementType);
				return;
			}
			throw new ProxyGenerationException("Can't emit default value for reference of type " + elementType);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000C0DC File Offset: 0x0000A2DC
		private bool IsPrimitiveOrClass(Type type)
		{
			return (type.GetTypeInfo().IsPrimitive && type != typeof(IntPtr)) || ((type.GetTypeInfo().IsClass || type.GetTypeInfo().IsInterface) && !type.GetTypeInfo().IsGenericParameter && !type.GetTypeInfo().IsByRef);
		}

		// Token: 0x040000DB RID: 219
		private readonly Type type;
	}
}
