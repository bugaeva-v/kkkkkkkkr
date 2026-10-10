using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000062 RID: 98
	public class AddressOfReferenceExpression : Expression
	{
		// Token: 0x060002F8 RID: 760 RVA: 0x0000B97E File Offset: 0x00009B7E
		public AddressOfReferenceExpression(Reference reference)
		{
			this.reference = reference;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0000B98D File Offset: 0x00009B8D
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			ArgumentsUtil.EmitLoadOwnerAndReference(this.reference.OwnerReference, gen);
			this.reference.LoadAddressOfReference(gen);
		}

		// Token: 0x040000C6 RID: 198
		private readonly Reference reference;
	}
}
