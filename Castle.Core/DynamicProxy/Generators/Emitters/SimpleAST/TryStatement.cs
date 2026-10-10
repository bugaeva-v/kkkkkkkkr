using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000089 RID: 137
	public class TryStatement : Statement
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0000CC09 File Offset: 0x0000AE09
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.BeginExceptionBlock();
		}
	}
}
