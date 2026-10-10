using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007F RID: 127
	public class NopStatement : Statement
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000C883 File Offset: 0x0000AA83
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Nop);
		}
	}
}
