using System;
using System.Reflection;

namespace Castle.DynamicProxy.Generators.Emitters
{
	// Token: 0x02000055 RID: 85
	public interface IMemberEmitter
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002B1 RID: 689
		MemberInfo Member { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002B2 RID: 690
		Type ReturnType { get; }

		// Token: 0x060002B3 RID: 691
		void EnsureValidCodeBlock();

		// Token: 0x060002B4 RID: 692
		void Generate();
	}
}
