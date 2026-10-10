using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006B RID: 107
	public class ConstructorInvocationStatement : Statement
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0000BD4C File Offset: 0x00009F4C
		public ConstructorInvocationStatement(ConstructorInfo method, params Expression[] args)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
			if (args == null)
			{
				throw new ArgumentNullException("args");
			}
			this.cmethod = method;
			this.args = args;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000BD84 File Offset: 0x00009F84
		public override void Emit(IMemberEmitter member, ILGenerator gen)
		{
			gen.Emit(OpCodes.Ldarg_0);
			Expression[] array = this.args;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Emit(member, gen);
			}
			gen.Emit(OpCodes.Call, this.cmethod);
		}

		// Token: 0x040000D6 RID: 214
		private readonly Expression[] args;

		// Token: 0x040000D7 RID: 215
		private readonly ConstructorInfo cmethod;
	}
}
