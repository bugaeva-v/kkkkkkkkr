using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200007D RID: 125
	public class NewArrayExpression : Expression
	{
		// Token: 0x06000353 RID: 851 RVA: 0x0000C79B File Offset: 0x0000A99B
		public NewArrayExpression(int size, Type arrayType)
		{
			this.size = size;
			this.arrayType = arrayType;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000C7B1 File Offset: 0x0000A9B1
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldc_I4, this.size);
			gen.Emit(OpCodes.Newarr, this.arrayType);
		}

		// Token: 0x040000F2 RID: 242
		private readonly Type arrayType;

		// Token: 0x040000F3 RID: 243
		private readonly int size;
	}
}
