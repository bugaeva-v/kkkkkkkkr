using System;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007C RID: 124
	public class MultiStatementExpression : Expression
	{
		// Token: 0x0600034F RID: 847 RVA: 0x0000C717 File Offset: 0x0000A917
		public void AddStatement(Statement statement)
		{
			this.statements.Add(statement);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000C725 File Offset: 0x0000A925
		public void AddExpression(Expression expression)
		{
			this.AddStatement(new ExpressionStatement(expression));
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000C734 File Offset: 0x0000A934
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			foreach (Statement statement in this.statements)
			{
				statement.Emit(member, gen);
			}
		}

		// Token: 0x040000F1 RID: 241
		private readonly List<Statement> statements = new List<Statement>();
	}
}
