using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000065 RID: 101
	public class AssignArrayStatement : Statement
	{
		// Token: 0x06000303 RID: 771 RVA: 0x0000BABD File Offset: 0x00009CBD
		public AssignArrayStatement(Reference targetArray, int targetPosition, Expression value)
		{
			this.targetArray = targetArray;
			this.targetPosition = targetPosition;
			this.value = value;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000BADA File Offset: 0x00009CDA
		public override void Emit(IMemberEmitter member, ILGenerator il)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.targetArray, il);
			il.Emit(OpCodes.Ldc_I4, this.targetPosition);
			this.value.Emit(member, il);
			il.Emit(OpCodes.Stelem_Ref);
		}

		// Token: 0x040000CA RID: 202
		private readonly Reference targetArray;

		// Token: 0x040000CB RID: 203
		private readonly int targetPosition;

		// Token: 0x040000CC RID: 204
		private readonly Expression value;
	}
}
