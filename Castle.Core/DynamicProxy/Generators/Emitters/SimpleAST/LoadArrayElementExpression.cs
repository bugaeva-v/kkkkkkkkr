using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000077 RID: 119
	public class LoadArrayElementExpression : Expression
	{
		// Token: 0x0600033B RID: 827 RVA: 0x0000C4C3 File Offset: 0x0000A6C3
		public LoadArrayElementExpression(int index, Reference arrayReference, Type returnType) : this(new ConstReference(index), arrayReference, returnType)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		public LoadArrayElementExpression(ConstReference index, Reference arrayReference, Type returnType)
		{
			this.index = index;
			this.arrayReference = arrayReference;
			this.returnType = returnType;
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000C4F5 File Offset: 0x0000A6F5
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.arrayReference, gen);
			ArgumentsUtil.EmitLoadOwnerAndReference(this.index, gen);
			gen.Emit(OpCodes.Ldelem, this.returnType);
		}

		// Token: 0x040000E5 RID: 229
		private readonly Reference arrayReference;

		// Token: 0x040000E6 RID: 230
		private readonly ConstReference index;

		// Token: 0x040000E7 RID: 231
		private readonly Type returnType;
	}
}
