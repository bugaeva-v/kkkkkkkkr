using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006E RID: 110
	public class EndExceptionBlockStatement : Statement
	{
		// Token: 0x06000320 RID: 800 RVA: 0x0000C141 File Offset: 0x0000A341
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.EndExceptionBlock();
		}
	}
}
