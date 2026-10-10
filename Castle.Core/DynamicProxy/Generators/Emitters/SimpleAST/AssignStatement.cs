using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000066 RID: 102
	public class AssignStatement : Statement
	{
		// Token: 0x06000305 RID: 773 RVA: 0x0000BB11 File Offset: 0x00009D11
		public AssignStatement(Reference target, Expression expression)
		{
			this.target = target;
			this.expression = expression;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000BB27 File Offset: 0x00009D27
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.target.OwnerReference, gen);
			this.expression.Emit(member, gen);
			this.target.StoreReference(gen);
		}

		// Token: 0x040000CD RID: 205
		private readonly Expression expression;

		// Token: 0x040000CE RID: 206
		private readonly Reference target;
	}
}
