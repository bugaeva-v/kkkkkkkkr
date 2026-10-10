using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000072 RID: 114
	public class FinallyStatement : Statement
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0000C265 File Offset: 0x0000A465
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.BeginFinallyBlock();
		}
	}
}
