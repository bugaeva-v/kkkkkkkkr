using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000081 RID: 129
	public class NullExpression : Expression
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000C923 File Offset: 0x0000AB23
		protected NullExpression()
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000C92B File Offset: 0x0000AB2B
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldnull);
		}

		// Token: 0x040000FA RID: 250
		public static readonly NullExpression Instance = new NullExpression();
	}
}
