using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000073 RID: 115
	public class IfNullExpression : Expression
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0000C275 File Offset: 0x0000A475
		public IfNullExpression(Reference reference, IILEmitter ifNull, IILEmitter ifNotNull = null)
		{
			if (reference == null)
			{
				throw new ArgumentNullException("reference");
			}
			this.reference = reference;
			this.ifNull = ifNull;
			this.ifNotNull = ifNotNull;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000C2A1 File Offset: 0x0000A4A1
		public IfNullExpression(Expression expression, IILEmitter ifNull, IILEmitter ifNotNull = null)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			this.expression = expression;
			this.ifNull = ifNull;
			this.ifNotNull = ifNotNull;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			if (this.reference != null)
			{
				ArgumentsUtil.EmitLoadOwnerAndReference(this.reference, gen);
			}
			else if (this.expression != null)
			{
				this.expression.Emit(member, gen);
			}
			Label label = gen.DefineLabel();
			gen.Emit(OpCodes.Brtrue_S, label);
			this.ifNull.Emit(member, gen);
			gen.MarkLabel(label);
			if (this.ifNotNull != null)
			{
				this.ifNotNull.Emit(member, gen);
			}
		}

		// Token: 0x040000E0 RID: 224
		private readonly IILEmitter ifNotNull;

		// Token: 0x040000E1 RID: 225
		private readonly IILEmitter ifNull;

		// Token: 0x040000E2 RID: 226
		private readonly Reference reference;

		// Token: 0x040000E3 RID: 227
		private readonly Expression expression;
	}
}
