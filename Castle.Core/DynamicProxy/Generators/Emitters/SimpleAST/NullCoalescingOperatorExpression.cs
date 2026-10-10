using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000080 RID: 128
	public class NullCoalescingOperatorExpression : Expression
	{
		// Token: 0x0600035A RID: 858 RVA: 0x0000C898 File Offset: 0x0000AA98
		public NullCoalescingOperatorExpression(Expression expression, Expression @default)
		{
			if (expression == null)
			{
				throw new ArgumentNullException("expression");
			}
			if (@default == null)
			{
				throw new ArgumentNullException("default");
			}
			this.expression = expression;
			this.@default = @default;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000C8CC File Offset: 0x0000AACC
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			this.expression.Emit(member, gen);
			gen.Emit(OpCodes.Dup);
			Label label = gen.DefineLabel();
			gen.Emit(OpCodes.Brtrue_S, label);
			gen.Emit(OpCodes.Pop);
			this.@default.Emit(member, gen);
			gen.MarkLabel(label);
		}

		// Token: 0x040000F8 RID: 248
		private readonly Expression @default;

		// Token: 0x040000F9 RID: 249
		private readonly Expression expression;
	}
}
