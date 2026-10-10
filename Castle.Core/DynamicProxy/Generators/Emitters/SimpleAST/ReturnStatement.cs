using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000085 RID: 133
	public class ReturnStatement : Statement
	{
		// Token: 0x0600036D RID: 877 RVA: 0x0000CACA File Offset: 0x0000ACCA
		public ReturnStatement()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000CAD2 File Offset: 0x0000ACD2
		public ReturnStatement(Reference reference)
		{
			this.reference = reference;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000CAE1 File Offset: 0x0000ACE1
		public ReturnStatement(Expression expression)
		{
			this.expression = expression;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
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
			else if (member.ReturnType != typeof(void))
			{
				OpCodeUtil.EmitLoadOpCodeForDefaultValueOfType(gen, member.ReturnType);
			}
			gen.Emit(OpCodes.Ret);
		}

		// Token: 0x040000FE RID: 254
		private readonly Expression expression;

		// Token: 0x040000FF RID: 255
		private readonly Reference reference;
	}
}
