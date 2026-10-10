using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000070 RID: 112
	public class ExpressionStatement : Statement
	{
		// Token: 0x06000324 RID: 804 RVA: 0x0000C159 File Offset: 0x0000A359
		public ExpressionStatement(Expression expression)
		{
			this.expression = expression;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000C168 File Offset: 0x0000A368
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			this.expression.Emit(member, gen);
		}

		// Token: 0x040000DC RID: 220
		private readonly Expression expression;
	}
}
