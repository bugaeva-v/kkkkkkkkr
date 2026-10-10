using System;
using System.Reflection.Emit;

namespace Castle.DynamicProxy.Generators.Emitters.SimpleAST
{
	// Token: 0x02000074 RID: 116
	public interface IILEmitter
	{
		// Token: 0x06000332 RID: 818
		void Emit(IMemberEmitter member, ILGenerator gen);
	}
}
