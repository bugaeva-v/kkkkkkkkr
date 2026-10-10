using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006C RID: 108
	public class ConvertExpression : Expression
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0000BDCC File Offset: 0x00009FCC
		public ConvertExpression(Type targetType, Expression right) : this(targetType, typeof(object), right)
		{
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		public ConvertExpression(Type targetType, Type fromType, Expression right)
		{
			this.target = targetType;
			this.fromType = fromType;
			this.right = right;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000BE00 File Offset: 0x0000A000
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			this.right.Emit(member, gen);
			if (this.fromType == this.target)
			{
				return;
			}
			if (this.fromType.GetTypeInfo().IsByRef)
			{
				this.fromType = this.fromType.GetElementType();
			}
			if (this.target.IsByRef)
			{
				this.target = this.target.GetElementType();
			}
			if (this.target.GetTypeInfo().IsValueType)
			{
				if (this.fromType.GetTypeInfo().IsValueType)
				{
					throw new NotImplementedException("Cannot convert between distinct value types");
				}
				if (LdindOpCodesDictionary.Instance[this.target] != LdindOpCodesDictionary.EmptyOpCode)
				{
					gen.Emit(OpCodes.Unbox, this.target);
					OpCodeUtil.EmitLoadIndirectOpCodeForType(gen, this.target);
					return;
				}
				gen.Emit(OpCodes.Unbox_Any, this.target);
				return;
			}
			else
			{
				if (this.fromType.GetTypeInfo().IsValueType)
				{
					gen.Emit(OpCodes.Box, this.fromType);
					ConvertExpression.EmitCastIfNeeded(typeof(object), this.target, gen);
					return;
				}
				ConvertExpression.EmitCastIfNeeded(this.fromType, this.target, gen);
				return;
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000BF38 File Offset: 0x0000A138
		private static void EmitCastIfNeeded(Type from, Type target, ILGenerator gen)
		{
			if (target.IsGenericParameter)
			{
				gen.Emit(OpCodes.Unbox_Any, target);
				return;
			}
			if (from.GetTypeInfo().IsGenericParameter)
			{
				gen.Emit(OpCodes.Box, from);
				return;
			}
			if (target.GetTypeInfo().IsGenericType && target != from)
			{
				gen.Emit(OpCodes.Castclass, target);
				return;
			}
			if (target.GetTypeInfo().IsSubclassOf(from))
			{
				gen.Emit(OpCodes.Castclass, target);
			}
		}

		// Token: 0x040000D8 RID: 216
		private readonly Expression right;

		// Token: 0x040000D9 RID: 217
		private Type fromType;

		// Token: 0x040000DA RID: 218
		private Type target;
	}
}
