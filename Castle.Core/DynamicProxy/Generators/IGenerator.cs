using System;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Generators
{
	// Token: 0x02000038 RID: 56
	public interface IGenerator<T>
	{
		// Token: 0x060001C2 RID: 450
		T Generate(ClassEmitter @class, ProxyGenerationOptions options, INamingScope namingScope);
	}
}
