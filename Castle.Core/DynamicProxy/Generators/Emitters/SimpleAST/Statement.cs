using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000087 RID: 135
	public abstract class Statement : IILEmitter
	{
		// Token: 0x06000376 RID: 886
		public abstract void Emit(IMemberEmitter member, ILGenerator gen);
	}
}
