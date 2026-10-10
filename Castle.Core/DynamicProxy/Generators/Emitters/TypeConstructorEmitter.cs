using System;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000061 RID: 97
	public class TypeConstructorEmitter : ConstructorEmitter
	{
		// Token: 0x060002F6 RID: 758 RVA: 0x0000B94A File Offset: 0x00009B4A
		internal TypeConstructorEmitter(AbstractTypeEmitter maintype) : base(maintype, maintype.TypeBuilder.DefineTypeInitializer())
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000B95E File Offset: 0x00009B5E
		public override void EnsureValidCodeBlock()
		{
			if (this.CodeBuilder.IsEmpty)
			{
				this.CodeBuilder.AddStatement(new ReturnStatement());
			}
		}
	}
}
