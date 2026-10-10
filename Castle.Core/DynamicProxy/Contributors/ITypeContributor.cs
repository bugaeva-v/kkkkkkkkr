using System;
using Castle.DynamicProxy.Generators;
using Castle.DynamicProxy.Generators.Emitters;

namespace Castle.DynamicProxy.Contributors
{
	// Token: 0x020000A6 RID: 166
	public interface ITypeContributor
	{
		// Token: 0x060003FD RID: 1021
		void CollectElementsToProxy(IProxyGenerationHook hook, MetaType model);

		// Token: 0x060003FE RID: 1022
		void Generate(ClassEmitter @class, ProxyGenerationOptions options);
	}
}
