using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000078 RID: 120
	public class LoadRefArrayElementExpression : Expression
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0000C520 File Offset: 0x0000A720
		public LoadRefArrayElementExpression(int index, Reference arrayReference) : this(new ConstReference(index), arrayReference)
		{
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000C534 File Offset: 0x0000A734
		public LoadRefArrayElementExpression(ConstReference index, Reference arrayReference)
		{
			this.index = index;
			this.arrayReference = arrayReference;
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000C54A File Offset: 0x0000A74A
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.arrayReference, gen);
			ArgumentsUtil.EmitLoadOwnerAndReference(this.index, gen);
			gen.Emit(OpCodes.Ldelem_Ref);
		}

		// Token: 0x040000E8 RID: 232
		private readonly Reference arrayReference;

		// Token: 0x040000E9 RID: 233
		private readonly ConstReference index;
	}
}
