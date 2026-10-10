using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000064 RID: 100
	public class AssignArgumentStatement : Statement
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public AssignArgumentStatement(ArgumentReference argument, Expression expression)
		{
			this.argument = argument;
			this.expression = expression;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000BAA2 File Offset: 0x00009CA2
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.argument, gen);
			this.expression.Emit(member, gen);
		}

		// Token: 0x040000C8 RID: 200
		private readonly ArgumentReference argument;

		// Token: 0x040000C9 RID: 201
		private readonly Expression expression;
	}
}
