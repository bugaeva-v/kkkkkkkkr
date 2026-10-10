using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000083 RID: 131
	public class ReferenceExpression : Expression
	{
		// Token: 0x06000369 RID: 873 RVA: 0x0000C994 File Offset: 0x0000AB94
		public ReferenceExpression(Reference reference)
		{
			this.reference = reference;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000C9A3 File Offset: 0x0000ABA3
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.reference, gen);
		}

		// Token: 0x040000FC RID: 252
		private readonly Reference reference;
	}
}
