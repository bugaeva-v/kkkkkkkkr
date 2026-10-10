using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000076 RID: 118
	public class LiteralIntExpression : Expression
	{
		// Token: 0x06000339 RID: 825 RVA: 0x0000C3E4 File Offset: 0x0000A5E4
		public LiteralIntExpression(int value)
		{
			this.value = value;
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			switch (this.value)
			{
			case -1:
				gen.Emit(OpCodes.Ldc_I4_M1);
				return;
			case 0:
				gen.Emit(OpCodes.Ldc_I4_0);
				return;
			case 1:
				gen.Emit(OpCodes.Ldc_I4_1);
				return;
			case 2:
				gen.Emit(OpCodes.Ldc_I4_2);
				return;
			case 3:
				gen.Emit(OpCodes.Ldc_I4_3);
				return;
			case 4:
				gen.Emit(OpCodes.Ldc_I4_4);
				return;
			case 5:
				gen.Emit(OpCodes.Ldc_I4_5);
				return;
			case 6:
				gen.Emit(OpCodes.Ldc_I4_6);
				return;
			case 7:
				gen.Emit(OpCodes.Ldc_I4_7);
				return;
			case 8:
				gen.Emit(OpCodes.Ldc_I4_8);
				return;
			default:
				gen.Emit(OpCodes.Ldc_I4, this.value);
				return;
			}
		}

		// Token: 0x040000E4 RID: 228
		private readonly int value;
	}
}
