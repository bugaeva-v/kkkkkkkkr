using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x0200006F RID: 111
	public abstract class Expression : IILEmitter
	{
		// Token: 0x06000322 RID: 802
		public abstract void Emit(IMemberEmitter member, ILGenerator gen);
	}
}
